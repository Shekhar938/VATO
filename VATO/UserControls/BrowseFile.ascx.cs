﻿using System;
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
    byte[] FileData = null;
    
    #endregion
    #region properties for private fields

    

   
    
    #endregion

    #region  for page load
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Session["FileContent"] = null;
            Session["FileName"] = null;
        }
        lblMessage.Text = "";
    }
    #endregion

    #region for public utility class
    public class UIUtilities
    {
        
        #region ReadFile to Convert Binary
        /// <summary>
        /// Get the Uploaded file and convert to binary for storing in Db
        /// </summary>
        /// <param name="PostedFileName">Uploaded file</param>
        /// <returns>Byte[] object</returns>
        public static byte[] ReadFile(string PostedFileName, string[] filetype)
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

                    byte[] filecontent = br.ReadBytes((int)fs.Length);

                    //close the binary reader

                    br.Close();

                    //close the filestream

                    fs.Close();

                    return filecontent;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("File Not Supporting to upload" + ex);
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
            string strFileName = null;
            if (photoByte != null && photoByte.Length > 1)
            {
                System.Drawing.Image newImage;

                //get the temporary internet folder path of the system to store the image file
                strFileName = UIUtilities.GetTempFolderName()+FileName;    //PhotoExtension;

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

        //#region InsertImageToDb
        ///// <summary>
        ///// Insert to DB
        ///// </summary>
        ///// <param name="image">Input Parameters image byte array</param>
        ///// <param name="type">Input Parameter image type extention</param>
        ///// <returns>If inserted true else false</returns>
        //public static bool InsertImageToDb(byte[] image, string type)
        //{

        //    try
        //    {
        //        DataSet dsDataSet;

        //        //sql statement to insert image to DB
        //        string insertSql = "INSERT INTO tblImages (img,Type) VALUES (@Photo,@Type)";

        //        //create Connection 
        //        con = ProviderFactory.CreateConnection();
        //        con.ConnectionString = "Server=.;Database=FileUpload;Uid=sa;Pwd=123;";
        //        //open Connection 
        //        con.Open();

        //        //create command 
        //        DbCommand command = con.CreateCommand();
        //        command.CommandText = insertSql;
        //        command.Connection = con;


        //        //Create the Input Parameters
        //        DbParameter param = ProviderFactory.CreateParameter();
        //        param.ParameterName = "@Photo";
        //        param.DbType = DbType.Binary;
        //        param.Direction = ParameterDirection.Input;
        //        param.Value = image;


        //        DbParameter param1 = ProviderFactory.CreateParameter();
        //        param1.ParameterName = "@Type";
        //        param1.DbType = DbType.String;
        //        param1.Direction = ParameterDirection.Input;
        //        param1.Value = type;

        //        //Add Parameters to command object
        //        command.Parameters.Add(param);
        //        command.Parameters.Add(param1);

        //        // Store Image
        //        int rowsAffected = command.ExecuteNonQuery();
        //        if (rowsAffected == 0)
        //        {
        //            return (false);

        //        }
        //        return (true);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Error occured while insering the image", ex);
        //    }
        //    finally
        //    {
        //        if (con != null)
        //        {
        //            con.Close();
        //            con = null;
        //        }
        //    }

        //}
        //#endregion

        //#region GetImageFromDb
        ///// <summary>
        ///// Get From DB
        ///// </summary>
        ///// <returns>Result DataSet</returns>
        //public static DataSet GetImageFromDb()
        //{
        //    try
        //    {
        //        //Create Connection
        //        con = ProviderFactory.CreateConnection();
        //        con.ConnectionString = "Server=.;Database=FileUpload;Uid=sa;Pwd=123;";
        //        con.Open();

        //        //sql statement to get image to DB
        //        string selectSql = "SELECT ID,name,img,Type,length FROM tblImages";

        //        // Create Example DbCommand
        //        DbCommand selectCommand = con.CreateCommand();
        //        selectCommand.CommandText = selectSql;
        //        selectCommand.Connection = con;
        //        DbDataAdapter objDataAdapter = (DbDataAdapter)ProviderFactory.CreateDataAdapter();

        //        objDataAdapter.SelectCommand = selectCommand;
        //        DataSet dsResult = new DataSet();

        //        // Execute Command
        //        objDataAdapter.Fill(dsResult);
        //        if (dsResult != null && dsResult.Tables.Count > 0 && dsResult.Tables[0].Rows.Count > 0)
        //        {
        //            return (dsResult);

        //        }
        //        return (null);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        if (con != null)
        //        {
        //            con.Close();
        //            con = null;
        //        }
        //    }
        //}
        //#endregion

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
                    lblMessage.Text = "Please select a file to Attach";
                else
                {
                    //Get binary value of the image file
                    FileData  = UIUtilities.ReadFile(postFile.FileName, new string[] { ".doc", ".pdf", ".xl", ".xml", ".txt", ".ppt" });
                    if (FileData == null)
                    {
                        lblMessage.Text = "Please select a file of extentions doc, pdf, xl, xml, txt, ppt";
                    }
                    else
                    {
                        //persist the extension of the selected image file
                        //this.Page.RegisterHiddenField("hdnPhoto", Path.GetExtension(postFile.FileName));
                        if (Session["FileName"] == null)
                            Session.Add("FileName", strFileName);
                        else 
                            Session["FileName"] = strFileName;
                        if (Session["FileContent"] == null)
                            Session.Add("FileContent", FileData);
                        else
                            Session["FileContent"] = FileData;
                        lblMessage.Text = "File Attached";
                    }
                }
            }
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message;
        }
    }
    #endregion

}
