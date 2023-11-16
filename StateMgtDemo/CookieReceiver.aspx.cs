using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgtDemo
{
    public partial class CookieReceiver : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie=Request.Cookies.Get("custCookie");
            TextBox1.Text=cookie["custid"].ToString();
            TextBox2.Text = cookie["custname"].ToString();
        }
    }
}