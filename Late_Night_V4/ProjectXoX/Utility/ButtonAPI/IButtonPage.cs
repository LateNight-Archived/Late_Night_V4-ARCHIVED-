using System;
using UnityEngine;
using XButtonAPI;

namespace ProjectXoX.Utility.ButtonAPI
{
	// Token: 0x0200004D RID: 77
	public interface IButtonPage
	{
		// Token: 0x0600029A RID: 666
		QMSingleButton AddButton(string text, string tooltip, Action onClick, Sprite sprite = null);

		// Token: 0x0600029B RID: 667
		QMToggleButton AddToggle(string text, string tooltip, Action<bool> onToggle, bool defaultValue = false);

		// Token: 0x0600029C RID: 668
		QMToggleButton AddToggle(string text, string tooltip, Action<bool> configValue);

		// Token: 0x0600029D RID: 669
		QMNestedButton AddMenuPage(string text, string text2, string tooltip = "", bool Root = false, Sprite sprite = null);

		// Token: 0x0600029E RID: 670
		QMCategoryPage AddCategoryPage(string text, string tooltip = "", Sprite sprite = null);

		// Token: 0x0600029F RID: 671
		QMNestedButton GetMenuPage(string name);

		// Token: 0x060002A0 RID: 672
		QMCategoryPage GetCategoryPage(string name);
	}
}
