namespace Coursmanager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Teacher")]
    public partial class Teacher
    {
        public int Id { get; set; }

        [StringLength(10)]
        [Display(Name = "ΩÃ ¶–’√˚")]
        public string Name { get; set; }
        public int? TeacherId { get; set; }
    }
}
