using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using DayClientML2.Utility.Extensions;
using Il2CppSystem.Collections.Generic;
using Late_Night_V3_colnsole;
using MelonLoader;
using UnityEngine;
using VRC;
using VRC.SDKBase;

namespace Late_Night_V2_wrappers
{
	// Token: 0x02000004 RID: 4
	internal static class Wrapper
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00002FFF File Offset: 0x000011FF
		public static void DelayFunction(float del, Action action)
		{
			MelonCoroutines.Start(Wrapper.Delay(del, action));
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000300F File Offset: 0x0000120F
		private static IEnumerator Delay(float del, Action action)
		{
			yield return new WaitForSeconds(del);
			action();
			yield break;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003028 File Offset: 0x00001228
		public static string homeId()
		{
			string str = "wrld_4432ea9b-729c-46e3-8eaf-846aa0a37fdd:";
			return str + new Random().Next(0, 9999).ToString();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003060 File Offset: 0x00001260
		public static Color hextorgb(this Color color, string hex)
		{
			ColorUtility.TryParseHtmlString(hex, ref color);
			return color;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000307C File Offset: 0x0000127C
		internal static void RespawnPickups()
		{
			foreach (VRC_Pickup vrc_Pickup in Object.FindObjectsOfType<VRC_Pickup>())
			{
				Networking.LocalPlayer.TakeOwnership(vrc_Pickup.gameObject);
				vrc_Pickup.transform.localPosition = new Vector3(0f, -100000f, 0f);
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000030F8 File Offset: 0x000012F8
		public static List<string> GetListOfids(UiUserList A)
		{
			List<string> list = new List<string>();
			foreach (VRCUiContentButton vrcuiContentButton in A.pickers)
			{
				bool flag = !string.IsNullOrEmpty(vrcuiContentButton.field_Public_String_0);
				if (flag)
				{
					list.Add(vrcuiContentButton.field_Public_String_0);
				}
			}
			return list;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003154 File Offset: 0x00001354
		internal static VRCPlayer GetPlayerbyphotonid(int B)
		{
			List<Player> field_Private_List_1_Player_ = PlayerManager.field_Private_Static_PlayerManager_0.field_Private_List_1_Player_0;
			foreach (Player instance in field_Private_List_1_Player_)
			{
				bool flag = instance.GetVRCPlayerApi().playerId == B;
				if (flag)
				{
					return instance.GetVRCPlayer();
				}
			}
			return null;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000031AC File Offset: 0x000013AC
		public static string WorldType(string id)
		{
			bool flag = id.Contains("~private") && id.Contains("~canRequestInvite~nonce");
			string result;
			if (flag)
			{
				result = "invite+";
			}
			else
			{
				bool flag2 = id.Contains("~private") && id.Contains("~nonce");
				if (flag2)
				{
					result = "invite";
				}
				else
				{
					bool flag3 = id.Contains("~friend");
					if (flag3)
					{
						result = "friends";
					}
					else
					{
						bool flag4 = id.Contains("~hidden");
						if (flag4)
						{
							result = "friends+";
						}
						else
						{
							result = "public";
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003245 File Offset: 0x00001445
		internal static void EnableOutline(this HighlightsFX instance, Renderer renderer, bool state)
		{
			instance.Method_Public_Void_Renderer_Boolean_0(renderer, state);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003254 File Offset: 0x00001454
		internal static HighlightsFX GetHighlightsFX()
		{
			return HighlightsFX.Method_Public_Static_get_HighlightsFX_PDM_0();
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000326C File Offset: 0x0000146C
		internal static PlayerManager GetPlayerManager()
		{
			return PlayerManager.Method_Public_Static_get_PlayerManager_0();
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003284 File Offset: 0x00001484
		internal static QuickMenu GetQuickMenu()
		{
			return QuickMenu.Method_Public_Static_get_QuickMenu_PDM_0();
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000329C File Offset: 0x0000149C
		internal static VRCUiManager GetVRCUiManager()
		{
			return VRCUiManager.Method_Internal_Static_get_VRCUiManager_PDM_0();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000032B4 File Offset: 0x000014B4
		internal static string Convert(WebResponse res)
		{
			string result = "";
			using (Stream responseStream = res.GetResponseStream())
			{
				using (StreamReader streamReader = new StreamReader(responseStream))
				{
					result = streamReader.ReadToEnd();
				}
			}
			res.Dispose();
			return result;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003324 File Offset: 0x00001524
		internal static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
		{
			T component = gameObject.GetComponent<T>();
			return (component == null) ? gameObject.AddComponent<T>() : component;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003358 File Offset: 0x00001558
		public static void DirectoryFiles()
		{
			bool flag = !Directory.Exists("Late_night_V4");
			if (flag)
			{
				bool flag2 = Directory.Exists("Late_night_V3");
				if (flag2)
				{
					Directory.Move("Late_night_V3", "Late_night_V4");
					LNCcolnsole.Log("Moved Content V3 To V4", false, ConsoleColor.Green);
				}
				else
				{
					Directory.CreateDirectory("Late_night_V4");
					LNCcolnsole.Log("Made V4 Folder", false, ConsoleColor.Green);
				}
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000033C4 File Offset: 0x000015C4
		internal static void Bruhmoment()
		{
			Process.GetCurrentProcess().Kill();
		}
	}
}
