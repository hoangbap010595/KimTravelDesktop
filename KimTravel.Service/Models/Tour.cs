namespace KimTravel.Service.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tour")]
    public partial class Tour
    {
        public int TourID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? GroupID { get; set; }

        public DateTime? DateCreate { get; set; }

        public bool? Enable { get; set; }

        public int? Type { get; set; }

        public int? Priority { get; set; }

        public int? PriceSale { get; set; }

        public int? PriceVTQ { get; set; }

        public int? PriceSaleChild { get; set; }

        public int? MinPax { get; set; }

        public int? MaxPax { get; set; }

        public virtual GroupTour GroupTour { get; set; }
    }
}
