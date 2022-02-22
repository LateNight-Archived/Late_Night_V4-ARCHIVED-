using System;
using UnityEngine;
using UnityEngine.UI;

namespace DayClientML2.Utility.MenuApi
{
	// Token: 0x02000057 RID: 87
	public class MenuArrow
	{
		// Token: 0x06000341 RID: 833 RVA: 0x00019868 File Offset: 0x00017A68
		public MenuArrow(Transform parent, float PosX, float PosY, Action act, bool prev)
		{
			this.GameObject = Object.Instantiate<GameObject>(prev ? GameObject.Find("UserInterface/MenuContent/Screens/Settings/AudioDevicePanel/SelectPrevMic") : GameObject.Find("UserInterface/MenuContent/Screens/Settings/AudioDevicePanel/SelectNextMic"), parent, false);
			this.GameObject.name = "VRCArrow_" + PosX.ToString() + "_" + PosY.ToString();
			this.GameObject.GetComponent<RectTransform>().sizeDelta *= new Vector2(2f, 2f);
			this.GameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(PosX, PosY);
			this.GameObject.GetComponent<Button>().onClick = new Button.ButtonClickedEvent();
			this.GameObject.GetComponent<Button>().onClick.AddListener(act);
		}

		// Token: 0x040001C5 RID: 453
		public GameObject GameObject;
	}
}
