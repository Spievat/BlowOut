using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public String Index()
        {
            return "Please call Support at <strong><u>801-555-1212</u></strong>. Thank you!";
        }

        public String Email(String name, String email)
        {
            if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(email) == false)
            {
                return "Thank you. We will send you an email at " + email;
            }
            else if (string.IsNullOrEmpty(name) == false && string.IsNullOrEmpty(email) == false)
            {
                return "Thank you " + name + ". We will send you an email at " + email;
            }
            else if (string.IsNullOrEmpty(name) == false && string.IsNullOrEmpty(email))
            {
                return "Thank you " + name + ". Please send us an email.";
            }
            else
            {
                return "Please call Support at <strong><u>801-555-1212</u></strong>. Thank you!";
            }
        }

    }
}