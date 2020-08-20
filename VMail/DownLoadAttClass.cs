/*
 * Created by SharpDevelop.
 * User: blinov.va
 * Date: 05.08.2020
 * Time: 16:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using OpenPop.Mime;
using System.Collections.Generic;
using System.Windows.Forms;



namespace VMail
{
	/// <summary>
	/// Description of DonLoadAttClass1.
	/// </summary>
	public class DownLoadAttClass
	{	
		List <MessagePart> att ;
		string foldername = "" ;
		
		public DownLoadAttClass(List<MessagePart> att)
		{
			this.att = att ;		
		}
		
		public void Save () {
			
			SaveFileDialog sfd = new SaveFileDialog() ;
			sfd.FileName = "__@@" ;
			sfd.FileOk += GetPath ;
			sfd.ShowDialog() ;
			sfd = null ;
			
			foreach(MessagePart at in att) {
				File.WriteAllBytes( foldername+"/" + at.FileName , at.Body) ;
			}
			
			 MessageBox.Show("Файлы сохранены") ;
		}
		
		void GetPath (object sender, System.ComponentModel.CancelEventArgs e) {
			foldername = ((SaveFileDialog) sender).FileName ;
			foldername = foldername.Remove (foldername.Length-5) ;
		}
	
		
	}
}
