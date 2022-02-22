using System;
using Late_Night_config;
using Late_Night_V2_Playerlist;
using UnityEngine;
using VRC;

namespace Late_Night_V3_NamePlate
{
	// Token: 0x0200001A RID: 26
	internal class NamePlate : MonoBehaviour
	{
		// Token: 0x060000EC RID: 236 RVA: 0x000078A6 File Offset: 0x00005AA6
		public NamePlate(IntPtr ptr) : base(ptr)
		{
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000078B4 File Offset: 0x00005AB4
		public void Update()
		{
			NamePlate.time += Time.deltaTime;
			bool flag = NamePlate.time <= 1f;
			if (!flag)
			{
				bool betterNamePlate = Config.Instance.BetterNamePlate;
				if (betterNamePlate)
				{
					try
					{
						Playerlist.SetNamePlateColor(base.gameObject.GetComponent<Player>());
						Playerlist.PlayerismasterNamePLate(base.gameObject.GetComponent<Player>());
						Playerlist.Nameplate_TExt_ADMIN(base.gameObject.GetComponent<Player>());
						Playerlist.Nameplate_TExt_QUEST(base.gameObject.GetComponent<Player>());
					}
					catch
					{
					}
				}
				NamePlate.time = 0f;
			}
		}

		// Token: 0x0400006C RID: 108
		public static float time;
	}
}
