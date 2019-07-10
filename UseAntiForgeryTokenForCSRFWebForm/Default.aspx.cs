using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UseAntiForgeryTokenForCSRFWebForm
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AuthenticateButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text.Trim() == "Root" || UserPasswordTextBox.Text != "Toor") Response.Write("<script>alert('Ooops! Authentication failed, Pl make sure you put a valid username and password.');</script>");

            Response.Redirect("~/UserPage/Profile.aspx");
            Response.End();
        }
    }
}