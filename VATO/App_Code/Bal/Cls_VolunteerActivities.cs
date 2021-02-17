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
/// Summary description for Cls_VolunteerActivities
/// </summary>
public class Cls_VoluntereActivities
{

    private int activityConductedId;
    private int volunteerId;
    private DateTime  activityConductedDate;
    private int villageId;
    private int caseStudyId;
    private string caseStudyDetailedDescription;
    private string caseStudyOutCome;

    // constructor
    public Cls_VoluntereActivities()
    {
    }

    public int ActivityConductedId { get { return activityConductedId; } set { activityConductedId = value; } }
    public int VolunteerId { get { return volunteerId; } set { volunteerId = value; } }
    public DateTime  ActivityConductedDate { get { return activityConductedDate; } set { activityConductedDate = value; } }
    public int VillageId { get { return villageId; } set { villageId = value; } }
    public int CaseStudyId { get { return caseStudyId; } set { caseStudyId = value; } }
    public string CaseStudyDetailedDescription { get { return caseStudyDetailedDescription; } set { caseStudyDetailedDescription = value; } }
    public string CaseStudyOutCome { get { return caseStudyOutCome; } set { caseStudyOutCome = value; } }
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
        try {
            string strtext = "Sp_VillageMaster_Select";
            return SqlHelper.ExecuteDataset(Connection.con, CommandType.StoredProcedure, strtext);
        

        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }

    public DataSet GetCaseStudyId()
    {
        try {
            string strtext = "Sp_CaseStudyMaster_Select";
            return SqlHelper.ExecuteDataset(Connection.con, CommandType.StoredProcedure, strtext);
        
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    
    }
    public int InsertVolunteerActivities()
    {try
    {
        SqlParameter[] p = new SqlParameter[6];
    p[0]=new SqlParameter("@VolunteerId",VolunteerId );
    p[1] = new SqlParameter("@ActivityConductedDate", ActivityConductedDate);
    p[2] = new SqlParameter("@VillageId", VillageId);
    p[3] = new SqlParameter("@CaseStudyId", CaseStudyId);
    p[4] = new SqlParameter("@CaseStudyDetailedDescription", CaseStudyDetailedDescription);
    p[5] = new SqlParameter("@CaseStudyOutCome", CaseStudyOutCome);
    int i = SqlHelper.ExecuteNonQuery(Connection.con, CommandType.StoredProcedure, "Sp_VoluntereActivities_Insert", p);
    return i;
    }
catch (Exception ex)
    {
    throw new ArgumentException(ex.Message);
}

    }

}
