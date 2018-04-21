using SmartClinic.Data;
using SmartClinic.DataObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartClinic
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            using (var db = new ProjectContext())
            {

                //======================================
                //Example of adding row 
                //======================================
                //for (int i = 0; i < 10; i++)
                //{
                //    var user = new User { Username = "test" + i.ToString(), Password = i.ToString(), UserType = Bus.EnumType.UserType.Patient };

                //    db.User.Add(user);
                //    db.SaveChanges();
                //}

                //Response.Write("<h3>Done</h3>");

                //======================================
                //To modify data row
                //======================================
                //var user = db.User.Find(1);

                //if (user != null)
                //{
                //    user.Password = "abcd";
                //    db.SaveChanges();

                //======================================
                //To Remove data row
                //======================================
                //var user = db.User.Find(1);

                //if (user != null)
                //{
                //    db.User.Remove(user);
                //    db.SaveChanges();
                //}


                //var query = (from u in db.User
                //             where ((u.Id) > 5 && (u.Username.Length > 2))
                //             select u).ToList();

                //var labdaQuery = db.User.Where(u => u.Id > 5 && u.Username.Length > 2).ToList();

                //foreach(var row in labdaQuery)
                //{
                //    Response.Write(string.Format("{0} - {1}<br>", row.Id, row.Username));
                //}

                var result = Tools.IsValidCredential("test@test.ca", "1234", Bus.EnumType.UserType.Patient);

                Response.Write(result.ToString());

            }
        }
    }
}