using System;
using DayClientML2.Utility.Extensions;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace DayClientML2.Utility
{
	// Token: 0x02000051 RID: 81
	internal class MenuSlider
	{
		// Token: 0x060002B6 RID: 694 RVA: 0x000181E4 File Offset: 0x000163E4
		public MenuSlider(Transform parent, float x, float y, UnityAction<float> evt, float defaultValue = 0f, float MaxValue = 1f, float MinValue = 0f)
		{
			this.Slider = Object.Instantiate<Transform>(Utils.VRCUiManager.GetMenuContent().transform.Find("Screens/Settings/AudioDevicePanel/VolumeSlider"), parent).gameObject;
			this.Slider.GetComponent<RectTransform>().anchoredPosition = new Vector2(x, y);
			this.Slider.GetComponentInChildren<RectTransform>().anchorMin += new Vector2(0.06f, 0f);
			this.Slider.GetComponentInChildren<RectTransform>().anchorMax += new Vector2(0.1f, 0f);
			this.Slider.GetComponentInChildren<Slider>().onValueChanged = new Slider.SliderEvent();
			this.Slider.GetComponentInChildren<Slider>().onValueChanged.AddListener(evt);
			this.Slider.GetComponentInChildren<Slider>().maxValue = MaxValue;
			this.Slider.GetComponentInChildren<Slider>().minValue = MinValue;
			this.Slider.GetComponentInChildren<Slider>().value = defaultValue;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x000182F8 File Offset: 0x000164F8
		public MenuSlider(Transform parent, string name, float x, float y, UnityAction<float> evt, float defaultValue = 0f, float MaxValue = 1f, float MinValue = 0f)
		{
			this.Slider = Object.Instantiate<Transform>(Utils.VRCUiManager.GetMenuContent().transform.Find("Screens/Settings/AudioDevicePanel/VolumeSlider"), parent).gameObject;
			this.Slider.GetComponent<RectTransform>().anchoredPosition = new Vector2(x, y);
			this.Slider.GetComponentInChildren<Text>().text = name;
			this.Slider.GetComponentInChildren<RectTransform>().anchorMin += new Vector2(0.06f, 0f);
			this.Slider.GetComponentInChildren<RectTransform>().anchorMax += new Vector2(0.1f, 0f);
			this.Slider.GetComponentInChildren<Slider>().onValueChanged = new Slider.SliderEvent();
			this.Slider.GetComponentInChildren<Slider>().onValueChanged.AddListener(evt);
			this.Slider.GetComponentInChildren<Slider>().maxValue = MaxValue;
			this.Slider.GetComponentInChildren<Slider>().minValue = MinValue;
			this.Slider.GetComponentInChildren<Slider>().value = defaultValue;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0001841F File Offset: 0x0001661F
		public void SetMaxValue(float MaxValue)
		{
			this.Slider.GetComponentInChildren<Slider>().maxValue = MaxValue;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00018434 File Offset: 0x00016634
		public void SetMinValue(float MinValue)
		{
			this.Slider.GetComponentInChildren<Slider>().minValue = MinValue;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00018449 File Offset: 0x00016649
		public void SetPos(float x, float y)
		{
			this.Slider.transform.up += new Vector3(x, y);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0001846F File Offset: 0x0001666F
		public void SetValue(float Value)
		{
			this.Slider.GetComponentInChildren<Slider>().value = Value;
		}

		// Token: 0x040001B9 RID: 441
		public GameObject Slider;
	}
}
