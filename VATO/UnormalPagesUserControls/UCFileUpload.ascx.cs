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

public partial class UnormalPagesUserControls_UCFileUpload : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        { 
        
        }
    }
    string noimage;

    public string Noimage
    {
        get { return noimage; }
        set { noimage = value; }
    }
    protected void btnAttachFile_Click(object sender, EventArgs e)
    {
        try
        {
            if (FileUpload1.FileName != "")
            {
                Image1.Attributes.Add("Src", FileUpload1.PostedFile.FileName);
                Session["FileName"] = FileUpload1.FileName;
                //  Session["FilePath"] = FileUpload1.PostedFile.FileName;

                FileUpload1.SaveAs(Server.MapPath("~/Upload/" + Session["FileName"]));
            }
            else 
            {
                Session["FileName"] = "NoImage.jpg";
                FileUpload1.SaveAs(Server.MapPath("~/Upload/" + Session["FileName"]));
            }
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
        //HttpPostedFile file = FileUpload1.PostedFile.;
        //Image1.ImageUrl = FileUpload1.PostedFile.FileName;
         }
    public void SaveImage()
    {
       // FileUpload1.SaveAs(Server.MapPath("~/Upload/" + Session["FileName"]));
    }
    public void ClearImage()
    {
        Image1.Attributes.Clear();
        Image1.ImageUrl = "~/Upload/Noimage.jpg";
        Image1.Attributes.Add("Src",Server.MapPath("~/Upload/Noimage.jpg"));
    }
}
