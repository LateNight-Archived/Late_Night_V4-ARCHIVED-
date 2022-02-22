using System;
using System.Collections.Generic;
using DayClientML2.Utility;
using DayClientML2.Utility.Extensions;
using External_Libraries.popups;
using Late_Night_V2_Playerlist;
using Late_Night_V2_popshit;
using Late_Night_V2_wrappers;
using Late_Night_V3.Modules_Funny;
using Late_Night_V3.Modules_UserUtils;
using Late_Night_V3.Modules_Wolds;
using Late_Night_V3_AviFave;
using Late_Night_V3_colnsole;
using Late_Night_V3_Config_AVI_FAVE;
using Late_Night_V3_Config_Seen_AVIS;
using MelonLoader;
using UnityEngine;
using VRC;
using VRC.Core;
using VRC.UI;

namespace Late_Night_V3.Modules_BugMenuShit
{
	// Token: 0x02000029 RID: 41
	internal class BugMenuShit
	{
		// Token: 0x06000194 RID: 404 RVA: 0x000115B0 File Offset: 0x0000F7B0
		internal static void Menu_shit_for_rori()
		{
			MenuButton menuButton = new MenuButton(AviFave.Avis.UiVRCList.expandButton.transform, MenuButtonType.AvatarFavButton, "Fav Avi", 750f, 0f, delegate()
			{
				ApiAvatar field_Internal_ApiAvatar_ = BugMenuShit.MenuPed.GetComponent<SimpleAvatarPedestal>().field_Internal_ApiAvatar_0;
				AviFave.FaveAvi(field_Internal_ApiAvatar_, 1);
				Config_AVI_FAVE.Instance.SaveConfig_AVIS_FAVE();
			}, -150f, -10f);
			MenuButton menuButton2 = new MenuButton(AviFave.Avis.UiVRCList.expandButton.transform, MenuButtonType.AvatarFavButton, "Un-Fav Avi", 930f, 0f, delegate()
			{
				ApiAvatar Avi = BugMenuShit.MenuPed.GetComponent<SimpleAvatarPedestal>().field_Internal_ApiAvatar_0;
				Utils.VRCUiPopupManager.Alert("UnFavorite this Avi?", "Are you sure you want to do this", "Yes", delegate()
				{
					AviFave.UnFaveAvi(Avi);
					Config_AVI_FAVE.Instance.SaveConfig_AVIS_FAVE();
					Utils.VRCUiPopupManager.HideCurrentPopUp();
				}, "No", delegate()
				{
					Utils.VRCUiPopupManager.HideCurrentPopUp();
				}, null);
			}, -150f, -10f);
			MenuButton menuButton3 = new MenuButton(AviFave.Avis.UiVRCList.expandButton.transform, MenuButtonType.AvatarFavButton, "Load List", 570f, 0f, new Action(AviFave.showList), -150f, -10f);
			MenuButton menuButton4 = new MenuButton(AviFave.SEENAvis.UiVRCList.expandButton.transform, MenuButtonType.AvatarFavButton, "Clear ", 930f, 0f, delegate()
			{
				Utils.VRCUiPopupManager.Alert("Clear Recently seen?", "Are you sure you want to do this", "Yes", delegate()
				{
					AviFave.ClearSEENLIST();
					Config_Seen_AVIS.Instance.SaveConfig_AVIS_SEEN();
					Utils.VRCUiPopupManager.HideCurrentPopUp();
				}, "No", delegate()
				{
					Utils.VRCUiPopupManager.HideCurrentPopUp();
				}, null);
			}, -150f, -10f);
			MenuButton searchbut = new MenuButton(AviFave.AviSearchlist.UiVRCList.expandButton.transform, MenuButtonType.AvatarFavButton, "Search", 930f, 0f, delegate()
			{
				Popups.PopupCall("Search", "Enter", "Search", false, new Action<string>(AviFave.REEEEEEEEEEE), null);
			}, -150f, -10f);
			MenuButton calearbut = new MenuButton(AviFave.AviSearchlist.UiVRCList.expandButton.transform, MenuButtonType.AvatarFavButton, "Clear", 750f, 0f, delegate()
			{
				Utils.VRCUiPopupManager.Alert("Clear Search?", "Are you sure you want to do this", "Yes", delegate()
				{
					AviFave.SearchClaer();
					Utils.VRCUiPopupManager.HideCurrentPopUp();
				}, "No", delegate()
				{
					Utils.VRCUiPopupManager.HideCurrentPopUp();
				}, null);
			}, -150f, -10f);
			MenuButton name = new MenuButton(AviFave.AviSearchlist.UiVRCList.expandButton.transform, MenuButtonType.AvatarFavButton, "By Name", 770f, 0f, delegate()
			{
			}, -170f, -10f);
			name.SetAction(delegate
			{
				AviFave.ByNameOrAuther = !AviFave.ByNameOrAuther;
				bool byNameOrAuther = AviFave.ByNameOrAuther;
				if (byNameOrAuther)
				{
					name.SetText("By Name");
					AviFave.ByNameOrAuther = false;
				}
				else
				{
					name.SetText("By Author");
					AviFave.ByNameOrAuther = true;
				}
			});
			MenuButton ReLeaseType = new MenuButton(AviFave.AviSearchlist.UiVRCList.expandButton.transform, MenuButtonType.AvatarFavButton, "Public", 940f, 0f, delegate()
			{
			}, -170f, -10f);
			ReLeaseType.SetAction(delegate
			{
				AviFave.PublicOrPrivate = !AviFave.PublicOrPrivate;
				bool publicOrPrivate = AviFave.PublicOrPrivate;
				if (publicOrPrivate)
				{
					ReLeaseType.SetText("Public");
					AviFave.PublicOrPrivate = false;
				}
				else
				{
					ReLeaseType.SetText("Private");
					AviFave.PublicOrPrivate = true;
				}
			});
			name.Button.gameObject.SetActive(false);
			ReLeaseType.Button.gameObject.SetActive(false);
			bool FunctionsActive = true;
			MenuButton ToggleFunctions = new MenuButton(AviFave.AviSearchlist.UiVRCList.expandButton.transform, MenuButtonType.AvatarFavButton, "Options", 570f, 0f, delegate()
			{
			}, -150f, -10f);
			ToggleFunctions.SetAction(delegate
			{
				FunctionsActive = !FunctionsActive;
				bool functionsActive = FunctionsActive;
				bool flag2 = functionsActive;
				if (flag2)
				{
					ToggleFunctions.SetSize(20f, 0f);
					ToggleFunctions.SetText("Options");
					searchbut.Button.gameObject.SetActive(true);
					calearbut.Button.gameObject.SetActive(true);
					name.Button.gameObject.SetActive(false);
					ReLeaseType.Button.gameObject.SetActive(false);
				}
				else
				{
					ToggleFunctions.SetSize(-20f, 0f);
					ToggleFunctions.SetText("X");
					searchbut.Button.gameObject.SetActive(false);
					calearbut.Button.gameObject.SetActive(false);
					name.Button.gameObject.SetActive(true);
					ReLeaseType.Button.gameObject.SetActive(true);
				}
			});
			MenuButton menuButton5 = new MenuButton(MenuType.UserInfo, MenuButtonType.PlaylistButton, "Quick Inv", 1605f, -791f, new Action(NotificationManagerExtension.SendInviteEZ));
			MenuButton menuButton6 = new MenuButton(MenuType.UserInfo, MenuButtonType.PlaylistButton, "Quick Re-quest", 1605f, -710f, new Action(NotificationManagerExtension.SendRequestEZ));
			MenuButton menuButton7 = new MenuButton(MenuType.UserInfo, MenuButtonType.PlaylistButton, "Portal to", 1605f, -550f, delegate()
			{
				string location_k__BackingField = BugMenuShit.GetId.GetComponent<PageUserInfo>().field_Private_APIUser_0._location_k__BackingField;
				bool flag2 = location_k__BackingField.StartsWith("wrld");
				if (flag2)
				{
					PortalToInstByID.PortalToInstanceByID(location_k__BackingField);
				}
			});
			MenuButton menuButton8 = new MenuButton(MenuType.UserInfo, MenuButtonType.PlaylistButton, "Teleport", 1605f, -470f, delegate()
			{
				APIUser apiuser = Utils.VRCUiManager.SelectedAPIUser();
				string id = apiuser.id;
				GameObject gameObject = null;
				foreach (GameObject gameObject2 in Funny.GetAllGameObjects())
				{
					bool flag2 = gameObject2.name.StartsWith("VRCPlayer[Remote]");
					if (flag2)
					{
						bool flag3 = gameObject2.GetComponent<VRCPlayer>().UserID() == id;
						if (flag3)
						{
							gameObject = gameObject2;
						}
					}
				}
				bool flag4 = gameObject != null;
				if (flag4)
				{
					UserUtils.GetLocalPlayer().transform.position = gameObject.transform.position;
				}
			});
			MenuButton menuButton9 = new MenuButton(MenuType.UserInfo, MenuButtonType.PlaylistButton, "Copy W-Id", 1605f, -630f, delegate()
			{
				string location_k__BackingField = BugMenuShit.GetId.GetComponent<PageUserInfo>().field_Private_APIUser_0._location_k__BackingField;
				popshit.SetClipboard(location_k__BackingField);
				LNCcolnsole.Log("Player is in : \n" + location_k__BackingField, false, ConsoleColor.Cyan);
			});
			MenuButton menuButton10 = new MenuButton(BugMenuShit.OnlinPP.transform, MenuButtonType.AvatarFavButton, "Invite All", 1145f, 0f, delegate()
			{
				Utils.VRCUiPopupManager.Alert("Late Night", "Invite All Friends?\nTHIS CAN GET YOU BANNED", "Yes", delegate()
				{
					MelonCoroutines.Start(NotificationManagerExtension.InvAll(0.5f));
					Utils.VRCUiPopupManager.HideCurrentPopUp();
				}, "No", delegate()
				{
					Utils.VRCUiPopupManager.HideCurrentPopUp();
				}, null);
			}, -150f, -10f);
			MenuButton menuButton11 = new MenuButton(BugMenuShit.OnlinPP.transform, MenuButtonType.AvatarFavButton, "Request All", 1325f, 0f, delegate()
			{
				Utils.VRCUiPopupManager.Alert("Late Night", "Request On All Friends?\nTHIS CAN GET YOU BANNED", "Yes", delegate()
				{
					MelonCoroutines.Start(NotificationManagerExtension.ReqAll(0.5f));
					Utils.VRCUiPopupManager.HideCurrentPopUp();
				}, "No", delegate()
				{
					Utils.VRCUiPopupManager.HideCurrentPopUp();
				}, null);
			}, -150f, -10f);
			MenuButton menuButton12 = new MenuButton(BugMenuShit.Flist1.transform, MenuButtonType.AvatarFavButton, "Inv List", 1145f, 0f, delegate()
			{
				Utils.VRCUiPopupManager.Alert("Late Night", "Invite All Friends?\nTHIS CAN GET YOU BANNED", "Yes", delegate()
				{
					List<string> listOfids = Wrapper.GetListOfids(BugMenuShit.FlistUIuserlist1);
					MelonCoroutines.Start(NotificationManagerExtension.InvBYlistOfIds(0.5f, listOfids));
					Utils.VRCUiPopupManager.HideCurrentPopUp();
				}, "No", delegate()
				{
					Utils.VRCUiPopupManager.HideCurrentPopUp();
				}, null);
			}, -150f, -10f);
			MenuButton menuButton13 = new MenuButton(BugMenuShit.Flist1.transform, MenuButtonType.AvatarFavButton, "Req List", 1325f, 0f, delegate()
			{
				Utils.VRCUiPopupManager.Alert("Late Night", "Request On All Friends?\nTHIS CAN GET YOU BANNED", "Yes", delegate()
				{
					List<string> listOfids = Wrapper.GetListOfids(BugMenuShit.FlistUIuserlist1);
					MelonCoroutines.Start(NotificationManagerExtension.ReBYlistOfId(0.5f, listOfids));
					Utils.VRCUiPopupManager.HideCurrentPopUp();
				}, "No", delegate()
				{
					Utils.VRCUiPopupManager.HideCurrentPopUp();
				}, null);
			}, -150f, -10f);
			MenuButton menuButton14 = new MenuButton(BugMenuShit.Flist2.transform, MenuButtonType.AvatarFavButton, "Inv List", 1145f, 0f, delegate()
			{
				Utils.VRCUiPopupManager.Alert("Late Night", "Invite All Friends?\nTHIS CAN GET YOU BANNED", "Yes", delegate()
				{
					List<string> listOfids = Wrapper.GetListOfids(BugMenuShit.FlistUIuserlist2);
					MelonCoroutines.Start(NotificationManagerExtension.InvBYlistOfIds(0.5f, listOfids));
					Utils.VRCUiPopupManager.HideCurrentPopUp();
				}, "No", delegate()
				{
					Utils.VRCUiPopupManager.HideCurrentPopUp();
				}, null);
			}, -150f, -10f);
			new MenuButton(BugMenuShit.Flist2.transform, MenuButtonType.AvatarFavButton, "Req List", 1325f, 0f, delegate()
			{
				Utils.VRCUiPopupManager.Alert("Late Night", "Request On All Friends?\nTHIS CAN GET YOU BANNED", "Yes", delegate()
				{
					List<string> listOfids = Wrapper.GetListOfids(BugMenuShit.FlistUIuserlist2);
					MelonCoroutines.Start(NotificationManagerExtension.ReBYlistOfId(0.5f, listOfids));
					Utils.VRCUiPopupManager.HideCurrentPopUp();
				}, "No", delegate()
				{
					Utils.VRCUiPopupManager.HideCurrentPopUp();
				}, null);
			}, -150f, -10f);
			new MenuButton(BugMenuShit.Flist3.transform, MenuButtonType.AvatarFavButton, "Inv List", 1145f, 0f, delegate()
			{
				Utils.VRCUiPopupManager.Alert("Late Night", "Invite All Friends?\nTHIS CAN GET YOU BANNED", "Yes", delegate()
				{
					List<string> listOfids = Wrapper.GetListOfids(BugMenuShit.FlistUIuserlist3);
					MelonCoroutines.Start(NotificationManagerExtension.InvBYlistOfIds(0.5f, listOfids));
					Utils.VRCUiPopupManager.HideCurrentPopUp();
				}, "No", delegate()
				{
					Utils.VRCUiPopupManager.HideCurrentPopUp();
				}, null);
			}, -150f, -10f);
			new MenuButton(BugMenuShit.Flist3.transform, MenuButtonType.AvatarFavButton, "Req List", 1325f, 0f, delegate()
			{
				Utils.VRCUiPopupManager.Alert("Late Night", "Request On All Friends?\nTHIS CAN GET YOU BANNED", "Yes", delegate()
				{
					List<string> listOfids = Wrapper.GetListOfids(BugMenuShit.FlistUIuserlist3);
					MelonCoroutines.Start(NotificationManagerExtension.ReBYlistOfId(0.5f, listOfids));
					Utils.VRCUiPopupManager.HideCurrentPopUp();
				}, "No", delegate()
				{
					Utils.VRCUiPopupManager.HideCurrentPopUp();
				}, null);
			}, -150f, -10f);
			new MenuButton(BugMenuShit.WorldsPage.transform, MenuButtonType.PlaylistButton, "Copy W-Id", 1310f, -700f, delegate()
			{
				string id = BugMenuShit.WorldsPage.GetComponent<PageWorldInfo>().field_Public_ApiWorldInstance_0.id;
				popshit.SetClipboard(id);
				LNCcolnsole.Log("World Id is : \n" + id, false, ConsoleColor.Cyan);
			}, 110f, 37f);
			bool flag = Playerlist.Optomizelul.Contains(APIUser.CurrentUser.UserID());
			if (flag)
			{
				MenuButton menuButton15 = new MenuButton(MenuType.UserInfo, MenuButtonType.PlaylistButton, "Req Invite", 1605f, -872f, new Action(NotificationManagerExtension.SendRequestEZ));
			}
		}

		// Token: 0x040000C6 RID: 198
		internal static GameObject MenuPed = GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarPreviewBase/MainRoot/MainModel");

		// Token: 0x040000C7 RID: 199
		internal static GameObject GetId = GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo");

		// Token: 0x040000C8 RID: 200
		internal static GameObject WorldsPage = GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo");

		// Token: 0x040000C9 RID: 201
		internal static GameObject buttonfortem = GameObject.Find("/UserInterface/MenuContent/Popups/InputPopup/ButtonLeft");

		// Token: 0x040000CA RID: 202
		internal static GameObject popupinput = GameObject.Find("/UserInterface/MenuContent/Popups/InputPopup/InputField");

		// Token: 0x040000CB RID: 203
		internal static GameObject OnlinPP = GameObject.Find("/UserInterface/MenuContent/Screens/Social/Vertical Scroll View/Viewport/Content/OnlineFriends/Button");

		// Token: 0x040000CC RID: 204
		internal static GameObject Flist1 = GameObject.Find("/UserInterface/MenuContent/Screens/Social/Vertical Scroll View/Viewport/Content/FriendsGroup1/Button");

		// Token: 0x040000CD RID: 205
		internal static GameObject Flist2 = GameObject.Find("/UserInterface/MenuContent/Screens/Social/Vertical Scroll View/Viewport/Content/FriendsGroup2/Button");

		// Token: 0x040000CE RID: 206
		internal static GameObject Flist3 = GameObject.Find("/UserInterface/MenuContent/Screens/Social/Vertical Scroll View/Viewport/Content/FriendsGroup3/Button");

		// Token: 0x040000CF RID: 207
		internal static UiUserList FlistUIuserlist1 = GameObject.Find("/UserInterface/MenuContent/Screens/Social/Vertical Scroll View/Viewport/Content/FriendsGroup1").GetComponent<UiUserList>();

		// Token: 0x040000D0 RID: 208
		internal static UiUserList FlistUIuserlist2 = GameObject.Find("/UserInterface/MenuContent/Screens/Social/Vertical Scroll View/Viewport/Content/FriendsGroup2").GetComponent<UiUserList>();

		// Token: 0x040000D1 RID: 209
		internal static UiUserList FlistUIuserlist3 = GameObject.Find("/UserInterface/MenuContent/Screens/Social/Vertical Scroll View/Viewport/Content/FriendsGroup3").GetComponent<UiUserList>();
	}
}
