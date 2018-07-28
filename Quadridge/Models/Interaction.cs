namespace Quadridge
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Interaction")]
    public partial class Interaction
    {
        public int InteractionId { get; set; }

        [Required]
        [StringLength(255)]
        public string InteractionType { get; set; }
    }
}
