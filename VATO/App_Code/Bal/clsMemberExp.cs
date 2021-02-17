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
/// Summary description for clsMemberExp
/// </summary>
public class clsMemberExp
{
	public clsMemberExp()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    private int experienceId;
    private string experienceDate;
    private int menberId;
    private string experienceDescription;
    private int ratingIdValue;
    private int activityId;
    private int villageId;

    public int ExperienceId { get { return experienceId; } set { experienceId = value; } }
    public string ExperienceDate { get { return experienceDate; } set { experienceDate = value; } }
    public int MenberId { get { return menberId; } set { menberId = value; } }
    public string ExperienceDescription { get { return experienceDescription; } set { experienceDescription = value; } }
    public int RatingIdValue { get { return ratingIdValue; } set { ratingIdValue = value; } }
    public int ActivityId { get { return activityId; } set { activityId = value; } }
    public int VillageId { get { return villageId; } set { villageId = value; } }

    public int InsertMembersExperiencesMaster()
    {
        try
        {
            SqlParameter[] p = new SqlParameter[5];
            p[0] = new SqlParameter("@MenberId", MenberId);
            p[1] = new SqlParameter("@ExperienceDescription", ExperienceDescription);
            p[2] = new SqlParameter("@RatingIdValue", RatingIdValue);
            p[3] = new SqlParameter("@ActivityId", ActivityId);
            p[4] = new SqlParameter("@VillageId", VillageId);
            return SqlHelper.ExecuteNonQuery(Connection.con , CommandType.StoredProcedure, "sp_MembersExperiencesMaster_Insert", p);
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }

    public static DataSet GetAcitivityCompletionData(int Id)
    {
        try
        {
            string str = "select * from tbl_ActivityMonitorDetails where ActivityMonitorId=" + Id;
            return SqlHelper.ExecuteDataset(Connection.con, CommandType.Text, str);
        }
        catch (Exception ex)
        {
             throw new ArgumentException(ex.Message);
        }
    }
}
