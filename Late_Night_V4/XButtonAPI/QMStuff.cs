using System;
using System.Linq;
using System.Net;
using System.Reflection;
using UnhollowerRuntimeLib.XrefScans;
using UnityEngine;
using UnityEngine.UI;
using VRC.UI.Elements;

namespace XButtonAPI
{
	// Token: 0x0200004A RID: 74
	public static class QMStuff
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600027A RID: 634 RVA: 0x00016A88 File Offset: 0x00014C88
		public static MenuStateController MenuStateCtrl
		{
			get
			{
				return QMStuff.Instance.Method_Public_get_MenuStateController_0();
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600027B RID: 635 RVA: 0x00016A94 File Offset: 0x00014C94
		public static QuickMenu Instance
		{
			get
			{
				return Object.FindObjectOfType<QuickMenu>();
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600027C RID: 636 RVA: 0x00016A9B File Offset: 0x00014C9B
		public static Wing[] Wings
		{
			get
			{
				return Object.FindObjectsOfType<Wing>();
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600027D RID: 637 RVA: 0x00016AA8 File Offset: 0x00014CA8
		public static Wing LeftWing
		{
			get
			{
				return QMStuff.Wings.FirstOrDefault((Wing w) => w.field_Public_WingPanel_0 == 0);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600027E RID: 638 RVA: 0x00016AE4 File Offset: 0x00014CE4
		public static Wing RightWing
		{
			get
			{
				return QMStuff.Wings.FirstOrDefault((Wing w) => w.field_Public_WingPanel_0 == 1);
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00016B20 File Offset: 0x00014D20
		public static GameObject WingMenuTemplate()
		{
			return QMStuff.LeftWing.field_Public_RectTransform_0.Find("WingMenu").gameObject;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00016B4C File Offset: 0x00014D4C
		public static GameObject SingleWingTemplate()
		{
			return QMStuff.WingMenuTemplate().transform.Find("ScrollRect/Viewport/VerticalLayoutGroup/Button_Profile").gameObject;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00016B78 File Offset: 0x00014D78
		public static GameObject SingleButtonTemplate()
		{
			return QMStuff.Instance.field_Public_Transform_0.Find("Window/QMParent/Menu_Dashboard/ScrollRect").GetComponent<ScrollRect>().content.Find("Buttons_QuickActions/Button_Respawn").gameObject;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00016BB8 File Offset: 0x00014DB8
		public static Transform MainMenu()
		{
			return QMStuff.Instance.field_Public_Transform_0.Find("Window/QMParent/Menu_Dashboard/ScrollRect").GetComponent<ScrollRect>().content.Find("Buttons_QuickActions");
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00016BF4 File Offset: 0x00014DF4
		public static Transform USERMenu()
		{
			return QMStuff.Instance.field_Public_Transform_0.Find("Window/QMParent/Menu_SelectedUser_LocalMenu_SelectedUser_Local/ScrollRect").GetComponent<ScrollRect>().content.Find("Viewport");
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00016C30 File Offset: 0x00014E30
		public static GameObject ToggleButtonTemplate()
		{
			return QMStuff.Instance.field_Public_Transform_0.Find("Window/QMParent/Menu_Settings/Panel_QM_ScrollRect").GetComponent<ScrollRect>().content.Find("Buttons_UI_Elements_Row_1/Button_ToggleQMInfo").gameObject;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00016C70 File Offset: 0x00014E70
		public static GameObject ContainerTemplate()
		{
			return QMStuff.Instance.field_Public_Transform_0.Find("Window/QMParent/Menu_Dashboard/ScrollRect").GetComponent<ScrollRect>().content.Find("Buttons_QuickActions").gameObject;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00016CB0 File Offset: 0x00014EB0
		public static GameObject CatergoyPageTemplate()
		{
			return QMStuff.Instance.field_Public_Transform_0.Find("Window/QMParent/Menu_Dashboard").gameObject;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00016CDC File Offset: 0x00014EDC
		public static GameObject NestedMenuTemplate()
		{
			return QMStuff.Instance.field_Public_Transform_0.Find("Window/QMParent/Menu_DevTools").gameObject;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00016D08 File Offset: 0x00014F08
		public static GameObject HeaderTemplate()
		{
			return QMStuff.Instance.field_Public_Transform_0.Find("Window/QMParent/Menu_Dashboard/ScrollRect").GetComponent<ScrollRect>().content.Find("Header_QuickActions").gameObject;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00016D48 File Offset: 0x00014F48
		public static GameObject LabelTemplate()
		{
			return QMStuff.Instance.field_Public_Transform_0.Find("Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_Debug/Button_FPS").gameObject;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00016D74 File Offset: 0x00014F74
		public static GameObject SliderTemplate()
		{
			return QMStuff.Instance.field_Public_Transform_0.Find("Window/QMParent/Menu_AudioSettings/Content/Audio/VolumeSlider_Master").gameObject;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00016DA0 File Offset: 0x00014FA0
		public static GameObject PanelTemplate()
		{
			return QMStuff.Instance.field_Public_Transform_0.Find("Window/QMParent/Menu_AudioSettings/Content/Audio").gameObject;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00016DCC File Offset: 0x00014FCC
		public static VRCUiManager GetVRCUiMInstance()
		{
			return VRCUiManager.Method_Internal_Static_get_VRCUiManager_PDM_0();
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00016DE4 File Offset: 0x00014FE4
		public static GameObject TabButtonTemplate()
		{
			return QMStuff.Instance.field_Public_Transform_0.Find("Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Settings").gameObject;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00016E10 File Offset: 0x00015010
		public static bool CheckMethod(MethodInfo method, string match)
		{
			try
			{
				return XrefScanner.XrefScan(method).Any((XrefInstance xrefInstance) => xrefInstance.Type == null && xrefInstance.ReadAsObject().ToString().Contains(match));
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00016E60 File Offset: 0x00015060
		public static Sprite SetSprite(this string string_0)
		{
			bool flag = string.IsNullOrEmpty(string_0);
			Sprite result;
			if (flag)
			{
				result = null;
			}
			else
			{
				byte[] array = new WebClient().DownloadData(string_0);
				bool flag2 = array == null || array.Length == 0;
				if (flag2)
				{
					result = null;
				}
				else
				{
					Texture2D texture2D = new Texture2D(512, 512);
					bool flag3 = !Il2CppImageConversionManager.LoadImage(texture2D, array);
					if (flag3)
					{
						result = null;
					}
					else
					{
						Sprite sprite = Sprite.CreateSprite(texture2D, new Rect(0f, 0f, (float)texture2D.width, (float)texture2D.height), new Vector2(0.5f, 0.5f), 100f, 0U, 0, default(Vector4), false);
						sprite.hideFlags |= 32;
						result = sprite;
					}
				}
			}
			return result;
		}
	}
}
