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
/// Summary description for ClsActivityMonitoringMaster
/// </summary>
public class Cls_ActivityMonitoringMaster
{

    private int activityMonitorId;
    private DateTime activityMonitorDate;
    private int activityId;
    private int villageId;
    private string activityPercentCompleted;
    private string activityCompletedDetails;
    private int dataHostedVolunteerId;

    // constructor
    public Cls_ActivityMonitoringMaster()
    {
    }

    public int ActivityMonitorId { get { return activityMonitorId; } set { activityMonitorId = value; } }
    public DateTime   ActivityMonitorDate { get { return activityMonitorDate; } set { activityMonitorDate = value; } }
    public int ActivityId { get { return activityId; } set { activityId = value; } }
    public int VillageId { get { return villageId; } set { villageId = value; } }
    public string ActivityPercentCompleted { get { return activityPercentCompleted; } set { activityPercentCompleted = value; } }
    public string ActivityCompletedDetails { get { return activityCompletedDetails; } set { activityCompletedDetails = value; } }
    public int DataHostedVolunteerId { get { return dataHostedVolunteerId; } set { dataHostedVolunteerId = value; } }
    public DataSet GetvillageId()
    {
        try
        {
            string strtext = "Sp_VillageMaster_Select";
            return SqlHelper.ExecuteDataset(Connection.con, CommandType.StoredProcedure, strtext);


        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }
    public DataSet GetActivityId()
    {
        try
        {
            string strtext = "Sp_ActivityMaster_Select";
            return SqlHelper.ExecuteDataset(Connection.con, CommandType.StoredProcedure, strtext);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }

    }
    public int InsertActivityMonitoringMaster()
    {
        try
        {
            SqlParameter[] p = new SqlParameter[5];

            p[0] = new SqlParameter("@ActivityId", ActivityId);
            p[1] = new SqlParameter("@VillageId", VillageId);
            p[2] = new SqlParameter("@ActivityPercentCompleted", ActivityPercentCompleted);
            p[3] = new SqlParameter("@ActivityCompletedDetails", ActivityCompletedDetails);
                p[4] = new SqlParameter("@DataHostedVolunteerId", DataHostedVolunteerId);

                int i = SqlHelper.ExecuteNonQuery(Connection.con, CommandType.StoredProcedure, "Sp_ActivityMonitoringMaster_Insert", p);
            return i;
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }

    }
}
