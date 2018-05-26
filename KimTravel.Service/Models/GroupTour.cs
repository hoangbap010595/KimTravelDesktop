namespace KimTravel.Service.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GroupTour")]
    public partial class GroupTour
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GroupTour()
        {
            Tours = new HashSet<Tour>();
        }

        [Key]
        public int GroupID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public DateTime? DateCreate { get; set; }

        public int? MinPax { get; set; }

        public int? MaxPax { get; set; }

        public bool? Enable { get; set; }

        public int? Type { get; set; }

        [StringLength(500)]
        public string Note { get; set; }

        public int? Priority { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tour> Tours { get; set; }
    }
}
