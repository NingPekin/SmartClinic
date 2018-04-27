using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using SmartClinic.DataObject;

namespace SmartClinic.Api
{
    public partial class mainapi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //get method
            if (Request.QueryString["action"] != null)
            {
                var action = Request.QueryString["action"];
                string output = string.Empty;

                using (var db = new ProjectContext())
                {
                    switch (action)
                    {
                        //For action of getAvailableTime
                        case "getAvailableTime":
                            var ID = Request.QueryString["id"];
                            var DATE = Request.QueryString["date"];

                            //If Doctor is selected
                            if (Convert.ToInt32(ID) > 0)
                            {
                                //Get reserved appointments
                                var query = "select * from appointments where doctor_id=" + ID + " and date='" + DATE + "'";
                                var reserved = db.Database.SqlQuery<DataObject.Appointment>(query).ToList();

                                //Empty List of Appointments
                                List<DataObject.Appointment> list = new List<DataObject.Appointment>();

                                //Generate a month of available appointments and deduct from reserved appointments
                                //By default we generate one day from 9:00 am to 6:00 pm
                                DateTime requestedDate = Convert.ToDateTime(DATE);
                                DateTime today = new DateTime(requestedDate.Year, requestedDate.Month, requestedDate.Day, 0, 0, 0); //hour 00:00:00
                                DateTime time = new DateTime(1, 1, 1, 9, 0, 0); //Start from 9 am

                                //Add 9:00 to 18:00 to List by default
                                for (int d = 9; d < 19; d++)
                                {
                                    list.Add(new DataObject.Appointment() { Date = today, Time = d.ToString("00") + ":00" });
                                }

                                //Deduct reserved times of today and return the list
                                for (int i = 0; i < reserved.Count; i++)
                                {
                                    var found = list.Where(a => a.Date == reserved[i].Date && a.Time == reserved[i].Time).FirstOrDefault();
                                    if (found != null)
                                    {
                                        list.Remove(found);
                                    }
                                }

                                //Serialize the list as Json object and return to request as response
                                var result = JsonConvert.SerializeObject(list);

                                output = result;
                            }
                            else
                            {
                                output = "";
                            }

                            break;

                        case "addAppointment":
                            var doctorId = Convert.ToInt32(Request.QueryString["id"]);
                            var selectedDate = Request.QueryString["date"];
                            var selectedTime = Request.QueryString["hour"];

                            db.Appointment.Add(new DataObject.Appointment() {
                                Date = Convert.ToDateTime(selectedDate),
                                Time = selectedTime,
                                Doctor = db.Doctor.Where(a => a.Id == doctorId).FirstOrDefault()
                            });

                            db.SaveChanges();
                            output = "{result:1}";

                            break;
                    }
                }
                Response.Clear();
                Response.Write(output);
                Response.End();
            }
            else
            {
                //if the request doesnt have any parameter then
                //show fake error 404
                Response.Clear();
                Response.StatusCode = 404;
                Response.End();
            }
        }
    }
}