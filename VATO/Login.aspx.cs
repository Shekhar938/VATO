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

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string url = Request.Url.ToString();

        string[] split = url.Split('/');
        for (int i = 0; i < split.Length; i++)
        {
            if (split[i] == "Admin")
                Label1.Text = "Admin Login";
            if (split[i] == "Members")
                Label1.Text = "Donor Login";
            if (split[i] == "Volunteers")
                Label1.Text = "Volunteer Login";
        }

        if (Session["UserName"] != null)
        {
            FormsAuthentication.SignOut();
        }
    }
    clsLogin objLogin = new clsLogin();
    
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string str1 = null;
        string[] LoginName = null;
        try
        {
            if (txtUsername.Text.Contains("@"))
            {
                string str = txtUsername.Text;
                LoginName = str.Split('@');
                clsLogin.UserName = LoginName[0].ToString();
                str1 = LoginName[0].ToString();
            }
            else
            {
                clsLogin.UserName = txtUsername.Text.Trim();
                str1 = txtUsername.Text.Trim();
            }
            clsLogin.Password = txtPassword.Text.Trim();
            int Id;
            string Role = objLogin.GetUserLogin(out Id);

            if (Role == "NoUser")
                lblMsg.Text = "User Name and password mismatch. Try again.";
            else
            {
                if (Role.ToUpper() == "ADMIN")
                {
                    Session["UserName"] = str1;
                    Session["AdminId"] = Id;
                    Session["UserType"] = "Admin";
                    FormsAuthentication.RedirectFromLoginPage("Admin", false);
                }
                else if (Role.ToUpper() == "MEMBER")
                {
                    Session["UserName"] = str1;
                    Session["MemberId"] = Id;                   
                    Session["UserType"] = "Member";
                    FormsAuthentication.RedirectFromLoginPage("Member", false);
                }
                else if (Role.ToUpper() == "VOLUNTEER")
                {
                    Session["UserName"] = str1;
                    Session["VolunteerId"] = Id;                   
                    Session["UserType"] = "Volunteer";
                    FormsAuthentication.RedirectFromLoginPage("Volunteer", false);
                }
                else
                    lblMsg.Text = "Login Failed for this User";
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.Message;
        }
    }
}
