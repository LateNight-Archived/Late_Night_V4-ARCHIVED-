using System;
using System.Linq;
using System.Reflection;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerRuntimeLib;
using UnhollowerRuntimeLib.XrefScans;
using UnityEngine;
using UnityEngine.UI;

namespace External_Libraries.popups
{
	// Token: 0x02000030 RID: 48
	internal class Popups
	{
		// Token: 0x060001B9 RID: 441 RVA: 0x00013610 File Offset: 0x00011810
		public static void PopupCall(string title, string confirm, string placeholder, bool IsNumpad, Action<string> OnAccept, Action OnCancel = null)
		{
			VRCUiPopupManager.Method_Public_Static_get_VRCUiPopupManager_PDM_0().Method_Public_Void_String_String_InputType_Boolean_String_Action_3_String_List_1_KeyCode_Text_Action_String_Boolean_Action_1_VRCUiPopup_Boolean_Int32_1(title, "", 0, IsNumpad, confirm, DelegateSupport.ConvertDelegate<Action<string, List<KeyCode>, Text>>(new Action<string, List<KeyCode>, Text>(delegate(string a, List<KeyCode> b, Text c)
			{
				Action<string> onAccept = OnAccept;
				if (onAccept != null)
				{
					onAccept(a);
				}
			})), DelegateSupport.ConvertDelegate<Action>(OnCancel), placeholder, true, null, false, 0);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00013660 File Offset: 0x00011860
		public static void GameObjects()
		{
			GameObject.Find("UserInterface/MenuContent/Popups/StandardPopupV2/Darkness").SetActive(false);
			GameObject.Find("UserInterface/MenuContent/Popups/StandardPopupV2/Popup/BorderImage").GetComponent<Image>().color = new Color(0f, 0f, 0f, 0.1f);
			GameObject.Find("UserInterface/MenuContent/Popups/StandardPopupV2/Popup/Panel").GetComponent<Image>().color = new Color(102f, 0f, 102f, 0.1f);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000136DC File Offset: 0x000118DC
		public static bool XRefScanFor(MethodBase methodBase, string searchTerm)
		{
			return XrefScanner.XrefScan(methodBase).Any(delegate(XrefInstance xref)
			{
				bool flag = xref.Type > 0;
				bool result;
				if (flag)
				{
					result = false;
				}
				else
				{
					Object @object = xref.ReadAsObject();
					bool flag2 = @object == null;
					result = (!flag2 && @object.ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0);
				}
				return result;
			});
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00013712 File Offset: 0x00011912
		public static void CloseCurrentPopup()
		{
			VRCUiManager.Method_Internal_Static_get_VRCUiManager_PDM_0().HideScreen("POPUP");
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00013728 File Offset: 0x00011928
		public static Popups.YesNoPopupDelegate GetYesNoPopupDelegate
		{
			get
			{
				bool flag = Popups.yesNoPopupDelegate != null;
				Popups.YesNoPopupDelegate result;
				if (flag)
				{
					result = Popups.yesNoPopupDelegate;
				}
				else
				{
					MethodInfo method = typeof(VRCUiPopupManager).GetMethods(BindingFlags.Instance | BindingFlags.Public).Single((MethodInfo m) => m.GetParameters().Length == 7 && Popups.XRefScanFor(m, "Popups/StandardPopupV2"));
					Popups.yesNoPopupDelegate = (Popups.YesNoPopupDelegate)Delegate.CreateDelegate(typeof(Popups.YesNoPopupDelegate), VRCUiPopupManager.field_Private_Static_VRCUiPopupManager_0, method);
					result = Popups.yesNoPopupDelegate;
				}
				return result;
			}
		}

		// Token: 0x040000DA RID: 218
		public static Popups.YesNoPopupDelegate yesNoPopupDelegate;

		// Token: 0x0200009C RID: 156
		// (Invoke) Token: 0x060006B4 RID: 1716
		public delegate void YesNoPopupDelegate(string title, string text, string leftButtonText, Action leftButtonAction, string rightButtonText, Action rightButtonAction, Action<VRCUiPopup> additionalShit = null);
	}
}
