using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartClinic
{
    public partial class Patient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //public string ShowAppointment()
        //{
        //    string result = "<table class='table table-hover table-striped' cellpadding='5'>";
        //    result += "<tr><th></th><th>Title</th><th>Due Date</th></tr>";

        //    List<Project> _projectsList = Project.getProjects();
        //    int cnt = 0;

        //    foreach (var item in _projectsList)
        //    {
        //        result += string.Format("<tr id='tr{3}' onclick='showData(\"{0}\",\"{1}\",\"{2}\");'><td>{0}</td><td>{1}</td><td>{2}</td></tr>",
        //            item.PCode, item.Ptitle, item.DueDate, cnt);
        //        cnt++;
        //    }

        //    return result;
        //}
    }
}