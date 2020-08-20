/*
 * Created by SharpDevelop.
 * User: blinov.va
 * Date: 21.10.2019
 * Time: 15:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO ;
//using System.Text.RegularExpressions ;

namespace VMail
{
	/// <summary>
	/// Description of WriteLogClass.
	/// </summary>
	public class WriteLogClass
	{
		
		StreamWriter SR ;
		public WriteLogClass()
		{
		}
		public void OpenJournal () {
			SR = new StreamWriter ("Journal.txt" ,true) ;
		}
		
		public void CloseJournal() {
			SR.Dispose() ;
			SR.Close() ;
		}
		
		public void WriteString(string Adress, string  Name_Of_File , DateTime date) {
			//Regex RE = new Regex (@"\\.*$") ;
			
			SR.WriteLine(date.Date + "," + Adress + "," + Name_Of_File + "," + date.TimeOfDay) ;
		}
		
	}
}
