using System;
using Late_Night_V3_colnsole;
using UnityEngine;
using UnityEngine.UI;

namespace DayClientML2.Utility
{
	// Token: 0x02000050 RID: 80
	internal class MenuCheckbox
	{
		// Token: 0x060002B0 RID: 688 RVA: 0x0001803B File Offset: 0x0001623B
		public void SetActive(bool isActive)
		{
			this.Checkbox.gameObject.SetActive(isActive);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00018050 File Offset: 0x00016250
		public MenuCheckbox(Transform parent, string text, float XPos, float YPos, bool Checked, Action<bool> act, bool Interactable = true)
		{
			try
			{
				this.Checkbox = Object.Instantiate<GameObject>(GameObject.Find("UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/DesktopReticle"), parent, false);
				Object.DestroyImmediate(this.Checkbox.GetComponent<UiSettingConfig>());
				this.Checkbox.name = "Check_" + text;
				this.Checkbox.GetComponent<RectTransform>().anchoredPosition = new Vector2(XPos, YPos);
				this.Text = this.Checkbox.GetComponentInChildren<Text>();
				this.Text.text = text;
				this.Toggle = this.Checkbox.GetComponent<Toggle>();
				this.Toggle.Set(Checked, true);
				this.Toggle.group = new ToggleGroup();
				this.Toggle.name = "Check_" + text;
				this.Toggle.onValueChanged = new Toggle.ToggleEvent();
				this.Toggle.onValueChanged.AddListener(act);
				this.SetInteractable(true);
			}
			catch (Exception)
			{
				LNCcolnsole.ERROR("Error Occurred in Checkbox API", false, ConsoleColor.Red);
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0001817C File Offset: 0x0001637C
		public void SetToggleState(bool state, bool ShouldInvoke = false)
		{
			this.Toggle.Set(state, ShouldInvoke);
			this.Toggle.isOn = state;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0001819A File Offset: 0x0001639A
		public void SetPosition(float xPos, float YPos)
		{
			this.Checkbox.GetComponent<RectTransform>().anchoredPosition = new Vector2(xPos, YPos);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x000181B5 File Offset: 0x000163B5
		public void SetPosition(float xPos, float YPos, float ZPos)
		{
			this.Checkbox.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(xPos, YPos, ZPos);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x000181D1 File Offset: 0x000163D1
		public void SetInteractable(bool State)
		{
			this.Toggle.interactable = State;
		}

		// Token: 0x040001B6 RID: 438
		public Text Text;

		// Token: 0x040001B7 RID: 439
		public Toggle Toggle;

		// Token: 0x040001B8 RID: 440
		public GameObject Checkbox;
	}
}
