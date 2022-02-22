using System;
using System.Linq;
using UnityEngine;

namespace XButtonAPI
{
	// Token: 0x02000045 RID: 69
	public class QMCategory
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000267 RID: 615 RVA: 0x00016586 File Offset: 0x00014786
		public string Name { get; }

		// Token: 0x06000268 RID: 616 RVA: 0x0001658E File Offset: 0x0001478E
		public QMCategory(string title, Transform parent = null)
		{
			this.Name = QMButtonBase.GetCleanName(title);
			this.Header = new QMHeader(title, parent);
			this._buttonContainer = new QMContainer(this.Name, parent);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x000165C4 File Offset: 0x000147C4
		public QMSlider AddSlider(string Title, Action<float> Value, bool ShowPercent, string Percent = "", string ToolTip = null, float maxValue = 100f, float MinValue = 0f)
		{
			return new QMSlider(Title, Value, this._buttonContainer.RectTransform, ShowPercent, Percent, ToolTip, maxValue, MinValue);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x000165F4 File Offset: 0x000147F4
		public QMSingleToggleButton AddButtonToggle(string TextON, Action ActionON, string TextOFF, Action ActionOFF, bool postion = false, string TooltipON = null, string ToolTipOFF = null)
		{
			return new QMSingleToggleButton(this._buttonContainer.RectTransform, TextON, ActionON, TextOFF, ActionOFF, postion, TooltipON, ToolTipOFF);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00016624 File Offset: 0x00014824
		public QMLabel AddLabel(string text, string subtitle, int fontsize = 56)
		{
			return new QMLabel(this._buttonContainer.RectTransform, text, subtitle, fontsize);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0001664C File Offset: 0x0001484C
		public QMEmptyButton AddPlaceHolder()
		{
			return new QMEmptyButton(this._buttonContainer.RectTransform);
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00016670 File Offset: 0x00014870
		public QMSingleButton AddButton(string text, string tooltip, Action onClick, Sprite sprite = null)
		{
			return new QMSingleButton(text, tooltip, onClick, this._buttonContainer.RectTransform, sprite);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00016698 File Offset: 0x00014898
		public QMToggleButton AddToggle(string text, string tooltip, Action<bool> onToggle, bool defaultValue = false)
		{
			return new QMToggleButton(text, tooltip, onToggle, this._buttonContainer.RectTransform, defaultValue);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x000166C0 File Offset: 0x000148C0
		public QMNestedButton AddMenuPage(string ButtonText, string PageText, string tooltip = "", bool IsRoot = false, Sprite sprite = null)
		{
			QMNestedButton menuPage = this.GetMenuPage(PageText);
			return menuPage ?? new QMNestedButton(this._buttonContainer.RectTransform, ButtonText, PageText, IsRoot, tooltip, sprite);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x000166F8 File Offset: 0x000148F8
		public QMCategoryPage AddCategoryPage(string text, string tooltip = "", Sprite sprite = null)
		{
			QMCategoryPage categoryPage = this.GetCategoryPage(text);
			return categoryPage ?? new QMCategoryPage(this._buttonContainer.RectTransform, text, false, false, tooltip, sprite);
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000271 RID: 625 RVA: 0x0001672C File Offset: 0x0001492C
		public RectTransform RectTransform
		{
			get
			{
				return this._buttonContainer.RectTransform;
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0001673C File Offset: 0x0001493C
		public QMNestedButton GetMenuPage(string name)
		{
			return XButtonAPI.allNestedButtons.FirstOrDefault((QMNestedButton m) => m.Name == QMButtonBase.GetCleanName("Menu_" + name));
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00016774 File Offset: 0x00014974
		public QMCategoryPage GetCategoryPage(string name)
		{
			return XButtonAPI.allcategorypages.FirstOrDefault((QMCategoryPage m) => m.Name == QMButtonBase.GetCleanName("Menu_" + name));
		}

		// Token: 0x06000274 RID: 628 RVA: 0x000167AC File Offset: 0x000149AC
		public QMToggleButton AddToggle(string text, string tooltip, Action<bool> configValue)
		{
			return new QMToggleButton(text, tooltip, configValue, this._buttonContainer.RectTransform, false);
		}

		// Token: 0x040001A2 RID: 418
		public QMHeader Header;

		// Token: 0x040001A3 RID: 419
		public QMContainer _buttonContainer;
	}
}
