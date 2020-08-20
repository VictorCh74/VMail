/*
 * Created by SharpDevelop.
 * User: victor
 * Date: 02.05.2020
 * Time: 22:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Collections.Generic;
using OpenPop.Mime;
using OpenPop.Pop3;


namespace VMail
{
	/// <summary>
	/// Description of InputTable.
	/// </summary>
	public class InputTable
	{
		DataTable mailDataTable =  new DataTable () ;
		
		public InputTable()
		{
			
		}
		public InputDataClass GetInputData() {
			
			

			List<Message> Messages ;
			
			DataTable mailDataTable =  new DataTable () ;
			mailDataTable.Columns.Add(new DataColumn("Адрес")) ;
			mailDataTable.Columns.Add(new DataColumn("Тема")) ;
			mailDataTable.Columns.Add(new DataColumn("Дата и время")) ;
			GlobalData.LastMes = GlobalData.FirstMes + GlobalData.MESSAGE_NUMBER ;
			MailRecieve MR = new MailRecieve () ;
			
			Messages = MR.Main_Work(GlobalData.FirstMes , GlobalData.LastMes) ;
			
			 foreach (Message mes in Messages) {
				DataRow Row =  mailDataTable.NewRow() ;
				Row["Адрес"] = mes.Headers.From ;
				Row["Тема"] = mes.Headers.Subject ;
				Row["Дата и время"] = mes.Headers.Date ;
				mailDataTable.Rows.Add(Row) ;
			} 
	
			InputDataClass IDC = new InputDataClass() ;
			IDC.Messages = Messages ;
			IDC.mailDataTable = mailDataTable ;
			                                  
			return IDC ;
		}
		
		
	}
}
