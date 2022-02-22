using System;
using UnityEngine;

namespace Late_Night_V3_WorldGameHacks
{
	// Token: 0x02000006 RID: 6
	internal class ClubB
	{
		// Token: 0x06000041 RID: 65 RVA: 0x00003450 File Offset: 0x00001650
		public static bool Inworld()
		{
			return RoomManager.Method_Internal_Static_get_String_0().Contains(ClubB.Worldid);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003474 File Offset: 0x00001674
		public static void Enter1()
		{
			bool flag = !ClubB.Inworld();
			if (!flag)
			{
				foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
				{
					bool flag2 = gameObject.name.Contains("Bedroom 1");
					if (flag2)
					{
						gameObject.SetActive(true);
					}
				}
				Vector3 position;
				position..ctor(-223.7f, -11.3f, 151.1f);
				WorldGameHacks.GetLocalPlayer().transform.position = position;
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003510 File Offset: 0x00001710
		public static void Enter2()
		{
			bool flag = !ClubB.Inworld();
			if (!flag)
			{
				foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
				{
					bool flag2 = gameObject.name.Contains("Bedroom 2");
					if (flag2)
					{
						gameObject.SetActive(true);
					}
				}
				Vector3 position;
				position..ctor(-211.2f, 55.7f, -91.3f);
				WorldGameHacks.GetLocalPlayer().transform.position = position;
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000035AC File Offset: 0x000017AC
		public static void Enter3()
		{
			bool flag = !ClubB.Inworld();
			if (!flag)
			{
				foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
				{
					bool flag2 = gameObject.name.Contains("Bedroom 3");
					if (flag2)
					{
						gameObject.SetActive(true);
					}
				}
				Vector3 position;
				position..ctor(-124.6f, -11.3f, 150.3f);
				WorldGameHacks.GetLocalPlayer().transform.position = position;
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003648 File Offset: 0x00001848
		public static void Enter4()
		{
			bool flag = !ClubB.Inworld();
			if (!flag)
			{
				foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
				{
					bool flag2 = gameObject.name.Contains("Bedroom 4");
					if (flag2)
					{
						gameObject.SetActive(true);
					}
				}
				Vector3 position;
				position..ctor(-111.3f, 55.7f, -90.5f);
				WorldGameHacks.GetLocalPlayer().transform.position = position;
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000036E4 File Offset: 0x000018E4
		public static void Enter5()
		{
			bool flag = !ClubB.Inworld();
			if (!flag)
			{
				foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
				{
					bool flag2 = gameObject.name.Contains("Bedroom 5");
					if (flag2)
					{
						gameObject.SetActive(true);
					}
				}
				Vector3 position;
				position..ctor(-24.7f, -11.3f, 150.6f);
				WorldGameHacks.GetLocalPlayer().transform.position = position;
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003780 File Offset: 0x00001980
		public static void Enter6()
		{
			bool flag = !ClubB.Inworld();
			if (!flag)
			{
				foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
				{
					bool flag2 = gameObject.name.Contains("Bedroom 6");
					if (flag2)
					{
						gameObject.SetActive(true);
					}
				}
				Vector3 position;
				position..ctor(-11.3f, 55.7f, -90.5f);
				WorldGameHacks.GetLocalPlayer().transform.position = position;
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000381C File Offset: 0x00001A1C
		public static void EnterVip()
		{
			bool flag = !ClubB.Inworld();
			if (!flag)
			{
				foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
				{
					bool flag2 = gameObject.name.Contains("Bedroom VIP");
					if (flag2)
					{
						gameObject.SetActive(true);
					}
				}
				Vector3 position;
				position..ctor(57.9796f, 62.8633f, 0.001f);
				WorldGameHacks.GetLocalPlayer().transform.position = position;
			}
		}

		// Token: 0x04000010 RID: 16
		public static string Worldid = "wrld_1b3b3259-0a1f-4311-984e-826abab6f481";
	}
}
