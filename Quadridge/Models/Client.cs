namespace Quadridge.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            ClientInteractions = new HashSet<ClientInteraction>();
        }

        public int ClientId { get; set; }

        [Required]
        [StringLength(100)]
        public string Firstname { get; set; }

        [Required]
        [StringLength(100)]
        public string Surname { get; set; }

        public int? CompanyId { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        [Required]
        [StringLength(10)]
        public string CellNo { get; set; }

        [StringLength(10)]
        public string BusinessNo { get; set; }

        [Required]
        [StringLength(255)]
        public string FirstAddressLine { get; set; }

        [StringLength(255)]
        public string SecondAddressLine { get; set; }

        [Required]
        [StringLength(100)]
        public string City { get; set; }

        [StringLength(8)]
        public string Zip { get; set; }

        [StringLength(100)]
        public string Province { get; set; }

        [Required]
        [StringLength(100)]
        public string Country { get; set; }

        public virtual Company Company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientInteraction> ClientInteractions { get; set; }
    }
}
