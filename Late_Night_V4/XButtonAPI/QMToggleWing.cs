using System;
using UnityEngine;
using UnityEngine.UI;

namespace XButtonAPI
{
	// Token: 0x0200003E RID: 62
	public class QMToggleWing : QMWingBase
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000239 RID: 569 RVA: 0x000154CF File Offset: 0x000136CF
		// (set) Token: 0x0600023A RID: 570 RVA: 0x000154D7 File Offset: 0x000136D7
		private bool state { get; set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600023B RID: 571 RVA: 0x000154E0 File Offset: 0x000136E0
		// (set) Token: 0x0600023C RID: 572 RVA: 0x000154E8 File Offset: 0x000136E8
		private string OnText { get; set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600023D RID: 573 RVA: 0x000154F1 File Offset: 0x000136F1
		// (set) Token: 0x0600023E RID: 574 RVA: 0x000154F9 File Offset: 0x000136F9
		private string OffText { get; set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600023F RID: 575 RVA: 0x00015502 File Offset: 0x00013702
		// (set) Token: 0x06000240 RID: 576 RVA: 0x0001550A File Offset: 0x0001370A
		private Action OffAction { get; set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00015513 File Offset: 0x00013713
		// (set) Token: 0x06000242 RID: 578 RVA: 0x0001551B File Offset: 0x0001371B
		private Action OnAction { get; set; }

		// Token: 0x06000243 RID: 579 RVA: 0x00015524 File Offset: 0x00013724
		public QMToggleWing(Transform transform, string btnTextOn, Action btnActionOn, string btnTextOff, Action btnActionOff, bool position = false, bool backroundshow = true, bool arrow = true, bool iconshow = true, bool Separator = false) : base(QMStuff.SingleWingTemplate(), transform, "Button_" + btnTextOn, true)
		{
			this.container = base.RectTransform.Find("Container").transform;
			this.container.Find("Background").gameObject.SetActive(backroundshow);
			this.container.Find("Icon_Arrow").gameObject.SetActive(arrow);
			base.RectTransform.Find("Separator").gameObject.SetActive(Separator);
			Image component = this.container.Find("Icon").GetComponent<Image>();
			component.gameObject.SetActive(false);
			bool flag = !iconshow;
			if (flag)
			{
				base.SetTextPosition(new Vector2(50f, 0f));
			}
			base.SetText(position ? btnTextOn : btnTextOff);
			this.OnText = btnTextOn;
			this.OffText = btnTextOff;
			this.setAction();
			this.OnAction = btnActionOn;
			this.OffAction = btnActionOff;
			this.state = position;
			base.SetActive(true);
			XButtonAPI.allToggleWings.Add(this);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00015658 File Offset: 0x00013858
		public QMToggleWing(string btnTextOn, Action btnActionOn, string btnTextOff, Action btnActionOff, bool left = true, bool position = false, bool backroundshow = true, bool arrow = true, bool iconshow = true) : base(QMStuff.SingleWingTemplate(), (left ? QMStuff.LeftWing : QMStuff.RightWing).field_Public_RectTransform_0.Find("WingMenu/ScrollRect/Viewport/VerticalLayoutGroup"), "Button_" + btnTextOn, true)
		{
			this.container = base.RectTransform.Find("Container").transform;
			this.container.Find("Background").gameObject.SetActive(backroundshow);
			this.container.Find("Icon_Arrow").gameObject.SetActive(arrow);
			Image component = this.container.Find("Icon").GetComponent<Image>();
			component.gameObject.SetActive(false);
			bool flag = !component;
			if (flag)
			{
				base.SetTextPosition(new Vector2(50f, 0f));
			}
			base.SetText(position ? btnTextOn : btnTextOff);
			this.OnText = btnTextOn;
			this.OffText = btnTextOff;
			this.setAction();
			this.OnAction = btnActionOn;
			this.OffAction = btnActionOff;
			this.state = position;
			base.SetActive(true);
			XButtonAPI.allToggleWings.Add(this);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0001578C File Offset: 0x0001398C
		public void setToggleState(bool toggleOn, bool shouldInvoke = false)
		{
			this.state = toggleOn;
			base.SetText(toggleOn ? this.OnText : this.OffText);
			try
			{
				if (!toggleOn)
				{
					if (shouldInvoke)
					{
						this.OffAction();
					}
				}
				else if (shouldInvoke)
				{
					this.OnAction();
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00015804 File Offset: 0x00013A04
		public void setAction()
		{
			base.GameObject.GetComponent<Button>().onClick = new Button.ButtonClickedEvent();
			base.GameObject.GetComponent<Button>().onClick.AddListener(delegate()
			{
				this.state = !this.state;
				bool state = this.state;
				if (state)
				{
					this.setToggleState(true, true);
				}
				else
				{
					this.setToggleState(false, true);
				}
			});
		}

		// Token: 0x0400018B RID: 395
		public Transform container;

		// Token: 0x0400018C RID: 396
		public GameObject backround;

		// Token: 0x0400018D RID: 397
		public GameObject icon;

		// Token: 0x0400018E RID: 398
		public GameObject icon_arrow;
	}
}
