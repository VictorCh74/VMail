/*
 * Created by SharpDevelop.
 * User: blinov.va
 * Date: 05.08.2020
 * Time: 11:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing.Printing;
using System.Drawing ;
using System.Windows.Forms ;
using System.Collections.Specialized ;

namespace VMail
{
	/// <summary>
	/// Description of PrintHeaderClass.
	/// </summary>
	public class PrintHeaderClass
	{
		
		String printText = "" ;
		private PrintDocument PD = new PrintDocument();
		
		string PrinterName = GlobalData.prinrterName ;
		PrinterSettings PS = new PrinterSettings();

		public PrintHeaderClass(String printText)
		{
			this.printText = printText ;
					
			PS.PrinterName = GetDefaultPrName(PD) ;
			PD.PrinterSettings = PS;
			
			PD.PrintPage += new PrintPageEventHandler(PD_PrintPage);
			PD.Print() ;
		}
		
		private void PD_PrintPage(object sender, PrintPageEventArgs e)
		{			
   			Font PrintFont = new Font("Times New Roman", 4, FontStyle.Regular, GraphicsUnit.Millimeter);	
   			e.Graphics.DrawString(printText, PrintFont, Brushes.Black, new PointF(0, 0));
		}
		
		string GetDefaultPrName(PrintDocument pd) {
			
			PrinterSettings setting = new PrinterSettings() ;
			foreach (String pr in PrinterSettings.InstalledPrinters ) {
				setting.PrinterName = pr ;
				if (setting.IsDefaultPrinter){
					setting = null ;
					return pr ;
				}
			}
			MessageBox.Show("Ошибка печати." +
			                "Не установлен принтер.") ;
			return null;
			
			
		}
		
	}
}
