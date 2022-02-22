using System;
using UnityEngine;
using VRC.Udon;

namespace Late_Night_V3_WorldGameHacks
{
	// Token: 0x02000007 RID: 7
	internal class FBT
	{
		// Token: 0x0600004B RID: 75 RVA: 0x000038D0 File Offset: 0x00001AD0
		public static bool Inworld()
		{
			return RoomManager.Method_Internal_Static_get_String_0().Contains(FBT.Worldid);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000038F4 File Offset: 0x00001AF4
		public static void OpenAllRooms()
		{
			bool flag = !FBT.Inworld();
			if (!flag)
			{
				try
				{
					Object.Destroy(GameObject.Find("Logger"));
				}
				catch
				{
				}
				foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
				{
					bool flag2 = gameObject.name.StartsWith("Room") && gameObject.name.Contains("main script");
					if (flag2)
					{
						gameObject.GetComponent<UdonBehaviour>().SendCustomNetworkEvent(0, "OffToggle");
					}
				}
			}
		}

		// Token: 0x04000011 RID: 17
		public static string Worldid = "wrld_d319c58a-dcec-47de-b5fc-21200116462c";
	}
}
