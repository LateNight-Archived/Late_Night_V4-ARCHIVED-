using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppSystem.Collections.Generic;
using Late_Night_V3_colnsole;
using Transmtn.DTO;
using Transmtn.DTO.Notifications;
using UnityEngine;
using VRC.Core;

namespace DayClientML2.Utility.Extensions
{
	// Token: 0x0200005E RID: 94
	public static class NotificationManagerExtension
	{
		// Token: 0x0600038E RID: 910 RVA: 0x0001ACC5 File Offset: 0x00018EC5
		public static void SendNotification(this NotificationManager Instance, string UserID, string Type, string IDKISEMPTY, NotificationDetails notificationDetails)
		{
			Instance.Method_Private_Void_String_String_String_NotificationDetails_0(UserID, Type, IDKISEMPTY, notificationDetails);
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0001ACD4 File Offset: 0x00018ED4
		public static void SendNotification(this NotificationManager Instance, Notification notification, byte[] ImageData = null)
		{
			Utils.VRCWebSocketsManager.Method_Public_get_Api_0().PostOffice.Send(notification, ImageData);
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0001ACF4 File Offset: 0x00018EF4
		public static Notification GetNotification(this NotificationManager Instance)
		{
			return Instance.field_Private_Notification_0;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0001AD0C File Offset: 0x00018F0C
		public static void DismissNotification(this VRCWebSocketsManager Instance, Notification notification)
		{
			Instance.Method_Public_get_Api_0().PostOffice.See(notification);
			Instance.Method_Public_get_Api_0().PostOffice.MarkAsSeen(notification);
			Instance.Method_Public_get_Api_0().PostOffice.Hide(notification);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0001AD45 File Offset: 0x00018F45
		public static void SendNotification(this VRCWebSocketsManager Instance, Notification notification)
		{
			Instance.Method_Public_get_Api_0().PostOffice.Send(notification, null);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0001AD5C File Offset: 0x00018F5C
		public static void SendInvite(this VRCWebSocketsManager Instance, string Message, string UserID)
		{
			Instance.Method_Public_get_Api_0().PostOffice.Send(Invite.Create(UserID, "", new Location("", new Instance("", UserID, "", "", "", false)), Message), null);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0001ADB0 File Offset: 0x00018FB0
		public static void SendInviteEZ()
		{
			APIUser apiuser = Utils.VRCUiManager.SelectedAPIUser();
			Utils.VRCWebSocketsManager.SendNotification(Invite.Create(apiuser.id, "", new Location(RoomManagerExtension.GetWorld().id, RoomManagerExtension.GetWorldInstance().instanceId), ""));
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0001AE04 File Offset: 0x00019004
		public static void SendRequestEZ()
		{
			APIUser apiuser = Utils.VRCUiManager.SelectedAPIUser();
			NotificationDetails notificationDetails = new NotificationDetails();
			Notification notification = Notification.Create(apiuser.id, Notification.NotificationType.Requestinvite, "", notificationDetails);
			Utils.VRCWebSocketsManager.SendNotification(notification);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0001AE48 File Offset: 0x00019048
		public static void SendRequestNormal()
		{
			APIUser apiuser = Utils.VRCUiManager.SelectedAPIUser();
			NotificationDetails notificationDetails = new NotificationDetails();
			Notification notification = Notification.Create(apiuser.id, Notification.NotificationType.Requestinvite, "", notificationDetails);
			Utils.VRCWebSocketsManager.SendNotification(notification);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0001AE8A File Offset: 0x0001908A
		public static void SendInviteByID(string ID)
		{
			Utils.VRCWebSocketsManager.SendNotification(Invite.Create(ID, "", new Location(RoomManagerExtension.GetWorld().id, RoomManagerExtension.GetWorldInstance().instanceId), ""));
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0001AEC4 File Offset: 0x000190C4
		public static void SendRequestBYID(string Id)
		{
			NotificationDetails notificationDetails = new NotificationDetails();
			Notification notification = Notification.Create(Id, Notification.NotificationType.Requestinvite, "", notificationDetails);
			Utils.VRCWebSocketsManager.SendNotification(notification);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0001AEF6 File Offset: 0x000190F6
		public static IEnumerator InvAll(float WaitBetweenPlayer)
		{
			List<string> AllPlayers = APIUser.CurrentUser.friendIDs;
			List<string>.Enumerator enumerator = AllPlayers.GetEnumerator();
			while (enumerator.MoveNext())
			{
				NotificationManagerExtension.<>c__DisplayClass11_0 CS$<>8__locals1 = new NotificationManagerExtension.<>c__DisplayClass11_0();
				CS$<>8__locals1.friendid = enumerator.Current;
				APIUser.FetchUser(CS$<>8__locals1.friendid, delegate(APIUser friend)
				{
					LNCcolnsole.Log("Trying User :" + friend.displayName, false, ConsoleColor.Blue);
					NotificationManagerExtension.OnlineCheck(friend);
				}, delegate(string message)
				{
					LNCcolnsole.Log("[API] Failed Fetching Friend : " + CS$<>8__locals1.friendid, false, ConsoleColor.White);
				});
				yield return new WaitForSeconds(WaitBetweenPlayer);
				CS$<>8__locals1 = null;
			}
			enumerator = null;
			LNCcolnsole.Log("Done!!!", true, ConsoleColor.Cyan);
			yield return null;
			yield break;
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0001AF05 File Offset: 0x00019105
		public static IEnumerator ReqAll(float WaitBetweenPlayer)
		{
			List<string> AllPlayers = APIUser.CurrentUser.friendIDs;
			List<string>.Enumerator enumerator = AllPlayers.GetEnumerator();
			while (enumerator.MoveNext())
			{
				NotificationManagerExtension.<>c__DisplayClass12_0 CS$<>8__locals1 = new NotificationManagerExtension.<>c__DisplayClass12_0();
				CS$<>8__locals1.friendid = enumerator.Current;
				APIUser.FetchUser(CS$<>8__locals1.friendid, delegate(APIUser friend)
				{
					LNCcolnsole.Log("Trying User :" + friend.displayName, false, ConsoleColor.Blue);
					NotificationManagerExtension.OnlineCheckFORREQ(friend);
				}, delegate(string message)
				{
					LNCcolnsole.Log("[API] Failed Fetching Friend : " + CS$<>8__locals1.friendid, false, ConsoleColor.White);
				});
				yield return new WaitForSeconds(WaitBetweenPlayer);
				CS$<>8__locals1 = null;
			}
			enumerator = null;
			LNCcolnsole.Log("Done!!!", true, ConsoleColor.Cyan);
			yield return null;
			yield break;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0001AF14 File Offset: 0x00019114
		public static void OnlineCheck(APIUser friend)
		{
			bool flag = friend.state != "online";
			if (!flag)
			{
				NotificationManagerExtension.SendInviteByID(friend.id);
				LNCcolnsole.Log("Sent Ivite to :" + friend.displayName, true, ConsoleColor.Green);
			}
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0001AF60 File Offset: 0x00019160
		public static void OnlineCheckFORREQ(APIUser friend)
		{
			bool flag = friend.state != "online";
			if (!flag)
			{
				NotificationManagerExtension.SendRequestBYID(friend.id);
				LNCcolnsole.Log("Sent Request to :" + friend.displayName, true, ConsoleColor.Green);
			}
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0001AFA9 File Offset: 0x000191A9
		public static IEnumerator InvBYlistOfIds(float WaitBetweenPlayer, List<string> ID)
		{
			using (List<string>.Enumerator enumerator = ID.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					NotificationManagerExtension.<>c__DisplayClass15_0 CS$<>8__locals1 = new NotificationManagerExtension.<>c__DisplayClass15_0();
					CS$<>8__locals1.friendid = enumerator.Current;
					APIUser.FetchUser(CS$<>8__locals1.friendid, delegate(APIUser friend)
					{
						LNCcolnsole.Log("Trying User :" + friend.displayName, false, ConsoleColor.Blue);
						NotificationManagerExtension.OnlineCheck(friend);
					}, delegate(string message)
					{
						LNCcolnsole.Log("[API] Failed Fetching Friend : " + CS$<>8__locals1.friendid, false, ConsoleColor.White);
					});
					yield return new WaitForSeconds(WaitBetweenPlayer);
					CS$<>8__locals1 = null;
				}
			}
			List<string>.Enumerator enumerator = default(List<string>.Enumerator);
			LNCcolnsole.Log("Done!!!", true, ConsoleColor.Cyan);
			yield return null;
			yield break;
			yield break;
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0001AFBF File Offset: 0x000191BF
		public static IEnumerator ReBYlistOfId(float WaitBetweenPlayer, List<string> ID)
		{
			using (List<string>.Enumerator enumerator = ID.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					NotificationManagerExtension.<>c__DisplayClass16_0 CS$<>8__locals1 = new NotificationManagerExtension.<>c__DisplayClass16_0();
					CS$<>8__locals1.friendid = enumerator.Current;
					APIUser.FetchUser(CS$<>8__locals1.friendid, delegate(APIUser friend)
					{
						LNCcolnsole.Log("Trying User :" + friend.displayName, false, ConsoleColor.Blue);
						NotificationManagerExtension.OnlineCheckFORREQ(friend);
					}, delegate(string message)
					{
						LNCcolnsole.Log("[API] Failed Fetching Friend : " + CS$<>8__locals1.friendid, false, ConsoleColor.White);
					});
					yield return new WaitForSeconds(WaitBetweenPlayer);
					CS$<>8__locals1 = null;
				}
			}
			List<string>.Enumerator enumerator = default(List<string>.Enumerator);
			LNCcolnsole.Log("Done!!!", true, ConsoleColor.Cyan);
			yield return null;
			yield break;
			yield break;
		}
	}
}
