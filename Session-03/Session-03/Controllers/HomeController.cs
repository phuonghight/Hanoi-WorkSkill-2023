using Newtonsoft.Json;
using Session_03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Session_03.Controllers
{
    public class HomeController : Controller
    {
        private Model1 db = new Model1();

        public ActionResult Index()
        {
            var items = (from item in db.Items
                         join ip in db.ItemPrices on item.ID equals ip.ItemID
                         where item.Area.Name == "Seocho-gu" && ip.Date == new DateTime(2022, 11, 25)
                         select item).ToList();
            ViewBag.Area = "Seocho-gu";
            return View(items);
        }

        [HttpPost]
        public ActionResult Index(string area)
        {
            var items = (from item in db.Items
                         join ip in db.ItemPrices on item.ID equals ip.ItemID
                         where item.Area.Name.Contains(area) && ip.Date == new DateTime(2022, 11, 25)
                         select item).ToList();
            if (items.Count == 0)
            {
                return HttpNotFound();
            }
            ViewBag.Area = items.First().Area.Name;
            return View(items);
        }

        public ActionResult Detail(long id)
        {
            Item item = db.Items.Find(id);
            decimal price = 0;
            price = item.ItemPrices.Where(x => x.Date >= new DateTime(2022, 11, 25)).Sum(x => x.Price);
            ViewBag.Price = price;
            return View(item);
        }

        [HttpPost]
        public async Task<ActionResult> Payment(long id, decimal price, int capacity)
        {
            string api = "http://localhost:5000/Payment/";
            using (HttpClient client = new HttpClient())
            {
                var data = new
                {
                    customer = "John Doe",
                    orderId = id.ToString(),
                    price,
                    extraInfo = "capacity: " + capacity,
                    callBackUrl = Url.Action("PaymentResult", "Home", null, Request.Url.Scheme)
                };
                string jsonData = JsonConvert.SerializeObject(data);
                HttpContent content = new StringContent(jsonData, encoding: Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(api + "PaymentToken", content);
                if (response.IsSuccessStatusCode)
                {
                    string token = await response.Content.ReadAsStringAsync();
                    return Redirect(api + token);
                }
            }
            return View("Error");
        }

        public ActionResult PaymentResult()
        {
            string id = Request.QueryString["OrderId"];
            Item item = db.Items.Find(long.Parse(id));
            decimal price = decimal.Parse(Request.QueryString["Price"]);
            ViewBag.Price = price;
            ViewBag.Property = item.Title;
            Transaction transaction = new Transaction()
            {
                ID = db.Transactions.OrderByDescending(x => x.ID).First().ID,
                GUID = Guid.NewGuid(),
                Amount = price,
                GatewayReturnID = Request.QueryString["TrackId"],
                TransactionDate = new DateTime(2022, 11, 25),
                TransactionTypeID = 1,
                UserID = 3
            };
            db.Transactions.Add(transaction);
            db.SaveChanges();
            ViewBag.Transaction = transaction.ID;
            return View();
        }
    }
}