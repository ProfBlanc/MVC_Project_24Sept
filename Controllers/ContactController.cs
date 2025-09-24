using Microsoft.AspNetCore.Mvc;
using WebApplication4MVC.Models;

namespace WebApplication4MVC.Controllers
{
    public class ContactController : Controller
    {

        //OnGet() => GET request
        //OnPost() => Post request

        /*
         *  method overloading
         *      create multiple methods with same name
         *      HOWEVER, the parameters must be different
         *          what params? num of params and data type ordering of params
         * 
         * 
         *  public static void MyMethod(int n1){}
         *  public static void MyMethod(int n1, double n2){}
         *  public static void MyMethod(int double n1, int n2){}
         * 
         * 
         * NOT GOOD: public void MyMethod(int hello, double world)
         * 
         * 
         * public static void Main(string[] args){
         * 
         *      MyMethod(n1: 10)
         * }
         * 
         */


        [HttpGet]
        public IActionResult Index()
        {

            return View(model: new ContactFormModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(ContactFormModel model)
        {
            if(ModelState.IsValid) {
                TempData["Message"] = "You have successfully submitted the Contact form";
                //save to file, send to admin, save to db (later)
                ModelState.Clear();
                model = new ContactFormModel();
            }


            return View(model: model);
        }


    }
}
