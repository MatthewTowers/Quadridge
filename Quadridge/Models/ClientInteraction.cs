namespace Quadridge
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClientInteraction")]
    public partial class ClientInteraction
    {
        [Key]
        public int ClientInterationId { get; set; }

        public int ClientId { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [StringLength(2000)]
        public string Comment { get; set; }

        public int Type { get; set; }

        public virtual Client Client { get; set; }
    }
}
