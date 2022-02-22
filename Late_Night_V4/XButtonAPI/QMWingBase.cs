using System;
using System.Text.RegularExpressions;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnhollowerRuntimeLib;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using VRC.UI.Elements;
using VRC.UI.Elements.Tooltips;

namespace XButtonAPI
{
	// Token: 0x02000038 RID: 56
	public class QMWingBase
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00014187 File Offset: 0x00012387
		public string Name { get; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x0001418F File Offset: 0x0001238F
		public GameObject GameObject { get; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x00014197 File Offset: 0x00012397
		public RectTransform RectTransform { get; }

		// Token: 0x060001F6 RID: 502 RVA: 0x0001419F File Offset: 0x0001239F
		public QMWingBase(GameObject original, Transform parent, Vector3 pos, string name, bool defaultState = true) : this(original, parent, name, defaultState)
		{
			this.GameObject.transform.localPosition = pos;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x000141C4 File Offset: 0x000123C4
		public QMWingBase(GameObject original, Transform parent, string name, bool defaultState = true)
		{
			this.GameObject = Object.Instantiate<GameObject>(original, parent);
			this.GameObject.name = QMWingBase.GetCleanName(name);
			this.Name = this.GameObject.name;
			this.GameObject.SetActive(defaultState);
			this.RectTransform = this.GameObject.GetComponent<RectTransform>();
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00014228 File Offset: 0x00012428
		public static string GetCleanName(string name)
		{
			return Regex.Replace(Regex.Replace(name, "<.*?>", string.Empty), "[^0-9a-zA-Z_]+", string.Empty);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0001425C File Offset: 0x0001245C
		public void ClearScroll(ScrollRect scrollRect)
		{
			foreach (Object @object in scrollRect.content)
			{
				bool flag = @object.Cast<Transform>() == null;
				if (!flag)
				{
					Object.Destroy(@object.Cast<Transform>().gameObject);
				}
			}
		}

		// Token: 0x060001FA RID: 506 RVA: 0x000142D4 File Offset: 0x000124D4
		public void SetUIPage(UIPage uiPage, string _menuName, MenuStateController menuStateController)
		{
			uiPage.field_Public_String_0 = _menuName;
			uiPage.field_Private_Boolean_1 = true;
			uiPage.field_Private_MenuStateController_0 = menuStateController;
			uiPage.field_Private_List_1_UIPage_0 = new List<UIPage>();
			uiPage.field_Private_List_1_UIPage_0.Add(uiPage);
			menuStateController.field_Private_Dictionary_2_String_UIPage_0.Add(uiPage.field_Public_String_0, uiPage);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00014326 File Offset: 0x00012526
		public void SetActive(bool isActive)
		{
			this.GameObject.SetActive(isActive);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00014336 File Offset: 0x00012536
		public void SetIntractable(bool isIntractable)
		{
			this.GameObject.GetComponent<Button>().interactable = isIntractable;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0001434C File Offset: 0x0001254C
		public void SetAction(Action buttonAction)
		{
			this.GameObject.GetComponent<Button>().onClick = new Button.ButtonClickedEvent();
			this.GameObject.GetComponent<Button>().onClick.RemoveAllListeners();
			this.GameObject.GetComponent<Button>().onClick.AddListener(DelegateSupport.ConvertDelegate<UnityAction>(buttonAction));
		}

		// Token: 0x060001FE RID: 510 RVA: 0x000143A2 File Offset: 0x000125A2
		public void SetTooltip(string tooltip)
		{
			this.GameObject.GetComponent<UiTooltip>().field_Public_String_0 = tooltip;
			this.GameObject.GetComponent<UiTooltip>().field_Public_String_1 = tooltip;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x000143CC File Offset: 0x000125CC
		public void SetText(string buttonText)
		{
			this.GameObject.transform.Find("Container/Text_QM_H3").GetComponent<TextMeshProUGUI>().text = buttonText;
			this.GameObject.transform.Find("Container/Text_QM_H3").GetComponent<TextMeshProUGUI>().richText = true;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0001441C File Offset: 0x0001261C
		public void SetPageText(string PageText)
		{
			this.RectTransform.GetChild(0).GetComponentInChildren<TextMeshProUGUI>().text = PageText;
			this.RectTransform.GetChild(0).GetComponentInChildren<TextMeshProUGUI>().richText = true;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0001444F File Offset: 0x0001264F
		public void SetTextPosition(Vector2 pos)
		{
			this.GameObject.transform.Find("Container/Text_QM_H3").GetComponent<RectTransform>().anchoredPosition = pos;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00014473 File Offset: 0x00012673
		public void SetBackround(string sprite)
		{
			this.GameObject.transform.Find("Background").gameObject.GetComponent<Image>().sprite = sprite.SetSprite();
		}

		// Token: 0x06000203 RID: 515 RVA: 0x000144A1 File Offset: 0x000126A1
		public void SetIcon(string sprite)
		{
			this.GameObject.transform.Find("Icon").gameObject.GetComponent<Image>().sprite = sprite.SetSprite();
		}

		// Token: 0x06000204 RID: 516 RVA: 0x000144CF File Offset: 0x000126CF
		public void SeticonArrow(string sprite)
		{
			this.GameObject.transform.Find("Icon_Arrow").gameObject.GetComponent<Image>().sprite = sprite.SetSprite();
		}

		// Token: 0x06000205 RID: 517 RVA: 0x000144FD File Offset: 0x000126FD
		public void SetBackround(bool active)
		{
			this.GameObject.transform.Find("Background").gameObject.SetActive(active);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00014524 File Offset: 0x00012724
		public void SetIcon(bool active)
		{
			if (active)
			{
				this.SetTextPosition(new Vector2(50f, 0f));
			}
			this.GameObject.transform.Find("Icon").gameObject.SetActive(active);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0001456E File Offset: 0x0001276E
		public void SeticonArrow(bool active)
		{
			this.GameObject.transform.Find("Icon_Arrow").gameObject.SetActive(active);
		}
	}
}
