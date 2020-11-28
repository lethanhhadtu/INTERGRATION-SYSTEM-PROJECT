namespace HRWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        public int id { get; set; }

        [Required]
        [StringLength(30)]
        public string userName { get; set; }

        [Required]
        [StringLength(30)]
        public string password { get; set; }
    }
}
