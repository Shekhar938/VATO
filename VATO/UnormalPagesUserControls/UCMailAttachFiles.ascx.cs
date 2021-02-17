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

public partial class UnormalPagesUserControls_UCMailAttachFiles : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAttachFile_Click(object sender, EventArgs e)
    {
        try
        {
            if (FileUpload1.FileName != "")
            {
                Session["MailAttachFiles"] = FileUpload1.FileName;
                FileUpload1.SaveAs(Server.MapPath("~/MailAttachFiles/" + Session["MailAttachFiles"]));
            }
            else
            {
                Session["MailAttachFiles"] = "";
            }
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
}
