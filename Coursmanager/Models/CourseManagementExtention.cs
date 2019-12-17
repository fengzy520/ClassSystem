using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Coursmanager.Models
{
    public partial class CourseManagement
    {
        [Display(Name = "教师姓名")]
        public string TeacherName
        {
            get
            {
                if (!TeacherId.HasValue)
                {
                    return "";
                }
                CourseManagerContext db = new CourseManagerContext();
                var teacher = db.Teacher.Where(t => t.Id == TeacherId.Value).FirstOrDefault();
                if (teacher == null)
                {
                    return "";
                }
                return teacher.Name;
            }
        }
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
        [Display(Name = "科目名称")]
        public string CourseName
        {
            get
            {
                if (!CourseId.HasValue)
                {
                    return "";
                }
                CourseManagerContext db = new CourseManagerContext();
                var course = db.Course.Where(t => t.Id == CourseId.Value).FirstOrDefault();
                if (course == null)
                {
                    return "";
                }
                return course.Name;
            }
        }
    }
}