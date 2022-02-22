using System;
using System.Linq;
using DayClientML2.Utility.Extensions;
using Late_Night_V2_wrappers;
using Late_Night_V3_StarLag;
using Late_Night_V3_WorldGameHacks;
using UnityEngine;
using UnityEngine.SceneManagement;
using VRC;
using VRC.SDK3.Components;
using VRC.SDKBase;
using VRCSDK2;
using XButtonAPI;

namespace Late_Night_V3.Modules_Funny
{
	// Token: 0x02000028 RID: 40
	internal class Funny
	{
		// Token: 0x0600018B RID: 395 RVA: 0x00010044 File Offset: 0x0000E244
		internal static void Funny_menu(QMNestedButton Submenux)
		{
			QMNestedButton qmnestedButton = Submenux.AddMenuPage("Mic Stuff", "Mic Stuff", "Fuck ur mic up", false, null);
			qmnestedButton.AddToggle("Loud Mic", "Loud Mic", delegate(bool B)
			{
				USpeaker.field_Internal_Static_Single_1 = (B ? float.MaxValue : 1f);
			}, false);
			qmnestedButton.AddButton("8k(BitRate)", "8k (BitRate)", delegate
			{
				Utils.CurrentUser.Method_Public_get_USpeaker_0().field_Public_BitRate_0 = 0;
			}, null);
			qmnestedButton.AddButton("16k(BitRate)", "16k (BitRate)", delegate
			{
				Utils.CurrentUser.Method_Public_get_USpeaker_0().field_Public_BitRate_0 = 2;
			}, null);
			qmnestedButton.AddButton("18k(BitRate)", "18k (BitRate)", delegate
			{
				Utils.CurrentUser.Method_Public_get_USpeaker_0().field_Public_BitRate_0 = 3;
			}, null);
			qmnestedButton.AddButton("24k(Default)", "24k (Default)", delegate
			{
				Utils.CurrentUser.Method_Public_get_USpeaker_0().field_Public_BitRate_0 = 5;
			}, null);
			QMNestedButton qmnestedButton2 = Submenux.AddMenuPage("pickup Stuff", "pickup Stuff", "Fuck ur pickups", false, null);
			qmnestedButton2.AddToggle("pickup speed", "pickup speed", delegate(bool B)
			{
				Funny.pickupspeed(B ? 9f : 1.5f);
			}, false);
			qmnestedButton2.AddToggle("pickup speed MAX", "pickup speed MAX", delegate(bool B)
			{
				Funny.pickupspeed(B ? 1000f : 1.5f);
			}, false);
			qmnestedButton2.AddButton("pickup steal", "pickup steal", delegate
			{
				Funny.pickupsteal();
			}, null);
			qmnestedButton2.AddButton("bring pickup", "bring pickup", delegate
			{
				Funny.bringpickups();
			}, null);
			qmnestedButton2.AddButton("drop pickup", "drop pickup", delegate
			{
				Funny.droppickups();
			}, null);
			Submenux.AddToggle("Invis Join", "Only the master can see you", delegate(bool B)
			{
				Late_Night.invisjoin = B;
			}, Late_Night.invisjoin);
			Submenux.AddToggle("e1 ear fuck", "KYS", delegate(bool B)
			{
				StarLag.EArFUCKINGRAP = B;
			}, StarLag.EArFUCKINGRAP);
			Submenux.AddToggle("e9 crash", "KYS", delegate(bool B)
			{
				StarLag.ZaWaurldo = B;
			}, StarLag.ZaWaurldo);
			Submenux.AddToggle("e9 lag", "KYS", delegate(bool B)
			{
				StarLag.invalidobject = B;
			}, StarLag.invalidobject);
			QMNestedButton qmnestedButton3 = Submenux.AddMenuPage("World Hacks", "World Hacks", "Fuck ur World", false, null);
			QMNestedButton qmnestedButton4 = qmnestedButton3.AddMenuPage("FBT", "FBT", "FBT Hacks", false, null);
			qmnestedButton4.AddButton("Open All Doors", "Open All Doors", delegate
			{
				FBT.OpenAllRooms();
			}, null);
			QMNestedButton qmnestedButton5 = qmnestedButton3.AddMenuPage("just B", "just B", "Just B Hacks", false, null);
			qmnestedButton5.AddButton("Enter Room 1", "Enter Room 1", delegate
			{
				ClubB.Enter1();
			}, null);
			qmnestedButton5.AddButton("Enter Room 2", "Enter Room 2", delegate
			{
				ClubB.Enter2();
			}, null);
			qmnestedButton5.AddButton("Enter Room 3", "Enter Room 3", delegate
			{
				ClubB.Enter3();
			}, null);
			qmnestedButton5.AddButton("Enter Room 4", "Enter Room 4", delegate
			{
				ClubB.Enter4();
			}, null);
			qmnestedButton5.AddButton("Enter Room 5", "Enter Room 5", delegate
			{
				ClubB.Enter5();
			}, null);
			qmnestedButton5.AddButton("Enter Room 6", "Enter Room 6", delegate
			{
				ClubB.Enter6();
			}, null);
			qmnestedButton5.AddButton("Enter Room VIP", "Enter Room VIP", delegate
			{
				ClubB.EnterVip();
			}, null);
			QMNestedButton qmnestedButton6 = qmnestedButton3.AddMenuPage("Murder hax", "Murder hax", "e", false, null);
			qmnestedButton6.AddButton("Start Game", "Start Game", delegate
			{
				murder.Start();
			}, null);
			qmnestedButton6.AddButton("Abort", "Abort", delegate
			{
				murder.Abort();
			}, null);
			qmnestedButton6.AddButton("ByStander Win", "ByStander Win", delegate
			{
				murder.ByStandWin();
			}, null);
			qmnestedButton6.AddButton("Murder Win", "Murder Win", delegate
			{
				murder.MurderWin();
			}, null);
			qmnestedButton6.AddButton("Kill All", "Kill All", delegate
			{
				murder.KillAll();
			}, null);
			qmnestedButton6.AddButton("Blind All", "Blind All", delegate
			{
				murder.BlindAll();
			}, null);
			qmnestedButton6.AddButton("Frag", "Frag", delegate
			{
				murder.bringFrag();
			}, null);
			qmnestedButton6.AddButton("knife", "knife", delegate
			{
				murder.bringKnife();
			}, null);
			qmnestedButton6.AddButton("Luger", "Luger", delegate
			{
				murder.bringLuger();
			}, null);
			qmnestedButton6.AddButton("Revolver", "Revolver", delegate
			{
				murder.bringRevolver();
			}, null);
			qmnestedButton6.AddButton("Shotgun", "Shotgun", delegate
			{
				murder.bringShotgun();
			}, null);
			qmnestedButton6.AddButton("Self Murder", "Murder", delegate
			{
				murder.SetPlayerM(PlayerWrapper.GetCurrentPlayer().GetPlayer());
			}, null);
			qmnestedButton6.AddButton("Self Detective", "Detective", delegate
			{
				murder.SetPlayerD(PlayerWrapper.GetCurrentPlayer().GetPlayer());
			}, null);
			qmnestedButton6.AddButton("Self Bystander", "Bystander", delegate
			{
				murder.SetPlayerB(PlayerWrapper.GetCurrentPlayer().GetPlayer());
			}, null);
			QMNestedButton qmnestedButton7 = qmnestedButton3.AddMenuPage("Among Us hax", "Among Us hax", "a", false, null);
			qmnestedButton7.AddButton("Start Game", "Start Game", delegate
			{
				Amungus.Start();
			}, null);
			qmnestedButton7.AddButton("Abort", "Abort", delegate
			{
				Amungus.Abort();
			}, null);
			qmnestedButton7.AddButton("Crew Win", "Crew Win", delegate
			{
				Amungus.CrewWin();
			}, null);
			qmnestedButton7.AddButton("Imposter Win", "Imposter Win", delegate
			{
				Amungus.InpostWin();
			}, null);
			qmnestedButton7.AddButton("Kill All", "Kill All", delegate
			{
				Amungus.KillAll();
			}, null);
			qmnestedButton7.AddButton("Emergency Meeting", "Emergency Meeting", delegate
			{
				Amungus.EM();
			}, null);
			qmnestedButton7.AddButton("Skip Vote", "Skip Vote", delegate
			{
				Amungus.SkipVote();
			}, null);
			qmnestedButton7.AddButton("Complete Task", "Complete Task", delegate
			{
				Amungus.taskcomplet();
			}, null);
			qmnestedButton7.AddButton("Close Vote", "Close Vote", delegate
			{
				Amungus.CloseVote();
			}, null);
			qmnestedButton7.AddButton("Self Crew", "Murder", delegate
			{
				Amungus.SetPlayerC(PlayerWrapper.GetCurrentPlayer().GetPlayer());
			}, null);
			qmnestedButton7.AddButton("Self Imposter", "Detective", delegate
			{
				Amungus.SetPlayerI(PlayerWrapper.GetCurrentPlayer().GetPlayer());
			}, null);
			QMNestedButton qmnestedButton8 = qmnestedButton3.AddMenuPage("H Party hax", "H Party hax", "sports", false, null);
			qmnestedButton8.AddButton("VR floor 1", "VR floor 1", delegate
			{
				Hparty.Floor2();
			}, null);
			qmnestedButton8.AddButton("VR floor 2", "VR floor 2", delegate
			{
				Hparty.Floor3();
			}, null);
			qmnestedButton8.AddButton("UnLock room 1", "UnLock room 1", delegate
			{
				Hparty.OpenRoom1();
			}, null);
			qmnestedButton8.AddButton("TP to room 1", "TP to room 1", delegate
			{
				Hparty.tpin1();
			}, null);
			qmnestedButton8.AddButton("UnLock room 2", "UnLock room 2", delegate
			{
				Hparty.OpenRoom2();
			}, null);
			qmnestedButton8.AddButton("TP to room 2", "TP to room 2", delegate
			{
				Hparty.tpin2();
			}, null);
			qmnestedButton8.AddButton("UnLock room 3", "UnLock room 3", delegate
			{
				Hparty.OpenRoom3();
			}, null);
			qmnestedButton8.AddButton("TP to room 3", "TP to room 3", delegate
			{
				Hparty.tpin3();
			}, null);
			qmnestedButton8.AddButton("UnLock room 4", "UnLock room 4", delegate
			{
				Hparty.OpenRoom4();
			}, null);
			qmnestedButton8.AddButton("TP to room 4", "TP to room 4", delegate
			{
				Hparty.tpin4();
			}, null);
			qmnestedButton8.AddButton("UnLock room 5", "UnLock room 5", delegate
			{
				Hparty.OpenRoom5();
			}, null);
			qmnestedButton8.AddButton("TP to room 5", "TP to room 5", delegate
			{
				Hparty.tpin5();
			}, null);
			qmnestedButton8.AddButton("UnLock room 6", "UnLock room 6", delegate
			{
				Hparty.OpenRoom6();
			}, null);
			qmnestedButton8.AddButton("TP to room 6", "TP to room 6", delegate
			{
				Hparty.tpin6();
			}, null);
			QMNestedButton qmnestedButton9 = qmnestedButton3.AddMenuPage("Midnight Roof Top", "Midnight Roof Top", "have world triggers on", false, null);
			qmnestedButton9.AddButton("Disable\nUp\nstairs", "DisableUpstairs", delegate
			{
				MIdNight.DisableUpstairs();
			}, null);
			qmnestedButton9.AddButton("Disable\nDown\nstairs", "DisableDownstairs", delegate
			{
				MIdNight.DisableDownstairs();
			}, null);
			qmnestedButton9.AddButton("Enable\nDown\nstairs", "EnableDownstairs", delegate
			{
				MIdNight.EnableDownstairs();
			}, null);
			qmnestedButton9.AddButton("Enable\nUp\nstairs", "EnableUpstairs", delegate
			{
				MIdNight.EnableUpstairs();
			}, null);
			qmnestedButton9.AddToggle("Keep Floors off", "Ass hole", delegate(bool B)
			{
				MIdNight.KeyOffFloor = B;
			}, MIdNight.KeyOffFloor);
			qmnestedButton9.AddToggle("Seizure Mode", "Seizure Mode", delegate(bool B)
			{
				MIdNight.Shake = B;
			}, MIdNight.Shake);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00010E50 File Offset: 0x0000F050
		internal static GameObject GetLocalPlayer()
		{
			foreach (GameObject gameObject in Funny.GetAllGameObjects())
			{
				bool flag = gameObject.name.StartsWith("VRCPlayer[Local]");
				if (flag)
				{
					return gameObject;
				}
			}
			return new GameObject();
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00010E9C File Offset: 0x0000F09C
		internal static GameObject[] GetAllGameObjects()
		{
			return SceneManager.GetActiveScene().GetRootGameObjects();
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00010EC0 File Offset: 0x0000F0C0
		internal static void pickupspeed(float Speed)
		{
			VRC_Pickup[] array = Resources.FindObjectsOfTypeAll<VRC_Pickup>().ToArray<VRC_Pickup>();
			foreach (VRC_Pickup vrc_Pickup in array)
			{
				bool flag = vrc_Pickup.gameObject;
				if (flag)
				{
					vrc_Pickup.ThrowVelocityBoostScale = Speed;
				}
			}
			VRC_Pickup[] array3 = Resources.FindObjectsOfTypeAll<VRC_Pickup>().ToArray<VRC_Pickup>();
			foreach (VRC_Pickup vrc_Pickup2 in array3)
			{
				bool flag2 = vrc_Pickup2.gameObject;
				if (flag2)
				{
					vrc_Pickup2.ThrowVelocityBoostScale = Speed;
				}
			}
			VRCPickup[] array5 = Resources.FindObjectsOfTypeAll<VRCPickup>().ToArray<VRCPickup>();
			foreach (VRCPickup vrcpickup in array5)
			{
				bool flag3 = vrcpickup.gameObject;
				if (flag3)
				{
					vrcpickup.ThrowVelocityBoostScale = Speed;
				}
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00010F98 File Offset: 0x0000F198
		internal static void pickupsteal()
		{
			VRC_Pickup[] array = Resources.FindObjectsOfTypeAll<VRC_Pickup>().ToArray<VRC_Pickup>();
			foreach (VRC_Pickup vrc_Pickup in array)
			{
				bool flag = vrc_Pickup.gameObject;
				if (flag)
				{
					vrc_Pickup.DisallowTheft = false;
				}
			}
			VRC_Pickup[] array3 = Resources.FindObjectsOfTypeAll<VRC_Pickup>().ToArray<VRC_Pickup>();
			foreach (VRC_Pickup vrc_Pickup2 in array3)
			{
				bool flag2 = vrc_Pickup2.gameObject;
				if (flag2)
				{
					vrc_Pickup2.DisallowTheft = false;
				}
			}
			VRCPickup[] array5 = Resources.FindObjectsOfTypeAll<VRCPickup>().ToArray<VRCPickup>();
			foreach (VRCPickup vrcpickup in array5)
			{
				bool flag3 = vrcpickup.gameObject;
				if (flag3)
				{
					vrcpickup.DisallowTheft = false;
				}
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00011070 File Offset: 0x0000F270
		internal static void bringpickups()
		{
			VRC_Pickup[] array = Resources.FindObjectsOfTypeAll<VRC_Pickup>().ToArray<VRC_Pickup>();
			foreach (VRC_Pickup vrc_Pickup in array)
			{
				bool flag = vrc_Pickup.gameObject;
				if (flag)
				{
					Networking.LocalPlayer.TakeOwnership(vrc_Pickup.gameObject);
					vrc_Pickup.transform.localPosition = new Vector3(0f, 0.3f, 0f);
					Transform transform = vrc_Pickup.transform;
					transform.position = VRCPlayer.field_Internal_Static_VRCPlayer_0.transform.position + new Vector3(0f, 0.1f, 0f);
				}
			}
			VRC_Pickup[] array3 = Resources.FindObjectsOfTypeAll<VRC_Pickup>().ToArray<VRC_Pickup>();
			foreach (VRC_Pickup vrc_Pickup2 in array3)
			{
				bool flag2 = vrc_Pickup2.gameObject;
				if (flag2)
				{
					Networking.LocalPlayer.TakeOwnership(vrc_Pickup2.gameObject);
					vrc_Pickup2.transform.localPosition = new Vector3(0f, 0.3f, 0f);
					Transform transform2 = vrc_Pickup2.transform;
					transform2.position = VRCPlayer.field_Internal_Static_VRCPlayer_0.transform.position + new Vector3(0f, 0.1f, 0f);
				}
			}
			VRCPickup[] array5 = Resources.FindObjectsOfTypeAll<VRCPickup>().ToArray<VRCPickup>();
			foreach (VRCPickup vrcpickup in array5)
			{
				bool flag3 = vrcpickup.gameObject;
				if (flag3)
				{
					Networking.LocalPlayer.TakeOwnership(vrcpickup.gameObject);
					vrcpickup.transform.localPosition = new Vector3(0f, 0.3f, 0f);
					Transform transform3 = vrcpickup.transform;
					transform3.position = VRCPlayer.field_Internal_Static_VRCPlayer_0.transform.position + new Vector3(0f, 0.1f, 0f);
				}
			}
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00011288 File Offset: 0x0000F488
		internal static void droppickups()
		{
			VRC_Pickup[] array = Resources.FindObjectsOfTypeAll<VRC_Pickup>().ToArray<VRC_Pickup>();
			foreach (VRC_Pickup vrc_Pickup in array)
			{
				bool flag = vrc_Pickup.gameObject;
				if (flag)
				{
					Networking.LocalPlayer.TakeOwnership(vrc_Pickup.gameObject);
					vrc_Pickup.Drop();
				}
			}
			VRC_Pickup[] array3 = Resources.FindObjectsOfTypeAll<VRC_Pickup>().ToArray<VRC_Pickup>();
			foreach (VRC_Pickup vrc_Pickup2 in array3)
			{
				bool flag2 = vrc_Pickup2.gameObject;
				if (flag2)
				{
					Networking.LocalPlayer.TakeOwnership(vrc_Pickup2.gameObject);
					vrc_Pickup2.Drop();
				}
			}
			VRCPickup[] array5 = Resources.FindObjectsOfTypeAll<VRCPickup>().ToArray<VRCPickup>();
			foreach (VRCPickup vrcpickup in array5)
			{
				bool flag3 = vrcpickup.gameObject;
				if (flag3)
				{
					Networking.LocalPlayer.TakeOwnership(vrcpickup.gameObject);
					vrcpickup.Drop();
				}
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00011398 File Offset: 0x0000F598
		internal static void bringpickupsTOPLAYER(Player P)
		{
			VRC_Pickup[] array = Resources.FindObjectsOfTypeAll<VRC_Pickup>().ToArray<VRC_Pickup>();
			foreach (VRC_Pickup vrc_Pickup in array)
			{
				bool flag = vrc_Pickup.gameObject;
				if (flag)
				{
					Networking.LocalPlayer.TakeOwnership(vrc_Pickup.gameObject);
					vrc_Pickup.transform.localPosition = new Vector3(0f, 0.3f, 0f);
					Transform transform = vrc_Pickup.transform;
					transform.position = P.transform.position + new Vector3(0f, 0.3f, 0f);
				}
			}
			VRC_Pickup[] array3 = Resources.FindObjectsOfTypeAll<VRC_Pickup>().ToArray<VRC_Pickup>();
			foreach (VRC_Pickup vrc_Pickup2 in array3)
			{
				bool flag2 = vrc_Pickup2.gameObject;
				if (flag2)
				{
					Networking.LocalPlayer.TakeOwnership(vrc_Pickup2.gameObject);
					vrc_Pickup2.transform.localPosition = new Vector3(0f, 0.3f, 0f);
					Transform transform2 = vrc_Pickup2.transform;
					transform2.position = P.transform.position + new Vector3(0f, 0.3f, 0f);
				}
			}
			VRCPickup[] array5 = Resources.FindObjectsOfTypeAll<VRCPickup>().ToArray<VRCPickup>();
			foreach (VRCPickup vrcpickup in array5)
			{
				bool flag3 = vrcpickup.gameObject;
				if (flag3)
				{
					Networking.LocalPlayer.TakeOwnership(vrcpickup.gameObject);
					vrcpickup.transform.localPosition = new Vector3(0f, 0.3f, 0f);
					Transform transform3 = vrcpickup.transform;
					transform3.position = P.transform.position + new Vector3(0f, 0.3f, 0f);
				}
			}
		}
	}
}
