/*
 * Created by SharpDevelop.
 * User: victor
 * Date: 15.07.2020
 * Time: 17:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Data;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace VMail
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class AccParamEditForm : Form
	{	
		DataTable paramTable = new DataTable () ;
		
		
		public AccParamEditForm()
		{	
			this.InitializeComponent();	
			ParamExpo() ;
		}
		
		
		void ParamExpo() {
	
			
			accountParamDataGridView.Rows.Add(new DataGridViewRow( )) ;
			accountParamDataGridView.Rows[0].Cells["paramName"].Value = "Электронный адрес" ;
			accountParamDataGridView.Rows[0].Cells["accParamValue"].Value = GlobalData.myAddress ; 
			
			accountParamDataGridView.Rows.Add(new DataGridViewRow( )) ;
			accountParamDataGridView.Rows[1].Cells["paramName"].Value = "Login" ;
			accountParamDataGridView.Rows[1].Cells["accParamValue"].Value = GlobalData.login ; 			
					
			accountParamDataGridView.Rows.Add(new DataGridViewRow( )) ;
			accountParamDataGridView.Rows[2].Cells["paramName"].Value =  "Пароль" ;
			accountParamDataGridView.Rows[2].Cells["accParamValue"].Value =  GlobalData.password ;
			
			accountParamDataGridView.Rows.Add(new DataGridViewRow( )) ;
			accountParamDataGridView.Rows[3].Cells["paramName"].Value =  "Номер POP порта" ;
			accountParamDataGridView.Rows[3].Cells["accParamValue"].Value =  GlobalData.popPort ;	
			
			accountParamDataGridView.Rows.Add(new DataGridViewRow( )) ;
			accountParamDataGridView.Rows[4].Cells["paramName"].Value =  "Имя почтовго хостинга" ;
			accountParamDataGridView.Rows[4].Cells["accParamValue"].Value =  GlobalData.hostname ;
			
			
						
			accountParamDataGridView.Rows.Add(new DataGridViewRow( )) ;
			accountParamDataGridView.Rows[5].Cells["paramName"].Value =  "Моя подпись" ;
			accountParamDataGridView.Rows[5].Cells["accParamValue"].Value = GlobalData.mySignature ;

			accountParamDataGridView.Rows.Add(new DataGridViewRow( )) ;
			accountParamDataGridView.Rows[6].Cells["paramName"].Value =  "Каталог для загрузок вложений" ;
			accountParamDataGridView.Rows[6].Cells["accParamValue"].Value =GlobalData.downloadDir ;	

			//smtp_server
			accountParamDataGridView.Rows.Add(new DataGridViewRow( )) ;
			accountParamDataGridView.Rows[7].Cells["paramName"].Value =  "Smtp сервер" ;
			accountParamDataGridView.Rows[7].Cells["accParamValue"].Value =GlobalData.smtp ;
			
			accountParamDataGridView.Rows.Add(new DataGridViewRow( )) ;
			accountParamDataGridView.Rows[8].Cells["paramName"].Value =  "Порт SMTP" ;
			accountParamDataGridView.Rows[8].Cells["accParamValue"].Value =  GlobalData.port ;			
			
				
		}
		
		void  SaveParam (Object sender, MouseEventArgs e) {
			
			MessageBox.Show("СОХРАНИТЬ ?") ;
			
			StreamWriter SR = new StreamWriter("config.ini") ;
			
						
			//accountParamDataGridView.Rows[0].Cells["paramName"].Value = "Электронный адрес" ;
			SR.WriteLine ("my_address #"+accountParamDataGridView.Rows[0].Cells["accParamValue"].Value+"#") ;
			GlobalData.myAddress = (string) accountParamDataGridView.Rows[0].Cells["accParamValue"].Value ;
			
			SR.WriteLine ("my_login #"+accountParamDataGridView.Rows[1].Cells["accParamValue"].Value+"#") ;
			GlobalData.login = (string) accountParamDataGridView.Rows[1].Cells["accParamValue"].Value ;			
			
			
			//accountParamDataGridView.Rows[1].Cells["paramName"].Value =  "Пароль" ;
			SR.WriteLine ("password #" + accountParamDataGridView.Rows[2].Cells["accParamValue"].Value+"#") ;
			GlobalData.password = (string) accountParamDataGridView.Rows[2].Cells["accParamValue"].Value ;
			
			//accountParamDataGridView.Rows[2].Cells["paramName"].Value =  "Порт SMTP" ;
			SR.WriteLine("smtp_port #" + accountParamDataGridView.Rows[8].Cells["accParamValue"].Value+"#" );
			GlobalData.port = (string) accountParamDataGridView.Rows[8].Cells["accParamValue"].Value ;
			
			//accountParamDataGridView.Rows[3].Cells["paramName"].Value =  "Имя почтовго хостинга" ;
			SR.WriteLine("host_name #" + accountParamDataGridView.Rows[4].Cells["accParamValue"].Value +"#" ) ;
			GlobalData.hostname = (string) accountParamDataGridView.Rows[4].Cells["accParamValue"].Value ;
			
			//accountParamDataGridView.Rows[4].Cells["paramName"].Value =  "Номер POP порта" ;
			SR.WriteLine("pop_port #" + accountParamDataGridView.Rows[3].Cells["accParamValue"].Value +"#") ;
			GlobalData.popPort = (string) accountParamDataGridView.Rows[3].Cells["accParamValue"].Value ;
			
			//accountParamDataGridView.Rows[5].Cells["paramName"].Value =  "Моя подпись" ;
			SR.WriteLine ("signature #" + accountParamDataGridView.Rows[5].Cells["accParamValue"].Value +"#");
			GlobalData.mySignature = (string) accountParamDataGridView.Rows[5].Cells["accParamValue"].Value ;
			
			//accountParamDataGridView.Rows[6].Cells["paramName"].Value =  "Каталог для загрузок вложений" ;
			SR.WriteLine ("download_to #" + accountParamDataGridView.Rows[6].Cells["accParamValue"].Value +"#");
			GlobalData.downloadDir = (string) accountParamDataGridView.Rows[6].Cells["accParamValue"].Value ;
			
					//smtp_server 
			SR.WriteLine ("smtp_server #" + accountParamDataGridView.Rows[7].Cells["accParamValue"].Value +"#");
			GlobalData.smtp = (string) accountParamDataGridView.Rows[7].Cells["accParamValue"].Value ;				
			
			SR.Dispose() ;
			SR.Close() ;
			
			GetConfigClass GCC = new GetConfigClass() ;
			GCC.GetConfiruration() ;
			GCC = null ;
			
			MessageBox.Show("Параметры учетной записи сохранены") ;
		}
	}
}
