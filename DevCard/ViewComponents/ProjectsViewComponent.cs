using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DevCard.Models;

namespace DevCard.ViewComponents
{
    public class ProjectsViewComponent:ViewComponent
    {
        private readonly List<DevCard.Models.Project> projects = new List<DevCard.Models.Project>();
        public IViewComponentResult Invoke(string s)
        {
            projects.Add(new Project("Taxi", "تاکسی انلاین", "Yas", "taxi.jpg"));
            projects.Add(new Project("ZoodFood", "سفارش انلاین غذا", "Yas", "food.jpg"));
            projects.Add(new Project("HumabResource", "مدیریت منابع انسانی", "Yas", "humanresource.png"));
            projects.Add(new Project("Turn", "نوبت انلاین", "Yas", "turn.png"));
            return View("_Projects",projects);
        }
    }
}
