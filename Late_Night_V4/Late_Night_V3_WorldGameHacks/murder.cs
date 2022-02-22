using System;
using System.Collections.Generic;
using System.Linq;
using UnhollowerBaseLib;
using UnityEngine;
using VRC;
using VRC.SDK3.Components;
using VRC.SDKBase;
using VRC.Udon;

namespace Late_Night_V3_WorldGameHacks
{
	// Token: 0x02000009 RID: 9
	internal class murder
	{
		// Token: 0x0600005F RID: 95 RVA: 0x0000400C File Offset: 0x0000220C
		public static bool Inworld()
		{
			return RoomManager.Method_Internal_Static_get_String_0().Contains(murder.WORLDID);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00004030 File Offset: 0x00002230
		public static void bringRevolver()
		{
			bool flag = !murder.Inworld();
			if (!flag)
			{
				Il2CppArrayBase<GameObject> source = Resources.FindObjectsOfTypeAll<GameObject>();
				List<GameObject> source2 = (from gameObject in source
				where gameObject.name.Contains("Revolver")
				select gameObject).ToList<GameObject>();
				foreach (GameObject gameObject2 in from A in source2
				where A.GetComponent<VRCPickup>()
				select A)
				{
					Networking.SetOwner(VRCPlayer.field_Internal_Static_VRCPlayer_0.field_Private_VRCPlayerApi_0, gameObject2);
					gameObject2.transform.position = VRCPlayer.field_Internal_Static_VRCPlayer_0.transform.position + new Vector3(0f, 0.1f, 0f);
				}
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00004124 File Offset: 0x00002324
		public static void bringKnife()
		{
			bool flag = !murder.Inworld();
			if (!flag)
			{
				List<GameObject> source = (from gameObject in Resources.FindObjectsOfTypeAll<GameObject>()
				where gameObject.name.Contains("Knife")
				select gameObject).ToList<GameObject>();
				foreach (GameObject gameObject2 in from A in source
				where A.GetComponent<VRCPickup>()
				select A)
				{
					Networking.SetOwner(VRCPlayer.field_Internal_Static_VRCPlayer_0.field_Private_VRCPlayerApi_0, gameObject2);
					gameObject2.transform.position = VRCPlayer.field_Internal_Static_VRCPlayer_0.transform.position + new Vector3(0f, 0.1f, 0f);
				}
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00004214 File Offset: 0x00002414
		public static void bringLuger()
		{
			bool flag = !murder.Inworld();
			if (!flag)
			{
				List<GameObject> source = (from gameObject in Resources.FindObjectsOfTypeAll<GameObject>()
				where gameObject.name.Contains("Luger")
				select gameObject).ToList<GameObject>();
				foreach (GameObject gameObject2 in from A in source
				where A.GetComponent<VRCPickup>()
				select A)
				{
					Networking.SetOwner(VRCPlayer.field_Internal_Static_VRCPlayer_0.field_Private_VRCPlayerApi_0, gameObject2);
					gameObject2.transform.position = VRCPlayer.field_Internal_Static_VRCPlayer_0.transform.position + new Vector3(0f, 0.1f, 0f);
				}
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00004304 File Offset: 0x00002504
		public static void bringFrag()
		{
			bool flag = !murder.Inworld();
			if (!flag)
			{
				List<GameObject> source = (from gameObject in Resources.FindObjectsOfTypeAll<GameObject>()
				where gameObject.name.Contains("Frag")
				select gameObject).ToList<GameObject>();
				foreach (GameObject gameObject2 in from A in source
				where A.GetComponent<VRCPickup>()
				select A)
				{
					Networking.SetOwner(VRCPlayer.field_Internal_Static_VRCPlayer_0.field_Private_VRCPlayerApi_0, gameObject2);
					gameObject2.transform.position = VRCPlayer.field_Internal_Static_VRCPlayer_0.transform.position + new Vector3(0f, 0.1f, 0f);
				}
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000043F4 File Offset: 0x000025F4
		public static void bringShotgun()
		{
			bool flag = !murder.Inworld();
			if (!flag)
			{
				List<GameObject> source = (from gameObject in Resources.FindObjectsOfTypeAll<GameObject>()
				where gameObject.name.Contains("Shotgun")
				select gameObject).ToList<GameObject>();
				foreach (GameObject gameObject2 in from A in source
				where A.GetComponent<VRCPickup>()
				select A)
				{
					Networking.SetOwner(VRCPlayer.field_Internal_Static_VRCPlayer_0.field_Private_VRCPlayerApi_0, gameObject2);
					gameObject2.transform.position = VRCPlayer.field_Internal_Static_VRCPlayer_0.transform.position + new Vector3(0f, 0.1f, 0f);
				}
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000044E4 File Offset: 0x000026E4
		public static void KillAll()
		{
			bool flag = !murder.Inworld();
			if (!flag)
			{
				foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
				{
					bool flag2 = gameObject.name.Contains("Game Logic");
					if (flag2)
					{
						gameObject.GetComponent<UdonBehaviour>().SendCustomNetworkEvent(0, "KillLocalPlayer");
					}
				}
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00004564 File Offset: 0x00002764
		public static void BlindAll()
		{
			bool flag = !murder.Inworld();
			if (!flag)
			{
				foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
				{
					bool flag2 = gameObject.name.Contains("Game Logic");
					if (flag2)
					{
						gameObject.GetComponent<UdonBehaviour>().SendCustomNetworkEvent(0, "OnLocalPlayerBlinded");
					}
				}
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000045E4 File Offset: 0x000027E4
		public static void Start()
		{
			bool flag = !murder.Inworld();
			if (!flag)
			{
				foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
				{
					bool flag2 = gameObject.name.Contains("Game Logic");
					if (flag2)
					{
						gameObject.GetComponent<UdonBehaviour>().SendCustomNetworkEvent(0, "SyncStart");
					}
				}
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00004664 File Offset: 0x00002864
		public static void Abort()
		{
			bool flag = !murder.Inworld();
			if (!flag)
			{
				foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
				{
					bool flag2 = gameObject.name.Contains("Game Logic");
					if (flag2)
					{
						gameObject.GetComponent<UdonBehaviour>().SendCustomNetworkEvent(0, "SyncAbort");
					}
				}
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000046E4 File Offset: 0x000028E4
		public static void MurderWin()
		{
			bool flag = !murder.Inworld();
			if (!flag)
			{
				foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
				{
					bool flag2 = gameObject.name.Contains("Game Logic");
					if (flag2)
					{
						gameObject.GetComponent<UdonBehaviour>().SendCustomNetworkEvent(0, "SyncVictoryM");
					}
				}
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00004764 File Offset: 0x00002964
		public static void ByStandWin()
		{
			bool flag = !murder.Inworld();
			if (!flag)
			{
				foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
				{
					bool flag2 = gameObject.name.Contains("Game Logic");
					if (flag2)
					{
						gameObject.GetComponent<UdonBehaviour>().SendCustomNetworkEvent(0, "SyncVictoryB");
					}
				}
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000047E4 File Offset: 0x000029E4
		public static void SetPlayerM(Player A)
		{
			bool flag = !murder.Inworld();
			if (!flag)
			{
				GameObject gameObject = jarUtils.getplayernode(A);
				bool flag2 = gameObject == null || gameObject.GetComponent<UdonBehaviour>() == null;
				if (flag2)
				{
					throw new NullReferenceException();
				}
				gameObject.GetComponent<UdonBehaviour>().SendCustomNetworkEvent(0, "SyncAssignM");
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000483C File Offset: 0x00002A3C
		public static void SetPlayerD(Player A)
		{
			bool flag = !murder.Inworld();
			if (!flag)
			{
				GameObject gameObject = jarUtils.getplayernode(A);
				bool flag2 = gameObject == null || gameObject.GetComponent<UdonBehaviour>() == null;
				if (flag2)
				{
					throw new NullReferenceException();
				}
				gameObject.GetComponent<UdonBehaviour>().SendCustomNetworkEvent(0, "SyncAssignD");
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00004894 File Offset: 0x00002A94
		public static void SetPlayerB(Player A)
		{
			bool flag = !murder.Inworld();
			if (!flag)
			{
				GameObject gameObject = jarUtils.getplayernode(A);
				bool flag2 = gameObject == null || gameObject.GetComponent<UdonBehaviour>() == null;
				if (flag2)
				{
					throw new NullReferenceException();
				}
				gameObject.GetComponent<UdonBehaviour>().SendCustomNetworkEvent(0, "SyncAssignB");
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000048EC File Offset: 0x00002AEC
		public static void Killplayer(Player A)
		{
			bool flag = !murder.Inworld();
			if (!flag)
			{
				GameObject gameObject = jarUtils.getplayernode(A);
				bool flag2 = gameObject == null || gameObject.GetComponent<UdonBehaviour>() == null;
				if (flag2)
				{
					throw new NullReferenceException();
				}
				gameObject.GetComponent<UdonBehaviour>().SendCustomNetworkEvent(0, "SyncKill");
			}
		}

		// Token: 0x04000013 RID: 19
		public static string WORLDID = "wrld_858dfdfc-1b48-4e1e-8a43-f0edc611e5fe";
	}
}
