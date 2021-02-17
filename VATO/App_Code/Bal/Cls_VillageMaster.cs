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
using BackToMyVillage;

/// <summary>
/// Summary description for Cls_VillageMaster
/// </summary>
public class Cls_VillageMaster
{

    private int villageId;
    private string villageName;
    private string villageAbbr;
    private string villageArea;
    private long  villagePopulation;
    private int villageEducationPercentage;

    // constructor
    public Cls_VillageMaster()
    {
    }

    public int VillageId { get { return villageId; } set { villageId = value; } }
    public string VillageName { get { return villageName; } set { villageName = value; } }
    public string VillageAbbr { get { return villageAbbr; } set { villageAbbr = value; } }
    public string VillageArea { get { return villageArea; } set { villageArea = value; } }
    public long  VillagePopulation { get { return villagePopulation; } set { villagePopulation = value; } }
    public int VillageEducationPercentage { get { return villageEducationPercentage; } set { villageEducationPercentage = value; } }
    
    public static DataSet GetAllVillageMaster()
    {
        try
        {
            string strCmdText = "select * from tbl_VillageMaster";
            return SqlHelper.ExecuteDataset(Connection.con , CommandType.Text, strCmdText);
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }
}