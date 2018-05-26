namespace KimTravel.Service.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        public int ID { get; set; }

        public int? TourID { get; set; }

        public int? PartnerID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        public double? Pax { get; set; }

        [StringLength(50)]
        public string PickUp { get; set; }

        [StringLength(50)]
        public string Room { get; set; }

        [StringLength(50)]
        public string CustomName { get; set; }

        public int? PartnerPrice { get; set; }

        public int? PriceReceive { get; set; }

        public int? PriceSale { get; set; }

        public int? PriceVTQ { get; set; }

        public int? PromotionMoney { get; set; }

        public int? PromotionPercent { get; set; }

        [StringLength(50)]
        public string StaffID { get; set; }

        public DateTime? DateCreate { get; set; }

        [StringLength(200)]
        public string Note { get; set; }

        public string ServiceType { get; set; }

        public int? Total { get; set; }

        public bool? IsCancel { get; set; }

        [StringLength(50)]
        public string CreateBy { get; set; }

        public DateTime? LastUpdate { get; set; }

        [StringLength(50)]
        public string UpdateBy { get; set; }

        public bool? IsBooked { get; set; }

        public DateTime? FinishDate { get; set; }

        public bool? IsPayment { get; set; }

        public DateTime? DatePayment { get; set; }

        public string ServiceName { get; set; }

        public double? PaxChild { get; set; }

        public int? PriceReChild { get; set; }

        public bool? IsDone { get; set; }

        [StringLength(50)]
        public string DoneBy { get; set; }
    }
}
