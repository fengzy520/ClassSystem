namespace Coursmanager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        public int Id { get; set; }

        [StringLength(10)]

        [Display(Name = "ÐÕÃû")]
        public string Name { get; set; }
        public int? ClassId { get; set; }
    }
}
