using System;
using System.Collections;
using System.Collections.Generic;
using BestHTTP;
using DayClientML2.Utility.Extensions;
using External_Libraries.popups;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Late_Night_config;
using Late_Night_config_Firends_backUp;
using Late_Night_V2_Playerlist;
using Late_Night_V3_colnsole;
using Late_Night_V3_PlayerObjects;
using TMPro;
using UnhollowerBaseLib;
using UnityEngine;
using UnityEngine.UI;
using VRC;
using VRC.Core;
using VRC.SDKBase;
using VRC.Udon;

namespace Late_Night_V2_wrappers
{
	// Token: 0x02000003 RID: 3
	internal static class PlayerWrapper
	{
		// Token: 0x0600000B RID: 11 RVA: 0x000021D8 File Offset: 0x000003D8
		internal static Player GetSelectedPlayer(bool forlist = false)
		{
			bool flag = !GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_SelectedUser_Local").active;
			if (flag)
			{
				if (forlist)
				{
					return null;
				}
			}
			string text = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_SelectedUser_Local/ScrollRect/Viewport/VerticalLayoutGroup/UserProfile_Compact/PanelBG/Info/Text_Username_NonFriend").GetComponent<TextMeshProUGUI>().text;
			List<Player> field_Private_List_1_Player_ = PlayerManager.field_Private_Static_PlayerManager_0.field_Private_List_1_Player_0;
			foreach (Player player in field_Private_List_1_Player_)
			{
				bool flag2 = player.GetVRCPlayerApi().displayName == text;
				if (flag2)
				{
					return player;
				}
			}
			return null;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000226C File Offset: 0x0000046C
		internal static void QueueHudMessage(string Text, Color? color)
		{
			VRCUiManager.Method_Internal_Static_get_VRCUiManager_PDM_0().field_Public_Text_0.color = color.Value;
			VRCUiManager.Method_Internal_Static_get_VRCUiManager_PDM_0().field_Private_List_1_String_0.Add("[Late Night]\n" + Text);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000022A1 File Offset: 0x000004A1
		internal static void CloseAllUI()
		{
			PlayerWrapper.CloseAllSubMenus();
			VRCUiManager.Method_Internal_Static_get_VRCUiManager_PDM_0().HideScreen("POPUP");
			VRCUiManager.Method_Internal_Static_get_VRCUiManager_PDM_0().Method_Public_Virtual_New_Void_Boolean_0(false);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000022C8 File Offset: 0x000004C8
		internal static void CloseAllSubMenus()
		{
			PlayerWrapper.ShortcutMenuTransform.gameObject.SetActive(false);
			PlayerWrapper.UserInteractMenuTransform.gameObject.SetActive(false);
			foreach (GameObject gameObject in PlayerWrapper.SubMenus)
			{
				gameObject.SetActive(false);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002344 File Offset: 0x00000544
		internal static Transform ShortcutMenuTransform
		{
			get
			{
				return GameObject.Find("/UserInterface/QuickMenu/ShortcutMenu").transform;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002355 File Offset: 0x00000555
		internal static Transform UserInteractMenuTransform
		{
			get
			{
				return GameObject.Find("/UserInterface/QuickMenu/UserInteractMenu").transform;
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002368 File Offset: 0x00000568
		internal static void ReloadAllAvatars()
		{
			bool flag = VRCPlayer.field_Internal_Static_VRCPlayer_0 == null;
			if (!flag)
			{
				foreach (Player player in PlayerManager.field_Private_Static_PlayerManager_0.field_Private_List_1_Player_0)
				{
					bool flag2 = player != null && player.Method_Internal_get_VRCPlayer_0() != null;
					if (flag2)
					{
						player.ReloadAvatar();
					}
				}
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000023D4 File Offset: 0x000005D4
		public static IEnumerator savefirends(float WaitBetweenPlayer)
		{
			List<string> AllPlayers = APIUser.CurrentUser.friendIDs;
			List<string>.Enumerator enumerator = AllPlayers.GetEnumerator();
			while (enumerator.MoveNext())
			{
				PlayerWrapper.<>c__DisplayClass11_0 CS$<>8__locals1 = new PlayerWrapper.<>c__DisplayClass11_0();
				CS$<>8__locals1.friendid = enumerator.Current;
				APIUser.FetchUser(CS$<>8__locals1.friendid, delegate(APIUser friend)
				{
					LNCcolnsole.Log("Saving User :" + friend.displayName, true, ConsoleColor.Blue);
					Config_Firends_backUp.Instance.firends.Add(new PLayerObjects(friend.displayName, friend.id));
				}, delegate(string message)
				{
					LNCcolnsole.Log("[API] Failed Fetching Friend : " + CS$<>8__locals1.friendid, false, ConsoleColor.White);
				});
				yield return new WaitForSeconds(WaitBetweenPlayer);
				CS$<>8__locals1 = null;
			}
			enumerator = null;
			Config_Firends_backUp.Instance.SaveConfig_Firends_backUp();
			LNCcolnsole.Log("DONE!!!", true, ConsoleColor.Cyan);
			yield return null;
			yield break;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000023E3 File Offset: 0x000005E3
		public static IEnumerator REfirend(float WaitBetweenPlayer)
		{
			List<string> allPlayers = APIUser.CurrentUser.friendIDs;
			foreach (PLayerObjects P in Config_Firends_backUp.Instance.firends)
			{
				LNCcolnsole.Log("Trying : " + P.id, false, ConsoleColor.Blue);
				bool flag = !allPlayers.Contains(P.id);
				if (flag)
				{
					LNCcolnsole.Log("friendReq To : " + P.id, true, ConsoleColor.Green);
					PlayerWrapper.SendFriendRequest(P.id);
				}
				yield return new WaitForSeconds(WaitBetweenPlayer);
				P = null;
			}
			List<PLayerObjects>.Enumerator enumerator = default(List<PLayerObjects>.Enumerator);
			LNCcolnsole.Log("DONE!", true, ConsoleColor.Cyan);
			yield return null;
			yield break;
			yield break;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000023F2 File Offset: 0x000005F2
		public static IEnumerator Friendallinlobby(float WaitBetweenPlayer, List<Player> List)
		{
			foreach (Player P in List)
			{
				bool flag = !RoomManager.Method_Public_Static_get_Boolean_3();
				if (flag)
				{
					LNCcolnsole.Log("Left World stoping. . .", true, ConsoleColor.Red);
					yield return null;
				}
				bool flag2 = P == null || P.field_Private_APIUser_0 == APIUser.CurrentUser;
				if (!flag2)
				{
					LNCcolnsole.Log("trying : " + P.field_Private_APIUser_0.displayName, false, ConsoleColor.Blue);
					bool flag3 = APIUser.CurrentUser.friendIDs.Contains(P.field_Private_APIUser_0.id);
					if (flag3)
					{
						LNCcolnsole.Log("Player : " + P.field_Private_APIUser_0.displayName + "Is allready a friend", true, ConsoleColor.Yellow);
					}
					else
					{
						LNCcolnsole.Log("Friending : " + P.field_Private_APIUser_0.displayName, true, ConsoleColor.Green);
						PlayerWrapper.SendFriendRequest(P.field_Private_APIUser_0.id);
					}
					yield return new WaitForSeconds(WaitBetweenPlayer);
					P = null;
				}
			}
			List<Player>.Enumerator enumerator = null;
			LNCcolnsole.Log("DONE!", true, ConsoleColor.Cyan);
			yield return null;
			yield break;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002408 File Offset: 0x00000608
		public static List<Player> PlayerList()
		{
			return PlayerManager.field_Private_Static_PlayerManager_0.field_Private_List_1_Player_0;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002424 File Offset: 0x00000624
		public static void SendFriendRequest(string userid)
		{
			string url = "user/" + userid + "/friendRequest";
			ApiDictContainer apiDictContainer = new ApiDictContainer(new string[0]);
			ApiDictContainer callback = apiDictContainer;
			PlayerWrapper.SendRequest(url, 2, callback, true, null);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002464 File Offset: 0x00000664
		internal static void SendRequest(string url, HTTPMethods method, ApiContainer callback = null, bool noCache = true, Dictionary<string, Object> parms = null)
		{
			API.SendRequest(url, method, callback, parms, true, noCache, 3600f, 2, null, null);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002488 File Offset: 0x00000688
		internal static PlayerManager get_player_manager()
		{
			return PlayerManager.Method_Public_Static_get_PlayerManager_0();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000024A0 File Offset: 0x000006A0
		internal static Player GetPlayerFromIDInLobby(string id)
		{
			List<Player> allPlayers = PlayerWrapper.GetAllPlayers();
			foreach (Player player in allPlayers)
			{
				bool flag = player != null && player.GetAPIUser() != null && player.GetAPIUser().id == id;
				if (flag)
				{
					return player;
				}
			}
			return null;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002508 File Offset: 0x00000708
		internal static void PickupESP(bool state)
		{
			Il2CppArrayBase<VRC_Pickup> il2CppArrayBase = Resources.FindObjectsOfTypeAll<VRC_Pickup>();
			foreach (VRC_Pickup vrc_Pickup in il2CppArrayBase)
			{
				bool flag = !(vrc_Pickup == null) && !(vrc_Pickup.gameObject == null) && vrc_Pickup.gameObject.active && vrc_Pickup.enabled && vrc_Pickup.pickupable && !vrc_Pickup.name.Contains("ViewFinder") && !(HighlightsFX.Method_Public_Static_get_HighlightsFX_PDM_0() == null);
				if (flag)
				{
					HighlightsFX.Method_Public_Static_get_HighlightsFX_PDM_0().Method_Public_Void_Renderer_Boolean_0(vrc_Pickup.GetComponentInChildren<MeshRenderer>(), state);
				}
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000025C4 File Offset: 0x000007C4
		internal static void TriggerESP(bool state)
		{
			Il2CppArrayBase<VRC_Trigger> il2CppArrayBase = Resources.FindObjectsOfTypeAll<VRC_Trigger>();
			Il2CppArrayBase<UdonBehaviour> il2CppArrayBase2 = Resources.FindObjectsOfTypeAll<UdonBehaviour>();
			foreach (VRC_Trigger vrc_Trigger in il2CppArrayBase)
			{
				bool flag = !(vrc_Trigger == null) && !(vrc_Trigger.gameObject == null) && vrc_Trigger.gameObject.active && !vrc_Trigger.name.Contains("ViewFinder") && !(HighlightsFX.Method_Public_Static_get_HighlightsFX_PDM_0() == null);
				if (flag)
				{
					HighlightsFX.Method_Public_Static_get_HighlightsFX_PDM_0().Method_Public_Void_Renderer_Boolean_0(vrc_Trigger.GetComponentInChildren<MeshRenderer>(), state);
				}
			}
			foreach (UdonBehaviour udonBehaviour in il2CppArrayBase2)
			{
				bool flag2 = !(udonBehaviour == null) && !(udonBehaviour.gameObject == null) && udonBehaviour.gameObject.active && !udonBehaviour.name.Contains("ViewFinder") && !(HighlightsFX.Method_Public_Static_get_HighlightsFX_PDM_0() == null) && udonBehaviour._eventTable.System_Collections_IDictionary_Contains("_interact");
				if (flag2)
				{
					HighlightsFX.Method_Public_Static_get_HighlightsFX_PDM_0().Method_Public_Void_Renderer_Boolean_0(udonBehaviour.GetComponentInChildren<MeshRenderer>(), state);
				}
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002734 File Offset: 0x00000934
		internal static void toggle_outline(Renderer render, bool state)
		{
			bool flag = HighlightsFX.Method_Public_Static_get_HighlightsFX_PDM_0() == null;
			if (!flag)
			{
				HighlightsFX.Method_Public_Static_get_HighlightsFX_PDM_0().Method_Public_Void_Renderer_Boolean_0(render, state);
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002760 File Offset: 0x00000960
		internal static VRCPlayer GetCurrentPlayer()
		{
			return VRCPlayer.field_Internal_Static_VRCPlayer_0;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002778 File Offset: 0x00000978
		internal static List<Player> GetAllPlayers()
		{
			return Wrapper.GetPlayerManager().field_Private_List_1_Player_0;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002794 File Offset: 0x00000994
		public static void ToggleESP(bool enabled)
		{
			PlayerManager field_Private_Static_PlayerManager_ = PlayerManager.field_Private_Static_PlayerManager_0;
			bool flag = field_Private_Static_PlayerManager_ == null;
			if (!flag)
			{
				foreach (Player player in field_Private_Static_PlayerManager_.AllPlayers())
				{
					PlayerWrapper.HighlightPlayer(player, enabled);
				}
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002804 File Offset: 0x00000A04
		public static void HighlightPlayer(Player player, bool enable)
		{
			bool isSelf = player.field_Private_APIUser_0.IsSelf;
			if (!isSelf)
			{
				Transform transform = player.transform.Find("SelectRegion");
				bool flag = transform == null;
				if (!flag)
				{
					PlayerWrapper.GetHighlightsFX(player).Method_Public_Void_Renderer_Boolean_0(transform.GetComponent<Renderer>(), enable);
				}
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002858 File Offset: 0x00000A58
		private static HighlightsFXStandalone GetHighlightsFX(Player Instance)
		{
			bool flag = Instance.Method_Internal_get_APIUser_0().hasModerationPowers || Instance.Method_Internal_get_APIUser_0().tags.Contains("admin_moderator") || Playerlist.THEBRUHS.Contains(Instance.Method_Internal_get_APIUser_0().id);
			HighlightsFXStandalone result;
			if (flag)
			{
				result = PlayerWrapper.DEVnHighlights;
			}
			else
			{
				bool flag2 = Instance.Method_Internal_get_APIUser_0().hasSuperPowers || Instance.Method_Internal_get_APIUser_0().tags.Contains("admin_");
				if (flag2)
				{
					result = PlayerWrapper.DEVnHighlights;
				}
				else
				{
					bool isFriend = Instance.Method_Internal_get_APIUser_0().GetIsFriend();
					if (isFriend)
					{
						result = PlayerWrapper.FriendsHighlights;
					}
					else
					{
						bool flag3 = Instance.Method_Internal_get_APIUser_0().tags.Contains("system_legend") && Instance.Method_Internal_get_APIUser_0().tags.Contains("system_trust_legend") && Instance.Method_Internal_get_APIUser_0().tags.Contains("system_trust_trusted");
						if (flag3)
						{
							result = PlayerWrapper.TrustedHighlights;
						}
						else
						{
							bool flag4 = Instance.Method_Internal_get_APIUser_0().hasLegendTrustLevel || (Instance.Method_Internal_get_APIUser_0().tags.Contains("system_trust_legend") && Instance.Method_Internal_get_APIUser_0().tags.Contains("system_trust_trusted"));
							if (flag4)
							{
								result = PlayerWrapper.TrustedHighlights;
							}
							else
							{
								bool hasVeteranTrustLevel = Instance.Method_Internal_get_APIUser_0().hasVeteranTrustLevel;
								if (hasVeteranTrustLevel)
								{
									result = PlayerWrapper.TrustedHighlights;
								}
								else
								{
									bool hasTrustedTrustLevel = Instance.Method_Internal_get_APIUser_0().hasTrustedTrustLevel;
									if (hasTrustedTrustLevel)
									{
										result = PlayerWrapper.KnowUserHighlights;
									}
									else
									{
										bool hasKnownTrustLevel = Instance.Method_Internal_get_APIUser_0().hasKnownTrustLevel;
										if (hasKnownTrustLevel)
										{
											result = PlayerWrapper.UserHighlights;
										}
										else
										{
											bool flag5 = Instance.Method_Internal_get_APIUser_0().hasBasicTrustLevel || Instance.Method_Internal_get_APIUser_0().isNewUser;
											if (flag5)
											{
												result = PlayerWrapper.NewUserHighlights;
											}
											else
											{
												bool hasNegativeTrustLevel = Instance.Method_Internal_get_APIUser_0().hasNegativeTrustLevel;
												if (hasNegativeTrustLevel)
												{
													result = PlayerWrapper.VisitorHighlights;
												}
												else
												{
													bool hasVeryNegativeTrustLevel = Instance.Method_Internal_get_APIUser_0().hasVeryNegativeTrustLevel;
													if (hasVeryNegativeTrustLevel)
													{
														result = PlayerWrapper.VisitorHighlights;
													}
													else
													{
														result = PlayerWrapper.VisitorHighlights;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002A68 File Offset: 0x00000C68
		public static void setupcolor()
		{
			HighlightsFX field_Private_Static_HighlightsFX_ = HighlightsFX.field_Private_Static_HighlightsFX_0;
			PlayerWrapper.FriendsHighlights = field_Private_Static_HighlightsFX_.gameObject.AddComponent<HighlightsFXStandalone>();
			PlayerWrapper.FriendsHighlights.highlightColor = default(Color).hextorgb(Config.Instance.Friend);
			PlayerWrapper.DEVnHighlights = field_Private_Static_HighlightsFX_.gameObject.AddComponent<HighlightsFXStandalone>();
			PlayerWrapper.DEVnHighlights.highlightColor = new Color(1f, 0f, 0f);
			PlayerWrapper.TrustedHighlights = field_Private_Static_HighlightsFX_.gameObject.AddComponent<HighlightsFXStandalone>();
			PlayerWrapper.TrustedHighlights.highlightColor = default(Color).hextorgb(Config.Instance.Trusted);
			PlayerWrapper.KnowUserHighlights = field_Private_Static_HighlightsFX_.gameObject.AddComponent<HighlightsFXStandalone>();
			PlayerWrapper.KnowUserHighlights.highlightColor = default(Color).hextorgb(Config.Instance.known);
			PlayerWrapper.UserHighlights = field_Private_Static_HighlightsFX_.gameObject.AddComponent<HighlightsFXStandalone>();
			PlayerWrapper.UserHighlights.highlightColor = default(Color).hextorgb(Config.Instance.user);
			PlayerWrapper.NewUserHighlights = field_Private_Static_HighlightsFX_.gameObject.AddComponent<HighlightsFXStandalone>();
			PlayerWrapper.NewUserHighlights.highlightColor = default(Color).hextorgb(Config.Instance.Newuser);
			PlayerWrapper.VisitorHighlights = field_Private_Static_HighlightsFX_.gameObject.AddComponent<HighlightsFXStandalone>();
			PlayerWrapper.VisitorHighlights.highlightColor = default(Color).hextorgb(Config.Instance.vistor);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002BE0 File Offset: 0x00000DE0
		public static void UpdateESPcolor()
		{
			PlayerWrapper.FriendsHighlights.highlightColor = default(Color).hextorgb(Config.Instance.Friend);
			PlayerWrapper.DEVnHighlights.highlightColor = new Color(1f, 0f, 0f);
			PlayerWrapper.TrustedHighlights.highlightColor = default(Color).hextorgb(Config.Instance.Trusted);
			PlayerWrapper.KnowUserHighlights.highlightColor = default(Color).hextorgb(Config.Instance.known);
			PlayerWrapper.UserHighlights.highlightColor = default(Color).hextorgb(Config.Instance.user);
			PlayerWrapper.NewUserHighlights.highlightColor = default(Color).hextorgb(Config.Instance.Newuser);
			PlayerWrapper.VisitorHighlights.highlightColor = default(Color).hextorgb(Config.Instance.vistor);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002CE0 File Offset: 0x00000EE0
		internal static Player GetPlayer(string UserID)
		{
			List<Player> allPlayers = PlayerWrapper.GetAllPlayers();
			Player result = null;
			foreach (Player player in allPlayers)
			{
				Player player2 = player;
				bool flag = player2.GetAPIUser().id == UserID;
				if (flag)
				{
					result = player2;
				}
			}
			return result;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002D38 File Offset: 0x00000F38
		public static void ChangeStauts(string Status)
		{
			UiInputField component = GameObject.Find("UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/InputFieldStatus").GetComponent<UiInputField>();
			component.Method_Public_Virtual_Final_New_set_Void_String_0(Status);
			Button component2 = GameObject.Find("UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/Buttons/UpdateButton").GetComponent<Button>();
			component2.onClick.Invoke();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002D7C File Offset: 0x00000F7C
		public static void statusUpdate()
		{
			PlayerWrapper.updatetime += Time.deltaTime;
			bool flag = PlayerWrapper.updatetime <= 10f;
			if (!flag)
			{
				bool flag2 = !RoomManager.Method_Public_Static_get_Boolean_3();
				if (!flag2)
				{
					bool flag3 = Config.Instance.statusNext && !Config.Instance.statusRandom;
					if (flag3)
					{
						PlayerWrapper.Nextststuse();
					}
					bool flag4 = Config.Instance.statusRandom && !Config.Instance.statusNext;
					if (flag4)
					{
						PlayerWrapper.reandomstat();
					}
					bool flag5 = Config.Instance.statusRandom && Config.Instance.statusNext;
					if (flag5)
					{
						LNCcolnsole.Log("Plz only have one status changer on", true, ConsoleColor.White);
					}
					PlayerWrapper.updatetime = 0f;
				}
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002E4C File Offset: 0x0000104C
		public static void reandomstat()
		{
			bool flag = Config.Instance.StatusV2.Count == 0;
			if (flag)
			{
				LNCcolnsole.Log("Please add a status", true, ConsoleColor.White);
			}
			else
			{
				int index = new Random().Next(0, Config.Instance.StatusV2.Count);
				PlayerWrapper.ChangeStauts(Config.Instance.StatusV2[index]);
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002EB4 File Offset: 0x000010B4
		public static void Nextststuse()
		{
			bool flag = Config.Instance.StatusV2.Count == 0;
			if (flag)
			{
				LNCcolnsole.Log("Please add a status", true, ConsoleColor.White);
			}
			else
			{
				UiInputField component = GameObject.Find("UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/InputFieldStatus").GetComponent<UiInputField>();
				int num = Config.Instance.StatusV2.IndexOf(component.Method_Public_Virtual_Final_New_get_String_0()) + 1;
				bool flag2 = num > Config.Instance.StatusV2.Count;
				if (flag2)
				{
					PlayerWrapper.ChangeStauts(Config.Instance.StatusV2[0]);
				}
				else
				{
					PlayerWrapper.ChangeStauts(Config.Instance.StatusV2[num]);
				}
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002F59 File Offset: 0x00001159
		public static void Addstsus()
		{
			Popups.PopupCall("Status", "Enter", "Status", false, delegate(string text)
			{
				bool flag = string.IsNullOrEmpty(text);
				if (!flag)
				{
					bool flag2 = !Config.Instance.StatusV2.Contains(text);
					if (flag2)
					{
						bool flag3 = text.Length < 33;
						if (flag3)
						{
							Config.Instance.StatusV2.Add(text);
							Config.Instance.SaveConfig();
							LNCcolnsole.Log("Added", true, ConsoleColor.White);
						}
						else
						{
							LNCcolnsole.Log("Can't Use More Than 32 Letter", true, ConsoleColor.White);
						}
					}
					else
					{
						LNCcolnsole.Log("This Status is already in use", true, ConsoleColor.Yellow);
					}
				}
			}, null);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002F92 File Offset: 0x00001192
		public static void Removestsus()
		{
			Popups.PopupCall("Status", "Enter", "Status", false, delegate(string text)
			{
				bool flag = string.IsNullOrEmpty(text);
				if (!flag)
				{
					bool flag2 = Config.Instance.StatusV2.Contains(text);
					if (flag2)
					{
						Config.Instance.StatusV2.Remove(text);
						Config.Instance.SaveConfig();
						LNCcolnsole.Log("Remove", true, ConsoleColor.White);
					}
					else
					{
						LNCcolnsole.Log("This Status is not in use", true, ConsoleColor.Yellow);
					}
				}
			}, null);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002FCB File Offset: 0x000011CB
		public static void Rest()
		{
			Config.Instance.StatusV2.Clear();
			Config.Instance.SaveConfig();
		}

		// Token: 0x04000005 RID: 5
		internal static List<string> friend_list = new List<string>();

		// Token: 0x04000006 RID: 6
		private static List<GameObject> SubMenus = new List<GameObject>();

		// Token: 0x04000007 RID: 7
		private static HighlightsFXStandalone FriendsHighlights;

		// Token: 0x04000008 RID: 8
		private static HighlightsFXStandalone LegendaryHighlights;

		// Token: 0x04000009 RID: 9
		private static HighlightsFXStandalone DEVnHighlights;

		// Token: 0x0400000A RID: 10
		private static HighlightsFXStandalone TrustedHighlights;

		// Token: 0x0400000B RID: 11
		private static HighlightsFXStandalone KnowUserHighlights;

		// Token: 0x0400000C RID: 12
		private static HighlightsFXStandalone UserHighlights;

		// Token: 0x0400000D RID: 13
		private static HighlightsFXStandalone NewUserHighlights;

		// Token: 0x0400000E RID: 14
		private static HighlightsFXStandalone VisitorHighlights;

		// Token: 0x0400000F RID: 15
		public static float updatetime;
	}
}
