using buddyConnect.Portable.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using buddyConnect.Portable.Services;
using System.Xml.Serialization;
using System.IO;
using Newtonsoft.Json;
using System.Net.Http;

namespace buddyConnect.Portable.ViewModels.HomeViewModels
{
    //public class BuddiesViewModel : BaseViewModel
    //{
    //    UriStrings url= new UriStrings();
    //    List<loginDatum> loginDatumObj;
    //    private ObservableCollection<loginDatum> buddiesOC = new ObservableCollection<loginDatum>();
    //    public ObservableCollection<loginDatum> BuddiesOC
    //    {
    //        get { return buddiesOC; }
    //        set
    //        {
    //            buddiesOC = value;
    //            RaisePropertyChanged();
    //        }
    //    }

    //    public override async void LoadState(object navParameter, Dictionary<string, object> state)
    //    {
    //        base.LoadState(navParameter, state);
    //        if (!BuddiesOC.Any())
    //        {
    //            HttpService http = new HttpService();
    //            string response = await http.GetAsync(url.authenticate("sairam", "1234", " ", " "));
    //            XmlSerializer x = new XmlSerializer(typeof(XmlModel));
    //            XmlModel myTest = (XmlModel)x.Deserialize(new StringReader(response));
    //            string res = myTest.Text;
    //            loginDatumObj = JsonConvert.DeserializeObject<List<loginDatum>>(res);
    //            ObservableCollection<loginDatum> BuddiesOC = new ObservableCollection<loginDatum>(loginDatumObj);
    //        }
    //    }
    //}


    public class BuddiesViewModel : BaseViewModel
    {
        private HttpClient httpClient;
        private HttpResponseMessage responseMes;
        LoginModel loginObj;

        private ObservableCollection<loginDatum> loginCO = new ObservableCollection<loginDatum>();
        private string responseBodyAsText;

        public ObservableCollection<loginDatum> LoginCO
        {
            get { return loginCO; }
            set
            {
                loginCO = value;
                RaisePropertyChanged();
            }
        }

        protected override void LoadDesignTimeData()
        {
            base.LoadDesignTimeData();
        }



        #region State Management

        public async override void LoadState(object navParameter, Dictionary<string, object> state)
        {
            base.LoadState(navParameter, state);
            httpClient = new HttpClient();
            if (!LoginCO.Any())
            {
                string getLogin = "http://www.graylogictech.com/glt_cs/BuddyTrackerWebservice.asmx/authenticate?userid=sairam&pwd=1234&lat=&log=";
                try
                {
                    responseMes = await httpClient.GetAsync(getLogin);

                    responseMes.EnsureSuccessStatusCode();

                    responseBodyAsText = await responseMes.Content.ReadAsStringAsync();

                }
                catch (Exception ex)
                {
                    // Need to convert int HResult to hex string
                }

                XmlSerializer x = new XmlSerializer(typeof(XmlModel));
                XmlModel myTest = (XmlModel)x.Deserialize(new StringReader(responseBodyAsText));
                string res = myTest.Text;
                loginObj = JsonConvert.DeserializeObject<LoginModel>(res);
                loginCO.Add(loginObj.data[0]);
            }
        }


       
        public override void SaveState(Dictionary<string, object> state)
        {
            base.SaveState(state);

        }

        #endregion

    }
}
