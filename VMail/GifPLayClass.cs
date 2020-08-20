/*
 * Created by SharpDevelop.
 * User: blinov.va
 * Date: 02.07.2020
 * Time: 16:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 //НЕ ИСПОЛЬЗУЕТСЯ
 
using System;
using System.Drawing ;
using System.Windows.Forms ;

namespace VMail
{
	/// <summary>
	/// Description of GifPLayClass.
	/// </summary>
	public class GifPLayClass : Form
	{
		
		Bitmap animatedImage = new Bitmap("Loading.gif");
		
		
		
		
		public GifPLayClass()
		{
			Inisialize () ; //-- написать. большой размер сделать.
            ImageAnimator.Animate(animatedImage, new EventHandler(this.OnFrameChanged));
  			ImageAnimator.UpdateFrames() ;
  			this.TopLevel = true ;
		}
		
		public void AnimateImage() {
                     
			
			//Begin the animation only once.
            ImageAnimator.Animate(animatedImage, new EventHandler(this.OnFrameChanged));
  			ImageAnimator.UpdateFrames() ;
    	}
		
		private void OnFrameChanged(object o, EventArgs e) 
    	{
                     
        	//Force a call to the Paint event handler.
       		 this.Invalidate();
    	}
		
		protected override void OnPaint(PaintEventArgs e) 
    	{
                     
        	//Begin the animation.
        	AnimateImage();
                     
        	//Get the next frame ready for rendering.
        	ImageAnimator.UpdateFrames();
                     
        	//Draw the next frame in the animation.
        	e.Graphics.DrawImage(this.animatedImage , new PointF(0,0));
    	}
		
		/*piblic void StopAnimaate() {
			ImageAnimator.StopAnimate(Image, new EventHandler (animatedImage, new EventHandler(this.OnClosed)) ;
		}*/
	
		void Inisialize () {
			this.StartPosition = FormStartPosition.CenterScreen ;
			this.Width = 800 ;
			this.Height = 700 ;
			this.FormBorderStyle = FormBorderStyle.None ;
			this.AutoSize = true ;
			
		}
		
	}
}
