using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WinFormsApp4
{

    internal class Membership
    {
        public string Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public DateTime Dob { get; set; }
        public string Gender { get; set; } 
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Streetaddress { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string Postalcode { get; set; }
        public DateTime Validity { get; set; }
        public bool Status { get; set; }




        public Membership(string id, string fname,string lname,DateTime dob,string gender,string mobile,string email,string streetaddress,string city,string province,string country,string postalcode,DateTime validity) {
            this.Id = id;
            this.Fname= fname;
            this.Lname= lname;
            this.Dob= dob.Date;
            this.Gender = gender;
            this.Mobile = mobile;
            this.Email = email;
            this.Streetaddress = streetaddress;
            this.City = city;
            this.Province = province;
            this.Country = country;
            this.Postalcode = postalcode;
            this.Validity= validity.Date;
            this.Status = true;


        }
        public static List<Membership> people = new List<Membership>();//list for membership of customer
        
        public static string NextMem(List<Membership> member)//function to genrate next member id
        {
            if (member.Count > 0)//if atleast one member is present in list 
            {
                int lastindex = member.Count - 1;//getting last index
                int lastmemid = Int32.Parse(member[lastindex].Id);
                string newmemberid = Convert.ToString(lastmemid + 1);

                return newmemberid;
            }

            return "1";//if no member is prsent in the list this would be the first member

        }

        public static bool MemberCheck(List<Membership> allmember, string mobile)//for checking if the same mobile number is registered with other membership
        {
            foreach (Membership member in allmember)
            {
                if (member.Mobile == mobile)
                {
                    return true;
                }
            }
            return false;
        }

        public static void SaveData(List<Membership> allmembers)//method to save data 
        {
         // convert list of users to JSON string
            string jsonString = JsonSerializer.Serialize(allmembers);

            // write JSON string to a file
            File.WriteAllText("Members.json", jsonString);
        }

        public static void StatusCheck(List<Membership> members)
        {
            foreach(Membership member in members)
            {
                if (DateTime.Now > member.Validity)
                {
                    member.Status = false;
                }
            }
        }

        

        

    }
}
