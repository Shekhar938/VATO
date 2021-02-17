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
/// Summary description for Cls_VillageVolunteerMaster
/// </summary>
public class Cls_VillageVolunteerMaster
{

    private int villageId;
    private int volunteerId;
    private int activityId;

    // constructor
    public Cls_VillageVolunteerMaster()
    {
    }

    public int VillageId { get { return villageId; } set { villageId = value; } }
    public int VolunteerId { get { return volunteerId; } set { volunteerId = value; } }
    public int ActivityId { get { return activityId; } set { activityId = value; } }
    public DataSet GetvolunteerId()
    {
        try
        {
            string strText = "Sp_VolunteerMaster_Select";
            return SqlHelper.ExecuteDataset(Connection.con, CommandType.StoredProcedure, strText);

        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }

    }
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
                return SqlHelper.ExecuteDataset(Connection.con,CommandType.StoredProcedure,strtext);
        }
        catch (Exception ex)
        {
            
           throw new ArgumentException(ex.Message);
        }
    
    }
    public DataSet GetVolunteerIdData(int   volunnid)
    {
        try
        {
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@VolunteerId", volunnid);
            string strtext = "Sp_VillageVolunteerMasterId_Select";
                return SqlHelper.ExecuteDataset(Connection.con,CommandType.StoredProcedure,strtext,p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }

    }
    public int InsertvillageVolunteermaster()
    {
        try
        {
            SqlParameter[] p = new SqlParameter[3];
            
            p[0]=new SqlParameter("@VolunteerId",VolunteerId);
            p[1] = new SqlParameter("@VillageId", VillageId);
            p[2] = new SqlParameter("@ActivityId",ActivityId);
            int i = SqlHelper.ExecuteNonQuery(Connection.con, CommandType.StoredProcedure, "Sp_VillageVolunteerMaster_Insert", p);
            return i;
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    
    }
}