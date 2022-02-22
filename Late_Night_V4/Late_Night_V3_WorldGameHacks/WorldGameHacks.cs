using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Late_Night_V3_WorldGameHacks
{
	// Token: 0x02000005 RID: 5
	internal class WorldGameHacks
	{
		// Token: 0x0600003E RID: 62 RVA: 0x000033D4 File Offset: 0x000015D4
		internal static GameObject GetLocalPlayer()
		{
			foreach (GameObject gameObject in WorldGameHacks.GetAllGameObjects())
			{
				bool flag = gameObject.name.StartsWith("VRCPlayer[Local]");
				if (flag)
				{
					return gameObject;
				}
			}
			return new GameObject();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003420 File Offset: 0x00001620
		internal static GameObject[] GetAllGameObjects()
		{
			return SceneManager.GetActiveScene().GetRootGameObjects();
		}
	}
}
