namespace KimTravel.Service.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrintTour")]
    public partial class PrintTour
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PrintTour()
        {
            DetailPrintTours = new HashSet<DetailPrintTour>();
        }

        public int ID { get; set; }

        public int? OrganizationID { get; set; }

        public int? TourID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateStart { get; set; }

        public int? Guide1 { get; set; }

        [StringLength(32)]
        public string Guide2 { get; set; }

        public int? Driver1 { get; set; }

        [StringLength(32)]
        public string Driver2 { get; set; }

        [StringLength(16)]
        public string CarCode { get; set; }

        public DateTime? DatePrint { get; set; }

        public double? TotalPax { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailPrintTour> DetailPrintTours { get; set; }
    }
}
