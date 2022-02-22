using System;
using UnityEngine;
using VRCSDK2;

namespace Late_Night_V3_WorldGameHacks
{
	// Token: 0x0200000C RID: 12
	internal class MIdNight
	{
		// Token: 0x0600008C RID: 140 RVA: 0x00004DE4 File Offset: 0x00002FE4
		public static bool Inworld()
		{
			return RoomManager.Method_Internal_Static_get_String_0().Contains(MIdNight.WORLDID);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00004E08 File Offset: 0x00003008
		public static void DisableUpstairs()
		{
			bool flag = !MIdNight.Inworld();
			if (!flag)
			{
				GameObject gameObject = GameObject.Find("Midnight Rooftop/Logic/Upstairs Toggles");
				gameObject.GetComponent<VRC_Trigger>().ExecuteCustomTrigger("DisableUpstairs");
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00004E40 File Offset: 0x00003040
		public static void DisableDownstairs()
		{
			bool flag = !MIdNight.Inworld();
			if (!flag)
			{
				GameObject gameObject = GameObject.Find("Midnight Rooftop/Logic/Downstairs Toggles");
				gameObject.GetComponent<VRC_Trigger>().ExecuteCustomTrigger("DisableDownstairs");
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00004E78 File Offset: 0x00003078
		public static void EnableUpstairs()
		{
			bool flag = !MIdNight.Inworld();
			if (!flag)
			{
				GameObject gameObject = GameObject.Find("Midnight Rooftop/Logic/Upstairs Toggles");
				gameObject.GetComponent<VRC_Trigger>().ExecuteCustomTrigger("EnableUpstairs");
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00004EB0 File Offset: 0x000030B0
		public static void EnableDownstairs()
		{
			bool flag = !MIdNight.Inworld();
			if (!flag)
			{
				GameObject gameObject = GameObject.Find("Midnight Rooftop/Logic/Downstairs Toggles");
				gameObject.GetComponent<VRC_Trigger>().ExecuteCustomTrigger("EnableDownstairs");
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00004EE8 File Offset: 0x000030E8
		public static void KEYFLOOROFF()
		{
			bool flag = !MIdNight.KeyOffFloor;
			if (!flag)
			{
				MIdNight.KeepTime += Time.deltaTime;
				bool flag2 = MIdNight.KeepTime <= 1f;
				if (!flag2)
				{
					MIdNight.DisableUpstairs();
					MIdNight.DisableDownstairs();
					MIdNight.KeepTime = 0f;
				}
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00004F40 File Offset: 0x00003140
		public static void ShakeMode()
		{
			bool flag = !MIdNight.Shake;
			if (!flag)
			{
				MIdNight.ShakeTime += Time.deltaTime;
				bool flag2 = MIdNight.ShakeTime <= 0.15f;
				if (!flag2)
				{
					bool onoff = MIdNight.ONoff;
					if (onoff)
					{
						MIdNight.DisableUpstairs();
						MIdNight.DisableDownstairs();
						MIdNight.ONoff = !MIdNight.ONoff;
					}
					else
					{
						MIdNight.EnableUpstairs();
						MIdNight.EnableDownstairs();
						MIdNight.ONoff = !MIdNight.ONoff;
					}
					MIdNight.ShakeTime = 0f;
				}
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00004FCC File Offset: 0x000031CC
		public static void UpdateThis()
		{
			MIdNight.KEYFLOOROFF();
			MIdNight.ShakeMode();
		}

		// Token: 0x04000016 RID: 22
		public static string WORLDID = "wrld_d29bb0d0-d268-42dc-8365-926f9d485505";

		// Token: 0x04000017 RID: 23
		public static float KeepTime;

		// Token: 0x04000018 RID: 24
		public static bool KeyOffFloor;

		// Token: 0x04000019 RID: 25
		public static float ShakeTime;

		// Token: 0x0400001A RID: 26
		public static bool Shake;

		// Token: 0x0400001B RID: 27
		public static bool ONoff;
	}
}
