using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buddyConnect.Portable
{
    public class UriStrings
    {
        const string hostm = "http://www.graylogictech.com/glt_cs/BuddyTrackerWebservice.asmx/";

        public string authenticate( string userid, string password, string lat, string log)
        {
            if (string.IsNullOrWhiteSpace(lat))
                lat = string.Empty;
            if (string.IsNullOrWhiteSpace(log))
                log = string.Empty;
            string s = hostm + "authenticate?userid=" + userid + "&pwd=" + password + "&lat=" + lat + "&log=" + log;
            return s;
        }
    }
}
