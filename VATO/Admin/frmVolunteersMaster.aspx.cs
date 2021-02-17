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
using System.Web.Mail;
public partial class Admin_frmVolunteersMaster : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    Cls_VolunteerMaster objVolunteerMaster = new Cls_VolunteerMaster();
    string s;
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            objVolunteerMaster.VolunteerName = TxtVolunteerName.Text ;
            objVolunteerMaster.VolunteerDoB = Convert.ToDateTime(TxtVolunteerDateofbirth.Text);
            if (Session["FileName"] != null)
            {
                 s = "~/Upload/" + Session["FileName"].ToString();
            }
            else
            {
                 s = "~/Upload/NoImage.jpg";
            }
            objVolunteerMaster.VolunteerImageFileName  = s.ToString();
            objVolunteerMaster.VolunteerDescription = TxtVolunteerDescription.Text;
            objVolunteerMaster.VolunteerMobile = TxtMobileNo.Text;
            objVolunteerMaster.VolunteerAddress  =TxtvolunteerAddress.Text;
            objVolunteerMaster.UserName = txtUserName.Text;
            objVolunteerMaster.Password = txtPassword.Text;
            
            int i = objVolunteerMaster.Insertvolunteermaster();
            if (i > 0)
            {
                lblError.Text = "Volunteer Registered Successfully.";
                Session["FileName"] = null;
                SendMails(objVolunteerMaster.UserName,objVolunteerMaster.Password);
                Cleardata();
                
            }
            else
            {
                lblError.Text = "Already username Available Add Another user..";
            }
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }

    }

    protected void btncancel_Click(object sender, EventArgs e)
    { 
        Cleardata();
    }

    void Cleardata()
    {
        TxtMobileNo.Text = "";
        TxtvolunteerAddress.Text = "";
        TxtVolunteerDateofbirth.Text = "";
       
        TxtVolunteerDescription.Text = "";
        TxtVolunteerName.Text = "";
        FileUpload1.ClearImage();
       
    }

    void SendMails(string username,string password)
    {
        try
        {
            MailMessage objMail = new MailMessage();
            objMail.From = "Back To MyVillage.Com";
            objMail.To = "Localhost";
            objMail.Subject = "Volunteer Login Details.";
            objMail.Body = "Hai" + " \n " + objVolunteerMaster.VolunteerName + " This is Your UserName   : " + username + "" + "\n" +
                           "Your Password Date: " + password;


            SmtpMail.SmtpServer = "localhost";
            SmtpMail.Send(objMail);
        }
        catch (Exception ex)
        {
            
          
        }
     
    }
}
