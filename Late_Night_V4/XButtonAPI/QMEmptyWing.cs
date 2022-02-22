using System;
using UnityEngine;

namespace XButtonAPI
{
	// Token: 0x0200003F RID: 63
	public class QMEmptyWing : QMWingBase
	{
		// Token: 0x06000248 RID: 584 RVA: 0x00015884 File Offset: 0x00013A84
		public QMEmptyWing(Transform parent) : base(QMStuff.SingleWingTemplate(), parent, "Button_Empty", true)
		{
			Transform transform = base.RectTransform.Find("Container").transform;
			transform.Find("Background").gameObject.SetActive(false);
			transform.Find("Icon_Arrow").gameObject.SetActive(false);
			base.RectTransform.sizeDelta = new Vector2(420f, 123f);
			base.RectTransform.Find("Separator").gameObject.SetActive(false);
			Object.DestroyImmediate(transform.Find("Icon").gameObject);
			Object.DestroyImmediate(transform.Find("Text_QM_H3").gameObject);
			XButtonAPI.allEmptyWings.Add(this);
		}
	}
}
