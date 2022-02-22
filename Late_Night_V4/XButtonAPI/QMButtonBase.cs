using System;
using System.Text.RegularExpressions;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VRC.UI.Elements;
using VRC.UI.Elements.Tooltips;

namespace XButtonAPI
{
	// Token: 0x02000039 RID: 57
	public class QMButtonBase
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000208 RID: 520 RVA: 0x00014592 File Offset: 0x00012792
		public string Name { get; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000209 RID: 521 RVA: 0x0001459A File Offset: 0x0001279A
		public GameObject GameObject { get; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600020A RID: 522 RVA: 0x000145A2 File Offset: 0x000127A2
		public RectTransform RectTransform { get; }

		// Token: 0x0600020B RID: 523 RVA: 0x000145AA File Offset: 0x000127AA
		public QMButtonBase(GameObject original, Transform parent, Vector3 pos, string name, bool defaultState = true) : this(original, parent, name, defaultState)
		{
			this.GameObject.transform.localPosition = pos;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x000145CC File Offset: 0x000127CC
		public QMButtonBase(GameObject original, Transform parent, string name, bool defaultState = true)
		{
			this.GameObject = Object.Instantiate<GameObject>(original, parent);
			this.GameObject.name = QMButtonBase.GetCleanName(name);
			this.Name = this.GameObject.name;
			this.GameObject.SetActive(defaultState);
			this.RectTransform = this.GameObject.GetComponent<RectTransform>();
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00014630 File Offset: 0x00012830
		public UIPage SetUIPage(string _menuName)
		{
			UIPage uipage = this.GameObject.AddComponent<UIPage>();
			uipage.field_Public_String_0 = "QuickMenu" + _menuName;
			uipage.field_Private_Boolean_1 = true;
			uipage.field_Private_MenuStateController_0 = QMStuff.MenuStateCtrl;
			uipage.field_Private_List_1_UIPage_0 = new List<UIPage>();
			uipage.field_Private_List_1_UIPage_0.Add(uipage);
			QMStuff.MenuStateCtrl.field_Private_Dictionary_2_String_UIPage_0.Add(uipage.field_Public_String_0, uipage);
			return uipage;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x000146A8 File Offset: 0x000128A8
		public void ClearScroll(Transform transform)
		{
			foreach (Object @object in transform)
			{
				bool flag = @object.Cast<Transform>() == null;
				if (!flag)
				{
					Object.Destroy(@object.Cast<Transform>().gameObject);
				}
			}
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00014718 File Offset: 0x00012918
		public void SetScrollRect()
		{
			this.RectTransform.GetComponentInChildren<ScrollRect>().gameObject.SetActive(true);
			this.RectTransform.GetComponentInChildren<ScrollRect>().enabled = true;
			this.RectTransform.GetComponentInChildren<ScrollRect>().verticalScrollbar = this.RectTransform.GetComponentInChildren<ScrollRect>().transform.Find("Scrollbar").GetComponent<Scrollbar>();
			this.RectTransform.GetComponentInChildren<ScrollRect>().verticalScrollbarVisibility = 0;
			this.RectTransform.GetComponentInChildren<ScrollRect>().viewport.GetComponent<RectMask2D>().enabled = true;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x000147B0 File Offset: 0x000129B0
		public void SetGridLayout(Transform transform)
		{
			GridLayoutGroup component = transform.Find("Buttons").GetComponent<GridLayoutGroup>();
			GridLayoutGroup gridLayoutGroup = transform.gameObject.AddComponent<GridLayoutGroup>();
			gridLayoutGroup.spacing = component.spacing;
			gridLayoutGroup.cellSize = component.cellSize;
			gridLayoutGroup.constraint = component.constraint;
			gridLayoutGroup.constraintCount = component.constraintCount;
			gridLayoutGroup.startAxis = component.startAxis;
			gridLayoutGroup.startCorner = component.startCorner;
			gridLayoutGroup.childAlignment = 0;
			gridLayoutGroup.padding = component.padding;
			gridLayoutGroup.padding.top = 8;
			gridLayoutGroup.padding.left = 64;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00014859 File Offset: 0x00012A59
		public void SetPageText(string PageText)
		{
			this.RectTransform.GetChild(0).GetComponentInChildren<TextMeshProUGUI>().text = PageText;
			this.RectTransform.GetChild(0).GetComponentInChildren<TextMeshProUGUI>().richText = true;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0001488C File Offset: 0x00012A8C
		public void SetText(string text)
		{
			this.RectTransform.GetComponentInChildren<TextMeshProUGUI>().text = text;
			this.RectTransform.GetComponentInChildren<TextMeshProUGUI>().richText = true;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x000148B4 File Offset: 0x00012AB4
		public void SetIfSprite(Sprite sprite)
		{
			TextMeshProUGUI componentInChildren = this.GameObject.GetComponentInChildren<TextMeshProUGUI>();
			bool flag = sprite == null;
			if (flag)
			{
				componentInChildren.fontSize = 30f;
				componentInChildren.transform.localPosition = new Vector3(componentInChildren.transform.localPosition.x, -25f);
				Object.DestroyImmediate(this.RectTransform.Find("Icon").gameObject);
			}
			else
			{
				Image component = this.RectTransform.Find("Icon").GetComponent<Image>();
				component.sprite = sprite;
				component.overrideSprite = sprite;
			}
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00014952 File Offset: 0x00012B52
		public void SetAction(Action onClick)
		{
			this.GameObject.GetComponent<Button>().onClick = new Button.ButtonClickedEvent();
			this.GameObject.GetComponent<Button>().onClick.AddListener(new Action(onClick.Invoke));
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00014992 File Offset: 0x00012B92
		public void SetTooltip(string tooltip, string Alternativ)
		{
			this.RectTransform.GetComponent<UiTooltip>().field_Public_String_0 = tooltip;
			this.RectTransform.GetComponent<UiTooltip>().field_Public_String_1 = Alternativ;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x000149BC File Offset: 0x00012BBC
		public static string GetCleanName(string name)
		{
			return Regex.Replace(Regex.Replace(name, "<.*?>", string.Empty), "[^0-9a-zA-Z_]+", string.Empty);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x000149F0 File Offset: 0x00012BF0
		public void DestroyMe()
		{
			try
			{
				Object.Destroy(this.GameObject);
			}
			catch
			{
			}
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00014A24 File Offset: 0x00012C24
		public void SetIcon(string url)
		{
			this.RectTransform.Find("Icon").GetComponent<Image>().sprite = url.SetSprite();
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00014A48 File Offset: 0x00012C48
		public void SetIcon(bool Activate)
		{
			this.RectTransform.Find("Icon").gameObject.SetActive(Activate);
		}
	}
}
