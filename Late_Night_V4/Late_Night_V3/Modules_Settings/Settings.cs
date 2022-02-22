using System;
using System.Diagnostics;
using Late_Night_config;
using Late_Night_V2_wrappers;
using Late_Night_V3_colnsole;
using XButtonAPI;

namespace Late_Night_V3.Modules_Settings
{
	// Token: 0x02000023 RID: 35
	internal class Settings
	{
		// Token: 0x0600017C RID: 380 RVA: 0x0000E7C0 File Offset: 0x0000C9C0
		public static void Settings_menu(QMNestedButton Submenu)
		{
			Submenu.AddButton("Quit", "Quit", delegate
			{
				Wrapper.Bruhmoment();
			}, null);
			Submenu.AddButton("Quick Restart", "Quick Restart", delegate
			{
				Process.Start("vrchat.exe", Environment.CommandLine.ToString());
				Wrapper.Bruhmoment();
			}, null);
			Submenu.AddButton("Clear M.L.C.", "Clear M.L.C.", delegate
			{
				Console.Clear();
				LNCcolnsole.Log("============================ Late_Night_V4 ===========================", false, ConsoleColor.Cyan);
			}, null);
			Submenu.AddToggle("Clear M.L.C. on join", "Clear M.L.C. on join", delegate(bool B)
			{
				Config.Instance.ConsoleCleaner = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.ConsoleCleaner);
			QMNestedButton qmnestedButton = Submenu.AddMenuPage("Key Info", "Key Info", "what do what", false, null);
			qmnestedButton.AddToggle("Keybinding", "Keybinding", delegate(bool B)
			{
				Config.Instance.keysbinding = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.keysbinding);
			qmnestedButton.AddToggle("Restart Key (END)", "Restart Key (END)", delegate(bool B)
			{
				Config.Instance.Restartkey = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.Restartkey);
			qmnestedButton.AddButton("SHIFT +(THE KEY)TO USE THEM", "SHIFT +(THE KEY)TO USE THEM", delegate
			{
				LNCcolnsole.Log("SHIFT +(THE KEY)TO USE THEM", false, ConsoleColor.White);
			}, null);
			qmnestedButton.AddButton("G = NoClip", "G = NoClip", delegate
			{
				LNCcolnsole.Log("G = NoClip", false, ConsoleColor.White);
			}, null);
			qmnestedButton.AddButton("Y = Jump Power", "Y = Jump Power", delegate
			{
				LNCcolnsole.Log("Y = Jump Power", false, ConsoleColor.White);
			}, null);
			qmnestedButton.AddButton("B = +Speed", "B = +Speed", delegate
			{
				LNCcolnsole.Log("B = +Speed", false, ConsoleColor.White);
			}, null);
			qmnestedButton.AddButton("N = Player ESP", "N = Player ESP", delegate
			{
				LNCcolnsole.Log("N = Player ESP", false, ConsoleColor.White);
			}, null);
			qmnestedButton.AddButton("Middle Mouse = Ghost Mode", "Middle Mouse = Ghost Mode", delegate
			{
				LNCcolnsole.Log("Middle Mouse = Ghost Mode", false, ConsoleColor.White);
			}, null);
		}
	}
}
