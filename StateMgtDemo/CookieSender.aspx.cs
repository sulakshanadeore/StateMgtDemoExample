using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgtDemo
{
    public partial class CookieSender : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Custid = Convert.ToInt32(TextBox1.Text);
            customer.CustName = TextBox2.Text;

            HttpCookie cookie = new HttpCookie("custCookie");
            cookie.Values.Add("custid", customer.Custid.ToString());
            cookie.Values.Add("custname", customer.CustName);
            cookie.Expires = DateTime.Now.AddMinutes(5);
            Response.Cookies.Add(cookie);
            Response.Redirect("~/CookieReceiver.aspx");



        }
    }
}