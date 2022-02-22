using System;
using System.Linq;
using ProjectXoX.Utility.ButtonAPI;
using UnityEngine;
using UnityEngine.UI;
using VRC.UI.Elements;
using VRC.UI.Elements.Menus;

namespace XButtonAPI
{
	// Token: 0x0200003D RID: 61
	public class QMNestedButton : QMButtonBase, IButtonPage
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000228 RID: 552 RVA: 0x0001508F File Offset: 0x0001328F
		public UIPage UiPage { get; }

		// Token: 0x06000229 RID: 553 RVA: 0x00015098 File Offset: 0x00013298
		public QMNestedButton(Transform transform, string ButtonText, string PageText, bool isRoot = false, string tooltip = "", Sprite sprite = null)
		{
			QMNestedButton.<>c__DisplayClass6_0 CS$<>8__locals1 = new QMNestedButton.<>c__DisplayClass6_0();
			CS$<>8__locals1.isRoot = isRoot;
			base..ctor(QMStuff.NestedMenuTemplate(), QMStuff.NestedMenuTemplate().transform.parent, "Menu_" + PageText, false);
			string Name = QMButtonBase.GetCleanName(PageText);
			base.RectTransform.GetChild(0).name = "Header_" + Name;
			Object.DestroyImmediate(base.GameObject.GetComponent<DevMenu>());
			bool flag = !CS$<>8__locals1.isRoot;
			if (flag)
			{
				base.RectTransform.GetChild(0).GetComponentInChildren<Button>(true).gameObject.SetActive(true);
			}
			base.SetPageText(tooltip);
			base.ClearScroll(base.RectTransform.Find("Scrollrect/Viewport/VerticalLayoutGroup/Buttons"));
			this.UiPage = base.SetUIPage(Name);
			this._container = base.RectTransform.GetComponentInChildren<ScrollRect>().content;
			this.menuContents = base.GameObject.transform.Find("ScrollRect/Viewport/VerticalLayoutGroup");
			Object.DestroyImmediate(this._container.GetComponent<VerticalLayoutGroup>());
			base.SetGridLayout(this._container);
			base.SetScrollRect();
			Object.DestroyImmediate(this._container.Find("Buttons").gameObject);
			Object.DestroyImmediate(this._container.Find("Spacer_8pt").gameObject);
			bool isRoot2 = CS$<>8__locals1.isRoot;
			if (isRoot2)
			{
				QMStuff.MenuStateCtrl.field_Public_ArrayOf_UIPage_0.ToList<UIPage>().Add(this.UiPage);
				QMStuff.MenuStateCtrl.field_Public_ArrayOf_UIPage_0 = QMStuff.MenuStateCtrl.field_Public_ArrayOf_UIPage_0.ToList<UIPage>().ToArray();
			}
			this.MenuButton = new QMSingleButton(ButtonText, tooltip, delegate()
			{
				bool isRoot3 = CS$<>8__locals1.isRoot;
				if (isRoot3)
				{
					QMStuff.MenuStateCtrl.SwitchToRootPage("QuickMenu" + Name, null, false, false);
				}
				else
				{
					QMStuff.MenuStateCtrl.PushPage("QuickMenu" + Name, null, false);
				}
			}, transform, sprite);
			XButtonAPI.allNestedButtons.Add(this);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00015290 File Offset: 0x00013490
		public QMSlider AddSlider(string Title, Action<float> Value, bool ShowPercent, string Percent = "", string ToolTip = null, float maxValue = 100f, float MinValue = 0f)
		{
			return new QMSlider(Title, Value, this.menuContents, ShowPercent, Percent, ToolTip, MinValue, maxValue);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x000152B8 File Offset: 0x000134B8
		public QMSingleToggleButton AddButtonToggle(string TextON, Action ActionON, string TextOFF, Action ActionOFF, bool postion = false, string TooltipON = null, string ToolTipOFF = null)
		{
			return new QMSingleToggleButton(this._container, TextON, ActionON, TextOFF, ActionOFF, postion, TooltipON, ToolTipOFF);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x000152E0 File Offset: 0x000134E0
		public QMEmptyButton AddPlaceHolder()
		{
			return new QMEmptyButton(this._container);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00015300 File Offset: 0x00013500
		public QMLabel AddLabel(string text, string Subtitle, int FontSize = 56)
		{
			return new QMLabel(this._container, text, Subtitle, FontSize);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00015320 File Offset: 0x00013520
		public QMSingleButton AddButton(string text, string tooltip, Action onClick, Sprite sprite = null)
		{
			return new QMSingleButton(text, tooltip, onClick, this._container, sprite);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00015344 File Offset: 0x00013544
		public QMToggleButton AddToggle(string text, string tooltip, Action<bool> onToggle, bool defaultValue = false)
		{
			return new QMToggleButton(text, tooltip, onToggle, this._container, defaultValue);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00015368 File Offset: 0x00013568
		public QMNestedButton AddMenuPage(string ButtonText, string PageText, string tooltip = "", bool IsRoot = false, Sprite sprite = null)
		{
			int num = new Random().Next(0, 9999);
			return new QMNestedButton(this._container, ButtonText, num.ToString() + PageText, IsRoot, tooltip, sprite);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x000153AC File Offset: 0x000135AC
		public QMCategoryPage AddCategoryPage(string text, string tooltip = "", Sprite sprite = null)
		{
			bool flag = this.GetCategoryPage(text) != null;
			QMCategoryPage result;
			if (flag)
			{
				result = this.GetCategoryPage(text);
			}
			else
			{
				result = new QMCategoryPage(this._container, text, false, false, tooltip, sprite);
			}
			return result;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x000153E8 File Offset: 0x000135E8
		public QMNestedButton GetMenuPage(string name)
		{
			return XButtonAPI.allNestedButtons.FirstOrDefault((QMNestedButton m) => m.Name == QMButtonBase.GetCleanName("Menu_" + name));
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00015420 File Offset: 0x00013620
		public QMCategoryPage GetCategoryPage(string name)
		{
			return XButtonAPI.allcategorypages.FirstOrDefault((QMCategoryPage m) => m.Name == QMButtonBase.GetCleanName("Menu_" + name));
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00015458 File Offset: 0x00013658
		public static QMNestedButton Create(Transform transform, string ButtonText, string PageText, bool isRoot, string tooltip = "", Sprite sprite = null)
		{
			return new QMNestedButton(transform, ButtonText, PageText, isRoot, tooltip, sprite);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00015478 File Offset: 0x00013678
		public QMToggleButton AddToggle(string text, string tooltip, Action<bool> configValue)
		{
			return new QMToggleButton(text, tooltip, configValue, this._container, false);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0001549C File Offset: 0x0001369C
		public QMNestedButton AddMenuPage(string ButtonText, string PageText, string tooltip = "", Sprite sprite = null)
		{
			return new QMNestedButton(this._container, ButtonText, PageText, false, tooltip, sprite);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x000154BF File Offset: 0x000136BF
		public QMSingleButton AddSingle(string text, string tooltip, Action onClick, Sprite sprite = null)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000238 RID: 568 RVA: 0x000154C7 File Offset: 0x000136C7
		public QMNestedButton AddMenuPage(string text, string tooltip = "", Sprite sprite = null)
		{
			throw new NotImplementedException();
		}

		// Token: 0x04000187 RID: 391
		public Transform _container;

		// Token: 0x04000188 RID: 392
		public Transform menuContents;

		// Token: 0x0400018A RID: 394
		public QMSingleButton MenuButton;
	}
}
