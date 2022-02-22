using System;
using UnityEngine;
using VRCSDK2;

namespace Late_Night_V3_WorldGameHacks
{
	// Token: 0x0200000A RID: 10
	internal class Hparty
	{
		// Token: 0x06000071 RID: 113 RVA: 0x00004958 File Offset: 0x00002B58
		public static bool Inworld()
		{
			return RoomManager.Method_Internal_Static_get_String_0().Contains(Hparty.WORLDID);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000497C File Offset: 0x00002B7C
		public static void OpenRoom1()
		{
			bool flag = !Hparty.Inworld();
			if (!flag)
			{
				GameObject gameObject = GameObject.Find("기믹/lock system/sys/001/lock");
				gameObject.GetComponent<VRC_Trigger>().Interact();
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000049B0 File Offset: 0x00002BB0
		public static void OpenRoom2()
		{
			bool flag = !Hparty.Inworld();
			if (!flag)
			{
				GameObject gameObject = GameObject.Find("기믹/lock system/sys/002/lock (1)");
				gameObject.GetComponent<VRC_Trigger>().Interact();
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000049E4 File Offset: 0x00002BE4
		public static void OpenRoom3()
		{
			bool flag = !Hparty.Inworld();
			if (!flag)
			{
				GameObject gameObject = GameObject.Find("기믹/lock system/sys/003/lock (2)");
				gameObject.GetComponent<VRC_Trigger>().Interact();
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00004A18 File Offset: 0x00002C18
		public static void OpenRoom4()
		{
			bool flag = !Hparty.Inworld();
			if (!flag)
			{
				GameObject gameObject = GameObject.Find("기믹/lock system/sys/004/lock (3)");
				gameObject.GetComponent<VRC_Trigger>().Interact();
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00004A4C File Offset: 0x00002C4C
		public static void OpenRoom5()
		{
			bool flag = !Hparty.Inworld();
			if (!flag)
			{
				GameObject gameObject = GameObject.Find("기믹/lock system/sys/005/lock (4)");
				gameObject.GetComponent<VRC_Trigger>().Interact();
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00004A80 File Offset: 0x00002C80
		public static void OpenRoom6()
		{
			bool flag = !Hparty.Inworld();
			if (!flag)
			{
				GameObject gameObject = GameObject.Find("기믹/lock system/sys/006/lock (5)");
				gameObject.GetComponent<VRC_Trigger>().Interact();
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00004AB4 File Offset: 0x00002CB4
		public static void Floor2()
		{
			bool flag = !Hparty.Inworld();
			if (!flag)
			{
				Vector3 position;
				position..ctor(24.9864f, 15.701f, -7.1761f);
				WorldGameHacks.GetLocalPlayer().transform.position = position;
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00004AF8 File Offset: 0x00002CF8
		public static void Floor3()
		{
			bool flag = !Hparty.Inworld();
			if (!flag)
			{
				Vector3 position;
				position..ctor(-61.0076f, 15.961f, -100.1939f);
				WorldGameHacks.GetLocalPlayer().transform.position = position;
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00004B3C File Offset: 0x00002D3C
		public static void tpin1()
		{
			bool flag = !Hparty.Inworld();
			if (!flag)
			{
				Vector3 position;
				position..ctor(-95.376f, 14.242f, 130.0615f);
				WorldGameHacks.GetLocalPlayer().transform.position = position;
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00004B80 File Offset: 0x00002D80
		public static void tpin2()
		{
			bool flag = !Hparty.Inworld();
			if (!flag)
			{
				Vector3 position;
				position..ctor(-3.8299f, 14.242f, 130.0866f);
				WorldGameHacks.GetLocalPlayer().transform.position = position;
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00004BC4 File Offset: 0x00002DC4
		public static void tpin3()
		{
			bool flag = !Hparty.Inworld();
			if (!flag)
			{
				Vector3 position;
				position..ctor(0.7652f, 13.448f, 61.4464f);
				WorldGameHacks.GetLocalPlayer().transform.position = position;
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00004C08 File Offset: 0x00002E08
		public static void tpin4()
		{
			bool flag = !Hparty.Inworld();
			if (!flag)
			{
				Vector3 position;
				position..ctor(-93.2427f, 13.448f, 61.5138f);
				WorldGameHacks.GetLocalPlayer().transform.position = position;
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00004C4C File Offset: 0x00002E4C
		public static void tpin5()
		{
			bool flag = !Hparty.Inworld();
			if (!flag)
			{
				Vector3 position;
				position..ctor(-95.9686f, 13.676f, 201.7702f);
				WorldGameHacks.GetLocalPlayer().transform.position = position;
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00004C90 File Offset: 0x00002E90
		public static void tpin6()
		{
			bool flag = !Hparty.Inworld();
			if (!flag)
			{
				Vector3 position;
				position..ctor(0.0903f, 13.676f, 201.4697f);
				WorldGameHacks.GetLocalPlayer().transform.position = position;
			}
		}

		// Token: 0x04000014 RID: 20
		public static string WORLDID = "wrld_e5c30b56-efa8-42d5-a8d4-a2cca2bf3403";
	}
}
