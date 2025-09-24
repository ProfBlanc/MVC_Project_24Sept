using Microsoft.AspNetCore.Mvc;
using WebApplication4MVC.Models;

namespace WebApplication4MVC.Controllers
{
    public class ProfileController : Controller
    {

        public List<ProfileModel> Profiles { get; set; }

        public ProfileController() {

            Profiles = new List<ProfileModel> { 
            new ProfileModel{ Id = 1, Name="Ben", Age=20},
            new ProfileModel{ Id = 2, Name="John", Age=21},
            new ProfileModel{ Id = 3, Name="Mary", Age=22},
            new ProfileModel{ Id = 4, Name="Ashley", Age=23},
            new ProfileModel{ Id = 5, Name="Danny", Age=24},
            };
        
        }


        public IActionResult Index()
        {
            return View(model: Profiles);
        }
        public IActionResult Create()
        {
            return View(model: new ProfileModel());
        }
        public IActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Submit(ProfileModel model)
        {
            return RedirectToAction("Index");  //redirects to a method
        }
        public IActionResult View()
        {
            return View();
        }



    }
}
