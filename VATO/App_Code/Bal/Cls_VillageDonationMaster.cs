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
/// Summary description for Cls_VillageDonationMaster
/// </summary>
public class Cls_VillageDonationsMaster
{
    
    private int donationId;
    private DateTime  donationRegDate;
    private int activityId;
    private int villageId;
    private decimal  donationAmountexpected;
    private decimal  donationAmountCollatedtillnow;
    private string donationDescription;
    private int donationAcquiredMembersCount;
    private decimal  donationMinimumAmountAccepted;

    // constructor
    public Cls_VillageDonationsMaster()
    {
    }

    public int DonationId { get { return donationId; } set { donationId = value; } }
    public DateTime  DonationRegDate { get { return donationRegDate; } set { donationRegDate = value; } }
    public int ActivityId { get { return activityId; } set { activityId = value; } }
    public int VillageId { get { return villageId; } set { villageId = value; } }
    public decimal  DonationAmountexpected { get { return donationAmountexpected; } set { donationAmountexpected = value; } }
    public decimal DonationAmountCollatedtillnow { get { return donationAmountCollatedtillnow; } set { donationAmountCollatedtillnow = value; } }
    public string DonationDescription { get { return donationDescription; } set { donationDescription = value; } }
    public int DonationAcquiredMembersCount { get { return donationAcquiredMembersCount; } set { donationAcquiredMembersCount = value; } }
    public decimal  DonationMinimumAmountAccepted { get { return donationMinimumAmountAccepted; } set { donationMinimumAmountAccepted = value; } }

    public int InsertVillageDonationMaster()
    {
        try
        {
            SqlParameter[] p = new SqlParameter[6];
         
            p[0] = new SqlParameter("@ActivityId ", ActivityId);
            p[1] = new SqlParameter("@VillageId ", VillageId);
            p[2] = new SqlParameter("@DonationAmountexpected ", DonationAmountexpected);
          
            p[3] = new SqlParameter("@DonationDescription  ", DonationDescription);
            p[4] = new SqlParameter("@DonationAcquiredMembersCount  ", DonationAcquiredMembersCount);
            p[5] = new SqlParameter("@DonationMinimumAmountAccepted  ", DonationMinimumAmountAccepted);
            int i = SqlHelper.ExecuteNonQuery(Connection.con, CommandType.StoredProcedure, "Sp_VillageDonationsMaster_Insert", p);
            return i;
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }

    public DataSet GetActivityIdData()
    {
        try
        {
            string strText = "Sp_ActivityMaster_Select";
            return SqlHelper.ExecuteDataset(Connection.con, CommandType.StoredProcedure, strText);
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }
    public DataSet GetVillageIdData()
    {
        try
        {
            string strText = "Sp_VillageMaster_Select";
            return SqlHelper.ExecuteDataset(Connection.con, CommandType.StoredProcedure, strText);
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }

    public static DataSet GetVillageDonationsByUsers()
    {
        try
        {
            string strText = "sp_GetVillageDonationsByUsers";
            return SqlHelper.ExecuteDataset(Connection.con, CommandType.StoredProcedure, strText);
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }


    public static DataSet GetAllMembersVillageDonations()
    {
        try
        {
            string strText = "sp_GetAllMembersVillageDonations";
            return SqlHelper.ExecuteDataset(Connection.con, CommandType.StoredProcedure, strText);
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }
}