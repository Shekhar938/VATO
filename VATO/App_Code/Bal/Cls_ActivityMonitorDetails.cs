using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using BackToMyVillage;

/// <summary>
/// Summary description for Cls_ActivityMonitorDetails
/// </summary>
public class Cls_ActivityMonitorDetails
{

    private int activityMonitorId;
    private int activityImageId;
    private string activityImagefileName;
   
    private string activityImagefileDescription;
    
    private string activityImageVideofileName;
    private int imageorVideofileHostedVolunteerId;

    // constructor
    public Cls_ActivityMonitorDetails()
    {
    }

    public int ActivityMonitorId { get { return activityMonitorId; } set { activityMonitorId = value; } }
    public int ActivityImageId { get { return activityImageId; } set { activityImageId = value; } }
    public string ActivityImagefileName { get { return activityImagefileName; } set { activityImagefileName = value; } }
    
    public string ActivityImagefileDescription { get { return activityImagefileDescription; } set { activityImagefileDescription = value; } }
   
    public string ActivityImageVideofileName { get { return activityImageVideofileName; } set { activityImageVideofileName = value; } }
    public int ImageorVideofileHostedVolunteerId { get { return imageorVideofileHostedVolunteerId; } set { imageorVideofileHostedVolunteerId = value; } }
    public DataSet GetActivityMonitorId()
    {
        try
        {
            string strtext = "Sp_ActivityMonitoringMaster_Select";
            return SqlHelper.ExecuteDataset(Connection.con, CommandType.StoredProcedure, strtext);

        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    
    }
    public int InsertActivityMonitoringDetails()
    {
        try
        {
            SqlParameter[] p = new SqlParameter[5];
            p[0] = new SqlParameter("@ActivityMonitorId", ActivityMonitorId);
            p[1] = new SqlParameter("@ActivityImagefileName", ActivityImagefileName);
            p[2] = new SqlParameter("@ActivityImagefileDescription", ActivityImagefileDescription);
            p[3] = new SqlParameter("@ActivityImageVideofileName", ActivityImageVideofileName);
            p[4] = new SqlParameter("@ImageorVideofileHostedVolunteerId", ImageorVideofileHostedVolunteerId);
            int i = SqlHelper.ExecuteNonQuery(Connection.con, CommandType.StoredProcedure, "Sp_ActivityMonitorDetails_Insert", p);
            return i;
        }
        catch (Exception ex)
        {
            
            throw new ArgumentException (ex.Message);
        }
    }

    public DataSet GetActivityMonitoringIdByVolunteerId(int p)
    {
        try
        {
            string str = "select * from tbl_ActivityMonitoringMaster where DataHostedVolunteerId=" + p;
            return SqlHelper.ExecuteDataset(Connection.con, CommandType.Text, str);
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }
}
