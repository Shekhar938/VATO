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
/// Summary description for Cls_PaymentTypeDonationDetails
/// </summary>
public class Cls_PaymentTypeDonationDetails
{

    private int villageDonationId;
    private int paymentTypeId;
    private int bankId;
    private DateTime dateofChequeorDD;
    private string  dDorCheckNO;
    private bool  dDorChequeBit;
    private string paymentStatus;
    private string chequeImagefilelname;
   
    private decimal  chequeDDAmount;
    

    // constructor
    public Cls_PaymentTypeDonationDetails()
    {
    }

    public int VillageDonationId { get { return villageDonationId; } set { villageDonationId = value; } }
    public int PaymentTypeId { get { return paymentTypeId; } set { paymentTypeId = value; } }
    public int BankId { get { return bankId; } set { bankId = value; } }
    public DateTime  DateofChequeorDD { get { return dateofChequeorDD; } set { dateofChequeorDD = value; } }
    public string  DDorCheckNO { get { return dDorCheckNO; } set { dDorCheckNO = value; } }
    public bool  DDorChequeBit { get { return dDorChequeBit; } set { dDorChequeBit = value; } }
    public string PaymentStatus { get { return paymentStatus; } set { paymentStatus = value; } }
    public string ChequeImagefilelname { get { return chequeImagefilelname; } set { chequeImagefilelname = value; } }
   
    public decimal  ChequeDDAmount { get { return chequeDDAmount; } set { chequeDDAmount = value; } }

    public DataSet GetvillageDonationId()
    {
        try
        {
            string strText = "Sp_VillageDonationDetails_Select";
            return SqlHelper.ExecuteDataset(Connection.con, CommandType.StoredProcedure, strText);

        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }
    public DataSet GetDonationIdData(int VillageDonatd)
    {
        try
        {
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@VillageDonationID", VillageDonatd);
            string strText = "Sp_VillageDontaionId_select";
            return SqlHelper.ExecuteDataset(Connection.con, CommandType.StoredProcedure, strText, p);
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }
    public DataSet GetBankmasterId()
    {
        try
        {
 string strText = "Sp_BankMaster_Select";
            return SqlHelper.ExecuteDataset(Connection.con, CommandType.StoredProcedure, strText);

        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    
    }

    public int InsertPaymentTypeDonationDetails()
    {
        try
        {
            SqlParameter[] p = new SqlParameter[8];

            p[0] = new SqlParameter("@VillageDonationId", VillageDonationId);
            p[1] = new SqlParameter("@PaymentTypeId", PaymentTypeId);
            p[2] = new SqlParameter("@BankId   ", BankId);

            p[3] = new SqlParameter("@DateofChequeorDD", DateofChequeorDD);
            p[4] = new SqlParameter("@DDorCheckNO", DDorCheckNO);
            p[5] = new SqlParameter("@PaymentStatus",PaymentStatus);
            p[6] = new SqlParameter("@ChequeImagefilelname", ChequeImagefilelname);
            p[7] = new SqlParameter("@ChequeDDAmount", ChequeDDAmount);

            int i = SqlHelper.ExecuteNonQuery(Connection.con, CommandType.StoredProcedure, "Sp_PaymentTypeDonationDetails_Insert", p);
            return i;
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }
}