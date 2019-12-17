using Coursmanager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coursmanager.Migrations.Seeds
{
    public class SideBarCreate
    {
        private readonly Coursmanager.Models.CourseManagerContext _context;
        public SideBarCreate(Coursmanager.Models.CourseManagerContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            var initialSideBar = new List<Sidebar>
            {
                new Sidebar
                {
                    Name="班级管理",
                    Controller="Classes",
                    Action="Index"
                },
                new Sidebar
                {
                    Name="教师管理",
                    Controller="Teachers",
                    Action="Index"
                },new Sidebar
                {
                    Name="学生管理",
                    Controller="Studebts",
                    Action="Index"
                },new Sidebar
                {
                    Name="课程科目管理",
                    Controller="Courses",
                    Action="Index"
                },new Sidebar
                {
                    Name="课程安排",
                    Controller="CoursesManadements",
                    Action="Index"
                },new Sidebar
                {
                    Name="顶部导航栏管理",
                    Controller="ActionLinks",
                    Action="Index"
                },new Sidebar
                {
                    Name="左侧导航栏管理",
                    Controller="Sidebars",
                    Action="Index"
                },
            };
            foreach (var bar in initialSideBar)
            {
                if (_context.Sidebar.Any(r => r.Name == bar.Name))
                {
                    continue;
                }
                _context.Sidebar.Add(bar);
            }
            _context.SaveChanges();
        }
    }
}