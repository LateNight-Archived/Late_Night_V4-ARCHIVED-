using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using AmplitudeSDKWrapper;
using DayClientML2.Utility;
using DayClientML2.Utility.Extensions;
using ExitGames.Client.Photon;
using External_Libraries.popups;
using Harmony;
using HarmonyLib;
using Late_Night_config;
using Late_Night_config_Firends_backUp;
using Late_Night_V2_Move_vrc_ui;
using Late_Night_V2_ui_difine;
using Late_Night_V2_wrappers;
using Late_Night_V3.Modules_BugMenuShit;
using Late_Night_V3.Modules_Funny;
using Late_Night_V3.Modules_Movement;
using Late_Night_V3.Modules_Player;
using Late_Night_V3.Modules_QOL;
using Late_Night_V3.Modules_Safety;
using Late_Night_V3.Modules_Settings;
using Late_Night_V3.Modules_UserUtils;
using Late_Night_V3.Modules_Wolds;
using Late_Night_V3_Art;
using Late_Night_V3_AviFave;
using Late_Night_V3_BigMenuBeh;
using Late_Night_V3_colnsole;
using Late_Night_V3_Config_AVI_FAVE;
using Late_Night_V3_Config_Seen_AVIS;
using Late_Night_V3_Config_World_Histoy;
using Late_Night_V3_Enderpearl;
using Late_Night_V3_GlobalDynamicBones;
using Late_Night_V3_MediaControl;
using Late_Night_V3_NamePlate;
using Late_Night_V3_PickUpBoom;
using Late_Night_V3_PlayerSel;
using Late_Night_V3_QmFreeze;
using Late_Night_V3_StarLag;
using Late_Night_V3_stayoffnigga;
using Late_Night_V3_Test69;
using Late_Night_V3_WorldGameHacks;
using Late_Night_V4.Move;
using MelonLoader;
using Photon.Realtime;
using ProjectXoX.Utility;
using RootMotion.FinalIK;
using UnhollowerRuntimeLib;
using UnityEngine;
using UnityEngine.XR;
using VRC;
using VRC.Core;
using VRC.SDKBase;
using VRCSDK2;
using XButtonAPI;

namespace Late_Night_V3
{
	// Token: 0x0200001E RID: 30
	public class Late_Night : MelonMod
	{
		// Token: 0x0600010E RID: 270 RVA: 0x00009048 File Offset: 0x00007248
		public override void OnApplicationStart()
		{
			Art.Art_start();
			Console.Title = "Late Night V4";
			try
			{
				Wrapper.DirectoryFiles();
			}
			catch (Exception)
			{
				LNCcolnsole.ERROR("Failed To Find Files/Folders", false, ConsoleColor.Red);
			}
			Config.Instance = Config.Load();
			Config_Firends_backUp.Instance = Config_Firends_backUp.Load_Firends_backUp();
			Config_World_Histoy.Instance = Config_World_Histoy.Load();
			Config_Seen_AVIS.Instance = Config_Seen_AVIS.Load_AVIS_SEEN();
			Config_AVI_FAVE.Instance = Config_AVI_FAVE.Load_AVIS_FAVE();
			this.DoAfterUiManagerInit();
			ClassInjector.RegisterTypeInIl2Cpp<ActionListenerLNC_>();
			ClassInjector.RegisterTypeInIl2Cpp<Test69>();
			ClassInjector.RegisterTypeInIl2Cpp<Enderpearl>();
			ClassInjector.RegisterTypeInIl2Cpp<PickUpBoom>();
			ClassInjector.RegisterTypeInIl2Cpp<QmFreeze>();
			ClassInjector.RegisterTypeInIl2Cpp<NamePlate>();
			ClassInjector.RegisterTypeInIl2Cpp<PlayerSel>();
			ClassInjector.RegisterTypeInIl2Cpp<BigMenuBeh>();
			ClassInjector.RegisterTypeInIl2Cpp<stayoffnigga>();
			ClassInjector.RegisterTypeInIl2Cpp<MoveMentV2>();
			try
			{
				new gPatch("ONPlayerJoin_", typeof(NetworkManager).GetMethod("Method_Public_Void_Player_0"), Patches.GetLocalPatch("onJoin"), null).AttemptPatch();
				new gPatch("ONPlayerLeft_", typeof(NetworkManager).GetMethod("Method_Public_Void_Player_1"), Patches.GetLocalPatch("onLeft"), null).AttemptPatch();
				new gPatch("ONENTERPORT", typeof(PortalTrigger).GetMethod("OnTriggerEnter"), Patches.GetLocalPatch("Enterportal"), null).AttemptPatch();
				new gPatch("InstanCatch", typeof(Networking).GetMethod("Instantiate"), Patches.GetLocalPatch("Instant"), null).AttemptPatch();
				new gPatch("spamPort", typeof(PortalTrigger).GetMethod("Awake"), Patches.GetLocalPatch("portalSpawn"), null).AttemptPatch();
				new gPatch("UIconf", typeof(VRCUiManager).GetMethod(Patches.PlaceUI().Name), Patches.GetLocalPatch("comfyMenu"), null).AttemptPatch();
				new gPatch("bruhdsdfr", typeof(VRC_EventDispatcherRFC).GetMethod("Method_Public_Void_Player_VrcEvent_VrcBroadcastType_Int32_Single_0"), Patches.GetLocalPatch("EventPatch"), null).AttemptPatch();
				new gPatch("dsuiorjiopeksjk", typeof(LoadBalancingClient).GetMethod("OnEvent"), Patches.GetLocalPatch("photonevents"), null).AttemptPatch();
				new gPatch("NJFNKLGSTKDL", typeof(LoadBalancingClient).GetMethod("Method_Public_Virtual_New_Boolean_Byte_Object_RaiseEventOptions_SendOptions_0"), Patches.GetLocalPatch("OpRaiseEventPrefix"), null).AttemptPatch();
				new gPatch("djsdksaideopklkop", typeof(VRC_EventHandler).GetMethod("InternalTriggerEvent"), Patches.GetLocalPatch("Triggeruwu"), null).AttemptPatch();
				new gPatch("budsnkldsjdioe", typeof(Analytics).GetMethod("Update"), Patches.GetLocalPatch("ReturnFalse"), null).AttemptPatch();
				new gPatch("dnjeudmkp", typeof(Analytics).GetMethod("Start"), Patches.GetLocalPatch("ReturnFalse"), null).AttemptPatch();
				new gPatch("fnjoisdml", typeof(Analytics).GetMethod("OnEnable"), Patches.GetLocalPatch("ReturnFalse"), null).AttemptPatch();
				new gPatch("djnuejos", typeof(AmplitudeWrapper).GetMethod("UpdateServer"), Patches.GetLocalPatch("ReturnFalse"), null).AttemptPatch();
				new gPatch("mkdioa", typeof(AmplitudeWrapper).GetMethod("UpdateServerDelayed"), Patches.GetLocalPatch("ReturnFalse"), null).AttemptPatch();
				Late_Night.Instance.Patch(AccessTools.Property(typeof(Time), "smoothDeltaTime").GetMethod, null, Patches.GetLocalPatch("FakeFrame"), null, null, null);
				Late_Night.Instance2.Patch(AccessTools.Property(typeof(PhotonPeer), "RoundTripTime").GetMethod, null, Patches.GetLocalPatch("FakePing"), null, null, null);
				Late_Night.Instance3.Patch(AccessTools.Method(typeof(LoadBalancingClient), "Method_Public_Virtual_New_Boolean_Byte_Object_RaiseEventOptions_SendOptions_0", null, null), Patches.GetLocalPatch("OpRaiseEv"), null, null, null, null);
				bool gb_Spine = Config.Instance.GB_Spine;
				if (gb_Spine)
				{
					Late_Night.Instance4.Patch(AccessTools.Property(typeof(Tools), "Platform").GetMethod, null, Patches.GetLocalPatch("QSpoof"), null, null, null);
					MelonCoroutines.Start(Late_Night.UnPatchTheQuest());
				}
				Late_Night.Instance5.Patch(AccessTools.Method(typeof(API), "SendRequest", null, null), Patches.GetLocalPatch("MsgApi"), null, null, null, null);
				(from m in typeof(VRCAvatarManager).GetMethods()
				where m.Name.StartsWith("Method_Private_Boolean_ApiAvatar_GameObject_")
				select m).ToList<MethodInfo>().ForEach(delegate(MethodInfo m)
				{
					new gPatch("AvaLoadType2", typeof(VRCAvatarManager).GetMethod(m.Name), Patches.GetLocalPatch("AviLoadType2"), null).AttemptPatch();
				});
				(from m in typeof(VRCPlayer).GetMethods()
				where m.Name.StartsWith("Method_Private_Void_GameObject_VRC_AvatarDescriptor_Boolean_")
				select m).ToList<MethodInfo>().ForEach(delegate(MethodInfo m)
				{
					new gPatch("AvaLoad", typeof(VRCPlayer).GetMethod(m.Name), Patches.GetLocalPatch("AvaLoaded"), null).AttemptPatch();
				});
				(from m in typeof(AssetManagement).GetMethods()
				where m.Name.StartsWith("Method_Public_Static_Object_Object_Boolean_Boolean_Boolean_0")
				select m).ToList<MethodInfo>().ForEach(delegate(MethodInfo m)
				{
					new gPatch("BunnbleLoad", typeof(AssetManagement).GetMethod(m.Name), Patches.GetLocalPatch("OnAvatarAssetBundleLoad"), null).AttemptPatch();
				});
			}
			catch (Exception ex)
			{
				LNCcolnsole.Log(string.Concat(new string[]
				{
					"Error in patch! - ",
					ex.Message,
					" From:pach ",
					ex.Source,
					" - Stack:pack ",
					ex.StackTrace
				}), false, ConsoleColor.White);
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000966C File Offset: 0x0000786C
		public void ONUUI()
		{
			Late_Night.Main = new QMCategory("Late Night V4", null);
			QMNestedButton qmnestedButton = Late_Night.Main.AddMenuPage("Late Night V4", "Late Night V4", "Late Night V4", false, null);
			Late_Night.next = Late_Night.Main.AddButton("<<< Back", "Media", delegate
			{
				MediaControl.PrevTrack();
			}, null);
			Late_Night.Play = Late_Night.Main.AddButton("Play/Pause", "Media", delegate
			{
				MediaControl.PlayPause();
			}, null);
			Late_Night.Back = Late_Night.Main.AddButton("Next >>>", "Media", delegate
			{
				MediaControl.NextTrack();
			}, null);
			Late_Night.fly = Late_Night.Main.AddToggle("Noclip", "Noclip", delegate(bool B)
			{
				Late_Night_V3.Modules_Movement.Movement.TogNoClip.Toggle(B, true, false);
			}, false);
			Late_Night.speedbut = Late_Night.Main.AddToggle("Speed", "Speed", delegate(bool B)
			{
				Late_Night_V3.Modules_Movement.Movement.TogSpeed.Toggle(B, true, false);
			}, false);
			Late_Night.Jump = Late_Night.Main.AddToggle("Jump", "Jump", delegate(bool B)
			{
				Late_Night_V3.Modules_Movement.Movement.TogJump.Toggle(B, true, false);
			}, false);
			Late_Night.fly.GameObject.SetActive(!Config.Instance.QuickMediaOrMove);
			Late_Night.speedbut.GameObject.SetActive(!Config.Instance.QuickMediaOrMove);
			Late_Night.Jump.GameObject.SetActive(!Config.Instance.QuickMediaOrMove);
			Late_Night.next.GameObject.SetActive(Config.Instance.QuickMediaOrMove);
			Late_Night.Play.GameObject.SetActive(Config.Instance.QuickMediaOrMove);
			Late_Night.Back.GameObject.SetActive(Config.Instance.QuickMediaOrMove);
			QMNestedButton submenu = qmnestedButton.AddMenuPage("Movement", "Movement", "Movement", false, null);
			QMNestedButton qmnestedButton2 = qmnestedButton.AddMenuPage("Player", "Player", "Player", false, null);
			QMNestedButton submenu2 = qmnestedButton.AddMenuPage("World", "World", "World", false, null);
			QMNestedButton qmnestedButton3 = qmnestedButton.AddMenuPage("Funny", "Funny", "John Cena saying boobies.", false, null);
			QMNestedButton qmnestedButton4 = qmnestedButton.AddMenuPage("Base Game", "Base Game", "Base Game", false, null);
			QMNestedButton qmnestedButton5 = qmnestedButton.AddMenuPage("Safety", "Safety", "Safety", false, null);
			QMNestedButton submenu3 = qmnestedButton.AddMenuPage("Media", "Media", "Media", false, null);
			QMNestedButton submenu4 = qmnestedButton.AddMenuPage("Settings", "Settings", "Settings", false, null);
			QMNestedButton qmnestedButton6 = qmnestedButton4.AddMenuPage("Portable Mirror", "Mirror", "Mirror", false, null);
			QMNestedButton qmnestedButton7 = qmnestedButton4.AddMenuPage("UI", "UI", "UI", false, null);
			QMNestedButton qmnestedButton8 = qmnestedButton5.AddMenuPage("Spoofer", "Spoofer", "Spoofer", false, null);
			Funny.Funny_menu(qmnestedButton3);
			Late_Night_V3.Modules_Movement.Movement.Movement_menu(submenu);
			Player.Player_menu(qmnestedButton2);
			QOL.QOL_menu(qmnestedButton4, qmnestedButton7);
			Safety.Safety_menu(qmnestedButton5);
			Settings.Settings_menu(submenu4);
			Wolds.Wolds_menu(submenu2);
			QOL.Media_menu(submenu3);
			qmnestedButton2.AddToggle("Immobilize Player", "We Got This Method Form : Nirv-git - ImmobilizePlayerMod", delegate(bool B)
			{
				VRCPlayer.field_Internal_Static_VRCPlayer_0.Method_Public_get_VRCPlayerApi_0().Immobilize(B);
			}, false);
			qmnestedButton4.AddToggle("Min Clipping", "erp its in the game ", delegate(bool B)
			{
				Config.Instance.min_clip = B;
				Config.Instance.SaveConfig();
				this.ChangeNearClipPlane(Config.Instance.min_clip ? 0.001f : 0.03f);
			}, Config.Instance.min_clip);
			qmnestedButton4.AddToggle("Max Far Clipping", "erp its in the game UWU", delegate(bool B)
			{
				Config.Instance.far_clip = B;
				Config.Instance.SaveConfig();
				this.ChangeFARClipPlane(Config.Instance.far_clip ? short.MaxValue : 1000);
			}, Config.Instance.far_clip);
			qmnestedButton3.AddButton("Enderpearl", "Enderpearl", delegate
			{
				this.Endermake();
			}, null);
			qmnestedButton3.AddButton("Pick-Up boom", "Pick-Up boom", delegate
			{
				this.BoomMaker();
			}, null);
			qmnestedButton3.AddToggle("Ghost Mode", "makes you look stuck to others", delegate(bool B)
			{
				Late_Night.Ghoats = B;
				this.Cubemake(Late_Night.Ghoats);
			}, Late_Night.Ghoats);
			qmnestedButton3.AddToggle("World Triggers\n(SDK2 ONLY)", "Ass hole", delegate(bool B)
			{
				Config.Instance.Woldtrig = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.Woldtrig);
			qmnestedButton3.AddToggle("Left Head pat\n(Desktop only)", "Head Pats are great", delegate(bool B)
			{
				this.HeadpatMODELEFT = B;
			}, this.HeadpatMODELEFT);
			qmnestedButton3.AddToggle("Right Head pat\n(Desktop only)", "Head Pats are great", delegate(bool B)
			{
				this.HeadpatMODERIGHT = B;
			}, this.HeadpatMODERIGHT);
			qmnestedButton6.AddButton("Spawn Mirror", "Spawn Mirror", delegate
			{
				this.Mirromake();
			}, null);
			qmnestedButton6.AddToggle("Otp", "Otp", delegate(bool B)
			{
				this.OptOrNah = B;
				bool flag2 = this.Mirro != null && this.Mirro.GetComponent<VRC_MirrorReflection>() != null;
				if (flag2)
				{
					VRC_MirrorReflection component2 = this.Mirro.GetComponent<VRC_MirrorReflection>();
					LayerMask reflectLayers = default(LayerMask);
					reflectLayers.value = (this.OptOrNah ? 263680 : -1025);
					component2.m_ReflectLayers = reflectLayers;
				}
			}, this.OptOrNah);
			qmnestedButton6.AddToggle("PickUp", "PickUp", delegate(bool B)
			{
				this.PickUpabl = B;
				bool flag2 = this.Mirro != null && this.Mirro.GetComponent<VRC_Pickup>() != null;
				if (flag2)
				{
					this.Mirro.GetComponent<VRC_Pickup>().pickupable = this.PickUpabl;
				}
			}, this.PickUpabl);
			qmnestedButton6.AddToggle("Stick To Me", "Stick To Me", delegate(bool B)
			{
				this.StickTo = B;
				bool flag2 = this.Mirro != null;
				if (flag2)
				{
					this.Mirro.gameObject.transform.parent = (this.StickTo ? Funny.GetLocalPlayer().transform : null);
				}
			}, this.StickTo);
			qmnestedButton6.AddButton("Size X+", "Size X", delegate
			{
				this.sizeX += 0.1f;
				bool flag2 = this.Mirro != null && this.Mirro.GetComponent<Transform>() != null;
				if (flag2)
				{
					this.Mirro.GetComponent<Transform>().localScale = new Vector3(this.sizeX, this.sizeY, 0f);
				}
			}, null);
			qmnestedButton6.AddButton("Size X-", "Size X", delegate
			{
				this.sizeX -= 0.1f;
				bool flag2 = this.Mirro != null && this.Mirro.GetComponent<Transform>() != null;
				if (flag2)
				{
					this.Mirro.GetComponent<Transform>().localScale = new Vector3(this.sizeX, this.sizeY, 0f);
				}
			}, null);
			qmnestedButton6.AddButton("Size Z+", "Size Z", delegate
			{
				this.sizeY += 0.1f;
				bool flag2 = this.Mirro != null && this.Mirro.GetComponent<Transform>() != null;
				if (flag2)
				{
					this.Mirro.GetComponent<Transform>().localScale = new Vector3(this.sizeX, this.sizeY, 0f);
				}
			}, null);
			qmnestedButton6.AddButton("Size Z-", "Size Z", delegate
			{
				this.sizeY -= 0.1f;
				bool flag2 = this.Mirro != null && this.Mirro.GetComponent<Transform>() != null;
				if (flag2)
				{
					this.Mirro.GetComponent<Transform>().localScale = new Vector3(this.sizeX, this.sizeY, 0f);
				}
			}, null);
			qmnestedButton6.AddButton("Size Reset", "Size Reset", delegate
			{
				Vector3 position = PlayerWrapper.GetCurrentPlayer().transform.position + new Vector3(0f, 0.65f, 0f);
				this.sizeX = 1f;
				this.sizeY = 1f;
				bool flag2 = this.Mirro != null && this.Mirro.GetComponent<Transform>() != null;
				if (flag2)
				{
					this.Mirro.GetComponent<Transform>().localScale = new Vector3(this.sizeX, this.sizeY, 0f);
				}
				bool flag3 = this.Mirro != null && this.Mirro.GetComponent<Transform>() != null;
				if (flag3)
				{
					this.Mirro.GetComponent<Transform>().transform.position = position;
				}
			}, null);
			qmnestedButton7.AddToggle("Custom Loading Music", "Custom Loading Music", delegate(bool B)
			{
				if (B)
				{
					bool flag2 = Config.Instance.LoadIng_Audio != "";
					if (flag2)
					{
						bool flag3 = File.Exists(Config.Instance.LoadIng_Audio);
						if (flag3)
						{
							Config.Instance.LoadIng_Audio_Enabled = true;
							Config.Instance.SaveConfig();
							AudioSource component2 = GameObject.Find("UserInterface/MenuContent/Popups/LoadingPopup/LoadingSound").GetComponent<AudioSource>();
							Move_vrc_ui.StartMus(component2, Config.Instance.LoadIng_Audio);
						}
						else
						{
							LNCcolnsole.ERROR("Path File Not Foun Please Toggle this again to try again", false, ConsoleColor.Red);
							VRCUiManager.Method_Internal_Static_get_VRCUiManager_PDM_0().QueHudMessage("<color=red>Path not found</color>");
						}
					}
					else
					{
						LNCcolnsole.ERROR("Path File Not Foun Please Toggle this again to try again", false, ConsoleColor.Red);
						VRCUiManager.Method_Internal_Static_get_VRCUiManager_PDM_0().QueHudMessage("<color=red>Please set  a path</color>");
					}
				}
				else
				{
					Config.Instance.LoadIng_Audio_Enabled = false;
					Config.Instance.SaveConfig();
					VRCUiManager.Method_Internal_Static_get_VRCUiManager_PDM_0().QueHudMessage("<color=red>Restart please</color>");
				}
			}, Config.Instance.LoadIng_Audio_Enabled);
			qmnestedButton7.AddButton("Set Custom Loading Music", "Set Custom Loading Music", delegate
			{
				Popups.PopupCall("Set Audio Path", "Enter", "Ex:D:/ECT./Late_night_V3/SONG.ogg ", false, delegate(string text)
				{
					bool flag2 = text == "";
					if (!flag2)
					{
						text = text.Replace("\"", "");
						bool flag3 = File.Exists(text);
						if (flag3)
						{
							Config.Instance.LoadIng_Audio = text;
							Config.Instance.SaveConfig();
						}
						else
						{
							LNCcolnsole.ERROR("Path File Not Found Please try again", false, ConsoleColor.Red);
						}
					}
				}, null);
			}, null);
			qmnestedButton7.AddToggle("Loading Music", "Loading Music", delegate(bool B)
			{
				Config.Instance.LoadIng_Music_off = B;
				Config.Instance.SaveConfig();
				GameObject.Find("UserInterface/MenuContent/Popups/LoadingPopup/LoadingSound").SetActive(Config.Instance.LoadIng_Music_off);
			}, Config.Instance.LoadIng_Music_off);
			qmnestedButton2.AddButton("Save Friends List", "Save Friends List", delegate
			{
				Utils.VRCUiPopupManager.Alert("Save Friends?", "This will take a bit", "Yes", delegate()
				{
					Config_Firends_backUp.Instance.firends.Clear();
					MelonCoroutines.Start(PlayerWrapper.savefirends(0.5f));
					Utils.VRCUiPopupManager.HideCurrentPopUp();
				}, "No", delegate()
				{
					Utils.VRCUiPopupManager.HideCurrentPopUp();
				}, null);
			}, null);
			qmnestedButton2.AddButton("Friend Saved List", "Friend Saved List", delegate
			{
				Utils.VRCUiPopupManager.Alert("Re-Friend Save Friends list?", "THIS IS PAINFULLY SLOW SO YOU WONT GET BANNED", "Yes", delegate()
				{
					MelonCoroutines.Start(PlayerWrapper.REfirend(30f));
					Utils.VRCUiPopupManager.HideCurrentPopUp();
				}, "No", delegate()
				{
					Utils.VRCUiPopupManager.HideCurrentPopUp();
				}, null);
			}, null);
			bool isPresent = XRDevice.isPresent;
			if (isPresent)
			{
				this.harmony = new HarmonyInstance("LateNightGest");
				foreach (MethodInfo methodInfo in typeof(ActionMenuOpener).GetMethods(BindingFlags.Instance | BindingFlags.Public))
				{
					bool flag = methodInfo.Name.Contains("Method_Public_Void_Boolean");
					if (flag)
					{
						this.harmony.Patch(methodInfo, new HarmonyMethod(typeof(Late_Night).GetMethod("OnActionMenuOpen", BindingFlags.Static | BindingFlags.Public)), null, null);
					}
				}
			}
			AudioSource component = GameObject.Find("UserInterface/MenuContent/Popups/LoadingPopup/LoadingSound").GetComponent<AudioSource>();
			Move_vrc_ui.StartMus(component, Config.Instance.LoadIng_Audio);
			GameObject.Find("UserInterface/MenuContent/Popups/LoadingPopup/LoadingSound").SetActive(Config.Instance.LoadIng_Music_off);
			qmnestedButton8.AddToggle("Ping", "Ping", delegate(bool B)
			{
				Config.Instance.FakePing = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.FakePing);
			qmnestedButton8.AddButton("Ping+", "Ping Spoof", delegate
			{
				Config.Instance.setFakePingto = Config.Instance.setFakePingto + 1;
				Config.Instance.SaveConfig();
			}, null);
			qmnestedButton8.AddButton("Ping-", "Ping spoof", delegate
			{
				Config.Instance.setFakePingto = Config.Instance.setFakePingto - 1;
				Config.Instance.SaveConfig();
			}, null);
			qmnestedButton8.AddButton("Ping Reset", "Ping Reset", delegate
			{
				Config.Instance.setFakePingto = 10;
				Config.Instance.SaveConfig();
			}, null);
			qmnestedButton8.AddToggle("FPS", "FPS", delegate(bool B)
			{
				Config.Instance.FakeFPS = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.FakePing);
			qmnestedButton8.AddButton("FPS+", "FPS Spoof", delegate
			{
				Config.Instance.setFakeFPSto = Config.Instance.setFakeFPSto + 1f;
				Config.Instance.SaveConfig();
			}, null);
			qmnestedButton8.AddButton("FPS-", "FPS spoof", delegate
			{
				Config.Instance.setFakeFPSto = Config.Instance.setFakeFPSto - 1f;
				Config.Instance.SaveConfig();
			}, null);
			qmnestedButton8.AddButton("FPS Reset", "FPS Reset", delegate
			{
				Config.Instance.setFakeFPSto = 90f;
				Config.Instance.SaveConfig();
			}, null);
			qmnestedButton8.AddToggle("Quest", "bruh", delegate(bool B)
			{
				Config.Instance.GB_Spine = B;
				Config.Instance.SaveConfig();
				LNCcolnsole.Log("Restart to get this to work", true, ConsoleColor.White);
			}, Config.Instance.GB_Spine);
			qmnestedButton8.AddToggle("Offline", "Offline will take a few min to start working", delegate(bool B)
			{
				Config.Instance.GB_line = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.GB_line);
			GameObject gameObject = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Right/Button");
			Late_Night.ListText = new MenuText(gameObject.transform, 200f, 440f, 1000f, 1000f, "Loading...", 257, 30);
			gameObject.AddComponent<PlayerSel>();
			Late_Night.ListText.menuTitle.SetActive(Config.Instance.InfoList);
			GameObject gameObject2 = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMNotificationsArea/DebugInfoPanel");
			Late_Night.clock = new MenuText(gameObject2.transform, 700f, 250f, 500f, 500f, "<color=#ffdd00>" + DateTime.Now.ToString("h:mm:ss tt") + "</color>", 257, 30);
			Late_Night.clock.menuTitle.SetActive(Config.Instance.Clock);
			Late_Night.LNCINFOVS = new MenuText(gameObject2.transform, 650f, 300f, 500f, 500f, "<color=#ffdd00>Late Night : V4.1.0.0</color>", 257, 30);
			Late_Night.LNCINFOVS.menuTitle.SetActive(Config.Instance.LNCinfo);
			AviFave.startAvis();
			BugMenuShit.Menu_shit_for_rori();
			Move_vrc_ui.MoveSmallUI();
			Late_Night.UIdone = true;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000A1A8 File Offset: 0x000083A8
		public void ONUUIUSERCREATE()
		{
			GameObject gameObject = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_SelectedUser_Local/ScrollRect/Viewport/VerticalLayoutGroup");
			Late_Night.USerUtills = new QMCategory("Late Night V4", gameObject.transform);
			QMNestedButton qmnestedButton = Late_Night.USerUtills.AddMenuPage("UserUtils", "User Utils", "User Utils", false, null);
			QMNestedButton qmnestedButton2 = Late_Night.USerUtills.AddMenuPage("Target ops.", "Target", "Target", false, null);
			UserUtils.UserUtils_menu(qmnestedButton, Late_Night.USerUtills);
			qmnestedButton2.AddButton("Set as Target", "Set as Target", delegate
			{
				bool flag = PlayerWrapper.GetSelectedPlayer(false) == null;
				if (!flag)
				{
					bool flag2 = PlayerWrapper.GetSelectedPlayer(false).Method_Internal_get_APIUser_0().UserID() != PlayerWrapper.GetCurrentPlayer().UserID();
					if (flag2)
					{
						this.Target = PlayerWrapper.GetSelectedPlayer(false);
					}
				}
			}, null);
			QMNestedButton qmnestedButton3 = qmnestedButton2.AddMenuPage("Sit on", "Sit On", "Sit On", false, null);
			qmnestedButton2.AddToggle("Leash", "Leash", delegate(bool B)
			{
				bool flag = this.Target != null;
				if (flag)
				{
					this.leash = B;
				}
			}, this.Target);
			qmnestedButton2.AddButton("Leash Force+", "Leash Force", delegate
			{
				this.MOveToSpeed += 1f;
			}, null);
			qmnestedButton2.AddButton("Leash Force-", "Leash Force", delegate
			{
				this.MOveToSpeed -= 1f;
			}, null);
			qmnestedButton2.AddButton("Leash Dist+", "Leash Dist", delegate
			{
				this.disten += 0.5f;
			}, null);
			qmnestedButton2.AddButton("Leash Dist-", "Leash Dist", delegate
			{
				this.disten -= 0.5f;
			}, null);
			qmnestedButton2.AddButton("Leash Reset", "Leash Reset", delegate
			{
				this.disten = 2f;
				this.MOveToSpeed = 9f;
			}, null);
			qmnestedButton2.AddButton("Orbit Player", "Player Orbit", delegate
			{
				bool flag = this.Target == null;
				if (!flag)
				{
					this.orbitPlayer = true;
					PlayerWrapper.GetCurrentPlayer().gameObject.transform.position = this.Target.Method_Internal_get_VRCPlayer_0().field_Internal_GameObject_0.transform.position + new Vector3(this.OrbitDist, 0f, 0f);
					Late_Night_V3.Modules_Movement.Movement.GetCurentBehaviour().FlyNoClip(true, true);
				}
			}, null);
			qmnestedButton2.AddButton("Orb Speed+", "Orb Speed", delegate
			{
				this.OrbitSpeed += 10f;
			}, null);
			qmnestedButton2.AddButton("Orb Speed-", "Orb Speed", delegate
			{
				this.OrbitSpeed -= 10f;
			}, null);
			qmnestedButton2.AddButton("Orb Dist+", "Orb Dist", delegate
			{
				this.OrbitDist += 0.1f;
				bool flag = this.orbitPlayer;
				if (flag)
				{
					PlayerWrapper.GetCurrentPlayer().gameObject.transform.position = this.Target.Method_Internal_get_VRCPlayer_0().field_Internal_GameObject_0.transform.position + new Vector3(this.OrbitDist, 0f, 0f);
				}
			}, null);
			qmnestedButton2.AddButton("Orb Dist-", "Orb Dist", delegate
			{
				this.OrbitDist -= 0.1f;
				bool flag = this.orbitPlayer;
				if (flag)
				{
					PlayerWrapper.GetCurrentPlayer().gameObject.transform.position = this.Target.Method_Internal_get_VRCPlayer_0().field_Internal_GameObject_0.transform.position + new Vector3(this.OrbitDist, 0f, 0f);
				}
			}, null);
			qmnestedButton2.AddButton("Orb Reset", "Orb Reset", delegate
			{
				this.OrbitDist = 2f;
				this.OrbitSpeed = 50f;
				bool flag = this.Target == null;
				if (!flag)
				{
					bool flag2 = this.orbitPlayer;
					if (flag2)
					{
						PlayerWrapper.GetCurrentPlayer().gameObject.transform.position = this.Target.Method_Internal_get_VRCPlayer_0().field_Internal_GameObject_0.transform.position + new Vector3(this.OrbitDist, 0f, 0f);
					}
				}
			}, null);
			qmnestedButton3.AddButton("Sit on Head", "Sit on Head", delegate
			{
				bool flag = this.Target == null;
				if (!flag)
				{
					this.SitonHead = true;
					Late_Night_V3.Modules_Movement.Movement.GetCurentBehaviour().FlyNoClip(true, true);
				}
			}, null);
			qmnestedButton3.AddButton("Sit on shoulder(L)", "Sit on shoulder(L)", delegate
			{
				bool flag = this.Target == null;
				if (!flag)
				{
					this.SitonLeftshoulder = true;
					Late_Night_V3.Modules_Movement.Movement.GetCurentBehaviour().FlyNoClip(true, true);
				}
			}, null);
			qmnestedButton3.AddButton("Sit on shoulder(R)", "Sit on shoulder(R)", delegate
			{
				bool flag = this.Target == null;
				if (!flag)
				{
					this.SitonRightshoulder = true;
					Late_Night_V3.Modules_Movement.Movement.GetCurentBehaviour().FlyNoClip(true, true);
				}
			}, null);
			qmnestedButton3.AddButton("sit on Hand(L)", "Sit on Hand(L)", delegate
			{
				bool flag = this.Target == null;
				if (!flag)
				{
					this.SitonLeftHand = true;
					Late_Night_V3.Modules_Movement.Movement.GetCurentBehaviour().FlyNoClip(true, true);
				}
			}, null);
			qmnestedButton3.AddButton("sit on Hand(R)", "sit on Hand(R)", delegate
			{
				bool flag = this.Target == null;
				if (!flag)
				{
					this.SitonRightHand = true;
					Late_Night_V3.Modules_Movement.Movement.GetCurentBehaviour().FlyNoClip(true, true);
				}
			}, null);
			qmnestedButton3.AddButton("sit on Knee(L)", "sit on Knee(L)", delegate
			{
				bool flag = this.Target == null;
				if (!flag)
				{
					this.SitonLeftknee = true;
					Late_Night_V3.Modules_Movement.Movement.GetCurentBehaviour().FlyNoClip(true, true);
				}
			}, null);
			qmnestedButton3.AddButton("sit on Knee(R)", "sit on Knee(R)", delegate
			{
				bool flag = this.Target == null;
				if (!flag)
				{
					this.SitonRightknee = true;
					Late_Night_V3.Modules_Movement.Movement.GetCurentBehaviour().FlyNoClip(true, true);
				}
			}, null);
			qmnestedButton3.AddButton("sit on Feet(L)", "sit on Feet(L)", delegate
			{
				bool flag = this.Target == null;
				if (!flag)
				{
					this.SitonLeftfeet = true;
					Late_Night_V3.Modules_Movement.Movement.GetCurentBehaviour().FlyNoClip(true, true);
				}
			}, null);
			qmnestedButton3.AddButton("sit on Feet(R)", "sit on Feet(R)", delegate
			{
				bool flag = this.Target == null;
				if (!flag)
				{
					this.SitonRightfeet = true;
					Late_Night_V3.Modules_Movement.Movement.GetCurentBehaviour().FlyNoClip(true, true);
				}
			}, null);
			qmnestedButton2.AddButton("bring pickups To target", "bring pickups To target", delegate
			{
				bool flag = this.Target == null;
				if (!flag)
				{
					Funny.bringpickupsTOPLAYER(this.Target);
					LNCcolnsole.Log("bring-ing all pickups to : " + this.Target.DisplayName(), false, ConsoleColor.White);
				}
			}, null);
			QMNestedButton qmnestedButton4 = qmnestedButton.AddMenuPage("World Hax", "World Hax_", "fuck ur world", null);
			QMNestedButton qmnestedButton5 = qmnestedButton4.AddMenuPage("Murder 4\n user hax", "Murder World Hax", "Murder 4", null);
			qmnestedButton5.AddButton("Make Murder", "Murder", delegate
			{
				bool flag = PlayerWrapper.GetSelectedPlayer(false) == null;
				if (!flag)
				{
					murder.SetPlayerM(PlayerWrapper.GetSelectedPlayer(false));
				}
			}, null);
			qmnestedButton5.AddButton("Make Detective", "Detective", delegate
			{
				bool flag = PlayerWrapper.GetSelectedPlayer(false) == null;
				if (!flag)
				{
					murder.SetPlayerD(PlayerWrapper.GetSelectedPlayer(false));
				}
			}, null);
			qmnestedButton5.AddButton("Make Bystander", "Bystander", delegate
			{
				bool flag = PlayerWrapper.GetSelectedPlayer(false) == null;
				if (!flag)
				{
					murder.SetPlayerB(PlayerWrapper.GetSelectedPlayer(false));
				}
			}, null);
			qmnestedButton5.AddButton("Kill player", "Kill this player", delegate
			{
				bool flag = PlayerWrapper.GetSelectedPlayer(false) == null;
				if (!flag)
				{
					murder.Killplayer(PlayerWrapper.GetSelectedPlayer(false));
				}
			}, null);
			QMNestedButton qmnestedButton6 = qmnestedButton4.AddMenuPage("Among Us\n hax", "Among Us World Hax", "Among sus", null);
			qmnestedButton6.AddButton("Make Imposter", "Imposter", delegate
			{
				bool flag = PlayerWrapper.GetSelectedPlayer(false) == null;
				if (!flag)
				{
					Amungus.SetPlayerI(PlayerWrapper.GetSelectedPlayer(false));
				}
			}, null);
			qmnestedButton6.AddButton("Make Crew", "Crew", delegate
			{
				bool flag = PlayerWrapper.GetSelectedPlayer(false) == null;
				if (!flag)
				{
					Amungus.SetPlayerC(PlayerWrapper.GetSelectedPlayer(false));
				}
			}, null);
			qmnestedButton6.AddButton("Kill player", "Kill this player", delegate
			{
				bool flag = PlayerWrapper.GetSelectedPlayer(false) == null;
				if (!flag)
				{
					Amungus.Killplayer(PlayerWrapper.GetSelectedPlayer(false));
				}
			}, null);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000A696 File Offset: 0x00008896
		protected void DoAfterUiManagerInit()
		{
			MelonCoroutines.Start(this.OnVRCUI());
			MelonCoroutines.Start(this.ONUUIUSER());
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000A6B1 File Offset: 0x000088B1
		public IEnumerator OnVRCUI()
		{
			while (GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)") == null)
			{
				yield return null;
			}
			this.ONUUI();
			yield return null;
			yield break;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000A6C0 File Offset: 0x000088C0
		public IEnumerator ONUUIUSER()
		{
			while (GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_SelectedUser_Local/ScrollRect/Viewport/VerticalLayoutGroup") == null)
			{
				yield return null;
			}
			this.ONUUIUSERCREATE();
			yield return null;
			yield break;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000A6D0 File Offset: 0x000088D0
		public static bool OnActionMenuOpen(bool __0, ref ActionMenuOpener __instance)
		{
			bool flag = (!Config.Instance.rightHandSetting || !__instance.name.Equals("MenuR")) && (!Config.Instance.leftHandSetting || !__instance.name.Equals("MenuL"));
			bool result;
			if (flag)
			{
				result = true;
			}
			else
			{
				if (__0)
				{
					HandGestureController.Method_Public_Static_Void_Boolean_PDM_0(!HandGestureController.Method_Public_Static_Boolean_PDM_0());
				}
				else
				{
					HandGestureController.Method_Public_Static_Void_Boolean_PDM_0(__0);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000A750 File Offset: 0x00008950
		internal static GameObject GetLocalPlayerCamera()
		{
			return GameObject.Find("Camera (eye)");
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000A76C File Offset: 0x0000896C
		public override void OnUpdate()
		{
			this.time += Time.deltaTime;
			bool flag = this.time > 0.5f;
			if (flag)
			{
				try
				{
					bool flag2 = RoomManager.Method_Public_Static_get_Boolean_3();
					if (flag2)
					{
						bool tig_esp = Wolds.tig_esp;
						if (tig_esp)
						{
							PlayerWrapper.TriggerESP(true);
						}
					}
				}
				catch (Exception ex)
				{
					LNCcolnsole.ERROR(string.Concat(new string[]
					{
						"Error in OnUpdate! - ",
						ex.Message,
						" From:world esp ",
						ex.Source,
						" - Stack:  ",
						ex.StackTrace
					}), false, ConsoleColor.Red);
				}
				try
				{
					bool flag3 = RoomManager.Method_Public_Static_get_Boolean_3();
					if (flag3)
					{
						bool item_esp = Wolds.item_esp;
						if (item_esp)
						{
							PlayerWrapper.PickupESP(true);
						}
					}
				}
				catch (Exception ex2)
				{
					LNCcolnsole.ERROR(string.Concat(new string[]
					{
						"Error in OnUpdate! - ",
						ex2.Message,
						" From:world esp ",
						ex2.Source,
						" - Stack:  ",
						ex2.StackTrace
					}), false, ConsoleColor.Red);
				}
				this.time = 0f;
			}
			StarLag.shitToUpdate();
			MIdNight.UpdateThis();
			PlayerWrapper.statusUpdate();
			try
			{
				bool keyDown = Input.GetKeyDown(279);
				if (keyDown)
				{
					bool restartkey = Config.Instance.Restartkey;
					if (restartkey)
					{
						Process.Start("vrchat.exe", Environment.CommandLine.ToString());
						Wrapper.Bruhmoment();
					}
				}
				bool flag4 = RoomManager.Method_Public_Static_get_Boolean_3();
				if (flag4)
				{
					bool keysbinding = Config.Instance.keysbinding;
					if (keysbinding)
					{
						bool flag5 = Input.GetKey(304) && Input.GetKeyDown(116);
						if (flag5)
						{
							bool ctozoom = Config.Instance.Ctozoom;
							if (ctozoom)
							{
								bool flag6 = Late_Night.GetLocalPlayerCamera().GetComponent<Camera>().fieldOfView == 20f;
								if (flag6)
								{
									Late_Night.GetLocalPlayerCamera().GetComponent<Camera>().fieldOfView = this.FOV;
									LNCcolnsole.Log("Zoom off", true, ConsoleColor.White);
								}
								else
								{
									Late_Night.GetLocalPlayerCamera().GetComponent<Camera>().fieldOfView = 20f;
									LNCcolnsole.Log("Zoom on", true, ConsoleColor.White);
								}
							}
						}
						bool flag7 = Input.GetKey(304) && Input.GetKeyDown(103);
						if (flag7)
						{
							Late_Night_V3.Modules_Movement.Movement.GetCurentBehaviour().FlyNoClip(!Late_Night_V3.Modules_Movement.Movement.GetCurentBehaviour().FlyG, !Late_Night_V3.Modules_Movement.Movement.GetCurentBehaviour().NoclipG);
						}
						bool flag8 = Input.GetKey(304) && Input.GetKeyDown(98);
						if (flag8)
						{
							Late_Night_V3.Modules_Movement.Movement.GetCurentBehaviour().Speeds(!Late_Night_V3.Modules_Movement.Movement.GetCurentBehaviour().SpeedG);
						}
						bool flag9 = Input.GetKey(304) && Input.GetKeyDown(121);
						if (flag9)
						{
							Late_Night_V3.Modules_Movement.Movement.GetCurentBehaviour().Jumps(!Late_Night_V3.Modules_Movement.Movement.GetCurentBehaviour().JumpG);
						}
						bool flag10 = Input.GetKey(304) && Input.GetKeyDown(110);
						if (flag10)
						{
							bool flag11 = !Config.Instance.ESPPlayer;
							if (flag11)
							{
								Config.Instance.ESPPlayer = true;
								LNCcolnsole.Log("ESP On", true, ConsoleColor.White);
								PlayerWrapper.ToggleESP(true);
							}
							else
							{
								Config.Instance.ESPPlayer = false;
								LNCcolnsole.Log("ESP Off", true, ConsoleColor.White);
								PlayerWrapper.ToggleESP(false);
							}
						}
						bool flag12 = Input.GetKey(304) && Input.GetKeyDown(325);
						if (flag12)
						{
							bool flag13 = !Late_Night.Ghoats;
							if (flag13)
							{
								Late_Night.Ghoats = true;
								LNCcolnsole.Log("Ghost Mode On", true, ConsoleColor.White);
								this.Cubemake(Late_Night.Ghoats);
							}
							else
							{
								Late_Night.Ghoats = false;
								LNCcolnsole.Log("Ghost Mode Off", true, ConsoleColor.White);
								this.Cubemake(Late_Night.Ghoats);
							}
						}
					}
				}
			}
			catch (Exception ex3)
			{
			}
			try
			{
				bool flag14 = RoomManager.Method_Public_Static_get_Boolean_3();
				if (flag14)
				{
					bool inf_jump = Config.Instance.Inf_jump;
					if (inf_jump)
					{
						bool flag15 = VRCInputManager.Method_Public_Static_VRCInput_String_0("Jump").Method_Public_get_Boolean_3() && !Networking.LocalPlayer.IsPlayerGrounded();
						if (flag15)
						{
							Vector3 velocity = Networking.LocalPlayer.GetVelocity();
							velocity.y = Networking.LocalPlayer.GetJumpImpulse();
							Networking.LocalPlayer.SetVelocity(velocity);
						}
					}
					bool rock_jump = Config.Instance.Rock_jump;
					if (rock_jump)
					{
						bool flag16 = VRCInputManager.Method_Public_Static_VRCInput_String_0("Jump").Method_Public_get_Single_0() == 1f;
						if (flag16)
						{
							Vector3 velocity2 = Networking.LocalPlayer.GetVelocity();
							velocity2.y = Networking.LocalPlayer.GetJumpImpulse();
							Networking.LocalPlayer.SetVelocity(velocity2);
						}
					}
				}
			}
			catch (Exception ex4)
			{
				LNCcolnsole.ERROR(string.Concat(new string[]
				{
					"Error in OnUpdate! - ",
					ex4.Message,
					" From:InfJump ",
					ex4.Source,
					" - Stack:InfJump ",
					ex4.StackTrace
				}), false, ConsoleColor.Red);
			}
			try
			{
				bool flag17 = !RoomManager.Method_Public_Static_get_Boolean_3();
				if (!flag17)
				{
					bool flag18 = this.Target != null;
					if (flag18)
					{
						bool flag19 = this.leash;
						if (flag19)
						{
							bool flag20 = Vector3.Distance(PlayerWrapper.GetCurrentPlayer().gameObject.transform.position, this.Target.Method_Internal_get_VRCPlayer_0().field_Internal_GameObject_0.transform.position) > this.disten;
							if (flag20)
							{
								PlayerWrapper.GetCurrentPlayer().gameObject.transform.position = Vector3.MoveTowards(PlayerWrapper.GetCurrentPlayer().gameObject.transform.position, this.Target.Method_Internal_get_VRCPlayer_0().field_Internal_GameObject_0.transform.position, this.MOveToSpeed * Time.fixedDeltaTime);
							}
							bool flag21 = Vector3.Distance(PlayerWrapper.GetCurrentPlayer().gameObject.transform.position, this.Target.Method_Internal_get_VRCPlayer_0().field_Internal_GameObject_0.transform.position) > this.disten + 2.5f;
							if (flag21)
							{
								PlayerWrapper.GetCurrentPlayer().gameObject.transform.position = this.Target.Method_Internal_get_VRCPlayer_0().field_Internal_GameObject_0.transform.position;
							}
						}
						bool flag22 = this.orbitPlayer;
						if (flag22)
						{
							bool flag23 = Vector3.Distance(PlayerWrapper.GetCurrentPlayer().gameObject.transform.position, this.Target.Method_Internal_get_VRCPlayer_0().field_Internal_GameObject_0.transform.position) > this.OrbitDist;
							if (flag23)
							{
								PlayerWrapper.GetCurrentPlayer().gameObject.transform.position = Vector3.MoveTowards(PlayerWrapper.GetCurrentPlayer().gameObject.transform.position, this.Target.Method_Internal_get_VRCPlayer_0().field_Internal_GameObject_0.transform.position, this.OrbitSpeed * Time.fixedDeltaTime);
							}
							PlayerWrapper.GetCurrentPlayer().gameObject.transform.RotateAround(this.Target.Method_Internal_get_VRCPlayer_0().field_Internal_GameObject_0.transform.position, Vector3.up, this.OrbitSpeed * Time.deltaTime);
						}
						bool sitonLeftHand = this.SitonLeftHand;
						if (sitonLeftHand)
						{
							PlayerWrapper.GetCurrentPlayer().gameObject.transform.position = this.Target.field_Private_VRCPlayerApi_0.GetBonePosition(17);
						}
						bool sitonRightHand = this.SitonRightHand;
						if (sitonRightHand)
						{
							PlayerWrapper.GetCurrentPlayer().gameObject.transform.position = this.Target.field_Private_VRCPlayerApi_0.GetBonePosition(18);
						}
						bool sitonHead = this.SitonHead;
						if (sitonHead)
						{
							PlayerWrapper.GetCurrentPlayer().gameObject.transform.position = this.Target.field_Private_VRCPlayerApi_0.GetBonePosition(10) + new Vector3(0f, 0.15f, 0f);
						}
						bool sitonRightshoulder = this.SitonRightshoulder;
						if (sitonRightshoulder)
						{
							PlayerWrapper.GetCurrentPlayer().gameObject.transform.position = this.Target.field_Private_VRCPlayerApi_0.GetBonePosition(12);
						}
						bool sitonLeftshoulder = this.SitonLeftshoulder;
						if (sitonLeftshoulder)
						{
							PlayerWrapper.GetCurrentPlayer().gameObject.transform.position = this.Target.field_Private_VRCPlayerApi_0.GetBonePosition(11);
						}
						bool sitonLeftknee = this.SitonLeftknee;
						if (sitonLeftknee)
						{
							PlayerWrapper.GetCurrentPlayer().gameObject.transform.position = this.Target.field_Private_VRCPlayerApi_0.GetBonePosition(3);
						}
						bool sitonRightknee = this.SitonRightknee;
						if (sitonRightknee)
						{
							PlayerWrapper.GetCurrentPlayer().gameObject.transform.position = this.Target.field_Private_VRCPlayerApi_0.GetBonePosition(4);
						}
						bool sitonRightfeet = this.SitonRightfeet;
						if (sitonRightfeet)
						{
							PlayerWrapper.GetCurrentPlayer().gameObject.transform.position = this.Target.field_Private_VRCPlayerApi_0.GetBonePosition(6);
						}
						bool sitonLeftfeet = this.SitonLeftfeet;
						if (sitonLeftfeet)
						{
							PlayerWrapper.GetCurrentPlayer().gameObject.transform.position = this.Target.field_Private_VRCPlayerApi_0.GetBonePosition(5);
						}
					}
					bool flag24 = this.SitonLeftHand || this.SitonRightHand || this.SitonHead || this.SitonLeftshoulder || this.SitonRightshoulder || this.SitonRightknee || this.SitonLeftknee || this.SitonRightfeet || this.SitonLeftfeet || this.orbitPlayer;
					if (flag24)
					{
						bool flag25 = VRCInputManager.Method_Public_Static_VRCInput_String_0("Jump").Method_Public_get_Boolean_3();
						if (flag25)
						{
							this.SitonLeftHand = false;
							this.SitonRightHand = false;
							this.SitonHead = false;
							this.SitonLeftshoulder = false;
							this.SitonRightshoulder = false;
							this.SitonRightknee = false;
							this.SitonLeftknee = false;
							this.SitonRightfeet = false;
							this.SitonLeftfeet = false;
							this.orbitPlayer = false;
							Late_Night_V3.Modules_Movement.Movement.GetCurentBehaviour().FlyNoClip(false, false);
						}
					}
					bool flag26 = this.HeadpatMODELEFT || (this.HeadpatMODERIGHT && !XRDevice.isPresent);
					if (flag26)
					{
						bool flag27 = this.HeadpatMODELEFT && VRCPlayer.field_Internal_Static_VRCPlayer_0 != null && PlayerWrapper.GetCurrentPlayer().gameObject.GetComponentInChildren<VRIK>().solver.leftArm != null;
						if (flag27)
						{
							PlayerWrapper.GetCurrentPlayer().gameObject.GetComponentInChildren<VRIK>().solver.leftArm.positionWeight = 1f;
						}
						bool flag28 = this.HeadpatMODERIGHT && VRCPlayer.field_Internal_Static_VRCPlayer_0 != null && PlayerWrapper.GetCurrentPlayer().gameObject.GetComponentInChildren<VRIK>().solver.rightArm != null;
						if (flag28)
						{
							PlayerWrapper.GetCurrentPlayer().gameObject.GetComponentInChildren<VRIK>().solver.rightArm.positionWeight = 1f;
						}
					}
				}
			}
			catch (Exception ex5)
			{
				LNCcolnsole.ERROR(string.Concat(new string[]
				{
					"Error in OnUpdate! - ",
					ex5.Message,
					" From:Leash ",
					ex5.Source,
					" - Stack:Leash ",
					ex5.StackTrace
				}), false, ConsoleColor.Red);
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000B308 File Offset: 0x00009508
		public override void OnApplicationQuit()
		{
			Art.Art_stop();
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000B314 File Offset: 0x00009514
		public override void OnLevelWasLoaded(int level)
		{
			bool flag = level > 1;
			if (flag)
			{
				this.TestBehav();
			}
			bool consoleCleaner = Config.Instance.ConsoleCleaner;
			if (consoleCleaner)
			{
				bool flag2 = level == -1;
				bool flag3 = flag2;
				if (flag3)
				{
					Console.Clear();
					LNCcolnsole.Log("============================ Late Night V4 ===========================", false, ConsoleColor.Cyan);
				}
			}
			bool nopost = Config.Instance.Nopost;
			if (nopost)
			{
				bool flag4 = level == -1;
				bool flag5 = flag4;
				if (flag5)
				{
					Wolds.WorldWasChanged = true;
					MelonCoroutines.Start(this.DelayedAction());
				}
			}
			bool noChairs = Config.Instance.NoChairs;
			if (noChairs)
			{
				bool flag6 = level == -1;
				bool flag7 = flag6;
				if (flag7)
				{
					this.NoChaisBool = true;
					MelonCoroutines.Start(this.NoChairIE());
				}
			}
			bool noPickUp = Config.Instance.NoPickUp;
			if (noPickUp)
			{
				bool flag8 = level == -1;
				bool flag9 = flag8;
				if (flag9)
				{
					this.NoPickUpBool = true;
					MelonCoroutines.Start(this.NoPickIE());
				}
			}
			bool noVideo = Config.Instance.NoVideo;
			if (noVideo)
			{
				bool flag10 = level == -1;
				bool flag11 = flag10;
				if (flag11)
				{
					this.NoVideoBool = true;
					MelonCoroutines.Start(this.NoVideoIE());
				}
			}
			bool hidePickUps = Config.Instance.HidePickUps;
			if (hidePickUps)
			{
				bool flag12 = level == -1;
				bool flag13 = flag12;
				if (flag13)
				{
					this.HidePickUpsBool = true;
					MelonCoroutines.Start(this.HidePickUpsIE());
				}
			}
			bool pickUpAutoHolder = Config.Instance.PickUpAutoHolder;
			if (pickUpAutoHolder)
			{
				bool flag14 = level == -1;
				bool flag15 = flag14;
				if (flag15)
				{
					this.PickUpAutoHoldBool = true;
					MelonCoroutines.Start(this.AutoHolderIE());
				}
			}
			bool min_clip = Config.Instance.min_clip;
			if (min_clip)
			{
				bool flag16 = level == -1;
				bool flag17 = flag16;
				if (flag17)
				{
					MelonCoroutines.Start(this.SetNearClipPlane());
				}
			}
			bool far_clip = Config.Instance.far_clip;
			if (far_clip)
			{
				bool flag18 = level == -1;
				bool flag19 = flag18;
				if (flag19)
				{
					MelonCoroutines.Start(this.SetFARClipPlane());
				}
			}
			GlobalDynamicBones.clearlistDyn();
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000B502 File Offset: 0x00009702
		public override void OnSceneWasLoaded(int buildIndex, string sceneName)
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000B508 File Offset: 0x00009708
		private void TestBehav()
		{
			bool flag = this.TestOby;
			if (!flag)
			{
				PlayerWrapper.setupcolor();
				ui_difine.ActionMenu.AddComponent<QmFreeze>();
				ui_difine.AvatarMenu.AddComponent<BigMenuBeh>();
				this.TestOby = new GameObject("lateTest");
				Object.DontDestroyOnLoad(this.TestOby);
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000B55F File Offset: 0x0000975F
		private IEnumerator NoChairIE()
		{
			yield return new WaitForSeconds(5f);
			bool worldWasChanged = this.NoChaisBool;
			bool flag = !worldWasChanged;
			if (flag)
			{
				yield break;
			}
			this.NoChaisBool = false;
			try
			{
				Wolds.SetAllObjectsOfTypeChairs(false);
				yield break;
			}
			catch
			{
				LNCcolnsole.Log("world didn't load in time to Disable chairs", false, ConsoleColor.White);
				yield break;
			}
			yield break;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000B56E File Offset: 0x0000976E
		private IEnumerator NoPickIE()
		{
			yield return new WaitForSeconds(5f);
			bool worldWasChanged = this.NoPickUpBool;
			bool flag = !worldWasChanged;
			if (flag)
			{
				yield break;
			}
			this.NoPickUpBool = false;
			try
			{
				Wolds.pickupNOHOLD(false);
				yield break;
			}
			catch
			{
				LNCcolnsole.Log("world didn't load in time to disable pickup component", false, ConsoleColor.White);
				yield break;
			}
			yield break;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000B57D File Offset: 0x0000977D
		private IEnumerator NoVideoIE()
		{
			yield return new WaitForSeconds(5f);
			bool worldWasChanged = this.NoVideoBool;
			bool flag = !worldWasChanged;
			if (flag)
			{
				yield break;
			}
			this.NoVideoBool = false;
			try
			{
				Wolds.SetAllObjectsOfTypeVideoPlayers(false);
				yield break;
			}
			catch
			{
				LNCcolnsole.Log("world didn't load in time to disable video players", false, ConsoleColor.White);
				yield break;
			}
			yield break;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000B58C File Offset: 0x0000978C
		private IEnumerator HidePickUpsIE()
		{
			yield return new WaitForSeconds(5f);
			bool worldWasChanged = this.HidePickUpsBool;
			bool flag = worldWasChanged;
			if (flag)
			{
				this.HidePickUpsBool = false;
				try
				{
					Wolds.pickupHIDE(false);
				}
				catch
				{
					LNCcolnsole.Log("world didn't load in time to disable pickups", false, ConsoleColor.White);
				}
			}
			yield break;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000B59B File Offset: 0x0000979B
		private IEnumerator AutoHolderIE()
		{
			yield return new WaitForSeconds(5f);
			bool worldWasChanged = this.PickUpAutoHoldBool;
			bool flag = !worldWasChanged;
			if (flag)
			{
				yield break;
			}
			this.PickUpAutoHoldBool = false;
			try
			{
				Wolds.pickupAutoHold(true);
				yield break;
			}
			catch
			{
				LNCcolnsole.Log("world didn't load in time to catch the info", false, ConsoleColor.White);
				yield break;
			}
			yield break;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000B5AA File Offset: 0x000097AA
		private IEnumerator DelayedAction()
		{
			yield return new WaitForSeconds(5f);
			bool worldWasChanged = Wolds.WorldWasChanged;
			bool flag = !worldWasChanged;
			if (flag)
			{
				yield break;
			}
			Wolds.WorldWasChanged = false;
			Wolds.Nopost();
			yield break;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000B5BC File Offset: 0x000097BC
		internal void ChangeNearClipPlane(float V)
		{
			VRCVrCamera field_Private_Static_VRCVrCamera_ = VRCVrCamera.field_Private_Static_VRCVrCamera_0;
			bool flag = !field_Private_Static_VRCVrCamera_;
			if (!flag)
			{
				Camera field_Public_Camera_ = field_Private_Static_VRCVrCamera_.field_Public_Camera_0;
				bool flag2 = !field_Public_Camera_;
				if (!flag2)
				{
					field_Public_Camera_.nearClipPlane = V;
				}
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000B5FD File Offset: 0x000097FD
		private IEnumerator SetNearClipPlane()
		{
			yield return new WaitForSecondsRealtime(15f);
			this.ChangeNearClipPlane(0.001f);
			yield break;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000B60C File Offset: 0x0000980C
		internal void ChangeFARClipPlane(short C)
		{
			VRCVrCamera field_Private_Static_VRCVrCamera_ = VRCVrCamera.field_Private_Static_VRCVrCamera_0;
			bool flag = !field_Private_Static_VRCVrCamera_;
			if (!flag)
			{
				Camera field_Public_Camera_ = field_Private_Static_VRCVrCamera_.field_Public_Camera_0;
				bool flag2 = !field_Public_Camera_;
				if (!flag2)
				{
					field_Public_Camera_.farClipPlane = (float)C;
					Camera.main.farClipPlane = (float)C;
				}
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000B65B File Offset: 0x0000985B
		private IEnumerator SetFARClipPlane()
		{
			yield return new WaitForSecondsRealtime(15f);
			this.ChangeFARClipPlane(short.MaxValue);
			yield break;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000B66C File Offset: 0x0000986C
		internal void Cubemake(bool OnOrOff)
		{
			bool flag = this.Late_cube != null && !OnOrOff;
			if (flag)
			{
				Object.Destroy(this.Late_cube);
				this.Late_cube = null;
			}
			else
			{
				Vector3 vector = PlayerWrapper.GetCurrentPlayer().transform.position + new Vector3(0f, 0.65f, 0f);
				Vector3 position = vector;
				GameObject gameObject = GameObject.CreatePrimitive(3);
				gameObject.transform.position = position;
				gameObject.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
				gameObject.transform.localScale = new Vector3(0.05f, 1f, 0.05f);
				gameObject.name = "Late_Nighrt_Cube";
				Object.Destroy(gameObject.GetComponent<Collider>());
				gameObject.GetOrAddComponent<BoxCollider>().size = new Vector3(0.1f, 0.1f, 0.1f);
				gameObject.GetOrAddComponent<BoxCollider>().isTrigger = true;
				gameObject.GetOrAddComponent<MeshRenderer>().material.color = Late_Night.cubemat;
				gameObject.GetOrAddComponent<Rigidbody>().useGravity = false;
				this.Late_cube = gameObject;
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000B7A4 File Offset: 0x000099A4
		internal void Endermake()
		{
			bool flag = this.ENDER != null;
			if (flag)
			{
				Object.Destroy(this.ENDER);
				this.ENDER = null;
			}
			else
			{
				Vector3 bonePosition = PlayerWrapper.GetCurrentPlayer().field_Private_VRCPlayerApi_0.GetBonePosition(18);
				Vector3 position = bonePosition;
				GameObject gameObject = GameObject.CreatePrimitive(0);
				gameObject.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
				gameObject.transform.position = position;
				gameObject.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
				gameObject.name = "Late_Night_ender";
				Object.Destroy(gameObject.GetComponent<Collider>());
				gameObject.GetOrAddComponent<BoxCollider>().size = new Vector3(1f, 1f, 1f);
				gameObject.GetOrAddComponent<BoxCollider>().isTrigger = true;
				gameObject.GetOrAddComponent<MeshRenderer>().material.color = Late_Night.Ender;
				gameObject.GetOrAddComponent<Rigidbody>().useGravity = false;
				gameObject.GetOrAddComponent<Rigidbody>().drag = 0f;
				gameObject.GetOrAddComponent<Rigidbody>().angularDrag = 0.01f;
				gameObject.GetOrAddComponent<VRC_Pickup>().pickupable = true;
				gameObject.GetOrAddComponent<VRC_Pickup>().ThrowVelocityBoostScale = 7.5f;
				gameObject.AddComponent<Enderpearl>();
				this.ENDER = gameObject;
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000B904 File Offset: 0x00009B04
		internal void BoomMaker()
		{
			bool flag = this.Boom != null;
			if (flag)
			{
				Object.Destroy(this.Boom);
				this.Boom = null;
			}
			else
			{
				Vector3 bonePosition = PlayerWrapper.GetCurrentPlayer().field_Private_VRCPlayerApi_0.GetBonePosition(18);
				Vector3 position = bonePosition;
				GameObject gameObject = GameObject.CreatePrimitive(0);
				gameObject.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
				gameObject.transform.position = position;
				gameObject.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
				gameObject.name = "Late_Night_BOOM";
				Object.Destroy(gameObject.GetComponent<Collider>());
				gameObject.GetOrAddComponent<BoxCollider>().size = new Vector3(1f, 1f, 1f);
				gameObject.GetOrAddComponent<BoxCollider>().isTrigger = true;
				gameObject.GetOrAddComponent<MeshRenderer>().material.color = Late_Night.cubemat;
				gameObject.GetOrAddComponent<Rigidbody>().useGravity = false;
				gameObject.GetOrAddComponent<Rigidbody>().drag = 0f;
				gameObject.GetOrAddComponent<Rigidbody>().angularDrag = 0.01f;
				gameObject.GetOrAddComponent<VRC_Pickup>().pickupable = true;
				gameObject.GetOrAddComponent<VRC_Pickup>().ThrowVelocityBoostScale = 7.5f;
				gameObject.AddComponent<PickUpBoom>();
				this.Boom = gameObject;
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000BA61 File Offset: 0x00009C61
		private static IEnumerator UnPatchTheQuest()
		{
			while (APIUser.CurrentUser == null || string.IsNullOrWhiteSpace(ApiCredentials.authToken))
			{
				yield return null;
			}
			Late_Night.Instance4.UnpatchSelf();
			yield break;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000BA6C File Offset: 0x00009C6C
		public static void Clear_cache()
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			string text = Path.Combine(new string[]
			{
				folderPath + "Low\\VRChat\\VRChat\\Cache-WindowsPlayer"
			});
			DirectoryInfo directoryInfo = new DirectoryInfo(text);
			LNCcolnsole.Log(text, false, ConsoleColor.White);
			bool flag = Directory.Exists(text);
			if (flag)
			{
				foreach (DirectoryInfo directoryInfo2 in directoryInfo.GetDirectories())
				{
					try
					{
						directoryInfo2.Delete();
					}
					catch (Exception ex)
					{
						LNCcolnsole.ERROR(string.Concat(new string[]
						{
							"Error in Clear_cache ! - ",
							ex.Message,
							" From:Clear_cache ",
							ex.Source,
							" - Stack:Clear_cache ",
							ex.StackTrace
						}), false, ConsoleColor.Red);
					}
				}
				LNCcolnsole.Log("Cear-ed", false, ConsoleColor.White);
			}
			else
			{
				LNCcolnsole.ERROR("brrrr", false, ConsoleColor.Red);
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000BB70 File Offset: 0x00009D70
		internal void Mirromake()
		{
			bool flag = this.Mirro != null;
			if (flag)
			{
				Object.Destroy(this.Mirro);
				this.Mirro = null;
			}
			else
			{
				Vector3 position = PlayerWrapper.GetCurrentPlayer().transform.position + PlayerWrapper.GetCurrentPlayer().transform.forward * 1f + PlayerWrapper.GetCurrentPlayer().transform.up * 1f;
				Quaternion rotation = PlayerWrapper.GetCurrentPlayer().transform.rotation;
				GameObject gameObject = GameObject.CreatePrimitive(5);
				gameObject.transform.position = position;
				gameObject.transform.rotation = rotation;
				gameObject.transform.localScale = new Vector3(this.sizeX, this.sizeY, 0f);
				gameObject.name = "Late_Night_Miro";
				Object.Destroy(gameObject.GetComponent<Collider>());
				gameObject.GetOrAddComponent<BoxCollider>().size = new Vector3(this.sizeX, this.sizeY, 0f);
				gameObject.GetOrAddComponent<BoxCollider>().isTrigger = true;
				gameObject.GetOrAddComponent<Rigidbody>().useGravity = false;
				gameObject.GetOrAddComponent<Rigidbody>().isKinematic = true;
				gameObject.GetOrAddComponent<VRC_Pickup>().pickupable = true;
				gameObject.GetOrAddComponent<VRC_Pickup>().allowManipulationWhenEquipped = false;
				gameObject.GetOrAddComponent<MeshRenderer>().material.shader = Shader.Find("FX/MirrorReflection");
				VRC_MirrorReflection component = gameObject.GetOrAddComponent<VRC_MirrorReflection>().GetComponent<VRC_MirrorReflection>();
				LayerMask reflectLayers = default(LayerMask);
				reflectLayers.value = (this.OptOrNah ? 263680 : -1025);
				component.m_ReflectLayers = reflectLayers;
				bool stickTo = this.StickTo;
				if (stickTo)
				{
					gameObject.gameObject.transform.parent = Funny.GetLocalPlayer().transform;
				}
				this.Mirro = gameObject;
			}
		}

		// Token: 0x0400007B RID: 123
		public const string clientVS = "4.1.0.0";

		// Token: 0x0400007C RID: 124
		public static Harmony Instance = new Harmony("kysLN");

		// Token: 0x0400007D RID: 125
		public static Harmony Instance2 = new Harmony("kysLNASAAAA");

		// Token: 0x0400007E RID: 126
		public static Harmony Instance3 = new Harmony("LNCONTOP");

		// Token: 0x0400007F RID: 127
		public static Harmony Instance4 = new Harmony("MISHUDNWEKDEVFSMAL");

		// Token: 0x04000080 RID: 128
		public static Harmony Instance5 = new Harmony("hnuiehudjia");

		// Token: 0x04000081 RID: 129
		internal static Color cubemat = new Color(2f, 0f, 0f, 0.4f);

		// Token: 0x04000082 RID: 130
		internal static Color Ender = new Color(0f, 2f, 0f, 0.4f);

		// Token: 0x04000083 RID: 131
		public Player Target;

		// Token: 0x04000084 RID: 132
		public bool leash = false;

		// Token: 0x04000085 RID: 133
		public bool orbitPlayer;

		// Token: 0x04000086 RID: 134
		public bool SitonHead;

		// Token: 0x04000087 RID: 135
		public bool SitonLeftHand;

		// Token: 0x04000088 RID: 136
		public bool SitonRightHand;

		// Token: 0x04000089 RID: 137
		public bool SitonLeftshoulder;

		// Token: 0x0400008A RID: 138
		public bool SitonRightshoulder;

		// Token: 0x0400008B RID: 139
		public bool SitonLeftknee;

		// Token: 0x0400008C RID: 140
		public bool SitonRightknee;

		// Token: 0x0400008D RID: 141
		public bool SitonLeftfeet;

		// Token: 0x0400008E RID: 142
		public bool SitonRightfeet;

		// Token: 0x0400008F RID: 143
		public float disten = 2f;

		// Token: 0x04000090 RID: 144
		public float MOveToSpeed = 9f;

		// Token: 0x04000091 RID: 145
		public static bool invisjoin;

		// Token: 0x04000092 RID: 146
		public bool HeadpatMODE;

		// Token: 0x04000093 RID: 147
		public bool HeadpatMODELEFT;

		// Token: 0x04000094 RID: 148
		public bool HeadpatMODERIGHT;

		// Token: 0x04000095 RID: 149
		public static float Delay;

		// Token: 0x04000096 RID: 150
		public float OrbitSpeed = 50f;

		// Token: 0x04000097 RID: 151
		public float OrbitDist = 2f;

		// Token: 0x04000098 RID: 152
		public static bool E9Anti;

		// Token: 0x04000099 RID: 153
		public static bool UIdone = false;

		// Token: 0x0400009A RID: 154
		public static bool Ghoats;

		// Token: 0x0400009B RID: 155
		public static QMCategory Main;

		// Token: 0x0400009C RID: 156
		public static QMCategory USerUtills;

		// Token: 0x0400009D RID: 157
		public static MenuText ListText;

		// Token: 0x0400009E RID: 158
		public static MenuText clock;

		// Token: 0x0400009F RID: 159
		public static MenuText LNCINFOVS;

		// Token: 0x040000A0 RID: 160
		public static MenuText SysInfo;

		// Token: 0x040000A1 RID: 161
		public static QMSingleButton Play;

		// Token: 0x040000A2 RID: 162
		public static QMSingleButton next;

		// Token: 0x040000A3 RID: 163
		public static QMSingleButton Back;

		// Token: 0x040000A4 RID: 164
		public static QMToggleButton fly;

		// Token: 0x040000A5 RID: 165
		public static QMToggleButton speedbut;

		// Token: 0x040000A6 RID: 166
		public static QMToggleButton Jump;

		// Token: 0x040000A7 RID: 167
		public static Late_Night instance;

		// Token: 0x040000A8 RID: 168
		public HarmonyInstance harmony;

		// Token: 0x040000A9 RID: 169
		public float FOV = 60f;

		// Token: 0x040000AA RID: 170
		public bool ListHasBeedUpDate = false;

		// Token: 0x040000AB RID: 171
		private float time;

		// Token: 0x040000AC RID: 172
		public bool worldloadid;

		// Token: 0x040000AD RID: 173
		public bool NoChaisBool;

		// Token: 0x040000AE RID: 174
		public bool NoPickUpBool;

		// Token: 0x040000AF RID: 175
		public bool NoVideoBool;

		// Token: 0x040000B0 RID: 176
		public bool HidePickUpsBool;

		// Token: 0x040000B1 RID: 177
		public bool PickUpAutoHoldBool;

		// Token: 0x040000B2 RID: 178
		public bool colorchanged = false;

		// Token: 0x040000B3 RID: 179
		public bool Updidthething = false;

		// Token: 0x040000B4 RID: 180
		private GameObject TestOby;

		// Token: 0x040000B5 RID: 181
		private GameObject Late_cube;

		// Token: 0x040000B6 RID: 182
		public GameObject ENDER;

		// Token: 0x040000B7 RID: 183
		public GameObject Boom;

		// Token: 0x040000B8 RID: 184
		public bool OptOrNah = false;

		// Token: 0x040000B9 RID: 185
		public bool PickUpabl = true;

		// Token: 0x040000BA RID: 186
		public bool StickTo = false;

		// Token: 0x040000BB RID: 187
		public float sizeX = 1f;

		// Token: 0x040000BC RID: 188
		public float sizeY = 1f;

		// Token: 0x040000BD RID: 189
		internal GameObject Mirro;
	}
}
