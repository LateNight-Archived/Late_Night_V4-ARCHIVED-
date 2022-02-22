using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DayClientML2.Utility.Extensions;
using ExitGames.Client.Photon;
using HarmonyLib;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Late_Night_config;
using Late_Night_V2_lewd;
using Late_Night_V2_Playerlist;
using Late_Night_V2_wrappers;
using Late_Night_V3_Anitcrash;
using Late_Night_V3_AviFave;
using Late_Night_V3_colnsole;
using Late_Night_V3_Config_Seen_AVIS;
using Late_Night_V3_GlobalDynamicBones;
using Late_Night_V3_NamePlate;
using Photon.Realtime;
using UnhollowerBaseLib;
using UnhollowerRuntimeLib.XrefScans;
using UnityEngine;
using UnityEngine.XR;
using VRC;
using VRC.Core;
using VRC.SDKBase;

namespace Late_Night_V3
{
	// Token: 0x0200001F RID: 31
	public static class Patches
	{
		// Token: 0x06000154 RID: 340 RVA: 0x0000C810 File Offset: 0x0000AA10
		public static MethodInfo PlaceUI()
		{
			IEnumerable<XrefInstance> enumerable = XrefScanner.XrefScan(typeof(VRCUiManager).GetMethod("LateUpdate"));
			foreach (XrefInstance xrefInstance in enumerable)
			{
				bool flag;
				if (xrefInstance.Type == 1 && !(xrefInstance.TryResolve() == null) && xrefInstance.TryResolve().GetParameters().Length == 2)
				{
					flag = !xrefInstance.TryResolve().GetParameters().All((ParameterInfo a) => a.ParameterType == typeof(bool));
				}
				else
				{
					flag = true;
				}
				bool flag2 = flag;
				if (!flag2)
				{
					return (MethodInfo)xrefInstance.TryResolve();
				}
			}
			return null;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000C8F8 File Offset: 0x0000AAF8
		private static bool comfyMenu(VRCUiManager __instance, bool __0, bool __1)
		{
			try
			{
				bool flag = !XRDevice.isPresent || !Config.Instance.ComfyMode;
				if (flag)
				{
					return true;
				}
				float num = (Utils.VRCTrackingManager != null) ? Utils.VRCTrackingManager.transform.localScale.x : 1f;
				bool flag2 = num <= 0f;
				if (flag2)
				{
					num = 1f;
				}
				Transform transform = __instance.transform;
				Transform transform2 = __instance.transform.Find("UnscaledUI");
				transform.position = Utils.GetWorldCameraPosition();
				Vector3 eulerAngles = GameObject.Find("Camera (eye)").transform.rotation.eulerAngles;
				Vector3 vector;
				vector..ctor(eulerAngles.x - 30f, eulerAngles.y, 0f);
				bool flag3 = Utils.CurrentUser == null;
				if (flag3)
				{
					vector.x = (vector.z = 0f);
				}
				bool flag4 = !__0;
				if (flag4)
				{
					transform.rotation = Quaternion.Euler(vector);
				}
				else
				{
					Quaternion quaternion = Quaternion.Euler(vector);
					bool flag5 = Quaternion.Angle(transform.rotation, quaternion) >= 15f;
					if (flag5)
					{
						bool flag6 = Quaternion.Angle(transform.rotation, quaternion) >= 25f;
						if (flag6)
						{
							transform.rotation = Quaternion.RotateTowards(transform.rotation, quaternion, 5f);
						}
						else
						{
							transform.rotation = Quaternion.RotateTowards(transform.rotation, quaternion, 1f);
						}
					}
				}
				bool flag7 = num >= 0f;
				if (flag7)
				{
					transform.localScale = num * Vector3.one;
				}
				else
				{
					transform.localScale = Vector3.one;
				}
				bool flag8 = num > float.Epsilon;
				if (flag8)
				{
					transform2.localScale = 1f / num * Vector3.one;
				}
				else
				{
					transform2.localScale = Vector3.one;
				}
				return false;
			}
			catch
			{
			}
			return true;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000CB30 File Offset: 0x0000AD30
		public static bool checkXref(MethodBase m, string match)
		{
			try
			{
				return XrefScanner.XrefScan(m).Any((XrefInstance instance) => instance.Type == null && instance.ReadAsObject() != null && instance.ReadAsObject().ToString().ToLower().Equals(match.ToLower(), StringComparison.OrdinalIgnoreCase));
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000CB80 File Offset: 0x0000AD80
		public static bool CheckUsed(MethodBase methodBase, string methodName)
		{
			try
			{
				return (from instance in XrefScanner.UsedBy(methodBase)
				where instance.TryResolve() != null && instance.TryResolve().Name.Contains(methodName)
				select instance).Any<XrefInstance>();
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000CBD8 File Offset: 0x0000ADD8
		public static bool CheckMethod(MethodBase methodBase, string match)
		{
			try
			{
				return XrefScanner.XrefScan(methodBase).Any((XrefInstance instance) => instance.Type == null && instance.ReadAsObject().ToString().Contains(match));
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000CC28 File Offset: 0x0000AE28
		public static HarmonyMethod GetLocalPatch(string name)
		{
			return new HarmonyMethod(typeof(Patches).GetMethod(name, BindingFlags.Static | BindingFlags.NonPublic));
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000CC54 File Offset: 0x0000AE54
		private static void AvaLoaded(GameObject __0, VRC_AvatarDescriptor __1, bool __2, VRCPlayer __instance)
		{
			try
			{
				bool flag = !Config.Instance.LocalAvatarLog;
				if (!flag)
				{
					AviFave.FaveAvi(__instance.Method_Public_get_ApiAvatar_0(), 2);
					Config_Seen_AVIS.Instance.SaveConfig_AVIS_SEEN();
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000CCA8 File Offset: 0x0000AEA8
		private static void AviLoadType2(VRCAvatarManager __instance, ApiAvatar __0, GameObject __1)
		{
			try
			{
				APIUser apiuser = __instance.field_Private_VRCPlayer_0.GetAPIUser();
				GlobalDynamicBones.ProcessDynamicBones(__1, apiuser);
				VRCPlayer field_Private_VRCPlayer_ = __instance.field_Private_VRCPlayer_0;
				__1.anti_spwan_mian(field_Private_VRCPlayer_);
				bool autoforcelewd = Config.Instance.autoforcelewd;
				if (autoforcelewd)
				{
					__1.Lewdify();
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000CD0C File Offset: 0x0000AF0C
		private static void OnOpenBigMenu()
		{
			AviFave.showList();
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000CD18 File Offset: 0x0000AF18
		private static void onJoin(ref Player __0)
		{
			try
			{
				__0.gameObject.AddComponent<NamePlate>();
				bool joinNotif = Config.Instance.JoinNotif;
				if (joinNotif)
				{
					bool isFriend = __0.field_Private_APIUser_0.GetIsFriend();
					if (isFriend)
					{
						VRCUiManager.Method_Internal_Static_get_VRCUiManager_PDM_0().QueHudMessage("<color=#e0cf16> " + __0.Method_Internal_get_APIUser_0().displayName + " </color><color=#00e617> Joined</color>");
					}
					else
					{
						bool flag = !Config.Instance.JoinOnlyFriend;
						if (flag)
						{
							VRCUiManager.Method_Internal_Static_get_VRCUiManager_PDM_0().QueHudMessage(Playerlist.JOINRank(__0) + "<color=#00e617> Joined</color>");
						}
					}
					LNCcolnsole.Log("Player [" + __0.Method_Internal_get_APIUser_0().displayName + "] has Joined", false, ConsoleColor.White);
				}
				bool flag2 = __0.Method_Internal_get_APIUser_0().hasModerationPowers || __0.Method_Internal_get_APIUser_0().tags.Contains("admin_moderator") || __0.Method_Internal_get_APIUser_0().hasSuperPowers || __0.Method_Internal_get_APIUser_0().tags.Contains("admin_");
				if (flag2)
				{
					bool askonAdminJoin = Config.Instance.ASKonAdminJoin;
					if (askonAdminJoin)
					{
						Utils.VRCUiPopupManager.Alert("<color=#00e617>A Admin Has Joined</color>", "Would you like to Leave?", "Yes", delegate()
						{
							string text2 = Wrapper.homeId();
							Networking.GoToRoom(text2);
							Utils.VRCUiPopupManager.HideCurrentPopUp();
						}, "No", delegate()
						{
							Utils.VRCUiPopupManager.HideCurrentPopUp();
						}, null);
					}
					bool leaveOnAdminjoin = Config.Instance.LeaveOnAdminjoin;
					if (leaveOnAdminjoin)
					{
						string text = Wrapper.homeId();
						Networking.GoToRoom(text);
					}
					LNCcolnsole.Log("ADMIN [" + __0.Method_Internal_get_APIUser_0().displayName + "] HAS JOIND", false, ConsoleColor.Red);
				}
				bool espplayer = Config.Instance.ESPPlayer;
				if (espplayer)
				{
					PlayerWrapper.HighlightPlayer(__0, true);
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000CF20 File Offset: 0x0000B120
		private static void onLeft(ref Player __0)
		{
			try
			{
				bool flag = !Config.Instance.JoinNotif;
				if (!flag)
				{
					bool isFriend = __0.field_Private_APIUser_0.GetIsFriend();
					if (isFriend)
					{
						VRCUiManager.Method_Internal_Static_get_VRCUiManager_PDM_0().QueHudMessage("<color=#e0cf16> " + __0.Method_Internal_get_APIUser_0().displayName + " </color><color=#ad0000> Left</color>");
					}
					else
					{
						bool flag2 = !Config.Instance.JoinOnlyFriend;
						if (flag2)
						{
							VRCUiManager.Method_Internal_Static_get_VRCUiManager_PDM_0().QueHudMessage(Playerlist.JOINRank(__0) + "<color=#ad0000> Left</color>");
						}
					}
					LNCcolnsole.Log("Player [" + __0.Method_Internal_get_APIUser_0().displayName + "] has Left", false, ConsoleColor.White);
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000CFEC File Offset: 0x0000B1EC
		private static bool Enterportal(PortalTrigger __instance)
		{
			bool result;
			try
			{
				bool flag = Vector3.Distance(Utils.CurrentUser.transform.position, __instance.transform.position) > 1f;
				if (flag)
				{
					result = false;
				}
				else
				{
					bool flag2 = __instance.gameObject.GetComponentInParent<VRC_PortalMarker>() != null;
					if (flag2)
					{
						result = true;
					}
					else
					{
						bool askPortals = Config.Instance.AskPortals;
						if (askPortals)
						{
							Utils.VRCUiPopupManager.Alert("Late Night", "Would you like to Enter this Portal?", "Yes", delegate()
							{
								Networking.GoToRoom(__instance.field_Private_PortalInternal_0.field_Private_ApiWorld_0.id + ":" + __instance.field_Private_PortalInternal_0.field_Private_String_4);
								Utils.VRCUiPopupManager.HideCurrentPopUp();
							}, "No", delegate()
							{
								Utils.VRCUiPopupManager.HideCurrentPopUp();
							}, null);
							result = false;
						}
						else
						{
							Networking.GoToRoom(__instance.field_Private_PortalInternal_0.field_Private_ApiWorld_0.id + ":" + __instance.field_Private_PortalInternal_0.field_Private_String_1);
							result = false;
						}
					}
				}
			}
			catch
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000D114 File Offset: 0x0000B314
		private static void Instant(VRC_EventHandler.VrcBroadcastType __0, string __1, Vector3 __2, Quaternion __3)
		{
			try
			{
				string text = __0.ToString();
				string text2 = __2.ToString();
				string text3 = __3.ToString();
			}
			catch
			{
				LNCcolnsole.ERROR("Instant patch go brrr", false, ConsoleColor.Red);
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000D16C File Offset: 0x0000B36C
		private static void portalSpawn(PortalTrigger __instance)
		{
			try
			{
				bool flag = __instance.gameObject.GetComponentInParent<VRC_PortalMarker>() != null;
				if (!flag)
				{
					bool flag2 = !Config.Instance.autodeletePortals;
					if (!flag2)
					{
						string str = __instance.transform.position.ToString();
						LNCcolnsole.Log("Portal Spawned: vector3: " + str + "  Now Destroying it...", false, ConsoleColor.White);
						VRCUiManager.Method_Internal_Static_get_VRCUiManager_PDM_0().QueHudMessage("<color=red>Portal Spawned Destroying it...</color>");
						Object.Destroy(__instance.gameObject);
					}
				}
			}
			catch
			{
				LNCcolnsole.ERROR("portalSpawn patch go brrr", false, ConsoleColor.Red);
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000D218 File Offset: 0x0000B418
		private static bool EventPatch(ref Player __0, ref VRC_EventHandler.VrcEvent __1, ref VRC_EventHandler.VrcBroadcastType __2, ref int __3, ref float __4)
		{
			bool result;
			try
			{
				bool flag = true;
				bool flag2 = __1.EventType == 8;
				if (flag2)
				{
					flag = !Config.Instance.AntiTP;
				}
				result = flag;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000D264 File Offset: 0x0000B464
		private static void FakePing(ref int __result)
		{
			try
			{
				bool fakePing = Config.Instance.FakePing;
				if (fakePing)
				{
					__result = Config.Instance.setFakePingto;
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000D2A8 File Offset: 0x0000B4A8
		private static void FakeFrame(ref float __result)
		{
			try
			{
				bool fakeFPS = Config.Instance.FakeFPS;
				if (fakeFPS)
				{
					__result = 1f / Config.Instance.setFakeFPSto;
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000D2F0 File Offset: 0x0000B4F0
		private static bool photonevents(ref EventData __0)
		{
			try
			{
				bool flag = RoomManager.Method_Public_Static_get_Boolean_3();
				if (flag)
				{
					bool flag2 = Wrapper.GetPlayerbyphotonid(__0.Sender) == PlayerWrapper.GetCurrentPlayer();
					if (flag2)
					{
						return true;
					}
					bool isFriend = Wrapper.GetPlayerbyphotonid(__0.Sender).GetAPIUser().GetIsFriend();
					if (isFriend)
					{
						byte code = __0.Code;
						byte b = code;
						if (b <= 33)
						{
							switch (b)
							{
							case 4:
								if (!Config.Instance.Event4blockfriend)
								{
									goto IL_10C;
								}
								break;
							case 5:
							case 7:
								goto IL_10C;
							case 6:
								if (!Config.Instance.Event6blockfriend)
								{
									goto IL_10C;
								}
								break;
							case 8:
								if (!Config.Instance.Event8blockfriend)
								{
									goto IL_10C;
								}
								break;
							case 9:
								if (!Config.Instance.Event9blockfriend)
								{
									goto IL_10C;
								}
								break;
							default:
								if (b != 33)
								{
									goto IL_10C;
								}
								if (!Config.Instance.Event33blockfriend)
								{
									goto IL_10C;
								}
								break;
							}
						}
						else if (b != 209)
						{
							if (b != 210)
							{
								goto IL_10C;
							}
							if (!Config.Instance.Event210blockfriend)
							{
								goto IL_10C;
							}
						}
						else if (!Config.Instance.Event209blockfriend)
						{
							goto IL_10C;
						}
						return false;
						IL_10C:
						bool e9Antifriends = Config.Instance.E9Antifriends;
						if (e9Antifriends)
						{
							bool flag3 = __0.Code == 9;
							if (flag3)
							{
								Il2CppArrayBase<byte> il2CppArrayBase = __0.CustomData.Cast<Il2CppArrayBase<byte>>();
								bool flag4 = il2CppArrayBase.Length > 0;
								if (flag4)
								{
									for (int i = 0; i < il2CppArrayBase.Length; i++)
									{
										bool flag5 = il2CppArrayBase.Length == 224 || il2CppArrayBase.Length == 8 || il2CppArrayBase.Length == 9;
										if (flag5)
										{
											return false;
										}
									}
								}
							}
						}
					}
					else
					{
						byte code2 = __0.Code;
						byte b2 = code2;
						if (b2 <= 33)
						{
							switch (b2)
							{
							case 4:
								if (!Config.Instance.Event4blockNonfriends)
								{
									goto IL_26A;
								}
								break;
							case 5:
							case 7:
								goto IL_26A;
							case 6:
								if (!Config.Instance.Event6blockNonfriends)
								{
									goto IL_26A;
								}
								break;
							case 8:
								if (!Config.Instance.Event8blockNonfriends)
								{
									goto IL_26A;
								}
								break;
							case 9:
								if (!Config.Instance.Event9blockNonfriends)
								{
									goto IL_26A;
								}
								break;
							default:
								if (b2 != 33)
								{
									goto IL_26A;
								}
								if (!Config.Instance.Event33blockNonfriends)
								{
									goto IL_26A;
								}
								break;
							}
						}
						else if (b2 != 209)
						{
							if (b2 != 210)
							{
								goto IL_26A;
							}
							if (!Config.Instance.Event210blockNonfriends)
							{
								goto IL_26A;
							}
						}
						else if (!Config.Instance.Event209blockNonfriends)
						{
							goto IL_26A;
						}
						return false;
						IL_26A:
						bool e9AntiNonfriends = Config.Instance.E9AntiNonfriends;
						if (e9AntiNonfriends)
						{
							bool flag6 = __0.Code == 9;
							if (flag6)
							{
								Il2CppArrayBase<byte> il2CppArrayBase2 = __0.CustomData.Cast<Il2CppArrayBase<byte>>();
								bool flag7 = il2CppArrayBase2.Length > 0;
								if (flag7)
								{
									for (int j = 0; j < il2CppArrayBase2.Length; j++)
									{
										bool flag8 = il2CppArrayBase2.Length == 224 || il2CppArrayBase2.Length == 8 || il2CppArrayBase2.Length == 9;
										if (flag8)
										{
											return false;
										}
									}
								}
							}
						}
					}
				}
			}
			catch
			{
			}
			return true;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0000D62C File Offset: 0x0000B82C
		private static bool OnAvatarAssetBundleLoad(ref Object __0)
		{
			bool flag = __0 == null;
			bool result;
			if (flag)
			{
				result = true;
			}
			else
			{
				GameObject gameObject = __0.TryCast<GameObject>();
				bool flag2 = gameObject == null;
				if (flag2)
				{
					result = true;
				}
				else
				{
					bool flag3 = gameObject != null && gameObject.name.ToLower().Contains("avatar");
					if (flag3)
					{
						string blueprintId = gameObject.GetComponent<PipelineManager>().blueprintId;
					}
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000D69C File Offset: 0x0000B89C
		private static bool ReturnFalse()
		{
			return false;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000D6B0 File Offset: 0x0000B8B0
		private static bool OpRaiseEv(byte __0, ref Object __1, ref RaiseEventOptions __2)
		{
			try
			{
				bool flag = __1 != null && __2 != null;
				if (flag)
				{
					return __0 != 7 || !Late_Night.Ghoats;
				}
			}
			catch
			{
				return true;
			}
			return true;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000D700 File Offset: 0x0000B900
		private static void QSpoof(ref string __result)
		{
			try
			{
				bool flag = !RoomManagerExtension.IsInWorld();
				if (flag)
				{
					__result = "android";
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000D73C File Offset: 0x0000B93C
		private static bool OpRaiseEventPrefix(byte __0, Object __1, RaiseEventOptions __2, SendOptions __3)
		{
			try
			{
				bool flag = __0 == 202;
				if (flag)
				{
					__2.field_Public_ReceiverGroup_0 = (Late_Night.invisjoin ? 2 : 0);
				}
			}
			catch (Exception ex)
			{
				LNCcolnsole.ERROR(ex.ToString(), false, ConsoleColor.Red);
			}
			return true;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000D798 File Offset: 0x0000B998
		private static bool Triggeruwu(ref VRC_EventHandler.VrcEvent __0, ref VRC_EventHandler.VrcBroadcastType __1, ref int __2)
		{
			try
			{
				bool woldtrig = Config.Instance.Woldtrig;
				if (woldtrig)
				{
					__1 = 4;
				}
			}
			catch
			{
			}
			return true;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000D7D8 File Offset: 0x0000B9D8
		private static bool MsgApi(ref string __0, ref Dictionary<string, Object> __2)
		{
			try
			{
				bool flag = __2 != null && (__0 == "visits" || __0 == "worlds");
				if (flag)
				{
					bool gb_line = Config.Instance.GB_line;
					if (gb_line)
					{
						return false;
					}
				}
			}
			catch
			{
			}
			return true;
		}
	}
}
