using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace XButtonAPI
{
	// Token: 0x0200003A RID: 58
	public class QMSlider : QMButtonBase
	{
		// Token: 0x0600021A RID: 538 RVA: 0x00014A68 File Offset: 0x00012C68
		public QMSlider(string Title, Action<float> onValueChanged, Transform transform, bool ShowPercent, string Tooltip, string percent = "", float maxValue = 100f, float MinValue = 0f) : base(QMStuff.SliderTemplate(), transform, "ValueSlider_" + Title, true)
		{
			this.TextComponent = base.RectTransform.Find("Text_QM_H4").GetComponent<TextMeshProUGUI>();
			if (ShowPercent)
			{
				this.Percent = base.RectTransform.Find("Text_QM_H4 (1)").GetComponent<TextMeshProUGUI>();
				this.Percent.text = percent;
			}
			else
			{
				Object.DestroyImmediate(base.RectTransform.Find("Text_QM_H4 (1)").gameObject);
			}
			this.TextComponent.richText = true;
			this.TextComponent.text = Title;
			base.SetTooltip(Tooltip, Tooltip);
			this.Slider = base.GameObject.GetComponentInChildren<Slider>();
			this.Slider.minValue = MinValue;
			this.Slider.maxValue = maxValue;
			this.Slider.onValueChanged = new Slider.SliderEvent();
			this.Slider.onValueChanged.AddListener(new Action<float>(onValueChanged.Invoke));
			XButtonAPI.allSliders.Add(this);
		}

		// Token: 0x04000180 RID: 384
		public TextMeshProUGUI TextComponent;

		// Token: 0x04000181 RID: 385
		public TextMeshProUGUI Percent;

		// Token: 0x04000182 RID: 386
		private readonly Slider Slider;
	}
}
