using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgtDemo
{
    public partial class ViewStateDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int cnt = 1;
            if (!Page.IsPostBack)
            {
                ViewState["visitCount"] = cnt;
                TextBox1.Text= ViewState["visitCount"].ToString();  
            }
            else
            {
                cnt = Convert.ToInt32(ViewState["visitCount"]) + 1;
                ViewState["visitCount"] = cnt;
                TextBox1.Text = ViewState["visitCount"].ToString();
                if (cnt==3)
                {
                    Button2.Enabled = false;
                }

            }
        }
    }
}