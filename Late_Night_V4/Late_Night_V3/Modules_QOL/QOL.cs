using System;
using DayClientML2.Utility.Extensions;
using External_Libraries.popups;
using Late_Night_config;
using Late_Night_V2_wrappers;
using Late_Night_V3_colnsole;
using Late_Night_V3_MediaControl;
using UnityEngine;
using XButtonAPI;

namespace Late_Night_V3.Modules_QOL
{
	// Token: 0x02000025 RID: 37
	internal class QOL
	{
		// Token: 0x06000181 RID: 385 RVA: 0x0000F1BC File Offset: 0x0000D3BC
		public static void QOL_menu(QMNestedButton Submenu, QMNestedButton Submenu2)
		{
			QMNestedButton qmnestedButton = Submenu.AddMenuPage("Gesture locking", "Gesture locking", "Gesture Locking", false, null);
			qmnestedButton.AddToggle("Gesture lock left", "Gesture lock left", delegate(bool B)
			{
				Config.Instance.leftHandSetting = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.leftHandSetting);
			qmnestedButton.AddToggle("Gesture lock right", "Gesture lock right", delegate(bool B)
			{
				Config.Instance.rightHandSetting = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.rightHandSetting);
			Submenu.AddToggle("optifine (shift + T)", "optifine (shift + T)", delegate(bool B)
			{
				Config.Instance.Ctozoom = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.Ctozoom);
			Submenu.AddToggle("Comfy Menus", "Comfy Menus", delegate(bool B)
			{
				Config.Instance.ComfyMode = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.ComfyMode);
			Submenu.AddToggle("FPS unlock", "Unlock your fps", delegate(bool B)
			{
				Config.Instance.FPSunlock = B;
				Config.Instance.SaveConfig();
				Application.targetFrameRate = (B ? 0 : 90);
			}, Config.Instance.FPSunlock);
			Application.targetFrameRate = (Config.Instance.FPSunlock ? 0 : 90);
			Submenu2.AddToggle("Info List", "Info List toggle", delegate(bool B)
			{
				Config.Instance.InfoList = B;
				Config.Instance.SaveConfig();
				Late_Night.ListText.menuTitle.SetActive(Config.Instance.InfoList);
			}, Config.Instance.InfoList);
			Submenu2.AddToggle("Clock", "Clock toggle", delegate(bool B)
			{
				Config.Instance.Clock = B;
				Config.Instance.SaveConfig();
				Late_Night.clock.menuTitle.SetActive(Config.Instance.Clock);
			}, Config.Instance.Clock);
			Submenu2.AddToggle("LNC info", "Info toggle", delegate(bool B)
			{
				Config.Instance.LNCinfo = B;
				Config.Instance.SaveConfig();
				Late_Night.LNCINFOVS.menuTitle.SetActive(Config.Instance.LNCinfo);
			}, Config.Instance.LNCinfo);
			Submenu2.AddToggle("Fav List", "Fav List", delegate(bool B)
			{
				Config.Instance.FavList = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.FavList);
			Submenu2.AddToggle("Search List", "Search List", delegate(bool B)
			{
				Config.Instance.SearchList = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.SearchList);
			Submenu2.AddToggle("Better NamePlates", "Better NamePlates", delegate(bool B)
			{
				Config.Instance.BetterNamePlate = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.BetterNamePlate);
			QMNestedButton qmnestedButton2 = Submenu2.AddMenuPage("Trust rank coloring", "Trust rank coloring", "Trust rank coloring", false, null);
			qmnestedButton2.AddButton("Set Trusted", "Set color for rank", delegate
			{
				Popups.PopupCall("Enter Hex Code", "Enter", "Hex Code", false, delegate(string text)
				{
					bool flag = string.IsNullOrEmpty(text) || !text.StartsWith("#");
					if (flag)
					{
						LNCcolnsole.ERROR("Not a Hex Code", true, ConsoleColor.Red);
					}
					else
					{
						Config.Instance.Trusted = text;
						Config.Instance.SaveConfig();
						PlayerWrapper.UpdateESPcolor();
					}
				}, null);
			}, null);
			qmnestedButton2.AddButton("Set known", "Set color for rank", delegate
			{
				Popups.PopupCall("Enter Hex Code", "Enter", "Hex Code", false, delegate(string text)
				{
					bool flag = string.IsNullOrEmpty(text) || !text.StartsWith("#");
					if (flag)
					{
						LNCcolnsole.ERROR("Not a Hex Code", true, ConsoleColor.Red);
					}
					else
					{
						Config.Instance.known = text;
						Config.Instance.SaveConfig();
						PlayerWrapper.UpdateESPcolor();
					}
				}, null);
			}, null);
			qmnestedButton2.AddButton("Set user", "Set color for rank", delegate
			{
				Popups.PopupCall("Enter Hex Code", "Enter", "Hex Code", false, delegate(string text)
				{
					bool flag = string.IsNullOrEmpty(text) || !text.StartsWith("#");
					if (flag)
					{
						LNCcolnsole.ERROR("Not a Hex Code", true, ConsoleColor.Red);
					}
					else
					{
						Config.Instance.user = text;
						Config.Instance.SaveConfig();
						PlayerWrapper.UpdateESPcolor();
					}
				}, null);
			}, null);
			qmnestedButton2.AddButton("Set new user", "Set color for rank", delegate
			{
				Popups.PopupCall("Enter Hex Code", "Enter", "Hex Code", false, delegate(string text)
				{
					bool flag = string.IsNullOrEmpty(text) || !text.StartsWith("#");
					if (flag)
					{
						LNCcolnsole.ERROR("Not a Hex Code", true, ConsoleColor.Red);
					}
					else
					{
						Config.Instance.Newuser = text;
						Config.Instance.SaveConfig();
						PlayerWrapper.UpdateESPcolor();
					}
				}, null);
			}, null);
			qmnestedButton2.AddButton("Set vistor", "Set color for rank", delegate
			{
				Popups.PopupCall("Enter Hex Code", "Enter", "Hex Code", false, delegate(string text)
				{
					bool flag = string.IsNullOrEmpty(text) || !text.StartsWith("#");
					if (flag)
					{
						LNCcolnsole.ERROR("Not a Hex Code", true, ConsoleColor.Red);
					}
					else
					{
						Config.Instance.vistor = text;
						Config.Instance.SaveConfig();
						PlayerWrapper.UpdateESPcolor();
					}
				}, null);
			}, null);
			qmnestedButton2.AddButton("Set Master Color", "Set color for master", delegate
			{
				Popups.PopupCall("Enter Hex Code", "Enter", "Hex Code", false, delegate(string text)
				{
					bool flag = string.IsNullOrEmpty(text) || !text.StartsWith("#");
					if (flag)
					{
						LNCcolnsole.ERROR("Not a Hex Code", true, ConsoleColor.Red);
					}
					else
					{
						Config.Instance.Master = text;
						Config.Instance.SaveConfig();
					}
				}, null);
			}, null);
			qmnestedButton2.AddButton("Set speech highlight", "Set color for rank", delegate
			{
				Popups.PopupCall("Enter Hex Code", "Enter", "Hex Code", false, delegate(string text)
				{
					bool flag = string.IsNullOrEmpty(text) || !text.StartsWith("#");
					if (flag)
					{
						LNCcolnsole.ERROR("Not a Hex Code", true, ConsoleColor.Red);
					}
					else
					{
						Config.Instance.SpeckingBubble = text;
						Config.Instance.SaveConfig();
					}
				}, null);
			}, null);
			qmnestedButton2.AddButton("Reset all colors", "Reset all colors", delegate
			{
				Utils.VRCUiPopupManager.Alert("Reset all colors?", "Are you sure you want to reset the colors", "Yes", delegate()
				{
					Config.Instance.Friend = "#ffd000";
					Config.Instance.Trusted = "#9000ff";
					Config.Instance.known = "#ff6200";
					Config.Instance.user = "#02e020";
					Config.Instance.Newuser = "#2977ff";
					Config.Instance.vistor = "#848587";
					Config.Instance.SpeckingBubble = "#000000";
					Config.Instance.Master = "#00e5ff";
					Config.Instance.SaveConfig();
					PlayerWrapper.UpdateESPcolor();
					Utils.VRCUiPopupManager.HideCurrentPopUp();
				}, "No", delegate()
				{
					Utils.VRCUiPopupManager.HideCurrentPopUp();
				}, null);
			}, null);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000F618 File Offset: 0x0000D818
		public static void Media_menu(QMNestedButton Submenu)
		{
			Submenu.AddButton("<<< Back", "Media", new Action(MediaControl.PrevTrack), null);
			Submenu.AddButton("Play/Pause", "Media", new Action(MediaControl.PlayPause), null);
			Submenu.AddButton("Next >>>", "Media", new Action(MediaControl.NextTrack), null);
			QOL.meadiatoggle = Submenu.AddToggle("Quick Short Cuts", "Quick Short Cuts", delegate(bool B)
			{
				Config.Instance.QuickMediaOrMove = B;
				Config.Instance.SaveConfig();
				Late_Night.next.GameObject.SetActive(Config.Instance.QuickMediaOrMove);
				Late_Night.Play.GameObject.SetActive(Config.Instance.QuickMediaOrMove);
				Late_Night.Back.GameObject.SetActive(Config.Instance.QuickMediaOrMove);
				Late_Night.fly.GameObject.SetActive(!Config.Instance.QuickMediaOrMove);
				Late_Night.speedbut.GameObject.SetActive(!Config.Instance.QuickMediaOrMove);
				Late_Night.Jump.GameObject.SetActive(!Config.Instance.QuickMediaOrMove);
			}, Config.Instance.QuickMediaOrMove);
			Submenu.AddButton("Vol +", "Media", new Action(MediaControl.VolumeUp), null);
			Submenu.AddButton("Mute Vol", "Media", new Action(MediaControl.VolumeMute), null);
			Submenu.AddButton("Vol -", "Media", new Action(MediaControl.VolumeDown), null);
		}

		// Token: 0x040000C1 RID: 193
		public static QMToggleButton meadiatoggle;
	}
}
