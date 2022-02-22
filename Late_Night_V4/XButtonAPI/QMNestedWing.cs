using System;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VRC.UI.Elements;

namespace XButtonAPI
{
	// Token: 0x0200003C RID: 60
	public class QMNestedWing : QMWingBase
	{
		// Token: 0x0600021E RID: 542 RVA: 0x00014C58 File Offset: 0x00012E58
		public QMNestedWing(string ButtonText, string PageText, bool left = false, string tooltip = "", Sprite sprite = null) : base(QMStuff.WingMenuTemplate(), (left ? QMStuff.LeftWing : QMStuff.RightWing).field_Public_RectTransform_0, (left ? "Left" : "Right") + "Wing" + QMWingBase.GetCleanName(PageText), false)
		{
			this._menuName = QMWingBase.GetCleanName(PageText);
			this._wing = (left ? QMStuff.LeftWing : QMStuff.RightWing);
			this._container = base.RectTransform.GetComponentInChildren<ScrollRect>().content;
			base.RectTransform.GetComponentInChildren<VerticalLayoutGroup>().spacing = -20f;
			base.SetPageText(PageText);
			base.ClearScroll(base.RectTransform.GetComponentInChildren<ScrollRect>());
			base.SetUIPage(base.GameObject.GetComponent<UIPage>(), this._menuName, this._wing.field_Private_MenuStateController_0);
			base.RectTransform.GetChild(0).GetComponentInChildren<Button>(true).gameObject.SetActive(true);
			base.RectTransform.GetChild(0).GetComponentInChildren<Button>(true).transform.Find("Icon").gameObject.SetActive(true);
			List<Behaviour> list = new List<Behaviour>();
			base.RectTransform.GetChild(0).GetComponentInChildren<Button>(true).GetComponents<Behaviour>(list);
			foreach (Behaviour behaviour in list)
			{
				behaviour.enabled = true;
			}
			this.SingleWing = new QMSingleWing(ButtonText, tooltip, delegate()
			{
				this._wing.field_Private_MenuStateController_0.Method_Public_Void_String_UIContext_Boolean_0(this._menuName, null, false);
			}, sprite, left, true, true, false);
			XButtonAPI.allnestedWings.Add(this);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00014DE8 File Offset: 0x00012FE8
		public QMNestedWing(Transform transform, string PageText, bool left = false, string tooltip = "", Sprite sprite = null) : base(QMStuff.WingMenuTemplate(), (left ? QMStuff.LeftWing : QMStuff.RightWing).field_Public_RectTransform_0, (left ? "Left" : "Right") + "Wing" + QMWingBase.GetCleanName(PageText), false)
		{
			this._menuName = QMWingBase.GetCleanName(PageText);
			this._wing = (left ? QMStuff.LeftWing : QMStuff.RightWing);
			this._container = base.RectTransform.GetComponentInChildren<ScrollRect>().content;
			base.RectTransform.GetComponentInChildren<VerticalLayoutGroup>().spacing = -20f;
			base.SetPageText(PageText);
			base.ClearScroll(base.RectTransform.GetComponentInChildren<ScrollRect>());
			base.SetUIPage(base.GameObject.GetComponent<UIPage>(), this._menuName, this._wing.field_Private_MenuStateController_0);
			base.RectTransform.GetChild(0).GetComponentInChildren<Button>(true).gameObject.SetActive(true);
			base.RectTransform.GetChild(0).GetComponentInChildren<Button>(true).transform.Find("Icon").gameObject.SetActive(true);
			List<Behaviour> list = new List<Behaviour>();
			base.RectTransform.GetChild(0).GetComponentInChildren<Button>(true).GetComponents<Behaviour>(list);
			foreach (Behaviour behaviour in list)
			{
				behaviour.enabled = true;
			}
			this.SingleWing = new QMSingleWing(PageText, tooltip, delegate()
			{
				this._wing.field_Private_MenuStateController_0.Method_Public_Void_String_UIContext_Boolean_0(this._menuName, null, false);
			}, transform, false, true, false, sprite);
			XButtonAPI.allnestedWings.Add(this);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00014F78 File Offset: 0x00013178
		public QMEmptyWing AddEmpty()
		{
			return new QMEmptyWing(this._container);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00014F98 File Offset: 0x00013198
		public QMSingleWing AddButton(string text, string tooltip, Action onClick, bool arrow = true, bool background = true, bool separator = false, Sprite sprite = null)
		{
			return new QMSingleWing(text, tooltip, onClick, this._container, arrow, background, separator, sprite);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00014FC0 File Offset: 0x000131C0
		public QMToggleWing AddToggle(string TextON, Action ON, string TextOFF, Action OFF, bool DefaultPosition, bool arrow = true, bool background = true, bool Icon = true, bool Separator = false)
		{
			return new QMToggleWing(this._container, TextON, ON, TextOFF, OFF, DefaultPosition, background, arrow, Icon, Separator);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00014FEC File Offset: 0x000131EC
		public QMNestedWing AddSubMenu(string text, string tooltip, bool left = true, Sprite sprite = null)
		{
			return new QMNestedWing(this._container, text, left, tooltip, sprite);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00015010 File Offset: 0x00013210
		public QMNestedButton AddMenuPage(bool root, string ButtonText, string PageText, string tooltip, Sprite sprite = null)
		{
			return new QMNestedButton(this._container, ButtonText, PageText, root, tooltip, sprite);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00015034 File Offset: 0x00013234
		public QMCategoryPage AddCatergory(bool root, string text, string tooltip, Sprite sprite = null)
		{
			return new QMCategoryPage(this._container, text, root, true, tooltip, sprite);
		}

		// Token: 0x04000183 RID: 387
		private readonly Wing _wing;

		// Token: 0x04000184 RID: 388
		private readonly string _menuName;

		// Token: 0x04000185 RID: 389
		private readonly Transform _container;

		// Token: 0x04000186 RID: 390
		public QMSingleWing SingleWing;
	}
}
