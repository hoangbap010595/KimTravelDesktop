namespace KimTravel.Service.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DetailPrintTour")]
    public partial class DetailPrintTour
    {
        public int ID { get; set; }

        public int? PrintID { get; set; }

        public int? BookID { get; set; }

        public DateTime? Date { get; set; }

        public virtual PrintTour PrintTour { get; set; }
    }
}
