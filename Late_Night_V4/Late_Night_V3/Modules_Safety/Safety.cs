using System;
using Late_Night_config;
using Late_Night_V2_wrappers;
using UnityEngine;
using VRC.SDKBase;
using XButtonAPI;

namespace Late_Night_V3.Modules_Safety
{
	// Token: 0x02000024 RID: 36
	internal class Safety
	{
		// Token: 0x0600017E RID: 382 RVA: 0x0000EA58 File Offset: 0x0000CC58
		public static void Safety_menu(QMNestedButton Submenu)
		{
			Submenu.AddToggle("Ask to leave on admin join", "Ask to leave on admin join", delegate(bool B)
			{
				Config.Instance.ASKonAdminJoin = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.ASKonAdminJoin);
			Submenu.AddToggle("leave on admin join", "leave on admin join", delegate(bool B)
			{
				Config.Instance.LeaveOnAdminjoin = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.LeaveOnAdminjoin);
			Submenu.AddToggle("Anti-Tp RPC", "Anti-Tp RPC", delegate(bool B)
			{
				Config.Instance.AntiTP = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.AntiTP);
			QMNestedButton qmnestedButton = Submenu.AddMenuPage("Portals", "Portals", "KILL ME IS TO LATE TO BE DOING THIS", false, null);
			qmnestedButton.AddToggle("Ask Portals", "Ask Portals", delegate(bool B)
			{
				Config.Instance.AskPortals = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.AskPortals);
			qmnestedButton.AddButton("Delete portals", "Delete portals", delegate
			{
				Safety.deletallPort();
			}, null);
			qmnestedButton.AddToggle("Auto Delete Portals", "Auto Delete Portals", delegate(bool B)
			{
				Config.Instance.autodeletePortals = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.autodeletePortals);
			QMNestedButton qmnestedButton2 = Submenu.AddMenuPage("Avi Anti", "Avi Anti", "i want to die", false, null);
			qmnestedButton2.AddToggle("Auto Re-load players", "Auto Re-load players", delegate(bool B)
			{
				Config.Instance.Reload_players_on_aply = B;
				Config.Instance.SaveConfig();
				bool reload_players_on_aply = Config.Instance.Reload_players_on_aply;
				if (reload_players_on_aply)
				{
					PlayerWrapper.ReloadAllAvatars();
				}
			}, Config.Instance.Reload_players_on_aply);
			qmnestedButton2.AddButton("Re-Load Players", "Re-Load Players", delegate
			{
				PlayerWrapper.ReloadAllAvatars();
			}, null);
			qmnestedButton2.AddToggle("Anti-spawn Audio", "Anti-spawn Audio", delegate(bool B)
			{
				Config.Instance.Anti_spawn_Audio = B;
				Config.Instance.SaveConfig();
				bool reload_players_on_aply = Config.Instance.Reload_players_on_aply;
				if (reload_players_on_aply)
				{
					PlayerWrapper.ReloadAllAvatars();
				}
			}, Config.Instance.Anti_spawn_Audio);
			qmnestedButton2.AddToggle("Anti-spawn Particles", "Anti-spawn Particles", delegate(bool B)
			{
				Config.Instance.Anti_spawn_Particals = B;
				Config.Instance.SaveConfig();
				bool reload_players_on_aply = Config.Instance.Reload_players_on_aply;
				if (reload_players_on_aply)
				{
					PlayerWrapper.ReloadAllAvatars();
				}
			}, Config.Instance.Anti_spawn_Particals);
			qmnestedButton2.AddToggle("Friend ByPass", "Friend ByPass", delegate(bool B)
			{
				Config.Instance.Firend_bypass = B;
				Config.Instance.SaveConfig();
				bool reload_players_on_aply = Config.Instance.Reload_players_on_aply;
				if (reload_players_on_aply)
				{
					PlayerWrapper.ReloadAllAvatars();
				}
			}, Config.Instance.Firend_bypass);
			qmnestedButton2.AddToggle("Self ByPass", "Self ByPass", delegate(bool B)
			{
				Config.Instance.Self_bypass_Spwan = B;
				Config.Instance.SaveConfig();
				bool reload_players_on_aply = Config.Instance.Reload_players_on_aply;
				if (reload_players_on_aply)
				{
					PlayerWrapper.ReloadAllAvatars();
				}
			}, Config.Instance.Self_bypass_Spwan);
			QMNestedButton qmnestedButton3 = Submenu.AddMenuPage("Event Blocking", "Event Blocking", "i want to die", false, null);
			QMNestedButton qmnestedButton4 = qmnestedButton3.AddMenuPage("Friend Blocking", "Friend Blocking", "yes", false, null);
			QMNestedButton qmnestedButton5 = qmnestedButton3.AddMenuPage("NON-Friend Blocking", "NON-Friend Blocking", "yes", false, null);
			QMNestedButton qmnestedButton6 = Submenu.AddMenuPage("Anti Bad Event", "Event Protection", "i want to not lag", false, null);
			qmnestedButton6.AddToggle("Friends\nEvent\n9 Anti", "Block bad E9", delegate(bool B)
			{
				Config.Instance.E9Antifriends = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.E9Antifriends);
			qmnestedButton6.AddToggle("Non-Friends\nEvent\n9 Anti", "Block bad E9", delegate(bool B)
			{
				Config.Instance.E9AntiNonfriends = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.E9AntiNonfriends);
			qmnestedButton5.AddToggle("Block event 4", "Block event 4", delegate(bool B)
			{
				Config.Instance.Event4blockNonfriends = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.Event4blockNonfriends);
			qmnestedButton4.AddToggle("Block event 4", "Block event 4", delegate(bool B)
			{
				Config.Instance.Event4blockfriend = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.Event4blockfriend);
			qmnestedButton5.AddToggle("Block event 6", "Block event 6", delegate(bool B)
			{
				Config.Instance.Event6blockNonfriends = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.Event6blockNonfriends);
			qmnestedButton4.AddToggle("Block event 6", "Block event 6", delegate(bool B)
			{
				Config.Instance.Event6blockfriend = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.Event6blockfriend);
			qmnestedButton5.AddToggle("Block event 8", "Block event 8", delegate(bool B)
			{
				Config.Instance.Event8blockNonfriends = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.Event8blockNonfriends);
			qmnestedButton4.AddToggle("Block event 8", "Block event 8", delegate(bool B)
			{
				Config.Instance.Event8blockfriend = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.Event8blockfriend);
			qmnestedButton5.AddToggle("Block event 9", "Block event 9", delegate(bool B)
			{
				Config.Instance.Event9blockNonfriends = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.Event9blockNonfriends);
			qmnestedButton4.AddToggle("Block event 9", "Block event 9", delegate(bool B)
			{
				Config.Instance.Event9blockfriend = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.Event9blockfriend);
			qmnestedButton5.AddToggle("Block event 33", "Block event 33", delegate(bool B)
			{
				Config.Instance.Event33blockNonfriends = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.Event33blockNonfriends);
			qmnestedButton4.AddToggle("Block event 33", "Block event 33", delegate(bool B)
			{
				Config.Instance.Event33blockfriend = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.Event33blockfriend);
			qmnestedButton5.AddToggle("Block event 209", "Block event 209", delegate(bool B)
			{
				Config.Instance.Event209blockNonfriends = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.Event209blockNonfriends);
			qmnestedButton4.AddToggle("Block event 209", "Block event 209", delegate(bool B)
			{
				Config.Instance.Event209blockfriend = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.Event209blockfriend);
			qmnestedButton5.AddToggle("Block event 210", "Block event 210", delegate(bool B)
			{
				Config.Instance.Event210blockNonfriends = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.Event210blockNonfriends);
			qmnestedButton4.AddToggle("Block event 210", "Block event 210", delegate(bool B)
			{
				Config.Instance.Event210blockfriend = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.Event210blockfriend);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000F148 File Offset: 0x0000D348
		public static void deletallPort()
		{
			PortalTrigger[] array = Resources.FindObjectsOfTypeAll<PortalTrigger>();
			foreach (PortalTrigger portalTrigger in array)
			{
				bool flag = portalTrigger.gameObject.activeInHierarchy && !(portalTrigger.gameObject.GetComponentInParent<VRC_PortalMarker>() != null);
				if (flag)
				{
					Object.Destroy(portalTrigger.gameObject);
				}
			}
		}
	}
}
