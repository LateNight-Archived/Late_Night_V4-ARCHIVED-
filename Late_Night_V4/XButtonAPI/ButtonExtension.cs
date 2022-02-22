using System;
using System.Linq;
using System.Reflection;
using VRC.UI.Core;
using VRC.UI.Elements;
using VRC.UI.Elements.Controls;

namespace XButtonAPI
{
	// Token: 0x0200004B RID: 75
	public static class ButtonExtension
	{
		// Token: 0x06000290 RID: 656 RVA: 0x00016F3C File Offset: 0x0001513C
		public static void OnValueChanged(this ToggleIcon toggleIcon, bool arg0)
		{
			if (ButtonExtension._onValueChanged == null)
			{
				ButtonExtension._onValueChanged = (ButtonExtension.OnValueChangedDelegate)Delegate.CreateDelegate(typeof(ButtonExtension.OnValueChangedDelegate), typeof(ToggleIcon).GetMethods().FirstOrDefault((MethodInfo m) => m.Name.StartsWith("Method_Private_Void_Boolean_PDM_") && QMStuff.CheckMethod(m, "Toggled")));
			}
			ButtonExtension._onValueChanged(toggleIcon, arg0);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00016FAC File Offset: 0x000151AC
		public static void PushPage(this MenuStateController menuStateCtrl, string pageName, UIContext uiContext = null, bool clearPageStack = false)
		{
			if (ButtonExtension._pushPage == null)
			{
				ButtonExtension._pushPage = (ButtonExtension.PushPageDelegate)Delegate.CreateDelegate(typeof(ButtonExtension.PushPageDelegate), typeof(MenuStateController).GetMethods().FirstOrDefault((MethodInfo m) => m.Name.StartsWith("Method_Public_Void_String_UIContext_Boolean_") && QMStuff.CheckMethod(m, "No page named")));
			}
			ButtonExtension._pushPage(menuStateCtrl, pageName, uiContext, clearPageStack);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0001701C File Offset: 0x0001521C
		public static void SwitchToRootPage(this MenuStateController menuStateCtrl, string pageName, UIContext uiContext = null, bool clearPageStack = false, bool inPlace = false)
		{
			if (ButtonExtension._switchToRootPage == null)
			{
				ButtonExtension._switchToRootPage = (ButtonExtension.SwitchToRootPageDelegate)Delegate.CreateDelegate(typeof(ButtonExtension.SwitchToRootPageDelegate), typeof(MenuStateController).GetMethods().FirstOrDefault((MethodInfo m) => m.Name.StartsWith("Method_Public_Void_String_UIContext_Boolean_") && QMStuff.CheckMethod(m, "UIPage not in root page list:")));
			}
			ButtonExtension._switchToRootPage(menuStateCtrl, pageName, uiContext, clearPageStack, inPlace);
		}

		// Token: 0x040001A6 RID: 422
		private static ButtonExtension.OnValueChangedDelegate _onValueChanged;

		// Token: 0x040001A7 RID: 423
		private static ButtonExtension.PushPageDelegate _pushPage;

		// Token: 0x040001A8 RID: 424
		private static ButtonExtension.SwitchToRootPageDelegate _switchToRootPage;

		// Token: 0x020000A9 RID: 169
		// (Invoke) Token: 0x060006D2 RID: 1746
		private delegate void OnValueChangedDelegate(ToggleIcon toggleIcon, bool arg0);

		// Token: 0x020000AA RID: 170
		// (Invoke) Token: 0x060006D6 RID: 1750
		private delegate void PushPageDelegate(MenuStateController menuStateCtrl, string pageName, UIContext uiContext, bool clearPageStack);

		// Token: 0x020000AB RID: 171
		// (Invoke) Token: 0x060006DA RID: 1754
		private delegate void SwitchToRootPageDelegate(MenuStateController menuStateCtrl, string pageName, UIContext uiContext, bool clearPageStack, bool inPlace);
	}
}
