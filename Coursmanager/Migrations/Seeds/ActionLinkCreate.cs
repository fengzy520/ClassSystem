using Coursmanager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coursmanager.Migrations.Seeds
{
    public class ActionLinkCreate
    {
        private readonly Coursmanager.Models.CourseManagerContext _context;
        public ActionLinkCreate(Coursmanager.Models.CourseManagerContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            var initialActionLinks = new List<ActionLink>
            {
                new ActionLink
                {
                    Name="主页",
                    Controller="Home",
                    Action="Index"
                }
            };
            foreach (var action in initialActionLinks)
            {
                if(_context.ActionLink.Any(r=>r.Name==action.Name))
                {
                    continue;
                }
                _context.ActionLink.Add(action);
            }
            _context.SaveChanges();
        }
    }
}