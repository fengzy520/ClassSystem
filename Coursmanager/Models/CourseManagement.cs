namespace Coursmanager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CourseManagement")]
    public partial class CourseManagement
    {
        public int Id { get; set; }

        public int? ClassId { get; set; }

        public int? TeacherId { get; set; }

        public int? CourseId { get; set; }
    }
}
