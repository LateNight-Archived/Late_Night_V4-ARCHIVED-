using System;
using Late_Night_config;
using Late_Night_V3_AviFave;
using UnityEngine;

namespace Late_Night_V3_BigMenuBeh
{
	// Token: 0x0200006D RID: 109
	internal class BigMenuBeh : MonoBehaviour
	{
		// Token: 0x0600046F RID: 1135 RVA: 0x0001E1DC File Offset: 0x0001C3DC
		public BigMenuBeh(IntPtr ptr) : base(ptr)
		{
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0001E1E8 File Offset: 0x0001C3E8
		public void Start()
		{
			AviFave.showList();
			bool flag = !Config.Instance.LocalAvatarLog;
			if (flag)
			{
				AviFave.SEENAvis.GameObject.SetActive(false);
			}
			bool flag2 = !Config.Instance.FavList;
			if (flag2)
			{
				AviFave.Avis.GameObject.SetActive(false);
			}
			bool flag3 = !Config.Instance.SearchList;
			if (flag3)
			{
				AviFave.AviSearchlist.GameObject.SetActive(false);
			}
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0001E268 File Offset: 0x0001C468
		public void Update()
		{
			BigMenuBeh.time += Time.deltaTime;
			bool flag = BigMenuBeh.time <= 0.1f;
			if (!flag)
			{
				bool flag2 = !Config.Instance.LocalAvatarLog;
				if (flag2)
				{
					AviFave.SEENAvis.GameObject.SetActive(false);
				}
				bool flag3 = !Config.Instance.FavList;
				if (flag3)
				{
					AviFave.Avis.GameObject.SetActive(false);
				}
				bool flag4 = !Config.Instance.SearchList;
				if (flag4)
				{
					AviFave.AviSearchlist.GameObject.SetActive(false);
				}
				BigMenuBeh.time = 0f;
			}
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0001E311 File Offset: 0x0001C511
		public void OnDisable()
		{
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x0001E314 File Offset: 0x0001C514
		public void OnEnable()
		{
			AviFave.showList();
			bool flag = !Config.Instance.LocalAvatarLog;
			if (flag)
			{
				AviFave.SEENAvis.GameObject.SetActive(false);
			}
			bool flag2 = !Config.Instance.FavList;
			if (flag2)
			{
				AviFave.Avis.GameObject.SetActive(false);
			}
			bool flag3 = !Config.Instance.SearchList;
			if (flag3)
			{
				AviFave.AviSearchlist.GameObject.SetActive(false);
			}
		}

		// Token: 0x040001F1 RID: 497
		public static float time;
	}
}
