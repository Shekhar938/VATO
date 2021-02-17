using System;
using System.Collections;
	/// <summary>
	/// Summary description for Chat.
	/// </summary>
public class Chat
{
    static protected ArrayList pArray = new ArrayList();

    static public void ClearData()
    {
        pArray.Clear();
    }

    static public void AddMessage(string sDealer, string sUser, string sMsg)
    {
        string sAddText = sDealer + "~" + sUser + "~" + sMsg;
        pArray.Add(sAddText);

        if (pArray.Count > 200)
        {
            pArray.RemoveRange(0, 10);
        }
    }

    static public string GetAllMessages(string sDealer)
    {
        string sResponse = "";

        for (int i = 0; i < pArray.Count; i++)
        {
            sResponse = sResponse + FormatChat(pArray[i].ToString(), sDealer);
        }
        return (sResponse);
    }

    static private string FormatChat(string sLine, string sDealer)
    {
        int iFirst = sLine.IndexOf("~");
        int iLast = sLine.LastIndexOf("~");

        string sDeal = sLine.Substring(0, iFirst);
        if (sDeal != sDealer)
            return ("");

        string sUser = sLine.Substring(iFirst + 1, iLast - (iFirst + 1));

        string sMsg = sLine.Substring(iLast + 1);

        string sRet = "<span style=font-weight:bold;font-family:Verdana;font-size:10px;color:Red>" + sUser + ": </span>" + "<span style=font-weight:bold;font-family:Verdana;font-size:10px;color:Black>" + sMsg + "</span>" + "<BR>";

        return (sRet);
    }
}

