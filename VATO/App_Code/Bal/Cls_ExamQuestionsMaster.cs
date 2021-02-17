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
/// Summary description for Cls_ExamQuestionsMaster
/// </summary>
public class Cls_ExamQuestionsMaster
{

    private int questionId;
    private string questiontext;
    private string answer1;
    private string answers2;
    private string answers3;
    private string answer4;
    private string correctAnswer;
    private int examinationId;
    private int marks;

    // constructor
    public Cls_ExamQuestionsMaster()
    {
    }

    public int QuestionId { get { return questionId; } set { questionId = value; } }
    public string Questiontext { get { return questiontext; } set { questiontext = value; } }
    public string Answer1 { get { return answer1; } set { answer1 = value; } }
    public string Answers2 { get { return answers2; } set { answers2 = value; } }
    public string Answers3 { get { return answers3; } set { answers3 = value; } }
    public string Answer4 { get { return answer4; } set { answer4 = value; } }
    public string CorrectAnswer { get { return correctAnswer; } set { correctAnswer = value; } }
    public int ExaminationId { get { return examinationId; } set { examinationId = value; } }
    public int Marks { get { return marks; } set { marks = value; } }

    public int InsertQuestionAndAnswers()
    {
        try
        {
            SqlParameter[] p = new SqlParameter[8];
            p[0]=new SqlParameter("@Questiontext",Questiontext);
            p[1]=new SqlParameter("@Answer1",Answer1);
            p[2]=new SqlParameter("@Answers2",Answers2);
            p[3]=new SqlParameter("@Answers3",Answers3);
            p[4]=new SqlParameter("@Answer4",Answer4);
            p[5]=new SqlParameter("@CorrectAnswer",CorrectAnswer);
            p[6]=new SqlParameter("@ExaminationId",ExaminationId);
            p[7] = new SqlParameter("@Marks", Marks);
            return SqlHelper.ExecuteNonQuery(Connection.con,CommandType.StoredProcedure,"Sp_ExamQuestionsMaster_Insert",p);
            

        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }

    public static int  Updatestatus(int id, bool p1)
    {
        try
        {
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@id", id);
            p[1] = new SqlParameter("@status", p1);
            return SqlHelper.ExecuteNonQuery(Connection.con, CommandType.StoredProcedure, "Sp_UpdateExamstatus", p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
}
