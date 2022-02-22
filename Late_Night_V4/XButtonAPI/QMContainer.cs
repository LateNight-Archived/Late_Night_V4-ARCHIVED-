using System;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace XButtonAPI
{
	// Token: 0x02000048 RID: 72
	public class QMContainer : QMButtonBase
	{
		// Token: 0x06000277 RID: 631 RVA: 0x000168CC File Offset: 0x00014ACC
		public QMContainer(string name, Transform parent = null) : base(QMStuff.ContainerTemplate(), (parent == null) ? QMStuff.ContainerTemplate().transform.parent : parent, "Buttons_" + name, true)
		{
			foreach (Object @object in base.RectTransform)
			{
				Transform transform = @object.Cast<Transform>();
				bool flag = transform == null;
				if (!flag)
				{
					Object.Destroy(transform.gameObject);
				}
			}
			this.SetButtonAnchor(1);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00016980 File Offset: 0x00014B80
		public void SetButtonAnchor(TextAnchor textAnchor)
		{
			this.gridLayout = base.GameObject.GetComponent<GridLayoutGroup>();
			this.gridLayout.childAlignment = textAnchor;
			this.gridLayout.padding.top = 8;
			this.gridLayout.padding.left = 64;
		}

		// Token: 0x040001A5 RID: 421
		public GridLayoutGroup gridLayout;
	}
}
