using CaptchaMvc.HtmlHelpers;
using System.Web.Mvc;
using System.Web.UI.WebControls;

public class TechController : Controller
{
    // GET: Tech
    public ActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Index(Login objLogin)
    {
        if (!this.IsCaptchaValid(errorText: ""))
        {
            ViewBag.ErrorMessage = "Captcha is not valid";
            return View("Index", new WebAppfinalMvcMarch3.Models.Logins());
        }

        
        return RedirectToAction("Dashboard");
    }

  
    public ActionResult Dashboard()
    {
        return View();
    }
}









