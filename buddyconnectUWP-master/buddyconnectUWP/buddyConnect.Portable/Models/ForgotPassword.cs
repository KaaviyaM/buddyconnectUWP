using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buddyConnect.Portable.Models
{
    public class forgotPasswordDatum
    {
        public string result { get; set; }
        public string output { get; set; }
    }

    public class ForgotPasswordModel
    {
        public List<forgotPasswordDatum> data { get; set; }
    }
}
