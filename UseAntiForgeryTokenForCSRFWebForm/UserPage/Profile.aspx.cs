using System;
using UseAntiForgeryTokenForCSRFWebForm.Shared;

namespace UseAntiForgeryTokenForCSRFWebForm.UserPage
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Inti()
        {

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            CsrfHandler.Validate(this.Page, forgeryToken);
        }
    }
}