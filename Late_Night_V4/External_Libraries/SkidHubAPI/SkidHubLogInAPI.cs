using System;

namespace Late_Night_V4.External_Libraries.SkidHubAPI
{
	// Token: 0x0200002D RID: 45
	internal class SkidHubLogInAPI
	{
		// Token: 0x060001AE RID: 430 RVA: 0x00013160 File Offset: 0x00011360
		public static NetworkingObject.User LoginWithSkidID(string Key)
		{
			NetworkingObject.User result = Functions.LoginWithSkidID(Key);
			SkidHubLogInAPI.curentuser = result;
			return result;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00013180 File Offset: 0x00011380
		public static NetworkingObject.User LoginWithUsernameAndPassword(string Username, string Password)
		{
			NetworkingObject.User result = Functions.LoginWithUsernameAndPassword(Username, Password);
			SkidHubLogInAPI.curentuser = result;
			return result;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000131A4 File Offset: 0x000113A4
		public static string Register(string DiscordID, string Username, string Password)
		{
			return Functions.Register(DiscordID, Username, Password);
		}

		// Token: 0x040000D9 RID: 217
		public static NetworkingObject.User curentuser;
	}
}
