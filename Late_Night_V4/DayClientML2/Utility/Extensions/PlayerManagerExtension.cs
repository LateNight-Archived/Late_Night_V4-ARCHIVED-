using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using VRC;
using VRC.Core;
using VRC.SDKBase;

namespace DayClientML2.Utility.Extensions
{
	// Token: 0x02000063 RID: 99
	public static class PlayerManagerExtension
	{
		// Token: 0x06000413 RID: 1043 RVA: 0x0001CC64 File Offset: 0x0001AE64
		public static List<Player> AllPlayers(this PlayerManager Instance)
		{
			return Instance.field_Private_List_1_Player_0.ToArray().ToList<Player>();
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0001CC88 File Offset: 0x0001AE88
		public static List<APIUser> AllApiUsers(this PlayerManager Instance)
		{
			return Instance.field_Private_List_1_Player_0.ToArray().ToList<Player>().ConvertAll<APIUser>((Player plr) => plr.GetAPIUser());
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0001CCD0 File Offset: 0x0001AED0
		public static List<int> AllPlayersIDs(this PlayerManager Instance)
		{
			return (from p in Instance.AllPlayers()
			select p.GetVRCPlayerApi().playerId).ToList<int>();
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0001CD14 File Offset: 0x0001AF14
		public static Player GetPlayer(this PlayerManager Instance, int Index)
		{
			List<Player> list = Instance.AllPlayers();
			return list[Index];
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0001CD34 File Offset: 0x0001AF34
		public static Player GetPlayerID(this PlayerManager Instance, int playerID)
		{
			List<Player> list = Instance.AllPlayers();
			return list.ToArray().FirstOrDefault((Player player) => player.GetVRCPlayerApi().playerId == playerID);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0001CD74 File Offset: 0x0001AF74
		public static Player GetPlayer(this PlayerManager Instance, string UserID)
		{
			List<Player> source = Instance.AllPlayers();
			return source.FirstOrDefault((Player t) => t.GetAPIUser().UserID() == UserID);
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0001CDAC File Offset: 0x0001AFAC
		public static Player GetInstanceOnwer(this PlayerManager Instance)
		{
			List<Player> source = Instance.AllPlayers();
			return source.FirstOrDefault((Player t) => t.GetVRCPlayerApi().isInstanceOwner);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0001CDEC File Offset: 0x0001AFEC
		public static Player GetPlayerByRayCast(this RaycastHit RayCast)
		{
			GameObject gameObject = RayCast.transform.gameObject;
			return Utils.PlayerManager.GetPlayer(VRCPlayerApi.GetPlayerByGameObject(gameObject).playerId);
		}
	}
}
