using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace SuperJockey
{
	/// <summary>
	/// Summary description for TheChatScreenWin.
	/// </summary>
	public partial class TheChatScreenWin : System.Web.UI.Page
	{
		protected void Page_Load(object sender, System.EventArgs e)
		{
			string sDealer="1";
			
			Response.Write( "<meta http-equiv=\"Refresh\"content=\"4\">" );
			Response.Write(Chat.GetAllMessages(sDealer));
		}
		#region Web Form Designer generated code

		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
    
		}
		#endregion
	}
}
