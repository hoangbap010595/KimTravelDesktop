namespace KimTravel.Service.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Price")]
    public partial class Price
    {
        [Key]
        public int Key { get; set; }

        public int? GroupID { get; set; }

        public int? TourID { get; set; }

        public int? PriceRe { get; set; }

        public int? PriceReChild { get; set; }

        public int? PriceVTQ { get; set; }
    }
}
