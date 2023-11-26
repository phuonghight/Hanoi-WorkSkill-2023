namespace Session_03.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DimDate
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public int Year { get; set; }

        public int Quarter { get; set; }

        public int Month { get; set; }

        [Required]
        [StringLength(10)]
        public string MonthName { get; set; }

        public int DayOfMonth { get; set; }

        public int DayOfWeek { get; set; }

        [Required]
        [StringLength(10)]
        public string DayName { get; set; }

        public bool isHoliday { get; set; }
    }
}
