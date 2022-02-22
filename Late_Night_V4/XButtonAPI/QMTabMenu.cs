using System;
using UnityEngine;
using UnityEngine.UI;
using VRC.UI.Elements.Controls;

namespace XButtonAPI
{
	// Token: 0x02000049 RID: 73
	public class QMTabMenu : QMButtonBase
	{
		// Token: 0x06000279 RID: 633 RVA: 0x000169D4 File Offset: 0x00014BD4
		public QMTabMenu(string name, string tooltip, string pageName, Sprite sprite) : base(QMStuff.TabButtonTemplate(), QMStuff.TabButtonTemplate().transform.parent, "Page_" + name, true)
		{
			MenuTab component = base.RectTransform.GetComponent<MenuTab>();
			component.field_Public_String_0 = QMButtonBase.GetCleanName("QuickMenu" + pageName);
			component.field_Private_MenuStateController_0 = QMStuff.MenuStateCtrl;
			base.SetAction(new Action(component.ShowTabContent));
			base.SetTooltip(tooltip, tooltip);
			Image component2 = base.RectTransform.Find("Icon").GetComponent<Image>();
			component2.sprite = sprite;
			component2.overrideSprite = sprite;
			XButtonAPI.allTabsButton.Add(this);
		}
	}
}
