using Coursmanager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coursmanager.BLLs.Classes
{
    public class ClassRepository:IClassRepository
    {
        protected CourseManagerContext db = new CourseManagerContext();
        public List<CourseDatail> GetClassCourse(int id)
        {
            var query = from cm in db.CourseManagement
                        join c in db.Classes
                            on cm.ClassId equals c.Id
                        join cr in db.Course
                            on cm.ClassId equals cr.Id
                        join t in db.Teacher
                            on cm.ClassId equals t.Id
                        where cm.ClassId == id
                        select new CourseDatail
                        {
                            ClassName = c.Name,
                            CourseName = cr.Name,
                            TeacherName = t.Name
                        };
            return query.ToList();
        }
    }
}