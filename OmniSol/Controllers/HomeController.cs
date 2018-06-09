using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace OmniSol.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.title = "OmniSol";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.title = "About - OmniSol";

            return View();
        }
        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.title = "Contact - OmniSol";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string Name,string Email,string Phone,string Subject,string Message)
        {
            

            return View();
        }

        public ActionResult Portfolio()
        {
            ViewBag.title = "Portfolio - OmniSol";
            return View();
        }

     

        [HttpGet]
        public ActionResult Services(string id)
        {
            ViewBag.title = "Services - OmniSol";
            if (id == null)
            {
                return View();
            }
            else
            {
                return View(id);
            }
        }


        public int message(string Name, string Email, string Phone, string Subject, string Message)
        {


            MailMessage EmailObject = new MailMessage();
            EmailObject.From = new MailAddress("fahadsherwani01@gmail.com", "Order");
            EmailObject.To.Add(new MailAddress("fahadsherwani01@gmail.com", "samba123"));

            EmailObject.Subject = "Message";
            //EmailObject.Body = "<h1>this is body of the email</h1>";
            EmailObject.IsBodyHtml = true;
            string body = "Name:   " + Name + "  Email:    " + Email + "Phone     " + Phone + "  Subject       " + Subject + "Message      " + Message;

           
            EmailObject.Body = body;
            //SmtpClient SC = new SmtpClient("smtpout.asia.secureserver.net", 3535);
            //SC.Credentials = new System.Net.NetworkCredential("info@dojawsports.com", "tuDcJSMQB2DZ");

            SmtpClient SC = new SmtpClient("smtpout.secureserver.net", 3535);
            SC.Credentials = new System.Net.NetworkCredential("info@omnisolutions.org", "Samba@123");
            
            SC.Send(EmailObject);



            return 1;
        }

    }
}