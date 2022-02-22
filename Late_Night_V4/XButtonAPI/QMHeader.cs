using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace XButtonAPI
{
	// Token: 0x02000047 RID: 71
	public class QMHeader : QMButtonBase
	{
		// Token: 0x06000276 RID: 630 RVA: 0x00016844 File Offset: 0x00014A44
		public QMHeader(string title, Transform parent) : base(QMStuff.HeaderTemplate(), (parent == null) ? QMStuff.HeaderTemplate().transform.parent : parent, "Header_" + title, true)
		{
			base.GameObject.GetComponentInChildren<TextMeshProUGUI>().text = title;
			base.GameObject.GetComponentInChildren<TextMeshProUGUI>().richText = true;
			base.GameObject.GetComponentInChildren<TextMeshProUGUI>().transform.parent.GetComponent<HorizontalLayoutGroup>().childControlWidth = true;
		}
	}
}
