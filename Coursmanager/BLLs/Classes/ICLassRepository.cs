using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursmanager.BLLs.Classes
{
    interface IClassRepository
    {
        List<CourseDatail> GetClassCourse(int id);
    }
}
