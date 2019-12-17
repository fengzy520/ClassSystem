using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Coursmanager.Models
{
    public partial class Student
    {
        [Display(Name = "班级名称")]
        public string ClassName
        {
            get
            {
                if (!ClassId.HasValue)
                {
                    return "";
                }
                CourseManagerContext db = new CourseManagerContext();
                var classe = db.Classes.Where(t => t.Id == ClassId.Value).FirstOrDefault();
                if (classe == null)
                {
                    return "";
                }
                return classe.Name;
            }
        }
    }
}