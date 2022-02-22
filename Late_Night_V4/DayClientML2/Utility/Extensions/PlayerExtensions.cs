using System;
using UnityEngine;
using VRC;
using VRC.Core;
using VRC.SDKBase;

namespace DayClientML2.Utility.Extensions
{
	// Token: 0x02000062 RID: 98
	internal static class PlayerExtensions
	{
		// Token: 0x060003D0 RID: 976 RVA: 0x0001BDEC File Offset: 0x00019FEC
		public static APIUser GetAPIUser(this Player Instance)
		{
			return Instance.Method_Internal_get_APIUser_0();
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0001BE04 File Offset: 0x0001A004
		public static APIUser GetAPIUser(this VRCPlayer Instance)
		{
			return Instance.GetPlayer().GetAPIUser();
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x0001BE24 File Offset: 0x0001A024
		public static APIUser GetAPIUser(this PlayerNet Instance)
		{
			return Instance.GetPlayer().GetAPIUser();
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0001BE44 File Offset: 0x0001A044
		public static Player GetPlayer(this VRCPlayer Instance)
		{
			return (Instance == null) ? null : Instance._player;
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0001BE68 File Offset: 0x0001A068
		public static int GetActorNumber(this Player player)
		{
			return player.GetVRCPlayerApi().playerId;
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x0001BE85 File Offset: 0x0001A085
		public static Player LocalPlayer
		{
			get
			{
				return Player.Method_Internal_Static_get_Player_0();
			}
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0001BE8C File Offset: 0x0001A08C
		public static Player GetPlayer(this PlayerNet Instance)
		{
			return (Instance == null) ? null : Instance.Method_Public_get_Player_0();
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0001BEB0 File Offset: 0x0001A0B0
		public static Player GetPlayer(this VRCPlayerApi Instance)
		{
			return (Instance == null) ? null : Utils.PlayerManager.GetPlayerID(Instance.playerId);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0001BED8 File Offset: 0x0001A0D8
		public static Player GetTryPlayer(this APIUser Instance)
		{
			return (Instance == null) ? null : Utils.PlayerManager.GetPlayer(Instance.id);
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0001BF00 File Offset: 0x0001A100
		public static VRCPlayer GetVRCPlayer(this Player Instance)
		{
			return (Instance == null) ? null : Instance._vrcplayer;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0001BF24 File Offset: 0x0001A124
		public static VRCPlayer GetVRCPlayer(this PlayerNet Instance)
		{
			return (Instance == null) ? null : Instance._vrcPlayer;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0001BF48 File Offset: 0x0001A148
		public static VRCPlayer GetVRCPlayer(this VRCPlayerApi Instance)
		{
			return (Instance == null) ? null : Utils.PlayerManager.GetPlayerID(Instance.playerId).GetVRCPlayer();
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0001BF78 File Offset: 0x0001A178
		public static VRCPlayerApi GetVRCPlayerApi(this Player Instance)
		{
			return (Instance == null) ? null : Instance.Method_Public_get_VRCPlayerApi_0();
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0001BF9C File Offset: 0x0001A19C
		public static VRCPlayerApi GetVRCPlayerApi(this VRCPlayer Instance)
		{
			return (Instance == null) ? null : Instance.Method_Public_get_VRCPlayerApi_0();
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0001BFC0 File Offset: 0x0001A1C0
		public static VRCPlayerApi GetVRCPlayerApi(this PlayerNet Instance)
		{
			return (Instance == null) ? null : Instance.GetVRCPlayer().GetVRCPlayerApi();
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0001BFEC File Offset: 0x0001A1EC
		public static PlayerNet GetPlayerNet(this Player Instance)
		{
			return (Instance == null) ? null : Instance.Method_Internal_get_PlayerNet_0();
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0001C010 File Offset: 0x0001A210
		public static PlayerNet GetPlayerNet(this VRCPlayer Instance)
		{
			return (Instance == null) ? null : Instance.Method_Public_get_PlayerNet_0();
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0001C034 File Offset: 0x0001A234
		public static string UserID(this Player Instance)
		{
			return Instance.GetAPIUser().id;
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0001C054 File Offset: 0x0001A254
		public static string UserID(this VRCPlayer Instance)
		{
			return Instance.GetAPIUser().id;
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0001C074 File Offset: 0x0001A274
		public static string UserID(this PlayerNet Instance)
		{
			return Instance.GetAPIUser().id;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0001C094 File Offset: 0x0001A294
		public static string UserID(this APIUser Instance)
		{
			return Instance.id;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x0001C0AC File Offset: 0x0001A2AC
		public static string DisplayName(this Player Instance)
		{
			return Instance.GetAPIUser().displayName;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0001C0CC File Offset: 0x0001A2CC
		public static string DisplayName(this VRCPlayer Instance)
		{
			return Instance.GetAPIUser().displayName;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0001C0EC File Offset: 0x0001A2EC
		public static string DisplayName(this PlayerNet Instance)
		{
			return Instance.GetAPIUser().displayName;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0001C10C File Offset: 0x0001A30C
		public static string DisplayName(this APIUser Instance)
		{
			return Instance.displayName;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0001C124 File Offset: 0x0001A324
		public static bool GetIsMaster(this Player Instance)
		{
			return Instance.GetVRCPlayerApi().isMaster;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0001C144 File Offset: 0x0001A344
		public static bool GetIsMaster(this VRCPlayer Instance)
		{
			return Instance.GetVRCPlayerApi().isMaster;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0001C164 File Offset: 0x0001A364
		public static bool GetIsMaster(this PlayerNet Instance)
		{
			return Instance.GetVRCPlayerApi().isMaster;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0001C184 File Offset: 0x0001A384
		public static bool GetIsInVR(this Player Instance)
		{
			return Instance.GetVRCPlayerApi().IsUserInVR();
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0001C1A4 File Offset: 0x0001A3A4
		public static bool GetIsInVR(this VRCPlayer Instance)
		{
			return Instance.GetVRCPlayerApi().IsUserInVR();
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0001C1C4 File Offset: 0x0001A3C4
		public static bool GetIsInVR(this PlayerNet Instance)
		{
			return Instance.GetVRCPlayerApi().IsUserInVR();
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0001C1E4 File Offset: 0x0001A3E4
		public static short GetPing(this VRCPlayer Instance)
		{
			return Instance.GetPlayerNet().field_Private_Int16_0;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0001C204 File Offset: 0x0001A404
		public static float GetFrames(this VRCPlayer Instance)
		{
			return (Instance.GetPlayerNet().Method_Public_get_Byte_0() != 0) ? Mathf.Floor(1000f / (float)Instance.GetPlayerNet().Method_Public_get_Byte_0()) : -1f;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0001C244 File Offset: 0x0001A444
		public static float GetQuality(this VRCPlayer Instance)
		{
			return float.Parse((((!(Instance.GetPlayerNet() == null)) ? Instance.GetPlayerNet().Method_Internal_get_Single_0() : 0f) * 100f).ToString("0.00"));
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0001C290 File Offset: 0x0001A490
		public static double GetDelay(this VRCPlayer Instance)
		{
			int num = Mathf.FloorToInt((float)(Instance.GetPing() + 50) / 10f);
			int num2 = Mathf.FloorToInt((1f - Instance.GetQuality()) * 10f);
			double num3 = (double)Mathf.Min(2f, (float)(num + num2));
			return 0.20000000298023224 * num3;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0001C2EC File Offset: 0x0001A4EC
		public static ulong GetSteamID(this VRCPlayer player)
		{
			return player.field_Private_UInt64_0;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0001C304 File Offset: 0x0001A504
		public static string GetPingColored(this VRCPlayer Instance)
		{
			bool flag = Instance.GetPing() <= 75;
			string arg;
			if (flag)
			{
				arg = "<color=#59D365>";
			}
			else
			{
				bool flag2 = Instance.GetPing() >= 75 && Instance.GetPing() <= 150;
				if (flag2)
				{
					arg = "<color=#FF7000>";
				}
				else
				{
					arg = "<color=red>";
				}
			}
			return string.Format("{0}{1}</color>", arg, Instance.GetPing());
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0001C37C File Offset: 0x0001A57C
		public static string GetFramesColored(this VRCPlayer Instance)
		{
			bool flag = Instance.GetFrames() >= 80f;
			string arg;
			if (flag)
			{
				arg = "<color=#59D365>";
			}
			else
			{
				bool flag2 = Instance.GetFrames() <= 80f && Instance.GetFrames() >= 30f;
				if (flag2)
				{
					arg = "<color=#FF7000>";
				}
				else
				{
					arg = "<color=red>";
				}
			}
			return string.Format("{0}{1}</color>", arg, Instance.GetFrames());
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0001C3F8 File Offset: 0x0001A5F8
		public static string GetQualityColored(this VRCPlayer Instance)
		{
			bool flag = Instance.GetQuality() >= 90f;
			string arg;
			if (flag)
			{
				arg = "<color=#59D365>";
			}
			else
			{
				bool flag2 = Instance.GetQuality() <= 90f && Instance.GetQuality() >= 60f;
				if (flag2)
				{
					arg = "<color=#FF7000>";
				}
				else
				{
					arg = "<color=red>";
				}
			}
			return string.Format("{0}{1}</color>", arg, Instance.GetQuality());
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0001C474 File Offset: 0x0001A674
		public static void ReloadAvatar(this VRCPlayer Instance)
		{
			VRCPlayer.Method_Public_Static_Void_APIUser_0(Instance.GetAPIUser());
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0001C483 File Offset: 0x0001A683
		public static void ReloadAvatar(this Player Instance)
		{
			Instance.GetVRCPlayer().ReloadAvatar();
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0001C494 File Offset: 0x0001A694
		public static bool GetForceMute(this Player Instance)
		{
			return Instance.Method_Public_get_Boolean_6();
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0001C4AC File Offset: 0x0001A6AC
		public static void SetForceMute(this Player Instance, bool State)
		{
			Instance.Method_Internal_set_Void_Boolean_0(State);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0001C4B7 File Offset: 0x0001A6B7
		public static void SetBlock(this Player Instance, bool State)
		{
			Instance.Method_Private_set_Void_Boolean_1(State);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0001C4C2 File Offset: 0x0001A6C2
		public static void SetHide(this Player Instance, bool State)
		{
			Instance.Method_Internal_set_Void_Boolean_1(State);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0001C4CD File Offset: 0x0001A6CD
		public static void SetSpeak(this Player Instance, bool State)
		{
			Instance.Method_Private_set_Void_Boolean_0(State);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0001C4D8 File Offset: 0x0001A6D8
		public static string GetRank(this APIUser Instance)
		{
			bool flag = Instance.hasModerationPowers || Instance.tags.Contains("admin_moderator");
			string result;
			if (flag)
			{
				result = "Moderation User";
			}
			else
			{
				bool flag2 = Instance.hasSuperPowers || Instance.tags.Contains("admin_");
				if (flag2)
				{
					result = "Admin User";
				}
				else
				{
					bool flag3 = Instance.tags.Contains("system_legend") && Instance.tags.Contains("system_trust_legend") && Instance.tags.Contains("system_trust_trusted");
					if (flag3)
					{
						result = "Legend";
					}
					else
					{
						bool flag4 = Instance.hasLegendTrustLevel || (Instance.tags.Contains("system_trust_legend") && Instance.tags.Contains("system_trust_trusted"));
						if (flag4)
						{
							result = "Veteran";
						}
						else
						{
							bool hasVeteranTrustLevel = Instance.hasVeteranTrustLevel;
							if (hasVeteranTrustLevel)
							{
								result = "Trusted";
							}
							else
							{
								bool hasTrustedTrustLevel = Instance.hasTrustedTrustLevel;
								if (hasTrustedTrustLevel)
								{
									result = "Known";
								}
								else
								{
									bool hasKnownTrustLevel = Instance.hasKnownTrustLevel;
									if (hasKnownTrustLevel)
									{
										result = "User";
									}
									else
									{
										bool flag5 = Instance.hasBasicTrustLevel || Instance.isNewUser;
										if (flag5)
										{
											result = "New User";
										}
										else
										{
											bool hasNegativeTrustLevel = Instance.hasNegativeTrustLevel;
											if (hasNegativeTrustLevel)
											{
												result = "NegativeTrust";
											}
											else
											{
												result = (Instance.hasVeryNegativeTrustLevel ? "VeryNegativeTrust" : "Visitor");
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0001C648 File Offset: 0x0001A848
		public static PlayerExtensions.RankType GetRankEnum(this APIUser Instance)
		{
			bool flag = Instance.hasModerationPowers || Instance.tags.Contains("admin_moderator");
			PlayerExtensions.RankType result;
			if (flag)
			{
				result = PlayerExtensions.RankType.Moderator;
			}
			else
			{
				bool flag2 = Instance.hasSuperPowers || Instance.tags.Contains("admin_");
				if (flag2)
				{
					result = PlayerExtensions.RankType.Admin;
				}
				else
				{
					bool flag3 = Instance.tags.Contains("system_legend") && Instance.tags.Contains("system_trust_legend") && Instance.tags.Contains("system_trust_trusted");
					if (flag3)
					{
						result = PlayerExtensions.RankType.Legend;
					}
					else
					{
						bool flag4 = Instance.hasLegendTrustLevel || (Instance.tags.Contains("system_trust_legend") && Instance.tags.Contains("system_trust_trusted"));
						if (flag4)
						{
							result = PlayerExtensions.RankType.Veteran;
						}
						else
						{
							bool hasVeteranTrustLevel = Instance.hasVeteranTrustLevel;
							if (hasVeteranTrustLevel)
							{
								result = PlayerExtensions.RankType.Trusted;
							}
							else
							{
								bool hasTrustedTrustLevel = Instance.hasTrustedTrustLevel;
								if (hasTrustedTrustLevel)
								{
									result = PlayerExtensions.RankType.Known;
								}
								else
								{
									bool hasKnownTrustLevel = Instance.hasKnownTrustLevel;
									if (hasKnownTrustLevel)
									{
										result = PlayerExtensions.RankType.User;
									}
									else
									{
										bool flag5 = Instance.hasBasicTrustLevel || Instance.isNewUser;
										if (flag5)
										{
											result = PlayerExtensions.RankType.newUser;
										}
										else
										{
											bool hasNegativeTrustLevel = Instance.hasNegativeTrustLevel;
											if (hasNegativeTrustLevel)
											{
												result = PlayerExtensions.RankType.NegativeTrust;
											}
											else
											{
												result = (Instance.hasVeryNegativeTrustLevel ? PlayerExtensions.RankType.VeryNegativeTrust : PlayerExtensions.RankType.visitor);
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0001C78C File Offset: 0x0001A98C
		public static string GetThings(this VRCPlayer Instance)
		{
			string str = string.Empty;
			bool isFriend = Instance.GetAPIUser().GetIsFriend();
			if (isFriend)
			{
				str += "<color=yellow>[F]</color> ";
			}
			bool flag = Instance.GetVRCPlayerApi().isMaster && !Instance.GetVRCPlayerApi().isInstanceOwner;
			if (flag)
			{
				str += "<color=#12F1FF>[O]</color> ";
			}
			else
			{
				bool flag2 = !Instance.GetVRCPlayerApi().isMaster && Instance.GetVRCPlayerApi().isInstanceOwner;
				if (flag2)
				{
					str += "<color=yellow>[O]</color> ";
				}
				else
				{
					bool flag3 = Instance.GetVRCPlayerApi().isMaster && Instance.GetVRCPlayerApi().isInstanceOwner;
					if (flag3)
					{
						str += "<color=red>[O]</color> ";
					}
				}
			}
			bool isOnMobile = Instance.GetAPIUser().IsOnMobile;
			if (isOnMobile)
			{
				str += "<color=#59D365>[Q]</color> ";
			}
			bool isDANGER = Instance.GetIsDANGER();
			if (isDANGER)
			{
				str += "<color=#FFC4FF>[MODERATOR]</color> ";
			}
			return str + (Instance.GetVRCPlayerApi().IsUserInVR() ? "<color=#A6CACD><VR></color> " : "<color=#A6CACD><D></color> ");
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0001C8A4 File Offset: 0x0001AAA4
		public static bool IsFlying(this VRCPlayer Instance)
		{
			return !Instance.GetVRCPlayerApi().IsPlayerGrounded();
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0001C8C4 File Offset: 0x0001AAC4
		public static string GetSmallThings(this VRCPlayer Instance)
		{
			string text = string.Empty;
			bool isFriend = Instance.GetAPIUser().GetIsFriend();
			if (isFriend)
			{
				text += "<color=yellow>[F]</color> ";
			}
			bool flag = Instance.GetVRCPlayerApi().isMaster && !Instance.GetVRCPlayerApi().isInstanceOwner;
			if (flag)
			{
				text += "<color=#12F1FF>[O]</color> ";
			}
			else
			{
				bool flag2 = !Instance.GetVRCPlayerApi().isMaster && Instance.GetVRCPlayerApi().isInstanceOwner;
				if (flag2)
				{
					text += "<color=yellow>[O]</color> ";
				}
				else
				{
					bool flag3 = Instance.GetVRCPlayerApi().isMaster && Instance.GetVRCPlayerApi().isInstanceOwner;
					if (flag3)
					{
						text += "<color=red>[O]</color> ";
					}
				}
			}
			bool isOnMobile = Instance.GetAPIUser().IsOnMobile;
			if (isOnMobile)
			{
				text += "<color=#59D365>[Q]</color> ";
			}
			return text;
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0001C9A4 File Offset: 0x0001ABA4
		public static bool GetIsFriend(this APIUser Instance)
		{
			return Instance.isFriend || APIUser.IsFriendsWith(Instance.id) || APIUser.CurrentUser.friendIDs.Contains(Instance.id);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0001C9E4 File Offset: 0x0001ABE4
		public static bool GetIsDANGER(this VRCPlayer Instance)
		{
			return Instance.GetVRCPlayerApi().isModerator || Instance.GetAPIUser().hasModerationPowers || Instance.GetAPIUser().hasSuperPowers || Instance.GetAPIUser().hasSuperPowers;
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0001CA2C File Offset: 0x0001AC2C
		public static bool GetIsBot(this VRCPlayer Instance)
		{
			return Instance.GetPing() == 0 && Instance.GetFrames() == 0f && Instance.UserID() != APIUser.CurrentUser.id;
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0001CA6C File Offset: 0x0001AC6C
		public static ApiAvatar GetApiAvatar(this Player Instance)
		{
			return Instance.GetVRCPlayer().GetApiAvatar();
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0001CA8C File Offset: 0x0001AC8C
		public static ApiAvatar GetApiAvatar(this VRCPlayer Instance)
		{
			ApiAvatar result = null;
			bool flag = Instance.Method_Public_get_ApiAvatar_0().supportedPlatforms == 3;
			if (flag)
			{
				result = Instance.Method_Public_get_ApiAvatar_1();
			}
			bool flag2 = Instance.Method_Public_get_ApiAvatar_1().supportedPlatforms == 3;
			if (flag2)
			{
				result = Instance.Method_Public_get_ApiAvatar_0();
			}
			return result;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0001CAD4 File Offset: 0x0001ACD4
		public static GameObject GetAvatar(this Player Instance)
		{
			return Instance.GetVRCPlayer().GetAvatarManager().GetAvatar();
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0001CAF8 File Offset: 0x0001ACF8
		public static GameObject GetAvatar(this VRCPlayer Instance)
		{
			return Instance.GetAvatarManager().GetAvatar();
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0001CB18 File Offset: 0x0001AD18
		public static VRCAvatarManager GetAvatarManager(this VRCPlayer Instance)
		{
			return Instance.Method_Public_get_VRCAvatarManager_0();
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0001CB30 File Offset: 0x0001AD30
		public static GameObject GetAvatar(this VRCAvatarManager Instance)
		{
			return (Instance.Method_Public_get_GameObject_0() != null) ? Instance.Method_Public_get_GameObject_0() : null;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x0001CB5C File Offset: 0x0001AD5C
		public static ApiAvatar GetAPIAvatar(this VRCAvatarManager Instance)
		{
			ApiAvatar result = null;
			bool flag = Instance.field_Private_ApiAvatar_0 != null;
			if (flag)
			{
				result = Instance.field_Private_ApiAvatar_0;
			}
			else
			{
				bool flag2 = Instance.field_Private_ApiAvatar_1 != null;
				if (flag2)
				{
					result = Instance.field_Private_ApiAvatar_1;
				}
				else
				{
					bool flag3 = Instance.Method_Public_get_ApiAvatar_PDM_0() != null;
					if (flag3)
					{
						result = Instance.Method_Public_get_ApiAvatar_PDM_0();
					}
				}
			}
			return result;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0001CBB4 File Offset: 0x0001ADB4
		public static VRC_AvatarDescriptor GetSDK3Descriptor(this VRCAvatarManager Instance)
		{
			return Instance.Method_Public_get_VRCAvatarDescriptor_0();
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0001CBCC File Offset: 0x0001ADCC
		public static VRC_AvatarDescriptor GetSDK2Descriptor(this VRCAvatarManager Instance)
		{
			return Instance.Method_Public_get_VRC_AvatarDescriptor_0();
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0001CBE4 File Offset: 0x0001ADE4
		public static bool GetIsSKD3(this VRCAvatarManager Instance)
		{
			return Instance.GetSDK3Descriptor() == null || Instance.GetSDK2Descriptor() != null;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0001CC14 File Offset: 0x0001AE14
		public static APIUser SelectedAPIUser(this QuickMenu instance)
		{
			return instance.field_Private_APIUser_0;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0001CC2C File Offset: 0x0001AE2C
		public static VRCPlayer SelectedVRCPlayer(this QuickMenu instance)
		{
			return instance.SelectedPlayer().GetVRCPlayer();
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0001CC4C File Offset: 0x0001AE4C
		public static Player SelectedPlayer(this QuickMenu instance)
		{
			return instance.field_Private_Player_0;
		}

		// Token: 0x020000D1 RID: 209
		public enum RankType
		{
			// Token: 0x04000415 RID: 1045
			Moderator,
			// Token: 0x04000416 RID: 1046
			Admin,
			// Token: 0x04000417 RID: 1047
			Legend,
			// Token: 0x04000418 RID: 1048
			Veteran,
			// Token: 0x04000419 RID: 1049
			Trusted,
			// Token: 0x0400041A RID: 1050
			Known,
			// Token: 0x0400041B RID: 1051
			User,
			// Token: 0x0400041C RID: 1052
			newUser,
			// Token: 0x0400041D RID: 1053
			visitor,
			// Token: 0x0400041E RID: 1054
			NegativeTrust,
			// Token: 0x0400041F RID: 1055
			VeryNegativeTrust
		}
	}
}
