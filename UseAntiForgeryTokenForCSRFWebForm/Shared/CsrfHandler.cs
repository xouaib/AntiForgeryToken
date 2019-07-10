using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UseAntiForgeryTokenForCSRFWebForm.Shared
{
    public class CsrfHandler
    {
        public static void Validate(Page page, HiddenField forgeryToken)
        {
            if (!page.IsPostBack)
            {
                Guid antiForgeryToken = Guid.NewGuid();
                page.Session["AntiForgeryToken"] = antiForgeryToken;
                forgeryToken.Value = antiForgeryToken.ToString();
            }
            else
            {
                Guid storedAntiForgeryToken = (Guid)page.Session["AntiForgeryToken"];
                Guid hiddenFildAntiForgeryToken = new Guid(forgeryToken.Value);

                if(hiddenFildAntiForgeryToken != storedAntiForgeryToken)
                {
                    // you can throw an exception, in my case I'm just logging the user out
                    page.Session.Abandon();
                    page.Response.Redirect("~/default.aspx");
                    page.Response.End();

                }
            }
        }
    }
}