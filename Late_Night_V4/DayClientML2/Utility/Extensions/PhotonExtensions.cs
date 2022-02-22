using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Photon.Realtime;
using VRC;

namespace DayClientML2.Utility.Extensions
{
	// Token: 0x0200005F RID: 95
	public static class PhotonExtensions
	{
		// Token: 0x0600039F RID: 927 RVA: 0x0001AFD8 File Offset: 0x000191D8
		public static string GetUserID(this Player player)
		{
			bool flag = !player.GetRawHashtable().ContainsKey("user");
			string result;
			if (flag)
			{
				result = "No ID";
			}
			else
			{
				Dictionary<string, object> dictionary = player.GetHashtable()["user"] as Dictionary<string, object>;
				bool flag2 = dictionary != null;
				if (flag2)
				{
					result = (string)dictionary["id"];
				}
				else
				{
					result = "No ID";
				}
			}
			return result;
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0001B044 File Offset: 0x00019244
		public static string GetDisplayName(this Player player)
		{
			bool flag = !player.GetRawHashtable().ContainsKey("user");
			string result;
			if (flag)
			{
				result = "No DisplayName";
			}
			else
			{
				Dictionary<string, object> dictionary = player.GetHashtable()["user"] as Dictionary<string, object>;
				bool flag2 = dictionary != null;
				if (flag2)
				{
					result = (string)dictionary["displayName"];
				}
				else
				{
					result = "No DisplayName";
				}
			}
			return result;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0001B0B0 File Offset: 0x000192B0
		public static string GetStatus(this Player player)
		{
			bool flag = !player.GetRawHashtable().ContainsKey("user");
			string result;
			if (flag)
			{
				result = "No ID";
			}
			else
			{
				Dictionary<string, object> dictionary = player.GetHashtable()["user"] as Dictionary<string, object>;
				bool flag2 = dictionary != null;
				if (flag2)
				{
					result = (string)dictionary["status"];
				}
				else
				{
					result = "No ID";
				}
			}
			return result;
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0001B11C File Offset: 0x0001931C
		public static string GetStatusDesciption(this Player player)
		{
			bool flag = !player.GetRawHashtable().ContainsKey("user");
			string result;
			if (flag)
			{
				result = "No ID";
			}
			else
			{
				Dictionary<string, object> dictionary = player.GetHashtable()["user"] as Dictionary<string, object>;
				bool flag2 = dictionary != null;
				if (flag2)
				{
					result = (string)dictionary["statusDescription"];
				}
				else
				{
					result = "No ID";
				}
			}
			return result;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0001B188 File Offset: 0x00019388
		public static string GetBio(this Player player)
		{
			bool flag = !player.GetRawHashtable().ContainsKey("user");
			string result;
			if (flag)
			{
				result = "No ID";
			}
			else
			{
				Dictionary<string, object> dictionary = player.GetHashtable()["user"] as Dictionary<string, object>;
				bool flag2 = dictionary != null;
				if (flag2)
				{
					result = (string)dictionary["bio"];
				}
				else
				{
					result = "No ID";
				}
			}
			return result;
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0001B1F4 File Offset: 0x000193F4
		public static string GetLastPlatform(this Player player)
		{
			bool flag = !player.GetRawHashtable().ContainsKey("user");
			string result;
			if (flag)
			{
				result = "No ID";
			}
			else
			{
				Dictionary<string, object> dictionary = player.GetHashtable()["user"] as Dictionary<string, object>;
				bool flag2 = dictionary != null;
				if (flag2)
				{
					result = (string)dictionary["last_platform"];
				}
				else
				{
					result = "No ID";
				}
			}
			return result;
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0001B260 File Offset: 0x00019460
		public static string GetAvatarId(this Player player)
		{
			bool flag = !player.GetRawHashtable().ContainsKey("avatarDict");
			string result;
			if (flag)
			{
				result = "No Id";
			}
			else
			{
				Dictionary<string, object> dictionary = player.GetHashtable()["avatarDict"] as Dictionary<string, object>;
				bool flag2 = dictionary != null;
				if (flag2)
				{
					result = (string)dictionary["id"];
				}
				else
				{
					result = "No Id";
				}
			}
			return result;
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0001B2CC File Offset: 0x000194CC
		public static string GetAvatarName(this Player player)
		{
			bool flag = !player.GetRawHashtable().ContainsKey("avatarDict");
			string result;
			if (flag)
			{
				result = "No Id";
			}
			else
			{
				Dictionary<string, object> dictionary = player.GetHashtable()["avatarDict"] as Dictionary<string, object>;
				bool flag2 = dictionary != null;
				if (flag2)
				{
					result = (string)dictionary["name"];
				}
				else
				{
					result = "No Id";
				}
			}
			return result;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0001B338 File Offset: 0x00019538
		public static string GetAvatarAuthorName(this Player player)
		{
			bool flag = !player.GetRawHashtable().ContainsKey("avatarDict");
			string result;
			if (flag)
			{
				result = "No Id";
			}
			else
			{
				Dictionary<string, object> dictionary = player.GetHashtable()["avatarDict"] as Dictionary<string, object>;
				bool flag2 = dictionary != null;
				if (flag2)
				{
					result = (string)dictionary["authorName"];
				}
				else
				{
					result = "No Id";
				}
			}
			return result;
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0001B3A4 File Offset: 0x000195A4
		public static string GetAvatarAuthorId(this Player player)
		{
			bool flag = !player.GetRawHashtable().ContainsKey("avatarDict");
			string result;
			if (flag)
			{
				result = "No Id";
			}
			else
			{
				Dictionary<string, object> dictionary = player.GetHashtable()["avatarDict"] as Dictionary<string, object>;
				bool flag2 = dictionary != null;
				if (flag2)
				{
					result = (string)dictionary["authorId"];
				}
				else
				{
					result = "No Id";
				}
			}
			return result;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0001B410 File Offset: 0x00019610
		public static string GetAvatarDescription(this Player player)
		{
			bool flag = !player.GetRawHashtable().ContainsKey("avatarDict");
			string result;
			if (flag)
			{
				result = "No Id";
			}
			else
			{
				Dictionary<string, object> dictionary = player.GetHashtable()["avatarDict"] as Dictionary<string, object>;
				bool flag2 = dictionary != null;
				if (flag2)
				{
					result = (string)dictionary["description"];
				}
				else
				{
					result = "No Id";
				}
			}
			return result;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0001B47C File Offset: 0x0001967C
		public static string GetAvatarReleaseStatus(this Player player)
		{
			bool flag = !player.GetRawHashtable().ContainsKey("avatarDict");
			string result;
			if (flag)
			{
				result = "No Id";
			}
			else
			{
				Dictionary<string, object> dictionary = player.GetHashtable()["avatarDict"] as Dictionary<string, object>;
				bool flag2 = dictionary != null;
				if (flag2)
				{
					result = (string)dictionary["releaseStatus"];
				}
				else
				{
					result = "No Id";
				}
			}
			return result;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0001B4E8 File Offset: 0x000196E8
		public static int GetPhotonID(this Player player)
		{
			return player.field_Private_Int32_0;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0001B4F0 File Offset: 0x000196F0
		public static Player GetPlayer(this Player player)
		{
			return player.field_Public_Player_0;
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0001B4F8 File Offset: 0x000196F8
		public static Hashtable GetHashtable(this Player player)
		{
			return Serialization.FromIL2CPPToManaged<Hashtable>(player.GetRawHashtable());
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0001B505 File Offset: 0x00019705
		public static Hashtable GetRawHashtable(this Player player)
		{
			return player.Method_Public_get_Hashtable_0();
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0001B510 File Offset: 0x00019710
		public static List<Player> GetAllPhotonPlayers(this LoadBalancingClient Instance)
		{
			List<Player> list = new List<Player>();
			foreach (KeyValuePair<int, Player> keyValuePair in Instance.Method_Public_get_Room_0().Method_Public_get_Dictionary_2_Int32_Player_0())
			{
				list.Add(keyValuePair.Value);
			}
			return list;
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0001B55C File Offset: 0x0001975C
		public static Player GetPhotonPlayer(this LoadBalancingClient Instance, int photonID)
		{
			List<Player> allPhotonPlayers = Instance.GetAllPhotonPlayers();
			return allPhotonPlayers.FirstOrDefault((Player x) => x.GetPhotonID() == photonID);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0001B594 File Offset: 0x00019794
		public static Player GetPhotonPlayer(this LoadBalancingClient Instance, string userID)
		{
			return Instance.GetAllPhotonPlayers().FirstOrDefault((Player x) => x.GetUserID() == userID);
		}
	}
}
