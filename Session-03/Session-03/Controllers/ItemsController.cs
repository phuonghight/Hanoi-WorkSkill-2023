using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Razor.Tokenizer.Symbols;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using Session_03.Models;

namespace Session_03.Controllers
{
    public class ItemsController : Controller
    {
        private Model1 db = new Model1();

        // GET: Items
        public ActionResult Index()
        {
            string area = "Seocho-gu";
            int nights = 1;
            var items = db.Items.Where(i => i.Area.Name.Contains(area));
            ViewBag.Area = area;
            ViewBag.Nights = nights;
            return View(items.ToList());
        }

        [HttpPost]
        public ActionResult Index(string area)
        {
            string keyword;
            if(string.IsNullOrEmpty(area)) keyword = "Seocho-gu"; 
            else keyword = area;
            int nights = 1;
            var items = db.Items.Where(i => i.Area.Name.Contains(keyword));
            ViewBag.Area = keyword;
            ViewBag.Nights = nights;
            return View(items.ToList());
        }

        // GET: Items/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            decimal price = item.ItemPrices.Count > 0 ? item.ItemPrices.First().Price : 0;
            ViewBag.Price = price;
            return View(item);
        }

        [HttpPost]
        public async Task<ActionResult> Details(long id, decimal price, int capacity)
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = "http://localhost:5000/Payment/";
                var data = new
                {
                    customer = "John Doe",
                    orderId = id.ToString(),
                    price = price * capacity,
                    extraInfo = capacity.ToString(),
                    callBackUrl = Url.Action("PaymentResult", "Items", null, Request.Url.Scheme)
                };
                string jsonData = JsonConvert.SerializeObject(data);
                HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(apiUrl + "PaymentToken", content);
                if (response.IsSuccessStatusCode)
                {
                    string apiData = await response.Content.ReadAsStringAsync();
                    return Redirect(apiUrl + apiData);
                }
                else
                {
                    return View("Error");
                }
            }
        }

        public ActionResult PaymentResult()
        {
            string status = Request.QueryString["status"];
            string id = Request.QueryString["OrderId"];
            string price = Request.QueryString["Price"];
            if (status == "success")
            {
                Item item = db.Items.Find(long.Parse(id));
                ViewBag.TransactionId = id;
                ViewBag.Price = price;
                ViewBag.PropertyTitle = item.Title;
            }
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
