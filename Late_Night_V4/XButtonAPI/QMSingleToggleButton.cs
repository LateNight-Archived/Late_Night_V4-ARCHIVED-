using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace XButtonAPI
{
	// Token: 0x02000041 RID: 65
	public class QMSingleToggleButton : QMButtonBase
	{
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00015BB1 File Offset: 0x00013DB1
		// (set) Token: 0x0600024C RID: 588 RVA: 0x00015BB9 File Offset: 0x00013DB9
		private bool state { get; set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00015BC2 File Offset: 0x00013DC2
		// (set) Token: 0x0600024E RID: 590 RVA: 0x00015BCA File Offset: 0x00013DCA
		private string OnText { get; set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00015BD3 File Offset: 0x00013DD3
		// (set) Token: 0x06000250 RID: 592 RVA: 0x00015BDB File Offset: 0x00013DDB
		private string OffText { get; set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000251 RID: 593 RVA: 0x00015BE4 File Offset: 0x00013DE4
		// (set) Token: 0x06000252 RID: 594 RVA: 0x00015BEC File Offset: 0x00013DEC
		private Action OffAction { get; set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00015BF5 File Offset: 0x00013DF5
		// (set) Token: 0x06000254 RID: 596 RVA: 0x00015BFD File Offset: 0x00013DFD
		private Action OnAction { get; set; }

		// Token: 0x06000255 RID: 597 RVA: 0x00015C08 File Offset: 0x00013E08
		public QMSingleToggleButton(Transform transform, string btnTextOn, Action btnActionOn, string btnTextOff, Action btnActionOff, bool position = false, string TooltipON = null, string ToolTipOFF = null) : base(QMStuff.SingleButtonTemplate(), transform, "ToggleButton_" + btnTextOn, true)
		{
			Object.DestroyImmediate(base.RectTransform.Find("Icon").gameObject);
			Object.DestroyImmediate(base.RectTransform.Find("Icon_Secondary").gameObject);
			Object.DestroyImmediate(base.RectTransform.Find("Badge_Close").gameObject);
			Object.DestroyImmediate(base.RectTransform.Find("Badge_MMJump").gameObject);
			TextMeshProUGUI componentInChildren = base.GameObject.GetComponentInChildren<TextMeshProUGUI>();
			componentInChildren.fontSize = 30f;
			componentInChildren.transform.localPosition = new Vector3(componentInChildren.transform.localPosition.x, -25f);
			base.SetTooltip(TooltipON, ToolTipOFF);
			base.SetText(position ? btnTextOn : btnTextOff);
			this.OnText = btnTextOn;
			this.OffText = btnTextOff;
			this.setAction();
			this.OnAction = btnActionOn;
			this.OffAction = btnActionOff;
			this.state = position;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00015D26 File Offset: 0x00013F26
		public void SetActive(bool isActive)
		{
			base.GameObject.SetActive(isActive);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00015D38 File Offset: 0x00013F38
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

		// Token: 0x06000258 RID: 600 RVA: 0x00015DB0 File Offset: 0x00013FB0
		public void setAction()
		{
			base.GameObject.GetComponent<Button>().onClick = new Button.ButtonClickedEvent();
			base.GameObject.GetComponent<Button>().onClick.AddListener(delegate()
			{
				this.state = !this.state;
				this.setToggleState(this.state, true);
			});
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00015DF0 File Offset: 0x00013FF0
		public static QMSingleToggleButton Create(Transform transform, string btnTextOn, Action btnActionOn, string btnTextOff, Action btnActionOff, bool position = false)
		{
			return new QMSingleToggleButton(transform, btnTextOn, btnActionOn, btnTextOff, btnActionOff, position, null, null);
		}
	}
}
