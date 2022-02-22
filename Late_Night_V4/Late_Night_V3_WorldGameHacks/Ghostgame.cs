using System;

namespace Late_Night_V3_WorldGameHacks
{
	// Token: 0x0200000B RID: 11
	internal class Ghostgame
	{
		// Token: 0x06000082 RID: 130 RVA: 0x00004CE8 File Offset: 0x00002EE8
		public static bool Inworld()
		{
			return RoomManager.Method_Internal_Static_get_String_0().Contains(Ghostgame.WORLDID);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00004D0C File Offset: 0x00002F0C
		public static void killall()
		{
			bool flag = Ghostgame.Inworld();
			if (flag)
			{
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00004D28 File Offset: 0x00002F28
		public static void WinG()
		{
			bool flag = Ghostgame.Inworld();
			if (flag)
			{
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00004D44 File Offset: 0x00002F44
		public static void WinH()
		{
			bool flag = Ghostgame.Inworld();
			if (flag)
			{
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00004D60 File Offset: 0x00002F60
		public static void InfAmo()
		{
			bool flag = Ghostgame.Inworld();
			if (flag)
			{
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00004D7C File Offset: 0x00002F7C
		public static void KeyESP(bool state)
		{
			bool flag = Ghostgame.Inworld();
			if (flag)
			{
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00004D98 File Offset: 0x00002F98
		public static void ClueESP(bool state)
		{
			bool flag = Ghostgame.Inworld();
			if (flag)
			{
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00004DB4 File Offset: 0x00002FB4
		public static void LockerESP(bool state)
		{
			bool flag = Ghostgame.Inworld();
			if (flag)
			{
			}
		}

		// Token: 0x04000015 RID: 21
		public static string WORLDID = "wrld_0ec97c4f-1e84-4a3a-9e3a-fa3075b6c56d";
	}
}
