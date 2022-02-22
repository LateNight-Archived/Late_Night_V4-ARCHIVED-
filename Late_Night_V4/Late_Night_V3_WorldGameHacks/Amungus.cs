using System;
using UnityEngine;
using VRC;
using VRC.Udon;

namespace Late_Night_V3_WorldGameHacks
{
	// Token: 0x02000008 RID: 8
	internal class Amungus
	{
		// Token: 0x0600004F RID: 79 RVA: 0x000039CC File Offset: 0x00001BCC
		public static bool Inworld()
		{
			return RoomManager.Method_Internal_Static_get_String_0().Contains(Amungus.WORLDID);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000039F0 File Offset: 0x00001BF0
		public static void taskcomplet()
		{
			bool flag = !Amungus.Inworld();
			if (!flag)
			{
				foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
				{
					bool flag2 = gameObject.name.Contains("Game Logic");
					if (flag2)
					{
						gameObject.GetComponent<UdonBehaviour>().SendCustomNetworkEvent(0, "OnLocalPlayerCompletedTask");
					}
				}
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003A70 File Offset: 0x00001C70
		public static void CloseVote()
		{
			bool flag = !Amungus.Inworld();
			if (!flag)
			{
				foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
				{
					bool flag2 = gameObject.name.Contains("Game Logic");
					if (flag2)
					{
						gameObject.GetComponent<UdonBehaviour>().SendCustomNetworkEvent(0, "SyncCloseVoting");
					}
				}
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003AF0 File Offset: 0x00001CF0
		public static void Bodywasfound()
		{
			bool flag = !Amungus.Inworld();
			if (!flag)
			{
				foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
				{
					bool flag2 = gameObject.name.Contains("Game Logic");
					if (flag2)
					{
						gameObject.GetComponent<UdonBehaviour>().SendCustomNetworkEvent(0, "OnBodyWasFound");
					}
				}
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003B70 File Offset: 0x00001D70
		public static void SkipVote()
		{
			bool flag = !Amungus.Inworld();
			if (!flag)
			{
				foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
				{
					bool flag2 = gameObject.name.Contains("Game Logic");
					if (flag2)
					{
						gameObject.GetComponent<UdonBehaviour>().SendCustomNetworkEvent(0, "Btn_SkipVoting");
					}
				}
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003BF0 File Offset: 0x00001DF0
		public static void EM()
		{
			bool flag = !Amungus.Inworld();
			if (!flag)
			{
				foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
				{
					bool flag2 = gameObject.name.Contains("Game Logic");
					if (flag2)
					{
						gameObject.GetComponent<UdonBehaviour>().SendCustomNetworkEvent(0, "StartMeeting");
					}
				}
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00003C70 File Offset: 0x00001E70
		public static void Start()
		{
			bool flag = !Amungus.Inworld();
			if (!flag)
			{
				foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
				{
					bool flag2 = gameObject.name.Contains("Game Logic");
					if (flag2)
					{
						gameObject.GetComponent<UdonBehaviour>().SendCustomNetworkEvent(0, "Btn_Start");
					}
				}
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003CF0 File Offset: 0x00001EF0
		public static void Abort()
		{
			bool flag = !Amungus.Inworld();
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

		// Token: 0x06000057 RID: 87 RVA: 0x00003D70 File Offset: 0x00001F70
		public static void InpostWin()
		{
			bool flag = !Amungus.Inworld();
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

		// Token: 0x06000058 RID: 88 RVA: 0x00003DF0 File Offset: 0x00001FF0
		public static void CrewWin()
		{
			bool flag = !Amungus.Inworld();
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

		// Token: 0x06000059 RID: 89 RVA: 0x00003E70 File Offset: 0x00002070
		public static void KillAll()
		{
			bool flag = !Amungus.Inworld();
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

		// Token: 0x0600005A RID: 90 RVA: 0x00003EF0 File Offset: 0x000020F0
		public static void SetPlayerC(Player A)
		{
			bool flag = !Amungus.Inworld();
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

		// Token: 0x0600005B RID: 91 RVA: 0x00003F48 File Offset: 0x00002148
		public static void SetPlayerI(Player A)
		{
			bool flag = !Amungus.Inworld();
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

		// Token: 0x0600005C RID: 92 RVA: 0x00003FA0 File Offset: 0x000021A0
		public static void Killplayer(Player A)
		{
			bool flag = !Amungus.Inworld();
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

		// Token: 0x04000012 RID: 18
		public static string WORLDID = "wrld_dd036610-a246-4f52-bf01-9d7cea3405d7";
	}
}
