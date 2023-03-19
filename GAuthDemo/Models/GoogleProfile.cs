using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GAuthDemo.Models
{
    public class GoogleProfile
    {
        public String Id {  get; set; }
        public String Name {  get; set; }
        public String Picture {  get; set; }
        public String Email {  get; set; }
        public String Verified_Email {  get; set; }
        public String MobilePhone {  get; set; }
        public String Locale {  get; set; }
    }
}