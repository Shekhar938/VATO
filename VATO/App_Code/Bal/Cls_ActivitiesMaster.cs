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
/// Summary description for Cls_ActivitiesMaster
/// </summary>
public class Cls_ActivityMaster
{

    private int activityId;
    private string activityName;
    private string activityAbbr;
    private string activityDesc;

    // constructor
    public Cls_ActivityMaster()
    {
    }

    public int ActivityId { get { return activityId; } set { activityId = value; } }
    public string ActivityName { get { return activityName; } set { activityName = value; } }
    public string ActivityAbbr { get { return activityAbbr; } set { activityAbbr = value; } }
    public string ActivityDesc { get { return activityDesc; } set { activityDesc = value; } }
    public static DataSet GetActivityId()
    {
        try
        {
            string strcmdText = "select * from tbl_ActivityMaster";
            return SqlHelper.ExecuteDataset(Connection.con , CommandType.Text, strcmdText);
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }
}
