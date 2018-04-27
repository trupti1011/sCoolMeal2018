using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sCoolMeal2018.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
           

            return View();
        }

        public ActionResult Contact()
        {
          
            return View();
        }

        public ActionResult FAQ()
        {
            return View();
        }

        public ActionResult ContactUs()
        {

            return View();
        }

        //[HttpPost]
        //public JsonResult ContactUsEvent(string name, string email, string Phone, string mssg)
        //{
        //    string returnmsg = "";
        //    System.Net.Mail.MailMessage msz = new System.Net.Mail.MailMessage();
        //    msz.From = new MailAddress(email);//Email which you are getting 
        //    msz.To.Add("bhavana@scoolmeal.com");
        //    msz.To.Add("sukanya@scoolmeal.com");//Where mail will be sent 
        //    msz.Subject = "From event form";
        //    msz.Body = mssg;
        //    msz.Body = msz.Body + "<br/><br/>" + "<strong>Senders Name:<strong/>" + name;
        //    msz.Body = msz.Body + "<br/><br/>" + "<strong>Senders Phone:<strong/>" + Phone;
        //    msz.Body = msz.Body + "<br/><br/>" + "<strong>Senders Email:<strong/>" + email;
        //    msz.IsBodyHtml = true;
        //    SmtpClient smtp = new SmtpClient();
        //    smtp.Host = "smtp.gmail.com";
        //    smtp.Port = 587;
        //    smtp.UseDefaultCredentials = false;
        //    smtp.Credentials = new System.Net.NetworkCredential("scoolmeal@gmail.com", "ignite15");
        //    smtp.EnableSsl = true;
        //    smtp.Send(msz);
        //    returnmsg = "Your message has been sent. One of us will get in touch with you shortly";
        //    return Json(returnmsg, JsonRequestBehavior.AllowGet);
        //}
       
        public ActionResult WhySubscribe()
        {

            return View();
        }

        

        public ActionResult Events()
        {
            return View();
        }
       

       
      

    }
}