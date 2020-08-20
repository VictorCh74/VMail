/*
 * Created by SharpDevelop.
 * User: victor
 * Date: 03.07.2020
 * Time: 17:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms ;
using System.Drawing ;
using System.Threading;
using System.Threading.Tasks;


namespace VMail
{
	/// <summary>
	/// Description of GifShowClass.
	/// </summary>
	public class GifShowClass : Form
	{
		//PictureBox PB = new PictureBox() ;
		PictureBox PB = new PictureBox() ;
		public Bitmap animatedImage = new Bitmap("Loading.gif");
		
		public GifShowClass()
		{
			Initialize() ;
			
		}
		
		void Initialize() {
		
			this.Width = 800 ;
			this.Height = 600 ;
			this.StartPosition = FormStartPosition.CenterScreen;
			this.FormBorderStyle = FormBorderStyle.None ;

			//this.BringToFront() ;
				
			PB.Location = new Point(0,0) ;
			PB.Width = this.Width ;
			PB.Height = this.Height;
			PB.Image = animatedImage ;
			//PB.BackColor = Color.Sienna ;
		
			this.Controls.Add(PB) ;
			PB.Refresh() ;
			//PB.BringToFront() ;
		
		}
		
		public void  Drive() {
		
			PB.Refresh() ;
			
		
		}
	}
}
