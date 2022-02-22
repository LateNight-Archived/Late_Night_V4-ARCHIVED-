using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DayClientML2.Utility.Extensions;
using Late_Night_config;
using Late_Night_V2_popshit;
using Late_Night_V2_wrappers;
using Late_Night_V3_colnsole;
using Late_Night_V3_GlobalDynamicBones;
using UnityEngine;
using VRC;
using VRC.Core;
using XButtonAPI;

namespace Late_Night_V3.Modules_Player
{
	// Token: 0x02000026 RID: 38
	internal class Player
	{
		// Token: 0x06000184 RID: 388 RVA: 0x0000F724 File Offset: 0x0000D924
		public static void Player_menu(QMNestedButton Submenu)
		{
			QMNestedButton qmnestedButton = Submenu.AddMenuPage("Avi utils", "Avi utils", "Avi utils", false, null);
			qmnestedButton.AddButton("Avi By ID", "Avi id", delegate
			{
				bool flag = popshit.GetClipboard().StartsWith("avtr");
				if (flag)
				{
					popshit.avatarbyid(popshit.GetClipboard());
				}
				else
				{
					LNCcolnsole.ERROR("Text on clipboard is not a avi ID", true, ConsoleColor.Red);
				}
			}, null);
			qmnestedButton.AddButton("self avatar id to clipboard", "avi id", delegate
			{
				popshit.SetClipboard(PlayerWrapper.GetCurrentPlayer().Method_Public_get_ApiAvatar_0().id);
				LNCcolnsole.Log("Your avi id is : " + PlayerWrapper.GetCurrentPlayer().Method_Public_get_ApiAvatar_0().id, false, ConsoleColor.Cyan);
			}, null);
			qmnestedButton.AddToggle("Auto Force Lewd", "", delegate(bool B)
			{
				Config.Instance.autoforcelewd = B;
				Config.Instance.SaveConfig();
				PlayerWrapper.ReloadAllAvatars();
			}, Config.Instance.autoforcelewd);
			qmnestedButton.AddToggle("Local Avatar Log", "Local AvatarLog", delegate(bool B)
			{
				if (B)
				{
					Config.Instance.LocalAvatarLog = true;
					Config.Instance.SaveConfig();
				}
				else
				{
					Config.Instance.LocalAvatarLog = false;
					Config.Instance.SaveConfig();
				}
			}, Config.Instance.LocalAvatarLog);
			Submenu.AddToggle("ESP", "See player through walls", delegate(bool B)
			{
				Config.Instance.ESPPlayer = B;
				Config.Instance.SaveConfig();
				PlayerWrapper.ToggleESP(Config.Instance.ESPPlayer);
			}, Config.Instance.ESPPlayer);
			Submenu.AddToggle("Join Notif", "Join Notif", delegate(bool B)
			{
				if (B)
				{
					Config.Instance.JoinNotif = true;
					Config.Instance.SaveConfig();
				}
				else
				{
					Config.Instance.JoinNotif = false;
					Config.Instance.SaveConfig();
				}
			}, Config.Instance.JoinNotif);
			Submenu.AddToggle("Friends only", "Friends only", delegate(bool B)
			{
				if (B)
				{
					Config.Instance.JoinOnlyFriend = true;
					Config.Instance.SaveConfig();
				}
				else
				{
					Config.Instance.JoinOnlyFriend = false;
					Config.Instance.SaveConfig();
				}
			}, Config.Instance.JoinOnlyFriend);
			QMNestedButton qmnestedButton2 = Submenu.AddMenuPage("Global Dynamic bones", "Global Dynamic bones", "Global Dynamic bones", false, null);
			qmnestedButton2.AddToggle("Global Bones", "", delegate(bool B)
			{
				if (B)
				{
					Config.Instance.GB_Enabled = true;
					Config.Instance.SaveConfig();
					Player.QueuePlayerActions(delegate(Player plr)
					{
						bool flag = Config.Instance.GB_Friends && (plr.GetAPIUser().GetIsFriend() || plr.GetAPIUser().id == APIUser.CurrentUser.id);
						if (flag)
						{
							plr.ReloadAvatar();
						}
						bool flag2 = !Config.Instance.GB_Friends;
						if (flag2)
						{
							plr.ReloadAvatar();
						}
					}, 0.1f).Start();
				}
				else
				{
					Config.Instance.GB_Enabled = false;
					Config.Instance.SaveConfig();
					Utils.PlayerManager.AllPlayers().ForEach(delegate(Player plr)
					{
						bool flag = Config.Instance.GB_Friends && (plr.GetAPIUser().GetIsFriend() || plr.GetAPIUser().id == APIUser.CurrentUser.id);
						if (flag)
						{
							GlobalDynamicBones.ProcessDynamicBones(plr.GetAvatar(), plr.GetAPIUser());
						}
						bool flag2 = !Config.Instance.GB_Friends;
						if (flag2)
						{
							GlobalDynamicBones.ProcessDynamicBones(plr.GetAvatar(), plr.GetAPIUser());
						}
					});
				}
			}, Config.Instance.GB_Enabled);
			qmnestedButton2.AddToggle("Friends", "", delegate(bool B)
			{
				Config.Instance.GB_Friends = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.GB_Friends);
			qmnestedButton2.AddToggle("Head", "", delegate(bool B)
			{
				Config.Instance.GB_HeadBones = B;
				Config.Instance.SaveConfig();
				PlayerWrapper.ReloadAllAvatars();
			}, Config.Instance.GB_HeadBones);
			qmnestedButton2.AddToggle("Chest", "", delegate(bool B)
			{
				Config.Instance.GB_ChestBones = B;
				Config.Instance.SaveConfig();
				PlayerWrapper.ReloadAllAvatars();
			}, Config.Instance.GB_ChestBones);
			qmnestedButton2.AddToggle("Hip", "", delegate(bool B)
			{
				Config.Instance.GB_HipBones = B;
				Config.Instance.SaveConfig();
				PlayerWrapper.ReloadAllAvatars();
			}, Config.Instance.GB_HipBones);
			qmnestedButton2.AddToggle("Hand", "", delegate(bool B)
			{
				Config.Instance.GB_HandColliders = B;
				Config.Instance.SaveConfig();
				PlayerWrapper.ReloadAllAvatars();
			}, Config.Instance.GB_HandColliders);
			qmnestedButton2.AddToggle("Feet", "", delegate(bool B)
			{
				Config.Instance.GB_FeetColliders = B;
				Config.Instance.SaveConfig();
				PlayerWrapper.ReloadAllAvatars();
			}, Config.Instance.GB_FeetColliders);
			QMNestedButton qmnestedButton3 = Submenu.AddMenuPage("Auto Status Change", "Auto Status Change", "Auto Status Change", false, null);
			qmnestedButton3.AddButton("Add Status", "Add Status", delegate
			{
				PlayerWrapper.Addstsus();
			}, null);
			qmnestedButton3.AddButton("Remove Status", "Remove Status", delegate
			{
				PlayerWrapper.Removestsus();
			}, null);
			qmnestedButton3.AddButton("Reset", "Remove all and use default Status", delegate
			{
				PlayerWrapper.Rest();
			}, null);
			qmnestedButton3.AddToggle("Random Status", "this will pick a random status from config", delegate(bool B)
			{
				Config.Instance.statusRandom = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.statusRandom);
			qmnestedButton3.AddToggle("Sequential Status", "this will pick the next status from config", delegate(bool B)
			{
				Config.Instance.statusNext = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.statusNext);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0000FB9B File Offset: 0x0000DD9B
		public static IEnumerator QueuePlayerActions(Action<Player> OnPlayerAction, float WaitBetweenPlayer)
		{
			List<Player> AllPlayers = Utils.PlayerManager.AllPlayers();
			foreach (Player player2 in from player in AllPlayers
			where player != null
			select player)
			{
				if (OnPlayerAction != null)
				{
					OnPlayerAction(player2);
				}
				yield return new WaitForSeconds(WaitBetweenPlayer);
				player2 = null;
			}
			IEnumerator<Player> enumerator = null;
			yield return null;
			yield break;
			yield break;
		}
	}
}
