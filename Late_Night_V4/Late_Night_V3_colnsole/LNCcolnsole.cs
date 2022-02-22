using System;
using DayClientML2.Utility.Extensions;

namespace Late_Night_V3_colnsole
{
	// Token: 0x0200006C RID: 108
	internal class LNCcolnsole
	{
		// Token: 0x06000467 RID: 1127 RVA: 0x0001DE84 File Offset: 0x0001C084
		public static void Log(string Msg, bool toHud = false, ConsoleColor A = ConsoleColor.White)
		{
			string value = LNCcolnsole.Time() + LNCcolnsole.Name + Msg;
			Console.ForegroundColor = A;
			Console.WriteLine(value);
			if (toHud)
			{
				VRCUiManager.Method_Internal_Static_get_VRCUiManager_PDM_0().QueHudMessage(LNCcolnsole.ColorHudText(Msg, A));
			}
			Console.ResetColor();
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x0001DED0 File Offset: 0x0001C0D0
		public static void WARN(string Msg, bool toHud = false, ConsoleColor A = ConsoleColor.Yellow)
		{
			string value = LNCcolnsole.Time() + LNCcolnsole.Name + "[WARNING] " + Msg;
			string msg = "[WARNING] " + Msg;
			Console.ForegroundColor = A;
			Console.WriteLine(value);
			if (toHud)
			{
				VRCUiManager.Method_Internal_Static_get_VRCUiManager_PDM_0().QueHudMessage(LNCcolnsole.ColorHudText(msg, A));
			}
			Console.ResetColor();
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0001DF2C File Offset: 0x0001C12C
		public static void ERROR(string Msg, bool toHud = false, ConsoleColor A = ConsoleColor.Red)
		{
			string value = LNCcolnsole.Time() + LNCcolnsole.Name + "[ERROR] " + Msg;
			string msg = "[ERROR] " + Msg;
			Console.ForegroundColor = A;
			Console.WriteLine(value);
			if (toHud)
			{
				VRCUiManager.Method_Internal_Static_get_VRCUiManager_PDM_0().QueHudMessage(LNCcolnsole.ColorHudText(msg, A));
			}
			Console.ResetColor();
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0001DF88 File Offset: 0x0001C188
		public static void Patches(string Msg, bool toHud = false, ConsoleColor A = ConsoleColor.DarkMagenta)
		{
			string value = LNCcolnsole.Time() + LNCcolnsole.Name + "[Patches] " + Msg;
			string msg = "[Patches] " + Msg;
			Console.ForegroundColor = A;
			Console.WriteLine(value);
			if (toHud)
			{
				VRCUiManager.Method_Internal_Static_get_VRCUiManager_PDM_0().QueHudMessage(LNCcolnsole.ColorHudText(msg, A));
			}
			Console.ResetColor();
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0001DFE4 File Offset: 0x0001C1E4
		private static string ColorHudText(string Msg, ConsoleColor A = ConsoleColor.White)
		{
			if (!true)
			{
			}
			string result;
			switch (A)
			{
			case ConsoleColor.Black:
				result = "<color=#000000>" + Msg + "</color>";
				break;
			case ConsoleColor.DarkBlue:
				result = "<color=#0b0785>" + Msg + "</color>";
				break;
			case ConsoleColor.DarkGreen:
				result = "<color=#00800b>" + Msg + "</color>";
				break;
			case ConsoleColor.DarkCyan:
				result = "<color=#00a39b>" + Msg + "</color>";
				break;
			case ConsoleColor.DarkRed:
				result = "<color=#8a0000>" + Msg + "</color>";
				break;
			case ConsoleColor.DarkMagenta:
				result = "<color=#8a007c>" + Msg + "</color>";
				break;
			case ConsoleColor.DarkYellow:
				result = "<color=#8a8a00>" + Msg + "</color>";
				break;
			case ConsoleColor.Gray:
				result = "<color=##b5b5b5>" + Msg + "</color>";
				break;
			case ConsoleColor.DarkGray:
				result = "<color=#787878>" + Msg + "</color>";
				break;
			case ConsoleColor.Blue:
				result = "<color=#0400ff>" + Msg + "</color>";
				break;
			case ConsoleColor.Green:
				result = "<color=#11ff00>" + Msg + "</color>";
				break;
			case ConsoleColor.Cyan:
				result = "<color=#00ffea>" + Msg + "</color>";
				break;
			case ConsoleColor.Red:
				result = "<color=#ff0800>" + Msg + "</color>";
				break;
			case ConsoleColor.Magenta:
				result = "<color=#ff00b3>" + Msg + "</color>";
				break;
			case ConsoleColor.Yellow:
				result = "<color=#fbff00>" + Msg + "</color>";
				break;
			default:
				result = "<color=#ffffff>" + Msg + "</color>";
				break;
			}
			if (!true)
			{
			}
			return result;
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x0001E194 File Offset: 0x0001C394
		private static string Time()
		{
			return "[" + DateTime.Now.ToString("h:mm:ss tt") + "] ";
		}

		// Token: 0x040001F0 RID: 496
		public static string Name = "[Late Night] ";
	}
}
