using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgtDemo
{
    public partial class QueryStringReceiver : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = Request.QueryString["custid"].ToString();
            TextBox2.Text = Request.QueryString["custname"].ToString();

            //string d = Server.UrlDecode(Request.QueryString.Get("s1"));
            //string d1 = Server.UrlDecode(Request.QueryString.Get("s2"));

            //TextBox1.Text = d;
            ////TextBox2.Text = d1;
        }
    }
}