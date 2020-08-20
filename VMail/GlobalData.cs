/*
 * Created by SharpDevelop.
 * User: Blinov.VA
 * Date: 13.02.2019
 * Time: 11:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace VMail
{
	/// <summary>
	/// Description of GlobalData.
	/// </summary>
	public class GlobalData
	{
		public GlobalData()
		{
		}
		static public string [ , ] RetData = new string [5 , 3];
		static public byte [] [] MessBody = new byte [5][];
		static public int CountOf5 = 0 ;
		static public MailRecieve MR = new MailRecieve () ;
		static public int MESSAGE_NUMBER = 15 ;
		static public int FirstMes ;
		static public int LastMes ;
		static public string myAddress = "" ;
		static public string password = "" ;
		static public string login = "" ;
		static public string mySignature = "" ;
		static public string downloadDir = "" ;
		static public string smtp = "" ;
		static public string port = "";
		static public string hostname = "" ;
		static public string popPort = "" ;
		//static public string JOURNAL_FILE = @"G:\GitPortable\Data\home\fastSender_v5\fastSender_v2\bin\Debug\journal.txt" ;
		static public string prinrterName = "HP LaserJet Pro MFP M426-M427 PCL 6";
		static public string rootFolder = "C:/Scan";
	}
}
