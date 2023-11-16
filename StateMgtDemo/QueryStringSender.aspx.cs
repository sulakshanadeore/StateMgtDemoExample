using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgtDemo
{
    public partial class QueryStringSender : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
Customer c=new      Customer();
            c.Custid = Convert.ToInt32(TextBox1.Text);
            c.CustName = TextBox2.Text;
            Response.Redirect("~/QueryStringReceiver.aspx?custid=" + c.Custid + "&custname=" +
            c.CustName);
           // string s1=c.Custid.ToString();
           // string s2 = c.CustName;
           
           //string s3 =String.Format("~/QueryStringReceiver.aspx?{0}&{1}",Server.UrlEncode(s1),Server.UrlEncode(s2));
           // Response.Redirect(s3);

        }
    }
}