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

public partial class UnormalPagesUserControls_UCActivityMonitoeingDetails : System.Web.UI.UserControl
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
                Image1.Attributes.Add("Src", FileUpload1.PostedFile.FileName);
                Session["ActivityImage"] = FileUpload1.FileName;
                FileUpload1.SaveAs(Server.MapPath("~/ActivityImages/" + Session["ActivityImage"]));
            }
            else
            {
                Session["ActivityImage"] = "NoImage.jpg";
                FileUpload1.SaveAs(Server.MapPath("~/Upload/" + Session["ActivityImage"]));
            }
   
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
        }
    public void ClearImage()
    {
        Image1.Attributes.Clear();
        //Image1.ImageUrl = "~/Upload/Noimage.jpg";
        Image1.Attributes.Add("Src", Server.MapPath("~/Upload/Noimage.jpg"));
    }
}
