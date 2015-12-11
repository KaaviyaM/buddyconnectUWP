using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buddyConnect.Portable.Models
{
    public class signUpDatum
    {
        public string result { get; set; }
        public string output { get; set; }
    }

    public class SignUpModel
    {
        public List<signUpDatum> data { get; set; }
    }
}
