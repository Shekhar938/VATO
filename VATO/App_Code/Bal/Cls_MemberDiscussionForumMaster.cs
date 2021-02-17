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
/// Summary description for Cls_MemberDiscussionForumMaster
/// </summary>
public class Cls_MemberDiscussionForumMaster {

		private int discussionId;
        private DateTime discussionDateOpen;
        private DateTime discussionDateClosed;
		private int memberId;
		private string disscussionTopicPorted;

		// constructor
		public Cls_MemberDiscussionForumMaster () {
		}

		public int DiscussionId {get {return discussionId;} set {discussionId = value;}}
		public DateTime  DiscussionDateOpen {get {return discussionDateOpen;} set {discussionDateOpen = value;}}
		public DateTime  DiscussionDateClosed {get {return discussionDateClosed;} set {discussionDateClosed = value;}}
		public int MemberId {get {return memberId;} set {memberId = value;}}
		public string DisscussionTopicPorted {get {return disscussionTopicPorted;} set {disscussionTopicPorted = value;}}


        private int discussionForumResponseId;
        private DateTime discussionForumResponseDate;        
        private string responseData;
        public int DiscussionForumResponseId { get { return discussionForumResponseId; } set { discussionForumResponseId = value; } }
        public DateTime DiscussionForumResponseDate { get { return discussionForumResponseDate; } set { discussionForumResponseDate = value; } }       
        public string ResponseData { get { return responseData; } set { responseData = value; } }

        public int InsertMemberDiscussionMaster()
        {
            try
            {
                SqlParameter[] p = new SqlParameter[3];
                p[0]=new SqlParameter("@DiscussionDateClosed",DiscussionDateClosed);
                p[1]=new SqlParameter("@MemberId",MemberId);
                p[2] = new SqlParameter("@DisscussionTopicPorted", DisscussionTopicPorted);
                return SqlHelper.ExecuteNonQuery(Connection.con,CommandType.StoredProcedure,"Sp_MemberDiscussionForumMaster_Insert",p);

            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }
        }


        public static DataSet  ShowmemberDiscussionforummaster()
        {
            try
            {
                DataSet ds = new DataSet();
                return SqlHelper.ExecuteDataset(Connection.con, CommandType.StoredProcedure, "Sp_ShowforumQuestiondisplay");
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }
        }

        public static DataSet Showmemberdiscussionforumidwise(int id)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlParameter p = new SqlParameter("@discussionid", id);
                return SqlHelper.ExecuteDataset(Connection.con, CommandType.StoredProcedure, "Sp_discussiontopicWiseAnswerDisplayId", p);
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }
        }
        public static DataSet Showmemberdiscussiontopicid(int id)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlParameter p = new SqlParameter("@discussionid", id);
                return SqlHelper.ExecuteDataset(Connection.con, CommandType.StoredProcedure, "Sp_forumdiscussionforumidselect", p);
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }
        }
        public int InserDisscussionforumdetails()
        {
            try
            {
                SqlParameter[] p = new SqlParameter[3];
                p[0] = new SqlParameter("@MemberId", MemberId );
                p[1]=new SqlParameter("@ResponseData",ResponseData);
                p[2] = new SqlParameter("@DiscussionId", DiscussionId);
                return SqlHelper.ExecuteNonQuery(Connection.con, CommandType.StoredProcedure, "Sp_DiscussionForumDetails_Insert", p);
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }
        }

}
