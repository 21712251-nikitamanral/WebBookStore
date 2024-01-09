using Microsoft.AspNetCore.Mvc;

namespace WebBookStore.Controllers
{
    public class HomeController : Controller
    {
        // It is use for print data  without views 

        //public string Index()
        //{
        //    return "BookStore";
        //}


        //It is use for print data with views 

        public ViewResult Index()
        {
            //var obj = new { id = 1, name = "Nikita" };
            //return View("AboutUs",obj);

            //return View("TempViews/NikitaTemp.cshtml");
            //we ca also write this

            //return View("../../TempViews/NikitaTemp");
            return View();
        }
        public ViewResult AboutUs()
        {
            return View();
        }

        //we can use shared folder for views for comman action method
        //we can onlu use shared folder we cant use other name folder in shared place and all this returnn in razor viewEngin.
        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
