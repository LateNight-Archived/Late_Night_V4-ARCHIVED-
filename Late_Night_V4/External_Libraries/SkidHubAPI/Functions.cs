using System;
using System.Net;
using Late_Night_V3_colnsole;
using Newtonsoft.Json;

namespace Late_Night_V4.External_Libraries.SkidHubAPI
{
	// Token: 0x0200002E RID: 46
	internal class Functions
	{
		// Token: 0x060001B2 RID: 434 RVA: 0x000131C8 File Offset: 0x000113C8
		internal static NetworkingObject.User LoginWithSkidID(string Key)
		{
			NetworkingObject.User user2;
			try
			{
				string text = new WebClient().DownloadString("https://api.skid-hub.com/LoginID?Key=" + Key);
				NetworkingObject.User user = JsonConvert.DeserializeObject<NetworkingObject.User>(text);
				bool flag = user == null;
				if (flag)
				{
					LNCcolnsole.WARN("[Log In] : User Is Null", false, ConsoleColor.Yellow);
				}
				bool banned = user.Banned;
				if (banned)
				{
					LNCcolnsole.ERROR("[Log In] : User Is BANNED", false, ConsoleColor.Red);
				}
				bool flag2 = !user.HasPlan("Registered");
				if (flag2)
				{
					LNCcolnsole.WARN("[Log In] : User isnt Fully Registered", false, ConsoleColor.Yellow);
				}
				user2 = user;
			}
			catch
			{
				LNCcolnsole.ERROR("[Log In] : FAILED TO LOG IN", false, ConsoleColor.Red);
				return null;
			}
			LNCcolnsole.Log("[Log In] : Logged In As : " + user2.Username, false, ConsoleColor.White);
			return user2;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00013298 File Offset: 0x00011498
		internal static NetworkingObject.User LoginWithUsernameAndPassword(string Username, string Password)
		{
			NetworkingObject.User result;
			try
			{
				string text = new WebClient().DownloadString("https://api.skid-hub.com/Login?Username=" + Username + "&Password=" + Password);
				NetworkingObject.User user = JsonConvert.DeserializeObject<NetworkingObject.User>(text);
				bool flag = user == null;
				if (flag)
				{
					LNCcolnsole.WARN("[Log In] : User Is Null", false, ConsoleColor.Yellow);
				}
				bool banned = user.Banned;
				if (banned)
				{
					LNCcolnsole.ERROR("[Log In] : User Is BANNED", false, ConsoleColor.Red);
				}
				bool flag2 = !user.HasPlan("Registered");
				if (flag2)
				{
					LNCcolnsole.WARN("[Log In] : User isnt Fully Registered", false, ConsoleColor.Yellow);
				}
				bool flag3 = user != null;
				if (flag3)
				{
					LNCcolnsole.WARN("[Log In] : User Is Log In Success", false, ConsoleColor.Yellow);
				}
				result = user;
			}
			catch
			{
				LNCcolnsole.ERROR("[Log In] : FAILED TO LOG IN", false, ConsoleColor.Red);
				return null;
			}
			return result;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00013370 File Offset: 0x00011570
		internal static string Register(string DiscordID, string Username, string Password)
		{
			string result;
			try
			{
				string text = new WebClient().DownloadString(string.Concat(new string[]
				{
					"https://api.skid-hub.com/AS-MP/Register?DiscordID=",
					DiscordID,
					"&Username=",
					Username,
					"&Password=",
					Password
				}));
				result = text;
				LNCcolnsole.Log("[Long In] : Registered", false, ConsoleColor.White);
			}
			catch
			{
				LNCcolnsole.ERROR("[Log In] : FAILED TO REGISTER IN", false, ConsoleColor.Red);
				return null;
			}
			return result;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000133F8 File Offset: 0x000115F8
		internal static byte[] GetFile(string FileName)
		{
			byte[] result;
			try
			{
				result = new WebClient().DownloadData("https://api.skid-hub.com/file?Filename=" + FileName);
			}
			catch
			{
				LNCcolnsole.ERROR("[Log In] : FAILED TO GET FILE", false, ConsoleColor.Red);
				return null;
			}
			return result;
		}
	}
}
