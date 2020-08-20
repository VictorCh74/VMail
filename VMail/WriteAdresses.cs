/*
 * Created by SharpDevelop.
 * User: blinov.va
 * Date: 02.12.2019
 * Time: 13:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace fastSender_v2
{
	/// <summary>
	/// Description of WriteAdresses.
	/// </summary>
	public class WriteAdresses
	{


		public WriteAdresses(string LineIn)
		{
	
			string AddrFileMame = @"addr.txt" ;
			
			FileInfo FI = new FileInfo (AddrFileMame) ;
			if (!FI.Exists)
			{
   					FI.Create();
   
			}
			
			//открывем и пишем в него
			    using (StreamWriter sw = new StreamWriter( AddrFileMame, false, System.Text.Encoding.Default))
    			{
        				sw.WriteLine(LineIn);
   			 	}
		}
	}
}
