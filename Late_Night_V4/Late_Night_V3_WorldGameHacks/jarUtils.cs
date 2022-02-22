using System;
using System.Collections.Generic;
using System.Linq;
using UnhollowerBaseLib;
using UnityEngine;
using VRC;
using VRC.Networking;
using VRC.Udon;

namespace Late_Night_V3_WorldGameHacks
{
	// Token: 0x0200000D RID: 13
	public class jarUtils
	{
		// Token: 0x06000096 RID: 150 RVA: 0x00004FF0 File Offset: 0x000031F0
		public static GameObject getplayernode(Player A)
		{
			Il2CppReferenceArray<Player> il2CppReferenceArray = GameObject.Find("PlayerManager").GetComponent<PlayerManager>().Method_Public_get_ArrayOf_Player_0();
			int num = 0;
			int num2 = 0;
			foreach (Player player in il2CppReferenceArray)
			{
				bool flag = player == A;
				if (flag)
				{
					num2 = num;
				}
				else
				{
					num++;
				}
			}
			IEnumerable<GameObject> enumerable = from G in Resources.FindObjectsOfTypeAll<GameObject>()
			where G.GetComponent<UdonBehaviour>() != null && G.GetComponent<UdonSync>() != null && G.name.StartsWith("Player Node")
			select G;
			foreach (GameObject gameObject in enumerable)
			{
				bool flag2 = gameObject.name.Contains("(" + num2.ToString() + ")");
				if (flag2)
				{
					return gameObject;
				}
			}
			return null;
		}
	}
}
