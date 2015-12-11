using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buddyConnect.Portable.Models.HomeModels
{
    public class buddiesHomeDatum
    {
        public string result { get; set; }
        public string output { get; set; }
        public string sno { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string age { get; set; }
        public string createddate { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string status { get; set; }
        public string email { get; set; }
        public string profile_imgurl { get; set; }
        public string gender { get; set; }
    }

    public class BuddiesHomeModel
    {
        public List<buddiesHomeDatum> data { get; set; }
    }
}
