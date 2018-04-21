using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartClinic.Api
{
    public partial class mainapi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //get method
            if (Request.QueryString["event"] != null)
            {
                var x = Request.QueryString["event"];
                Response.Clear();
                Response.Write(string.Format("Hello {0}", x));
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