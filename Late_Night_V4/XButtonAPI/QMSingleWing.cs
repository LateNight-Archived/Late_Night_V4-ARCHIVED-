using System;
using UnityEngine;
using UnityEngine.UI;

namespace XButtonAPI
{
	// Token: 0x02000040 RID: 64
	public class QMSingleWing : QMWingBase
	{
		// Token: 0x06000249 RID: 585 RVA: 0x00015958 File Offset: 0x00013B58
		public QMSingleWing(string text, string tooltip, Action onClick, Sprite sprite = null, bool left = true, bool arrow = true, bool background = true, bool separator = false) : base(QMStuff.SingleWingTemplate(), (left ? QMStuff.LeftWing : QMStuff.RightWing).field_Public_RectTransform_0.Find("WingMenu/ScrollRect/Viewport/VerticalLayoutGroup"), "Button_" + text, true)
		{
			Transform transform = base.RectTransform.Find("Container").transform;
			transform.Find("Background").gameObject.SetActive(background);
			transform.Find("Icon_Arrow").gameObject.SetActive(arrow);
			base.RectTransform.Find("Separator").gameObject.SetActive(separator);
			Image component = transform.Find("Icon").GetComponent<Image>();
			bool flag = sprite != null;
			if (flag)
			{
				component.sprite = sprite;
				component.overrideSprite = sprite;
				base.SetTextPosition(new Vector2(115f, 0f));
			}
			else
			{
				base.SetTextPosition(new Vector2(50f, 0f));
				component.gameObject.SetActive(false);
			}
			base.SetText(text);
			base.SetAction(onClick);
			base.SetTooltip(tooltip);
			XButtonAPI.allSingleWings.Add(this);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00015A94 File Offset: 0x00013C94
		public QMSingleWing(string text, string tooltip, Action onClick, Transform parent, bool arrow = false, bool background = true, bool separator = false, Sprite sprite = null) : base(QMStuff.SingleWingTemplate(), parent, "Button_" + text, true)
		{
			Transform transform = base.RectTransform.Find("Container").transform;
			transform.Find("Background").gameObject.SetActive(background);
			transform.Find("Icon_Arrow").gameObject.SetActive(arrow);
			base.RectTransform.Find("Separator").gameObject.SetActive(separator);
			Image component = transform.Find("Icon").GetComponent<Image>();
			bool flag = sprite != null;
			if (flag)
			{
				component.sprite = sprite;
				component.overrideSprite = sprite;
				base.SetTextPosition(new Vector2(115f, 0f));
			}
			else
			{
				base.SetTextPosition(new Vector2(50f, 0f));
				component.gameObject.SetActive(false);
			}
			base.SetText(text);
			base.SetAction(onClick);
			base.SetTooltip(tooltip);
			XButtonAPI.allSingleWings.Add(this);
		}
	}
}
