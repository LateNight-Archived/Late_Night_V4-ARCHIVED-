using System;
using System.Collections.Generic;
using DayClientML2.Utility.Extensions;
using Late_Night_config;
using Late_Night_V2_wrappers;
using UnityEngine;
using VRC;

namespace Late_Night_V2_Playerlist
{
	// Token: 0x02000016 RID: 22
	internal class Playerlist
	{
		// Token: 0x060000BC RID: 188 RVA: 0x00005D28 File Offset: 0x00003F28
		internal static string PlayerName(Player Instance)
		{
			bool flag = Playerlist.THEBRUHS.Contains(Instance.Method_Internal_get_APIUser_0().id) || Instance.Method_Internal_get_APIUser_0().hasModerationPowers || Instance.Method_Internal_get_APIUser_0().tags.Contains("admin_moderator") || Instance.Method_Internal_get_APIUser_0().hasSuperPowers || Instance.Method_Internal_get_APIUser_0().tags.Contains("admin_");
			string result;
			if (flag)
			{
				result = "<color=#ff0000>" + Instance.field_Private_VRCPlayerApi_0.displayName + "</color>";
			}
			else
			{
				bool flag2 = Instance.Method_Internal_get_APIUser_0().id == Playerlist.Nigger;
				if (flag2)
				{
					result = "<color=#FF69B4>" + Instance.field_Private_VRCPlayerApi_0.displayName + "</color>";
				}
				else
				{
					result = "<color=#ffdd00>" + Instance.field_Private_VRCPlayerApi_0.displayName + "</color>";
				}
			}
			return result;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00005E10 File Offset: 0x00004010
		internal static string PlayerisFristring(Player Instance)
		{
			return Instance.field_Private_APIUser_0.GetIsFriend() ? ("<color=" + Config.Instance.Friend + ">[F]</color>") : "";
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00005E50 File Offset: 0x00004050
		internal static string PlayerPING(Player Instance)
		{
			return string.Format("<color=#ff00e1>[P : {0}]</color>", Instance.GetPlayerNet().field_Private_Int16_0);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00005E7C File Offset: 0x0000407C
		internal static string PlayerFPS(Player Instance)
		{
			return string.Format("<color=#55ff00>[FPS : {0}]</color>", (Instance.GetPlayerNet().Method_Public_get_Byte_0() != 0) ? ((int)(1000f / (float)Instance.GetPlayerNet().Method_Public_get_Byte_0())) : 0);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00005EC0 File Offset: 0x000040C0
		internal static string Playerisvr(Player Instance)
		{
			return Instance.GetVRCPlayerApi().IsUserInVR() ? "<color=#0080ff>[VR]</color>" : "<color=#ff3c00>[PC]</color>";
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00005EEC File Offset: 0x000040EC
		internal static string Playerisquet(Player Instance)
		{
			return Instance.Method_Internal_get_APIUser_0().IsOnMobile ? "<color=#42f20c>[Q]</color>" : "";
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00005F18 File Offset: 0x00004118
		internal static string Playerismaster(Player Instance)
		{
			return Instance.GetVRCPlayerApi().isMaster ? ("<color=" + Config.Instance.Master + ">[M]</color>") : "";
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00005F58 File Offset: 0x00004158
		internal static string TrustRank(Player Instance)
		{
			bool flag = Playerlist.THEBRUHS.Contains(Instance.Method_Internal_get_APIUser_0().id);
			string result;
			if (flag)
			{
				result = "<color=#ff0000>[Late Night Dev]</color>";
			}
			else
			{
				bool flag2 = Instance.Method_Internal_get_APIUser_0().id == Playerlist.Nigger;
				if (flag2)
				{
					result = "<color=#FF69B4>[Cutie]</color>";
				}
				else
				{
					bool flag3 = Playerlist.Staff.Contains(Instance.Method_Internal_get_APIUser_0().id);
					if (flag3)
					{
						result = "<color=#ff0000>[Late Night Staff]</color>";
					}
					else
					{
						bool flag4 = Instance.Method_Internal_get_APIUser_0().hasModerationPowers || Instance.Method_Internal_get_APIUser_0().tags.Contains("admin_moderator");
						if (flag4)
						{
							result = "<color=#ff0000>[Moderation User]</color>";
						}
						else
						{
							bool flag5 = Instance.Method_Internal_get_APIUser_0().hasSuperPowers || Instance.Method_Internal_get_APIUser_0().tags.Contains("admin_");
							if (flag5)
							{
								result = "<color=#ff0000>[Admin User]</color>";
							}
							else
							{
								bool flag6 = Instance.Method_Internal_get_APIUser_0().tags.Contains("system_legend") && Instance.Method_Internal_get_APIUser_0().tags.Contains("system_trust_legend") && Instance.Method_Internal_get_APIUser_0().tags.Contains("system_trust_trusted");
								if (flag6)
								{
									result = "<color=" + Config.Instance.Trusted + ">[Legend]</color>";
								}
								else
								{
									bool flag7 = Instance.Method_Internal_get_APIUser_0().hasLegendTrustLevel || (Instance.Method_Internal_get_APIUser_0().tags.Contains("system_trust_legend") && Instance.Method_Internal_get_APIUser_0().tags.Contains("system_trust_trusted"));
									if (flag7)
									{
										result = "<color=" + Config.Instance.Trusted + ">[Veteran]</color>";
									}
									else
									{
										bool hasVeteranTrustLevel = Instance.Method_Internal_get_APIUser_0().hasVeteranTrustLevel;
										if (hasVeteranTrustLevel)
										{
											result = "<color=" + Config.Instance.Trusted + ">[Trusted]</color>";
										}
										else
										{
											bool hasTrustedTrustLevel = Instance.Method_Internal_get_APIUser_0().hasTrustedTrustLevel;
											if (hasTrustedTrustLevel)
											{
												result = "<color=" + Config.Instance.known + ">[Known]</color>";
											}
											else
											{
												bool hasKnownTrustLevel = Instance.Method_Internal_get_APIUser_0().hasKnownTrustLevel;
												if (hasKnownTrustLevel)
												{
													result = "<color=" + Config.Instance.user + ">[User]</color>";
												}
												else
												{
													bool flag8 = Instance.Method_Internal_get_APIUser_0().hasBasicTrustLevel || Instance.Method_Internal_get_APIUser_0().isNewUser;
													if (flag8)
													{
														result = "<color=" + Config.Instance.Newuser + ">[New User]</color>";
													}
													else
													{
														bool hasNegativeTrustLevel = Instance.Method_Internal_get_APIUser_0().hasNegativeTrustLevel;
														if (hasNegativeTrustLevel)
														{
															result = "<color=" + Config.Instance.vistor + ">Nuisance]</color>";
														}
														else
														{
															bool hasVeryNegativeTrustLevel = Instance.Method_Internal_get_APIUser_0().hasVeryNegativeTrustLevel;
															if (hasVeryNegativeTrustLevel)
															{
																result = "<color=" + Config.Instance.vistor + ">[Nuisance++]</color>";
															}
															else
															{
																result = "<color=" + Config.Instance.vistor + ">[Visitor]</color>";
															}
														}
													}
												}
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

		// Token: 0x060000C4 RID: 196 RVA: 0x00006254 File Offset: 0x00004454
		internal static string JOINRank(Player Instance)
		{
			bool flag = Playerlist.THEBRUHS.Contains(Instance.Method_Internal_get_APIUser_0().id);
			string result;
			if (flag)
			{
				result = "<color=#ff0000> " + Instance.DisplayName() + " </color>";
			}
			else
			{
				bool flag2 = Instance.Method_Internal_get_APIUser_0().id == Playerlist.Nigger;
				if (flag2)
				{
					result = "<color=#FF69B4> " + Instance.DisplayName() + " </color>";
				}
				else
				{
					bool flag3 = Instance.Method_Internal_get_APIUser_0().hasModerationPowers || Instance.Method_Internal_get_APIUser_0().tags.Contains("admin_moderator");
					if (flag3)
					{
						result = "<color=#ff0000> " + Instance.DisplayName() + " </color>";
					}
					else
					{
						bool flag4 = Instance.Method_Internal_get_APIUser_0().hasSuperPowers || Instance.Method_Internal_get_APIUser_0().tags.Contains("admin_");
						if (flag4)
						{
							result = "<color=#ff0000> " + Instance.DisplayName() + " </color>";
						}
						else
						{
							bool flag5 = Instance.Method_Internal_get_APIUser_0().tags.Contains("system_legend") && Instance.Method_Internal_get_APIUser_0().tags.Contains("system_trust_legend") && Instance.Method_Internal_get_APIUser_0().tags.Contains("system_trust_trusted");
							if (flag5)
							{
								result = string.Concat(new string[]
								{
									"<color=",
									Config.Instance.Trusted,
									"> ",
									Instance.DisplayName(),
									" </color>"
								});
							}
							else
							{
								bool flag6 = Instance.Method_Internal_get_APIUser_0().hasLegendTrustLevel || (Instance.Method_Internal_get_APIUser_0().tags.Contains("system_trust_legend") && Instance.Method_Internal_get_APIUser_0().tags.Contains("system_trust_trusted"));
								if (flag6)
								{
									result = string.Concat(new string[]
									{
										"<color=",
										Config.Instance.Trusted,
										"> ",
										Instance.DisplayName(),
										" </color>"
									});
								}
								else
								{
									bool hasVeteranTrustLevel = Instance.Method_Internal_get_APIUser_0().hasVeteranTrustLevel;
									if (hasVeteranTrustLevel)
									{
										result = string.Concat(new string[]
										{
											"<color=",
											Config.Instance.Trusted,
											"> ",
											Instance.DisplayName(),
											" </color>"
										});
									}
									else
									{
										bool hasTrustedTrustLevel = Instance.Method_Internal_get_APIUser_0().hasTrustedTrustLevel;
										if (hasTrustedTrustLevel)
										{
											result = string.Concat(new string[]
											{
												"<color=",
												Config.Instance.known,
												"> ",
												Instance.DisplayName(),
												" </color>"
											});
										}
										else
										{
											bool hasKnownTrustLevel = Instance.Method_Internal_get_APIUser_0().hasKnownTrustLevel;
											if (hasKnownTrustLevel)
											{
												result = string.Concat(new string[]
												{
													"<color=",
													Config.Instance.user,
													"> ",
													Instance.DisplayName(),
													" </color>"
												});
											}
											else
											{
												bool flag7 = Instance.Method_Internal_get_APIUser_0().hasBasicTrustLevel || Instance.Method_Internal_get_APIUser_0().isNewUser;
												if (flag7)
												{
													result = string.Concat(new string[]
													{
														"<color=",
														Config.Instance.Newuser,
														"> ",
														Instance.DisplayName(),
														" </color>"
													});
												}
												else
												{
													bool hasNegativeTrustLevel = Instance.Method_Internal_get_APIUser_0().hasNegativeTrustLevel;
													if (hasNegativeTrustLevel)
													{
														result = string.Concat(new string[]
														{
															"<color=",
															Config.Instance.vistor,
															"> ",
															Instance.DisplayName(),
															" </color>"
														});
													}
													else
													{
														bool hasVeryNegativeTrustLevel = Instance.Method_Internal_get_APIUser_0().hasVeryNegativeTrustLevel;
														if (hasVeryNegativeTrustLevel)
														{
															result = string.Concat(new string[]
															{
																"<color=",
																Config.Instance.vistor,
																"> ",
																Instance.DisplayName(),
																" </color>"
															});
														}
														else
														{
															result = string.Concat(new string[]
															{
																"<color=",
																Config.Instance.vistor,
																"> ",
																Instance.DisplayName(),
																" </color>"
															});
														}
													}
												}
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

		// Token: 0x060000C5 RID: 197 RVA: 0x00006690 File Offset: 0x00004890
		internal static string PlayerAviname(Player Instance)
		{
			return "<color=#008cff>[Avi name : " + Instance.Method_Public_get_ApiAvatar_0().name + "]</color>";
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000066BC File Offset: 0x000048BC
		internal static string PlayerAviID(Player Instance)
		{
			return "<color=#ff0040>[Avi id : " + Instance.Method_Public_get_ApiAvatar_0().id + "]</color>";
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000066E8 File Offset: 0x000048E8
		internal static string PlayerAviAuth(Player Instance)
		{
			return "<color=#f457ff>[Avi author name : " + Instance.Method_Public_get_ApiAvatar_0().authorName + "]</color>";
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00006714 File Offset: 0x00004914
		internal static string PlayerAvipuborpri(Player Instance)
		{
			return "<color=#57fff7>[Avi Release Status : " + Instance.Method_Public_get_ApiAvatar_0().releaseStatus + "]</color>";
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00006740 File Offset: 0x00004940
		internal static string PlayerAviPatform(Player Instance)
		{
			return string.Format("<color=#ff8052>[Avi Supported Platforms : {0}]</color>", Instance.Method_Public_get_ApiAvatar_0().supportedPlatforms);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000676C File Offset: 0x0000496C
		internal static string PlayerAviWhen(Player Instance)
		{
			return "<color=#f9ff4f>[Avi Release Date : " + Instance.Method_Public_get_ApiAvatar_0().updated_at.ToString() + "]</color>";
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000067A0 File Offset: 0x000049A0
		internal static void SetNamePlateColor(Player Instance)
		{
			bool flag = Instance.Method_Internal_get_APIUser_0().id == Playerlist.Nigger;
			if (flag)
			{
				Playerlist.Nameplate_color_dev(Instance);
			}
			else
			{
				bool flag2 = Instance.Method_Internal_get_APIUser_0().hasModerationPowers || Instance.Method_Internal_get_APIUser_0().tags.Contains("admin_moderator") || Playerlist.THEBRUHS.Contains(Instance.Method_Internal_get_APIUser_0().id);
				if (flag2)
				{
					Playerlist.Nameplate_color_dev(Instance);
				}
				else
				{
					bool flag3 = Instance.Method_Internal_get_APIUser_0().hasSuperPowers || Instance.Method_Internal_get_APIUser_0().tags.Contains("admin_");
					if (flag3)
					{
						Playerlist.Nameplate_color_dev(Instance);
					}
					else
					{
						bool flag4 = Instance.Method_Internal_get_APIUser_0().tags.Contains("system_legend") && Instance.Method_Internal_get_APIUser_0().tags.Contains("system_trust_legend") && Instance.Method_Internal_get_APIUser_0().tags.Contains("system_trust_trusted");
						if (flag4)
						{
							Playerlist.Nameplate_color_trused(Instance);
						}
						else
						{
							bool flag5 = Instance.Method_Internal_get_APIUser_0().hasLegendTrustLevel || (Instance.Method_Internal_get_APIUser_0().tags.Contains("system_trust_legend") && Instance.Method_Internal_get_APIUser_0().tags.Contains("system_trust_trusted"));
							if (flag5)
							{
								Playerlist.Nameplate_color_trused(Instance);
							}
							else
							{
								bool hasVeteranTrustLevel = Instance.Method_Internal_get_APIUser_0().hasVeteranTrustLevel;
								if (hasVeteranTrustLevel)
								{
									Playerlist.Nameplate_color_trused(Instance);
								}
								else
								{
									bool hasTrustedTrustLevel = Instance.Method_Internal_get_APIUser_0().hasTrustedTrustLevel;
									if (hasTrustedTrustLevel)
									{
										Playerlist.Nameplate_color_Known(Instance);
									}
									else
									{
										bool hasKnownTrustLevel = Instance.Method_Internal_get_APIUser_0().hasKnownTrustLevel;
										if (hasKnownTrustLevel)
										{
											Playerlist.Nameplate_color_User(Instance);
										}
										else
										{
											bool flag6 = Instance.Method_Internal_get_APIUser_0().hasBasicTrustLevel || Instance.Method_Internal_get_APIUser_0().isNewUser;
											if (flag6)
											{
												Playerlist.Nameplate_color_New(Instance);
											}
											else
											{
												bool hasNegativeTrustLevel = Instance.Method_Internal_get_APIUser_0().hasNegativeTrustLevel;
												if (hasNegativeTrustLevel)
												{
													Playerlist.Nameplate_color_Vis(Instance);
												}
												else
												{
													bool hasVeryNegativeTrustLevel = Instance.Method_Internal_get_APIUser_0().hasVeryNegativeTrustLevel;
													if (hasVeryNegativeTrustLevel)
													{
														Playerlist.Nameplate_color_Vis(Instance);
													}
													else
													{
														Playerlist.Nameplate_color_Vis(Instance);
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000069CC File Offset: 0x00004BCC
		internal static void PlayerismasterNamePLate(Player Instance)
		{
			bool isMaster = Instance.GetVRCPlayerApi().isMaster;
			if (isMaster)
			{
				Playerlist.Nameplate_color_WorldMaster(Instance);
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000069F8 File Offset: 0x00004BF8
		internal static void Nameplate_TExt_ADMIN(Player Instance)
		{
			bool flag = Instance.Method_Internal_get_APIUser_0().hasModerationPowers || Instance.Method_Internal_get_APIUser_0().tags.Contains("admin_moderator") || Instance.Method_Internal_get_APIUser_0().hasSuperPowers || Instance.Method_Internal_get_APIUser_0().tags.Contains("admin_") || Playerlist.THEBRUHS.Contains(Instance.Method_Internal_get_APIUser_0().id);
			if (flag)
			{
				Playerlist.Nameplate_color_ADMIN(Instance);
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00006A78 File Offset: 0x00004C78
		internal static void Nameplate_TExt_QUEST(Player Instance)
		{
			bool isOnMobile = Instance.Method_Internal_get_APIUser_0().IsOnMobile;
			if (isOnMobile)
			{
				Playerlist.Nameplate_color_Quest(Instance);
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00006AA4 File Offset: 0x00004CA4
		internal static void Nameplate_color_SpeachBubble(Player Instance)
		{
			Color color = default(Color).hextorgb(Config.Instance.SpeckingBubble);
			color.a = NameplateManager.Method_Public_Static_get_Single_PDM_1();
			Instance.Method_Internal_get_VRCPlayer_0().field_Public_PlayerNameplate_0.field_Public_Graphic_5.color = color;
			Instance.Method_Internal_get_VRCPlayer_0().field_Public_PlayerNameplate_0.field_Public_Graphic_7.color = color;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00006B08 File Offset: 0x00004D08
		internal static void Nameplate_color_dev(Player Instance)
		{
			Instance.Method_Internal_get_VRCPlayer_0().field_Public_PlayerNameplate_0.field_Public_Graphic_1.color = new Color(2f, 0f, 0f, NameplateManager.Method_Public_Static_get_Single_PDM_1());
			Instance.Method_Internal_get_VRCPlayer_0().field_Public_PlayerNameplate_0.field_Public_Graphic_2.color = new Color(2f, 0f, 0f, NameplateManager.Method_Public_Static_get_Single_PDM_1());
			Instance.Method_Internal_get_VRCPlayer_0().field_Public_PlayerNameplate_0.field_Public_Graphic_3.color = new Color(2f, 0f, 0f, NameplateManager.Method_Public_Static_get_Single_PDM_1());
			Instance.Method_Internal_get_VRCPlayer_0().field_Public_PlayerNameplate_0.field_Public_Graphic_9.color = new Color(2f, 0f, 0f, NameplateManager.Method_Public_Static_get_Single_PDM_1());
			Instance.Method_Internal_get_VRCPlayer_0().field_Public_PlayerNameplate_0.field_Public_Graphic_10.color = new Color(2f, 0f, 0f, NameplateManager.Method_Public_Static_get_Single_PDM_1());
			Playerlist.Nameplate_color_SpeachBubble(Instance);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00006C08 File Offset: 0x00004E08
		internal static void Nameplate_color_Vis(Player Instance)
		{
			Color color = default(Color).hextorgb(Config.Instance.vistor);
			color.a = NameplateManager.Method_Public_Static_get_Single_PDM_1();
			Instance.Method_Internal_get_VRCPlayer_0().field_Public_PlayerNameplate_0.field_Public_Graphic_1.color = color;
			Instance.Method_Internal_get_VRCPlayer_0().field_Public_PlayerNameplate_0.field_Public_Graphic_2.color = color;
			Instance.Method_Internal_get_VRCPlayer_0().field_Public_PlayerNameplate_0.field_Public_Graphic_3.color = color;
			Instance.Method_Internal_get_VRCPlayer_0().field_Public_PlayerNameplate_0.field_Public_Graphic_9.color = color;
			Instance.Method_Internal_get_VRCPlayer_0().field_Public_PlayerNameplate_0.field_Public_Graphic_10.color = color;
			Playerlist.Nameplate_color_SpeachBubble(Instance);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00006CB8 File Offset: 0x00004EB8
		internal static void Nameplate_color_New(Player Instance)
		{
			Color color = default(Color).hextorgb(Config.Instance.Newuser);
			color.a = NameplateManager.Method_Public_Static_get_Single_PDM_1();
			Instance.Method_Internal_get_VRCPlayer_0().field_Public_PlayerNameplate_0.field_Public_Graphic_1.color = color;
			Instance.Method_Internal_get_VRCPlayer_0().field_Public_PlayerNameplate_0.field_Public_Graphic_2.color = color;
			Instance.Method_Internal_get_VRCPlayer_0().field_Public_PlayerNameplate_0.field_Public_Graphic_3.color = color;
			Instance.Method_Internal_get_VRCPlayer_0().field_Public_PlayerNameplate_0.field_Public_Graphic_9.color = color;
			Instance.Method_Internal_get_VRCPlayer_0().field_Public_PlayerNameplate_0.field_Public_Graphic_10.color = color;
			Playerlist.Nameplate_color_SpeachBubble(Instance);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00006D68 File Offset: 0x00004F68
		internal static void Nameplate_color_User(Player Instance)
		{
			Color color = default(Color).hextorgb(Config.Instance.user);
			color.a = NameplateManager.Method_Public_Static_get_Single_PDM_1();
			Instance.Method_Internal_get_VRCPlayer_0().field_Public_PlayerNameplate_0.field_Public_Graphic_1.color = color;
			Instance.Method_Internal_get_VRCPlayer_0().field_Public_PlayerNameplate_0.field_Public_Graphic_2.color = color;
			Instance.Method_Internal_get_VRCPlayer_0().field_Public_PlayerNameplate_0.field_Public_Graphic_3.color = color;
			Instance.Method_Internal_get_VRCPlayer_0().field_Public_PlayerNameplate_0.field_Public_Graphic_9.color = color;
			Instance.Method_Internal_get_VRCPlayer_0().field_Public_PlayerNameplate_0.field_Public_Graphic_10.color = color;
			Playerlist.Nameplate_color_SpeachBubble(Instance);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00006E18 File Offset: 0x00005018
		internal static void Nameplate_color_Known(Player Instance)
		{
			Color color = default(Color).hextorgb(Config.Instance.known);
			color.a = NameplateManager.Method_Public_Static_get_Single_PDM_1();
			Instance.Method_Internal_get_VRCPlayer_0().field_Public_PlayerNameplate_0.field_Public_Graphic_1.color = color;
			Instance.Method_Internal_get_VRCPlayer_0().field_Public_PlayerNameplate_0.field_Public_Graphic_2.color = color;
			Instance.Method_Internal_get_VRCPlayer_0().field_Public_PlayerNameplate_0.field_Public_Graphic_3.color = color;
			Instance.Method_Internal_get_VRCPlayer_0().field_Public_PlayerNameplate_0.field_Public_Graphic_9.color = color;
			Instance.Method_Internal_get_VRCPlayer_0().field_Public_PlayerNameplate_0.field_Public_Graphic_10.color = color;
			Playerlist.Nameplate_color_SpeachBubble(Instance);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00006EC8 File Offset: 0x000050C8
		internal static void Nameplate_color_trused(Player Instance)
		{
			Color color = default(Color).hextorgb(Config.Instance.Trusted);
			color.a = NameplateManager.Method_Public_Static_get_Single_PDM_1();
			Instance.Method_Internal_get_VRCPlayer_0().field_Public_PlayerNameplate_0.field_Public_Graphic_1.color = color;
			Instance.Method_Internal_get_VRCPlayer_0().field_Public_PlayerNameplate_0.field_Public_Graphic_2.color = color;
			Instance.Method_Internal_get_VRCPlayer_0().field_Public_PlayerNameplate_0.field_Public_Graphic_3.color = color;
			Instance.Method_Internal_get_VRCPlayer_0().field_Public_PlayerNameplate_0.field_Public_Graphic_9.color = color;
			Instance.Method_Internal_get_VRCPlayer_0().field_Public_PlayerNameplate_0.field_Public_Graphic_10.color = color;
			Playerlist.Nameplate_color_SpeachBubble(Instance);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00006F78 File Offset: 0x00005178
		internal static void Nameplate_color_WorldMaster(Player Instance)
		{
			Instance.Method_Internal_get_VRCPlayer_0().field_Public_PlayerNameplate_0.field_Public_TextMeshProUGUI_0.color = default(Color).hextorgb(Config.Instance.Master);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00006FB4 File Offset: 0x000051B4
		internal static void Nameplate_color_ADMIN(Player Instance)
		{
			Instance.Method_Internal_get_VRCPlayer_0().field_Public_PlayerNameplate_0.field_Public_TextMeshProUGUI_0.color = new Color(2f, 0f, 0f);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00006FE1 File Offset: 0x000051E1
		internal static void Nameplate_color_Quest(Player Instance)
		{
			Instance.Method_Internal_get_VRCPlayer_0().field_Public_PlayerNameplate_0.field_Public_TextMeshProUGUI_1.color = new Color(0.2f, 1f, 0.2f, 0.5f);
		}

		// Token: 0x04000063 RID: 99
		public static string Nigger = "usr_7ad83483-2e1d-40f5-b4ab-739c926563ef";

		// Token: 0x04000064 RID: 100
		public static string FUCKWIT = "usr_c61615f2-c0b4-4cf0-beae-6a05195c7669";

		// Token: 0x04000065 RID: 101
		public static List<string> THEBRUHS = new List<string>
		{
			"usr_9b893a14-5d97-4082-a1d1-ae59fad0be71",
			"usr_c482bfc0-3cd2-43ba-b64c-6c709a756bee",
			"usr_87fafba8-c810-4703-abeb-c8cecf364d96",
			"usr_b69025fa-fcf0-4cc5-b3eb-3ed0488d34b8",
			"usr_04b1778d-a460-4309-ac92-7353522ac9c9",
			"usr_f19ae94f-8c11-4514-92bb-a09c1966acdd",
			"usr_bfcd90e9-853e-4dff-90ea-27e3b6635344",
			"usr_28af036d-0830-4e9f-a97b-4cfacda6f60e"
		};

		// Token: 0x04000066 RID: 102
		public static List<string> Optomizelul = new List<string>
		{
			"usr_bfcd90e9-853e-4dff-90ea-27e3b6635344"
		};

		// Token: 0x04000067 RID: 103
		public static List<string> Staff = new List<string>
		{
			"usr_d8a14aae-38d6-4994-9807-4b05f9d6a05c",
			"usr_464e250f-1175-4b1b-abb5-d2f7a682f707",
			"usr_8063ca60-19f5-402a-92b4-d741c7c1819d",
			"usr_c26bf519-b7f0-4b71-a935-08d1d46599eb",
			"usr_9ed158f5-6f32-4385-b86b-9f1faa9ff488",
			"usr_2b0ba90c-d699-43fe-9f72-84400ae3b7e4",
			"usr_7e911fe8-83ad-43e5-922f-aeac9adc85a2",
			"usr_0f7df6e1-6eb0-43d0-95bb-57686bbf8677",
			"usr_405dd9f9-cb76-47fd-b742-76b5f1f75e04"
		};
	}
}
