using SmartClinic.DataObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartClinic
{
    public partial class Registeration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void Register(object sender, EventArgs e)
        {
  
            using (var db = new ProjectContext())
            {
                var gender = Bus.EnumType.Gender.Female;

                if (RadioButton1.Checked)
                {
                    gender = Bus.EnumType.Gender.Male;
                }

                var patient = new DataObject.Patient { Email = user_email.Text, FirstName = firstName.Text, LastName = lastName.Text, Password = password.Text, PhoneNumber = phone.Text, BirthOfDate = birthday.SelectedDate, Gender = gender, Description = description.Text };
                Data.PatientDB.Register(patient);
                //Response.Write("success");

            }
        }
    }
}