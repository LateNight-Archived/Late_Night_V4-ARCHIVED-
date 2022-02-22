using System;
using System.Collections.Generic;
using System.Linq;
using Il2CppSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VRC.UI.Elements;
using VRC.UI.Elements.Menus;

namespace XButtonAPI
{
	// Token: 0x02000044 RID: 68
	public class QMCategoryPage : QMButtonBase
	{
		// Token: 0x06000260 RID: 608 RVA: 0x0001604C File Offset: 0x0001424C
		public QMCategoryPage(string text, bool isRoot = false) : base(QMStuff.CatergoyPageTemplate(), QMStuff.CatergoyPageTemplate().transform.parent, "Menu_" + text, false)
		{
			this.Names = QMButtonBase.GetCleanName(text);
			this.Root = isRoot;
			ScrollRect componentInChildren = base.RectTransform.GetComponentInChildren<ScrollRect>();
			componentInChildren.content.GetComponent<VerticalLayoutGroup>().childControlHeight = true;
			componentInChildren.enabled = true;
			componentInChildren.verticalScrollbar = componentInChildren.transform.Find("Scrollbar").GetComponent<Scrollbar>();
			componentInChildren.viewport.GetComponent<RectMask2D>().enabled = true;
			Object.DestroyImmediate(base.GameObject.GetComponent<LaunchPadQMMenu>());
			Transform child = base.RectTransform.GetChild(0);
			child.GetComponentInChildren<TextMeshProUGUI>().text = text;
			child.GetComponentInChildren<TextMeshProUGUI>().richText = true;
			base.RectTransform.SetSiblingIndex(QMStuff.Instance.field_Public_Transform_0.Find("Window/QMParent/Modal_AddMessage").GetSiblingIndex());
			bool flag = !isRoot;
			if (flag)
			{
				child.GetComponentInChildren<Button>(true).gameObject.SetActive(true);
			}
			this._container = base.RectTransform.GetComponentInChildren<ScrollRect>().content;
			foreach (Object @object in this._container)
			{
				Transform transform = @object.Cast<Transform>();
				bool flag2 = transform != null;
				if (flag2)
				{
					Object.Destroy(transform.gameObject);
				}
			}
			UIPage item = base.SetUIPage(this.Names);
			if (isRoot)
			{
				List<UIPage> list = QMStuff.MenuStateCtrl.field_Public_ArrayOf_UIPage_0.ToList<UIPage>();
				list.Add(item);
				QMStuff.MenuStateCtrl.field_Public_ArrayOf_UIPage_0 = list.ToArray();
			}
			XButtonAPI.allcategorypages.Add(this);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00016244 File Offset: 0x00014444
		public QMCategoryPage(Transform transform, string text, bool isRoot = false, bool IsWing = false, string tooltip = "", Sprite sprite = null) : base(QMStuff.CatergoyPageTemplate(), QMStuff.CatergoyPageTemplate().transform.parent, "Menu_" + text, false)
		{
			this.Names = QMButtonBase.GetCleanName(text);
			this.Root = isRoot;
			ScrollRect componentInChildren = base.RectTransform.GetComponentInChildren<ScrollRect>();
			componentInChildren.content.GetComponent<VerticalLayoutGroup>().childControlHeight = true;
			componentInChildren.enabled = true;
			componentInChildren.verticalScrollbar = componentInChildren.transform.Find("Scrollbar").GetComponent<Scrollbar>();
			componentInChildren.viewport.GetComponent<RectMask2D>().enabled = true;
			Object.DestroyImmediate(base.GameObject.GetComponent<LaunchPadQMMenu>());
			Transform child = base.RectTransform.GetChild(0);
			child.GetComponentInChildren<TextMeshProUGUI>().text = text;
			child.GetComponentInChildren<TextMeshProUGUI>().richText = true;
			Object.DestroyImmediate(child.Find("RightItemContainer/Button_QM_Expand").gameObject);
			base.RectTransform.SetSiblingIndex(QMStuff.Instance.field_Public_Transform_0.Find("Window/QMParent/Modal_AddMessage").GetSiblingIndex());
			bool flag = !isRoot;
			if (flag)
			{
				child.GetComponentInChildren<Button>(true).gameObject.SetActive(true);
			}
			this._container = base.RectTransform.GetComponentInChildren<ScrollRect>().content;
			foreach (Object @object in this._container)
			{
				Transform transform2 = @object.Cast<Transform>();
				bool flag2 = transform2 != null;
				if (flag2)
				{
					Object.Destroy(transform2.gameObject);
				}
			}
			UIPage item = base.SetUIPage(this.Names);
			if (isRoot)
			{
				List<UIPage> list = QMStuff.MenuStateCtrl.field_Public_ArrayOf_UIPage_0.ToList<UIPage>();
				list.Add(item);
				QMStuff.MenuStateCtrl.field_Public_ArrayOf_UIPage_0 = list.ToArray();
			}
			if (IsWing)
			{
				this.wing = new QMSingleWing(text, tooltip, delegate()
				{
					this.Open();
				}, transform, false, true, false, sprite);
			}
			else
			{
				this.Button = new QMSingleButton(text, tooltip, delegate()
				{
					this.Open();
				}, transform, sprite);
			}
			XButtonAPI.allcategorypages.Add(this);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x000164A0 File Offset: 0x000146A0
		public void Open()
		{
			bool root = this.Root;
			if (root)
			{
				QMStuff.MenuStateCtrl.SwitchToRootPage("QuickMenu" + this.Names, null, false, false);
			}
			else
			{
				QMStuff.MenuStateCtrl.PushPage("QuickMenu" + this.Names, null, false);
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x000164F8 File Offset: 0x000146F8
		public QMCategory AddCategory(string title)
		{
			QMCategory category = this.GetCategory(title);
			bool flag = category != null;
			QMCategory result;
			if (flag)
			{
				result = category;
			}
			else
			{
				QMCategory qmcategory = new QMCategory(title, this._container);
				this._categories.Add(qmcategory);
				result = qmcategory;
			}
			return result;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0001653C File Offset: 0x0001473C
		public QMCategory GetCategory(string name)
		{
			return this._categories.FirstOrDefault((QMCategory c) => c.Name == QMButtonBase.GetCleanName(name));
		}

		// Token: 0x0400019C RID: 412
		private readonly Transform _container;

		// Token: 0x0400019D RID: 413
		private readonly List<QMCategory> _categories = new List<QMCategory>();

		// Token: 0x0400019E RID: 414
		public QMSingleButton Button;

		// Token: 0x0400019F RID: 415
		public QMSingleWing wing;

		// Token: 0x040001A0 RID: 416
		private readonly string Names;

		// Token: 0x040001A1 RID: 417
		private readonly bool Root;
	}
}
