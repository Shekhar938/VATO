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

using System.IO;
using System.Data.Common;
public partial class BrowseImage : System.Web.UI.UserControl
{
    #region for privte fields
    string strImageType = string.Empty;
    byte[] imageData = null;
    private static byte[] NoImage;

   
    private byte[] _strLaodImageByte;
    private string _strLoadFileName;
    private string _strDefaultImageUrl;

   

    #endregion

    #region properties for private fields

    public string DefaultImageUrl
    {
        get { return _strDefaultImageUrl; }
        set { _strDefaultImageUrl = value; }
    }
    
    public byte[] LaodImageByte
    {
        get { return _strLaodImageByte; }
        set { _strLaodImageByte = value; }
    }
    public string LoadFileName
    {
        get { return _strLoadFileName; }
        set { _strLoadFileName = value; }
    }
    #endregion

    public void loadimage()
    {
        try
        {
            if (!string.IsNullOrEmpty(_strLoadFileName) && _strLaodImageByte != null)
            {
                Session["FileName"] = _strLoadFileName;
                Session["Photo"] = _strLaodImageByte;
                imgMyPhoto.Attributes.Add("Src", UIUtilities.LoadImage(_strLaodImageByte, _strLoadFileName));
            }
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message;
        }  
    }

    public void Clearimage()
    {
        try
        { 
            imgMyPhoto.ImageUrl = this._strDefaultImageUrl;
            Session["Photo"] = UIUtilities.ReadImageFile(Server.MapPath(this._strDefaultImageUrl), new string[] { ".jpg", ".gif" });
            Session["FileName"] = "NoImage.jpg";
            imgMyPhoto.Attributes.Add("Src", Server.MapPath(this._strDefaultImageUrl));
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }

    #region  for page load
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!string.IsNullOrEmpty(_strLoadFileName) && _strLaodImageByte != null)
            {
                Session["FileName"] = _strLoadFileName;
                Session["Photo"] = _strLaodImageByte;
                imgMyPhoto.Attributes.Add("Src", UIUtilities.LoadImage(_strLaodImageByte, _strLoadFileName));
            }
            else
            {
                imgMyPhoto.ImageUrl = this._strDefaultImageUrl;
                Session["Photo"] = UIUtilities.ReadImageFile(Server.MapPath(this._strDefaultImageUrl), new string[] { ".jpg", ".gif" });
                Session["FileName"] = "NoImage.jpg";
            }
        }
        lblMessage.Text = "";
    }
    #endregion

    #region for public utility class
    public  class UIUtilities
    {
        static DbProviderFactory ProviderFactory = DbProviderFactories.GetFactory("System.Data.SqlClient");
        static DbConnection con = null;

        #region ReadImageFile to Convert Binary
        /// <summary>
        /// Get the Uploaded file and convert to binary for storing in Db
        /// </summary>
        /// <param name="PostedFileName">Uploaded file</param>
        /// <returns>Byte[] object</returns>
        public static byte[] ReadImageFile(string PostedFileName, string[] filetype)
        {
            bool isAllowedFileType = false;
            try
            {
                FileInfo file = new FileInfo(PostedFileName);

                foreach (string strExtensionType in filetype)
                {
                    if (strExtensionType.ToUpper() == file.Extension.ToUpper())
                    {
                        isAllowedFileType = true;
                        break;
                    }
                }
                if (isAllowedFileType)
                {
                    //Create a new filestream object based on the file chosen in the FileUpload control

                    FileStream fs = new FileStream(PostedFileName, FileMode.Open, FileAccess.Read);

                    //Create a binary reader object to read the binary contents of the file to upload

                    BinaryReader br = new BinaryReader(fs);

                    //dump the bytes read into a new byte variable named image

                    byte[] image = br.ReadBytes((int)fs.Length);

                    //close the binary reader

                    br.Close();

                    //close the filestream

                    fs.Close();

                    return image;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("File Not Supporting For Image" + ex);
            }

        }
        #endregion

        #region GetTempFolderName
        /// <summary>
        /// returns the Temp Folder Name to store Images & resumes
        /// </summary>
        /// <returns>string Folder Name</returns>
        public static string GetTempFolderName()
        {
            string strTempFolderName = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache) + @"\";

            if (Directory.Exists(strTempFolderName))
            {
                return strTempFolderName;
            }
            else
            {
                Directory.CreateDirectory(strTempFolderName);
                return strTempFolderName;
            }
        }
        #endregion
        #region Code For Converting Varformat to Image format

        public static string LoadImage(byte[] photoByte, string FileName)
        {
            string strFileName=null;
            if (photoByte != null && photoByte.Length > 1)
            {
                System.Drawing.Image newImage;

                //get the temporary internet folder path of the system to store the image file
                 strFileName = UIUtilities.GetTempFolderName() + "BrowsenPhoto" + FileName;    //PhotoExtension;

                //write the binary data to memory stream 
                using (MemoryStream stream = new MemoryStream(photoByte))
                {
                    newImage = System.Drawing.Image.FromStream(stream);
                    //save the image file to temporary folder
                    newImage.Save(strFileName);
                }
            }
            return strFileName;
        }
        #endregion


    }
    #endregion

    #region for btn Show event
    protected void btnShowImg_Click(object sender, EventArgs e)
    {
        HttpPostedFile postFile = this.Upload1.PostedFile;
        string strFileName = this.Upload1.FileName;
        try
        {
            if (this.Upload1.PostedFile != null)
            {
               
                //Check the selection of file
                if (string.IsNullOrEmpty(postFile.FileName))
                    lblMessage.Text = "Browse Photo To View";
                else
                {
                    //Get binary value of the image file
                    imageData = UIUtilities.ReadImageFile(postFile.FileName, new string[] { ".gif", ".jpg", ".bmp", ".jpeg" });
                    if (imageData == null)
                    {
                        lblMessage.Text = "Allowed formates: gif, jpg or bmp.";
                        imgMyPhoto.Attributes.Add("Src", "");
                    }
                    else
                    {
                        //persist the extension of the selected image file
                        //this.Page.RegisterHiddenField("hdnPhoto", Path.GetExtension(postFile.FileName));
                        Session["FileName"] = strFileName;
                        if (Session["Photo"] == null)
                            Session.Add("Photo", imageData);
                        else
                            Session["Photo"] = imageData;
                        imgMyPhoto.Attributes.Add("Src",Upload1.PostedFile.FileName);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            lblMessage.Text =ex.Message ;
        }
    }
    #endregion
    
}
