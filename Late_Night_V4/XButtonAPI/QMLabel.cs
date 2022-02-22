using System;
using TMPro;
using UnityEngine;

namespace XButtonAPI
{
	// Token: 0x0200003B RID: 59
	public class QMLabel : QMButtonBase
	{
		// Token: 0x0600021B RID: 539 RVA: 0x00014B8C File Offset: 0x00012D8C
		public void SetSubtitle(string text)
		{
			TextMeshProUGUI component = base.RectTransform.Find("Text_H4").GetComponent<TextMeshProUGUI>();
			component.richText = true;
			component.text = text;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00014BC0 File Offset: 0x00012DC0
		public void SetText(string text, int fontsize = 56)
		{
			TextMeshProUGUI componentInChildren = base.RectTransform.Find("Text_H1").GetComponentInChildren<TextMeshProUGUI>();
			componentInChildren.text = text;
			componentInChildren.fontSize = (float)fontsize;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00014BF8 File Offset: 0x00012DF8
		public QMLabel(Transform transform, string text, string subtitleText, int fontsize = 56) : base(QMStuff.LabelTemplate(), transform, "Label_" + subtitleText, true)
		{
			Object.DestroyImmediate(base.RectTransform.Find("Text_H1").GetComponent<TextBinding>());
			this.SetText(text, fontsize);
			this.SetSubtitle(subtitleText);
			XButtonAPI.allLabelsButton.Add(this);
		}
	}
}
