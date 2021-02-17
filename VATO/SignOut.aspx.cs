using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class SignOut : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserType"] != null)
        {
            if (Session["UserType"].ToString() == "Volunteer")
                clsLogin.InActiveVolunteerOnlineStatus(Convert.ToInt32(Session["VolunteerId"]));
            if (Session["UserType"].ToString() == "Member")
                clsLogin.InActiveMemberOnlineStatus(Convert.ToInt32(Session["MemberId"]));
            Session.Abandon();
            Session.Clear();
            FormsAuthentication.SignOut();
        }

    }
}
