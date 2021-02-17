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

public partial class Admin_frmPaymentTypeDonationDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                GetVillageDonatinId();
                GetBankMasterId();
            }
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }
    Cls_PaymentTypeDonationDetails objPaymenttypedonationdetails = new Cls_PaymentTypeDonationDetails();

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            objPaymenttypedonationdetails.VillageDonationId = Convert.ToInt32(ddlVillageDonationID.SelectedValue);
            objPaymenttypedonationdetails.PaymentTypeId = Convert.ToInt32(ViewState["paymenttypeid"]);
            
            objPaymenttypedonationdetails.BankId = Convert.ToInt32(ddlBankName.SelectedValue);
            objPaymenttypedonationdetails.DateofChequeorDD  = Convert.ToDateTime(TxtDateofchequeordd.Text);
            objPaymenttypedonationdetails.DDorCheckNO = Convert.ToString(Txtchequeno.Text);
            objPaymenttypedonationdetails.PaymentStatus  = Convert.ToString(ddlPaymentstatus.SelectedValue);
            FileUpload1.SaveImage();
            string s = "~/Upload/" + Session["FileName"].ToString();
           
            objPaymenttypedonationdetails.ChequeImagefilelname = s;
            objPaymenttypedonationdetails.ChequeDDAmount = Convert.ToDecimal(TxttotalamoutDonated.Text);
            int i = objPaymenttypedonationdetails.InsertPaymentTypeDonationDetails();
            if (i > 0)
            {
                Cleardata();
                lblError.Text = "Recorded Inserted";
            }
            else
            {
                lblError.Text = "Recorded Not Inserted Try Again";
            }

        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        Cleardata();
    }
    
    protected void ddlVillageDonationID_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddlVillageDonationID.SelectedIndex != 0)
            {


                int VillageId = Convert.ToInt32(ddlVillageDonationID.SelectedValue);
                DataSet ds = objPaymenttypedonationdetails.GetDonationIdData(VillageId);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    TxtVillageName.Text = ds.Tables[0].Rows[0][1].ToString();

                    TxtActivityName.Text = ds.Tables[0].Rows[0][0].ToString();
                    TxtPaymentTypename.Text = ds.Tables[0].Rows[0][3].ToString();
                    TxttotalamoutDonated.Text = ds.Tables[0].Rows[0][4].ToString();
                    ViewState["paymenttypeid"] = ds.Tables[0].Rows[0][2].ToString();
             

                }

            }
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }

    void GetVillageDonatinId()
    {
        try
        {
            ddlVillageDonationID.Items.Clear();
            DataSet ds = objPaymenttypedonationdetails.GetvillageDonationId();
            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlVillageDonationID.DataSource = ds.Tables[0];
                //ddlDonationID.DataTextField = "VillageName";
                ddlVillageDonationID.DataValueField = "VillageDonationId";
                ddlVillageDonationID.DataBind();
            }
            ddlVillageDonationID.Items.Insert(0, "--Select One--");
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    void GetBankMasterId()
    {
        try
        {
            ddlBankName.Items.Clear();
            DataSet ds = objPaymenttypedonationdetails.GetBankmasterId();
            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlBankName.DataSource = ds.Tables[0];
                ddlBankName.DataTextField = "BankName";
                ddlBankName.DataValueField = "BankId";
                ddlBankName.DataBind();
            }
            ddlBankName.Items.Insert(0, "--Select One--");
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    
    }
    void Cleardata()
    {
        TxtActivityName.Text = "";
        Txtcheckddamout.Text = "";
        TxtVillageName.Text = "";
        if (ddlBankName.Items.Count != 0)
            ddlBankName.SelectedIndex = 0;
        if (ddlPaymentstatus.Items.Count != 0)
            ddlPaymentstatus.SelectedIndex = 0;
        if (ddlVillageDonationID.Items.Count != 0)
            ddlVillageDonationID.SelectedIndex = 0;
       
        Txtchequeno.Text = "";
        TxtDateofchequeordd.Text = "";
        TxtPaymentTypename.Text = "";

        TxttotalamoutDonated.Text = "";

    }
}
