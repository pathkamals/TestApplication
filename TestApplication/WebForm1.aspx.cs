using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //txtName.Text = "Rohit";


        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string strName = txtName.Text;
            txtName.Text = "";
            lblDisplayName.Text = strName;
            lblDisplay.Text = strName;
            strName = "";
            //Math.Max(1, 2);
        }

        
    }
}