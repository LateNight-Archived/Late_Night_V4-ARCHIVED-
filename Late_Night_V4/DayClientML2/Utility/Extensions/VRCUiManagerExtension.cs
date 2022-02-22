using System;
using System.Linq;
using System.Reflection;
using Il2CppSystem;
using Late_Night_V3_colnsole;
using MelonLoader;
using UnhollowerRuntimeLib.XrefScans;
using UnityEngine;
using VRC.Core;
using VRC.UI;

namespace DayClientML2.Utility.Extensions
{
	// Token: 0x02000067 RID: 103
	public static class VRCUiManagerExtension
	{
		// Token: 0x0600044E RID: 1102 RVA: 0x0001D9BC File Offset: 0x0001BBBC
		public static APIUser SelectedAPIUser(this VRCUiManager Instance)
		{
			return Instance.GetMenuContent().GetComponentInChildren<PageUserInfo>().GetUser();
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0001D9E0 File Offset: 0x0001BBE0
		public static void CloseUI(this VRCUiManager Instance, bool withFade = false)
		{
			try
			{
				Instance.Method_Public_Void_Boolean_0(withFade);
			}
			catch
			{
			}
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0001DA10 File Offset: 0x0001BC10
		public static void EnableCursor(this VRCUiCursorManager instance, bool EnableCursor)
		{
			instance.field_Private_Boolean_0 = EnableCursor;
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0001DA1B File Offset: 0x0001BC1B
		public static void CloseUI()
		{
			Utils.VRCUiManager.CloseUI(false);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0001DA2A File Offset: 0x0001BC2A
		public static void OpenUI(this VRCUiManager Instance, bool showDefaultScreen = false, bool showBackdrop = true)
		{
			Instance.Method_Public_Void_Boolean_Boolean_0(showDefaultScreen, showBackdrop);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0001DA38 File Offset: 0x0001BC38
		public static VRCUiPage GetPage(this VRCUiManager Instance, string screenPath)
		{
			GameObject gameObject = GameObject.Find(screenPath);
			VRCUiPage vrcuiPage = null;
			bool flag = gameObject != null;
			if (flag)
			{
				vrcuiPage = gameObject.GetComponent<VRCUiPage>();
				bool flag2 = vrcuiPage == null;
				if (flag2)
				{
					MelonLogger.Error("Screen Not Found - " + screenPath);
				}
			}
			else
			{
				MelonLogger.Warning("Screen Not Found - " + screenPath);
			}
			return vrcuiPage;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0001DAA0 File Offset: 0x0001BCA0
		public static VRCUiPage ShowScreen(this VRCUiManager Instance, VRCUiPage page)
		{
			return VRCUiManagerExtension.ShowScreenActionAction(page);
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0001DAC0 File Offset: 0x0001BCC0
		public static void ShowScreen(this VRCUiManager Instance, string pageName)
		{
			VRCUiPage page = Instance.GetPage(pageName);
			bool flag = page != null;
			if (flag)
			{
				Instance.ShowScreen(page);
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x0001DAEC File Offset: 0x0001BCEC
		public static VRCUiManagerExtension.ShowScreenAction ShowScreenActionAction
		{
			get
			{
				bool flag = VRCUiManagerExtension.ourShowScreenAction != null;
				VRCUiManagerExtension.ShowScreenAction result;
				if (flag)
				{
					result = VRCUiManagerExtension.ourShowScreenAction;
				}
				else
				{
					MethodInfo method = typeof(VRCUiManager).GetMethods(BindingFlags.Instance | BindingFlags.Public).Single(delegate(MethodInfo it)
					{
						bool flag2 = it.ReturnType == typeof(VRCUiPage) && it.GetParameters().Length == 1 && it.GetParameters()[0].ParameterType == typeof(VRCUiPage);
						bool result2;
						if (flag2)
						{
							result2 = XrefScanner.XrefScan(it).Any(delegate(XrefInstance jt)
							{
								bool flag3 = jt.Type > 0;
								bool result3;
								if (flag3)
								{
									result3 = false;
								}
								else
								{
									Object @object = jt.ReadAsObject();
									result3 = (((@object != null) ? @object.ToString() : null) == "Screen Not Found - ");
								}
								return result3;
							});
						}
						else
						{
							result2 = false;
						}
						return result2;
					});
					VRCUiManagerExtension.ourShowScreenAction = (VRCUiManagerExtension.ShowScreenAction)Delegate.CreateDelegate(typeof(VRCUiManagerExtension.ShowScreenAction), Utils.VRCUiManager, method);
					result = VRCUiManagerExtension.ourShowScreenAction;
				}
				return result;
			}
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0001DB70 File Offset: 0x0001BD70
		internal static void RefreshUser()
		{
			APIUser user = Utils.VRCUiManager.field_Public_GameObject_0.GetComponentInChildren<PageUserInfo>().GetUser();
			bool flag = user == null;
			if (flag)
			{
				Console.WriteLine("user null");
			}
			else
			{
				APIUser.FetchUser(user.id, delegate(APIUser userapi)
				{
					PageUserInfo componentInChildren = Utils.VRCUiManager.GetMenuContent().GetComponentInChildren<PageUserInfo>();
					bool flag2 = componentInChildren != null;
					if (flag2)
					{
						LNCcolnsole.Log("Refreshed user: " + userapi.id, false, ConsoleColor.White);
					}
				}, delegate(string Error)
				{
					LNCcolnsole.ERROR("Error Couldnt Fetch User\n" + Error, false, ConsoleColor.Red);
				});
			}
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0001DC00 File Offset: 0x0001BE00
		internal static void RefreshMenu()
		{
			UiUserList[] array = Utils.VRCUiManager.GetComponentsInChildren<UiUserList>(true);
			foreach (UiUserList uiUserList in array)
			{
				uiUserList.Method_Public_Void_0();
				uiUserList.Method_Public_Void_1();
			}
			LNCcolnsole.Log("Refreshed social lists!", false, ConsoleColor.White);
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0001DC54 File Offset: 0x0001BE54
		internal static GameObject GetMenuContent(this VRCUiManager Instance)
		{
			return Instance.field_Public_GameObject_0;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0001DC6C File Offset: 0x0001BE6C
		internal static APIUser GetUser(this PageUserInfo Instance)
		{
			return Instance.field_Private_APIUser_0;
		}

		// Token: 0x040001E7 RID: 487
		private static VRCUiManagerExtension.ShowScreenAction ourShowScreenAction;

		// Token: 0x020000E1 RID: 225
		// (Invoke) Token: 0x06000824 RID: 2084
		public delegate VRCUiPage ShowScreenAction(VRCUiPage page);
	}
}
