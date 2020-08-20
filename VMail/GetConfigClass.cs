/*
 * Created by SharpDevelop.
 * User: blinov.va
 * Date: 01.07.2020
 * Time: 14:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Text.RegularExpressions ;

namespace VMail
{
	/// <summary>
	/// Description of GetConfigClass.
	/// </summary>
	public class GetConfigClass
	{
		public GetConfigClass()
		{
		}
		
		public void GetConfiruration () {

			
			StreamReader SR = new StreamReader("config.ini") ;
		
			string configString = SR.ReadToEnd() ;
			//smtp
			Regex smtpRE = new Regex(@"smtp_server #\S*#") ;
			GlobalData.smtp = (smtpRE.Match(configString).Value).Replace("#","").Replace("smtp_server ","") ;
			
			//smtp_port
			Regex portRE = new Regex(@"smtp_port #\S*#") ;		
			GlobalData.port = (portRE.Match(configString).Value).Replace("#","").Replace("smtp_port ","") ;
			
			//host_name -- pop
			Regex hostnameRE = new Regex(@"host_name #\S*#") ;		
			GlobalData.hostname = (hostnameRE.Match(configString).Value).Replace("#","").Replace("host_name ","") ;
			
			
			//pop port
			Regex pop_portRE = new Regex(@"pop_port #\S*#") ;		
			GlobalData.popPort = (pop_portRE.Match(configString).Value).Replace("#","").Replace("pop_port ","") ;
			
			//свой адрес
			Regex addressRE = new Regex (@"my_address #\S*#") ;
			string adrStr = addressRE.Match(configString).Value ;
			adrStr = adrStr.Replace("#","") ;
			GlobalData.myAddress = adrStr.Replace("my_address ","") ;			
			
			
			//свой логин
			Regex loginRE = new Regex (@"my_login #\S*#") ;
			string login = loginRE.Match(configString).Value ;
			login = login.Replace("my_login #","") ;	
			login = login.Replace("#","") ;
			GlobalData.login = login ;
			

			
			//пароль
			Regex pswRE = new Regex(@"password #\S*#") ;		
			string psw = pswRE.Match(configString).Value ;
			psw = psw.Replace("#","") ;
			GlobalData.password = psw.Replace("password ","") ;
			
			//моя подпись
			Regex signRE = new Regex(@"signature #.*#") ;
			string signStr = signRE.Match(configString).Value ;	
			signStr = signStr.Replace("#", "");
			signStr = signStr.Replace("#", "");
			GlobalData.mySignature = signStr.Replace("signature ", "");
			
			
			//каталог для загрузок
			Regex downloadRE = new Regex(@"download_to #.*#") ;
			string downloadStr = downloadRE.Match(configString).Value ;
			downloadStr = downloadStr.Replace("#", "");
			GlobalData.downloadDir = downloadStr = downloadStr.Replace("download_to", "");
			
			SR.Dispose() ;
			SR.Close() ;
	
		}
		
		
	}
}
