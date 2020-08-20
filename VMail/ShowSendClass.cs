/*
 * Created by SharpDevelop.
 * User: blinov.va
 * Date: 30.07.2020
 * Time: 9:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Data;
using System.Windows.Forms;

namespace VMail
{
	/// <summary>
	/// Description of ShowSendClass.
	/// </summary>
	public class ShowSendClass
	{
		DataGridView dgw ;
		DataGridView dgwSend =  new DataGridView () ;
		//StreamReader SR = new StreamReader(  GlobalData.JOURNAL_FILE) ;
		StreamReader SR = new StreamReader(  "journal.txt") ;
		Panel panel ;
		
			
		public ShowSendClass(Panel panel, DataGridView dgw)
		{
			this.panel = panel ;
			this.dgw = dgw ;
			dgw.Visible = false ;
			panel.Controls.Add(dgwSend) ;
			//ReadJournal(0 , GlobalData.MESSAGE_NUMBER) ;
			ReadJournal() ;		
			dgwSend.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill ;
			dgwSend.Width = panel.Width - 50 ;
			dgwSend.Height = panel.Height - 20 ;
			
		}
		
		public void ReadJournal(int beginStr , int endStr) {
			DataTable table = new DataTable("Отправленные") ;

			
			SR = new StreamReader(  "journal.txt") ;	
			string inLine = SR.ReadLine() ;
			for(int i=0 ; i < (inLine.Split(',')).Length; i++) {
						table.Columns.Add() ;	
			}
			
			SR.Dispose() ;
			SR.Close() ;
			SR = new StreamReader( "journal.txt") ; //возвращаемся на первую строку файла
			
			for(int i = 0 ; i < endStr; i++) {
				if(i >= beginStr && inLine != null )
					table.Rows.Add( inLine.Split(',')) ;
			    	inLine = SR.ReadLine() ;
			}
			SR.Dispose() ;
			SR.Close() ;			
			
			
			/*while( ( inLine!= null) ) {
		
				table.Rows.Add( inLine.Split(',')) ;
			    inLine = SR.ReadLine() ;
			}*/
			
			dgwSend.DataSource = table ;		
			dgwSend.Visible = true ;
		}
		
		public void ReadJournal() {
			DataTable table = new DataTable("Отправленные") ;
			int key_id = 0 ;
			
			SR = new StreamReader(  "journal.txt") ;	
			table.Columns.Add() ;
			table.Columns[0].Unique = true ;
			string inLine = SR.ReadLine() ;
			for(int i=0 ; i < (inLine.Split(',')).Length; i++) {
						table.Columns.Add() ;	
			}
			
			
			while (inLine != null ) {
				++ key_id ;
				inLine = key_id + "," + inLine ;
				table.Rows.Add(inLine.Split(',')) ;
			    inLine = SR.ReadLine() ;	
			}
			
			SR.Dispose();
			SR.Close();
			
			dgwSend.DataSource = table ;
			
			int ii = 0 ;
			foreach(DataGridViewRow rd in dgwSend.Rows) {
				rd.Cells[0].Value = Convert.ToInt32(rd.Cells[0].Value) ;
				rd.HeaderCell.Value = ii ++ ;
			}
			
			//dgwSend.Sort( dgwSend.Columns[0] , System.ComponentModel.ListSortDirection.Descending ) ;
			dgwSend.Visible = true ;
			
		}
	}
}
