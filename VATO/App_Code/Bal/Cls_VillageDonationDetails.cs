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
/// Summary description for Cls_VillageDonationDetails
/// </summary>
public class Cls_VillageDonationDetails
{

    private int villageDonationId;
    private int donationId;
    private int activityId;
    private int villageId;
    private int memberIdorUserId;
    private decimal  amountDonated;
    private string remarksforDonation;
    private DateTime  villageDonationDate;
    private int paymentTypeId;
    private int inteoducedVolunteerId;

    // constructor
    public Cls_VillageDonationDetails()
    {
    }

    public int VillageDonationId { get { return villageDonationId; } set { villageDonationId = value; } }
    public int DonationId { get { return donationId; } set { donationId = value; } }
    public int ActivityId { get { return activityId; } set { activityId = value; } }
    public int VillageId { get { return villageId; } set { villageId = value; } }
    public int MemberIdorUserId { get { return memberIdorUserId; } set { memberIdorUserId = value; } }
    public decimal  AmountDonated { get { return amountDonated; } set { amountDonated = value; } }
    public string RemarksforDonation { get { return remarksforDonation; } set { remarksforDonation = value; } }
    public DateTime  VillageDonationDate { get { return villageDonationDate; } set { villageDonationDate = value; } }
    public int PaymentTypeId { get { return paymentTypeId; } set { paymentTypeId = value; } }
    public int InteoducedVolunteerId { get { return inteoducedVolunteerId; } set { inteoducedVolunteerId = value; } }
   
    public DataSet GetPaymentTypeId()
    {
        try
        {
            string strText = "Sp_PaymentTypeMaster_Select";
            return SqlHelper.ExecuteDataset(Connection.con, CommandType.StoredProcedure, strText);
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }
    public DataSet GetDonationMasterData()
    {
        try
        {
            string strText = "sp_VillageDonationsMaster_Select";
            return SqlHelper.ExecuteDataset(Connection.con, CommandType.StoredProcedure, strText);
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }
    public DataSet GetDonationIdData(int Donatd)
    {
        try
        {
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@DonationID  ", Donatd);
            string strText = "Sp_DontaionId_select";
            return SqlHelper.ExecuteDataset(Connection.con, CommandType.StoredProcedure, strText,p);
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }
    public DataSet GetVolunteerMasterId()
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

    public int InsertVillageDonationDetails()
    {
        try
        {
            SqlParameter[] p = new SqlParameter[8];

            p[0] = new SqlParameter("@DonationId  ", DonationId);
            p[1] = new SqlParameter("@ActivityId  ", ActivityId);
            p[2] = new SqlParameter("@VillageId  ", VillageId);

            p[3] = new SqlParameter("@MemberIdorUserId   ", MemberIdorUserId);
            p[4] = new SqlParameter("@AmountDonated   ", AmountDonated);
            p[5] = new SqlParameter("@RemarksforDonation   ", RemarksforDonation);
            p[6] = new SqlParameter("@PaymentTypeId    ", PaymentTypeId);
            p[7] = new SqlParameter("@InteoducedVolunteerId    ", InteoducedVolunteerId);

            int i = SqlHelper.ExecuteNonQuery(Connection.con, CommandType.StoredProcedure, "Sp_VillageDonationDetails_Insert", p);
            return i;
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }
}