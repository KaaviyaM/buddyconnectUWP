using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace buddyConnect.Portable.Models.HomeModels
{
    public class chatsHomeDatum : INotifyPropertyChanged
    {
        private string Result;
        public string result
        {
            get { return Result; }
            set
            {
                Result = value;
                OnPropertyChanged("result");
            }
        }

        private string Output;
        public string output
        {
            get { return Output; }
            set
            {
                Output = value;
                OnPropertyChanged("output");
            }
        }


        private string Sno;
        public string sno
        {
            get { return Sno; }
            set
            {
                Sno = value;
                OnPropertyChanged("sno");
            }
        }


        private string Username;
        public string username
        {
            get { return Username; }
            set
            {
                Username = value;
                OnPropertyChanged("username");
            }
        }



        private string Password;
        public string password
        {
            get { return Password; }
            set
            {
                Password = value;
                OnPropertyChanged("password");
            }
        }



        private string Age;
        public string age
        {
            get { return Age; }
            set
            {
                Age = value;
                OnPropertyChanged("age");
            }
        }



        private string Createddate;
        public string createddate
        {
            get { return Createddate; }
            set
            {
                Createddate = value;
                OnPropertyChanged("createddate");
            }
        }



        private string Latitude;
        public string latitude
        {
            get { return Latitude; }
            set
            {
                Latitude = value;
                OnPropertyChanged("latitude");
            }
        }



        private string Longitude;
        public string longitude
        {
            get { return Longitude; }
            set
            {
                Longitude = value;
                OnPropertyChanged("longitude");
            }
        }


        private string Status;
        public string status
        {
            get { return Status; }
            set
            {
                Status = value;
                OnPropertyChanged("status");
            }
        }


        private string Email;
        public string email
        {
            get { return Email; }
            set
            {
                Email = value;
                OnPropertyChanged("email");
            }
        }


        private string Profile_imgurl;
        public string profile_imgurl
        {
            get { return Profile_imgurl; }
            set
            {
                Profile_imgurl = value;
                OnPropertyChanged("profile_imgurl");
            }
        }


        private string Gender;
        public string gender
        {
            get { return Gender; }
            set
            {
                Gender = value;
                OnPropertyChanged("gender");
            }
        }


        private string Login_status;
        public string login_status
        {
            get { return Login_status; }
            set
            {
                Login_status = value;
                OnPropertyChanged("login_status");
            }
        }


        private string Intrests;
        public string intrests
        {
            get { return Intrests; }
            set
            {
                Intrests = value;
                OnPropertyChanged("intrests");
            }
        }


        private string Addictional_information;
        public string addictional_information
        {
            get { return Addictional_information; }
            set
            {
                Addictional_information = value;
                OnPropertyChanged("addictional_information");
            }
        }



        private string Looking_for;
        public string looking_for
        {
            get { return Looking_for; }
            set
            {
                Looking_for = value;
                OnPropertyChanged("looking_for");
            }
        }



        private string Body_type;
        public string body_type
        {
            get { return Body_type; }
            set
            {
                Body_type = value;
                OnPropertyChanged("body_type");
            }
        }



        private string Drinks;
        public string drinks
        {
            get { return Drinks; }
            set
            {
                Drinks = value;
                OnPropertyChanged("drinks");
            }
        }



        private string Height;
        public string height
        {
            get { return Height; }
            set
            {
                Height = value;
                OnPropertyChanged("height");
            }
        }



        private string Languages;
        public string languages
        {
            get { return Languages; }
            set
            {
                Languages = value;
                OnPropertyChanged("languages");
            }
        }



        private string Msgid;
        public string msgid
        {
            get { return Msgid; }
            set
            {
                Msgid = value;
                OnPropertyChanged("msgid");
            }
        }



        private string User_from;
        public string user_from
        {
            get { return User_from; }
            set
            {
                User_from = value;
                OnPropertyChanged("user_from");
            }
        }


        private string User_to;
        public string user_to
        {
            get { return User_to; }
            set
            {
                User_to = value;
                OnPropertyChanged("user_to");
            }
        }


        private string Conversation;
        public string conversation
        {
            get { return Conversation; }
            set
            {
                Conversation = value;
                OnPropertyChanged("conversation");
            }
        }


        private string Sentby;
        public string sentby
        {
            get { return Sentby; }
            set
            {
                Sentby = value;
                OnPropertyChanged("sentby");
            }
        }


        private string Datetime;
        public string datetime
        {
            get { return Datetime; }
            set
            {
                Datetime = value;
                OnPropertyChanged("datetime");
            }
        }


        private string New_msg_status;
        public string new_msg_status
        {
            get { return New_msg_status; }
            set
            {
                New_msg_status = value;
                OnPropertyChanged("new_msg_status");
            }
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            // Raise the PropertyChanged event, passing the name of the property whose value has changed.
            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    public class ChatsHomeModel
    {
        public List<chatsHomeDatum> data { get; set; }
    }
}