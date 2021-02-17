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

/// <summary>
/// Summary description for ClsActivityQuestionMaster
/// </summary>
public class Cls_ActivityQuestionMaster
{

    private int activityId;
    private int questionId;
    private DateTime  questionRegDate;
    private string questionDescription;

    // constructor
    public Cls_ActivityQuestionMaster()
    {
    }

    public int ActivityId { get { return activityId; } set { activityId = value; } }
    public int QuestionId { get { return questionId; } set { questionId = value; } }
    public DateTime  QuestionRegDate { get { return questionRegDate; } set { questionRegDate = value; } }
    public string QuestionDescription { get { return questionDescription; } set { questionDescription = value; } }
}
