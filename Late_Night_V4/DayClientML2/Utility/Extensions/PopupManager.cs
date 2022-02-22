using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Late_Night_config;
using MelonLoader;
using UnhollowerRuntimeLib.XrefScans;
using UnityEngine;
using UnityEngine.UI;

namespace DayClientML2.Utility.Extensions
{
	// Token: 0x02000064 RID: 100
	public static class PopupManager
	{
		// Token: 0x0600041B RID: 1051 RVA: 0x0001CE20 File Offset: 0x0001B020
		public static void Alert(this VRCUiPopupManager instance, string title, string Content, string buttonname, Action onSucces, Action<VRCUiPopup> onPopupShown = null)
		{
			PopupManager.ShowStandart2Popup(title, Content, buttonname, onSucces, onPopupShown);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0001CE3F File Offset: 0x0001B03F
		public static void Alert(this VRCUiPopupManager instance, string title, string Content, string buttonname, Action action, string button2, Action action2, Action<VRCUiPopup> onPopupShown = null)
		{
			PopupManager.ShowStandart3Popup(title, Content, buttonname, action, button2, action2, onPopupShown);
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0001CE67 File Offset: 0x0001B067
		public static void AlertV2(this VRCUiPopupManager instance, string title, string Content, string buttonname, Action onSucces, Action<VRCUiPopup> onPopupShown = null)
		{
			PopupManager.ShowStandartV21Popup(title, Content, buttonname, onSucces, onPopupShown);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x0001CE86 File Offset: 0x0001B086
		public static void AlertV2(this VRCUiPopupManager instance, string title, string Content, string buttonname, Action action, string button2, Action action2, Action<VRCUiPopup> onPopupShown = null)
		{
			PopupManager.ShowStandartV22Popup(title, Content, buttonname, action, button2, action, onPopupShown);
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0001CEAE File Offset: 0x0001B0AE
		public static void HideCurrentPopUp(this VRCUiPopupManager instance)
		{
			Utils.VRCUiManager.HideScreen("POPUP");
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0001CEC4 File Offset: 0x0001B0C4
		public static void QueHudMessage(this VRCUiManager instance, string Message)
		{
			bool flag = !RoomManagerExtension.IsInWorld();
			if (!flag)
			{
				bool betterhudtext = Config.Instance.betterhudtext;
				if (betterhudtext)
				{
					bool flag2 = PopupManager.HudMessage1 == null;
					if (flag2)
					{
						PopupManager.HudMessage1 = PopupManager.CreateTextNear(PopupManager.CreateImage("yes", 100f), 110f, 7);
					}
					MelonCoroutines.Start(PopupManager.ShowMessage(PopupManager.HudMessage1, PopupManager.MessagesList, Message));
				}
				else
				{
					instance.field_Private_List_1_String_0.Add(Message);
				}
			}
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0001CF45 File Offset: 0x0001B145
		public static void ClearHudMessages(this VRCUiManager instance)
		{
			instance.field_Private_List_1_String_0.Clear();
			instance.field_Public_Text_0.text = "";
			PopupManager.HudMessage1.text = "";
			PopupManager.MessagesList.Clear();
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0001CF80 File Offset: 0x0001B180
		internal static void InputPopUp(this VRCUiPopupManager instance, string title, string okButtonName, Action<string> onSuccess, Action Button2, string def = null)
		{
			PopupManager.ShowUiInputPopup(title, "", 0, false, okButtonName, delegate(string g, List<KeyCode> l, Text t)
			{
				bool flag = string.Empty == g;
				if (flag)
				{
					g = def;
				}
				onSuccess(g);
			}, Button2, def ?? "", true, null, false, 0);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x0001CFE4 File Offset: 0x0001B1E4
		internal static void NumericInputPopup(this VRCUiPopupManager instance, string title, string okButtonName, Action<string> onSuccess, string def = null)
		{
			PopupManager.ShowUiInputPopup(title, "", 0, true, okButtonName, delegate(string g, List<KeyCode> l, Text t)
			{
				bool flag = string.Empty == g;
				if (flag)
				{
					g = def;
				}
				onSuccess(g);
			}, delegate()
			{
				instance.HideCurrentPopUp();
				PopupManager.IsTyping = false;
			}, def ?? "", true, null, false, 0);
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x0001D058 File Offset: 0x0001B258
		internal static PopupManager.ShowUiInputPopupAction ShowUiInputPopup
		{
			get
			{
				bool flag = PopupManager.ourShowUiInputPopupAction != null;
				PopupManager.ShowUiInputPopupAction result;
				if (flag)
				{
					result = PopupManager.ourShowUiInputPopupAction;
				}
				else
				{
					MethodInfo method = typeof(VRCUiPopupManager).GetMethods(BindingFlags.Instance | BindingFlags.Public).FirstOrDefault(delegate(MethodInfo it)
					{
						bool flag2 = it.GetParameters().Length == 12;
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
									result3 = (((@object != null) ? @object.ToString() : null) == "UserInterface/MenuContent/Popups/InputPopup");
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
					PopupManager.ourShowUiInputPopupAction = (PopupManager.ShowUiInputPopupAction)Delegate.CreateDelegate(typeof(PopupManager.ShowUiInputPopupAction), Utils.VRCUiPopupManager, method);
					result = PopupManager.ourShowUiInputPopupAction;
				}
				return result;
			}
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0001D0D8 File Offset: 0x0001B2D8
		public static void ShowAlert(this VRCUiPopupManager instance, string title, string content, float timeout = 10f)
		{
			PopupManager.ShowAlertPopup(title, content, timeout);
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x0001D0EC File Offset: 0x0001B2EC
		internal static PopupManager.ShowAlertPopupAction ShowAlertPopup
		{
			get
			{
				bool flag = PopupManager.ourShowAlertPopupAction != null;
				PopupManager.ShowAlertPopupAction result;
				if (flag)
				{
					result = PopupManager.ourShowAlertPopupAction;
				}
				else
				{
					MethodInfo method = typeof(VRCUiPopupManager).GetMethods(BindingFlags.Instance | BindingFlags.Public).FirstOrDefault(delegate(MethodInfo it)
					{
						bool flag2 = it.GetParameters().Length != 3;
						bool result2;
						if (flag2)
						{
							result2 = false;
						}
						else
						{
							result2 = XrefScanner.XrefScan(it).Where(delegate(XrefInstance jt)
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
									result3 = (((@object != null) ? @object.ToString() : null) == "UserInterface/MenuContent/Popups/AlertPopup");
								}
								return result3;
							}).Any<XrefInstance>();
						}
						return result2;
					});
					PopupManager.ourShowAlertPopupAction = (PopupManager.ShowAlertPopupAction)Delegate.CreateDelegate(typeof(PopupManager.ShowAlertPopupAction), Utils.VRCUiPopupManager, method);
					result = PopupManager.ourShowAlertPopupAction;
				}
				return result;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x0001D16C File Offset: 0x0001B36C
		internal static PopupManager.ShowStandart1PopupAction ShowStandartV1Popup
		{
			get
			{
				bool flag = PopupManager.ourShowStandartV1PopupAction != null;
				PopupManager.ShowStandart1PopupAction result;
				if (flag)
				{
					result = PopupManager.ourShowStandartV1PopupAction;
				}
				else
				{
					MethodInfo method = typeof(VRCUiPopupManager).GetMethods(BindingFlags.Instance | BindingFlags.Public).FirstOrDefault(delegate(MethodInfo it)
					{
						bool flag2 = it.GetParameters().Length != 3 || it.Name.Contains("PDM");
						bool result2;
						if (flag2)
						{
							result2 = false;
						}
						else
						{
							result2 = XrefScanner.XrefScan(it).Where(delegate(XrefInstance jt)
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
									result3 = (((@object != null) ? @object.ToString() : null) == "UserInterface/MenuContent/Popups/StandardPopup");
								}
								return result3;
							}).Any<XrefInstance>();
						}
						return result2;
					});
					PopupManager.ourShowStandartV1PopupAction = (PopupManager.ShowStandart1PopupAction)Delegate.CreateDelegate(typeof(PopupManager.ShowStandart1PopupAction), VRCUiPopupManager.field_Private_Static_VRCUiPopupManager_0, method);
					result = PopupManager.ourShowStandartV1PopupAction;
				}
				return result;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x0001D1EC File Offset: 0x0001B3EC
		internal static PopupManager.ShowStandart2PopupAction ShowStandart2Popup
		{
			get
			{
				bool flag = PopupManager.ourShowStandart2PopupAction != null;
				PopupManager.ShowStandart2PopupAction result;
				if (flag)
				{
					result = PopupManager.ourShowStandart2PopupAction;
				}
				else
				{
					MethodInfo method = typeof(VRCUiPopupManager).GetMethods(BindingFlags.Instance | BindingFlags.Public).FirstOrDefault(delegate(MethodInfo it)
					{
						bool flag2 = it.GetParameters().Length == 5 && !it.Name.Contains("PDM");
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
									result3 = (((@object != null) ? @object.ToString() : null) == "UserInterface/MenuContent/Popups/StandardPopup");
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
					PopupManager.ourShowStandart2PopupAction = (PopupManager.ShowStandart2PopupAction)Delegate.CreateDelegate(typeof(PopupManager.ShowStandart2PopupAction), VRCUiPopupManager.field_Private_Static_VRCUiPopupManager_0, method);
					result = PopupManager.ourShowStandart2PopupAction;
				}
				return result;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x0001D26C File Offset: 0x0001B46C
		internal static PopupManager.ShowStandart3PopupAction ShowStandart3Popup
		{
			get
			{
				bool flag = PopupManager.ourShowStandart3PopupAction != null;
				PopupManager.ShowStandart3PopupAction result;
				if (flag)
				{
					result = PopupManager.ourShowStandart3PopupAction;
				}
				else
				{
					MethodInfo method = typeof(VRCUiPopupManager).GetMethods(BindingFlags.Instance | BindingFlags.Public).FirstOrDefault(delegate(MethodInfo it)
					{
						bool flag2 = it.GetParameters().Length == 7 && !it.Name.Contains("PDM");
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
									result3 = (((@object != null) ? @object.ToString() : null) == "UserInterface/MenuContent/Popups/StandardPopup");
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
					PopupManager.ourShowStandart3PopupAction = (PopupManager.ShowStandart3PopupAction)Delegate.CreateDelegate(typeof(PopupManager.ShowStandart3PopupAction), VRCUiPopupManager.field_Private_Static_VRCUiPopupManager_0, method);
					result = PopupManager.ourShowStandart3PopupAction;
				}
				return result;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x0001D2EC File Offset: 0x0001B4EC
		internal static PopupManager.ShowStandartV21PopupAction ShowStandartV21Popup
		{
			get
			{
				bool flag = PopupManager.ourShowStandartV21PopupAction != null;
				PopupManager.ShowStandartV21PopupAction result;
				if (flag)
				{
					result = PopupManager.ourShowStandartV21PopupAction;
				}
				else
				{
					MethodInfo method = typeof(VRCUiPopupManager).GetMethods(BindingFlags.Instance | BindingFlags.Public).FirstOrDefault(delegate(MethodInfo it)
					{
						bool flag2 = it.GetParameters().Length == 5 && !it.Name.Contains("PDM");
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
									result3 = (((@object != null) ? @object.ToString() : null) == "UserInterface/MenuContent/Popups/StandardPopupV2");
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
					PopupManager.ourShowStandartV21PopupAction = (PopupManager.ShowStandartV21PopupAction)Delegate.CreateDelegate(typeof(PopupManager.ShowStandartV21PopupAction), VRCUiPopupManager.field_Private_Static_VRCUiPopupManager_0, method);
					result = PopupManager.ourShowStandartV21PopupAction;
				}
				return result;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x0001D36C File Offset: 0x0001B56C
		internal static PopupManager.ShowStandartV22PopupAction ShowStandartV22Popup
		{
			get
			{
				bool flag = PopupManager.ourShowStandartV22PopupAction != null;
				PopupManager.ShowStandartV22PopupAction result;
				if (flag)
				{
					result = PopupManager.ourShowStandartV22PopupAction;
				}
				else
				{
					MethodInfo method = typeof(VRCUiPopupManager).GetMethods(BindingFlags.Instance | BindingFlags.Public).FirstOrDefault(delegate(MethodInfo it)
					{
						bool flag2 = it.GetParameters().Length == 7 && !it.Name.Contains("PDM");
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
									result3 = (((@object != null) ? @object.ToString() : null) == "UserInterface/MenuContent/Popups/StandardPopupV2");
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
					PopupManager.ourShowStandartV22PopupAction = (PopupManager.ShowStandartV22PopupAction)Delegate.CreateDelegate(typeof(PopupManager.ShowStandartV22PopupAction), VRCUiPopupManager.field_Private_Static_VRCUiPopupManager_0, method);
					result = PopupManager.ourShowStandartV22PopupAction;
				}
				return result;
			}
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0001D3EC File Offset: 0x0001B5EC
		public static Image CreateImage(string name, float offset)
		{
			GameObject gameObject = GameObject.Find("UserInterface/UnscaledUI/HudContent/Hud");
			Transform transform = gameObject.transform.Find("NotificationDotParent");
			GameObject gameObject2 = Object.Instantiate<GameObject>(gameObject.transform.Find("NotificationDotParent/NotificationDot").gameObject, transform, false).Cast<GameObject>();
			gameObject2.name = "NotifyDot-" + name;
			gameObject2.SetActive(true);
			gameObject2.transform.localPosition += Vector3.right * offset;
			Image component = gameObject2.GetComponent<Image>();
			component.enabled = false;
			return component;
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0001D48C File Offset: 0x0001B68C
		public static Text CreateTextNear(Image image, float offset, TextAnchor alignment)
		{
			GameObject gameObject = new GameObject(image.gameObject.name + "-text");
			gameObject.AddComponent<Text>();
			gameObject.transform.SetParent(image.transform, false);
			gameObject.transform.localScale = Vector3.one;
			gameObject.transform.localPosition = Vector3.up * offset + Vector3.right * 300f;
			Text component = gameObject.GetComponent<Text>();
			component.color = Color.white;
			component.fontStyle = 1;
			component.horizontalOverflow = 1;
			component.verticalOverflow = 1;
			component.alignment = alignment;
			component.fontSize = 30;
			component.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
			component.supportRichText = true;
			gameObject.SetActive(true);
			return component;
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0001D56D File Offset: 0x0001B76D
		public static IEnumerator ShowMessage(Text text, List<string> MessagesList, string message)
		{
			bool flag = MessagesList.Count >= 250;
			if (flag)
			{
				yield break;
			}
			MessagesList.Add(message);
			text.text = string.Join("\n", MessagesList);
			yield return new WaitForSeconds(4f);
			MessagesList.Remove(message);
			text.text = string.Join("\n", MessagesList);
			yield break;
		}

		// Token: 0x040001DD RID: 477
		public static bool IsTyping = false;

		// Token: 0x040001DE RID: 478
		public static List<string> MessagesList = new List<string>();

		// Token: 0x040001DF RID: 479
		private static PopupManager.ShowUiInputPopupAction ourShowUiInputPopupAction;

		// Token: 0x040001E0 RID: 480
		private static PopupManager.ShowAlertPopupAction ourShowAlertPopupAction;

		// Token: 0x040001E1 RID: 481
		private static PopupManager.ShowStandart1PopupAction ourShowStandartV1PopupAction;

		// Token: 0x040001E2 RID: 482
		private static PopupManager.ShowStandart2PopupAction ourShowStandart2PopupAction;

		// Token: 0x040001E3 RID: 483
		private static PopupManager.ShowStandart3PopupAction ourShowStandart3PopupAction;

		// Token: 0x040001E4 RID: 484
		private static PopupManager.ShowStandartV21PopupAction ourShowStandartV21PopupAction;

		// Token: 0x040001E5 RID: 485
		private static PopupManager.ShowStandartV22PopupAction ourShowStandartV22PopupAction;

		// Token: 0x040001E6 RID: 486
		public static Text HudMessage1;

		// Token: 0x020000D5 RID: 213
		// (Invoke) Token: 0x060007E9 RID: 2025
		internal delegate void ShowUiInputPopupAction(string title, string initialText, InputField.InputType inputType, bool isNumeric, string confirmButtonText, Action<string, List<KeyCode>, Text> onComplete, Action onCancel, string placeholderText = "Enter text...", bool closeAfterInput = true, Action<VRCUiPopup> onPopupShown = null, bool startOnLeft = false, int characterLimit = 0);

		// Token: 0x020000D6 RID: 214
		// (Invoke) Token: 0x060007ED RID: 2029
		internal delegate void ShowAlertPopupAction(string title, string content, float timeout);

		// Token: 0x020000D7 RID: 215
		// (Invoke) Token: 0x060007F1 RID: 2033
		internal delegate void ShowStandart1PopupAction(string title, string body, Action<VRCUiPopup> onPopupShown = null);

		// Token: 0x020000D8 RID: 216
		// (Invoke) Token: 0x060007F5 RID: 2037
		public delegate void ShowStandart2PopupAction(string title, string body, string middleButtonText, Action middleButtonAction, Action<VRCUiPopup> onPopupShown = null);

		// Token: 0x020000D9 RID: 217
		// (Invoke) Token: 0x060007F9 RID: 2041
		internal delegate void ShowStandart3PopupAction(string title, string body, string leftButtonText, Action leftButtonAction, string rightButtonText, Action rightButtonAction, Action<VRCUiPopup> onPopupShown = null);

		// Token: 0x020000DA RID: 218
		// (Invoke) Token: 0x060007FD RID: 2045
		internal delegate void ShowStandartV21PopupAction(string title, string body, string middleButtonText, Action middleButtonAction, Action<VRCUiPopup> onPopupShown = null);

		// Token: 0x020000DB RID: 219
		// (Invoke) Token: 0x06000801 RID: 2049
		internal delegate void ShowStandartV22PopupAction(string title, string body, string leftButtonText, Action leftButtonAction, string rightButtonText, Action rightButtonAction, Action<VRCUiPopup> onPopupShown = null);
	}
}
