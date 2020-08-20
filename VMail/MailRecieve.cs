/*
 * Created by SharpDevelop.
 * User: victor
 * Date: 10.02.2019
 * Time: 9:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

using System.Data;
using System.Collections.Generic;
using OpenPop.Mime;
using OpenPop.Pop3;
using System.Threading;
using System.Threading.Tasks;


namespace VMail
{
	/// <summary>
	/// Description of MailRecieve.
	/// </summary>
	public class MailRecieve
	{
		int MESSAGE_NUMBER = GlobalData.MESSAGE_NUMBER ;
		
		Pop3Client client ;
		string hostname  = GlobalData.hostname ;
		int port = 	Convert.ToInt32( GlobalData.popPort) ;
		bool useSsl = true ;
		public string [ , ] RetData = new string [GlobalData.MESSAGE_NUMBER , 3];		
		
	
		

		public MailRecieve()
		{		
		}

		List<Message> PickMes (int FirstMes , int LastMes ) {
							
							GifShowClass GC = new GifShowClass() ;
							GC.Show() ;
	
							
							byte [] [] MessBody = new byte [GlobalData.MESSAGE_NUMBER][];
							List<Message> Messages = new List<Message>() ;
			
			
							byte[] BodyB = new byte[1] ;
							//string Addrrr = "" ;
        					// We want to download all messages
 							int messageCount = 0;
        					messageCount = client.GetMessageCount();
        					if(  messageCount < LastMes) {
        						 LastMes = messageCount ;
        					}
        					int i = 0;
        					for(int j = messageCount - FirstMes ; j >  messageCount - LastMes ; j--){
        						Message MS =  client.GetMessage(j) ;
        						Messages.Add(MS) ;
 								i++; 
								MS = null ;
								GC.Drive() ;
        					}
      						
							GC.Close() ;
							GC = null ;
        					return Messages ;
        					
        					
		}
		
		public List<Message> Main_Work	(int FirstMes = 0 , int LastMes = 30) {
			
			
			List<Message> Messages = new List<Message>() ;
			
			GlobalData.FirstMes = FirstMes ;
			GlobalData.LastMes = LastMes ;
			
			// подключение к почте
			client = new Pop3Client() ;
			client.Connect(hostname, port, useSsl);
			// Authenticate ourselves towards the server : логин и пароль
			
			client.Authenticate(GlobalData.login, GlobalData.password);
			
			Messages = PickMes(FirstMes , LastMes ) ;
			

			return Messages ;
		}
		
		
		
	}
}


