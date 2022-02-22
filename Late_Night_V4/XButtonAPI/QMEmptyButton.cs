using System;
using UnityEngine;

namespace XButtonAPI
{
	// Token: 0x02000046 RID: 70
	public class QMEmptyButton : QMButtonBase
	{
		// Token: 0x06000275 RID: 629 RVA: 0x000167D4 File Offset: 0x000149D4
		public QMEmptyButton(Transform parent) : base(QMStuff.ContainerTemplate(), parent, "Button_Empty", true)
		{
			for (int i = base.GameObject.transform.childCount - 1; i >= 0; i--)
			{
				Object.DestroyImmediate(base.GameObject.transform.GetChild(i).gameObject);
			}
			XButtonAPI.allEmpty.Add(this);
		}
	}
}
