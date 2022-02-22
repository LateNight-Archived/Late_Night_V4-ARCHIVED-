using System;
using UnityEngine;

namespace XButtonAPI
{
	// Token: 0x02000043 RID: 67
	public class QMSingleButton : QMButtonBase
	{
		// Token: 0x0600025F RID: 607 RVA: 0x00015FA4 File Offset: 0x000141A4
		public QMSingleButton(string text, string tooltip, Action onClick, Transform parent, Sprite sprite = null) : base(QMStuff.SingleButtonTemplate(), parent, "Button_" + text, true)
		{
			base.SetText(text);
			base.SetTooltip(tooltip, tooltip);
			base.SetAction(onClick);
			base.SetIfSprite(sprite);
			Object.DestroyImmediate(base.RectTransform.Find("Icon_Secondary").gameObject);
			Object.DestroyImmediate(base.RectTransform.Find("Badge_Close").gameObject);
			Object.DestroyImmediate(base.RectTransform.Find("Badge_MMJump").gameObject);
			XButtonAPI.allSingleButtons.Add(this);
		}
	}
}
