using System;
using DayClientML2.Utility.Extensions;
using ExitGames.Client.Photon;
using Il2CppSystem;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using VRC;
using VRC.SDKBase;

namespace Late_Night_V3_StarLag
{
	// Token: 0x02000013 RID: 19
	internal class StarLag
	{
		// Token: 0x060000AF RID: 175 RVA: 0x000057C8 File Offset: 0x000039C8
		public static void shitToUpdate()
		{
			try
			{
				StarLag.Delay += Time.deltaTime;
				bool flag = StarLag.Delay > StarLag.timeing;
				if (flag)
				{
					bool flag2 = StarLag.ZaWaurldo && !StarLag.invalidobject;
					if (flag2)
					{
						byte[] array = new byte[8];
						Buffer.BlockCopy(BitConverter.GetBytes(int.Parse(Player.Method_Internal_Static_get_Player_0().field_Private_VRCPlayerApi_0.playerId.ToString() + "00001")), 0, array, 0, 4);
						for (int i = 0; i < 300; i++)
						{
							RaiseEventOptions raiseEventOptions = new RaiseEventOptions
							{
								field_Public_ReceiverGroup_0 = 0,
								field_Public_EventCaching_0 = 0
							};
							SendOptions sendReliable = SendOptions.SendReliable;
							StarLag.OpRaiseEvent(9, array, raiseEventOptions, sendReliable);
						}
					}
					bool flag3 = !StarLag.ZaWaurldo && StarLag.invalidobject;
					if (flag3)
					{
						byte[] array2 = new byte[8];
						Buffer.BlockCopy(BitConverter.GetBytes(int.Parse(Player.Method_Internal_Static_get_Player_0().field_Private_VRCPlayerApi_0.playerId.ToString() + "00001")), 0, array2, 0, 4);
						for (int j = 0; j < 80; j++)
						{
							RaiseEventOptions raiseEventOptions2 = new RaiseEventOptions
							{
								field_Public_ReceiverGroup_0 = 0,
								field_Public_EventCaching_0 = 0
							};
							SendOptions sendReliable2 = SendOptions.SendReliable;
							StarLag.OpRaiseEvent(9, array2, raiseEventOptions2, sendReliable2);
						}
					}
					StarLag.Delay = 0f;
				}
			}
			catch
			{
			}
			try
			{
				StarLag.Delay2 += Time.deltaTime;
				bool flag4 = StarLag.Delay2 <= 0.06f;
				if (!flag4)
				{
					bool flag5 = StarLag.EArFUCKINGRAP && RoomManager.Method_Public_Static_get_Boolean_3();
					if (flag5)
					{
						byte[] array3 = new byte[]
						{
							1,
							0,
							0,
							0,
							173,
							120,
							105,
							155,
							187,
							134,
							59,
							0,
							248,
							125,
							232,
							192,
							92,
							160,
							82,
							254,
							48,
							228,
							30,
							187,
							149,
							196,
							177,
							215,
							140,
							223,
							127,
							209,
							66,
							60,
							0,
							226,
							53,
							180,
							176,
							97,
							104,
							4,
							248,
							238,
							195,
							134,
							44,
							185,
							182,
							68,
							94,
							114,
							205,
							181,
							150,
							56,
							232,
							126,
							247,
							155,
							123,
							172,
							108,
							98,
							80,
							56,
							113,
							89,
							160,
							134,
							221
						};
						int actorNumber = PlayerExtensions.LocalPlayer.GetActorNumber();
						byte[] bytes = BitConverter.GetBytes(actorNumber);
						Buffer.BlockCopy(bytes, 0, array3, 0, 4);
						Buffer.BlockCopy(BitConverter.GetBytes(Networking.GetServerTimeInMilliseconds()), 0, array3, 4, 4);
						StarLag.OpRaiseEvent(1, array3, new RaiseEventOptions
						{
							field_Public_ReceiverGroup_0 = 1
						}, SendOptions.SendUnreliable);
					}
					StarLag.Delay2 = 0f;
				}
			}
			catch
			{
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00005A3C File Offset: 0x00003C3C
		public static void OpRaiseEvent(byte code, object customObject, RaiseEventOptions RaiseEventOptions, SendOptions sendOptions)
		{
			Object customObject2 = Serialization.FromManagedToIL2CPP<Object>(customObject);
			StarLag.OpRaiseEvent(code, customObject2, RaiseEventOptions, sendOptions);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00005A5B File Offset: 0x00003C5B
		public static void OpRaiseEvent(byte code, Object customObject, RaiseEventOptions RaiseEventOptions, SendOptions sendOptions)
		{
			PhotonNetwork.field_Public_Static_LoadBalancingClient_0.Method_Public_Virtual_New_Boolean_Byte_Object_RaiseEventOptions_SendOptions_0(code, customObject, RaiseEventOptions, sendOptions);
		}

		// Token: 0x0400005D RID: 93
		public static bool invalidobject;

		// Token: 0x0400005E RID: 94
		public static bool ZaWaurldo;

		// Token: 0x0400005F RID: 95
		public static float timeing = 1f;

		// Token: 0x04000060 RID: 96
		public static bool EArFUCKINGRAP;

		// Token: 0x04000061 RID: 97
		public static float Delay;

		// Token: 0x04000062 RID: 98
		public static float Delay2;
	}
}
