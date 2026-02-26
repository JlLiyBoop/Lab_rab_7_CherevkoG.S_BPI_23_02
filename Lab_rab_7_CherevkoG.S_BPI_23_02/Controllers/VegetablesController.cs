using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Lab_rab_7_CherevkoG.S_BPI_23_02.Models;

namespace Lab_rab_7_CherevkoG.S_BPI_23_02.Controllers
{
    public class VegetablesController : Controller
    {
        private List<Vegetable> GetVegetables()
        {
            return new List<Vegetable>
            {
                new Vegetable { Id = 1, Name = "Картофель" },
                new Vegetable { Id = 2, Name = "Морковь" },
                new Vegetable { Id = 3, Name = "Лук" },
                new Vegetable { Id = 4, Name = "Капуста" },
                new Vegetable { Id = 5, Name = "Свекла" }
            };
        }

        public IActionResult FirstViewMethod()
        {
            var veggies = GetVegetables();
            return View(veggies);
        }

        public IActionResult SecondViewMethod()
        {
            var sortedVeggies = GetVegetables().OrderBy(v => v.Name).ToList();
            return View(sortedVeggies);
        }

        public IActionResult ThirdViewMethod()
        {
            var groupedVeggies = GetVegetables().GroupBy(v => v.Name.Substring(0, 1)).ToList();
            return View(groupedVeggies);
        }
    }
}