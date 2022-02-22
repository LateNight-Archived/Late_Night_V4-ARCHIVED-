using System;
using ProjectXoX.Utility;
using UnityEngine;
using UnityEngine.UI;
using VRC.UI.Elements.Controls;

namespace XButtonAPI
{
	// Token: 0x02000042 RID: 66
	public class QMToggleButton : QMButtonBase
	{
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600025B RID: 603 RVA: 0x00015E32 File Offset: 0x00014032
		private static Sprite OnIconSprite
		{
			get
			{
				return QMStuff.Instance.field_Public_Transform_0.Find("Window/QMParent/Menu_Notifications/Panel_NoNotifications_Message/Icon").GetComponent<Image>().sprite;
			}
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00015E54 File Offset: 0x00014054
		public QMToggleButton(string text, string tooltip, Action<bool> onToggle, Transform parent, bool defaultValue = false) : base(QMStuff.ToggleButtonTemplate(), parent, "Button_Toggle" + text, true)
		{
			base.SetText(text);
			base.SetTooltip(tooltip, tooltip);
			base.RectTransform.Find("Icon_On").GetComponent<Image>().sprite = QMToggleButton.OnIconSprite;
			this.toggleIcon = base.GameObject.GetComponent<ToggleIcon>();
			this.toggle = base.GameObject.GetComponent<Toggle>();
			this.toggle.onValueChanged = new Toggle.ToggleEvent();
			this.toggle.onValueChanged.AddListener(new Action<bool>(this.toggleIcon.OnValueChanged));
			this.toggle.onValueChanged.AddListener(new Action<bool>(onToggle.Invoke));
			this.Toggle(defaultValue, false, false);
			base.GameObject.AddComponent<ActionListenerLNC_>().OnEnabled += this.UpdateToggleIfNeeded;
			XButtonAPI.allToggleButtons.Add(this);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00015F60 File Offset: 0x00014160
		public void Toggle(bool value, bool callback = true, bool updateVisually = false)
		{
			this._valueHolder = value;
			this.toggle.Set(value, callback);
			if (updateVisually)
			{
				this.UpdateToggleIfNeeded();
			}
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00015F8F File Offset: 0x0001418F
		private void UpdateToggleIfNeeded()
		{
			this.toggleIcon.OnValueChanged(this._valueHolder);
		}

		// Token: 0x04000199 RID: 409
		private readonly Toggle toggle;

		// Token: 0x0400019A RID: 410
		private readonly ToggleIcon toggleIcon;

		// Token: 0x0400019B RID: 411
		private bool _valueHolder;
	}
}
