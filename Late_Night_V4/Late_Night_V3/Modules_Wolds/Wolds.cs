using System;
using System.Linq;
using Late_Night_config;
using Late_Night_V2_popshit;
using Late_Night_V2_wrappers;
using Late_Night_V3_colnsole;
using UnhollowerBaseLib;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using VRC.SDK3.Components;
using VRC.SDK3.Video.Components;
using VRC.SDKBase;
using VRCSDK2;
using XButtonAPI;

namespace Late_Night_V3.Modules_Wolds
{
	// Token: 0x02000020 RID: 32
	internal class Wolds
	{
		// Token: 0x0600016D RID: 365 RVA: 0x0000D844 File Offset: 0x0000BA44
		public static void Wolds_menu(QMNestedButton Submenu)
		{
			QMNestedButton qmnestedButton = Submenu.AddMenuPage("Mirror options", "Mirror options", "Mirror options", false, null);
			qmnestedButton.AddButton("UnOpt Mirrors", "yes", delegate
			{
				bool flag = false;
				MirrorReflection[] array = Object.FindObjectsOfType<MirrorReflection>();
				LayerMask layerMask = default(LayerMask);
				layerMask.value = (flag ? 263680 : -1025);
				foreach (MirrorReflection mirrorReflection in array)
				{
					mirrorReflection.field_Public_LayerMask_0 = layerMask;
				}
				VRC_MirrorReflection[] array3 = Object.FindObjectsOfType<VRC_MirrorReflection>();
				foreach (VRC_MirrorReflection vrc_MirrorReflection in array3)
				{
					vrc_MirrorReflection.m_ReflectLayers = layerMask;
				}
				VRC_MirrorReflection[] array5 = Object.FindObjectsOfType<VRC_MirrorReflection>();
				foreach (VRC_MirrorReflection vrc_MirrorReflection2 in array5)
				{
					vrc_MirrorReflection2.m_ReflectLayers = layerMask;
				}
			}, null);
			qmnestedButton.AddButton("Opt Mirrors", "yes", delegate
			{
				bool flag = true;
				MirrorReflection[] array = Object.FindObjectsOfType<MirrorReflection>();
				LayerMask layerMask = default(LayerMask);
				layerMask.value = (flag ? 263680 : -1025);
				foreach (MirrorReflection mirrorReflection in array)
				{
					mirrorReflection.field_Public_LayerMask_0 = layerMask;
				}
				VRC_MirrorReflection[] array3 = Object.FindObjectsOfType<VRC_MirrorReflection>();
				foreach (VRC_MirrorReflection vrc_MirrorReflection in array3)
				{
					vrc_MirrorReflection.m_ReflectLayers = layerMask;
				}
				VRC_MirrorReflection[] array5 = Object.FindObjectsOfType<VRC_MirrorReflection>();
				foreach (VRC_MirrorReflection vrc_MirrorReflection2 in array5)
				{
					vrc_MirrorReflection2.m_ReflectLayers = layerMask;
				}
			}, null);
			qmnestedButton.AddButton("Max Resolution", "yes", delegate
			{
				VRC_MirrorReflection[] array = Object.FindObjectsOfType<VRC_MirrorReflection>();
				VRC_MirrorReflection[] array2 = Object.FindObjectsOfType<VRC_MirrorReflection>();
				foreach (VRC_MirrorReflection vrc_MirrorReflection in array)
				{
					vrc_MirrorReflection.mirrorResolution = 0;
				}
				foreach (VRC_MirrorReflection vrc_MirrorReflection2 in array2)
				{
					vrc_MirrorReflection2.mirrorResolution = 0;
				}
			}, null);
			qmnestedButton.AddButton("Mid (H) Resolution", "yes", delegate
			{
				VRC_MirrorReflection[] array = Object.FindObjectsOfType<VRC_MirrorReflection>();
				VRC_MirrorReflection[] array2 = Object.FindObjectsOfType<VRC_MirrorReflection>();
				foreach (VRC_MirrorReflection vrc_MirrorReflection in array)
				{
					vrc_MirrorReflection.mirrorResolution = 1024;
				}
				foreach (VRC_MirrorReflection vrc_MirrorReflection2 in array2)
				{
					vrc_MirrorReflection2.mirrorResolution = 1024;
				}
			}, null);
			qmnestedButton.AddButton("Mid (L)  Resolution", "yes", delegate
			{
				VRC_MirrorReflection[] array = Object.FindObjectsOfType<VRC_MirrorReflection>();
				VRC_MirrorReflection[] array2 = Object.FindObjectsOfType<VRC_MirrorReflection>();
				foreach (VRC_MirrorReflection vrc_MirrorReflection in array)
				{
					vrc_MirrorReflection.mirrorResolution = 512;
				}
				foreach (VRC_MirrorReflection vrc_MirrorReflection2 in array2)
				{
					vrc_MirrorReflection2.mirrorResolution = 512;
				}
			}, null);
			qmnestedButton.AddButton("Min Resolution", "yes", delegate
			{
				VRC_MirrorReflection[] array = Object.FindObjectsOfType<VRC_MirrorReflection>();
				VRC_MirrorReflection[] array2 = Object.FindObjectsOfType<VRC_MirrorReflection>();
				foreach (VRC_MirrorReflection vrc_MirrorReflection in array)
				{
					vrc_MirrorReflection.mirrorResolution = 256;
				}
				foreach (VRC_MirrorReflection vrc_MirrorReflection2 in array2)
				{
					vrc_MirrorReflection2.mirrorResolution = 256;
				}
			}, null);
			QMNestedButton qmnestedButton2 = Submenu.AddMenuPage("Pickup options", "Pickup options", "Pickup options", false, null);
			qmnestedButton2.AddButton("Respawn Pickups", "yes", delegate
			{
				Wrapper.RespawnPickups();
			}, null);
			qmnestedButton2.AddButton("Delete Pickups", "yes", delegate
			{
				foreach (VRC_Pickup vrc_Pickup in Resources.FindObjectsOfTypeAll<VRC_Pickup>())
				{
					bool flag = vrc_Pickup == null;
					bool flag2 = !flag;
					if (flag2)
					{
						Object.Destroy(vrc_Pickup.gameObject);
					}
				}
			}, null);
			qmnestedButton2.AddToggle("Hide Pick-ups", "yes", delegate(bool B)
			{
				Config.Instance.HidePickUps = B;
				Wolds.pickupHIDE(!Config.Instance.HidePickUps);
				Config.Instance.SaveConfig();
			}, Config.Instance.HidePickUps);
			qmnestedButton2.AddToggle("No pick up", "yes", delegate(bool B)
			{
				Config.Instance.NoPickUp = B;
				Wolds.pickupNOHOLD(Config.Instance.NoPickUp);
				Config.Instance.SaveConfig();
			}, Config.Instance.NoPickUp);
			qmnestedButton2.AddToggle("pick-up Auto holder", "yes", delegate(bool B)
			{
				Config.Instance.PickUpAutoHolder = B;
				Wolds.pickupAutoHold(Config.Instance.PickUpAutoHolder);
				Config.Instance.SaveConfig();
			}, Config.Instance.PickUpAutoHolder);
			qmnestedButton2.AddToggle("pick-up esp", "yes", delegate(bool B)
			{
				PlayerWrapper.PickupESP(B);
				Wolds.item_esp = B;
			}, Wolds.item_esp);
			QMNestedButton qmnestedButton3 = Submenu.AddMenuPage("World id options", "World id options", "World id  options", false, null);
			qmnestedButton3.AddButton("world id to clipboard", "yes", delegate
			{
				popshit.SetClipboard(RoomManager.Method_Internal_Static_get_String_0());
				LNCcolnsole.Log("You are in\n  " + RoomManager.Method_Internal_Static_get_String_0(), false, ConsoleColor.Yellow);
			}, null);
			qmnestedButton3.AddButton("Force Join by id (from clipboard)", "yes", delegate
			{
				bool flag = popshit.GetClipboard().StartsWith("wrld");
				if (flag)
				{
					popshit.JoinWorldById(popshit.GetClipboard());
				}
				else
				{
					LNCcolnsole.ERROR("Text on clipboard is not a world", true, ConsoleColor.Red);
				}
			}, null);
			qmnestedButton3.AddButton("Portal by ID(from clipboard)", "yes", delegate
			{
				bool flag = popshit.GetClipboard().StartsWith("wrld");
				if (flag)
				{
					PortalToInstByID.PortalToInstanceByID(popshit.GetClipboard());
				}
				else
				{
					LNCcolnsole.ERROR("Text on clipboard is not a world", true, ConsoleColor.Red);
				}
			}, null);
			Submenu.AddToggle("No post", "yes", delegate(bool B)
			{
				Config.Instance.Nopost = B;
				Wolds.Nopost();
				Config.Instance.SaveConfig();
			}, Config.Instance.Nopost);
			Submenu.AddToggle("chairs toggle", "yes", delegate(bool B)
			{
				Wolds.SetAllObjectsOfTypeChairs(!B);
				Config.Instance.NoChairs = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.NoChairs);
			Submenu.AddToggle("Video player toggle", "yes", delegate(bool B)
			{
				Wolds.SetAllObjectsOfTypeVideoPlayers(!B);
				Config.Instance.NoVideo = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.NoVideo);
			Submenu.AddToggle("Trigger esp", "yes", delegate(bool B)
			{
				PlayerWrapper.TriggerESP(B);
			}, Wolds.tig_esp);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000DC7C File Offset: 0x0000BE7C
		internal static void SetAllObjectsOfTypeChairs(bool state)
		{
			Il2CppArrayBase<VRCStation> il2CppArrayBase = Resources.FindObjectsOfTypeAll<VRCStation>();
			foreach (VRCStation vrcstation in il2CppArrayBase)
			{
				bool flag = !(vrcstation == null) && vrcstation.gameObject.active == !state;
				if (flag)
				{
					vrcstation.gameObject.SetActive(state);
				}
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000DCF8 File Offset: 0x0000BEF8
		internal static void SetAllObjectsOfTypeVideoPlayers(bool state)
		{
			Il2CppArrayBase<VRC_SyncVideoPlayer> il2CppArrayBase = Resources.FindObjectsOfTypeAll<VRC_SyncVideoPlayer>();
			foreach (VRC_SyncVideoPlayer vrc_SyncVideoPlayer in il2CppArrayBase)
			{
				bool flag = vrc_SyncVideoPlayer == null;
				if (!flag)
				{
					bool flag2 = vrc_SyncVideoPlayer.gameObject.active == !state;
					if (flag2)
					{
						vrc_SyncVideoPlayer.gameObject.SetActive(state);
					}
				}
			}
			Il2CppArrayBase<VRCUnityVideoPlayer> il2CppArrayBase2 = Resources.FindObjectsOfTypeAll<VRCUnityVideoPlayer>();
			foreach (VRCUnityVideoPlayer vrcunityVideoPlayer in il2CppArrayBase2)
			{
				bool flag3 = vrcunityVideoPlayer == null;
				if (!flag3)
				{
					bool flag4 = vrcunityVideoPlayer.gameObject.active == !state;
					if (flag4)
					{
						vrcunityVideoPlayer.gameObject.SetActive(state);
					}
				}
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000DDF4 File Offset: 0x0000BFF4
		internal static void Nopost()
		{
			foreach (Camera camera in Camera.allCameras)
			{
				bool flag = camera.GetComponent<PostProcessLayer>() != null;
				bool flag2 = !flag;
				if (!flag2)
				{
					bool flag3 = !Config.Instance.Nopost != camera.GetComponent<PostProcessLayer>().enabled;
					bool flag4 = flag3;
					if (flag4)
					{
						camera.GetComponent<PostProcessLayer>().enabled = !Config.Instance.Nopost;
					}
				}
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000DE98 File Offset: 0x0000C098
		internal static void pickupHIDE(bool a)
		{
			VRC_Pickup[] array = Resources.FindObjectsOfTypeAll<VRC_Pickup>().ToArray<VRC_Pickup>();
			foreach (VRC_Pickup vrc_Pickup in array)
			{
				bool flag = vrc_Pickup.gameObject.layer == 13;
				if (flag)
				{
					vrc_Pickup.gameObject.SetActive(a);
				}
			}
			VRC_Pickup[] array3 = Resources.FindObjectsOfTypeAll<VRC_Pickup>().ToArray<VRC_Pickup>();
			foreach (VRC_Pickup vrc_Pickup2 in array3)
			{
				bool flag2 = vrc_Pickup2.gameObject.layer == 13;
				if (flag2)
				{
					vrc_Pickup2.gameObject.SetActive(a);
				}
			}
			VRCPickup[] array5 = Resources.FindObjectsOfTypeAll<VRCPickup>().ToArray<VRCPickup>();
			foreach (VRCPickup vrcpickup in array5)
			{
				bool flag3 = vrcpickup.gameObject.layer == 13;
				if (flag3)
				{
					vrcpickup.gameObject.SetActive(a);
				}
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000DF8C File Offset: 0x0000C18C
		internal static void pickupAutoHold(bool a)
		{
			if (a)
			{
				VRC_Pickup[] array = Resources.FindObjectsOfTypeAll<VRC_Pickup>().ToArray<VRC_Pickup>();
				foreach (VRC_Pickup vrc_Pickup in array)
				{
					bool flag = vrc_Pickup.gameObject.layer == 13;
					if (flag)
					{
						vrc_Pickup.AutoHold = 1;
					}
				}
				VRC_Pickup[] array3 = Resources.FindObjectsOfTypeAll<VRC_Pickup>().ToArray<VRC_Pickup>();
				foreach (VRC_Pickup vrc_Pickup2 in array3)
				{
					bool flag2 = vrc_Pickup2.gameObject.layer == 13;
					if (flag2)
					{
						vrc_Pickup2.AutoHold = 1;
					}
				}
				VRCPickup[] array5 = Resources.FindObjectsOfTypeAll<VRCPickup>().ToArray<VRCPickup>();
				foreach (VRCPickup vrcpickup in array5)
				{
					bool flag3 = vrcpickup.gameObject.layer == 13;
					if (flag3)
					{
						vrcpickup.AutoHold = 1;
					}
				}
			}
			else
			{
				VRC_Pickup[] array7 = Resources.FindObjectsOfTypeAll<VRC_Pickup>().ToArray<VRC_Pickup>();
				for (int l = 0; l < array7.Length; l++)
				{
					bool flag4 = array7[l].gameObject.layer == 13;
					if (flag4)
					{
						array7[l].AutoHold = 0;
					}
				}
				VRC_Pickup[] array8 = Resources.FindObjectsOfTypeAll<VRC_Pickup>().ToArray<VRC_Pickup>();
				for (int m = 0; m < array8.Length; m++)
				{
					bool flag5 = array8[m].gameObject.layer == 13;
					if (flag5)
					{
						array8[m].AutoHold = 0;
					}
				}
				VRCPickup[] array9 = Resources.FindObjectsOfTypeAll<VRCPickup>().ToArray<VRCPickup>();
				for (int n = 0; n < array9.Length; n++)
				{
					bool flag6 = array9[n].gameObject.layer == 13;
					if (flag6)
					{
						array9[n].AutoHold = 0;
					}
				}
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000E164 File Offset: 0x0000C364
		internal static void pickupNOHOLD(bool a)
		{
			VRC_Pickup[] array = Resources.FindObjectsOfTypeAll<VRC_Pickup>().ToArray<VRC_Pickup>();
			for (int i = 0; i < array.Length; i++)
			{
				bool flag = array[i].gameObject.layer == 13;
				if (flag)
				{
					array[i].pickupable = a;
				}
			}
			VRC_Pickup[] array2 = Resources.FindObjectsOfTypeAll<VRC_Pickup>().ToArray<VRC_Pickup>();
			for (int j = 0; j < array2.Length; j++)
			{
				bool flag2 = array2[j].gameObject.layer == 13;
				if (flag2)
				{
					array2[j].pickupable = a;
				}
			}
			VRCPickup[] array3 = Resources.FindObjectsOfTypeAll<VRCPickup>().ToArray<VRCPickup>();
			for (int k = 0; k < array3.Length; k++)
			{
				bool flag3 = array3[k].gameObject.layer == 13;
				if (flag3)
				{
					array3[k].pickupable = a;
				}
			}
		}

		// Token: 0x040000BE RID: 190
		public static bool tig_esp;

		// Token: 0x040000BF RID: 191
		public static bool item_esp;

		// Token: 0x040000C0 RID: 192
		public static bool WorldWasChanged;
	}
}
