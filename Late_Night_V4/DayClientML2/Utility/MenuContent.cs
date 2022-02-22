using System;
using UnityEngine;

namespace DayClientML2.Utility
{
	// Token: 0x02000055 RID: 85
	public class MenuContent
	{
		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600032A RID: 810 RVA: 0x00019604 File Offset: 0x00017804
		public static GameObject Backdrop
		{
			get
			{
				return GameObject.Find("/UserInterface/MenuContent/Backdrop");
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600032B RID: 811 RVA: 0x00019620 File Offset: 0x00017820
		public static GameObject Screens
		{
			get
			{
				return GameObject.Find("/UserInterface/MenuContent/Screens");
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600032C RID: 812 RVA: 0x0001963C File Offset: 0x0001783C
		public static GameObject Popups
		{
			get
			{
				return GameObject.Find("/UserInterface/MenuContent/Popups");
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600032D RID: 813 RVA: 0x00019658 File Offset: 0x00017858
		public static GameObject Interupts
		{
			get
			{
				return GameObject.Find("/UserInterface/MenuContent/Interupts");
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600032E RID: 814 RVA: 0x00019674 File Offset: 0x00017874
		public static GameObject MenuAudio
		{
			get
			{
				return GameObject.Find("/UserInterface/MenuContent/MenuAudio");
			}
		}

		// Token: 0x020000AD RID: 173
		public class Screens_1
		{
			// Token: 0x17000125 RID: 293
			// (get) Token: 0x060006E2 RID: 1762 RVA: 0x000242A4 File Offset: 0x000224A4
			public static GameObject Announcement
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Screens/Announcement");
				}
			}

			// Token: 0x17000126 RID: 294
			// (get) Token: 0x060006E3 RID: 1763 RVA: 0x000242C0 File Offset: 0x000224C0
			public static GameObject Authentication
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication");
				}
			}

			// Token: 0x17000127 RID: 295
			// (get) Token: 0x060006E4 RID: 1764 RVA: 0x000242DC File Offset: 0x000224DC
			public static GameObject Avatar
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar");
				}
			}

			// Token: 0x17000128 RID: 296
			// (get) Token: 0x060006E5 RID: 1765 RVA: 0x000242F8 File Offset: 0x000224F8
			public static GameObject FirstLogin
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Screens/FirstLogin");
				}
			}

			// Token: 0x17000129 RID: 297
			// (get) Token: 0x060006E6 RID: 1766 RVA: 0x00024314 File Offset: 0x00022514
			public static GameObject Playlists
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Screens/Playlists");
				}
			}

			// Token: 0x1700012A RID: 298
			// (get) Token: 0x060006E7 RID: 1767 RVA: 0x00024330 File Offset: 0x00022530
			public static GameObject Settings_Safety
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety");
				}
			}

			// Token: 0x1700012B RID: 299
			// (get) Token: 0x060006E8 RID: 1768 RVA: 0x0002434C File Offset: 0x0002254C
			public static GameObject Settings
			{
				get
				{
					return GameObject.Find("UserInterface/MenuContent/Screens/Settings");
				}
			}

			// Token: 0x1700012C RID: 300
			// (get) Token: 0x060006E9 RID: 1769 RVA: 0x00024368 File Offset: 0x00022568
			public static GameObject Social
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Screens/Social");
				}
			}

			// Token: 0x1700012D RID: 301
			// (get) Token: 0x060006EA RID: 1770 RVA: 0x00024384 File Offset: 0x00022584
			public static GameObject Title
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Screens/Title");
				}
			}

			// Token: 0x1700012E RID: 302
			// (get) Token: 0x060006EB RID: 1771 RVA: 0x000243A0 File Offset: 0x000225A0
			public static GameObject UpdateRequired
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Screens/UpdateRequired");
				}
			}

			// Token: 0x1700012F RID: 303
			// (get) Token: 0x060006EC RID: 1772 RVA: 0x000243BC File Offset: 0x000225BC
			public static GameObject TitleXR
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Screens/TitleXR");
				}
			}

			// Token: 0x17000130 RID: 304
			// (get) Token: 0x060006ED RID: 1773 RVA: 0x000243D8 File Offset: 0x000225D8
			public static GameObject Gallery
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Screens/Gallery");
				}
			}

			// Token: 0x17000131 RID: 305
			// (get) Token: 0x060006EE RID: 1774 RVA: 0x000243F4 File Offset: 0x000225F4
			public static GameObject ImageDetails
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails");
				}
			}

			// Token: 0x17000132 RID: 306
			// (get) Token: 0x060006EF RID: 1775 RVA: 0x00024410 File Offset: 0x00022610
			public static GameObject UserInfo
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo");
				}
			}

			// Token: 0x17000133 RID: 307
			// (get) Token: 0x060006F0 RID: 1776 RVA: 0x0002442C File Offset: 0x0002262C
			public static GameObject VRCPlus
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+");
				}
			}

			// Token: 0x17000134 RID: 308
			// (get) Token: 0x060006F1 RID: 1777 RVA: 0x00024448 File Offset: 0x00022648
			public static GameObject WorldInfo
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo");
				}
			}

			// Token: 0x17000135 RID: 309
			// (get) Token: 0x060006F2 RID: 1778 RVA: 0x00024464 File Offset: 0x00022664
			public static GameObject Worlds
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Screens/Worlds");
				}
			}

			// Token: 0x17000136 RID: 310
			// (get) Token: 0x060006F3 RID: 1779 RVA: 0x00024480 File Offset: 0x00022680
			public static GameObject Menu_wqoRd0FotfW91RAccountswqoRd0FotfW91R
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R");
				}
			}

			// Token: 0x020000EF RID: 239
			public class Announcement_2
			{
				// Token: 0x170001DB RID: 475
				// (get) Token: 0x06000852 RID: 2130 RVA: 0x00027230 File Offset: 0x00025430
				public static GameObject Panel
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Announcement/Panel");
					}
				}

				// Token: 0x0200018B RID: 395
				public class Panel_3
				{
					// Token: 0x1700039E RID: 926
					// (get) Token: 0x06000ABA RID: 2746 RVA: 0x0002AAF0 File Offset: 0x00028CF0
					public static GameObject Text
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Announcement/Panel/Text");
						}
					}

					// Token: 0x1700039F RID: 927
					// (get) Token: 0x06000ABB RID: 2747 RVA: 0x0002AB0C File Offset: 0x00028D0C
					public static GameObject ButtonBack
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Announcement/Panel/ButtonBack");
						}
					}

					// Token: 0x170003A0 RID: 928
					// (get) Token: 0x06000ABC RID: 2748 RVA: 0x0002AB28 File Offset: 0x00028D28
					public static GameObject ButtonDone
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Announcement/Panel/ButtonDone");
						}
					}

					// Token: 0x170003A1 RID: 929
					// (get) Token: 0x06000ABD RID: 2749 RVA: 0x0002AB44 File Offset: 0x00028D44
					public static GameObject Scroll_View
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Announcement/Panel/Scroll View");
						}
					}

					// Token: 0x02000287 RID: 647
					public class ButtonBack_4
					{
						// Token: 0x1700064C RID: 1612
						// (get) Token: 0x06000E64 RID: 3684 RVA: 0x000301C8 File Offset: 0x0002E3C8
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Announcement/Panel/ButtonBack/Text");
							}
						}

						// Token: 0x1700064D RID: 1613
						// (get) Token: 0x06000E65 RID: 3685 RVA: 0x000301E4 File Offset: 0x0002E3E4
						public static GameObject Image
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Announcement/Panel/ButtonBack/Image");
							}
						}
					}

					// Token: 0x02000288 RID: 648
					public class ButtonDone_4
					{
						// Token: 0x1700064E RID: 1614
						// (get) Token: 0x06000E67 RID: 3687 RVA: 0x0003020C File Offset: 0x0002E40C
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Announcement/Panel/ButtonDone/Text");
							}
						}

						// Token: 0x1700064F RID: 1615
						// (get) Token: 0x06000E68 RID: 3688 RVA: 0x00030228 File Offset: 0x0002E428
						public static GameObject Image
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Announcement/Panel/ButtonDone/Image");
							}
						}
					}
				}
			}

			// Token: 0x020000F0 RID: 240
			public class Authentication_2
			{
				// Token: 0x170001DC RID: 476
				// (get) Token: 0x06000854 RID: 2132 RVA: 0x00027258 File Offset: 0x00025458
				public static GameObject Login2FA
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA");
					}
				}

				// Token: 0x170001DD RID: 477
				// (get) Token: 0x06000855 RID: 2133 RVA: 0x00027274 File Offset: 0x00025474
				public static GameObject Login2FARecovery
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery");
					}
				}

				// Token: 0x170001DE RID: 478
				// (get) Token: 0x06000856 RID: 2134 RVA: 0x00027290 File Offset: 0x00025490
				public static GameObject LoginPrompt
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt");
					}
				}

				// Token: 0x170001DF RID: 479
				// (get) Token: 0x06000857 RID: 2135 RVA: 0x000272AC File Offset: 0x000254AC
				public static GameObject LoginUserPass
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass");
					}
				}

				// Token: 0x170001E0 RID: 480
				// (get) Token: 0x06000858 RID: 2136 RVA: 0x000272C8 File Offset: 0x000254C8
				public static GameObject LoginCreateFromWebsite
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginCreateFromWebsite");
					}
				}

				// Token: 0x170001E1 RID: 481
				// (get) Token: 0x06000859 RID: 2137 RVA: 0x000272E4 File Offset: 0x000254E4
				public static GameObject StoreLoginPrompt
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt");
					}
				}

				// Token: 0x170001E2 RID: 482
				// (get) Token: 0x0600085A RID: 2138 RVA: 0x00027300 File Offset: 0x00025500
				public static GameObject LoginUpdate
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate");
					}
				}

				// Token: 0x170001E3 RID: 483
				// (get) Token: 0x0600085B RID: 2139 RVA: 0x0002731C File Offset: 0x0002551C
				public static GameObject LoginUpdateVS
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS");
					}
				}

				// Token: 0x170001E4 RID: 484
				// (get) Token: 0x0600085C RID: 2140 RVA: 0x00027338 File Offset: 0x00025538
				public static GameObject AgreeTermsOfService
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService");
					}
				}

				// Token: 0x170001E5 RID: 485
				// (get) Token: 0x0600085D RID: 2141 RVA: 0x00027354 File Offset: 0x00025554
				public static GameObject ViveportStoreLoginPrompt
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt");
					}
				}

				// Token: 0x170001E6 RID: 486
				// (get) Token: 0x0600085E RID: 2142 RVA: 0x00027370 File Offset: 0x00025570
				public static GameObject OculusStoreLoginPrompt
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt");
					}
				}

				// Token: 0x0200018C RID: 396
				public class Login2FA_3
				{
					// Token: 0x170003A2 RID: 930
					// (get) Token: 0x06000ABF RID: 2751 RVA: 0x0002AB6C File Offset: 0x00028D6C
					public static GameObject VRChat_LOGO
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/VRChat_LOGO");
						}
					}

					// Token: 0x170003A3 RID: 931
					// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x0002AB88 File Offset: 0x00028D88
					public static GameObject TextWelcome
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/TextWelcome");
						}
					}

					// Token: 0x170003A4 RID: 932
					// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x0002ABA4 File Offset: 0x00028DA4
					public static GameObject BoxLogin2FA
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/BoxLogin2FA");
						}
					}

					// Token: 0x170003A5 RID: 933
					// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x0002ABC0 File Offset: 0x00028DC0
					public static GameObject ButtonAboutUs
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/ButtonAboutUs");
						}
					}

					// Token: 0x170003A6 RID: 934
					// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x0002ABDC File Offset: 0x00028DDC
					public static GameObject TextVRChat
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/TextVRChat");
						}
					}

					// Token: 0x02000289 RID: 649
					public class BoxLogin2FA_4
					{
						// Token: 0x17000650 RID: 1616
						// (get) Token: 0x06000E6A RID: 3690 RVA: 0x00030250 File Offset: 0x0002E450
						public static GameObject Panel
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/BoxLogin2FA/Panel");
							}
						}

						// Token: 0x17000651 RID: 1617
						// (get) Token: 0x06000E6B RID: 3691 RVA: 0x0003026C File Offset: 0x0002E46C
						public static GameObject Title
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/BoxLogin2FA/Title");
							}
						}

						// Token: 0x17000652 RID: 1618
						// (get) Token: 0x06000E6C RID: 3692 RVA: 0x00030288 File Offset: 0x0002E488
						public static GameObject Instructions
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/BoxLogin2FA/Instructions");
							}
						}

						// Token: 0x17000653 RID: 1619
						// (get) Token: 0x06000E6D RID: 3693 RVA: 0x000302A4 File Offset: 0x0002E4A4
						public static GameObject InputField2FACode
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/BoxLogin2FA/InputField2FACode");
							}
						}

						// Token: 0x17000654 RID: 1620
						// (get) Token: 0x06000E6E RID: 3694 RVA: 0x000302C0 File Offset: 0x0002E4C0
						public static GameObject ButtonDone
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/BoxLogin2FA/ButtonDone");
							}
						}

						// Token: 0x17000655 RID: 1621
						// (get) Token: 0x06000E6F RID: 3695 RVA: 0x000302DC File Offset: 0x0002E4DC
						public static GameObject ButtonBack
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/BoxLogin2FA/ButtonBack");
							}
						}

						// Token: 0x17000656 RID: 1622
						// (get) Token: 0x06000E70 RID: 3696 RVA: 0x000302F8 File Offset: 0x0002E4F8
						public static GameObject ButtonUseRecoveryCode
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/BoxLogin2FA/ButtonUseRecoveryCode");
							}
						}

						// Token: 0x17000657 RID: 1623
						// (get) Token: 0x06000E71 RID: 3697 RVA: 0x00030314 File Offset: 0x0002E514
						public static GameObject ButtonHelp
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/BoxLogin2FA/ButtonHelp");
							}
						}

						// Token: 0x02000382 RID: 898
						public class ButtonDone_5
						{
							// Token: 0x1700087B RID: 2171
							// (get) Token: 0x0600118E RID: 4494 RVA: 0x00034AB0 File Offset: 0x00032CB0
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/BoxLogin2FA/ButtonDone/Text");
								}
							}
						}

						// Token: 0x02000383 RID: 899
						public class ButtonBack_5
						{
							// Token: 0x1700087C RID: 2172
							// (get) Token: 0x06001190 RID: 4496 RVA: 0x00034AD8 File Offset: 0x00032CD8
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/BoxLogin2FA/ButtonBack/Text");
								}
							}
						}

						// Token: 0x02000384 RID: 900
						public class ButtonUseRecoveryCode_5
						{
							// Token: 0x1700087D RID: 2173
							// (get) Token: 0x06001192 RID: 4498 RVA: 0x00034B00 File Offset: 0x00032D00
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/BoxLogin2FA/ButtonUseRecoveryCode/Text");
								}
							}
						}

						// Token: 0x02000385 RID: 901
						public class ButtonHelp_5
						{
							// Token: 0x1700087E RID: 2174
							// (get) Token: 0x06001194 RID: 4500 RVA: 0x00034B28 File Offset: 0x00032D28
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/BoxLogin2FA/ButtonHelp/Text");
								}
							}
						}
					}

					// Token: 0x0200028A RID: 650
					public class ButtonAboutUs_4
					{
						// Token: 0x17000658 RID: 1624
						// (get) Token: 0x06000E73 RID: 3699 RVA: 0x0003033C File Offset: 0x0002E53C
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/ButtonAboutUs/Text");
							}
						}

						// Token: 0x17000659 RID: 1625
						// (get) Token: 0x06000E74 RID: 3700 RVA: 0x00030358 File Offset: 0x0002E558
						public static GameObject About_Panel
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/ButtonAboutUs/About_Panel");
							}
						}

						// Token: 0x02000386 RID: 902
						public class About_Panel_5
						{
							// Token: 0x1700087F RID: 2175
							// (get) Token: 0x06001196 RID: 4502 RVA: 0x00034B50 File Offset: 0x00032D50
							public static GameObject Text_2
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/ButtonAboutUs/About_Panel/Text (2)");
								}
							}

							// Token: 0x17000880 RID: 2176
							// (get) Token: 0x06001197 RID: 4503 RVA: 0x00034B6C File Offset: 0x00032D6C
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/ButtonAboutUs/About_Panel/Text");
								}
							}
						}
					}
				}

				// Token: 0x0200018D RID: 397
				public class Login2FARecovery_3
				{
					// Token: 0x170003A7 RID: 935
					// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x0002AC04 File Offset: 0x00028E04
					public static GameObject VRChat_LOGO
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/VRChat_LOGO");
						}
					}

					// Token: 0x170003A8 RID: 936
					// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x0002AC20 File Offset: 0x00028E20
					public static GameObject TextWelcome
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/TextWelcome");
						}
					}

					// Token: 0x170003A9 RID: 937
					// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x0002AC3C File Offset: 0x00028E3C
					public static GameObject BoxLogin2FARecovery
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/BoxLogin2FARecovery");
						}
					}

					// Token: 0x170003AA RID: 938
					// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x0002AC58 File Offset: 0x00028E58
					public static GameObject ButtonAboutUs
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/ButtonAboutUs");
						}
					}

					// Token: 0x170003AB RID: 939
					// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x0002AC74 File Offset: 0x00028E74
					public static GameObject TextVRChat
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/TextVRChat");
						}
					}

					// Token: 0x0200028B RID: 651
					public class BoxLogin2FARecovery_4
					{
						// Token: 0x1700065A RID: 1626
						// (get) Token: 0x06000E76 RID: 3702 RVA: 0x00030380 File Offset: 0x0002E580
						public static GameObject Panel
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/BoxLogin2FARecovery/Panel");
							}
						}

						// Token: 0x1700065B RID: 1627
						// (get) Token: 0x06000E77 RID: 3703 RVA: 0x0003039C File Offset: 0x0002E59C
						public static GameObject Title
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/BoxLogin2FARecovery/Title");
							}
						}

						// Token: 0x1700065C RID: 1628
						// (get) Token: 0x06000E78 RID: 3704 RVA: 0x000303B8 File Offset: 0x0002E5B8
						public static GameObject Instructions
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/BoxLogin2FARecovery/Instructions");
							}
						}

						// Token: 0x1700065D RID: 1629
						// (get) Token: 0x06000E79 RID: 3705 RVA: 0x000303D4 File Offset: 0x0002E5D4
						public static GameObject InputField2FARecoveryCode
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/BoxLogin2FARecovery/InputField2FARecoveryCode");
							}
						}

						// Token: 0x1700065E RID: 1630
						// (get) Token: 0x06000E7A RID: 3706 RVA: 0x000303F0 File Offset: 0x0002E5F0
						public static GameObject ButtonDone
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/BoxLogin2FARecovery/ButtonDone");
							}
						}

						// Token: 0x1700065F RID: 1631
						// (get) Token: 0x06000E7B RID: 3707 RVA: 0x0003040C File Offset: 0x0002E60C
						public static GameObject ButtonBack
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/BoxLogin2FARecovery/ButtonBack");
							}
						}

						// Token: 0x17000660 RID: 1632
						// (get) Token: 0x06000E7C RID: 3708 RVA: 0x00030428 File Offset: 0x0002E628
						public static GameObject ButtonHelp
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/BoxLogin2FARecovery/ButtonHelp");
							}
						}

						// Token: 0x02000387 RID: 903
						public class ButtonDone_5
						{
							// Token: 0x17000881 RID: 2177
							// (get) Token: 0x06001199 RID: 4505 RVA: 0x00034B94 File Offset: 0x00032D94
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/BoxLogin2FARecovery/ButtonDone/Text");
								}
							}
						}

						// Token: 0x02000388 RID: 904
						public class ButtonBack_5
						{
							// Token: 0x17000882 RID: 2178
							// (get) Token: 0x0600119B RID: 4507 RVA: 0x00034BBC File Offset: 0x00032DBC
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/BoxLogin2FARecovery/ButtonBack/Text");
								}
							}
						}

						// Token: 0x02000389 RID: 905
						public class ButtonHelp_5
						{
							// Token: 0x17000883 RID: 2179
							// (get) Token: 0x0600119D RID: 4509 RVA: 0x00034BE4 File Offset: 0x00032DE4
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/BoxLogin2FARecovery/ButtonHelp/Text");
								}
							}
						}
					}

					// Token: 0x0200028C RID: 652
					public class ButtonAboutUs_4
					{
						// Token: 0x17000661 RID: 1633
						// (get) Token: 0x06000E7E RID: 3710 RVA: 0x00030450 File Offset: 0x0002E650
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/ButtonAboutUs/Text");
							}
						}

						// Token: 0x17000662 RID: 1634
						// (get) Token: 0x06000E7F RID: 3711 RVA: 0x0003046C File Offset: 0x0002E66C
						public static GameObject About_Panel
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/ButtonAboutUs/About_Panel");
							}
						}

						// Token: 0x0200038A RID: 906
						public class About_Panel_5
						{
							// Token: 0x17000884 RID: 2180
							// (get) Token: 0x0600119F RID: 4511 RVA: 0x00034C0C File Offset: 0x00032E0C
							public static GameObject Text_2
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/ButtonAboutUs/About_Panel/Text (2)");
								}
							}

							// Token: 0x17000885 RID: 2181
							// (get) Token: 0x060011A0 RID: 4512 RVA: 0x00034C28 File Offset: 0x00032E28
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/ButtonAboutUs/About_Panel/Text");
								}
							}
						}
					}
				}

				// Token: 0x0200018E RID: 398
				public class LoginPrompt_3
				{
					// Token: 0x170003AC RID: 940
					// (get) Token: 0x06000ACB RID: 2763 RVA: 0x0002AC9C File Offset: 0x00028E9C
					public static GameObject VRChatButtonLogin
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/VRChatButtonLogin");
						}
					}

					// Token: 0x170003AD RID: 941
					// (get) Token: 0x06000ACC RID: 2764 RVA: 0x0002ACB8 File Offset: 0x00028EB8
					public static GameObject ButtonCreate
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/ButtonCreate");
						}
					}

					// Token: 0x170003AE RID: 942
					// (get) Token: 0x06000ACD RID: 2765 RVA: 0x0002ACD4 File Offset: 0x00028ED4
					public static GameObject ButtonBypass
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/ButtonBypass");
						}
					}

					// Token: 0x170003AF RID: 943
					// (get) Token: 0x06000ACE RID: 2766 RVA: 0x0002ACF0 File Offset: 0x00028EF0
					public static GameObject TextWelcome
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/TextWelcome");
						}
					}

					// Token: 0x170003B0 RID: 944
					// (get) Token: 0x06000ACF RID: 2767 RVA: 0x0002AD0C File Offset: 0x00028F0C
					public static GameObject VRChat_LOGO
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/VRChat_LOGO");
						}
					}

					// Token: 0x170003B1 RID: 945
					// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x0002AD28 File Offset: 0x00028F28
					public static GameObject TextVRChat
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/TextVRChat");
						}
					}

					// Token: 0x170003B2 RID: 946
					// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x0002AD44 File Offset: 0x00028F44
					public static GameObject TextOr
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/TextOr");
						}
					}

					// Token: 0x170003B3 RID: 947
					// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x0002AD60 File Offset: 0x00028F60
					public static GameObject TextLoginWith
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/TextLoginWith");
						}
					}

					// Token: 0x170003B4 RID: 948
					// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x0002AD7C File Offset: 0x00028F7C
					public static GameObject ButtonAboutUs_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/ButtonAboutUs (1)");
						}
					}

					// Token: 0x170003B5 RID: 949
					// (get) Token: 0x06000AD4 RID: 2772 RVA: 0x0002AD98 File Offset: 0x00028F98
					public static GameObject StoreButtonLogin_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/StoreButtonLogin (1)");
						}
					}

					// Token: 0x170003B6 RID: 950
					// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x0002ADB4 File Offset: 0x00028FB4
					public static GameObject LanguagePanel
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/LanguagePanel");
						}
					}

					// Token: 0x0200028D RID: 653
					public class VRChatButtonLogin_4
					{
						// Token: 0x17000663 RID: 1635
						// (get) Token: 0x06000E81 RID: 3713 RVA: 0x00030494 File Offset: 0x0002E694
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/VRChatButtonLogin/Text");
							}
						}
					}

					// Token: 0x0200028E RID: 654
					public class ButtonCreate_4
					{
						// Token: 0x17000664 RID: 1636
						// (get) Token: 0x06000E83 RID: 3715 RVA: 0x000304BC File Offset: 0x0002E6BC
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/ButtonCreate/Text");
							}
						}
					}

					// Token: 0x0200028F RID: 655
					public class ButtonBypass_4
					{
						// Token: 0x17000665 RID: 1637
						// (get) Token: 0x06000E85 RID: 3717 RVA: 0x000304E4 File Offset: 0x0002E6E4
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/ButtonBypass/Text");
							}
						}
					}

					// Token: 0x02000290 RID: 656
					public class ButtonAboutUs_1_4
					{
						// Token: 0x17000666 RID: 1638
						// (get) Token: 0x06000E87 RID: 3719 RVA: 0x0003050C File Offset: 0x0002E70C
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/ButtonAboutUs (1)/Text");
							}
						}

						// Token: 0x17000667 RID: 1639
						// (get) Token: 0x06000E88 RID: 3720 RVA: 0x00030528 File Offset: 0x0002E728
						public static GameObject Image
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/ButtonAboutUs (1)/Image");
							}
						}

						// Token: 0x0200038B RID: 907
						public class Image_5
						{
							// Token: 0x17000886 RID: 2182
							// (get) Token: 0x060011A2 RID: 4514 RVA: 0x00034C50 File Offset: 0x00032E50
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/ButtonAboutUs (1)/Image/Text");
								}
							}

							// Token: 0x17000887 RID: 2183
							// (get) Token: 0x060011A3 RID: 4515 RVA: 0x00034C6C File Offset: 0x00032E6C
							public static GameObject Text_1
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/ButtonAboutUs (1)/Image/Text (1)");
								}
							}
						}
					}

					// Token: 0x02000291 RID: 657
					public class StoreButtonLogin_1_4
					{
						// Token: 0x17000668 RID: 1640
						// (get) Token: 0x06000E8A RID: 3722 RVA: 0x00030550 File Offset: 0x0002E750
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/StoreButtonLogin (1)/Text");
							}
						}
					}

					// Token: 0x02000292 RID: 658
					public class LanguagePanel_4
					{
						// Token: 0x17000669 RID: 1641
						// (get) Token: 0x06000E8C RID: 3724 RVA: 0x00030578 File Offset: 0x0002E778
						public static GameObject TitleText_1
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/LanguagePanel/TitleText (1)");
							}
						}

						// Token: 0x1700066A RID: 1642
						// (get) Token: 0x06000E8D RID: 3725 RVA: 0x00030594 File Offset: 0x0002E794
						public static GameObject SelectPrevLang
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/LanguagePanel/SelectPrevLang");
							}
						}

						// Token: 0x1700066B RID: 1643
						// (get) Token: 0x06000E8E RID: 3726 RVA: 0x000305B0 File Offset: 0x0002E7B0
						public static GameObject SelectNextLang
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/LanguagePanel/SelectNextLang");
							}
						}

						// Token: 0x1700066C RID: 1644
						// (get) Token: 0x06000E8F RID: 3727 RVA: 0x000305CC File Offset: 0x0002E7CC
						public static GameObject Language
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/LanguagePanel/Language");
							}
						}
					}
				}

				// Token: 0x0200018F RID: 399
				public class LoginUserPass_3
				{
					// Token: 0x170003B7 RID: 951
					// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x0002ADDC File Offset: 0x00028FDC
					public static GameObject VRChat_LOGO_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/VRChat_LOGO (1)");
						}
					}

					// Token: 0x170003B8 RID: 952
					// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x0002ADF8 File Offset: 0x00028FF8
					public static GameObject TextWelcome
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/TextWelcome");
						}
					}

					// Token: 0x170003B9 RID: 953
					// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x0002AE14 File Offset: 0x00029014
					public static GameObject BoxLogin
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/BoxLogin");
						}
					}

					// Token: 0x170003BA RID: 954
					// (get) Token: 0x06000ADA RID: 2778 RVA: 0x0002AE30 File Offset: 0x00029030
					public static GameObject ButtonDone_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/ButtonDone (1)");
						}
					}

					// Token: 0x170003BB RID: 955
					// (get) Token: 0x06000ADB RID: 2779 RVA: 0x0002AE4C File Offset: 0x0002904C
					public static GameObject ButtonBack_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/ButtonBack (1)");
						}
					}

					// Token: 0x170003BC RID: 956
					// (get) Token: 0x06000ADC RID: 2780 RVA: 0x0002AE68 File Offset: 0x00029068
					public static GameObject ButtonAboutUs
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/ButtonAboutUs");
						}
					}

					// Token: 0x170003BD RID: 957
					// (get) Token: 0x06000ADD RID: 2781 RVA: 0x0002AE84 File Offset: 0x00029084
					public static GameObject TextVRChat
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/TextVRChat");
						}
					}

					// Token: 0x02000293 RID: 659
					public class BoxLogin_4
					{
						// Token: 0x1700066D RID: 1645
						// (get) Token: 0x06000E91 RID: 3729 RVA: 0x000305F4 File Offset: 0x0002E7F4
						public static GameObject Panel
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/BoxLogin/Panel");
							}
						}

						// Token: 0x1700066E RID: 1646
						// (get) Token: 0x06000E92 RID: 3730 RVA: 0x00030610 File Offset: 0x0002E810
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/BoxLogin/Text");
							}
						}

						// Token: 0x1700066F RID: 1647
						// (get) Token: 0x06000E93 RID: 3731 RVA: 0x0003062C File Offset: 0x0002E82C
						public static GameObject InputFieldUser
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/BoxLogin/InputFieldUser");
							}
						}

						// Token: 0x17000670 RID: 1648
						// (get) Token: 0x06000E94 RID: 3732 RVA: 0x00030648 File Offset: 0x0002E848
						public static GameObject InputFieldPassword
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/BoxLogin/InputFieldPassword");
							}
						}
					}

					// Token: 0x02000294 RID: 660
					public class ButtonDone_1_4
					{
						// Token: 0x17000671 RID: 1649
						// (get) Token: 0x06000E96 RID: 3734 RVA: 0x00030670 File Offset: 0x0002E870
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/ButtonDone (1)/Text");
							}
						}
					}

					// Token: 0x02000295 RID: 661
					public class ButtonBack_1_4
					{
						// Token: 0x17000672 RID: 1650
						// (get) Token: 0x06000E98 RID: 3736 RVA: 0x00030698 File Offset: 0x0002E898
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/ButtonBack (1)/Text");
							}
						}
					}

					// Token: 0x02000296 RID: 662
					public class ButtonAboutUs_4
					{
						// Token: 0x17000673 RID: 1651
						// (get) Token: 0x06000E9A RID: 3738 RVA: 0x000306C0 File Offset: 0x0002E8C0
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/ButtonAboutUs/Text");
							}
						}

						// Token: 0x17000674 RID: 1652
						// (get) Token: 0x06000E9B RID: 3739 RVA: 0x000306DC File Offset: 0x0002E8DC
						public static GameObject About_Panel
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/ButtonAboutUs/About_Panel");
							}
						}

						// Token: 0x0200038C RID: 908
						public class About_Panel_5
						{
							// Token: 0x17000888 RID: 2184
							// (get) Token: 0x060011A5 RID: 4517 RVA: 0x00034C94 File Offset: 0x00032E94
							public static GameObject Text_2
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/ButtonAboutUs/About_Panel/Text (2)");
								}
							}

							// Token: 0x17000889 RID: 2185
							// (get) Token: 0x060011A6 RID: 4518 RVA: 0x00034CB0 File Offset: 0x00032EB0
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/ButtonAboutUs/About_Panel/Text");
								}
							}
						}
					}
				}

				// Token: 0x02000190 RID: 400
				public class LoginCreateFromWebsite_3
				{
					// Token: 0x170003BE RID: 958
					// (get) Token: 0x06000ADF RID: 2783 RVA: 0x0002AEAC File Offset: 0x000290AC
					public static GameObject Panel_Backdrop
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginCreateFromWebsite/Panel_Backdrop");
						}
					}

					// Token: 0x170003BF RID: 959
					// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x0002AEC8 File Offset: 0x000290C8
					public static GameObject ButtonAboutUs
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginCreateFromWebsite/ButtonAboutUs");
						}
					}

					// Token: 0x170003C0 RID: 960
					// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x0002AEE4 File Offset: 0x000290E4
					public static GameObject TextWelcome
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginCreateFromWebsite/TextWelcome");
						}
					}

					// Token: 0x170003C1 RID: 961
					// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x0002AF00 File Offset: 0x00029100
					public static GameObject TextVRChat
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginCreateFromWebsite/TextVRChat");
						}
					}

					// Token: 0x170003C2 RID: 962
					// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x0002AF1C File Offset: 0x0002911C
					public static GameObject Panel
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginCreateFromWebsite/Panel");
						}
					}

					// Token: 0x170003C3 RID: 963
					// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x0002AF38 File Offset: 0x00029138
					public static GameObject RegisterOnWebsiteText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginCreateFromWebsite/RegisterOnWebsiteText");
						}
					}

					// Token: 0x170003C4 RID: 964
					// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x0002AF54 File Offset: 0x00029154
					public static GameObject RegisterationCompletedText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginCreateFromWebsite/RegisterationCompletedText");
						}
					}

					// Token: 0x170003C5 RID: 965
					// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x0002AF70 File Offset: 0x00029170
					public static GameObject ButtonLogin
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginCreateFromWebsite/ButtonLogin");
						}
					}

					// Token: 0x02000297 RID: 663
					public class ButtonAboutUs_4
					{
						// Token: 0x17000675 RID: 1653
						// (get) Token: 0x06000E9D RID: 3741 RVA: 0x00030704 File Offset: 0x0002E904
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginCreateFromWebsite/ButtonAboutUs/Text");
							}
						}

						// Token: 0x17000676 RID: 1654
						// (get) Token: 0x06000E9E RID: 3742 RVA: 0x00030720 File Offset: 0x0002E920
						public static GameObject Image
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginCreateFromWebsite/ButtonAboutUs/Image");
							}
						}

						// Token: 0x0200038D RID: 909
						public class Image_5
						{
							// Token: 0x1700088A RID: 2186
							// (get) Token: 0x060011A8 RID: 4520 RVA: 0x00034CD8 File Offset: 0x00032ED8
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginCreateFromWebsite/ButtonAboutUs/Image/Text");
								}
							}
						}
					}

					// Token: 0x02000298 RID: 664
					public class Panel_4
					{
						// Token: 0x17000677 RID: 1655
						// (get) Token: 0x06000EA0 RID: 3744 RVA: 0x00030748 File Offset: 0x0002E948
						public static GameObject RegisterOnWebsiteText_1
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginCreateFromWebsite/Panel/RegisterOnWebsiteText (1)");
							}
						}
					}

					// Token: 0x02000299 RID: 665
					public class ButtonLogin_4
					{
						// Token: 0x17000678 RID: 1656
						// (get) Token: 0x06000EA2 RID: 3746 RVA: 0x00030770 File Offset: 0x0002E970
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginCreateFromWebsite/ButtonLogin/Text");
							}
						}

						// Token: 0x17000679 RID: 1657
						// (get) Token: 0x06000EA3 RID: 3747 RVA: 0x0003078C File Offset: 0x0002E98C
						public static GameObject Image
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginCreateFromWebsite/ButtonLogin/Image");
							}
						}
					}
				}

				// Token: 0x02000191 RID: 401
				public class StoreLoginPrompt_3
				{
					// Token: 0x170003C6 RID: 966
					// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x0002AF98 File Offset: 0x00029198
					public static GameObject VRChat_LOGO_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/VRChat_LOGO (1)");
						}
					}

					// Token: 0x170003C7 RID: 967
					// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x0002AFB4 File Offset: 0x000291B4
					public static GameObject VRChatButtonLogin
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/VRChatButtonLogin");
						}
					}

					// Token: 0x170003C8 RID: 968
					// (get) Token: 0x06000AEA RID: 2794 RVA: 0x0002AFD0 File Offset: 0x000291D0
					public static GameObject ButtonCreate
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/ButtonCreate");
						}
					}

					// Token: 0x170003C9 RID: 969
					// (get) Token: 0x06000AEB RID: 2795 RVA: 0x0002AFEC File Offset: 0x000291EC
					public static GameObject ButtonBypass
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/ButtonBypass");
						}
					}

					// Token: 0x170003CA RID: 970
					// (get) Token: 0x06000AEC RID: 2796 RVA: 0x0002B008 File Offset: 0x00029208
					public static GameObject TextWelcome
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/TextWelcome");
						}
					}

					// Token: 0x170003CB RID: 971
					// (get) Token: 0x06000AED RID: 2797 RVA: 0x0002B024 File Offset: 0x00029224
					public static GameObject TextVRChat
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/TextVRChat");
						}
					}

					// Token: 0x170003CC RID: 972
					// (get) Token: 0x06000AEE RID: 2798 RVA: 0x0002B040 File Offset: 0x00029240
					public static GameObject TextOr
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/TextOr");
						}
					}

					// Token: 0x170003CD RID: 973
					// (get) Token: 0x06000AEF RID: 2799 RVA: 0x0002B05C File Offset: 0x0002925C
					public static GameObject TextLoginWith
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/TextLoginWith");
						}
					}

					// Token: 0x170003CE RID: 974
					// (get) Token: 0x06000AF0 RID: 2800 RVA: 0x0002B078 File Offset: 0x00029278
					public static GameObject ButtonAboutUs_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/ButtonAboutUs (1)");
						}
					}

					// Token: 0x170003CF RID: 975
					// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x0002B094 File Offset: 0x00029294
					public static GameObject StoreButtonLogin_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/StoreButtonLogin (1)");
						}
					}

					// Token: 0x170003D0 RID: 976
					// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x0002B0B0 File Offset: 0x000292B0
					public static GameObject LanguagePanel
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/LanguagePanel");
						}
					}

					// Token: 0x0200029A RID: 666
					public class VRChatButtonLogin_4
					{
						// Token: 0x1700067A RID: 1658
						// (get) Token: 0x06000EA5 RID: 3749 RVA: 0x000307B4 File Offset: 0x0002E9B4
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/VRChatButtonLogin/Text");
							}
						}
					}

					// Token: 0x0200029B RID: 667
					public class ButtonCreate_4
					{
						// Token: 0x1700067B RID: 1659
						// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x000307DC File Offset: 0x0002E9DC
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/ButtonCreate/Text");
							}
						}
					}

					// Token: 0x0200029C RID: 668
					public class ButtonBypass_4
					{
						// Token: 0x1700067C RID: 1660
						// (get) Token: 0x06000EA9 RID: 3753 RVA: 0x00030804 File Offset: 0x0002EA04
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/ButtonBypass/Text");
							}
						}
					}

					// Token: 0x0200029D RID: 669
					public class ButtonAboutUs_1_4
					{
						// Token: 0x1700067D RID: 1661
						// (get) Token: 0x06000EAB RID: 3755 RVA: 0x0003082C File Offset: 0x0002EA2C
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/ButtonAboutUs (1)/Text");
							}
						}

						// Token: 0x1700067E RID: 1662
						// (get) Token: 0x06000EAC RID: 3756 RVA: 0x00030848 File Offset: 0x0002EA48
						public static GameObject Image
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/ButtonAboutUs (1)/Image");
							}
						}

						// Token: 0x0200038E RID: 910
						public class Image_5
						{
							// Token: 0x1700088B RID: 2187
							// (get) Token: 0x060011AA RID: 4522 RVA: 0x00034D00 File Offset: 0x00032F00
							public static GameObject Text_2
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/ButtonAboutUs (1)/Image/Text (2)");
								}
							}

							// Token: 0x1700088C RID: 2188
							// (get) Token: 0x060011AB RID: 4523 RVA: 0x00034D1C File Offset: 0x00032F1C
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/ButtonAboutUs (1)/Image/Text");
								}
							}
						}
					}

					// Token: 0x0200029E RID: 670
					public class StoreButtonLogin_1_4
					{
						// Token: 0x1700067F RID: 1663
						// (get) Token: 0x06000EAE RID: 3758 RVA: 0x00030870 File Offset: 0x0002EA70
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/StoreButtonLogin (1)/Text");
							}
						}
					}

					// Token: 0x0200029F RID: 671
					public class LanguagePanel_4
					{
						// Token: 0x17000680 RID: 1664
						// (get) Token: 0x06000EB0 RID: 3760 RVA: 0x00030898 File Offset: 0x0002EA98
						public static GameObject TitleText_1
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/LanguagePanel/TitleText (1)");
							}
						}

						// Token: 0x17000681 RID: 1665
						// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x000308B4 File Offset: 0x0002EAB4
						public static GameObject SelectPrevLang
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/LanguagePanel/SelectPrevLang");
							}
						}

						// Token: 0x17000682 RID: 1666
						// (get) Token: 0x06000EB2 RID: 3762 RVA: 0x000308D0 File Offset: 0x0002EAD0
						public static GameObject SelectNextLang
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/LanguagePanel/SelectNextLang");
							}
						}

						// Token: 0x17000683 RID: 1667
						// (get) Token: 0x06000EB3 RID: 3763 RVA: 0x000308EC File Offset: 0x0002EAEC
						public static GameObject Language
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/LanguagePanel/Language");
							}
						}
					}
				}

				// Token: 0x02000192 RID: 402
				public class LoginUpdate_3
				{
					// Token: 0x170003D1 RID: 977
					// (get) Token: 0x06000AF4 RID: 2804 RVA: 0x0002B0D8 File Offset: 0x000292D8
					public static GameObject VRChat_LOGO_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/VRChat_LOGO (1)");
						}
					}

					// Token: 0x170003D2 RID: 978
					// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x0002B0F4 File Offset: 0x000292F4
					public static GameObject Create
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/Create");
						}
					}

					// Token: 0x170003D3 RID: 979
					// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x0002B110 File Offset: 0x00029310
					public static GameObject TextWelcome
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/TextWelcome");
						}
					}

					// Token: 0x170003D4 RID: 980
					// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x0002B12C File Offset: 0x0002932C
					public static GameObject TextVRChat
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/TextVRChat");
						}
					}

					// Token: 0x170003D5 RID: 981
					// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x0002B148 File Offset: 0x00029348
					public static GameObject ButtonBack
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/ButtonBack");
						}
					}

					// Token: 0x170003D6 RID: 982
					// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x0002B164 File Offset: 0x00029364
					public static GameObject ButtonAboutUs
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/ButtonAboutUs");
						}
					}

					// Token: 0x170003D7 RID: 983
					// (get) Token: 0x06000AFA RID: 2810 RVA: 0x0002B180 File Offset: 0x00029380
					public static GameObject ButtonDone
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/ButtonDone");
						}
					}

					// Token: 0x020002A0 RID: 672
					public class Create_4
					{
						// Token: 0x17000684 RID: 1668
						// (get) Token: 0x06000EB5 RID: 3765 RVA: 0x00030914 File Offset: 0x0002EB14
						public static GameObject Panel
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/Create/Panel");
							}
						}

						// Token: 0x17000685 RID: 1669
						// (get) Token: 0x06000EB6 RID: 3766 RVA: 0x00030930 File Offset: 0x0002EB30
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/Create/Text");
							}
						}

						// Token: 0x17000686 RID: 1670
						// (get) Token: 0x06000EB7 RID: 3767 RVA: 0x0003094C File Offset: 0x0002EB4C
						public static GameObject InputFieldEmail
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/Create/InputFieldEmail");
							}
						}

						// Token: 0x17000687 RID: 1671
						// (get) Token: 0x06000EB8 RID: 3768 RVA: 0x00030968 File Offset: 0x0002EB68
						public static GameObject InputFieldBirthday
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/Create/InputFieldBirthday");
							}
						}
					}

					// Token: 0x020002A1 RID: 673
					public class ButtonBack_4
					{
						// Token: 0x17000688 RID: 1672
						// (get) Token: 0x06000EBA RID: 3770 RVA: 0x00030990 File Offset: 0x0002EB90
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/ButtonBack/Text");
							}
						}

						// Token: 0x17000689 RID: 1673
						// (get) Token: 0x06000EBB RID: 3771 RVA: 0x000309AC File Offset: 0x0002EBAC
						public static GameObject Image
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/ButtonBack/Image");
							}
						}
					}

					// Token: 0x020002A2 RID: 674
					public class ButtonAboutUs_4
					{
						// Token: 0x1700068A RID: 1674
						// (get) Token: 0x06000EBD RID: 3773 RVA: 0x000309D4 File Offset: 0x0002EBD4
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/ButtonAboutUs/Text");
							}
						}

						// Token: 0x1700068B RID: 1675
						// (get) Token: 0x06000EBE RID: 3774 RVA: 0x000309F0 File Offset: 0x0002EBF0
						public static GameObject Image
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/ButtonAboutUs/Image");
							}
						}

						// Token: 0x0200038F RID: 911
						public class Image_5
						{
							// Token: 0x1700088D RID: 2189
							// (get) Token: 0x060011AD RID: 4525 RVA: 0x00034D44 File Offset: 0x00032F44
							public static GameObject Text_
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/ButtonAboutUs/Image/Text (3)");
								}
							}

							// Token: 0x1700088E RID: 2190
							// (get) Token: 0x060011AE RID: 4526 RVA: 0x00034D60 File Offset: 0x00032F60
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/ButtonAboutUs/Image/Text");
								}
							}
						}
					}

					// Token: 0x020002A3 RID: 675
					public class ButtonDone_4
					{
						// Token: 0x1700068C RID: 1676
						// (get) Token: 0x06000EC0 RID: 3776 RVA: 0x00030A18 File Offset: 0x0002EC18
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/ButtonDone/Text");
							}
						}

						// Token: 0x1700068D RID: 1677
						// (get) Token: 0x06000EC1 RID: 3777 RVA: 0x00030A34 File Offset: 0x0002EC34
						public static GameObject Image
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/ButtonDone/Image");
							}
						}
					}
				}

				// Token: 0x02000193 RID: 403
				public class LoginUpdateVS_3
				{
					// Token: 0x170003D8 RID: 984
					// (get) Token: 0x06000AFC RID: 2812 RVA: 0x0002B1A8 File Offset: 0x000293A8
					public static GameObject Create
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/Create");
						}
					}

					// Token: 0x170003D9 RID: 985
					// (get) Token: 0x06000AFD RID: 2813 RVA: 0x0002B1C4 File Offset: 0x000293C4
					public static GameObject ButtonBack
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/ButtonBack");
						}
					}

					// Token: 0x170003DA RID: 986
					// (get) Token: 0x06000AFE RID: 2814 RVA: 0x0002B1E0 File Offset: 0x000293E0
					public static GameObject ButtonAboutUs
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/ButtonAboutUs");
						}
					}

					// Token: 0x170003DB RID: 987
					// (get) Token: 0x06000AFF RID: 2815 RVA: 0x0002B1FC File Offset: 0x000293FC
					public static GameObject ButtonDone
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/ButtonDone");
						}
					}

					// Token: 0x020002A4 RID: 676
					public class Create_4
					{
						// Token: 0x1700068E RID: 1678
						// (get) Token: 0x06000EC3 RID: 3779 RVA: 0x00030A5C File Offset: 0x0002EC5C
						public static GameObject Panel
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/Create/Panel");
							}
						}

						// Token: 0x1700068F RID: 1679
						// (get) Token: 0x06000EC4 RID: 3780 RVA: 0x00030A78 File Offset: 0x0002EC78
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/Create/Text");
							}
						}

						// Token: 0x17000690 RID: 1680
						// (get) Token: 0x06000EC5 RID: 3781 RVA: 0x00030A94 File Offset: 0x0002EC94
						public static GameObject InputFieldEmail
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/Create/InputFieldEmail");
							}
						}

						// Token: 0x17000691 RID: 1681
						// (get) Token: 0x06000EC6 RID: 3782 RVA: 0x00030AB0 File Offset: 0x0002ECB0
						public static GameObject InputFieldBirthday
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/Create/InputFieldBirthday");
							}
						}
					}

					// Token: 0x020002A5 RID: 677
					public class ButtonBack_4
					{
						// Token: 0x17000692 RID: 1682
						// (get) Token: 0x06000EC8 RID: 3784 RVA: 0x00030AD8 File Offset: 0x0002ECD8
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/ButtonBack/Text");
							}
						}

						// Token: 0x17000693 RID: 1683
						// (get) Token: 0x06000EC9 RID: 3785 RVA: 0x00030AF4 File Offset: 0x0002ECF4
						public static GameObject Image
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/ButtonBack/Image");
							}
						}
					}

					// Token: 0x020002A6 RID: 678
					public class ButtonAboutUs_4
					{
						// Token: 0x17000694 RID: 1684
						// (get) Token: 0x06000ECB RID: 3787 RVA: 0x00030B1C File Offset: 0x0002ED1C
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/ButtonAboutUs/Text");
							}
						}

						// Token: 0x17000695 RID: 1685
						// (get) Token: 0x06000ECC RID: 3788 RVA: 0x00030B38 File Offset: 0x0002ED38
						public static GameObject Image
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/ButtonAboutUs/Image");
							}
						}

						// Token: 0x02000390 RID: 912
						public class Image_5
						{
							// Token: 0x1700088F RID: 2191
							// (get) Token: 0x060011B0 RID: 4528 RVA: 0x00034D88 File Offset: 0x00032F88
							public static GameObject Text_
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/ButtonAboutUs/Image/Text (3)");
								}
							}

							// Token: 0x17000890 RID: 2192
							// (get) Token: 0x060011B1 RID: 4529 RVA: 0x00034DA4 File Offset: 0x00032FA4
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/ButtonAboutUs/Image/Text");
								}
							}
						}
					}

					// Token: 0x020002A7 RID: 679
					public class ButtonDone_4
					{
						// Token: 0x17000696 RID: 1686
						// (get) Token: 0x06000ECE RID: 3790 RVA: 0x00030B60 File Offset: 0x0002ED60
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/ButtonDone/Text");
							}
						}

						// Token: 0x17000697 RID: 1687
						// (get) Token: 0x06000ECF RID: 3791 RVA: 0x00030B7C File Offset: 0x0002ED7C
						public static GameObject Image
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/ButtonDone/Image");
							}
						}
					}
				}

				// Token: 0x02000194 RID: 404
				public class AgreeTermsOfService_3
				{
					// Token: 0x170003DC RID: 988
					// (get) Token: 0x06000B01 RID: 2817 RVA: 0x0002B224 File Offset: 0x00029424
					public static GameObject Panel
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService/Panel");
						}
					}

					// Token: 0x020002A8 RID: 680
					public class Panel_4
					{
						// Token: 0x17000698 RID: 1688
						// (get) Token: 0x06000ED1 RID: 3793 RVA: 0x00030BA4 File Offset: 0x0002EDA4
						public static GameObject Panel
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService/Panel/Panel");
							}
						}

						// Token: 0x17000699 RID: 1689
						// (get) Token: 0x06000ED2 RID: 3794 RVA: 0x00030BC0 File Offset: 0x0002EDC0
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService/Panel/Text");
							}
						}

						// Token: 0x1700069A RID: 1690
						// (get) Token: 0x06000ED3 RID: 3795 RVA: 0x00030BDC File Offset: 0x0002EDDC
						public static GameObject ButtonBack
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService/Panel/ButtonBack");
							}
						}

						// Token: 0x1700069B RID: 1691
						// (get) Token: 0x06000ED4 RID: 3796 RVA: 0x00030BF8 File Offset: 0x0002EDF8
						public static GameObject ButtonDone
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService/Panel/ButtonDone");
							}
						}

						// Token: 0x1700069C RID: 1692
						// (get) Token: 0x06000ED5 RID: 3797 RVA: 0x00030C14 File Offset: 0x0002EE14
						public static GameObject ToggleAgree
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService/Panel/ToggleAgree");
							}
						}

						// Token: 0x1700069D RID: 1693
						// (get) Token: 0x06000ED6 RID: 3798 RVA: 0x00030C30 File Offset: 0x0002EE30
						public static GameObject Scroll_View
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService/Panel/Scroll View");
							}
						}

						// Token: 0x1700069E RID: 1694
						// (get) Token: 0x06000ED7 RID: 3799 RVA: 0x00030C4C File Offset: 0x0002EE4C
						public static GameObject AgreeText
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService/Panel/AgreeText");
							}
						}

						// Token: 0x02000391 RID: 913
						public class ButtonBack_5
						{
							// Token: 0x17000891 RID: 2193
							// (get) Token: 0x060011B3 RID: 4531 RVA: 0x00034DCC File Offset: 0x00032FCC
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService/Panel/ButtonBack/Text");
								}
							}

							// Token: 0x17000892 RID: 2194
							// (get) Token: 0x060011B4 RID: 4532 RVA: 0x00034DE8 File Offset: 0x00032FE8
							public static GameObject Image
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService/Panel/ButtonBack/Image");
								}
							}
						}

						// Token: 0x02000392 RID: 914
						public class ButtonDone_5
						{
							// Token: 0x17000893 RID: 2195
							// (get) Token: 0x060011B6 RID: 4534 RVA: 0x00034E10 File Offset: 0x00033010
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService/Panel/ButtonDone/Text");
								}
							}

							// Token: 0x17000894 RID: 2196
							// (get) Token: 0x060011B7 RID: 4535 RVA: 0x00034E2C File Offset: 0x0003302C
							public static GameObject Image
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService/Panel/ButtonDone/Image");
								}
							}
						}

						// Token: 0x02000393 RID: 915
						public class ToggleAgree_5
						{
							// Token: 0x17000895 RID: 2197
							// (get) Token: 0x060011B9 RID: 4537 RVA: 0x00034E54 File Offset: 0x00033054
							public static GameObject Background
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService/Panel/ToggleAgree/Background");
								}
							}

							// Token: 0x17000896 RID: 2198
							// (get) Token: 0x060011BA RID: 4538 RVA: 0x00034E70 File Offset: 0x00033070
							public static GameObject Label
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService/Panel/ToggleAgree/Label");
								}
							}
						}

						// Token: 0x02000394 RID: 916
						public class AgreeText_5
						{
							// Token: 0x17000897 RID: 2199
							// (get) Token: 0x060011BC RID: 4540 RVA: 0x00034E98 File Offset: 0x00033098
							public static GameObject Button
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService/Panel/AgreeText/Button");
								}
							}
						}
					}
				}

				// Token: 0x02000195 RID: 405
				public class ViveportStoreLoginPrompt_3
				{
					// Token: 0x170003DD RID: 989
					// (get) Token: 0x06000B03 RID: 2819 RVA: 0x0002B24C File Offset: 0x0002944C
					public static GameObject VRChat_LOGO_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/VRChat_LOGO (1)");
						}
					}

					// Token: 0x170003DE RID: 990
					// (get) Token: 0x06000B04 RID: 2820 RVA: 0x0002B268 File Offset: 0x00029468
					public static GameObject VRChatButtonLogin
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/VRChatButtonLogin");
						}
					}

					// Token: 0x170003DF RID: 991
					// (get) Token: 0x06000B05 RID: 2821 RVA: 0x0002B284 File Offset: 0x00029484
					public static GameObject ButtonCreate
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/ButtonCreate");
						}
					}

					// Token: 0x170003E0 RID: 992
					// (get) Token: 0x06000B06 RID: 2822 RVA: 0x0002B2A0 File Offset: 0x000294A0
					public static GameObject ButtonBypass
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/ButtonBypass");
						}
					}

					// Token: 0x170003E1 RID: 993
					// (get) Token: 0x06000B07 RID: 2823 RVA: 0x0002B2BC File Offset: 0x000294BC
					public static GameObject TextWelcome
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/TextWelcome");
						}
					}

					// Token: 0x170003E2 RID: 994
					// (get) Token: 0x06000B08 RID: 2824 RVA: 0x0002B2D8 File Offset: 0x000294D8
					public static GameObject TextVRChat
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/TextVRChat");
						}
					}

					// Token: 0x170003E3 RID: 995
					// (get) Token: 0x06000B09 RID: 2825 RVA: 0x0002B2F4 File Offset: 0x000294F4
					public static GameObject TextOr
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/TextOr");
						}
					}

					// Token: 0x170003E4 RID: 996
					// (get) Token: 0x06000B0A RID: 2826 RVA: 0x0002B310 File Offset: 0x00029510
					public static GameObject TextLoginWith
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/TextLoginWith");
						}
					}

					// Token: 0x170003E5 RID: 997
					// (get) Token: 0x06000B0B RID: 2827 RVA: 0x0002B32C File Offset: 0x0002952C
					public static GameObject ButtonAboutUs_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/ButtonAboutUs (1)");
						}
					}

					// Token: 0x170003E6 RID: 998
					// (get) Token: 0x06000B0C RID: 2828 RVA: 0x0002B348 File Offset: 0x00029548
					public static GameObject StoreButtonLogin_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/StoreButtonLogin (1)");
						}
					}

					// Token: 0x170003E7 RID: 999
					// (get) Token: 0x06000B0D RID: 2829 RVA: 0x0002B364 File Offset: 0x00029564
					public static GameObject LanguagePanel
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/LanguagePanel");
						}
					}

					// Token: 0x020002A9 RID: 681
					public class VRChatButtonLogin_4
					{
						// Token: 0x1700069F RID: 1695
						// (get) Token: 0x06000ED9 RID: 3801 RVA: 0x00030C74 File Offset: 0x0002EE74
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/VRChatButtonLogin/Text");
							}
						}
					}

					// Token: 0x020002AA RID: 682
					public class ButtonCreate_4
					{
						// Token: 0x170006A0 RID: 1696
						// (get) Token: 0x06000EDB RID: 3803 RVA: 0x00030C9C File Offset: 0x0002EE9C
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/ButtonCreate/Text");
							}
						}
					}

					// Token: 0x020002AB RID: 683
					public class ButtonBypass_4
					{
						// Token: 0x170006A1 RID: 1697
						// (get) Token: 0x06000EDD RID: 3805 RVA: 0x00030CC4 File Offset: 0x0002EEC4
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/ButtonBypass/Text");
							}
						}
					}

					// Token: 0x020002AC RID: 684
					public class ButtonAboutUs_1_4
					{
						// Token: 0x170006A2 RID: 1698
						// (get) Token: 0x06000EDF RID: 3807 RVA: 0x00030CEC File Offset: 0x0002EEEC
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/ButtonAboutUs (1)/Text");
							}
						}

						// Token: 0x170006A3 RID: 1699
						// (get) Token: 0x06000EE0 RID: 3808 RVA: 0x00030D08 File Offset: 0x0002EF08
						public static GameObject Image
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/ButtonAboutUs (1)/Image");
							}
						}

						// Token: 0x02000395 RID: 917
						public class Image_5
						{
							// Token: 0x17000898 RID: 2200
							// (get) Token: 0x060011BE RID: 4542 RVA: 0x00034EC0 File Offset: 0x000330C0
							public static GameObject Text_
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/ButtonAboutUs (1)/Image/Text (3)");
								}
							}

							// Token: 0x17000899 RID: 2201
							// (get) Token: 0x060011BF RID: 4543 RVA: 0x00034EDC File Offset: 0x000330DC
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/ButtonAboutUs (1)/Image/Text");
								}
							}
						}
					}

					// Token: 0x020002AD RID: 685
					public class StoreButtonLogin_1_4
					{
						// Token: 0x170006A4 RID: 1700
						// (get) Token: 0x06000EE2 RID: 3810 RVA: 0x00030D30 File Offset: 0x0002EF30
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/StoreButtonLogin (1)/Text");
							}
						}
					}

					// Token: 0x020002AE RID: 686
					public class LanguagePanel_4
					{
						// Token: 0x170006A5 RID: 1701
						// (get) Token: 0x06000EE4 RID: 3812 RVA: 0x00030D58 File Offset: 0x0002EF58
						public static GameObject TitleText_1
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/LanguagePanel/TitleText (1)");
							}
						}

						// Token: 0x170006A6 RID: 1702
						// (get) Token: 0x06000EE5 RID: 3813 RVA: 0x00030D74 File Offset: 0x0002EF74
						public static GameObject SelectPrevLang
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/LanguagePanel/SelectPrevLang");
							}
						}

						// Token: 0x170006A7 RID: 1703
						// (get) Token: 0x06000EE6 RID: 3814 RVA: 0x00030D90 File Offset: 0x0002EF90
						public static GameObject SelectNextLang
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/LanguagePanel/SelectNextLang");
							}
						}

						// Token: 0x170006A8 RID: 1704
						// (get) Token: 0x06000EE7 RID: 3815 RVA: 0x00030DAC File Offset: 0x0002EFAC
						public static GameObject Language
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/LanguagePanel/Language");
							}
						}
					}
				}

				// Token: 0x02000196 RID: 406
				public class OculusStoreLoginPrompt_3
				{
					// Token: 0x170003E8 RID: 1000
					// (get) Token: 0x06000B0F RID: 2831 RVA: 0x0002B38C File Offset: 0x0002958C
					public static GameObject VRChat_LOGO_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/VRChat_LOGO (1)");
						}
					}

					// Token: 0x170003E9 RID: 1001
					// (get) Token: 0x06000B10 RID: 2832 RVA: 0x0002B3A8 File Offset: 0x000295A8
					public static GameObject VRChatButtonLogin
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/VRChatButtonLogin");
						}
					}

					// Token: 0x170003EA RID: 1002
					// (get) Token: 0x06000B11 RID: 2833 RVA: 0x0002B3C4 File Offset: 0x000295C4
					public static GameObject ButtonCreate
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/ButtonCreate");
						}
					}

					// Token: 0x170003EB RID: 1003
					// (get) Token: 0x06000B12 RID: 2834 RVA: 0x0002B3E0 File Offset: 0x000295E0
					public static GameObject ButtonBypass
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/ButtonBypass");
						}
					}

					// Token: 0x170003EC RID: 1004
					// (get) Token: 0x06000B13 RID: 2835 RVA: 0x0002B3FC File Offset: 0x000295FC
					public static GameObject TextWelcome
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/TextWelcome");
						}
					}

					// Token: 0x170003ED RID: 1005
					// (get) Token: 0x06000B14 RID: 2836 RVA: 0x0002B418 File Offset: 0x00029618
					public static GameObject TextVRChat
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/TextVRChat");
						}
					}

					// Token: 0x170003EE RID: 1006
					// (get) Token: 0x06000B15 RID: 2837 RVA: 0x0002B434 File Offset: 0x00029634
					public static GameObject TextOr_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/TextOr (1)");
						}
					}

					// Token: 0x170003EF RID: 1007
					// (get) Token: 0x06000B16 RID: 2838 RVA: 0x0002B450 File Offset: 0x00029650
					public static GameObject TextLoginWith_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/TextLoginWith (1)");
						}
					}

					// Token: 0x170003F0 RID: 1008
					// (get) Token: 0x06000B17 RID: 2839 RVA: 0x0002B46C File Offset: 0x0002966C
					public static GameObject ButtonAboutUs_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/ButtonAboutUs (1)");
						}
					}

					// Token: 0x170003F1 RID: 1009
					// (get) Token: 0x06000B18 RID: 2840 RVA: 0x0002B488 File Offset: 0x00029688
					public static GameObject StoreButtonLogin_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/StoreButtonLogin (1)");
						}
					}

					// Token: 0x170003F2 RID: 1010
					// (get) Token: 0x06000B19 RID: 2841 RVA: 0x0002B4A4 File Offset: 0x000296A4
					public static GameObject LanguagePanel
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/LanguagePanel");
						}
					}

					// Token: 0x020002AF RID: 687
					public class VRChatButtonLogin_4
					{
						// Token: 0x170006A9 RID: 1705
						// (get) Token: 0x06000EE9 RID: 3817 RVA: 0x00030DD4 File Offset: 0x0002EFD4
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/VRChatButtonLogin/Text");
							}
						}
					}

					// Token: 0x020002B0 RID: 688
					public class ButtonCreate_4
					{
						// Token: 0x170006AA RID: 1706
						// (get) Token: 0x06000EEB RID: 3819 RVA: 0x00030DFC File Offset: 0x0002EFFC
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/ButtonCreate/Text");
							}
						}
					}

					// Token: 0x020002B1 RID: 689
					public class ButtonBypass_4
					{
						// Token: 0x170006AB RID: 1707
						// (get) Token: 0x06000EED RID: 3821 RVA: 0x00030E24 File Offset: 0x0002F024
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/ButtonBypass/Text");
							}
						}
					}

					// Token: 0x020002B2 RID: 690
					public class ButtonAboutUs_1_4
					{
						// Token: 0x170006AC RID: 1708
						// (get) Token: 0x06000EEF RID: 3823 RVA: 0x00030E4C File Offset: 0x0002F04C
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/ButtonAboutUs (1)/Text");
							}
						}

						// Token: 0x170006AD RID: 1709
						// (get) Token: 0x06000EF0 RID: 3824 RVA: 0x00030E68 File Offset: 0x0002F068
						public static GameObject Image
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/ButtonAboutUs (1)/Image");
							}
						}

						// Token: 0x02000396 RID: 918
						public class Image_5
						{
							// Token: 0x1700089A RID: 2202
							// (get) Token: 0x060011C1 RID: 4545 RVA: 0x00034F04 File Offset: 0x00033104
							public static GameObject Text_
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/ButtonAboutUs (1)/Image/Text (3)");
								}
							}

							// Token: 0x1700089B RID: 2203
							// (get) Token: 0x060011C2 RID: 4546 RVA: 0x00034F20 File Offset: 0x00033120
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/ButtonAboutUs (1)/Image/Text");
								}
							}
						}
					}

					// Token: 0x020002B3 RID: 691
					public class StoreButtonLogin_1_4
					{
						// Token: 0x170006AE RID: 1710
						// (get) Token: 0x06000EF2 RID: 3826 RVA: 0x00030E90 File Offset: 0x0002F090
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/StoreButtonLogin (1)/Text");
							}
						}
					}

					// Token: 0x020002B4 RID: 692
					public class LanguagePanel_4
					{
						// Token: 0x170006AF RID: 1711
						// (get) Token: 0x06000EF4 RID: 3828 RVA: 0x00030EB8 File Offset: 0x0002F0B8
						public static GameObject TitleText_1
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/LanguagePanel/TitleText (1)");
							}
						}

						// Token: 0x170006B0 RID: 1712
						// (get) Token: 0x06000EF5 RID: 3829 RVA: 0x00030ED4 File Offset: 0x0002F0D4
						public static GameObject SelectPrevLang
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/LanguagePanel/SelectPrevLang");
							}
						}

						// Token: 0x170006B1 RID: 1713
						// (get) Token: 0x06000EF6 RID: 3830 RVA: 0x00030EF0 File Offset: 0x0002F0F0
						public static GameObject SelectNextLang
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/LanguagePanel/SelectNextLang");
							}
						}

						// Token: 0x170006B2 RID: 1714
						// (get) Token: 0x06000EF7 RID: 3831 RVA: 0x00030F0C File Offset: 0x0002F10C
						public static GameObject Language
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/LanguagePanel/Language");
							}
						}
					}
				}
			}

			// Token: 0x020000F1 RID: 241
			public class Avatar_2
			{
				// Token: 0x170001E7 RID: 487
				// (get) Token: 0x06000860 RID: 2144 RVA: 0x00027398 File Offset: 0x00025598
				public static GameObject TitlePanel_1
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/TitlePanel (1)");
					}
				}

				// Token: 0x170001E8 RID: 488
				// (get) Token: 0x06000861 RID: 2145 RVA: 0x000273B4 File Offset: 0x000255B4
				public static GameObject Vertical_Scroll_View
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View");
					}
				}

				// Token: 0x170001E9 RID: 489
				// (get) Token: 0x06000862 RID: 2146 RVA: 0x000273D0 File Offset: 0x000255D0
				public static GameObject Ticker
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Ticker");
					}
				}

				// Token: 0x170001EA RID: 490
				// (get) Token: 0x06000863 RID: 2147 RVA: 0x000273EC File Offset: 0x000255EC
				public static GameObject AvatarPreviewBase
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarPreviewBase");
					}
				}

				// Token: 0x170001EB RID: 491
				// (get) Token: 0x06000864 RID: 2148 RVA: 0x00027408 File Offset: 0x00025608
				public static GameObject Select_Button
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Select Button");
					}
				}

				// Token: 0x170001EC RID: 492
				// (get) Token: 0x06000865 RID: 2149 RVA: 0x00027424 File Offset: 0x00025624
				public static GameObject XplatHide_Button
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/XplatHide Button");
					}
				}

				// Token: 0x170001ED RID: 493
				// (get) Token: 0x06000866 RID: 2150 RVA: 0x00027440 File Offset: 0x00025640
				public static GameObject Change_Button
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Change Button");
					}
				}

				// Token: 0x170001EE RID: 494
				// (get) Token: 0x06000867 RID: 2151 RVA: 0x0002745C File Offset: 0x0002565C
				public static GameObject Fallback_Info
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Fallback Info");
					}
				}

				// Token: 0x170001EF RID: 495
				// (get) Token: 0x06000868 RID: 2152 RVA: 0x00027478 File Offset: 0x00025678
				public static GameObject Move_Button
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Move Button");
					}
				}

				// Token: 0x170001F0 RID: 496
				// (get) Token: 0x06000869 RID: 2153 RVA: 0x00027494 File Offset: 0x00025694
				public static GameObject Favorite_Button
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Favorite Button");
					}
				}

				// Token: 0x170001F1 RID: 497
				// (get) Token: 0x0600086A RID: 2154 RVA: 0x000274B0 File Offset: 0x000256B0
				public static GameObject Delete_Button
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Delete Button");
					}
				}

				// Token: 0x170001F2 RID: 498
				// (get) Token: 0x0600086B RID: 2155 RVA: 0x000274CC File Offset: 0x000256CC
				public static GameObject AvatarUiPrefab2
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarUiPrefab2");
					}
				}

				// Token: 0x170001F3 RID: 499
				// (get) Token: 0x0600086C RID: 2156 RVA: 0x000274E8 File Offset: 0x000256E8
				public static GameObject DepthOverlay
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/DepthOverlay");
					}
				}

				// Token: 0x170001F4 RID: 500
				// (get) Token: 0x0600086D RID: 2157 RVA: 0x00027504 File Offset: 0x00025704
				public static GameObject Stats_Button
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Stats Button");
					}
				}

				// Token: 0x02000197 RID: 407
				public class TitlePanel_1_3
				{
					// Token: 0x170003F3 RID: 1011
					// (get) Token: 0x06000B1B RID: 2843 RVA: 0x0002B4CC File Offset: 0x000296CC
					public static GameObject TitleText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/TitlePanel (1)/TitleText");
						}
					}
				}

				// Token: 0x02000198 RID: 408
				public class Ticker_3
				{
					// Token: 0x170003F4 RID: 1012
					// (get) Token: 0x06000B1D RID: 2845 RVA: 0x0002B4F4 File Offset: 0x000296F4
					public static GameObject Text
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Ticker/Text");
						}
					}

					// Token: 0x170003F5 RID: 1013
					// (get) Token: 0x06000B1E RID: 2846 RVA: 0x0002B510 File Offset: 0x00029710
					public static GameObject TopLine
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Ticker/TopLine");
						}
					}

					// Token: 0x170003F6 RID: 1014
					// (get) Token: 0x06000B1F RID: 2847 RVA: 0x0002B52C File Offset: 0x0002972C
					public static GameObject TopLine_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Ticker/TopLine (1)");
						}
					}
				}

				// Token: 0x02000199 RID: 409
				public class AvatarPreviewBase_3
				{
					// Token: 0x170003F7 RID: 1015
					// (get) Token: 0x06000B21 RID: 2849 RVA: 0x0002B554 File Offset: 0x00029754
					public static GameObject MainRoot
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarPreviewBase/MainRoot");
						}
					}

					// Token: 0x170003F8 RID: 1016
					// (get) Token: 0x06000B22 RID: 2850 RVA: 0x0002B570 File Offset: 0x00029770
					public static GameObject FallbackRoot
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarPreviewBase/FallbackRoot");
						}
					}

					// Token: 0x170003F9 RID: 1017
					// (get) Token: 0x06000B23 RID: 2851 RVA: 0x0002B58C File Offset: 0x0002978C
					public static GameObject EditPlayerDirLight
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarPreviewBase/EditPlayerDirLight");
						}
					}

					// Token: 0x170003FA RID: 1018
					// (get) Token: 0x06000B24 RID: 2852 RVA: 0x0002B5A8 File Offset: 0x000297A8
					public static GameObject FallbackThumbnail
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarPreviewBase/FallbackThumbnail");
						}
					}

					// Token: 0x020002B5 RID: 693
					public class MainRoot_4
					{
						// Token: 0x170006B3 RID: 1715
						// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x00030F34 File Offset: 0x0002F134
						public static GameObject MainModel
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarPreviewBase/MainRoot/MainModel");
							}
						}
					}

					// Token: 0x020002B6 RID: 694
					public class FallbackRoot_4
					{
						// Token: 0x170006B4 RID: 1716
						// (get) Token: 0x06000EFB RID: 3835 RVA: 0x00030F5C File Offset: 0x0002F15C
						public static GameObject FallbackModel
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarPreviewBase/FallbackRoot/FallbackModel");
							}
						}
					}

					// Token: 0x020002B7 RID: 695
					public class FallbackThumbnail_4
					{
						// Token: 0x170006B5 RID: 1717
						// (get) Token: 0x06000EFD RID: 3837 RVA: 0x00030F84 File Offset: 0x0002F184
						public static GameObject AvatarImage
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarPreviewBase/FallbackThumbnail/AvatarImage");
							}
						}

						// Token: 0x170006B6 RID: 1718
						// (get) Token: 0x06000EFE RID: 3838 RVA: 0x00030FA0 File Offset: 0x0002F1A0
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarPreviewBase/FallbackThumbnail/Text");
							}
						}
					}
				}

				// Token: 0x0200019A RID: 410
				public class Select_Button_3
				{
					// Token: 0x170003FB RID: 1019
					// (get) Token: 0x06000B26 RID: 2854 RVA: 0x0002B5D0 File Offset: 0x000297D0
					public static GameObject Label
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Select Button/Label");
						}
					}

					// Token: 0x170003FC RID: 1020
					// (get) Token: 0x06000B27 RID: 2855 RVA: 0x0002B5EC File Offset: 0x000297EC
					public static GameObject PlatformIcon
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Select Button/PlatformIcon");
						}
					}
				}

				// Token: 0x0200019B RID: 411
				public class XplatHide_Button_3
				{
					// Token: 0x170003FD RID: 1021
					// (get) Token: 0x06000B29 RID: 2857 RVA: 0x0002B614 File Offset: 0x00029814
					public static GameObject Label
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/XplatHide Button/Label");
						}
					}

					// Token: 0x170003FE RID: 1022
					// (get) Token: 0x06000B2A RID: 2858 RVA: 0x0002B630 File Offset: 0x00029830
					public static GameObject PlatformIcon
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/XplatHide Button/PlatformIcon");
						}
					}
				}

				// Token: 0x0200019C RID: 412
				public class Change_Button_3
				{
					// Token: 0x170003FF RID: 1023
					// (get) Token: 0x06000B2C RID: 2860 RVA: 0x0002B658 File Offset: 0x00029858
					public static GameObject Label
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Change Button/Label");
						}
					}

					// Token: 0x17000400 RID: 1024
					// (get) Token: 0x06000B2D RID: 2861 RVA: 0x0002B674 File Offset: 0x00029874
					public static GameObject PlatformAnyIcon
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Change Button/PlatformAnyIcon");
						}
					}
				}

				// Token: 0x0200019D RID: 413
				public class Fallback_Info_3
				{
					// Token: 0x17000401 RID: 1025
					// (get) Token: 0x06000B2F RID: 2863 RVA: 0x0002B69C File Offset: 0x0002989C
					public static GameObject Text
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Fallback Info/Text");
						}
					}
				}

				// Token: 0x0200019E RID: 414
				public class Move_Button_3
				{
					// Token: 0x17000402 RID: 1026
					// (get) Token: 0x06000B31 RID: 2865 RVA: 0x0002B6C4 File Offset: 0x000298C4
					public static GameObject Text
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Move Button/Text");
						}
					}
				}

				// Token: 0x0200019F RID: 415
				public class Favorite_Button_3
				{
					// Token: 0x17000403 RID: 1027
					// (get) Token: 0x06000B33 RID: 2867 RVA: 0x0002B6EC File Offset: 0x000298EC
					public static GameObject Horizontal
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Favorite Button/Horizontal");
						}
					}

					// Token: 0x17000404 RID: 1028
					// (get) Token: 0x06000B34 RID: 2868 RVA: 0x0002B708 File Offset: 0x00029908
					public static GameObject Icon_VRCPlus
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Favorite Button/Icon_VRC+");
						}
					}

					// Token: 0x020002B8 RID: 696
					public class Horizontal_4
					{
						// Token: 0x170006B7 RID: 1719
						// (get) Token: 0x06000F00 RID: 3840 RVA: 0x00030FC8 File Offset: 0x0002F1C8
						public static GameObject FavoriteActionText
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Favorite Button/Horizontal/FavoriteActionText");
							}
						}

						// Token: 0x170006B8 RID: 1720
						// (get) Token: 0x06000F01 RID: 3841 RVA: 0x00030FE4 File Offset: 0x0002F1E4
						public static GameObject FavoritesCountSpacingText
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Favorite Button/Horizontal/FavoritesCountSpacingText");
							}
						}

						// Token: 0x170006B9 RID: 1721
						// (get) Token: 0x06000F02 RID: 3842 RVA: 0x00031000 File Offset: 0x0002F200
						public static GameObject FavoritesCurrentCountText
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Favorite Button/Horizontal/FavoritesCurrentCountText");
							}
						}

						// Token: 0x170006BA RID: 1722
						// (get) Token: 0x06000F03 RID: 3843 RVA: 0x0003101C File Offset: 0x0002F21C
						public static GameObject FavoritesCountDividerText
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Favorite Button/Horizontal/FavoritesCountDividerText");
							}
						}

						// Token: 0x170006BB RID: 1723
						// (get) Token: 0x06000F04 RID: 3844 RVA: 0x00031038 File Offset: 0x0002F238
						public static GameObject FavoritesMaxAvailableText
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Favorite Button/Horizontal/FavoritesMaxAvailableText");
							}
						}
					}
				}

				// Token: 0x020001A0 RID: 416
				public class Delete_Button_3
				{
					// Token: 0x17000405 RID: 1029
					// (get) Token: 0x06000B36 RID: 2870 RVA: 0x0002B730 File Offset: 0x00029930
					public static GameObject DeleteText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Delete Button/DeleteText");
						}
					}
				}

				// Token: 0x020001A1 RID: 417
				public class AvatarUiPrefab2_3
				{
					// Token: 0x17000406 RID: 1030
					// (get) Token: 0x06000B38 RID: 2872 RVA: 0x0002B758 File Offset: 0x00029958
					public static GameObject RoomGlow
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarUiPrefab2/RoomGlow");
						}
					}

					// Token: 0x17000407 RID: 1031
					// (get) Token: 0x06000B39 RID: 2873 RVA: 0x0002B774 File Offset: 0x00029974
					public static GameObject RoomOutline
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarUiPrefab2/RoomOutline");
						}
					}

					// Token: 0x17000408 RID: 1032
					// (get) Token: 0x06000B3A RID: 2874 RVA: 0x0002B790 File Offset: 0x00029990
					public static GameObject RoomImageShape
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarUiPrefab2/RoomImageShape");
						}
					}

					// Token: 0x17000409 RID: 1033
					// (get) Token: 0x06000B3B RID: 2875 RVA: 0x0002B7AC File Offset: 0x000299AC
					public static GameObject TitleText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarUiPrefab2/TitleText");
						}
					}

					// Token: 0x020002B9 RID: 697
					public class RoomImageShape_4
					{
						// Token: 0x170006BC RID: 1724
						// (get) Token: 0x06000F06 RID: 3846 RVA: 0x00031060 File Offset: 0x0002F260
						public static GameObject RoomImage
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarUiPrefab2/RoomImageShape/RoomImage");
							}
						}

						// Token: 0x02000397 RID: 919
						public class RoomImage_5
						{
							// Token: 0x1700089C RID: 2204
							// (get) Token: 0x060011C4 RID: 4548 RVA: 0x00034F48 File Offset: 0x00033148
							public static GameObject Panel
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarUiPrefab2/RoomImageShape/RoomImage/Panel");
								}
							}
						}
					}
				}

				// Token: 0x020001A2 RID: 418
				public class Stats_Button_3
				{
					// Token: 0x1700040A RID: 1034
					// (get) Token: 0x06000B3D RID: 2877 RVA: 0x0002B7D4 File Offset: 0x000299D4
					public static GameObject Text
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Stats Button/Text");
						}
					}

					// Token: 0x1700040B RID: 1035
					// (get) Token: 0x06000B3E RID: 2878 RVA: 0x0002B7F0 File Offset: 0x000299F0
					public static GameObject PerfIcon
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Stats Button/PerfIcon");
						}
					}
				}
			}

			// Token: 0x020000F2 RID: 242
			public class FirstLogin_2
			{
				// Token: 0x170001F5 RID: 501
				// (get) Token: 0x0600086F RID: 2159 RVA: 0x0002752C File Offset: 0x0002572C
				public static GameObject TutorialLaunch
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/FirstLogin/TutorialLaunch");
					}
				}

				// Token: 0x020001A3 RID: 419
				public class TutorialLaunch_3
				{
					// Token: 0x1700040C RID: 1036
					// (get) Token: 0x06000B40 RID: 2880 RVA: 0x0002B818 File Offset: 0x00029A18
					public static GameObject Panel
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/FirstLogin/TutorialLaunch/Panel");
						}
					}

					// Token: 0x1700040D RID: 1037
					// (get) Token: 0x06000B41 RID: 2881 RVA: 0x0002B834 File Offset: 0x00029A34
					public static GameObject ButtonDone
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/FirstLogin/TutorialLaunch/ButtonDone");
						}
					}

					// Token: 0x1700040E RID: 1038
					// (get) Token: 0x06000B42 RID: 2882 RVA: 0x0002B850 File Offset: 0x00029A50
					public static GameObject TitleText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/FirstLogin/TutorialLaunch/TitleText");
						}
					}

					// Token: 0x1700040F RID: 1039
					// (get) Token: 0x06000B43 RID: 2883 RVA: 0x0002B86C File Offset: 0x00029A6C
					public static GameObject BodyTextMouse
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/FirstLogin/TutorialLaunch/BodyTextMouse");
						}
					}

					// Token: 0x020002BA RID: 698
					public class Panel_4
					{
						// Token: 0x170006BD RID: 1725
						// (get) Token: 0x06000F08 RID: 3848 RVA: 0x00031088 File Offset: 0x0002F288
						public static GameObject Rectangle
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/FirstLogin/TutorialLaunch/Panel/Rectangle");
							}
						}

						// Token: 0x170006BE RID: 1726
						// (get) Token: 0x06000F09 RID: 3849 RVA: 0x000310A4 File Offset: 0x0002F2A4
						public static GameObject MidRing
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/FirstLogin/TutorialLaunch/Panel/MidRing");
							}
						}

						// Token: 0x170006BF RID: 1727
						// (get) Token: 0x06000F0A RID: 3850 RVA: 0x000310C0 File Offset: 0x0002F2C0
						public static GameObject InnerDashRing
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/FirstLogin/TutorialLaunch/Panel/InnerDashRing");
							}
						}

						// Token: 0x170006C0 RID: 1728
						// (get) Token: 0x06000F0B RID: 3851 RVA: 0x000310DC File Offset: 0x0002F2DC
						public static GameObject RingGlow
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/FirstLogin/TutorialLaunch/Panel/RingGlow");
							}
						}

						// Token: 0x170006C1 RID: 1729
						// (get) Token: 0x06000F0C RID: 3852 RVA: 0x000310F8 File Offset: 0x0002F2F8
						public static GameObject ArrowLeft
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/FirstLogin/TutorialLaunch/Panel/ArrowLeft");
							}
						}

						// Token: 0x170006C2 RID: 1730
						// (get) Token: 0x06000F0D RID: 3853 RVA: 0x00031114 File Offset: 0x0002F314
						public static GameObject ArrowRight
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/FirstLogin/TutorialLaunch/Panel/ArrowRight");
							}
						}

						// Token: 0x170006C3 RID: 1731
						// (get) Token: 0x06000F0E RID: 3854 RVA: 0x00031130 File Offset: 0x0002F330
						public static GameObject CornerBL
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/FirstLogin/TutorialLaunch/Panel/CornerBL");
							}
						}

						// Token: 0x170006C4 RID: 1732
						// (get) Token: 0x06000F0F RID: 3855 RVA: 0x0003114C File Offset: 0x0002F34C
						public static GameObject CornerTL
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/FirstLogin/TutorialLaunch/Panel/CornerTL");
							}
						}

						// Token: 0x170006C5 RID: 1733
						// (get) Token: 0x06000F10 RID: 3856 RVA: 0x00031168 File Offset: 0x0002F368
						public static GameObject CornerBR
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/FirstLogin/TutorialLaunch/Panel/CornerBR");
							}
						}

						// Token: 0x170006C6 RID: 1734
						// (get) Token: 0x06000F11 RID: 3857 RVA: 0x00031184 File Offset: 0x0002F384
						public static GameObject CornerTR
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/FirstLogin/TutorialLaunch/Panel/CornerTR");
							}
						}
					}

					// Token: 0x020002BB RID: 699
					public class ButtonDone_4
					{
						// Token: 0x170006C7 RID: 1735
						// (get) Token: 0x06000F13 RID: 3859 RVA: 0x000311AC File Offset: 0x0002F3AC
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/FirstLogin/TutorialLaunch/ButtonDone/Text");
							}
						}
					}
				}
			}

			// Token: 0x020000F3 RID: 243
			public class Playlists_2
			{
				// Token: 0x170001F6 RID: 502
				// (get) Token: 0x06000871 RID: 2161 RVA: 0x00027554 File Offset: 0x00025754
				public static GameObject Vertical_Scroll_View
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Playlists/Vertical Scroll View");
					}
				}

				// Token: 0x170001F7 RID: 503
				// (get) Token: 0x06000872 RID: 2162 RVA: 0x00027570 File Offset: 0x00025770
				public static GameObject Header
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Playlists/Header");
					}
				}

				// Token: 0x170001F8 RID: 504
				// (get) Token: 0x06000873 RID: 2163 RVA: 0x0002758C File Offset: 0x0002578C
				public static GameObject DepthOverlay
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Playlists/DepthOverlay");
					}
				}

				// Token: 0x020001A4 RID: 420
				public class Header_3
				{
					// Token: 0x17000410 RID: 1040
					// (get) Token: 0x06000B45 RID: 2885 RVA: 0x0002B894 File Offset: 0x00029A94
					public static GameObject TitlePanel
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Playlists/Header/TitlePanel");
						}
					}

					// Token: 0x17000411 RID: 1041
					// (get) Token: 0x06000B46 RID: 2886 RVA: 0x0002B8B0 File Offset: 0x00029AB0
					public static GameObject TitleText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Playlists/Header/TitleText");
						}
					}

					// Token: 0x17000412 RID: 1042
					// (get) Token: 0x06000B47 RID: 2887 RVA: 0x0002B8CC File Offset: 0x00029ACC
					public static GameObject BackButton
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Playlists/Header/BackButton");
						}
					}

					// Token: 0x17000413 RID: 1043
					// (get) Token: 0x06000B48 RID: 2888 RVA: 0x0002B8E8 File Offset: 0x00029AE8
					public static GameObject TopLine
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Playlists/Header/TopLine");
						}
					}

					// Token: 0x17000414 RID: 1044
					// (get) Token: 0x06000B49 RID: 2889 RVA: 0x0002B904 File Offset: 0x00029B04
					public static GameObject BottomLine
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Playlists/Header/BottomLine");
						}
					}

					// Token: 0x020002BC RID: 700
					public class BackButton_4
					{
						// Token: 0x170006C8 RID: 1736
						// (get) Token: 0x06000F15 RID: 3861 RVA: 0x000311D4 File Offset: 0x0002F3D4
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Playlists/Header/BackButton/Text");
							}
						}
					}
				}
			}

			// Token: 0x020000F4 RID: 244
			public class Settings_Safety_2
			{
				// Token: 0x170001F9 RID: 505
				// (get) Token: 0x06000875 RID: 2165 RVA: 0x000275B4 File Offset: 0x000257B4
				public static GameObject TitlePanel
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/TitlePanel");
					}
				}

				// Token: 0x170001FA RID: 506
				// (get) Token: 0x06000876 RID: 2166 RVA: 0x000275D0 File Offset: 0x000257D0
				public static GameObject _Buttons_SafetyLevel
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_SafetyLevel");
					}
				}

				// Token: 0x170001FB RID: 507
				// (get) Token: 0x06000877 RID: 2167 RVA: 0x000275EC File Offset: 0x000257EC
				public static GameObject _Description_SafetyLevel
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Description_SafetyLevel");
					}
				}

				// Token: 0x170001FC RID: 508
				// (get) Token: 0x06000878 RID: 2168 RVA: 0x00027608 File Offset: 0x00025808
				public static GameObject _SafetyMatrix
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix");
					}
				}

				// Token: 0x170001FD RID: 509
				// (get) Token: 0x06000879 RID: 2169 RVA: 0x00027624 File Offset: 0x00025824
				public static GameObject Button_Reset
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/Button_Reset");
					}
				}

				// Token: 0x170001FE RID: 510
				// (get) Token: 0x0600087A RID: 2170 RVA: 0x00027640 File Offset: 0x00025840
				public static GameObject _Buttons_UserLevel
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel");
					}
				}

				// Token: 0x170001FF RID: 511
				// (get) Token: 0x0600087B RID: 2171 RVA: 0x0002765C File Offset: 0x0002585C
				public static GameObject _UserLevel_Tooltip
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_UserLevel_Tooltip");
					}
				}

				// Token: 0x17000200 RID: 512
				// (get) Token: 0x0600087C RID: 2172 RVA: 0x00027678 File Offset: 0x00025878
				public static GameObject _Notification_CloseMenu
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Notification_CloseMenu");
					}
				}

				// Token: 0x020001A5 RID: 421
				public class TitlePanel_3
				{
					// Token: 0x17000415 RID: 1045
					// (get) Token: 0x06000B4B RID: 2891 RVA: 0x0002B92C File Offset: 0x00029B2C
					public static GameObject Button_PerformanceOptions
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/TitlePanel/Button_PerformanceOptions");
						}
					}

					// Token: 0x17000416 RID: 1046
					// (get) Token: 0x06000B4C RID: 2892 RVA: 0x0002B948 File Offset: 0x00029B48
					public static GameObject TitleText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/TitlePanel/TitleText");
						}
					}

					// Token: 0x020002BD RID: 701
					public class Button_PerformanceOptions_4
					{
						// Token: 0x170006C9 RID: 1737
						// (get) Token: 0x06000F17 RID: 3863 RVA: 0x000311FC File Offset: 0x0002F3FC
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/TitlePanel/Button_PerformanceOptions/Text");
							}
						}
					}
				}

				// Token: 0x020001A6 RID: 422
				public class _Buttons_SafetyLevel_3
				{
					// Token: 0x17000417 RID: 1047
					// (get) Token: 0x06000B4E RID: 2894 RVA: 0x0002B970 File Offset: 0x00029B70
					public static GameObject Button_Maxiumum
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_SafetyLevel/Button_Maxiumum");
						}
					}

					// Token: 0x17000418 RID: 1048
					// (get) Token: 0x06000B4F RID: 2895 RVA: 0x0002B98C File Offset: 0x00029B8C
					public static GameObject Button_Cautious
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_SafetyLevel/Button_Cautious");
						}
					}

					// Token: 0x17000419 RID: 1049
					// (get) Token: 0x06000B50 RID: 2896 RVA: 0x0002B9A8 File Offset: 0x00029BA8
					public static GameObject Button_Normal
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_SafetyLevel/Button_Normal");
						}
					}

					// Token: 0x1700041A RID: 1050
					// (get) Token: 0x06000B51 RID: 2897 RVA: 0x0002B9C4 File Offset: 0x00029BC4
					public static GameObject Button_Limited
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_SafetyLevel/Button_Limited");
						}
					}

					// Token: 0x1700041B RID: 1051
					// (get) Token: 0x06000B52 RID: 2898 RVA: 0x0002B9E0 File Offset: 0x00029BE0
					public static GameObject Button_None
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_SafetyLevel/Button_None");
						}
					}

					// Token: 0x1700041C RID: 1052
					// (get) Token: 0x06000B53 RID: 2899 RVA: 0x0002B9FC File Offset: 0x00029BFC
					public static GameObject Button_Custom
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_SafetyLevel/Button_Custom");
						}
					}

					// Token: 0x020002BE RID: 702
					public class Button_Maxiumum_4
					{
						// Token: 0x170006CA RID: 1738
						// (get) Token: 0x06000F19 RID: 3865 RVA: 0x00031224 File Offset: 0x0002F424
						public static GameObject OFF
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_SafetyLevel/Button_Maxiumum/OFF");
							}
						}

						// Token: 0x170006CB RID: 1739
						// (get) Token: 0x06000F1A RID: 3866 RVA: 0x00031240 File Offset: 0x0002F440
						public static GameObject ON
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_SafetyLevel/Button_Maxiumum/ON");
							}
						}
					}

					// Token: 0x020002BF RID: 703
					public class Button_Cautious_4
					{
						// Token: 0x170006CC RID: 1740
						// (get) Token: 0x06000F1C RID: 3868 RVA: 0x00031268 File Offset: 0x0002F468
						public static GameObject OFF
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_SafetyLevel/Button_Cautious/OFF");
							}
						}

						// Token: 0x170006CD RID: 1741
						// (get) Token: 0x06000F1D RID: 3869 RVA: 0x00031284 File Offset: 0x0002F484
						public static GameObject ON
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_SafetyLevel/Button_Cautious/ON");
							}
						}
					}

					// Token: 0x020002C0 RID: 704
					public class Button_Normal_4
					{
						// Token: 0x170006CE RID: 1742
						// (get) Token: 0x06000F1F RID: 3871 RVA: 0x000312AC File Offset: 0x0002F4AC
						public static GameObject OFF
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_SafetyLevel/Button_Normal/OFF");
							}
						}

						// Token: 0x170006CF RID: 1743
						// (get) Token: 0x06000F20 RID: 3872 RVA: 0x000312C8 File Offset: 0x0002F4C8
						public static GameObject ON
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_SafetyLevel/Button_Normal/ON");
							}
						}
					}

					// Token: 0x020002C1 RID: 705
					public class Button_Limited_4
					{
						// Token: 0x170006D0 RID: 1744
						// (get) Token: 0x06000F22 RID: 3874 RVA: 0x000312F0 File Offset: 0x0002F4F0
						public static GameObject OFF
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_SafetyLevel/Button_Limited/OFF");
							}
						}

						// Token: 0x170006D1 RID: 1745
						// (get) Token: 0x06000F23 RID: 3875 RVA: 0x0003130C File Offset: 0x0002F50C
						public static GameObject ON
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_SafetyLevel/Button_Limited/ON");
							}
						}
					}

					// Token: 0x020002C2 RID: 706
					public class Button_None_4
					{
						// Token: 0x170006D2 RID: 1746
						// (get) Token: 0x06000F25 RID: 3877 RVA: 0x00031334 File Offset: 0x0002F534
						public static GameObject OFF
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_SafetyLevel/Button_None/OFF");
							}
						}

						// Token: 0x170006D3 RID: 1747
						// (get) Token: 0x06000F26 RID: 3878 RVA: 0x00031350 File Offset: 0x0002F550
						public static GameObject ON
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_SafetyLevel/Button_None/ON");
							}
						}
					}

					// Token: 0x020002C3 RID: 707
					public class Button_Custom_4
					{
						// Token: 0x170006D4 RID: 1748
						// (get) Token: 0x06000F28 RID: 3880 RVA: 0x00031378 File Offset: 0x0002F578
						public static GameObject OFF
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_SafetyLevel/Button_Custom/OFF");
							}
						}

						// Token: 0x170006D5 RID: 1749
						// (get) Token: 0x06000F29 RID: 3881 RVA: 0x00031394 File Offset: 0x0002F594
						public static GameObject ON
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_SafetyLevel/Button_Custom/ON");
							}
						}
					}
				}

				// Token: 0x020001A7 RID: 423
				public class _Description_SafetyLevel_3
				{
					// Token: 0x1700041D RID: 1053
					// (get) Token: 0x06000B55 RID: 2901 RVA: 0x0002BA24 File Offset: 0x00029C24
					public static GameObject Text
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Description_SafetyLevel/Text");
						}
					}
				}

				// Token: 0x020001A8 RID: 424
				public class _SafetyMatrix_3
				{
					// Token: 0x1700041E RID: 1054
					// (get) Token: 0x06000B57 RID: 2903 RVA: 0x0002BA4C File Offset: 0x00029C4C
					public static GameObject SocialRankBG
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/SocialRankBG");
						}
					}

					// Token: 0x1700041F RID: 1055
					// (get) Token: 0x06000B58 RID: 2904 RVA: 0x0002BA68 File Offset: 0x00029C68
					public static GameObject _Bracket
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Bracket");
						}
					}

					// Token: 0x17000420 RID: 1056
					// (get) Token: 0x06000B59 RID: 2905 RVA: 0x0002BA84 File Offset: 0x00029C84
					public static GameObject _Toggles
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles");
						}
					}

					// Token: 0x020002C4 RID: 708
					public class _Bracket_4
					{
						// Token: 0x170006D6 RID: 1750
						// (get) Token: 0x06000F2B RID: 3883 RVA: 0x000313BC File Offset: 0x0002F5BC
						public static GameObject SocialRankBorder
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Bracket/SocialRankBorder");
							}
						}
					}

					// Token: 0x020002C5 RID: 709
					public class _Toggles_4
					{
						// Token: 0x170006D7 RID: 1751
						// (get) Token: 0x06000F2D RID: 3885 RVA: 0x000313E4 File Offset: 0x0002F5E4
						public static GameObject Toggle_voice
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_voice");
							}
						}

						// Token: 0x170006D8 RID: 1752
						// (get) Token: 0x06000F2E RID: 3886 RVA: 0x00031400 File Offset: 0x0002F600
						public static GameObject Toggle_Avatar
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Avatar");
							}
						}

						// Token: 0x170006D9 RID: 1753
						// (get) Token: 0x06000F2F RID: 3887 RVA: 0x0003141C File Offset: 0x0002F61C
						public static GameObject Toggle_UserIcons
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_UserIcons");
							}
						}

						// Token: 0x170006DA RID: 1754
						// (get) Token: 0x06000F30 RID: 3888 RVA: 0x00031438 File Offset: 0x0002F638
						public static GameObject Toggle_Audio
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Audio");
							}
						}

						// Token: 0x170006DB RID: 1755
						// (get) Token: 0x06000F31 RID: 3889 RVA: 0x00031454 File Offset: 0x0002F654
						public static GameObject Toggle_Particles
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Particles");
							}
						}

						// Token: 0x170006DC RID: 1756
						// (get) Token: 0x06000F32 RID: 3890 RVA: 0x00031470 File Offset: 0x0002F670
						public static GameObject Toggle_Shaders
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Shaders");
							}
						}

						// Token: 0x170006DD RID: 1757
						// (get) Token: 0x06000F33 RID: 3891 RVA: 0x0003148C File Offset: 0x0002F68C
						public static GameObject Toggle_CustomAnimations
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_CustomAnimations");
							}
						}

						// Token: 0x02000398 RID: 920
						public class Toggle_voice_5
						{
							// Token: 0x1700089D RID: 2205
							// (get) Token: 0x060011C6 RID: 4550 RVA: 0x00034F70 File Offset: 0x00033170
							public static GameObject Panel
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_voice/Panel");
								}
							}

							// Token: 0x1700089E RID: 2206
							// (get) Token: 0x060011C7 RID: 4551 RVA: 0x00034F8C File Offset: 0x0003318C
							public static GameObject Text_Header
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_voice/Text_Header");
								}
							}

							// Token: 0x1700089F RID: 2207
							// (get) Token: 0x060011C8 RID: 4552 RVA: 0x00034FA8 File Offset: 0x000331A8
							public static GameObject Text_onOff
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_voice/Text_onOff");
								}
							}

							// Token: 0x170008A0 RID: 2208
							// (get) Token: 0x060011C9 RID: 4553 RVA: 0x00034FC4 File Offset: 0x000331C4
							public static GameObject RawImage
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_voice/RawImage");
								}
							}

							// Token: 0x170008A1 RID: 2209
							// (get) Token: 0x060011CA RID: 4554 RVA: 0x00034FE0 File Offset: 0x000331E0
							public static GameObject Toggle_Image
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_voice/Toggle_Image");
								}
							}
						}

						// Token: 0x02000399 RID: 921
						public class Toggle_Avatar_5
						{
							// Token: 0x170008A2 RID: 2210
							// (get) Token: 0x060011CC RID: 4556 RVA: 0x00035008 File Offset: 0x00033208
							public static GameObject Panel
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Avatar/Panel");
								}
							}

							// Token: 0x170008A3 RID: 2211
							// (get) Token: 0x060011CD RID: 4557 RVA: 0x00035024 File Offset: 0x00033224
							public static GameObject Text_Header
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Avatar/Text_Header");
								}
							}

							// Token: 0x170008A4 RID: 2212
							// (get) Token: 0x060011CE RID: 4558 RVA: 0x00035040 File Offset: 0x00033240
							public static GameObject Text_onOff
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Avatar/Text_onOff");
								}
							}

							// Token: 0x170008A5 RID: 2213
							// (get) Token: 0x060011CF RID: 4559 RVA: 0x0003505C File Offset: 0x0003325C
							public static GameObject RawImage
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Avatar/RawImage");
								}
							}

							// Token: 0x170008A6 RID: 2214
							// (get) Token: 0x060011D0 RID: 4560 RVA: 0x00035078 File Offset: 0x00033278
							public static GameObject Toggle_Image
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Avatar/Toggle_Image");
								}
							}
						}

						// Token: 0x0200039A RID: 922
						public class Toggle_UserIcons_5
						{
							// Token: 0x170008A7 RID: 2215
							// (get) Token: 0x060011D2 RID: 4562 RVA: 0x000350A0 File Offset: 0x000332A0
							public static GameObject Panel
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_UserIcons/Panel");
								}
							}

							// Token: 0x170008A8 RID: 2216
							// (get) Token: 0x060011D3 RID: 4563 RVA: 0x000350BC File Offset: 0x000332BC
							public static GameObject Text_Header
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_UserIcons/Text_Header");
								}
							}

							// Token: 0x170008A9 RID: 2217
							// (get) Token: 0x060011D4 RID: 4564 RVA: 0x000350D8 File Offset: 0x000332D8
							public static GameObject Text_onOff
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_UserIcons/Text_onOff");
								}
							}

							// Token: 0x170008AA RID: 2218
							// (get) Token: 0x060011D5 RID: 4565 RVA: 0x000350F4 File Offset: 0x000332F4
							public static GameObject RawImage
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_UserIcons/RawImage");
								}
							}

							// Token: 0x170008AB RID: 2219
							// (get) Token: 0x060011D6 RID: 4566 RVA: 0x00035110 File Offset: 0x00033310
							public static GameObject Toggle_Image
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_UserIcons/Toggle_Image");
								}
							}
						}

						// Token: 0x0200039B RID: 923
						public class Toggle_Audio_5
						{
							// Token: 0x170008AC RID: 2220
							// (get) Token: 0x060011D8 RID: 4568 RVA: 0x00035138 File Offset: 0x00033338
							public static GameObject Panel
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Audio/Panel");
								}
							}

							// Token: 0x170008AD RID: 2221
							// (get) Token: 0x060011D9 RID: 4569 RVA: 0x00035154 File Offset: 0x00033354
							public static GameObject Text_Header
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Audio/Text_Header");
								}
							}

							// Token: 0x170008AE RID: 2222
							// (get) Token: 0x060011DA RID: 4570 RVA: 0x00035170 File Offset: 0x00033370
							public static GameObject Text_onOff
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Audio/Text_onOff");
								}
							}

							// Token: 0x170008AF RID: 2223
							// (get) Token: 0x060011DB RID: 4571 RVA: 0x0003518C File Offset: 0x0003338C
							public static GameObject RawImage
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Audio/RawImage");
								}
							}

							// Token: 0x170008B0 RID: 2224
							// (get) Token: 0x060011DC RID: 4572 RVA: 0x000351A8 File Offset: 0x000333A8
							public static GameObject Toggle_Image
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Audio/Toggle_Image");
								}
							}
						}

						// Token: 0x0200039C RID: 924
						public class Toggle_Particles_5
						{
							// Token: 0x170008B1 RID: 2225
							// (get) Token: 0x060011DE RID: 4574 RVA: 0x000351D0 File Offset: 0x000333D0
							public static GameObject Panel
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Particles/Panel");
								}
							}

							// Token: 0x170008B2 RID: 2226
							// (get) Token: 0x060011DF RID: 4575 RVA: 0x000351EC File Offset: 0x000333EC
							public static GameObject Text_Header
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Particles/Text_Header");
								}
							}

							// Token: 0x170008B3 RID: 2227
							// (get) Token: 0x060011E0 RID: 4576 RVA: 0x00035208 File Offset: 0x00033408
							public static GameObject Text_onOff
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Particles/Text_onOff");
								}
							}

							// Token: 0x170008B4 RID: 2228
							// (get) Token: 0x060011E1 RID: 4577 RVA: 0x00035224 File Offset: 0x00033424
							public static GameObject RawImage
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Particles/RawImage");
								}
							}

							// Token: 0x170008B5 RID: 2229
							// (get) Token: 0x060011E2 RID: 4578 RVA: 0x00035240 File Offset: 0x00033440
							public static GameObject Toggle_Image
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Particles/Toggle_Image");
								}
							}
						}

						// Token: 0x0200039D RID: 925
						public class Toggle_Shaders_5
						{
							// Token: 0x170008B6 RID: 2230
							// (get) Token: 0x060011E4 RID: 4580 RVA: 0x00035268 File Offset: 0x00033468
							public static GameObject Panel
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Shaders/Panel");
								}
							}

							// Token: 0x170008B7 RID: 2231
							// (get) Token: 0x060011E5 RID: 4581 RVA: 0x00035284 File Offset: 0x00033484
							public static GameObject Text_Header
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Shaders/Text_Header");
								}
							}

							// Token: 0x170008B8 RID: 2232
							// (get) Token: 0x060011E6 RID: 4582 RVA: 0x000352A0 File Offset: 0x000334A0
							public static GameObject Text_onOff
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Shaders/Text_onOff");
								}
							}

							// Token: 0x170008B9 RID: 2233
							// (get) Token: 0x060011E7 RID: 4583 RVA: 0x000352BC File Offset: 0x000334BC
							public static GameObject RawImage
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Shaders/RawImage");
								}
							}

							// Token: 0x170008BA RID: 2234
							// (get) Token: 0x060011E8 RID: 4584 RVA: 0x000352D8 File Offset: 0x000334D8
							public static GameObject Toggle_Image
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Shaders/Toggle_Image");
								}
							}
						}

						// Token: 0x0200039E RID: 926
						public class Toggle_CustomAnimations_5
						{
							// Token: 0x170008BB RID: 2235
							// (get) Token: 0x060011EA RID: 4586 RVA: 0x00035300 File Offset: 0x00033500
							public static GameObject Panel
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_CustomAnimations/Panel");
								}
							}

							// Token: 0x170008BC RID: 2236
							// (get) Token: 0x060011EB RID: 4587 RVA: 0x0003531C File Offset: 0x0003351C
							public static GameObject Text_Header
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_CustomAnimations/Text_Header");
								}
							}

							// Token: 0x170008BD RID: 2237
							// (get) Token: 0x060011EC RID: 4588 RVA: 0x00035338 File Offset: 0x00033538
							public static GameObject Text_onOff
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_CustomAnimations/Text_onOff");
								}
							}

							// Token: 0x170008BE RID: 2238
							// (get) Token: 0x060011ED RID: 4589 RVA: 0x00035354 File Offset: 0x00033554
							public static GameObject RawImage
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_CustomAnimations/RawImage");
								}
							}

							// Token: 0x170008BF RID: 2239
							// (get) Token: 0x060011EE RID: 4590 RVA: 0x00035370 File Offset: 0x00033570
							public static GameObject Toggle_Image
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_CustomAnimations/Toggle_Image");
								}
							}
						}
					}
				}

				// Token: 0x020001A9 RID: 425
				public class Button_Reset_3
				{
					// Token: 0x17000421 RID: 1057
					// (get) Token: 0x06000B5B RID: 2907 RVA: 0x0002BAAC File Offset: 0x00029CAC
					public static GameObject Text
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/Button_Reset/Text");
						}
					}
				}

				// Token: 0x020001AA RID: 426
				public class _Buttons_UserLevel_3
				{
					// Token: 0x17000422 RID: 1058
					// (get) Token: 0x06000B5D RID: 2909 RVA: 0x0002BAD4 File Offset: 0x00029CD4
					public static GameObject Button_Visitor
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_Visitor");
						}
					}

					// Token: 0x17000423 RID: 1059
					// (get) Token: 0x06000B5E RID: 2910 RVA: 0x0002BAF0 File Offset: 0x00029CF0
					public static GameObject Button_New
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_New");
						}
					}

					// Token: 0x17000424 RID: 1060
					// (get) Token: 0x06000B5F RID: 2911 RVA: 0x0002BB0C File Offset: 0x00029D0C
					public static GameObject Button_User
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_User");
						}
					}

					// Token: 0x17000425 RID: 1061
					// (get) Token: 0x06000B60 RID: 2912 RVA: 0x0002BB28 File Offset: 0x00029D28
					public static GameObject Button_Trusted
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_Trusted");
						}
					}

					// Token: 0x17000426 RID: 1062
					// (get) Token: 0x06000B61 RID: 2913 RVA: 0x0002BB44 File Offset: 0x00029D44
					public static GameObject Button_Advanced
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_Advanced");
						}
					}

					// Token: 0x17000427 RID: 1063
					// (get) Token: 0x06000B62 RID: 2914 RVA: 0x0002BB60 File Offset: 0x00029D60
					public static GameObject Button_Friends
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_Friends");
						}
					}

					// Token: 0x020002C6 RID: 710
					public class Button_Visitor_4
					{
						// Token: 0x170006DE RID: 1758
						// (get) Token: 0x06000F35 RID: 3893 RVA: 0x000314B4 File Offset: 0x0002F6B4
						public static GameObject Connector
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_Visitor/Connector");
							}
						}

						// Token: 0x170006DF RID: 1759
						// (get) Token: 0x06000F36 RID: 3894 RVA: 0x000314D0 File Offset: 0x0002F6D0
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_Visitor/Text");
							}
						}
					}

					// Token: 0x020002C7 RID: 711
					public class Button_New_4
					{
						// Token: 0x170006E0 RID: 1760
						// (get) Token: 0x06000F38 RID: 3896 RVA: 0x000314F8 File Offset: 0x0002F6F8
						public static GameObject Connector
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_New/Connector");
							}
						}

						// Token: 0x170006E1 RID: 1761
						// (get) Token: 0x06000F39 RID: 3897 RVA: 0x00031514 File Offset: 0x0002F714
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_New/Text");
							}
						}
					}

					// Token: 0x020002C8 RID: 712
					public class Button_User_4
					{
						// Token: 0x170006E2 RID: 1762
						// (get) Token: 0x06000F3B RID: 3899 RVA: 0x0003153C File Offset: 0x0002F73C
						public static GameObject Connector
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_User/Connector");
							}
						}

						// Token: 0x170006E3 RID: 1763
						// (get) Token: 0x06000F3C RID: 3900 RVA: 0x00031558 File Offset: 0x0002F758
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_User/Text");
							}
						}
					}

					// Token: 0x020002C9 RID: 713
					public class Button_Trusted_4
					{
						// Token: 0x170006E4 RID: 1764
						// (get) Token: 0x06000F3E RID: 3902 RVA: 0x00031580 File Offset: 0x0002F780
						public static GameObject Connector
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_Trusted/Connector");
							}
						}

						// Token: 0x170006E5 RID: 1765
						// (get) Token: 0x06000F3F RID: 3903 RVA: 0x0003159C File Offset: 0x0002F79C
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_Trusted/Text");
							}
						}
					}

					// Token: 0x020002CA RID: 714
					public class Button_Advanced_4
					{
						// Token: 0x170006E6 RID: 1766
						// (get) Token: 0x06000F41 RID: 3905 RVA: 0x000315C4 File Offset: 0x0002F7C4
						public static GameObject Connector
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_Advanced/Connector");
							}
						}

						// Token: 0x170006E7 RID: 1767
						// (get) Token: 0x06000F42 RID: 3906 RVA: 0x000315E0 File Offset: 0x0002F7E0
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_Advanced/Text");
							}
						}
					}

					// Token: 0x020002CB RID: 715
					public class Button_Friends_4
					{
						// Token: 0x170006E8 RID: 1768
						// (get) Token: 0x06000F44 RID: 3908 RVA: 0x00031608 File Offset: 0x0002F808
						public static GameObject Connector
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_Friends/Connector");
							}
						}

						// Token: 0x170006E9 RID: 1769
						// (get) Token: 0x06000F45 RID: 3909 RVA: 0x00031624 File Offset: 0x0002F824
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_Friends/Text");
							}
						}
					}
				}

				// Token: 0x020001AB RID: 427
				public class _UserLevel_Tooltip_3
				{
					// Token: 0x17000428 RID: 1064
					// (get) Token: 0x06000B64 RID: 2916 RVA: 0x0002BB88 File Offset: 0x00029D88
					public static GameObject Panel
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_UserLevel_Tooltip/Panel");
						}
					}

					// Token: 0x17000429 RID: 1065
					// (get) Token: 0x06000B65 RID: 2917 RVA: 0x0002BBA4 File Offset: 0x00029DA4
					public static GameObject Text
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_UserLevel_Tooltip/Text");
						}
					}
				}

				// Token: 0x020001AC RID: 428
				public class _Notification_CloseMenu_3
				{
					// Token: 0x1700042A RID: 1066
					// (get) Token: 0x06000B67 RID: 2919 RVA: 0x0002BBCC File Offset: 0x00029DCC
					public static GameObject Text
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Notification_CloseMenu/Text");
						}
					}
				}
			}

			// Token: 0x020000F5 RID: 245
			public class Settings_2
			{
				// Token: 0x17000201 RID: 513
				// (get) Token: 0x0600087E RID: 2174 RVA: 0x000276A0 File Offset: 0x000258A0
				public static GameObject TitlePanel
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/TitlePanel");
					}
				}

				// Token: 0x17000202 RID: 514
				// (get) Token: 0x0600087F RID: 2175 RVA: 0x000276BC File Offset: 0x000258BC
				public static GameObject ComfortSafetyPanel
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel");
					}
				}

				// Token: 0x17000203 RID: 515
				// (get) Token: 0x06000880 RID: 2176 RVA: 0x000276D8 File Offset: 0x000258D8
				public static GameObject AudioDevicePanel
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/AudioDevicePanel");
					}
				}

				// Token: 0x17000204 RID: 516
				// (get) Token: 0x06000881 RID: 2177 RVA: 0x000276F4 File Offset: 0x000258F4
				public static GameObject MousePanel
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/MousePanel");
					}
				}

				// Token: 0x17000205 RID: 517
				// (get) Token: 0x06000882 RID: 2178 RVA: 0x00027710 File Offset: 0x00025910
				public static GameObject HeightPanel
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/HeightPanel");
					}
				}

				// Token: 0x17000206 RID: 518
				// (get) Token: 0x06000883 RID: 2179 RVA: 0x0002772C File Offset: 0x0002592C
				public static GameObject VoiceOptionsPanel
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel");
					}
				}

				// Token: 0x17000207 RID: 519
				// (get) Token: 0x06000884 RID: 2180 RVA: 0x00027748 File Offset: 0x00025948
				public static GameObject OtherOptionsPanel
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel");
					}
				}

				// Token: 0x17000208 RID: 520
				// (get) Token: 0x06000885 RID: 2181 RVA: 0x00027764 File Offset: 0x00025964
				public static GameObject VolumePanel
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel");
					}
				}

				// Token: 0x17000209 RID: 521
				// (get) Token: 0x06000886 RID: 2182 RVA: 0x00027780 File Offset: 0x00025980
				public static GameObject Footer
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/Footer");
					}
				}

				// Token: 0x1700020A RID: 522
				// (get) Token: 0x06000887 RID: 2183 RVA: 0x0002779C File Offset: 0x0002599C
				public static GameObject DepthOverlay
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/DepthOverlay");
					}
				}

				// Token: 0x1700020B RID: 523
				// (get) Token: 0x06000888 RID: 2184 RVA: 0x000277B8 File Offset: 0x000259B8
				public static GameObject Button_AdvancedOptions
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/Button_AdvancedOptions");
					}
				}

				// Token: 0x1700020C RID: 524
				// (get) Token: 0x06000889 RID: 2185 RVA: 0x000277D4 File Offset: 0x000259D4
				public static GameObject Button_EditBindings
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/Button_EditBindings");
					}
				}

				// Token: 0x1700020D RID: 525
				// (get) Token: 0x0600088A RID: 2186 RVA: 0x000277F0 File Offset: 0x000259F0
				public static GameObject UserVolumeOptions
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/UserVolumeOptions");
					}
				}

				// Token: 0x020001AD RID: 429
				public class TitlePanel_3
				{
					// Token: 0x1700042B RID: 1067
					// (get) Token: 0x06000B69 RID: 2921 RVA: 0x0002BBF4 File Offset: 0x00029DF4
					public static GameObject TitleText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/TitlePanel/TitleText");
						}
					}

					// Token: 0x1700042C RID: 1068
					// (get) Token: 0x06000B6A RID: 2922 RVA: 0x0002BC10 File Offset: 0x00029E10
					public static GameObject VersionText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/TitlePanel/VersionText");
						}
					}
				}

				// Token: 0x020001AE RID: 430
				public class ComfortSafetyPanel_3
				{
					// Token: 0x1700042D RID: 1069
					// (get) Token: 0x06000B6C RID: 2924 RVA: 0x0002BC38 File Offset: 0x00029E38
					public static GameObject Panel_Header
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/Panel_Header");
						}
					}

					// Token: 0x1700042E RID: 1070
					// (get) Token: 0x06000B6D RID: 2925 RVA: 0x0002BC54 File Offset: 0x00029E54
					public static GameObject TitleText_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/TitleText (1)");
						}
					}

					// Token: 0x1700042F RID: 1071
					// (get) Token: 0x06000B6E RID: 2926 RVA: 0x0002BC70 File Offset: 0x00029E70
					public static GameObject HoloportToggle
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/HoloportToggle");
						}
					}

					// Token: 0x17000430 RID: 1072
					// (get) Token: 0x06000B6F RID: 2927 RVA: 0x0002BC8C File Offset: 0x00029E8C
					public static GameObject ComfortTurnToggle
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/ComfortTurnToggle");
						}
					}

					// Token: 0x17000431 RID: 1073
					// (get) Token: 0x06000B70 RID: 2928 RVA: 0x0002BCA8 File Offset: 0x00029EA8
					public static GameObject PersonalSpaceToggle
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/PersonalSpaceToggle");
						}
					}

					// Token: 0x17000432 RID: 1074
					// (get) Token: 0x06000B71 RID: 2929 RVA: 0x0002BCC4 File Offset: 0x00029EC4
					public static GameObject AllowUntrustedURL
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/AllowUntrustedURL");
						}
					}

					// Token: 0x17000433 RID: 1075
					// (get) Token: 0x06000B72 RID: 2930 RVA: 0x0002BCE0 File Offset: 0x00029EE0
					public static GameObject StreamerModeToggle
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/StreamerModeToggle");
						}
					}

					// Token: 0x17000434 RID: 1076
					// (get) Token: 0x06000B73 RID: 2931 RVA: 0x0002BCFC File Offset: 0x00029EFC
					public static GameObject MuteUsersToggle
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/MuteUsersToggle");
						}
					}

					// Token: 0x17000435 RID: 1077
					// (get) Token: 0x06000B74 RID: 2932 RVA: 0x0002BD18 File Offset: 0x00029F18
					public static GameObject BlockAvatarsToggle
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/BlockAvatarsToggle");
						}
					}

					// Token: 0x17000436 RID: 1078
					// (get) Token: 0x06000B75 RID: 2933 RVA: 0x0002BD34 File Offset: 0x00029F34
					public static GameObject HeadSetGazeToggle
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/HeadSetGazeToggle");
						}
					}

					// Token: 0x17000437 RID: 1079
					// (get) Token: 0x06000B76 RID: 2934 RVA: 0x0002BD50 File Offset: 0x00029F50
					public static GameObject KeyboardToggle
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/KeyboardToggle");
						}
					}

					// Token: 0x17000438 RID: 1080
					// (get) Token: 0x06000B77 RID: 2935 RVA: 0x0002BD6C File Offset: 0x00029F6C
					public static GameObject GamepadToggle
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/GamepadToggle");
						}
					}

					// Token: 0x17000439 RID: 1081
					// (get) Token: 0x06000B78 RID: 2936 RVA: 0x0002BD88 File Offset: 0x00029F88
					public static GameObject PrimaryInputPanel
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/PrimaryInputPanel");
						}
					}

					// Token: 0x1700043A RID: 1082
					// (get) Token: 0x06000B79 RID: 2937 RVA: 0x0002BDA4 File Offset: 0x00029FA4
					public static GameObject LocomotionInputPanel_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/LocomotionInputPanel (1)");
						}
					}

					// Token: 0x020002CC RID: 716
					public class HoloportToggle_4
					{
						// Token: 0x170006EA RID: 1770
						// (get) Token: 0x06000F47 RID: 3911 RVA: 0x0003164C File Offset: 0x0002F84C
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/HoloportToggle/Background");
							}
						}

						// Token: 0x170006EB RID: 1771
						// (get) Token: 0x06000F48 RID: 3912 RVA: 0x00031668 File Offset: 0x0002F868
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/HoloportToggle/Label");
							}
						}

						// Token: 0x0200039F RID: 927
						public class Background_5
						{
							// Token: 0x170008C0 RID: 2240
							// (get) Token: 0x060011F0 RID: 4592 RVA: 0x00035398 File Offset: 0x00033598
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/HoloportToggle/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x020002CD RID: 717
					public class ComfortTurnToggle_4
					{
						// Token: 0x170006EC RID: 1772
						// (get) Token: 0x06000F4A RID: 3914 RVA: 0x00031690 File Offset: 0x0002F890
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/ComfortTurnToggle/Background");
							}
						}

						// Token: 0x170006ED RID: 1773
						// (get) Token: 0x06000F4B RID: 3915 RVA: 0x000316AC File Offset: 0x0002F8AC
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/ComfortTurnToggle/Label");
							}
						}

						// Token: 0x020003A0 RID: 928
						public class Background_5
						{
							// Token: 0x170008C1 RID: 2241
							// (get) Token: 0x060011F2 RID: 4594 RVA: 0x000353C0 File Offset: 0x000335C0
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/ComfortTurnToggle/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x020002CE RID: 718
					public class PersonalSpaceToggle_4
					{
						// Token: 0x170006EE RID: 1774
						// (get) Token: 0x06000F4D RID: 3917 RVA: 0x000316D4 File Offset: 0x0002F8D4
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/PersonalSpaceToggle/Background");
							}
						}

						// Token: 0x170006EF RID: 1775
						// (get) Token: 0x06000F4E RID: 3918 RVA: 0x000316F0 File Offset: 0x0002F8F0
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/PersonalSpaceToggle/Label");
							}
						}

						// Token: 0x020003A1 RID: 929
						public class Background_5
						{
							// Token: 0x170008C2 RID: 2242
							// (get) Token: 0x060011F4 RID: 4596 RVA: 0x000353E8 File Offset: 0x000335E8
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/PersonalSpaceToggle/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x020002CF RID: 719
					public class AllowUntrustedURL_4
					{
						// Token: 0x170006F0 RID: 1776
						// (get) Token: 0x06000F50 RID: 3920 RVA: 0x00031718 File Offset: 0x0002F918
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/AllowUntrustedURL/Background");
							}
						}

						// Token: 0x170006F1 RID: 1777
						// (get) Token: 0x06000F51 RID: 3921 RVA: 0x00031734 File Offset: 0x0002F934
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/AllowUntrustedURL/Label");
							}
						}

						// Token: 0x020003A2 RID: 930
						public class Background_5
						{
							// Token: 0x170008C3 RID: 2243
							// (get) Token: 0x060011F6 RID: 4598 RVA: 0x00035410 File Offset: 0x00033610
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/AllowUntrustedURL/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x020002D0 RID: 720
					public class StreamerModeToggle_4
					{
						// Token: 0x170006F2 RID: 1778
						// (get) Token: 0x06000F53 RID: 3923 RVA: 0x0003175C File Offset: 0x0002F95C
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/StreamerModeToggle/Background");
							}
						}

						// Token: 0x170006F3 RID: 1779
						// (get) Token: 0x06000F54 RID: 3924 RVA: 0x00031778 File Offset: 0x0002F978
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/StreamerModeToggle/Label");
							}
						}

						// Token: 0x170006F4 RID: 1780
						// (get) Token: 0x06000F55 RID: 3925 RVA: 0x00031794 File Offset: 0x0002F994
						public static GameObject InfoButton
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/StreamerModeToggle/InfoButton");
							}
						}

						// Token: 0x020003A3 RID: 931
						public class Background_5
						{
							// Token: 0x170008C4 RID: 2244
							// (get) Token: 0x060011F8 RID: 4600 RVA: 0x00035438 File Offset: 0x00033638
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/StreamerModeToggle/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x020002D1 RID: 721
					public class MuteUsersToggle_4
					{
						// Token: 0x170006F5 RID: 1781
						// (get) Token: 0x06000F57 RID: 3927 RVA: 0x000317BC File Offset: 0x0002F9BC
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/MuteUsersToggle/Background");
							}
						}

						// Token: 0x170006F6 RID: 1782
						// (get) Token: 0x06000F58 RID: 3928 RVA: 0x000317D8 File Offset: 0x0002F9D8
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/MuteUsersToggle/Label");
							}
						}

						// Token: 0x020003A4 RID: 932
						public class Background_5
						{
							// Token: 0x170008C5 RID: 2245
							// (get) Token: 0x060011FA RID: 4602 RVA: 0x00035460 File Offset: 0x00033660
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/MuteUsersToggle/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x020002D2 RID: 722
					public class BlockAvatarsToggle_4
					{
						// Token: 0x170006F7 RID: 1783
						// (get) Token: 0x06000F5A RID: 3930 RVA: 0x00031800 File Offset: 0x0002FA00
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/BlockAvatarsToggle/Background");
							}
						}

						// Token: 0x170006F8 RID: 1784
						// (get) Token: 0x06000F5B RID: 3931 RVA: 0x0003181C File Offset: 0x0002FA1C
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/BlockAvatarsToggle/Label");
							}
						}

						// Token: 0x020003A5 RID: 933
						public class Background_5
						{
							// Token: 0x170008C6 RID: 2246
							// (get) Token: 0x060011FC RID: 4604 RVA: 0x00035488 File Offset: 0x00033688
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/BlockAvatarsToggle/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x020002D3 RID: 723
					public class HeadSetGazeToggle_4
					{
						// Token: 0x170006F9 RID: 1785
						// (get) Token: 0x06000F5D RID: 3933 RVA: 0x00031844 File Offset: 0x0002FA44
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/HeadSetGazeToggle/Background");
							}
						}

						// Token: 0x170006FA RID: 1786
						// (get) Token: 0x06000F5E RID: 3934 RVA: 0x00031860 File Offset: 0x0002FA60
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/HeadSetGazeToggle/Label");
							}
						}

						// Token: 0x020003A6 RID: 934
						public class Background_5
						{
							// Token: 0x170008C7 RID: 2247
							// (get) Token: 0x060011FE RID: 4606 RVA: 0x000354B0 File Offset: 0x000336B0
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/HeadSetGazeToggle/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x020002D4 RID: 724
					public class KeyboardToggle_4
					{
						// Token: 0x170006FB RID: 1787
						// (get) Token: 0x06000F60 RID: 3936 RVA: 0x00031888 File Offset: 0x0002FA88
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/KeyboardToggle/Background");
							}
						}

						// Token: 0x170006FC RID: 1788
						// (get) Token: 0x06000F61 RID: 3937 RVA: 0x000318A4 File Offset: 0x0002FAA4
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/KeyboardToggle/Label");
							}
						}

						// Token: 0x020003A7 RID: 935
						public class Background_5
						{
							// Token: 0x170008C8 RID: 2248
							// (get) Token: 0x06001200 RID: 4608 RVA: 0x000354D8 File Offset: 0x000336D8
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/KeyboardToggle/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x020002D5 RID: 725
					public class GamepadToggle_4
					{
						// Token: 0x170006FD RID: 1789
						// (get) Token: 0x06000F63 RID: 3939 RVA: 0x000318CC File Offset: 0x0002FACC
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/GamepadToggle/Background");
							}
						}

						// Token: 0x170006FE RID: 1790
						// (get) Token: 0x06000F64 RID: 3940 RVA: 0x000318E8 File Offset: 0x0002FAE8
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/GamepadToggle/Label");
							}
						}

						// Token: 0x020003A8 RID: 936
						public class Background_5
						{
							// Token: 0x170008C9 RID: 2249
							// (get) Token: 0x06001202 RID: 4610 RVA: 0x00035500 File Offset: 0x00033700
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/GamepadToggle/Background/Checkmark");
								}
							}
						}
					}
				}

				// Token: 0x020001AF RID: 431
				public class AudioDevicePanel_3
				{
					// Token: 0x1700043B RID: 1083
					// (get) Token: 0x06000B7B RID: 2939 RVA: 0x0002BDCC File Offset: 0x00029FCC
					public static GameObject Panel_Header
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/AudioDevicePanel/Panel_Header");
						}
					}

					// Token: 0x1700043C RID: 1084
					// (get) Token: 0x06000B7C RID: 2940 RVA: 0x0002BDE8 File Offset: 0x00029FE8
					public static GameObject TitleText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/AudioDevicePanel/TitleText");
						}
					}

					// Token: 0x1700043D RID: 1085
					// (get) Token: 0x06000B7D RID: 2941 RVA: 0x0002BE04 File Offset: 0x0002A004
					public static GameObject LevelText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/AudioDevicePanel/LevelText");
						}
					}

					// Token: 0x1700043E RID: 1086
					// (get) Token: 0x06000B7E RID: 2942 RVA: 0x0002BE20 File Offset: 0x0002A020
					public static GameObject VolumeSlider
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/AudioDevicePanel/VolumeSlider");
						}
					}

					// Token: 0x1700043F RID: 1087
					// (get) Token: 0x06000B7F RID: 2943 RVA: 0x0002BE3C File Offset: 0x0002A03C
					public static GameObject VolumeDisplay
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/AudioDevicePanel/VolumeDisplay");
						}
					}

					// Token: 0x17000440 RID: 1088
					// (get) Token: 0x06000B80 RID: 2944 RVA: 0x0002BE58 File Offset: 0x0002A058
					public static GameObject SelectPrevMic
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/AudioDevicePanel/SelectPrevMic");
						}
					}

					// Token: 0x17000441 RID: 1089
					// (get) Token: 0x06000B81 RID: 2945 RVA: 0x0002BE74 File Offset: 0x0002A074
					public static GameObject SelectNextMic
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/AudioDevicePanel/SelectNextMic");
						}
					}

					// Token: 0x17000442 RID: 1090
					// (get) Token: 0x06000B82 RID: 2946 RVA: 0x0002BE90 File Offset: 0x0002A090
					public static GameObject MicDeviceText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/AudioDevicePanel/MicDeviceText");
						}
					}

					// Token: 0x020002D6 RID: 726
					public class VolumeSlider_4
					{
						// Token: 0x170006FF RID: 1791
						// (get) Token: 0x06000F66 RID: 3942 RVA: 0x00031910 File Offset: 0x0002FB10
						public static GameObject Fill_Area
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/AudioDevicePanel/VolumeSlider/Fill Area");
							}
						}

						// Token: 0x020003A9 RID: 937
						public class Fill_Area_5
						{
							// Token: 0x170008CA RID: 2250
							// (get) Token: 0x06001204 RID: 4612 RVA: 0x00035528 File Offset: 0x00033728
							public static GameObject Fill
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/AudioDevicePanel/VolumeSlider/Fill Area/Fill");
								}
							}

							// Token: 0x170008CB RID: 2251
							// (get) Token: 0x06001205 RID: 4613 RVA: 0x00035544 File Offset: 0x00033744
							public static GameObject Label
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/AudioDevicePanel/VolumeSlider/Fill Area/Label");
								}
							}
						}
					}

					// Token: 0x020002D7 RID: 727
					public class VolumeDisplay_4
					{
						// Token: 0x17000700 RID: 1792
						// (get) Token: 0x06000F68 RID: 3944 RVA: 0x00031938 File Offset: 0x0002FB38
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/AudioDevicePanel/VolumeDisplay/Background");
							}
						}

						// Token: 0x17000701 RID: 1793
						// (get) Token: 0x06000F69 RID: 3945 RVA: 0x00031954 File Offset: 0x0002FB54
						public static GameObject Fill_Area
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/AudioDevicePanel/VolumeDisplay/Fill Area");
							}
						}

						// Token: 0x020003AA RID: 938
						public class Fill_Area_5
						{
							// Token: 0x170008CC RID: 2252
							// (get) Token: 0x06001207 RID: 4615 RVA: 0x0003556C File Offset: 0x0003376C
							public static GameObject Fill
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/AudioDevicePanel/VolumeDisplay/Fill Area/Fill");
								}
							}
						}
					}
				}

				// Token: 0x020001B0 RID: 432
				public class MousePanel_3
				{
					// Token: 0x17000443 RID: 1091
					// (get) Token: 0x06000B84 RID: 2948 RVA: 0x0002BEB8 File Offset: 0x0002A0B8
					public static GameObject Panel_Header
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/MousePanel/Panel_Header");
						}
					}

					// Token: 0x17000444 RID: 1092
					// (get) Token: 0x06000B85 RID: 2949 RVA: 0x0002BED4 File Offset: 0x0002A0D4
					public static GameObject TitleText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/MousePanel/TitleText");
						}
					}

					// Token: 0x17000445 RID: 1093
					// (get) Token: 0x06000B86 RID: 2950 RVA: 0x0002BEF0 File Offset: 0x0002A0F0
					public static GameObject MouseSensitivityText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/MousePanel/MouseSensitivityText");
						}
					}

					// Token: 0x17000446 RID: 1094
					// (get) Token: 0x06000B87 RID: 2951 RVA: 0x0002BF0C File Offset: 0x0002A10C
					public static GameObject SensitivitySlider
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/MousePanel/SensitivitySlider");
						}
					}

					// Token: 0x17000447 RID: 1095
					// (get) Token: 0x06000B88 RID: 2952 RVA: 0x0002BF28 File Offset: 0x0002A128
					public static GameObject InvertedMouse
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/MousePanel/InvertedMouse");
						}
					}

					// Token: 0x020002D8 RID: 728
					public class SensitivitySlider_4
					{
						// Token: 0x17000702 RID: 1794
						// (get) Token: 0x06000F6B RID: 3947 RVA: 0x0003197C File Offset: 0x0002FB7C
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/MousePanel/SensitivitySlider/Background");
							}
						}

						// Token: 0x17000703 RID: 1795
						// (get) Token: 0x06000F6C RID: 3948 RVA: 0x00031998 File Offset: 0x0002FB98
						public static GameObject Fill_Area
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/MousePanel/SensitivitySlider/Fill Area");
							}
						}

						// Token: 0x17000704 RID: 1796
						// (get) Token: 0x06000F6D RID: 3949 RVA: 0x000319B4 File Offset: 0x0002FBB4
						public static GameObject Handle_Slide_Area
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/MousePanel/SensitivitySlider/Handle Slide Area");
							}
						}

						// Token: 0x020003AB RID: 939
						public class Fill_Area_5
						{
							// Token: 0x170008CD RID: 2253
							// (get) Token: 0x06001209 RID: 4617 RVA: 0x00035594 File Offset: 0x00033794
							public static GameObject Fill
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/MousePanel/SensitivitySlider/Fill Area/Fill");
								}
							}
						}

						// Token: 0x020003AC RID: 940
						public class Handle_Slide_Area_5
						{
							// Token: 0x170008CE RID: 2254
							// (get) Token: 0x0600120B RID: 4619 RVA: 0x000355BC File Offset: 0x000337BC
							public static GameObject Handle
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/MousePanel/SensitivitySlider/Handle Slide Area/Handle");
								}
							}
						}
					}

					// Token: 0x020002D9 RID: 729
					public class InvertedMouse_4
					{
						// Token: 0x17000705 RID: 1797
						// (get) Token: 0x06000F6F RID: 3951 RVA: 0x000319DC File Offset: 0x0002FBDC
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/MousePanel/InvertedMouse/Background");
							}
						}

						// Token: 0x17000706 RID: 1798
						// (get) Token: 0x06000F70 RID: 3952 RVA: 0x000319F8 File Offset: 0x0002FBF8
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/MousePanel/InvertedMouse/Label");
							}
						}

						// Token: 0x020003AD RID: 941
						public class Background_5
						{
							// Token: 0x170008CF RID: 2255
							// (get) Token: 0x0600120D RID: 4621 RVA: 0x000355E4 File Offset: 0x000337E4
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/MousePanel/InvertedMouse/Background/Checkmark");
								}
							}
						}
					}
				}

				// Token: 0x020001B1 RID: 433
				public class HeightPanel_3
				{
					// Token: 0x17000448 RID: 1096
					// (get) Token: 0x06000B8A RID: 2954 RVA: 0x0002BF50 File Offset: 0x0002A150
					public static GameObject Panel_Header
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/HeightPanel/Panel_Header");
						}
					}

					// Token: 0x17000449 RID: 1097
					// (get) Token: 0x06000B8B RID: 2955 RVA: 0x0002BF6C File Offset: 0x0002A16C
					public static GameObject TitleText_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/HeightPanel/TitleText (1)");
						}
					}

					// Token: 0x1700044A RID: 1098
					// (get) Token: 0x06000B8C RID: 2956 RVA: 0x0002BF88 File Offset: 0x0002A188
					public static GameObject HeightUP
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/HeightPanel/HeightUP");
						}
					}

					// Token: 0x1700044B RID: 1099
					// (get) Token: 0x06000B8D RID: 2957 RVA: 0x0002BFA4 File Offset: 0x0002A1A4
					public static GameObject HeightDOWN
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/HeightPanel/HeightDOWN");
						}
					}

					// Token: 0x1700044C RID: 1100
					// (get) Token: 0x06000B8E RID: 2958 RVA: 0x0002BFC0 File Offset: 0x0002A1C0
					public static GameObject Label
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/HeightPanel/Label");
						}
					}
				}

				// Token: 0x020001B2 RID: 434
				public class VoiceOptionsPanel_3
				{
					// Token: 0x1700044D RID: 1101
					// (get) Token: 0x06000B90 RID: 2960 RVA: 0x0002BFE8 File Offset: 0x0002A1E8
					public static GameObject Panel_Header
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/Panel_Header");
						}
					}

					// Token: 0x1700044E RID: 1102
					// (get) Token: 0x06000B91 RID: 2961 RVA: 0x0002C004 File Offset: 0x0002A204
					public static GameObject TitleText_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/TitleText (1)");
						}
					}

					// Token: 0x1700044F RID: 1103
					// (get) Token: 0x06000B92 RID: 2962 RVA: 0x0002C020 File Offset: 0x0002A220
					public static GameObject HardwareConfigToggle_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/HardwareConfigToggle (1)");
						}
					}

					// Token: 0x17000450 RID: 1104
					// (get) Token: 0x06000B93 RID: 2963 RVA: 0x0002C03C File Offset: 0x0002A23C
					public static GameObject HardwareConfigToggle_4
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/HardwareConfigToggle (4)");
						}
					}

					// Token: 0x17000451 RID: 1105
					// (get) Token: 0x06000B94 RID: 2964 RVA: 0x0002C058 File Offset: 0x0002A258
					public static GameObject HardwareConfigToggle_6
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/HardwareConfigToggle (6)");
						}
					}

					// Token: 0x17000452 RID: 1106
					// (get) Token: 0x06000B95 RID: 2965 RVA: 0x0002C074 File Offset: 0x0002A274
					public static GameObject HardwareConfigToggle_2
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/HardwareConfigToggle (2)");
						}
					}

					// Token: 0x020002DA RID: 730
					public class HardwareConfigToggle_1_4
					{
						// Token: 0x17000707 RID: 1799
						// (get) Token: 0x06000F72 RID: 3954 RVA: 0x00031A20 File Offset: 0x0002FC20
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/HardwareConfigToggle (1)/Background");
							}
						}

						// Token: 0x17000708 RID: 1800
						// (get) Token: 0x06000F73 RID: 3955 RVA: 0x00031A3C File Offset: 0x0002FC3C
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/HardwareConfigToggle (1)/Label");
							}
						}

						// Token: 0x020003AE RID: 942
						public class Background_5
						{
							// Token: 0x170008D0 RID: 2256
							// (get) Token: 0x0600120F RID: 4623 RVA: 0x0003560C File Offset: 0x0003380C
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/HardwareConfigToggle (1)/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x020002DB RID: 731
					public class HardwareConfigToggle_4_4
					{
						// Token: 0x17000709 RID: 1801
						// (get) Token: 0x06000F75 RID: 3957 RVA: 0x00031A64 File Offset: 0x0002FC64
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/HardwareConfigToggle (4)/Background");
							}
						}

						// Token: 0x1700070A RID: 1802
						// (get) Token: 0x06000F76 RID: 3958 RVA: 0x00031A80 File Offset: 0x0002FC80
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/HardwareConfigToggle (4)/Label");
							}
						}

						// Token: 0x020003AF RID: 943
						public class Background_5
						{
							// Token: 0x170008D1 RID: 2257
							// (get) Token: 0x06001211 RID: 4625 RVA: 0x00035634 File Offset: 0x00033834
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/HardwareConfigToggle (4)/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x020002DC RID: 732
					public class HardwareConfigToggle_6_4
					{
						// Token: 0x1700070B RID: 1803
						// (get) Token: 0x06000F78 RID: 3960 RVA: 0x00031AA8 File Offset: 0x0002FCA8
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/HardwareConfigToggle (6)/Background");
							}
						}

						// Token: 0x1700070C RID: 1804
						// (get) Token: 0x06000F79 RID: 3961 RVA: 0x00031AC4 File Offset: 0x0002FCC4
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/HardwareConfigToggle (6)/Label");
							}
						}

						// Token: 0x020003B0 RID: 944
						public class Background_5
						{
							// Token: 0x170008D2 RID: 2258
							// (get) Token: 0x06001213 RID: 4627 RVA: 0x0003565C File Offset: 0x0003385C
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/HardwareConfigToggle (6)/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x020002DD RID: 733
					public class HardwareConfigToggle_2_4
					{
						// Token: 0x1700070D RID: 1805
						// (get) Token: 0x06000F7B RID: 3963 RVA: 0x00031AEC File Offset: 0x0002FCEC
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/HardwareConfigToggle (2)/Background");
							}
						}

						// Token: 0x1700070E RID: 1806
						// (get) Token: 0x06000F7C RID: 3964 RVA: 0x00031B08 File Offset: 0x0002FD08
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/HardwareConfigToggle (2)/Label");
							}
						}

						// Token: 0x020003B1 RID: 945
						public class Background_5
						{
							// Token: 0x170008D3 RID: 2259
							// (get) Token: 0x06001215 RID: 4629 RVA: 0x00035684 File Offset: 0x00033884
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/HardwareConfigToggle (2)/Background/Checkmark");
								}
							}
						}
					}
				}

				// Token: 0x020001B3 RID: 435
				public class OtherOptionsPanel_3
				{
					// Token: 0x17000453 RID: 1107
					// (get) Token: 0x06000B97 RID: 2967 RVA: 0x0002C09C File Offset: 0x0002A29C
					public static GameObject Panel_Header_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/Panel_Header (1)");
						}
					}

					// Token: 0x17000454 RID: 1108
					// (get) Token: 0x06000B98 RID: 2968 RVA: 0x0002C0B8 File Offset: 0x0002A2B8
					public static GameObject TitleText_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/TitleText (1)");
						}
					}

					// Token: 0x17000455 RID: 1109
					// (get) Token: 0x06000B99 RID: 2969 RVA: 0x0002C0D4 File Offset: 0x0002A2D4
					public static GameObject HeadLookToggle
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/HeadLookToggle");
						}
					}

					// Token: 0x17000456 RID: 1110
					// (get) Token: 0x06000B9A RID: 2970 RVA: 0x0002C0F0 File Offset: 0x0002A2F0
					public static GameObject TooltipsToggle
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/TooltipsToggle");
						}
					}

					// Token: 0x17000457 RID: 1111
					// (get) Token: 0x06000B9B RID: 2971 RVA: 0x0002C10C File Offset: 0x0002A30C
					public static GameObject PRotationToggle
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/3PRotationToggle");
						}
					}

					// Token: 0x17000458 RID: 1112
					// (get) Token: 0x06000B9C RID: 2972 RVA: 0x0002C128 File Offset: 0x0002A328
					public static GameObject ViveAdvancedToggle
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/ViveAdvancedToggle");
						}
					}

					// Token: 0x17000459 RID: 1113
					// (get) Token: 0x06000B9D RID: 2973 RVA: 0x0002C144 File Offset: 0x0002A344
					public static GameObject SkipGoButtonInLoad
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/SkipGoButtonInLoad");
						}
					}

					// Token: 0x1700045A RID: 1114
					// (get) Token: 0x06000B9E RID: 2974 RVA: 0x0002C160 File Offset: 0x0002A360
					public static GameObject DesktopReticle
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/DesktopReticle");
						}
					}

					// Token: 0x1700045B RID: 1115
					// (get) Token: 0x06000B9F RID: 2975 RVA: 0x0002C17C File Offset: 0x0002A37C
					public static GameObject AllowAvatarCopyingToggle
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/AllowAvatarCopyingToggle");
						}
					}

					// Token: 0x1700045C RID: 1116
					// (get) Token: 0x06000BA0 RID: 2976 RVA: 0x0002C198 File Offset: 0x0002A398
					public static GameObject ShowCommunityLabsToggle
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/ShowCommunityLabsToggle");
						}
					}

					// Token: 0x020002DE RID: 734
					public class HeadLookToggle_4
					{
						// Token: 0x1700070F RID: 1807
						// (get) Token: 0x06000F7E RID: 3966 RVA: 0x00031B30 File Offset: 0x0002FD30
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/HeadLookToggle/Background");
							}
						}

						// Token: 0x17000710 RID: 1808
						// (get) Token: 0x06000F7F RID: 3967 RVA: 0x00031B4C File Offset: 0x0002FD4C
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/HeadLookToggle/Label");
							}
						}

						// Token: 0x020003B2 RID: 946
						public class Background_5
						{
							// Token: 0x170008D4 RID: 2260
							// (get) Token: 0x06001217 RID: 4631 RVA: 0x000356AC File Offset: 0x000338AC
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/HeadLookToggle/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x020002DF RID: 735
					public class TooltipsToggle_4
					{
						// Token: 0x17000711 RID: 1809
						// (get) Token: 0x06000F81 RID: 3969 RVA: 0x00031B74 File Offset: 0x0002FD74
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/TooltipsToggle/Background");
							}
						}

						// Token: 0x17000712 RID: 1810
						// (get) Token: 0x06000F82 RID: 3970 RVA: 0x00031B90 File Offset: 0x0002FD90
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/TooltipsToggle/Label");
							}
						}

						// Token: 0x020003B3 RID: 947
						public class Background_5
						{
							// Token: 0x170008D5 RID: 2261
							// (get) Token: 0x06001219 RID: 4633 RVA: 0x000356D4 File Offset: 0x000338D4
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/TooltipsToggle/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x020002E0 RID: 736
					public class PRotationToggle_4
					{
						// Token: 0x17000713 RID: 1811
						// (get) Token: 0x06000F84 RID: 3972 RVA: 0x00031BB8 File Offset: 0x0002FDB8
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/3PRotationToggle/Background");
							}
						}

						// Token: 0x17000714 RID: 1812
						// (get) Token: 0x06000F85 RID: 3973 RVA: 0x00031BD4 File Offset: 0x0002FDD4
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/3PRotationToggle/Label");
							}
						}

						// Token: 0x020003B4 RID: 948
						public class Background_5
						{
							// Token: 0x170008D6 RID: 2262
							// (get) Token: 0x0600121B RID: 4635 RVA: 0x000356FC File Offset: 0x000338FC
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/3PRotationToggle/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x020002E1 RID: 737
					public class ViveAdvancedToggle_4
					{
						// Token: 0x17000715 RID: 1813
						// (get) Token: 0x06000F87 RID: 3975 RVA: 0x00031BFC File Offset: 0x0002FDFC
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/ViveAdvancedToggle/Background");
							}
						}

						// Token: 0x17000716 RID: 1814
						// (get) Token: 0x06000F88 RID: 3976 RVA: 0x00031C18 File Offset: 0x0002FE18
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/ViveAdvancedToggle/Label");
							}
						}

						// Token: 0x020003B5 RID: 949
						public class Background_5
						{
							// Token: 0x170008D7 RID: 2263
							// (get) Token: 0x0600121D RID: 4637 RVA: 0x00035724 File Offset: 0x00033924
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/ViveAdvancedToggle/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x020002E2 RID: 738
					public class SkipGoButtonInLoad_4
					{
						// Token: 0x17000717 RID: 1815
						// (get) Token: 0x06000F8A RID: 3978 RVA: 0x00031C40 File Offset: 0x0002FE40
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/SkipGoButtonInLoad/Background");
							}
						}

						// Token: 0x17000718 RID: 1816
						// (get) Token: 0x06000F8B RID: 3979 RVA: 0x00031C5C File Offset: 0x0002FE5C
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/SkipGoButtonInLoad/Label");
							}
						}

						// Token: 0x020003B6 RID: 950
						public class Background_5
						{
							// Token: 0x170008D8 RID: 2264
							// (get) Token: 0x0600121F RID: 4639 RVA: 0x0003574C File Offset: 0x0003394C
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/SkipGoButtonInLoad/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x020002E3 RID: 739
					public class DesktopReticle_4
					{
						// Token: 0x17000719 RID: 1817
						// (get) Token: 0x06000F8D RID: 3981 RVA: 0x00031C84 File Offset: 0x0002FE84
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/DesktopReticle/Background");
							}
						}

						// Token: 0x1700071A RID: 1818
						// (get) Token: 0x06000F8E RID: 3982 RVA: 0x00031CA0 File Offset: 0x0002FEA0
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/DesktopReticle/Label");
							}
						}

						// Token: 0x020003B7 RID: 951
						public class Background_5
						{
							// Token: 0x170008D9 RID: 2265
							// (get) Token: 0x06001221 RID: 4641 RVA: 0x00035774 File Offset: 0x00033974
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/DesktopReticle/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x020002E4 RID: 740
					public class AllowAvatarCopyingToggle_4
					{
						// Token: 0x1700071B RID: 1819
						// (get) Token: 0x06000F90 RID: 3984 RVA: 0x00031CC8 File Offset: 0x0002FEC8
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/AllowAvatarCopyingToggle/Background");
							}
						}

						// Token: 0x1700071C RID: 1820
						// (get) Token: 0x06000F91 RID: 3985 RVA: 0x00031CE4 File Offset: 0x0002FEE4
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/AllowAvatarCopyingToggle/Label");
							}
						}

						// Token: 0x020003B8 RID: 952
						public class Background_5
						{
							// Token: 0x170008DA RID: 2266
							// (get) Token: 0x06001223 RID: 4643 RVA: 0x0003579C File Offset: 0x0003399C
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/AllowAvatarCopyingToggle/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x020002E5 RID: 741
					public class ShowCommunityLabsToggle_4
					{
						// Token: 0x1700071D RID: 1821
						// (get) Token: 0x06000F93 RID: 3987 RVA: 0x00031D0C File Offset: 0x0002FF0C
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/ShowCommunityLabsToggle/Background");
							}
						}

						// Token: 0x1700071E RID: 1822
						// (get) Token: 0x06000F94 RID: 3988 RVA: 0x00031D28 File Offset: 0x0002FF28
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/ShowCommunityLabsToggle/Label");
							}
						}

						// Token: 0x020003B9 RID: 953
						public class Background_5
						{
							// Token: 0x170008DB RID: 2267
							// (get) Token: 0x06001225 RID: 4645 RVA: 0x000357C4 File Offset: 0x000339C4
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/ShowCommunityLabsToggle/Background/Checkmark");
								}
							}
						}
					}
				}

				// Token: 0x020001B4 RID: 436
				public class VolumePanel_3
				{
					// Token: 0x1700045D RID: 1117
					// (get) Token: 0x06000BA2 RID: 2978 RVA: 0x0002C1C0 File Offset: 0x0002A3C0
					public static GameObject Panel_Header_Top
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/Panel_Header Top");
						}
					}

					// Token: 0x1700045E RID: 1118
					// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x0002C1DC File Offset: 0x0002A3DC
					public static GameObject Panel_Header_Side
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/Panel_Header Side");
						}
					}

					// Token: 0x1700045F RID: 1119
					// (get) Token: 0x06000BA4 RID: 2980 RVA: 0x0002C1F8 File Offset: 0x0002A3F8
					public static GameObject TitleText_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/TitleText (1)");
						}
					}

					// Token: 0x17000460 RID: 1120
					// (get) Token: 0x06000BA5 RID: 2981 RVA: 0x0002C214 File Offset: 0x0002A414
					public static GameObject VolumeMaster
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeMaster");
						}
					}

					// Token: 0x17000461 RID: 1121
					// (get) Token: 0x06000BA6 RID: 2982 RVA: 0x0002C230 File Offset: 0x0002A430
					public static GameObject VolumeUi
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeUi");
						}
					}

					// Token: 0x17000462 RID: 1122
					// (get) Token: 0x06000BA7 RID: 2983 RVA: 0x0002C24C File Offset: 0x0002A44C
					public static GameObject VolumeGameWorld
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeGameWorld");
						}
					}

					// Token: 0x17000463 RID: 1123
					// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x0002C268 File Offset: 0x0002A468
					public static GameObject VolumeGameVoice
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeGameVoice");
						}
					}

					// Token: 0x17000464 RID: 1124
					// (get) Token: 0x06000BA9 RID: 2985 RVA: 0x0002C284 File Offset: 0x0002A484
					public static GameObject VolumeGameAvatars
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeGameAvatars");
						}
					}

					// Token: 0x020002E6 RID: 742
					public class VolumeMaster_4
					{
						// Token: 0x1700071F RID: 1823
						// (get) Token: 0x06000F96 RID: 3990 RVA: 0x00031D50 File Offset: 0x0002FF50
						public static GameObject FillArea
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeMaster/FillArea");
							}
						}

						// Token: 0x17000720 RID: 1824
						// (get) Token: 0x06000F97 RID: 3991 RVA: 0x00031D6C File Offset: 0x0002FF6C
						public static GameObject SliderLabel
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeMaster/SliderLabel");
							}
						}

						// Token: 0x17000721 RID: 1825
						// (get) Token: 0x06000F98 RID: 3992 RVA: 0x00031D88 File Offset: 0x0002FF88
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeMaster/Label");
							}
						}

						// Token: 0x020003BA RID: 954
						public class FillArea_5
						{
							// Token: 0x170008DC RID: 2268
							// (get) Token: 0x06001227 RID: 4647 RVA: 0x000357EC File Offset: 0x000339EC
							public static GameObject Fill
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeMaster/FillArea/Fill");
								}
							}
						}
					}

					// Token: 0x020002E7 RID: 743
					public class VolumeUi_4
					{
						// Token: 0x17000722 RID: 1826
						// (get) Token: 0x06000F9A RID: 3994 RVA: 0x00031DB0 File Offset: 0x0002FFB0
						public static GameObject FillArea
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeUi/FillArea");
							}
						}

						// Token: 0x17000723 RID: 1827
						// (get) Token: 0x06000F9B RID: 3995 RVA: 0x00031DCC File Offset: 0x0002FFCC
						public static GameObject SliderLabel
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeUi/SliderLabel");
							}
						}

						// Token: 0x17000724 RID: 1828
						// (get) Token: 0x06000F9C RID: 3996 RVA: 0x00031DE8 File Offset: 0x0002FFE8
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeUi/Label");
							}
						}

						// Token: 0x020003BB RID: 955
						public class FillArea_5
						{
							// Token: 0x170008DD RID: 2269
							// (get) Token: 0x06001229 RID: 4649 RVA: 0x00035814 File Offset: 0x00033A14
							public static GameObject Fill
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeUi/FillArea/Fill");
								}
							}
						}
					}

					// Token: 0x020002E8 RID: 744
					public class VolumeGameWorld_4
					{
						// Token: 0x17000725 RID: 1829
						// (get) Token: 0x06000F9E RID: 3998 RVA: 0x00031E10 File Offset: 0x00030010
						public static GameObject FillArea
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeGameWorld/FillArea");
							}
						}

						// Token: 0x17000726 RID: 1830
						// (get) Token: 0x06000F9F RID: 3999 RVA: 0x00031E2C File Offset: 0x0003002C
						public static GameObject SliderLabel
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeGameWorld/SliderLabel");
							}
						}

						// Token: 0x17000727 RID: 1831
						// (get) Token: 0x06000FA0 RID: 4000 RVA: 0x00031E48 File Offset: 0x00030048
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeGameWorld/Label");
							}
						}

						// Token: 0x020003BC RID: 956
						public class FillArea_5
						{
							// Token: 0x170008DE RID: 2270
							// (get) Token: 0x0600122B RID: 4651 RVA: 0x0003583C File Offset: 0x00033A3C
							public static GameObject Fill
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeGameWorld/FillArea/Fill");
								}
							}
						}
					}

					// Token: 0x020002E9 RID: 745
					public class VolumeGameVoice_4
					{
						// Token: 0x17000728 RID: 1832
						// (get) Token: 0x06000FA2 RID: 4002 RVA: 0x00031E70 File Offset: 0x00030070
						public static GameObject FillArea
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeGameVoice/FillArea");
							}
						}

						// Token: 0x17000729 RID: 1833
						// (get) Token: 0x06000FA3 RID: 4003 RVA: 0x00031E8C File Offset: 0x0003008C
						public static GameObject SliderLabel
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeGameVoice/SliderLabel");
							}
						}

						// Token: 0x1700072A RID: 1834
						// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x00031EA8 File Offset: 0x000300A8
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeGameVoice/Label");
							}
						}

						// Token: 0x020003BD RID: 957
						public class FillArea_5
						{
							// Token: 0x170008DF RID: 2271
							// (get) Token: 0x0600122D RID: 4653 RVA: 0x00035864 File Offset: 0x00033A64
							public static GameObject Fill
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeGameVoice/FillArea/Fill");
								}
							}
						}
					}

					// Token: 0x020002EA RID: 746
					public class VolumeGameAvatars_4
					{
						// Token: 0x1700072B RID: 1835
						// (get) Token: 0x06000FA6 RID: 4006 RVA: 0x00031ED0 File Offset: 0x000300D0
						public static GameObject FillArea
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeGameAvatars/FillArea");
							}
						}

						// Token: 0x1700072C RID: 1836
						// (get) Token: 0x06000FA7 RID: 4007 RVA: 0x00031EEC File Offset: 0x000300EC
						public static GameObject SliderLabel
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeGameAvatars/SliderLabel");
							}
						}

						// Token: 0x1700072D RID: 1837
						// (get) Token: 0x06000FA8 RID: 4008 RVA: 0x00031F08 File Offset: 0x00030108
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeGameAvatars/Label");
							}
						}

						// Token: 0x020003BE RID: 958
						public class FillArea_5
						{
							// Token: 0x170008E0 RID: 2272
							// (get) Token: 0x0600122F RID: 4655 RVA: 0x0003588C File Offset: 0x00033A8C
							public static GameObject Fill
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeGameAvatars/FillArea/Fill");
								}
							}
						}
					}
				}

				// Token: 0x020001B5 RID: 437
				public class Footer_3
				{
					// Token: 0x17000465 RID: 1125
					// (get) Token: 0x06000BAB RID: 2987 RVA: 0x0002C2AC File Offset: 0x0002A4AC
					public static GameObject Logout
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/Footer/Logout");
						}
					}

					// Token: 0x17000466 RID: 1126
					// (get) Token: 0x06000BAC RID: 2988 RVA: 0x0002C2C8 File Offset: 0x0002A4C8
					public static GameObject Exit
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/Footer/Exit");
						}
					}

					// Token: 0x17000467 RID: 1127
					// (get) Token: 0x06000BAD RID: 2989 RVA: 0x0002C2E4 File Offset: 0x0002A4E4
					public static GameObject NameText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/Footer/NameText");
						}
					}

					// Token: 0x17000468 RID: 1128
					// (get) Token: 0x06000BAE RID: 2990 RVA: 0x0002C300 File Offset: 0x0002A500
					public static GameObject UpgradeAccount
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/Footer/UpgradeAccount");
						}
					}

					// Token: 0x020002EB RID: 747
					public class Logout_4
					{
						// Token: 0x1700072E RID: 1838
						// (get) Token: 0x06000FAA RID: 4010 RVA: 0x00031F30 File Offset: 0x00030130
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/Footer/Logout/Text");
							}
						}
					}

					// Token: 0x020002EC RID: 748
					public class Exit_4
					{
						// Token: 0x1700072F RID: 1839
						// (get) Token: 0x06000FAC RID: 4012 RVA: 0x00031F58 File Offset: 0x00030158
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/Footer/Exit/Text");
							}
						}
					}

					// Token: 0x020002ED RID: 749
					public class UpgradeAccount_4
					{
						// Token: 0x17000730 RID: 1840
						// (get) Token: 0x06000FAE RID: 4014 RVA: 0x00031F80 File Offset: 0x00030180
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/Footer/UpgradeAccount/Text");
							}
						}
					}
				}

				// Token: 0x020001B6 RID: 438
				public class Button_AdvancedOptions_3
				{
					// Token: 0x17000469 RID: 1129
					// (get) Token: 0x06000BB0 RID: 2992 RVA: 0x0002C328 File Offset: 0x0002A528
					public static GameObject Text
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/Button_AdvancedOptions/Text");
						}
					}
				}

				// Token: 0x020001B7 RID: 439
				public class Button_EditBindings_3
				{
					// Token: 0x1700046A RID: 1130
					// (get) Token: 0x06000BB2 RID: 2994 RVA: 0x0002C350 File Offset: 0x0002A550
					public static GameObject Image_NEW
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/Button_EditBindings/Image_NEW");
						}
					}

					// Token: 0x1700046B RID: 1131
					// (get) Token: 0x06000BB3 RID: 2995 RVA: 0x0002C36C File Offset: 0x0002A56C
					public static GameObject Text
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/Button_EditBindings/Text");
						}
					}
				}

				// Token: 0x020001B8 RID: 440
				public class UserVolumeOptions_3
				{
					// Token: 0x1700046C RID: 1132
					// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x0002C394 File Offset: 0x0002A594
					public static GameObject Panel_Header_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/UserVolumeOptions/Panel_Header (1)");
						}
					}

					// Token: 0x1700046D RID: 1133
					// (get) Token: 0x06000BB6 RID: 2998 RVA: 0x0002C3B0 File Offset: 0x0002A5B0
					public static GameObject TitleText_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/UserVolumeOptions/TitleText (1)");
						}
					}

					// Token: 0x1700046E RID: 1134
					// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x0002C3CC File Offset: 0x0002A5CC
					public static GameObject Button_ClearChanges
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/UserVolumeOptions/Button_ClearChanges");
						}
					}

					// Token: 0x020002EE RID: 750
					public class Button_ClearChanges_4
					{
						// Token: 0x17000731 RID: 1841
						// (get) Token: 0x06000FB0 RID: 4016 RVA: 0x00031FA8 File Offset: 0x000301A8
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Settings/UserVolumeOptions/Button_ClearChanges/Text");
							}
						}
					}
				}
			}

			// Token: 0x020000F6 RID: 246
			public class Social_2
			{
				// Token: 0x1700020E RID: 526
				// (get) Token: 0x0600088C RID: 2188 RVA: 0x00027818 File Offset: 0x00025A18
				public static GameObject Ticker
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Social/Ticker");
					}
				}

				// Token: 0x1700020F RID: 527
				// (get) Token: 0x0600088D RID: 2189 RVA: 0x00027834 File Offset: 0x00025A34
				public static GameObject Vertical_Scroll_View
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Social/Vertical Scroll View");
					}
				}

				// Token: 0x17000210 RID: 528
				// (get) Token: 0x0600088E RID: 2190 RVA: 0x00027850 File Offset: 0x00025A50
				public static GameObject DepthOverlay
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Social/DepthOverlay");
					}
				}

				// Token: 0x17000211 RID: 529
				// (get) Token: 0x0600088F RID: 2191 RVA: 0x0002786C File Offset: 0x00025A6C
				public static GameObject Current_Status
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Social/Current Status");
					}
				}

				// Token: 0x020001B9 RID: 441
				public class Ticker_3
				{
					// Token: 0x1700046F RID: 1135
					// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x0002C3F4 File Offset: 0x0002A5F4
					public static GameObject Text
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Social/Ticker/Text");
						}
					}

					// Token: 0x17000470 RID: 1136
					// (get) Token: 0x06000BBA RID: 3002 RVA: 0x0002C410 File Offset: 0x0002A610
					public static GameObject TopLine
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Social/Ticker/TopLine");
						}
					}

					// Token: 0x17000471 RID: 1137
					// (get) Token: 0x06000BBB RID: 3003 RVA: 0x0002C42C File Offset: 0x0002A62C
					public static GameObject TopLine_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Social/Ticker/TopLine (1)");
						}
					}
				}

				// Token: 0x020001BA RID: 442
				public class Current_Status_3
				{
					// Token: 0x17000472 RID: 1138
					// (get) Token: 0x06000BBD RID: 3005 RVA: 0x0002C454 File Offset: 0x0002A654
					public static GameObject TitlePanel
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Social/Current Status/TitlePanel");
						}
					}

					// Token: 0x17000473 RID: 1139
					// (get) Token: 0x06000BBE RID: 3006 RVA: 0x0002C470 File Offset: 0x0002A670
					public static GameObject TopLine
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Social/Current Status/TopLine");
						}
					}

					// Token: 0x17000474 RID: 1140
					// (get) Token: 0x06000BBF RID: 3007 RVA: 0x0002C48C File Offset: 0x0002A68C
					public static GameObject StatusButton
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Social/Current Status/StatusButton");
						}
					}

					// Token: 0x17000475 RID: 1141
					// (get) Token: 0x06000BC0 RID: 3008 RVA: 0x0002C4A8 File Offset: 0x0002A6A8
					public static GameObject StatusIcon
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Social/Current Status/StatusIcon");
						}
					}

					// Token: 0x17000476 RID: 1142
					// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x0002C4C4 File Offset: 0x0002A6C4
					public static GameObject StatusText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Social/Current Status/StatusText");
						}
					}

					// Token: 0x17000477 RID: 1143
					// (get) Token: 0x06000BC2 RID: 3010 RVA: 0x0002C4E0 File Offset: 0x0002A6E0
					public static GameObject BottomLine
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Social/Current Status/BottomLine");
						}
					}

					// Token: 0x020002EF RID: 751
					public class StatusButton_4
					{
						// Token: 0x17000732 RID: 1842
						// (get) Token: 0x06000FB2 RID: 4018 RVA: 0x00031FD0 File Offset: 0x000301D0
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Social/Current Status/StatusButton/Text");
							}
						}

						// Token: 0x17000733 RID: 1843
						// (get) Token: 0x06000FB3 RID: 4019 RVA: 0x00031FEC File Offset: 0x000301EC
						public static GameObject Image
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Social/Current Status/StatusButton/Image");
							}
						}
					}
				}
			}

			// Token: 0x020000F7 RID: 247
			public class Title_2
			{
				// Token: 0x17000212 RID: 530
				// (get) Token: 0x06000891 RID: 2193 RVA: 0x00027894 File Offset: 0x00025A94
				public static GameObject Panel
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Title/Panel");
					}
				}

				// Token: 0x17000213 RID: 531
				// (get) Token: 0x06000892 RID: 2194 RVA: 0x000278B0 File Offset: 0x00025AB0
				public static GameObject LogoContainer
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Title/LogoContainer");
					}
				}

				// Token: 0x020001BB RID: 443
				public class Panel_3
				{
					// Token: 0x17000478 RID: 1144
					// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x0002C508 File Offset: 0x0002A708
					public static GameObject Text
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Title/Panel/Text");
						}
					}

					// Token: 0x17000479 RID: 1145
					// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x0002C524 File Offset: 0x0002A724
					public static GameObject TitleImage
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Title/Panel/TitleImage");
						}
					}
				}

				// Token: 0x020001BC RID: 444
				public class LogoContainer_3
				{
					// Token: 0x1700047A RID: 1146
					// (get) Token: 0x06000BC7 RID: 3015 RVA: 0x0002C54C File Offset: 0x0002A74C
					public static GameObject vrchatlogo2sided
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Title/LogoContainer/vrchatlogo2sided");
						}
					}
				}
			}

			// Token: 0x020000F8 RID: 248
			public class UpdateRequired_2
			{
				// Token: 0x17000214 RID: 532
				// (get) Token: 0x06000894 RID: 2196 RVA: 0x000278D8 File Offset: 0x00025AD8
				public static GameObject Panel
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/UpdateRequired/Panel");
					}
				}

				// Token: 0x020001BD RID: 445
				public class Panel_3
				{
					// Token: 0x1700047B RID: 1147
					// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x0002C574 File Offset: 0x0002A774
					public static GameObject Text
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/UpdateRequired/Panel/Text");
						}
					}

					// Token: 0x1700047C RID: 1148
					// (get) Token: 0x06000BCA RID: 3018 RVA: 0x0002C590 File Offset: 0x0002A790
					public static GameObject TitleImage
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/UpdateRequired/Panel/TitleImage");
						}
					}

					// Token: 0x1700047D RID: 1149
					// (get) Token: 0x06000BCB RID: 3019 RVA: 0x0002C5AC File Offset: 0x0002A7AC
					public static GameObject ButtonUpdate
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/UpdateRequired/Panel/ButtonUpdate");
						}
					}

					// Token: 0x020002F0 RID: 752
					public class ButtonUpdate_4
					{
						// Token: 0x17000734 RID: 1844
						// (get) Token: 0x06000FB5 RID: 4021 RVA: 0x00032014 File Offset: 0x00030214
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UpdateRequired/Panel/ButtonUpdate/Text");
							}
						}
					}
				}
			}

			// Token: 0x020000F9 RID: 249
			public class TitleXR_2
			{
				// Token: 0x17000215 RID: 533
				// (get) Token: 0x06000896 RID: 2198 RVA: 0x00027900 File Offset: 0x00025B00
				public static GameObject Panel
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/TitleXR/Panel");
					}
				}

				// Token: 0x020001BE RID: 446
				public class Panel_3
				{
					// Token: 0x1700047E RID: 1150
					// (get) Token: 0x06000BCD RID: 3021 RVA: 0x0002C5D4 File Offset: 0x0002A7D4
					public static GameObject TitleImage
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/TitleXR/Panel/TitleImage");
						}
					}
				}
			}

			// Token: 0x020000FA RID: 250
			public class Gallery_2
			{
				// Token: 0x17000216 RID: 534
				// (get) Token: 0x06000898 RID: 2200 RVA: 0x00027928 File Offset: 0x00025B28
				public static GameObject TitlePanel
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Gallery/TitlePanel");
					}
				}

				// Token: 0x17000217 RID: 535
				// (get) Token: 0x06000899 RID: 2201 RVA: 0x00027944 File Offset: 0x00025B44
				public static GameObject DepthOverlay
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Gallery/DepthOverlay");
					}
				}

				// Token: 0x17000218 RID: 536
				// (get) Token: 0x0600089A RID: 2202 RVA: 0x00027960 File Offset: 0x00025B60
				public static GameObject Vertical_Scroll_View
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Gallery/Vertical Scroll View");
					}
				}

				// Token: 0x020001BF RID: 447
				public class TitlePanel_3
				{
					// Token: 0x1700047F RID: 1151
					// (get) Token: 0x06000BCF RID: 3023 RVA: 0x0002C5FC File Offset: 0x0002A7FC
					public static GameObject TitleText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Gallery/TitlePanel/TitleText");
						}
					}

					// Token: 0x17000480 RID: 1152
					// (get) Token: 0x06000BD0 RID: 3024 RVA: 0x0002C618 File Offset: 0x0002A818
					public static GameObject UploadUserIcon
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Gallery/TitlePanel/UploadUserIcon");
						}
					}

					// Token: 0x020002F1 RID: 753
					public class UploadUserIcon_4
					{
						// Token: 0x17000735 RID: 1845
						// (get) Token: 0x06000FB7 RID: 4023 RVA: 0x0003203C File Offset: 0x0003023C
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Gallery/TitlePanel/UploadUserIcon/Text");
							}
						}
					}
				}
			}

			// Token: 0x020000FB RID: 251
			public class ImageDetails_2
			{
				// Token: 0x17000219 RID: 537
				// (get) Token: 0x0600089C RID: 2204 RVA: 0x00027988 File Offset: 0x00025B88
				public static GameObject TitlePanel
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/TitlePanel");
					}
				}

				// Token: 0x1700021A RID: 538
				// (get) Token: 0x0600089D RID: 2205 RVA: 0x000279A4 File Offset: 0x00025BA4
				public static GameObject LargeImage
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/LargeImage");
					}
				}

				// Token: 0x1700021B RID: 539
				// (get) Token: 0x0600089E RID: 2206 RVA: 0x000279C0 File Offset: 0x00025BC0
				public static GameObject ImageOptions
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/ImageOptions");
					}
				}

				// Token: 0x1700021C RID: 540
				// (get) Token: 0x0600089F RID: 2207 RVA: 0x000279DC File Offset: 0x00025BDC
				public static GameObject ImagesScrollView
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/ImagesScrollView");
					}
				}

				// Token: 0x1700021D RID: 541
				// (get) Token: 0x060008A0 RID: 2208 RVA: 0x000279F8 File Offset: 0x00025BF8
				public static GameObject BackButton
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/BackButton");
					}
				}

				// Token: 0x1700021E RID: 542
				// (get) Token: 0x060008A1 RID: 2209 RVA: 0x00027A14 File Offset: 0x00025C14
				public static GameObject DepthOverlay
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/DepthOverlay");
					}
				}

				// Token: 0x020001C0 RID: 448
				public class TitlePanel_3
				{
					// Token: 0x17000481 RID: 1153
					// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x0002C640 File Offset: 0x0002A840
					public static GameObject TitleText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/TitlePanel/TitleText");
						}
					}
				}

				// Token: 0x020001C1 RID: 449
				public class LargeImage_3
				{
					// Token: 0x17000482 RID: 1154
					// (get) Token: 0x06000BD4 RID: 3028 RVA: 0x0002C668 File Offset: 0x0002A868
					public static GameObject Image
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/LargeImage/Image");
						}
					}

					// Token: 0x17000483 RID: 1155
					// (get) Token: 0x06000BD5 RID: 3029 RVA: 0x0002C684 File Offset: 0x0002A884
					public static GameObject ImageBorder
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/LargeImage/ImageBorder");
						}
					}
				}

				// Token: 0x020001C2 RID: 450
				public class ImageOptions_3
				{
					// Token: 0x17000484 RID: 1156
					// (get) Token: 0x06000BD7 RID: 3031 RVA: 0x0002C6AC File Offset: 0x0002A8AC
					public static GameObject SetAsProfilePic
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/ImageOptions/SetAsProfilePic");
						}
					}

					// Token: 0x17000485 RID: 1157
					// (get) Token: 0x06000BD8 RID: 3032 RVA: 0x0002C6C8 File Offset: 0x0002A8C8
					public static GameObject CreateUserIcon
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/ImageOptions/CreateUserIcon");
						}
					}

					// Token: 0x17000486 RID: 1158
					// (get) Token: 0x06000BD9 RID: 3033 RVA: 0x0002C6E4 File Offset: 0x0002A8E4
					public static GameObject Delete
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/ImageOptions/Delete");
						}
					}

					// Token: 0x17000487 RID: 1159
					// (get) Token: 0x06000BDA RID: 3034 RVA: 0x0002C700 File Offset: 0x0002A900
					public static GameObject Save
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/ImageOptions/Save");
						}
					}

					// Token: 0x020002F2 RID: 754
					public class SetAsProfilePic_4
					{
						// Token: 0x17000736 RID: 1846
						// (get) Token: 0x06000FB9 RID: 4025 RVA: 0x00032064 File Offset: 0x00030264
						public static GameObject SetAsProfilePicButton
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/ImageOptions/SetAsProfilePic/SetAsProfilePicButton");
							}
						}

						// Token: 0x020003BF RID: 959
						public class SetAsProfilePicButton_5
						{
							// Token: 0x170008E1 RID: 2273
							// (get) Token: 0x06001231 RID: 4657 RVA: 0x000358B4 File Offset: 0x00033AB4
							public static GameObject Image
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/ImageOptions/SetAsProfilePic/SetAsProfilePicButton/Image");
								}
							}
						}
					}

					// Token: 0x020002F3 RID: 755
					public class CreateUserIcon_4
					{
						// Token: 0x17000737 RID: 1847
						// (get) Token: 0x06000FBB RID: 4027 RVA: 0x0003208C File Offset: 0x0003028C
						public static GameObject CreateUserIconButton
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/ImageOptions/CreateUserIcon/CreateUserIconButton");
							}
						}

						// Token: 0x020003C0 RID: 960
						public class CreateUserIconButton_5
						{
							// Token: 0x170008E2 RID: 2274
							// (get) Token: 0x06001233 RID: 4659 RVA: 0x000358DC File Offset: 0x00033ADC
							public static GameObject Image
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/ImageOptions/CreateUserIcon/CreateUserIconButton/Image");
								}
							}
						}
					}

					// Token: 0x020002F4 RID: 756
					public class Delete_4
					{
						// Token: 0x17000738 RID: 1848
						// (get) Token: 0x06000FBD RID: 4029 RVA: 0x000320B4 File Offset: 0x000302B4
						public static GameObject DeleteButton
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/ImageOptions/Delete/DeleteButton");
							}
						}

						// Token: 0x020003C1 RID: 961
						public class DeleteButton_5
						{
							// Token: 0x170008E3 RID: 2275
							// (get) Token: 0x06001235 RID: 4661 RVA: 0x00035904 File Offset: 0x00033B04
							public static GameObject Image
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/ImageOptions/Delete/DeleteButton/Image");
								}
							}
						}
					}

					// Token: 0x020002F5 RID: 757
					public class Save_4
					{
						// Token: 0x17000739 RID: 1849
						// (get) Token: 0x06000FBF RID: 4031 RVA: 0x000320DC File Offset: 0x000302DC
						public static GameObject SaveButton
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/ImageOptions/Save/SaveButton");
							}
						}

						// Token: 0x020003C2 RID: 962
						public class SaveButton_5
						{
							// Token: 0x170008E4 RID: 2276
							// (get) Token: 0x06001237 RID: 4663 RVA: 0x0003592C File Offset: 0x00033B2C
							public static GameObject Image
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/ImageOptions/Save/SaveButton/Image");
								}
							}
						}
					}
				}

				// Token: 0x020001C3 RID: 451
				public class BackButton_3
				{
					// Token: 0x17000488 RID: 1160
					// (get) Token: 0x06000BDC RID: 3036 RVA: 0x0002C728 File Offset: 0x0002A928
					public static GameObject Text
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/BackButton/Text");
						}
					}
				}
			}

			// Token: 0x020000FC RID: 252
			public class UserInfo_2
			{
				// Token: 0x1700021F RID: 543
				// (get) Token: 0x060008A3 RID: 2211 RVA: 0x00027A3C File Offset: 0x00025C3C
				public static GameObject Worlds
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Worlds");
					}
				}

				// Token: 0x17000220 RID: 544
				// (get) Token: 0x060008A4 RID: 2212 RVA: 0x00027A58 File Offset: 0x00025C58
				public static GameObject BackButton
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/BackButton");
					}
				}

				// Token: 0x17000221 RID: 545
				// (get) Token: 0x060008A5 RID: 2213 RVA: 0x00027A74 File Offset: 0x00025C74
				public static GameObject AvatarImage
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/AvatarImage");
					}
				}

				// Token: 0x17000222 RID: 546
				// (get) Token: 0x060008A6 RID: 2214 RVA: 0x00027A90 File Offset: 0x00025C90
				public static GameObject SelfButtons
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/SelfButtons");
					}
				}

				// Token: 0x17000223 RID: 547
				// (get) Token: 0x060008A7 RID: 2215 RVA: 0x00027AAC File Offset: 0x00025CAC
				public static GameObject OnlineFriendButtons
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/OnlineFriendButtons");
					}
				}

				// Token: 0x17000224 RID: 548
				// (get) Token: 0x060008A8 RID: 2216 RVA: 0x00027AC8 File Offset: 0x00025CC8
				public static GameObject ViewUserOnVRChatWebsiteButton
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ViewUserOnVRChatWebsiteButton");
					}
				}

				// Token: 0x17000225 RID: 549
				// (get) Token: 0x060008A9 RID: 2217 RVA: 0x00027AE4 File Offset: 0x00025CE4
				public static GameObject User_Panel
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel");
					}
				}

				// Token: 0x17000226 RID: 550
				// (get) Token: 0x060008AA RID: 2218 RVA: 0x00027B00 File Offset: 0x00025D00
				public static GameObject Buttons
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Buttons");
					}
				}

				// Token: 0x17000227 RID: 551
				// (get) Token: 0x060008AB RID: 2219 RVA: 0x00027B1C File Offset: 0x00025D1C
				public static GameObject DepthOverlay
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/DepthOverlay");
					}
				}

				// Token: 0x17000228 RID: 552
				// (get) Token: 0x060008AC RID: 2220 RVA: 0x00027B38 File Offset: 0x00025D38
				public static GameObject ReceivedFriendRequest
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ReceivedFriendRequest");
					}
				}

				// Token: 0x17000229 RID: 553
				// (get) Token: 0x060008AD RID: 2221 RVA: 0x00027B54 File Offset: 0x00025D54
				public static GameObject SentFriendRequest
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/SentFriendRequest");
					}
				}

				// Token: 0x1700022A RID: 554
				// (get) Token: 0x060008AE RID: 2222 RVA: 0x00027B70 File Offset: 0x00025D70
				public static GameObject ModerateDialog
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ModerateDialog");
					}
				}

				// Token: 0x020001C4 RID: 452
				public class Worlds_3
				{
					// Token: 0x17000489 RID: 1161
					// (get) Token: 0x06000BDE RID: 3038 RVA: 0x0002C750 File Offset: 0x0002A950
					public static GameObject WorldScrollView
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Worlds/WorldScrollView");
						}
					}

					// Token: 0x1700048A RID: 1162
					// (get) Token: 0x06000BDF RID: 3039 RVA: 0x0002C76C File Offset: 0x0002A96C
					public static GameObject CurrentWorld
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Worlds/CurrentWorld");
						}
					}

					// Token: 0x020002F6 RID: 758
					public class CurrentWorld_4
					{
						// Token: 0x1700073A RID: 1850
						// (get) Token: 0x06000FC1 RID: 4033 RVA: 0x00032104 File Offset: 0x00030304
						public static GameObject CurrentWorldPanel
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Worlds/CurrentWorld/CurrentWorldPanel");
							}
						}

						// Token: 0x1700073B RID: 1851
						// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x00032120 File Offset: 0x00030320
						public static GameObject TitleText
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Worlds/CurrentWorld/TitleText");
							}
						}

						// Token: 0x1700073C RID: 1852
						// (get) Token: 0x06000FC3 RID: 4035 RVA: 0x0003213C File Offset: 0x0003033C
						public static GameObject WorldUiPrefab
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Worlds/CurrentWorld/WorldUiPrefab");
							}
						}

						// Token: 0x020003C3 RID: 963
						public class WorldUiPrefab_5
						{
							// Token: 0x170008E5 RID: 2277
							// (get) Token: 0x06001239 RID: 4665 RVA: 0x00035954 File Offset: 0x00033B54
							public static GameObject RoomOutline
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Worlds/CurrentWorld/WorldUiPrefab/RoomOutline");
								}
							}

							// Token: 0x170008E6 RID: 2278
							// (get) Token: 0x0600123A RID: 4666 RVA: 0x00035970 File Offset: 0x00033B70
							public static GameObject RoomImageShape
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Worlds/CurrentWorld/WorldUiPrefab/RoomImageShape");
								}
							}
						}
					}
				}

				// Token: 0x020001C5 RID: 453
				public class BackButton_3
				{
					// Token: 0x1700048B RID: 1163
					// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x0002C794 File Offset: 0x0002A994
					public static GameObject Text
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/BackButton/Text");
						}
					}
				}

				// Token: 0x020001C6 RID: 454
				public class AvatarImage_3
				{
					// Token: 0x1700048C RID: 1164
					// (get) Token: 0x06000BE3 RID: 3043 RVA: 0x0002C7BC File Offset: 0x0002A9BC
					public static GameObject AvatarImageMask
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/AvatarImage/AvatarImageMask");
						}
					}

					// Token: 0x1700048D RID: 1165
					// (get) Token: 0x06000BE4 RID: 3044 RVA: 0x0002C7D8 File Offset: 0x0002A9D8
					public static GameObject HideUserAvatar
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/AvatarImage/HideUserAvatar");
						}
					}

					// Token: 0x1700048E RID: 1166
					// (get) Token: 0x06000BE5 RID: 3045 RVA: 0x0002C7F4 File Offset: 0x0002A9F4
					public static GameObject AvatarBorder
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/AvatarImage/AvatarBorder");
						}
					}

					// Token: 0x1700048F RID: 1167
					// (get) Token: 0x06000BE6 RID: 3046 RVA: 0x0002C810 File Offset: 0x0002AA10
					public static GameObject Icon
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/AvatarImage/Icon");
						}
					}

					// Token: 0x17000490 RID: 1168
					// (get) Token: 0x06000BE7 RID: 3047 RVA: 0x0002C82C File Offset: 0x0002AA2C
					public static GameObject SupporterIcon
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/AvatarImage/SupporterIcon");
						}
					}

					// Token: 0x17000491 RID: 1169
					// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x0002C848 File Offset: 0x0002AA48
					public static GameObject OverlayIcons
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/AvatarImage/OverlayIcons");
						}
					}

					// Token: 0x020002F7 RID: 759
					public class AvatarImageMask_4
					{
						// Token: 0x1700073D RID: 1853
						// (get) Token: 0x06000FC5 RID: 4037 RVA: 0x00032164 File Offset: 0x00030364
						public static GameObject AvatarImage
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/AvatarImage/AvatarImageMask/AvatarImage");
							}
						}
					}

					// Token: 0x020002F8 RID: 760
					public class HideUserAvatar_4
					{
						// Token: 0x1700073E RID: 1854
						// (get) Token: 0x06000FC7 RID: 4039 RVA: 0x0003218C File Offset: 0x0003038C
						public static GameObject PhotoHiddenText
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/AvatarImage/HideUserAvatar/PhotoHiddenText");
							}
						}
					}

					// Token: 0x020002F9 RID: 761
					public class OverlayIcons_4
					{
						// Token: 0x1700073F RID: 1855
						// (get) Token: 0x06000FC9 RID: 4041 RVA: 0x000321B4 File Offset: 0x000303B4
						public static GameObject FavoriteIcon
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/AvatarImage/OverlayIcons/FavoriteIcon");
							}
						}

						// Token: 0x17000740 RID: 1856
						// (get) Token: 0x06000FCA RID: 4042 RVA: 0x000321D0 File Offset: 0x000303D0
						public static GameObject PlatformPCIcon
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/AvatarImage/OverlayIcons/PlatformPCIcon");
							}
						}

						// Token: 0x17000741 RID: 1857
						// (get) Token: 0x06000FCB RID: 4043 RVA: 0x000321EC File Offset: 0x000303EC
						public static GameObject PlatformMobileIcon
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/AvatarImage/OverlayIcons/PlatformMobileIcon");
							}
						}

						// Token: 0x17000742 RID: 1858
						// (get) Token: 0x06000FCC RID: 4044 RVA: 0x00032208 File Offset: 0x00030408
						public static GameObject MobileIcons
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/AvatarImage/OverlayIcons/MobileIcons");
							}
						}

						// Token: 0x020003C4 RID: 964
						public class MobileIcons_5
						{
							// Token: 0x170008E7 RID: 2279
							// (get) Token: 0x0600123C RID: 4668 RVA: 0x00035998 File Offset: 0x00033B98
							public static GameObject MobilePlatformPCIcon
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/AvatarImage/OverlayIcons/MobileIcons/MobilePlatformPCIcon");
								}
							}

							// Token: 0x170008E8 RID: 2280
							// (get) Token: 0x0600123D RID: 4669 RVA: 0x000359B4 File Offset: 0x00033BB4
							public static GameObject MobilePlatformMobileIcon
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/AvatarImage/OverlayIcons/MobileIcons/MobilePlatformMobileIcon");
								}
							}
						}
					}
				}

				// Token: 0x020001C7 RID: 455
				public class SelfButtons_3
				{
					// Token: 0x17000492 RID: 1170
					// (get) Token: 0x06000BEA RID: 3050 RVA: 0x0002C870 File Offset: 0x0002AA70
					public static GameObject ChangeProfilePicButton
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/SelfButtons/ChangeProfilePicButton");
						}
					}

					// Token: 0x17000493 RID: 1171
					// (get) Token: 0x06000BEB RID: 3051 RVA: 0x0002C88C File Offset: 0x0002AA8C
					public static GameObject UseAvatarAsProfilePicButton
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/SelfButtons/UseAvatarAsProfilePicButton");
						}
					}

					// Token: 0x020002FA RID: 762
					public class ChangeProfilePicButton_4
					{
						// Token: 0x17000743 RID: 1859
						// (get) Token: 0x06000FCE RID: 4046 RVA: 0x00032230 File Offset: 0x00030430
						public static GameObject Image
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/SelfButtons/ChangeProfilePicButton/Image");
							}
						}

						// Token: 0x17000744 RID: 1860
						// (get) Token: 0x06000FCF RID: 4047 RVA: 0x0003224C File Offset: 0x0003044C
						public static GameObject VRCPlus
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/SelfButtons/ChangeProfilePicButton/VRC+");
							}
						}

						// Token: 0x020003C5 RID: 965
						public class Image_5
						{
							// Token: 0x170008E9 RID: 2281
							// (get) Token: 0x0600123F RID: 4671 RVA: 0x000359DC File Offset: 0x00033BDC
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/SelfButtons/ChangeProfilePicButton/Image/Text");
								}
							}
						}
					}

					// Token: 0x020002FB RID: 763
					public class UseAvatarAsProfilePicButton_4
					{
						// Token: 0x17000745 RID: 1861
						// (get) Token: 0x06000FD1 RID: 4049 RVA: 0x00032274 File Offset: 0x00030474
						public static GameObject Image
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/SelfButtons/UseAvatarAsProfilePicButton/Image");
							}
						}

						// Token: 0x020003C6 RID: 966
						public class Image_5
						{
							// Token: 0x170008EA RID: 2282
							// (get) Token: 0x06001241 RID: 4673 RVA: 0x00035A04 File Offset: 0x00033C04
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/SelfButtons/UseAvatarAsProfilePicButton/Image/Text");
								}
							}
						}
					}
				}

				// Token: 0x020001C8 RID: 456
				public class OnlineFriendButtons_3
				{
					// Token: 0x17000494 RID: 1172
					// (get) Token: 0x06000BED RID: 3053 RVA: 0x0002C8B4 File Offset: 0x0002AAB4
					public static GameObject JoinButton
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/OnlineFriendButtons/JoinButton");
						}
					}

					// Token: 0x17000495 RID: 1173
					// (get) Token: 0x06000BEE RID: 3054 RVA: 0x0002C8D0 File Offset: 0x0002AAD0
					public static GameObject Invite
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/OnlineFriendButtons/Invite");
						}
					}

					// Token: 0x17000496 RID: 1174
					// (get) Token: 0x06000BEF RID: 3055 RVA: 0x0002C8EC File Offset: 0x0002AAEC
					public static GameObject Actions
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/OnlineFriendButtons/Actions");
						}
					}

					// Token: 0x020002FC RID: 764
					public class JoinButton_4
					{
						// Token: 0x17000746 RID: 1862
						// (get) Token: 0x06000FD3 RID: 4051 RVA: 0x0003229C File Offset: 0x0003049C
						public static GameObject Image
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/OnlineFriendButtons/JoinButton/Image");
							}
						}

						// Token: 0x020003C7 RID: 967
						public class Image_5
						{
							// Token: 0x170008EB RID: 2283
							// (get) Token: 0x06001243 RID: 4675 RVA: 0x00035A2C File Offset: 0x00033C2C
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/OnlineFriendButtons/JoinButton/Image/Text");
								}
							}
						}
					}

					// Token: 0x020002FD RID: 765
					public class Invite_4
					{
						// Token: 0x17000747 RID: 1863
						// (get) Token: 0x06000FD5 RID: 4053 RVA: 0x000322C4 File Offset: 0x000304C4
						public static GameObject Image
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/OnlineFriendButtons/Invite/Image");
							}
						}

						// Token: 0x020003C8 RID: 968
						public class Image_5
						{
							// Token: 0x170008EC RID: 2284
							// (get) Token: 0x06001245 RID: 4677 RVA: 0x00035A54 File Offset: 0x00033C54
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/OnlineFriendButtons/Invite/Image/Text");
								}
							}
						}
					}
				}

				// Token: 0x020001C9 RID: 457
				public class User_Panel_3
				{
					// Token: 0x17000497 RID: 1175
					// (get) Token: 0x06000BF1 RID: 3057 RVA: 0x0002C914 File Offset: 0x0002AB14
					public static GameObject Panel
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/Panel");
						}
					}

					// Token: 0x17000498 RID: 1176
					// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x0002C930 File Offset: 0x0002AB30
					public static GameObject PanelHeaderBackground
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/PanelHeaderBackground");
						}
					}

					// Token: 0x17000499 RID: 1177
					// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x0002C94C File Offset: 0x0002AB4C
					public static GameObject NameText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/NameText");
						}
					}

					// Token: 0x1700049A RID: 1178
					// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x0002C968 File Offset: 0x0002AB68
					public static GameObject UserIcon
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/UserIcon");
						}
					}

					// Token: 0x1700049B RID: 1179
					// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x0002C984 File Offset: 0x0002AB84
					public static GameObject UserStatus
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/UserStatus");
						}
					}

					// Token: 0x1700049C RID: 1180
					// (get) Token: 0x06000BF6 RID: 3062 RVA: 0x0002C9A0 File Offset: 0x0002ABA0
					public static GameObject TrustLevel
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/TrustLevel");
						}
					}

					// Token: 0x1700049D RID: 1181
					// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x0002C9BC File Offset: 0x0002ABBC
					public static GameObject VRCIcons
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/VRCIcons");
						}
					}

					// Token: 0x1700049E RID: 1182
					// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x0002C9D8 File Offset: 0x0002ABD8
					public static GameObject UserBio
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/UserBio");
						}
					}

					// Token: 0x1700049F RID: 1183
					// (get) Token: 0x06000BF9 RID: 3065 RVA: 0x0002C9F4 File Offset: 0x0002ABF4
					public static GameObject InviteNotification
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/InviteNotification");
						}
					}

					// Token: 0x020002FE RID: 766
					public class UserIcon_4
					{
						// Token: 0x17000748 RID: 1864
						// (get) Token: 0x06000FD7 RID: 4055 RVA: 0x000322EC File Offset: 0x000304EC
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/UserIcon/Background");
							}
						}

						// Token: 0x17000749 RID: 1865
						// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x00032308 File Offset: 0x00030508
						public static GameObject User_Image
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/UserIcon/User Image");
							}
						}

						// Token: 0x1700074A RID: 1866
						// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x00032324 File Offset: 0x00030524
						public static GameObject Initials
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/UserIcon/Initials");
							}
						}
					}

					// Token: 0x020002FF RID: 767
					public class UserStatus_4
					{
						// Token: 0x1700074B RID: 1867
						// (get) Token: 0x06000FDB RID: 4059 RVA: 0x0003234C File Offset: 0x0003054C
						public static GameObject StatusIcon
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/UserStatus/StatusIcon");
							}
						}

						// Token: 0x1700074C RID: 1868
						// (get) Token: 0x06000FDC RID: 4060 RVA: 0x00032368 File Offset: 0x00030568
						public static GameObject StatusText
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/UserStatus/StatusText");
							}
						}
					}

					// Token: 0x02000300 RID: 768
					public class TrustLevel_4
					{
						// Token: 0x1700074D RID: 1869
						// (get) Token: 0x06000FDE RID: 4062 RVA: 0x00032390 File Offset: 0x00030590
						public static GameObject TrustIcon
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/TrustLevel/TrustIcon");
							}
						}

						// Token: 0x1700074E RID: 1870
						// (get) Token: 0x06000FDF RID: 4063 RVA: 0x000323AC File Offset: 0x000305AC
						public static GameObject TrustText
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/TrustLevel/TrustText");
							}
						}
					}

					// Token: 0x02000301 RID: 769
					public class VRCIcons_4
					{
						// Token: 0x1700074F RID: 1871
						// (get) Token: 0x06000FE1 RID: 4065 RVA: 0x000323D4 File Offset: 0x000305D4
						public static GameObject VRCPlusEarlyAdopterIcon
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/VRCIcons/VRCPlusEarlyAdopterIcon");
							}
						}

						// Token: 0x17000750 RID: 1872
						// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x000323F0 File Offset: 0x000305F0
						public static GameObject VRCPlusSubscriberIcon
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/VRCIcons/VRCPlusSubscriberIcon");
							}
						}
					}

					// Token: 0x02000302 RID: 770
					public class UserBio_4
					{
						// Token: 0x17000751 RID: 1873
						// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x00032418 File Offset: 0x00030618
						public static GameObject Bio_Scroll_View
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/UserBio/Bio Scroll View");
							}
						}
					}

					// Token: 0x02000303 RID: 771
					public class InviteNotification_4
					{
						// Token: 0x17000752 RID: 1874
						// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x00032440 File Offset: 0x00030640
						public static GameObject Panel_Backdrop
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/InviteNotification/Panel_Backdrop");
							}
						}

						// Token: 0x17000753 RID: 1875
						// (get) Token: 0x06000FE7 RID: 4071 RVA: 0x0003245C File Offset: 0x0003065C
						public static GameObject Actions
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/InviteNotification/Actions");
							}
						}

						// Token: 0x17000754 RID: 1876
						// (get) Token: 0x06000FE8 RID: 4072 RVA: 0x00032478 File Offset: 0x00030678
						public static GameObject Image
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/InviteNotification/Image");
							}
						}

						// Token: 0x17000755 RID: 1877
						// (get) Token: 0x06000FE9 RID: 4073 RVA: 0x00032494 File Offset: 0x00030694
						public static GameObject MessageText
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/InviteNotification/MessageText");
							}
						}

						// Token: 0x020003C9 RID: 969
						public class Actions_5
						{
							// Token: 0x170008ED RID: 2285
							// (get) Token: 0x06001247 RID: 4679 RVA: 0x00035A7C File Offset: 0x00033C7C
							public static GameObject Accept
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/InviteNotification/Actions/Accept");
								}
							}

							// Token: 0x170008EE RID: 2286
							// (get) Token: 0x06001248 RID: 4680 RVA: 0x00035A98 File Offset: 0x00033C98
							public static GameObject Decline
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/InviteNotification/Actions/Decline");
								}
							}

							// Token: 0x170008EF RID: 2287
							// (get) Token: 0x06001249 RID: 4681 RVA: 0x00035AB4 File Offset: 0x00033CB4
							public static GameObject Block
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/InviteNotification/Actions/Block");
								}
							}
						}

						// Token: 0x020003CA RID: 970
						public class Image_5
						{
							// Token: 0x170008F0 RID: 2288
							// (get) Token: 0x0600124B RID: 4683 RVA: 0x00035ADC File Offset: 0x00033CDC
							public static GameObject WorldImage
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/InviteNotification/Image/WorldImage");
								}
							}

							// Token: 0x170008F1 RID: 2289
							// (get) Token: 0x0600124C RID: 4684 RVA: 0x00035AF8 File Offset: 0x00033CF8
							public static GameObject WorldBorder
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/InviteNotification/Image/WorldBorder");
								}
							}
						}
					}
				}

				// Token: 0x020001CA RID: 458
				public class Buttons_3
				{
					// Token: 0x170004A0 RID: 1184
					// (get) Token: 0x06000BFB RID: 3067 RVA: 0x0002CA1C File Offset: 0x0002AC1C
					public static GameObject RightSideButtons
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Buttons/RightSideButtons");
						}
					}

					// Token: 0x02000304 RID: 772
					public class RightSideButtons_4
					{
						// Token: 0x17000756 RID: 1878
						// (get) Token: 0x06000FEB RID: 4075 RVA: 0x000324BC File Offset: 0x000306BC
						public static GameObject RightUpperButtonColumn
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Buttons/RightSideButtons/RightUpperButtonColumn");
							}
						}

						// Token: 0x17000757 RID: 1879
						// (get) Token: 0x06000FEC RID: 4076 RVA: 0x000324D8 File Offset: 0x000306D8
						public static GameObject RightLowerButtonColumn
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Buttons/RightSideButtons/RightLowerButtonColumn");
							}
						}

						// Token: 0x020003CB RID: 971
						public class RightUpperButtonColumn_5
						{
							// Token: 0x170008F2 RID: 2290
							// (get) Token: 0x0600124E RID: 4686 RVA: 0x00035B20 File Offset: 0x00033D20
							public static GameObject Supporter
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Buttons/RightSideButtons/RightUpperButtonColumn/Supporter");
								}
							}

							// Token: 0x170008F3 RID: 2291
							// (get) Token: 0x0600124F RID: 4687 RVA: 0x00035B3C File Offset: 0x00033D3C
							public static GameObject PlaylistsButton
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Buttons/RightSideButtons/RightUpperButtonColumn/PlaylistsButton");
								}
							}

							// Token: 0x170008F4 RID: 2292
							// (get) Token: 0x06001250 RID: 4688 RVA: 0x00035B58 File Offset: 0x00033D58
							public static GameObject FavoriteButton
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Buttons/RightSideButtons/RightUpperButtonColumn/FavoriteButton");
								}
							}

							// Token: 0x170008F5 RID: 2293
							// (get) Token: 0x06001251 RID: 4689 RVA: 0x00035B74 File Offset: 0x00033D74
							public static GameObject EditBioButton
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Buttons/RightSideButtons/RightUpperButtonColumn/EditBioButton");
								}
							}

							// Token: 0x170008F6 RID: 2294
							// (get) Token: 0x06001252 RID: 4690 RVA: 0x00035B90 File Offset: 0x00033D90
							public static GameObject EditStatusButton
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Buttons/RightSideButtons/RightUpperButtonColumn/EditStatusButton");
								}
							}
						}

						// Token: 0x020003CC RID: 972
						public class RightLowerButtonColumn_5
						{
							// Token: 0x170008F7 RID: 2295
							// (get) Token: 0x06001254 RID: 4692 RVA: 0x00035BB8 File Offset: 0x00033DB8
							public static GameObject UnfriendButton
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Buttons/RightSideButtons/RightLowerButtonColumn/UnfriendButton");
								}
							}

							// Token: 0x170008F8 RID: 2296
							// (get) Token: 0x06001255 RID: 4693 RVA: 0x00035BD4 File Offset: 0x00033DD4
							public static GameObject FriendButton
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Buttons/RightSideButtons/RightLowerButtonColumn/FriendButton");
								}
							}

							// Token: 0x170008F9 RID: 2297
							// (get) Token: 0x06001256 RID: 4694 RVA: 0x00035BF0 File Offset: 0x00033DF0
							public static GameObject ReportButton
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Buttons/RightSideButtons/RightLowerButtonColumn/ReportButton");
								}
							}

							// Token: 0x170008FA RID: 2298
							// (get) Token: 0x06001257 RID: 4695 RVA: 0x00035C0C File Offset: 0x00033E0C
							public static GameObject ModerateButton
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Buttons/RightSideButtons/RightLowerButtonColumn/ModerateButton");
								}
							}
						}
					}
				}

				// Token: 0x020001CB RID: 459
				public class ReceivedFriendRequest_3
				{
					// Token: 0x170004A1 RID: 1185
					// (get) Token: 0x06000BFD RID: 3069 RVA: 0x0002CA44 File Offset: 0x0002AC44
					public static GameObject Panel
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ReceivedFriendRequest/Panel");
						}
					}

					// Token: 0x170004A2 RID: 1186
					// (get) Token: 0x06000BFE RID: 3070 RVA: 0x0002CA60 File Offset: 0x0002AC60
					public static GameObject Actions
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ReceivedFriendRequest/Actions");
						}
					}

					// Token: 0x170004A3 RID: 1187
					// (get) Token: 0x06000BFF RID: 3071 RVA: 0x0002CA7C File Offset: 0x0002AC7C
					public static GameObject Image
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ReceivedFriendRequest/Image");
						}
					}

					// Token: 0x170004A4 RID: 1188
					// (get) Token: 0x06000C00 RID: 3072 RVA: 0x0002CA98 File Offset: 0x0002AC98
					public static GameObject MessageText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ReceivedFriendRequest/MessageText");
						}
					}

					// Token: 0x02000305 RID: 773
					public class Actions_4
					{
						// Token: 0x17000758 RID: 1880
						// (get) Token: 0x06000FEE RID: 4078 RVA: 0x00032500 File Offset: 0x00030700
						public static GameObject Accept
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ReceivedFriendRequest/Actions/Accept");
							}
						}

						// Token: 0x17000759 RID: 1881
						// (get) Token: 0x06000FEF RID: 4079 RVA: 0x0003251C File Offset: 0x0003071C
						public static GameObject Decline
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ReceivedFriendRequest/Actions/Decline");
							}
						}

						// Token: 0x1700075A RID: 1882
						// (get) Token: 0x06000FF0 RID: 4080 RVA: 0x00032538 File Offset: 0x00030738
						public static GameObject Block
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ReceivedFriendRequest/Actions/Block");
							}
						}

						// Token: 0x020003CD RID: 973
						public class Accept_5
						{
							// Token: 0x170008FB RID: 2299
							// (get) Token: 0x06001259 RID: 4697 RVA: 0x00035C34 File Offset: 0x00033E34
							public static GameObject Image
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ReceivedFriendRequest/Actions/Accept/Image");
								}
							}
						}

						// Token: 0x020003CE RID: 974
						public class Decline_5
						{
							// Token: 0x170008FC RID: 2300
							// (get) Token: 0x0600125B RID: 4699 RVA: 0x00035C5C File Offset: 0x00033E5C
							public static GameObject Image
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ReceivedFriendRequest/Actions/Decline/Image");
								}
							}
						}

						// Token: 0x020003CF RID: 975
						public class Block_5
						{
							// Token: 0x170008FD RID: 2301
							// (get) Token: 0x0600125D RID: 4701 RVA: 0x00035C84 File Offset: 0x00033E84
							public static GameObject Image
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ReceivedFriendRequest/Actions/Block/Image");
								}
							}
						}
					}

					// Token: 0x02000306 RID: 774
					public class Image_4
					{
						// Token: 0x1700075B RID: 1883
						// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x00032560 File Offset: 0x00030760
						public static GameObject WorldImage
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ReceivedFriendRequest/Image/WorldImage");
							}
						}

						// Token: 0x1700075C RID: 1884
						// (get) Token: 0x06000FF3 RID: 4083 RVA: 0x0003257C File Offset: 0x0003077C
						public static GameObject WorldBorder
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ReceivedFriendRequest/Image/WorldBorder");
							}
						}
					}
				}

				// Token: 0x020001CC RID: 460
				public class SentFriendRequest_3
				{
					// Token: 0x170004A5 RID: 1189
					// (get) Token: 0x06000C02 RID: 3074 RVA: 0x0002CAC0 File Offset: 0x0002ACC0
					public static GameObject Actions
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/SentFriendRequest/Actions");
						}
					}

					// Token: 0x170004A6 RID: 1190
					// (get) Token: 0x06000C03 RID: 3075 RVA: 0x0002CADC File Offset: 0x0002ACDC
					public static GameObject WorldImage
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/SentFriendRequest/WorldImage");
						}
					}

					// Token: 0x02000307 RID: 775
					public class Actions_4
					{
						// Token: 0x1700075D RID: 1885
						// (get) Token: 0x06000FF5 RID: 4085 RVA: 0x000325A4 File Offset: 0x000307A4
						public static GameObject Friend
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/SentFriendRequest/Actions/Friend");
							}
						}

						// Token: 0x1700075E RID: 1886
						// (get) Token: 0x06000FF6 RID: 4086 RVA: 0x000325C0 File Offset: 0x000307C0
						public static GameObject Block
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/SentFriendRequest/Actions/Block");
							}
						}

						// Token: 0x020003D0 RID: 976
						public class Friend_5
						{
							// Token: 0x170008FE RID: 2302
							// (get) Token: 0x0600125F RID: 4703 RVA: 0x00035CAC File Offset: 0x00033EAC
							public static GameObject Image
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/SentFriendRequest/Actions/Friend/Image");
								}
							}
						}

						// Token: 0x020003D1 RID: 977
						public class Block_5
						{
							// Token: 0x170008FF RID: 2303
							// (get) Token: 0x06001261 RID: 4705 RVA: 0x00035CD4 File Offset: 0x00033ED4
							public static GameObject Image
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/SentFriendRequest/Actions/Block/Image");
								}
							}
						}
					}

					// Token: 0x02000308 RID: 776
					public class WorldImage_4
					{
						// Token: 0x1700075F RID: 1887
						// (get) Token: 0x06000FF8 RID: 4088 RVA: 0x000325E8 File Offset: 0x000307E8
						public static GameObject WorldImage
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/SentFriendRequest/WorldImage/WorldImage");
							}
						}

						// Token: 0x17000760 RID: 1888
						// (get) Token: 0x06000FF9 RID: 4089 RVA: 0x00032604 File Offset: 0x00030804
						public static GameObject WorldBorder
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/SentFriendRequest/WorldImage/WorldBorder");
							}
						}
					}
				}

				// Token: 0x020001CD RID: 461
				public class ModerateDialog_3
				{
					// Token: 0x170004A7 RID: 1191
					// (get) Token: 0x06000C05 RID: 3077 RVA: 0x0002CB04 File Offset: 0x0002AD04
					public static GameObject Darkness
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ModerateDialog/Darkness");
						}
					}

					// Token: 0x170004A8 RID: 1192
					// (get) Token: 0x06000C06 RID: 3078 RVA: 0x0002CB20 File Offset: 0x0002AD20
					public static GameObject Panel
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ModerateDialog/Panel");
						}
					}

					// Token: 0x02000309 RID: 777
					public class Panel_4
					{
						// Token: 0x17000761 RID: 1889
						// (get) Token: 0x06000FFB RID: 4091 RVA: 0x0003262C File Offset: 0x0003082C
						public static GameObject BorderImage
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ModerateDialog/Panel/BorderImage");
							}
						}

						// Token: 0x17000762 RID: 1890
						// (get) Token: 0x06000FFC RID: 4092 RVA: 0x00032648 File Offset: 0x00030848
						public static GameObject PanelHeaderBackground
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ModerateDialog/Panel/PanelHeaderBackground");
							}
						}

						// Token: 0x17000763 RID: 1891
						// (get) Token: 0x06000FFD RID: 4093 RVA: 0x00032664 File Offset: 0x00030864
						public static GameObject TitleText
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ModerateDialog/Panel/TitleText");
							}
						}

						// Token: 0x17000764 RID: 1892
						// (get) Token: 0x06000FFE RID: 4094 RVA: 0x00032680 File Offset: 0x00030880
						public static GameObject ExitButton
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ModerateDialog/Panel/ExitButton");
							}
						}

						// Token: 0x17000765 RID: 1893
						// (get) Token: 0x06000FFF RID: 4095 RVA: 0x0003269C File Offset: 0x0003089C
						public static GameObject GeneralModerationTitleText
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ModerateDialog/Panel/GeneralModerationTitleText");
							}
						}

						// Token: 0x17000766 RID: 1894
						// (get) Token: 0x06001000 RID: 4096 RVA: 0x000326B8 File Offset: 0x000308B8
						public static GameObject GeneralModeration
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ModerateDialog/Panel/GeneralModeration");
							}
						}

						// Token: 0x17000767 RID: 1895
						// (get) Token: 0x06001001 RID: 4097 RVA: 0x000326D4 File Offset: 0x000308D4
						public static GameObject AdminModerationTitleText
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ModerateDialog/Panel/AdminModerationTitleText");
							}
						}

						// Token: 0x17000768 RID: 1896
						// (get) Token: 0x06001002 RID: 4098 RVA: 0x000326F0 File Offset: 0x000308F0
						public static GameObject InstanceOwnerModerationTitleText
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ModerateDialog/Panel/InstanceOwnerModerationTitleText");
							}
						}

						// Token: 0x17000769 RID: 1897
						// (get) Token: 0x06001003 RID: 4099 RVA: 0x0003270C File Offset: 0x0003090C
						public static GameObject ModerateButtons
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ModerateDialog/Panel/ModerateButtons");
							}
						}

						// Token: 0x020003D2 RID: 978
						public class GeneralModeration_5
						{
							// Token: 0x17000900 RID: 2304
							// (get) Token: 0x06001263 RID: 4707 RVA: 0x00035CFC File Offset: 0x00033EFC
							public static GameObject Mute
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ModerateDialog/Panel/GeneralModeration/Mute");
								}
							}

							// Token: 0x17000901 RID: 2305
							// (get) Token: 0x06001264 RID: 4708 RVA: 0x00035D18 File Offset: 0x00033F18
							public static GameObject Block
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ModerateDialog/Panel/GeneralModeration/Block");
								}
							}

							// Token: 0x17000902 RID: 2306
							// (get) Token: 0x06001265 RID: 4709 RVA: 0x00035D34 File Offset: 0x00033F34
							public static GameObject VoteKick
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ModerateDialog/Panel/GeneralModeration/VoteKick");
								}
							}
						}

						// Token: 0x020003D3 RID: 979
						public class ModerateButtons_5
						{
							// Token: 0x17000903 RID: 2307
							// (get) Token: 0x06001267 RID: 4711 RVA: 0x00035D5C File Offset: 0x00033F5C
							public static GameObject Actions
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ModerateDialog/Panel/ModerateButtons/Actions");
								}
							}
						}
					}
				}
			}

			// Token: 0x020000FD RID: 253
			public class VRCPlus_2
			{
				// Token: 0x1700022B RID: 555
				// (get) Token: 0x060008B0 RID: 2224 RVA: 0x00027B98 File Offset: 0x00025D98
				public static GameObject TitlePanel
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/TitlePanel");
					}
				}

				// Token: 0x1700022C RID: 556
				// (get) Token: 0x060008B1 RID: 2225 RVA: 0x00027BB4 File Offset: 0x00025DB4
				public static GameObject Subscription
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription");
					}
				}

				// Token: 0x1700022D RID: 557
				// (get) Token: 0x060008B2 RID: 2226 RVA: 0x00027BD0 File Offset: 0x00025DD0
				public static GameObject DepthOverlay
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/DepthOverlay");
					}
				}

				// Token: 0x020001CE RID: 462
				public class TitlePanel_3
				{
					// Token: 0x170004A9 RID: 1193
					// (get) Token: 0x06000C08 RID: 3080 RVA: 0x0002CB48 File Offset: 0x0002AD48
					public static GameObject TitleText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/TitlePanel/TitleText");
						}
					}

					// Token: 0x170004AA RID: 1194
					// (get) Token: 0x06000C09 RID: 3081 RVA: 0x0002CB64 File Offset: 0x0002AD64
					public static GameObject TermsAndConditions
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/TitlePanel/TermsAndConditions");
						}
					}

					// Token: 0x0200030A RID: 778
					public class TermsAndConditions_4
					{
						// Token: 0x1700076A RID: 1898
						// (get) Token: 0x06001005 RID: 4101 RVA: 0x00032734 File Offset: 0x00030934
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/TitlePanel/TermsAndConditions/Text");
							}
						}
					}
				}

				// Token: 0x020001CF RID: 463
				public class Subscription_3
				{
					// Token: 0x170004AB RID: 1195
					// (get) Token: 0x06000C0B RID: 3083 RVA: 0x0002CB8C File Offset: 0x0002AD8C
					public static GameObject NonSubscriberBanner
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/NonSubscriberBanner");
						}
					}

					// Token: 0x170004AC RID: 1196
					// (get) Token: 0x06000C0C RID: 3084 RVA: 0x0002CBA8 File Offset: 0x0002ADA8
					public static GameObject SubscriberBanner
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/SubscriberBanner");
						}
					}

					// Token: 0x170004AD RID: 1197
					// (get) Token: 0x06000C0D RID: 3085 RVA: 0x0002CBC4 File Offset: 0x0002ADC4
					public static GameObject GROUP_Features
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Features");
						}
					}

					// Token: 0x170004AE RID: 1198
					// (get) Token: 0x06000C0E RID: 3086 RVA: 0x0002CBE0 File Offset: 0x0002ADE0
					public static GameObject GROUP_Subscribe_Buttons
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Subscribe_Buttons");
						}
					}

					// Token: 0x170004AF RID: 1199
					// (get) Token: 0x06000C0F RID: 3087 RVA: 0x0002CBFC File Offset: 0x0002ADFC
					public static GameObject GROUP_FeatureHovers
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_FeatureHovers");
						}
					}

					// Token: 0x170004B0 RID: 1200
					// (get) Token: 0x06000C10 RID: 3088 RVA: 0x0002CC18 File Offset: 0x0002AE18
					public static GameObject ProcessingOverlay
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/ProcessingOverlay");
						}
					}

					// Token: 0x0200030B RID: 779
					public class SubscriberBanner_4
					{
						// Token: 0x1700076B RID: 1899
						// (get) Token: 0x06001007 RID: 4103 RVA: 0x0003275C File Offset: 0x0003095C
						public static GameObject Viewport
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/SubscriberBanner/Viewport");
							}
						}

						// Token: 0x1700076C RID: 1900
						// (get) Token: 0x06001008 RID: 4104 RVA: 0x00032778 File Offset: 0x00030978
						public static GameObject Frame
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/SubscriberBanner/Frame");
							}
						}
					}

					// Token: 0x0200030C RID: 780
					public class GROUP_Features_4
					{
						// Token: 0x1700076D RID: 1901
						// (get) Token: 0x0600100A RID: 4106 RVA: 0x000327A0 File Offset: 0x000309A0
						public static GameObject Feature_UserIcon
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Features/Feature_UserIcon");
							}
						}

						// Token: 0x1700076E RID: 1902
						// (get) Token: 0x0600100B RID: 4107 RVA: 0x000327BC File Offset: 0x000309BC
						public static GameObject Feature_MoreFavorites
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Features/Feature_MoreFavorites");
							}
						}

						// Token: 0x1700076F RID: 1903
						// (get) Token: 0x0600100C RID: 4108 RVA: 0x000327D8 File Offset: 0x000309D8
						public static GameObject Feature_EarlySupporter
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Features/Feature_EarlySupporter");
							}
						}

						// Token: 0x17000770 RID: 1904
						// (get) Token: 0x0600100D RID: 4109 RVA: 0x000327F4 File Offset: 0x000309F4
						public static GameObject Feature_ProfileImage
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Features/Feature_ProfileImage");
							}
						}

						// Token: 0x17000771 RID: 1905
						// (get) Token: 0x0600100E RID: 4110 RVA: 0x00032810 File Offset: 0x00030A10
						public static GameObject Feature_PhotoInvites
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Features/Feature_PhotoInvites");
							}
						}

						// Token: 0x020003D4 RID: 980
						public class Feature_UserIcon_5
						{
							// Token: 0x17000904 RID: 2308
							// (get) Token: 0x06001269 RID: 4713 RVA: 0x00035D84 File Offset: 0x00033F84
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Features/Feature_UserIcon/Text");
								}
							}
						}

						// Token: 0x020003D5 RID: 981
						public class Feature_MoreFavorites_5
						{
							// Token: 0x17000905 RID: 2309
							// (get) Token: 0x0600126B RID: 4715 RVA: 0x00035DAC File Offset: 0x00033FAC
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Features/Feature_MoreFavorites/Text");
								}
							}
						}

						// Token: 0x020003D6 RID: 982
						public class Feature_EarlySupporter_5
						{
							// Token: 0x17000906 RID: 2310
							// (get) Token: 0x0600126D RID: 4717 RVA: 0x00035DD4 File Offset: 0x00033FD4
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Features/Feature_EarlySupporter/Text");
								}
							}
						}

						// Token: 0x020003D7 RID: 983
						public class Feature_ProfileImage_5
						{
							// Token: 0x17000907 RID: 2311
							// (get) Token: 0x0600126F RID: 4719 RVA: 0x00035DFC File Offset: 0x00033FFC
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Features/Feature_ProfileImage/Text");
								}
							}
						}

						// Token: 0x020003D8 RID: 984
						public class Feature_PhotoInvites_5
						{
							// Token: 0x17000908 RID: 2312
							// (get) Token: 0x06001271 RID: 4721 RVA: 0x00035E24 File Offset: 0x00034024
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Features/Feature_PhotoInvites/Text");
								}
							}
						}
					}

					// Token: 0x0200030D RID: 781
					public class GROUP_Subscribe_Buttons_4
					{
						// Token: 0x17000772 RID: 1906
						// (get) Token: 0x06001010 RID: 4112 RVA: 0x00032838 File Offset: 0x00030A38
						public static GameObject SubscribeButton_Monthly
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Subscribe_Buttons/SubscribeButton_Monthly");
							}
						}

						// Token: 0x17000773 RID: 1907
						// (get) Token: 0x06001011 RID: 4113 RVA: 0x00032854 File Offset: 0x00030A54
						public static GameObject SubscribeButton_Yearly
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Subscribe_Buttons/SubscribeButton_Yearly");
							}
						}

						// Token: 0x17000774 RID: 1908
						// (get) Token: 0x06001012 RID: 4114 RVA: 0x00032870 File Offset: 0x00030A70
						public static GameObject GROUP_Manage_Subscription
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Subscribe_Buttons/GROUP_Manage_Subscription");
							}
						}

						// Token: 0x17000775 RID: 1909
						// (get) Token: 0x06001013 RID: 4115 RVA: 0x0003288C File Offset: 0x00030A8C
						public static GameObject GROUP_Button_NotAvailable
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Subscribe_Buttons/GROUP_Button_NotAvailable");
							}
						}

						// Token: 0x17000776 RID: 1910
						// (get) Token: 0x06001014 RID: 4116 RVA: 0x000328A8 File Offset: 0x00030AA8
						public static GameObject GROUP_IntroductoryOffer_Buttons
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Subscribe_Buttons/GROUP_IntroductoryOffer_Buttons");
							}
						}

						// Token: 0x020003D9 RID: 985
						public class SubscribeButton_Monthly_5
						{
							// Token: 0x17000909 RID: 2313
							// (get) Token: 0x06001273 RID: 4723 RVA: 0x00035E4C File Offset: 0x0003404C
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Subscribe_Buttons/SubscribeButton_Monthly/Text");
								}
							}
						}

						// Token: 0x020003DA RID: 986
						public class SubscribeButton_Yearly_5
						{
							// Token: 0x1700090A RID: 2314
							// (get) Token: 0x06001275 RID: 4725 RVA: 0x00035E74 File Offset: 0x00034074
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Subscribe_Buttons/SubscribeButton_Yearly/Text");
								}
							}

							// Token: 0x1700090B RID: 2315
							// (get) Token: 0x06001276 RID: 4726 RVA: 0x00035E90 File Offset: 0x00034090
							public static GameObject RawImage
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Subscribe_Buttons/SubscribeButton_Yearly/RawImage");
								}
							}
						}

						// Token: 0x020003DB RID: 987
						public class GROUP_Manage_Subscription_5
						{
							// Token: 0x1700090C RID: 2316
							// (get) Token: 0x06001278 RID: 4728 RVA: 0x00035EB8 File Offset: 0x000340B8
							public static GameObject SubscriptionName
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Subscribe_Buttons/GROUP_Manage_Subscription/SubscriptionName");
								}
							}

							// Token: 0x1700090D RID: 2317
							// (get) Token: 0x06001279 RID: 4729 RVA: 0x00035ED4 File Offset: 0x000340D4
							public static GameObject BillingDate
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Subscribe_Buttons/GROUP_Manage_Subscription/BillingDate");
								}
							}

							// Token: 0x1700090E RID: 2318
							// (get) Token: 0x0600127A RID: 4730 RVA: 0x00035EF0 File Offset: 0x000340F0
							public static GameObject Amount
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Subscribe_Buttons/GROUP_Manage_Subscription/Amount");
								}
							}

							// Token: 0x1700090F RID: 2319
							// (get) Token: 0x0600127B RID: 4731 RVA: 0x00035F0C File Offset: 0x0003410C
							public static GameObject ManageSubscriptionButton
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Subscribe_Buttons/GROUP_Manage_Subscription/ManageSubscriptionButton");
								}
							}
						}

						// Token: 0x020003DC RID: 988
						public class GROUP_Button_NotAvailable_5
						{
							// Token: 0x17000910 RID: 2320
							// (get) Token: 0x0600127D RID: 4733 RVA: 0x00035F34 File Offset: 0x00034134
							public static GameObject Button
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Subscribe_Buttons/GROUP_Button_NotAvailable/Button");
								}
							}
						}

						// Token: 0x020003DD RID: 989
						public class GROUP_IntroductoryOffer_Buttons_5
						{
							// Token: 0x17000911 RID: 2321
							// (get) Token: 0x0600127F RID: 4735 RVA: 0x00035F5C File Offset: 0x0003415C
							public static GameObject SubscribeButton_Monthly
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Subscribe_Buttons/GROUP_IntroductoryOffer_Buttons/SubscribeButton_Monthly");
								}
							}

							// Token: 0x17000912 RID: 2322
							// (get) Token: 0x06001280 RID: 4736 RVA: 0x00035F78 File Offset: 0x00034178
							public static GameObject SubscribeButton_Yearly
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Subscribe_Buttons/GROUP_IntroductoryOffer_Buttons/SubscribeButton_Yearly");
								}
							}

							// Token: 0x17000913 RID: 2323
							// (get) Token: 0x06001281 RID: 4737 RVA: 0x00035F94 File Offset: 0x00034194
							public static GameObject Deal_HeaderPanel
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Subscribe_Buttons/GROUP_IntroductoryOffer_Buttons/Deal_HeaderPanel");
								}
							}
						}
					}

					// Token: 0x0200030E RID: 782
					public class GROUP_FeatureHovers_4
					{
						// Token: 0x17000777 RID: 1911
						// (get) Token: 0x06001016 RID: 4118 RVA: 0x000328D0 File Offset: 0x00030AD0
						public static GameObject IMG_FeatureHover_NameIcon
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_FeatureHovers/IMG_FeatureHover_NameIcon");
							}
						}

						// Token: 0x17000778 RID: 1912
						// (get) Token: 0x06001017 RID: 4119 RVA: 0x000328EC File Offset: 0x00030AEC
						public static GameObject IMG_FeatureHover_MoreFavoriteAvatars
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_FeatureHovers/IMG_FeatureHover_MoreFavoriteAvatars");
							}
						}

						// Token: 0x17000779 RID: 1913
						// (get) Token: 0x06001018 RID: 4120 RVA: 0x00032908 File Offset: 0x00030B08
						public static GameObject IMG_FeatureHover_EarlySupporterBadge
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_FeatureHovers/IMG_FeatureHover_EarlySupporterBadge");
							}
						}

						// Token: 0x1700077A RID: 1914
						// (get) Token: 0x06001019 RID: 4121 RVA: 0x00032924 File Offset: 0x00030B24
						public static GameObject IMG_FeatureHover_ProfileImage
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_FeatureHovers/IMG_FeatureHover_ProfileImage");
							}
						}

						// Token: 0x1700077B RID: 1915
						// (get) Token: 0x0600101A RID: 4122 RVA: 0x00032940 File Offset: 0x00030B40
						public static GameObject IMG_FeatureHover_PhotoInvites
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_FeatureHovers/IMG_FeatureHover_PhotoInvites");
							}
						}
					}

					// Token: 0x0200030F RID: 783
					public class ProcessingOverlay_4
					{
						// Token: 0x1700077C RID: 1916
						// (get) Token: 0x0600101C RID: 4124 RVA: 0x00032968 File Offset: 0x00030B68
						public static GameObject CloseButton
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/ProcessingOverlay/CloseButton");
							}
						}

						// Token: 0x1700077D RID: 1917
						// (get) Token: 0x0600101D RID: 4125 RVA: 0x00032984 File Offset: 0x00030B84
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/ProcessingOverlay/Text");
							}
						}

						// Token: 0x1700077E RID: 1918
						// (get) Token: 0x0600101E RID: 4126 RVA: 0x000329A0 File Offset: 0x00030BA0
						public static GameObject RawImage
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/ProcessingOverlay/RawImage");
							}
						}

						// Token: 0x1700077F RID: 1919
						// (get) Token: 0x0600101F RID: 4127 RVA: 0x000329BC File Offset: 0x00030BBC
						public static GameObject CheckSteamText
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/ProcessingOverlay/CheckSteamText");
							}
						}

						// Token: 0x17000780 RID: 1920
						// (get) Token: 0x06001020 RID: 4128 RVA: 0x000329D8 File Offset: 0x00030BD8
						public static GameObject CheckSteamOptionsText
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/ProcessingOverlay/CheckSteamOptionsText");
							}
						}

						// Token: 0x020003DE RID: 990
						public class CloseButton_5
						{
							// Token: 0x17000914 RID: 2324
							// (get) Token: 0x06001283 RID: 4739 RVA: 0x00035FBC File Offset: 0x000341BC
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/ProcessingOverlay/CloseButton/Text");
								}
							}
						}
					}
				}
			}

			// Token: 0x020000FE RID: 254
			public class WorldInfo_2
			{
				// Token: 0x1700022E RID: 558
				// (get) Token: 0x060008B4 RID: 2228 RVA: 0x00027BF8 File Offset: 0x00025DF8
				public static GameObject Panel_1
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panel (1)");
					}
				}

				// Token: 0x1700022F RID: 559
				// (get) Token: 0x060008B5 RID: 2229 RVA: 0x00027C14 File Offset: 0x00025E14
				public static GameObject Back_Button
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Back Button");
					}
				}

				// Token: 0x17000230 RID: 560
				// (get) Token: 0x060008B6 RID: 2230 RVA: 0x00027C30 File Offset: 0x00025E30
				public static GameObject WorldButtons
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldButtons");
					}
				}

				// Token: 0x17000231 RID: 561
				// (get) Token: 0x060008B7 RID: 2231 RVA: 0x00027C4C File Offset: 0x00025E4C
				public static GameObject WorldImage
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage");
					}
				}

				// Token: 0x17000232 RID: 562
				// (get) Token: 0x060008B8 RID: 2232 RVA: 0x00027C68 File Offset: 0x00025E68
				public static GameObject OtherInstances
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/OtherInstances");
					}
				}

				// Token: 0x17000233 RID: 563
				// (get) Token: 0x060008B9 RID: 2233 RVA: 0x00027C84 File Offset: 0x00025E84
				public static GameObject MakeHomeButton
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/MakeHomeButton");
					}
				}

				// Token: 0x17000234 RID: 564
				// (get) Token: 0x060008BA RID: 2234 RVA: 0x00027CA0 File Offset: 0x00025EA0
				public static GameObject ResetHomeButton
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/ResetHomeButton");
					}
				}

				// Token: 0x17000235 RID: 565
				// (get) Token: 0x060008BB RID: 2235 RVA: 0x00027CBC File Offset: 0x00025EBC
				public static GameObject ReportButton
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/ReportButton");
					}
				}

				// Token: 0x17000236 RID: 566
				// (get) Token: 0x060008BC RID: 2236 RVA: 0x00027CD8 File Offset: 0x00025ED8
				public static GameObject DepthOverlay
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/DepthOverlay");
					}
				}

				// Token: 0x17000237 RID: 567
				// (get) Token: 0x060008BD RID: 2237 RVA: 0x00027CF4 File Offset: 0x00025EF4
				public static GameObject FavoriteButton
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/FavoriteButton");
					}
				}

				// Token: 0x17000238 RID: 568
				// (get) Token: 0x060008BE RID: 2238 RVA: 0x00027D10 File Offset: 0x00025F10
				public static GameObject OwnerTextName
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/OwnerText-Name");
					}
				}

				// Token: 0x17000239 RID: 569
				// (get) Token: 0x060008BF RID: 2239 RVA: 0x00027D2C File Offset: 0x00025F2C
				public static GameObject Panels
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels");
					}
				}

				// Token: 0x020001D0 RID: 464
				public class Back_Button_3
				{
					// Token: 0x170004B1 RID: 1201
					// (get) Token: 0x06000C12 RID: 3090 RVA: 0x0002CC40 File Offset: 0x0002AE40
					public static GameObject Text
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Back Button/Text");
						}
					}
				}

				// Token: 0x020001D1 RID: 465
				public class WorldButtons_3
				{
					// Token: 0x170004B2 RID: 1202
					// (get) Token: 0x06000C14 RID: 3092 RVA: 0x0002CC68 File Offset: 0x0002AE68
					public static GameObject GoButton
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldButtons/GoButton");
						}
					}

					// Token: 0x170004B3 RID: 1203
					// (get) Token: 0x06000C15 RID: 3093 RVA: 0x0002CC84 File Offset: 0x0002AE84
					public static GameObject PortalButton
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldButtons/PortalButton");
						}
					}

					// Token: 0x170004B4 RID: 1204
					// (get) Token: 0x06000C16 RID: 3094 RVA: 0x0002CCA0 File Offset: 0x0002AEA0
					public static GameObject NewButton
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldButtons/NewButton");
						}
					}

					// Token: 0x02000310 RID: 784
					public class GoButton_4
					{
						// Token: 0x17000781 RID: 1921
						// (get) Token: 0x06001022 RID: 4130 RVA: 0x00032A00 File Offset: 0x00030C00
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldButtons/GoButton/Text");
							}
						}
					}

					// Token: 0x02000311 RID: 785
					public class PortalButton_4
					{
						// Token: 0x17000782 RID: 1922
						// (get) Token: 0x06001024 RID: 4132 RVA: 0x00032A28 File Offset: 0x00030C28
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldButtons/PortalButton/Text");
							}
						}
					}

					// Token: 0x02000312 RID: 786
					public class NewButton_4
					{
						// Token: 0x17000783 RID: 1923
						// (get) Token: 0x06001026 RID: 4134 RVA: 0x00032A50 File Offset: 0x00030C50
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldButtons/NewButton/Text");
							}
						}
					}
				}

				// Token: 0x020001D2 RID: 466
				public class WorldImage_3
				{
					// Token: 0x170004B5 RID: 1205
					// (get) Token: 0x06000C18 RID: 3096 RVA: 0x0002CCC8 File Offset: 0x0002AEC8
					public static GameObject RoomImage
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/RoomImage");
						}
					}

					// Token: 0x170004B6 RID: 1206
					// (get) Token: 0x06000C19 RID: 3097 RVA: 0x0002CCE4 File Offset: 0x0002AEE4
					public static GameObject RoomBorder
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/RoomBorder");
						}
					}

					// Token: 0x170004B7 RID: 1207
					// (get) Token: 0x06000C1A RID: 3098 RVA: 0x0002CD00 File Offset: 0x0002AF00
					public static GameObject Panel
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/Panel");
						}
					}

					// Token: 0x170004B8 RID: 1208
					// (get) Token: 0x06000C1B RID: 3099 RVA: 0x0002CD1C File Offset: 0x0002AF1C
					public static GameObject CurrentInstance
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/CurrentInstance");
						}
					}

					// Token: 0x170004B9 RID: 1209
					// (get) Token: 0x06000C1C RID: 3100 RVA: 0x0002CD38 File Offset: 0x0002AF38
					public static GameObject OverlayIcons
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/OverlayIcons");
						}
					}

					// Token: 0x170004BA RID: 1210
					// (get) Token: 0x06000C1D RID: 3101 RVA: 0x0002CD54 File Offset: 0x0002AF54
					public static GameObject InstanceInfo
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/InstanceInfo");
						}
					}

					// Token: 0x02000313 RID: 787
					public class Panel_4
					{
						// Token: 0x17000784 RID: 1924
						// (get) Token: 0x06001028 RID: 4136 RVA: 0x00032A78 File Offset: 0x00030C78
						public static GameObject NameText
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/Panel/NameText");
							}
						}

						// Token: 0x17000785 RID: 1925
						// (get) Token: 0x06001029 RID: 4137 RVA: 0x00032A94 File Offset: 0x00030C94
						public static GameObject IconPlayer
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/Panel/IconPlayer");
							}
						}

						// Token: 0x17000786 RID: 1926
						// (get) Token: 0x0600102A RID: 4138 RVA: 0x00032AB0 File Offset: 0x00030CB0
						public static GameObject PlayerCount
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/Panel/PlayerCount");
							}
						}
					}

					// Token: 0x02000314 RID: 788
					public class CurrentInstance_4
					{
						// Token: 0x17000787 RID: 1927
						// (get) Token: 0x0600102C RID: 4140 RVA: 0x00032AD8 File Offset: 0x00030CD8
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/CurrentInstance/Text");
							}
						}
					}

					// Token: 0x02000315 RID: 789
					public class InstanceInfo_4
					{
						// Token: 0x17000788 RID: 1928
						// (get) Token: 0x0600102E RID: 4142 RVA: 0x00032B00 File Offset: 0x00030D00
						public static GameObject InstanceIdBackground
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/InstanceInfo/InstanceIdBackground");
							}
						}

						// Token: 0x17000789 RID: 1929
						// (get) Token: 0x0600102F RID: 4143 RVA: 0x00032B1C File Offset: 0x00030D1C
						public static GameObject InstanceOwnerBackground
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/InstanceInfo/InstanceOwnerBackground");
							}
						}

						// Token: 0x1700078A RID: 1930
						// (get) Token: 0x06001030 RID: 4144 RVA: 0x00032B38 File Offset: 0x00030D38
						public static GameObject InstancePrivacyBackground
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/InstanceInfo/InstancePrivacyBackground");
							}
						}

						// Token: 0x020003DF RID: 991
						public class InstanceIdBackground_5
						{
							// Token: 0x17000915 RID: 2325
							// (get) Token: 0x06001285 RID: 4741 RVA: 0x00035FE4 File Offset: 0x000341E4
							public static GameObject InstanceId
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/InstanceInfo/InstanceIdBackground/InstanceId");
								}
							}
						}

						// Token: 0x020003E0 RID: 992
						public class InstanceOwnerBackground_5
						{
							// Token: 0x17000916 RID: 2326
							// (get) Token: 0x06001287 RID: 4743 RVA: 0x0003600C File Offset: 0x0003420C
							public static GameObject InstanceOwner
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/InstanceInfo/InstanceOwnerBackground/InstanceOwner");
								}
							}
						}

						// Token: 0x020003E1 RID: 993
						public class InstancePrivacyBackground_5
						{
							// Token: 0x17000917 RID: 2327
							// (get) Token: 0x06001289 RID: 4745 RVA: 0x00036034 File Offset: 0x00034234
							public static GameObject InstancePrivacy
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/InstanceInfo/InstancePrivacyBackground/InstancePrivacy");
								}
							}
						}
					}
				}

				// Token: 0x020001D3 RID: 467
				public class OtherInstances_3
				{
					// Token: 0x170004BB RID: 1211
					// (get) Token: 0x06000C1F RID: 3103 RVA: 0x0002CD7C File Offset: 0x0002AF7C
					public static GameObject ViewPort
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/OtherInstances/ViewPort");
						}
					}

					// Token: 0x170004BC RID: 1212
					// (get) Token: 0x06000C20 RID: 3104 RVA: 0x0002CD98 File Offset: 0x0002AF98
					public static GameObject Button
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/OtherInstances/Button");
						}
					}

					// Token: 0x02000316 RID: 790
					public class Button_4
					{
						// Token: 0x1700078B RID: 1931
						// (get) Token: 0x06001032 RID: 4146 RVA: 0x00032B60 File Offset: 0x00030D60
						public static GameObject TitleText
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/OtherInstances/Button/TitleText");
							}
						}

						// Token: 0x1700078C RID: 1932
						// (get) Token: 0x06001033 RID: 4147 RVA: 0x00032B7C File Offset: 0x00030D7C
						public static GameObject ToggleIcon
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/OtherInstances/Button/ToggleIcon");
							}
						}
					}
				}

				// Token: 0x020001D4 RID: 468
				public class MakeHomeButton_3
				{
					// Token: 0x170004BD RID: 1213
					// (get) Token: 0x06000C22 RID: 3106 RVA: 0x0002CDC0 File Offset: 0x0002AFC0
					public static GameObject Text
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/MakeHomeButton/Text");
						}
					}
				}

				// Token: 0x020001D5 RID: 469
				public class ResetHomeButton_3
				{
					// Token: 0x170004BE RID: 1214
					// (get) Token: 0x06000C24 RID: 3108 RVA: 0x0002CDE8 File Offset: 0x0002AFE8
					public static GameObject Text
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/ResetHomeButton/Text");
						}
					}
				}

				// Token: 0x020001D6 RID: 470
				public class ReportButton_3
				{
					// Token: 0x170004BF RID: 1215
					// (get) Token: 0x06000C26 RID: 3110 RVA: 0x0002CE10 File Offset: 0x0002B010
					public static GameObject Text
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/ReportButton/Text");
						}
					}
				}

				// Token: 0x020001D7 RID: 471
				public class FavoriteButton_3
				{
					// Token: 0x170004C0 RID: 1216
					// (get) Token: 0x06000C28 RID: 3112 RVA: 0x0002CE38 File Offset: 0x0002B038
					public static GameObject Text
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/FavoriteButton/Text");
						}
					}
				}

				// Token: 0x020001D8 RID: 472
				public class Panels_3
				{
					// Token: 0x170004C1 RID: 1217
					// (get) Token: 0x06000C2A RID: 3114 RVA: 0x0002CE60 File Offset: 0x0002B060
					public static GameObject PanelBackground
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/PanelBackground");
						}
					}

					// Token: 0x170004C2 RID: 1218
					// (get) Token: 0x06000C2B RID: 3115 RVA: 0x0002CE7C File Offset: 0x0002B07C
					public static GameObject DetailsPanel
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/DetailsPanel");
						}
					}

					// Token: 0x170004C3 RID: 1219
					// (get) Token: 0x06000C2C RID: 3116 RVA: 0x0002CE98 File Offset: 0x0002B098
					public static GameObject TagsPanel
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/TagsPanel");
						}
					}

					// Token: 0x02000317 RID: 791
					public class DetailsPanel_4
					{
						// Token: 0x1700078D RID: 1933
						// (get) Token: 0x06001035 RID: 4149 RVA: 0x00032BA4 File Offset: 0x00030DA4
						public static GameObject AuthorTextTitle
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/DetailsPanel/AuthorText-Title");
							}
						}

						// Token: 0x1700078E RID: 1934
						// (get) Token: 0x06001036 RID: 4150 RVA: 0x00032BC0 File Offset: 0x00030DC0
						public static GameObject WorldSizeTextTitle
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/DetailsPanel/WorldSizeTextTitle");
							}
						}

						// Token: 0x1700078F RID: 1935
						// (get) Token: 0x06001037 RID: 4151 RVA: 0x00032BDC File Offset: 0x00030DDC
						public static GameObject PublishStatusData
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/DetailsPanel/PublishStatus-Data");
							}
						}

						// Token: 0x17000790 RID: 1936
						// (get) Token: 0x06001038 RID: 4152 RVA: 0x00032BF8 File Offset: 0x00030DF8
						public static GameObject DescTextTitle
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/DetailsPanel/DescText-Title");
							}
						}

						// Token: 0x17000791 RID: 1937
						// (get) Token: 0x06001039 RID: 4153 RVA: 0x00032C14 File Offset: 0x00030E14
						public static GameObject PublicTextTitle
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/DetailsPanel/PublicTextTitle");
							}
						}

						// Token: 0x17000792 RID: 1938
						// (get) Token: 0x0600103A RID: 4154 RVA: 0x00032C30 File Offset: 0x00030E30
						public static GameObject PrivateTextTitle
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/DetailsPanel/PrivateTextTitle");
							}
						}

						// Token: 0x17000793 RID: 1939
						// (get) Token: 0x0600103B RID: 4155 RVA: 0x00032C4C File Offset: 0x00030E4C
						public static GameObject TagButton
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/DetailsPanel/TagButton");
							}
						}

						// Token: 0x020003E2 RID: 994
						public class AuthorTextTitle_5
						{
							// Token: 0x17000918 RID: 2328
							// (get) Token: 0x0600128B RID: 4747 RVA: 0x0003605C File Offset: 0x0003425C
							public static GameObject AuthorButton
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/DetailsPanel/AuthorText-Title/AuthorButton");
								}
							}
						}

						// Token: 0x020003E3 RID: 995
						public class WorldSizeTextTitle_5
						{
							// Token: 0x17000919 RID: 2329
							// (get) Token: 0x0600128D RID: 4749 RVA: 0x00036084 File Offset: 0x00034284
							public static GameObject WorldSizeText
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/DetailsPanel/WorldSizeTextTitle/WorldSizeText");
								}
							}
						}

						// Token: 0x020003E4 RID: 996
						public class DescTextTitle_5
						{
							// Token: 0x1700091A RID: 2330
							// (get) Token: 0x0600128F RID: 4751 RVA: 0x000360AC File Offset: 0x000342AC
							public static GameObject DescTextDesc
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/DetailsPanel/DescText-Title/DescText-Desc");
								}
							}
						}

						// Token: 0x020003E5 RID: 997
						public class PublicTextTitle_5
						{
							// Token: 0x1700091B RID: 2331
							// (get) Token: 0x06001291 RID: 4753 RVA: 0x000360D4 File Offset: 0x000342D4
							public static GameObject PublicText
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/DetailsPanel/PublicTextTitle/PublicText");
								}
							}
						}

						// Token: 0x020003E6 RID: 998
						public class PrivateTextTitle_5
						{
							// Token: 0x1700091C RID: 2332
							// (get) Token: 0x06001293 RID: 4755 RVA: 0x000360FC File Offset: 0x000342FC
							public static GameObject PrivateText
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/DetailsPanel/PrivateTextTitle/PrivateText");
								}
							}
						}

						// Token: 0x020003E7 RID: 999
						public class TagButton_5
						{
							// Token: 0x1700091D RID: 2333
							// (get) Token: 0x06001295 RID: 4757 RVA: 0x00036124 File Offset: 0x00034324
							public static GameObject Image
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/DetailsPanel/TagButton/Image");
								}
							}
						}
					}

					// Token: 0x02000318 RID: 792
					public class TagsPanel_4
					{
						// Token: 0x17000794 RID: 1940
						// (get) Token: 0x0600103D RID: 4157 RVA: 0x00032C74 File Offset: 0x00030E74
						public static GameObject TagButtons
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/TagsPanel/TagButtons");
							}
						}

						// Token: 0x17000795 RID: 1941
						// (get) Token: 0x0600103E RID: 4158 RVA: 0x00032C90 File Offset: 0x00030E90
						public static GameObject DetailsButton
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/TagsPanel/DetailsButton");
							}
						}

						// Token: 0x020003E8 RID: 1000
						public class TagButtons_5
						{
							// Token: 0x1700091E RID: 2334
							// (get) Token: 0x06001297 RID: 4759 RVA: 0x0003614C File Offset: 0x0003434C
							public static GameObject TagButton1
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/TagsPanel/TagButtons/TagButton1");
								}
							}

							// Token: 0x1700091F RID: 2335
							// (get) Token: 0x06001298 RID: 4760 RVA: 0x00036168 File Offset: 0x00034368
							public static GameObject TagButton2
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/TagsPanel/TagButtons/TagButton2");
								}
							}

							// Token: 0x17000920 RID: 2336
							// (get) Token: 0x06001299 RID: 4761 RVA: 0x00036184 File Offset: 0x00034384
							public static GameObject TagButton
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/TagsPanel/TagButtons/TagButton3");
								}
							}

							// Token: 0x17000921 RID: 2337
							// (get) Token: 0x0600129A RID: 4762 RVA: 0x000361A0 File Offset: 0x000343A0
							public static GameObject TagButton4
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/TagsPanel/TagButtons/TagButton4");
								}
							}

							// Token: 0x17000922 RID: 2338
							// (get) Token: 0x0600129B RID: 4763 RVA: 0x000361BC File Offset: 0x000343BC
							public static GameObject TagButton5
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/TagsPanel/TagButtons/TagButton5");
								}
							}

							// Token: 0x17000923 RID: 2339
							// (get) Token: 0x0600129C RID: 4764 RVA: 0x000361D8 File Offset: 0x000343D8
							public static GameObject TagsLabel
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/TagsPanel/TagButtons/TagsLabel");
								}
							}
						}

						// Token: 0x020003E9 RID: 1001
						public class DetailsButton_5
						{
							// Token: 0x17000924 RID: 2340
							// (get) Token: 0x0600129E RID: 4766 RVA: 0x00036200 File Offset: 0x00034400
							public static GameObject Image
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/TagsPanel/DetailsButton/Image");
								}
							}
						}
					}
				}
			}

			// Token: 0x020000FF RID: 255
			public class Worlds_2
			{
				// Token: 0x1700023A RID: 570
				// (get) Token: 0x060008C1 RID: 2241 RVA: 0x00027D54 File Offset: 0x00025F54
				public static GameObject Vertical_Scroll_View
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Vertical Scroll View");
					}
				}

				// Token: 0x1700023B RID: 571
				// (get) Token: 0x060008C2 RID: 2242 RVA: 0x00027D70 File Offset: 0x00025F70
				public static GameObject Current_Room
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Current Room");
					}
				}

				// Token: 0x1700023C RID: 572
				// (get) Token: 0x060008C3 RID: 2243 RVA: 0x00027D8C File Offset: 0x00025F8C
				public static GameObject DepthOverlay
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/DepthOverlay");
					}
				}

				// Token: 0x020001D9 RID: 473
				public class Current_Room_3
				{
					// Token: 0x170004C4 RID: 1220
					// (get) Token: 0x06000C2E RID: 3118 RVA: 0x0002CEC0 File Offset: 0x0002B0C0
					public static GameObject TitlePanel
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Current Room/TitlePanel");
						}
					}

					// Token: 0x170004C5 RID: 1221
					// (get) Token: 0x06000C2F RID: 3119 RVA: 0x0002CEDC File Offset: 0x0002B0DC
					public static GameObject Text
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Current Room/Text");
						}
					}

					// Token: 0x170004C6 RID: 1222
					// (get) Token: 0x06000C30 RID: 3120 RVA: 0x0002CEF8 File Offset: 0x0002B0F8
					public static GameObject ThisWorldButton
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Current Room/ThisWorldButton");
						}
					}

					// Token: 0x170004C7 RID: 1223
					// (get) Token: 0x06000C31 RID: 3121 RVA: 0x0002CF14 File Offset: 0x0002B114
					public static GameObject RespawnButton_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Current Room/RespawnButton (1)");
						}
					}

					// Token: 0x170004C8 RID: 1224
					// (get) Token: 0x06000C32 RID: 3122 RVA: 0x0002CF30 File Offset: 0x0002B130
					public static GameObject LikeButton_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Current Room/LikeButton (1)");
						}
					}

					// Token: 0x170004C9 RID: 1225
					// (get) Token: 0x06000C33 RID: 3123 RVA: 0x0002CF4C File Offset: 0x0002B14C
					public static GameObject TopLine
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Current Room/TopLine");
						}
					}

					// Token: 0x170004CA RID: 1226
					// (get) Token: 0x06000C34 RID: 3124 RVA: 0x0002CF68 File Offset: 0x0002B168
					public static GameObject TopLine_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Current Room/TopLine (1)");
						}
					}

					// Token: 0x02000319 RID: 793
					public class ThisWorldButton_4
					{
						// Token: 0x17000796 RID: 1942
						// (get) Token: 0x06001040 RID: 4160 RVA: 0x00032CB8 File Offset: 0x00030EB8
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Current Room/ThisWorldButton/Text");
							}
						}
					}

					// Token: 0x0200031A RID: 794
					public class RespawnButton_1_4
					{
						// Token: 0x17000797 RID: 1943
						// (get) Token: 0x06001042 RID: 4162 RVA: 0x00032CE0 File Offset: 0x00030EE0
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Current Room/RespawnButton (1)/Text");
							}
						}

						// Token: 0x17000798 RID: 1944
						// (get) Token: 0x06001043 RID: 4163 RVA: 0x00032CFC File Offset: 0x00030EFC
						public static GameObject Image
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Current Room/RespawnButton (1)/Image");
							}
						}
					}

					// Token: 0x0200031B RID: 795
					public class LikeButton_1_4
					{
						// Token: 0x17000799 RID: 1945
						// (get) Token: 0x06001045 RID: 4165 RVA: 0x00032D24 File Offset: 0x00030F24
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Current Room/LikeButton (1)/Text");
							}
						}

						// Token: 0x1700079A RID: 1946
						// (get) Token: 0x06001046 RID: 4166 RVA: 0x00032D40 File Offset: 0x00030F40
						public static GameObject Image
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Current Room/LikeButton (1)/Image");
							}
						}
					}
				}
			}

			// Token: 0x02000100 RID: 256
			public class Menu_wqoRd0FotfW91RAccountswqoRd0FotfW91R_2
			{
				// Token: 0x1700023D RID: 573
				// (get) Token: 0x060008C5 RID: 2245 RVA: 0x00027DB4 File Offset: 0x00025FB4
				public static GameObject TitlePanel
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/TitlePanel");
					}
				}

				// Token: 0x1700023E RID: 574
				// (get) Token: 0x060008C6 RID: 2246 RVA: 0x00027DD0 File Offset: 0x00025FD0
				public static GameObject ComfortSafetyPanel
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel");
					}
				}

				// Token: 0x1700023F RID: 575
				// (get) Token: 0x060008C7 RID: 2247 RVA: 0x00027DEC File Offset: 0x00025FEC
				public static GameObject AudioDevicePanel
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/AudioDevicePanel");
					}
				}

				// Token: 0x17000240 RID: 576
				// (get) Token: 0x060008C8 RID: 2248 RVA: 0x00027E08 File Offset: 0x00026008
				public static GameObject MousePanel
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/MousePanel");
					}
				}

				// Token: 0x17000241 RID: 577
				// (get) Token: 0x060008C9 RID: 2249 RVA: 0x00027E24 File Offset: 0x00026024
				public static GameObject HeightPanel
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/HeightPanel");
					}
				}

				// Token: 0x17000242 RID: 578
				// (get) Token: 0x060008CA RID: 2250 RVA: 0x00027E40 File Offset: 0x00026040
				public static GameObject VoiceOptionsPanel
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VoiceOptionsPanel");
					}
				}

				// Token: 0x17000243 RID: 579
				// (get) Token: 0x060008CB RID: 2251 RVA: 0x00027E5C File Offset: 0x0002605C
				public static GameObject OtherOptionsPanel
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/OtherOptionsPanel");
					}
				}

				// Token: 0x17000244 RID: 580
				// (get) Token: 0x060008CC RID: 2252 RVA: 0x00027E78 File Offset: 0x00026078
				public static GameObject VolumePanel
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VolumePanel");
					}
				}

				// Token: 0x17000245 RID: 581
				// (get) Token: 0x060008CD RID: 2253 RVA: 0x00027E94 File Offset: 0x00026094
				public static GameObject Footer
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/Footer");
					}
				}

				// Token: 0x17000246 RID: 582
				// (get) Token: 0x060008CE RID: 2254 RVA: 0x00027EB0 File Offset: 0x000260B0
				public static GameObject DepthOverlay
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/DepthOverlay");
					}
				}

				// Token: 0x17000247 RID: 583
				// (get) Token: 0x060008CF RID: 2255 RVA: 0x00027ECC File Offset: 0x000260CC
				public static GameObject Button_AdvancedOptions
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/Button_AdvancedOptions");
					}
				}

				// Token: 0x17000248 RID: 584
				// (get) Token: 0x060008D0 RID: 2256 RVA: 0x00027EE8 File Offset: 0x000260E8
				public static GameObject Button_EditBindings
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/Button_EditBindings");
					}
				}

				// Token: 0x17000249 RID: 585
				// (get) Token: 0x060008D1 RID: 2257 RVA: 0x00027F04 File Offset: 0x00026104
				public static GameObject UserVolumeOptions
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/UserVolumeOptions");
					}
				}

				// Token: 0x020001DA RID: 474
				public class TitlePanel_3
				{
					// Token: 0x170004CB RID: 1227
					// (get) Token: 0x06000C36 RID: 3126 RVA: 0x0002CF90 File Offset: 0x0002B190
					public static GameObject TitleText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/TitlePanel/TitleText");
						}
					}

					// Token: 0x170004CC RID: 1228
					// (get) Token: 0x06000C37 RID: 3127 RVA: 0x0002CFAC File Offset: 0x0002B1AC
					public static GameObject VersionText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/TitlePanel/VersionText");
						}
					}
				}

				// Token: 0x020001DB RID: 475
				public class ComfortSafetyPanel_3
				{
					// Token: 0x170004CD RID: 1229
					// (get) Token: 0x06000C39 RID: 3129 RVA: 0x0002CFD4 File Offset: 0x0002B1D4
					public static GameObject Panel_Header
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/Panel_Header");
						}
					}

					// Token: 0x170004CE RID: 1230
					// (get) Token: 0x06000C3A RID: 3130 RVA: 0x0002CFF0 File Offset: 0x0002B1F0
					public static GameObject TitleText_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/TitleText (1)");
						}
					}

					// Token: 0x170004CF RID: 1231
					// (get) Token: 0x06000C3B RID: 3131 RVA: 0x0002D00C File Offset: 0x0002B20C
					public static GameObject HoloportToggle
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/HoloportToggle");
						}
					}

					// Token: 0x170004D0 RID: 1232
					// (get) Token: 0x06000C3C RID: 3132 RVA: 0x0002D028 File Offset: 0x0002B228
					public static GameObject ComfortTurnToggle
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/ComfortTurnToggle");
						}
					}

					// Token: 0x170004D1 RID: 1233
					// (get) Token: 0x06000C3D RID: 3133 RVA: 0x0002D044 File Offset: 0x0002B244
					public static GameObject PersonalSpaceToggle
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/PersonalSpaceToggle");
						}
					}

					// Token: 0x170004D2 RID: 1234
					// (get) Token: 0x06000C3E RID: 3134 RVA: 0x0002D060 File Offset: 0x0002B260
					public static GameObject AllowUntrustedURL
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/AllowUntrustedURL");
						}
					}

					// Token: 0x170004D3 RID: 1235
					// (get) Token: 0x06000C3F RID: 3135 RVA: 0x0002D07C File Offset: 0x0002B27C
					public static GameObject StreamerModeToggle
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/StreamerModeToggle");
						}
					}

					// Token: 0x170004D4 RID: 1236
					// (get) Token: 0x06000C40 RID: 3136 RVA: 0x0002D098 File Offset: 0x0002B298
					public static GameObject MuteUsersToggle
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/MuteUsersToggle");
						}
					}

					// Token: 0x170004D5 RID: 1237
					// (get) Token: 0x06000C41 RID: 3137 RVA: 0x0002D0B4 File Offset: 0x0002B2B4
					public static GameObject BlockAvatarsToggle
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/BlockAvatarsToggle");
						}
					}

					// Token: 0x170004D6 RID: 1238
					// (get) Token: 0x06000C42 RID: 3138 RVA: 0x0002D0D0 File Offset: 0x0002B2D0
					public static GameObject HeadSetGazeToggle
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/HeadSetGazeToggle");
						}
					}

					// Token: 0x170004D7 RID: 1239
					// (get) Token: 0x06000C43 RID: 3139 RVA: 0x0002D0EC File Offset: 0x0002B2EC
					public static GameObject KeyboardToggle
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/KeyboardToggle");
						}
					}

					// Token: 0x170004D8 RID: 1240
					// (get) Token: 0x06000C44 RID: 3140 RVA: 0x0002D108 File Offset: 0x0002B308
					public static GameObject GamepadToggle
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/GamepadToggle");
						}
					}

					// Token: 0x170004D9 RID: 1241
					// (get) Token: 0x06000C45 RID: 3141 RVA: 0x0002D124 File Offset: 0x0002B324
					public static GameObject PrimaryInputPanel
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/PrimaryInputPanel");
						}
					}

					// Token: 0x170004DA RID: 1242
					// (get) Token: 0x06000C46 RID: 3142 RVA: 0x0002D140 File Offset: 0x0002B340
					public static GameObject LocomotionInputPanel_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/LocomotionInputPanel (1)");
						}
					}

					// Token: 0x0200031C RID: 796
					public class HoloportToggle_4
					{
						// Token: 0x1700079B RID: 1947
						// (get) Token: 0x06001048 RID: 4168 RVA: 0x00032D68 File Offset: 0x00030F68
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/HoloportToggle/Background");
							}
						}

						// Token: 0x1700079C RID: 1948
						// (get) Token: 0x06001049 RID: 4169 RVA: 0x00032D84 File Offset: 0x00030F84
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/HoloportToggle/Label");
							}
						}

						// Token: 0x020003EA RID: 1002
						public class Background_5
						{
							// Token: 0x17000925 RID: 2341
							// (get) Token: 0x060012A0 RID: 4768 RVA: 0x00036228 File Offset: 0x00034428
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/HoloportToggle/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x0200031D RID: 797
					public class ComfortTurnToggle_4
					{
						// Token: 0x1700079D RID: 1949
						// (get) Token: 0x0600104B RID: 4171 RVA: 0x00032DAC File Offset: 0x00030FAC
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/ComfortTurnToggle/Background");
							}
						}

						// Token: 0x1700079E RID: 1950
						// (get) Token: 0x0600104C RID: 4172 RVA: 0x00032DC8 File Offset: 0x00030FC8
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/ComfortTurnToggle/Label");
							}
						}

						// Token: 0x020003EB RID: 1003
						public class Background_5
						{
							// Token: 0x17000926 RID: 2342
							// (get) Token: 0x060012A2 RID: 4770 RVA: 0x00036250 File Offset: 0x00034450
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/ComfortTurnToggle/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x0200031E RID: 798
					public class PersonalSpaceToggle_4
					{
						// Token: 0x1700079F RID: 1951
						// (get) Token: 0x0600104E RID: 4174 RVA: 0x00032DF0 File Offset: 0x00030FF0
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/PersonalSpaceToggle/Background");
							}
						}

						// Token: 0x170007A0 RID: 1952
						// (get) Token: 0x0600104F RID: 4175 RVA: 0x00032E0C File Offset: 0x0003100C
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/PersonalSpaceToggle/Label");
							}
						}

						// Token: 0x020003EC RID: 1004
						public class Background_5
						{
							// Token: 0x17000927 RID: 2343
							// (get) Token: 0x060012A4 RID: 4772 RVA: 0x00036278 File Offset: 0x00034478
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/PersonalSpaceToggle/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x0200031F RID: 799
					public class AllowUntrustedURL_4
					{
						// Token: 0x170007A1 RID: 1953
						// (get) Token: 0x06001051 RID: 4177 RVA: 0x00032E34 File Offset: 0x00031034
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/AllowUntrustedURL/Background");
							}
						}

						// Token: 0x170007A2 RID: 1954
						// (get) Token: 0x06001052 RID: 4178 RVA: 0x00032E50 File Offset: 0x00031050
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/AllowUntrustedURL/Label");
							}
						}

						// Token: 0x020003ED RID: 1005
						public class Background_5
						{
							// Token: 0x17000928 RID: 2344
							// (get) Token: 0x060012A6 RID: 4774 RVA: 0x000362A0 File Offset: 0x000344A0
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/AllowUntrustedURL/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x02000320 RID: 800
					public class StreamerModeToggle_4
					{
						// Token: 0x170007A3 RID: 1955
						// (get) Token: 0x06001054 RID: 4180 RVA: 0x00032E78 File Offset: 0x00031078
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/StreamerModeToggle/Background");
							}
						}

						// Token: 0x170007A4 RID: 1956
						// (get) Token: 0x06001055 RID: 4181 RVA: 0x00032E94 File Offset: 0x00031094
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/StreamerModeToggle/Label");
							}
						}

						// Token: 0x170007A5 RID: 1957
						// (get) Token: 0x06001056 RID: 4182 RVA: 0x00032EB0 File Offset: 0x000310B0
						public static GameObject InfoButton
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/StreamerModeToggle/InfoButton");
							}
						}

						// Token: 0x020003EE RID: 1006
						public class Background_5
						{
							// Token: 0x17000929 RID: 2345
							// (get) Token: 0x060012A8 RID: 4776 RVA: 0x000362C8 File Offset: 0x000344C8
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/StreamerModeToggle/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x02000321 RID: 801
					public class MuteUsersToggle_4
					{
						// Token: 0x170007A6 RID: 1958
						// (get) Token: 0x06001058 RID: 4184 RVA: 0x00032ED8 File Offset: 0x000310D8
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/MuteUsersToggle/Background");
							}
						}

						// Token: 0x170007A7 RID: 1959
						// (get) Token: 0x06001059 RID: 4185 RVA: 0x00032EF4 File Offset: 0x000310F4
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/MuteUsersToggle/Label");
							}
						}

						// Token: 0x020003EF RID: 1007
						public class Background_5
						{
							// Token: 0x1700092A RID: 2346
							// (get) Token: 0x060012AA RID: 4778 RVA: 0x000362F0 File Offset: 0x000344F0
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/MuteUsersToggle/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x02000322 RID: 802
					public class BlockAvatarsToggle_4
					{
						// Token: 0x170007A8 RID: 1960
						// (get) Token: 0x0600105B RID: 4187 RVA: 0x00032F1C File Offset: 0x0003111C
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/BlockAvatarsToggle/Background");
							}
						}

						// Token: 0x170007A9 RID: 1961
						// (get) Token: 0x0600105C RID: 4188 RVA: 0x00032F38 File Offset: 0x00031138
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/BlockAvatarsToggle/Label");
							}
						}

						// Token: 0x020003F0 RID: 1008
						public class Background_5
						{
							// Token: 0x1700092B RID: 2347
							// (get) Token: 0x060012AC RID: 4780 RVA: 0x00036318 File Offset: 0x00034518
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/BlockAvatarsToggle/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x02000323 RID: 803
					public class HeadSetGazeToggle_4
					{
						// Token: 0x170007AA RID: 1962
						// (get) Token: 0x0600105E RID: 4190 RVA: 0x00032F60 File Offset: 0x00031160
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/HeadSetGazeToggle/Background");
							}
						}

						// Token: 0x170007AB RID: 1963
						// (get) Token: 0x0600105F RID: 4191 RVA: 0x00032F7C File Offset: 0x0003117C
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/HeadSetGazeToggle/Label");
							}
						}

						// Token: 0x020003F1 RID: 1009
						public class Background_5
						{
							// Token: 0x1700092C RID: 2348
							// (get) Token: 0x060012AE RID: 4782 RVA: 0x00036340 File Offset: 0x00034540
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/HeadSetGazeToggle/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x02000324 RID: 804
					public class KeyboardToggle_4
					{
						// Token: 0x170007AC RID: 1964
						// (get) Token: 0x06001061 RID: 4193 RVA: 0x00032FA4 File Offset: 0x000311A4
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/KeyboardToggle/Background");
							}
						}

						// Token: 0x170007AD RID: 1965
						// (get) Token: 0x06001062 RID: 4194 RVA: 0x00032FC0 File Offset: 0x000311C0
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/KeyboardToggle/Label");
							}
						}

						// Token: 0x020003F2 RID: 1010
						public class Background_5
						{
							// Token: 0x1700092D RID: 2349
							// (get) Token: 0x060012B0 RID: 4784 RVA: 0x00036368 File Offset: 0x00034568
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/KeyboardToggle/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x02000325 RID: 805
					public class GamepadToggle_4
					{
						// Token: 0x170007AE RID: 1966
						// (get) Token: 0x06001064 RID: 4196 RVA: 0x00032FE8 File Offset: 0x000311E8
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/GamepadToggle/Background");
							}
						}

						// Token: 0x170007AF RID: 1967
						// (get) Token: 0x06001065 RID: 4197 RVA: 0x00033004 File Offset: 0x00031204
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/GamepadToggle/Label");
							}
						}

						// Token: 0x020003F3 RID: 1011
						public class Background_5
						{
							// Token: 0x1700092E RID: 2350
							// (get) Token: 0x060012B2 RID: 4786 RVA: 0x00036390 File Offset: 0x00034590
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/ComfortSafetyPanel/GamepadToggle/Background/Checkmark");
								}
							}
						}
					}
				}

				// Token: 0x020001DC RID: 476
				public class AudioDevicePanel_3
				{
					// Token: 0x170004DB RID: 1243
					// (get) Token: 0x06000C48 RID: 3144 RVA: 0x0002D168 File Offset: 0x0002B368
					public static GameObject Panel_Header
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/AudioDevicePanel/Panel_Header");
						}
					}

					// Token: 0x170004DC RID: 1244
					// (get) Token: 0x06000C49 RID: 3145 RVA: 0x0002D184 File Offset: 0x0002B384
					public static GameObject TitleText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/AudioDevicePanel/TitleText");
						}
					}

					// Token: 0x170004DD RID: 1245
					// (get) Token: 0x06000C4A RID: 3146 RVA: 0x0002D1A0 File Offset: 0x0002B3A0
					public static GameObject LevelText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/AudioDevicePanel/LevelText");
						}
					}

					// Token: 0x170004DE RID: 1246
					// (get) Token: 0x06000C4B RID: 3147 RVA: 0x0002D1BC File Offset: 0x0002B3BC
					public static GameObject VolumeSlider
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/AudioDevicePanel/VolumeSlider");
						}
					}

					// Token: 0x170004DF RID: 1247
					// (get) Token: 0x06000C4C RID: 3148 RVA: 0x0002D1D8 File Offset: 0x0002B3D8
					public static GameObject VolumeDisplay
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/AudioDevicePanel/VolumeDisplay");
						}
					}

					// Token: 0x170004E0 RID: 1248
					// (get) Token: 0x06000C4D RID: 3149 RVA: 0x0002D1F4 File Offset: 0x0002B3F4
					public static GameObject SelectPrevMic
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/AudioDevicePanel/SelectPrevMic");
						}
					}

					// Token: 0x170004E1 RID: 1249
					// (get) Token: 0x06000C4E RID: 3150 RVA: 0x0002D210 File Offset: 0x0002B410
					public static GameObject SelectNextMic
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/AudioDevicePanel/SelectNextMic");
						}
					}

					// Token: 0x170004E2 RID: 1250
					// (get) Token: 0x06000C4F RID: 3151 RVA: 0x0002D22C File Offset: 0x0002B42C
					public static GameObject MicDeviceText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/AudioDevicePanel/MicDeviceText");
						}
					}

					// Token: 0x02000326 RID: 806
					public class VolumeSlider_4
					{
						// Token: 0x170007B0 RID: 1968
						// (get) Token: 0x06001067 RID: 4199 RVA: 0x0003302C File Offset: 0x0003122C
						public static GameObject Fill_Area
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/AudioDevicePanel/VolumeSlider/Fill Area");
							}
						}

						// Token: 0x020003F4 RID: 1012
						public class Fill_Area_5
						{
							// Token: 0x1700092F RID: 2351
							// (get) Token: 0x060012B4 RID: 4788 RVA: 0x000363B8 File Offset: 0x000345B8
							public static GameObject Fill
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/AudioDevicePanel/VolumeSlider/Fill Area/Fill");
								}
							}

							// Token: 0x17000930 RID: 2352
							// (get) Token: 0x060012B5 RID: 4789 RVA: 0x000363D4 File Offset: 0x000345D4
							public static GameObject Label
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/AudioDevicePanel/VolumeSlider/Fill Area/Label");
								}
							}
						}
					}

					// Token: 0x02000327 RID: 807
					public class VolumeDisplay_4
					{
						// Token: 0x170007B1 RID: 1969
						// (get) Token: 0x06001069 RID: 4201 RVA: 0x00033054 File Offset: 0x00031254
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/AudioDevicePanel/VolumeDisplay/Background");
							}
						}

						// Token: 0x170007B2 RID: 1970
						// (get) Token: 0x0600106A RID: 4202 RVA: 0x00033070 File Offset: 0x00031270
						public static GameObject Fill_Area
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/AudioDevicePanel/VolumeDisplay/Fill Area");
							}
						}

						// Token: 0x020003F5 RID: 1013
						public class Fill_Area_5
						{
							// Token: 0x17000931 RID: 2353
							// (get) Token: 0x060012B7 RID: 4791 RVA: 0x000363FC File Offset: 0x000345FC
							public static GameObject Fill
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/AudioDevicePanel/VolumeDisplay/Fill Area/Fill");
								}
							}
						}
					}
				}

				// Token: 0x020001DD RID: 477
				public class MousePanel_3
				{
					// Token: 0x170004E3 RID: 1251
					// (get) Token: 0x06000C51 RID: 3153 RVA: 0x0002D254 File Offset: 0x0002B454
					public static GameObject Panel_Header
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/MousePanel/Panel_Header");
						}
					}

					// Token: 0x170004E4 RID: 1252
					// (get) Token: 0x06000C52 RID: 3154 RVA: 0x0002D270 File Offset: 0x0002B470
					public static GameObject TitleText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/MousePanel/TitleText");
						}
					}

					// Token: 0x170004E5 RID: 1253
					// (get) Token: 0x06000C53 RID: 3155 RVA: 0x0002D28C File Offset: 0x0002B48C
					public static GameObject MouseSensitivityText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/MousePanel/MouseSensitivityText");
						}
					}

					// Token: 0x170004E6 RID: 1254
					// (get) Token: 0x06000C54 RID: 3156 RVA: 0x0002D2A8 File Offset: 0x0002B4A8
					public static GameObject SensitivitySlider
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/MousePanel/SensitivitySlider");
						}
					}

					// Token: 0x170004E7 RID: 1255
					// (get) Token: 0x06000C55 RID: 3157 RVA: 0x0002D2C4 File Offset: 0x0002B4C4
					public static GameObject InvertedMouse
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/MousePanel/InvertedMouse");
						}
					}

					// Token: 0x02000328 RID: 808
					public class SensitivitySlider_4
					{
						// Token: 0x170007B3 RID: 1971
						// (get) Token: 0x0600106C RID: 4204 RVA: 0x00033098 File Offset: 0x00031298
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/MousePanel/SensitivitySlider/Background");
							}
						}

						// Token: 0x170007B4 RID: 1972
						// (get) Token: 0x0600106D RID: 4205 RVA: 0x000330B4 File Offset: 0x000312B4
						public static GameObject Fill_Area
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/MousePanel/SensitivitySlider/Fill Area");
							}
						}

						// Token: 0x170007B5 RID: 1973
						// (get) Token: 0x0600106E RID: 4206 RVA: 0x000330D0 File Offset: 0x000312D0
						public static GameObject Handle_Slide_Area
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/MousePanel/SensitivitySlider/Handle Slide Area");
							}
						}

						// Token: 0x020003F6 RID: 1014
						public class Fill_Area_5
						{
							// Token: 0x17000932 RID: 2354
							// (get) Token: 0x060012B9 RID: 4793 RVA: 0x00036424 File Offset: 0x00034624
							public static GameObject Fill
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/MousePanel/SensitivitySlider/Fill Area/Fill");
								}
							}
						}

						// Token: 0x020003F7 RID: 1015
						public class Handle_Slide_Area_5
						{
							// Token: 0x17000933 RID: 2355
							// (get) Token: 0x060012BB RID: 4795 RVA: 0x0003644C File Offset: 0x0003464C
							public static GameObject Handle
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/MousePanel/SensitivitySlider/Handle Slide Area/Handle");
								}
							}
						}
					}

					// Token: 0x02000329 RID: 809
					public class InvertedMouse_4
					{
						// Token: 0x170007B6 RID: 1974
						// (get) Token: 0x06001070 RID: 4208 RVA: 0x000330F8 File Offset: 0x000312F8
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/MousePanel/InvertedMouse/Background");
							}
						}

						// Token: 0x170007B7 RID: 1975
						// (get) Token: 0x06001071 RID: 4209 RVA: 0x00033114 File Offset: 0x00031314
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/MousePanel/InvertedMouse/Label");
							}
						}

						// Token: 0x020003F8 RID: 1016
						public class Background_5
						{
							// Token: 0x17000934 RID: 2356
							// (get) Token: 0x060012BD RID: 4797 RVA: 0x00036474 File Offset: 0x00034674
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/MousePanel/InvertedMouse/Background/Checkmark");
								}
							}
						}
					}
				}

				// Token: 0x020001DE RID: 478
				public class HeightPanel_3
				{
					// Token: 0x170004E8 RID: 1256
					// (get) Token: 0x06000C57 RID: 3159 RVA: 0x0002D2EC File Offset: 0x0002B4EC
					public static GameObject Panel_Header
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/HeightPanel/Panel_Header");
						}
					}

					// Token: 0x170004E9 RID: 1257
					// (get) Token: 0x06000C58 RID: 3160 RVA: 0x0002D308 File Offset: 0x0002B508
					public static GameObject TitleText_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/HeightPanel/TitleText (1)");
						}
					}

					// Token: 0x170004EA RID: 1258
					// (get) Token: 0x06000C59 RID: 3161 RVA: 0x0002D324 File Offset: 0x0002B524
					public static GameObject HeightUP
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/HeightPanel/HeightUP");
						}
					}

					// Token: 0x170004EB RID: 1259
					// (get) Token: 0x06000C5A RID: 3162 RVA: 0x0002D340 File Offset: 0x0002B540
					public static GameObject HeightDOWN
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/HeightPanel/HeightDOWN");
						}
					}

					// Token: 0x170004EC RID: 1260
					// (get) Token: 0x06000C5B RID: 3163 RVA: 0x0002D35C File Offset: 0x0002B55C
					public static GameObject Label
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/HeightPanel/Label");
						}
					}
				}

				// Token: 0x020001DF RID: 479
				public class VoiceOptionsPanel_3
				{
					// Token: 0x170004ED RID: 1261
					// (get) Token: 0x06000C5D RID: 3165 RVA: 0x0002D384 File Offset: 0x0002B584
					public static GameObject Panel_Header
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VoiceOptionsPanel/Panel_Header");
						}
					}

					// Token: 0x170004EE RID: 1262
					// (get) Token: 0x06000C5E RID: 3166 RVA: 0x0002D3A0 File Offset: 0x0002B5A0
					public static GameObject TitleText_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VoiceOptionsPanel/TitleText (1)");
						}
					}

					// Token: 0x170004EF RID: 1263
					// (get) Token: 0x06000C5F RID: 3167 RVA: 0x0002D3BC File Offset: 0x0002B5BC
					public static GameObject HardwareConfigToggle_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VoiceOptionsPanel/HardwareConfigToggle (1)");
						}
					}

					// Token: 0x170004F0 RID: 1264
					// (get) Token: 0x06000C60 RID: 3168 RVA: 0x0002D3D8 File Offset: 0x0002B5D8
					public static GameObject HardwareConfigToggle_4
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VoiceOptionsPanel/HardwareConfigToggle (4)");
						}
					}

					// Token: 0x170004F1 RID: 1265
					// (get) Token: 0x06000C61 RID: 3169 RVA: 0x0002D3F4 File Offset: 0x0002B5F4
					public static GameObject HardwareConfigToggle_6
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VoiceOptionsPanel/HardwareConfigToggle (6)");
						}
					}

					// Token: 0x170004F2 RID: 1266
					// (get) Token: 0x06000C62 RID: 3170 RVA: 0x0002D410 File Offset: 0x0002B610
					public static GameObject HardwareConfigToggle_2
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VoiceOptionsPanel/HardwareConfigToggle (2)");
						}
					}

					// Token: 0x0200032A RID: 810
					public class HardwareConfigToggle_1_4
					{
						// Token: 0x170007B8 RID: 1976
						// (get) Token: 0x06001073 RID: 4211 RVA: 0x0003313C File Offset: 0x0003133C
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VoiceOptionsPanel/HardwareConfigToggle (1)/Background");
							}
						}

						// Token: 0x170007B9 RID: 1977
						// (get) Token: 0x06001074 RID: 4212 RVA: 0x00033158 File Offset: 0x00031358
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VoiceOptionsPanel/HardwareConfigToggle (1)/Label");
							}
						}

						// Token: 0x020003F9 RID: 1017
						public class Background_5
						{
							// Token: 0x17000935 RID: 2357
							// (get) Token: 0x060012BF RID: 4799 RVA: 0x0003649C File Offset: 0x0003469C
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VoiceOptionsPanel/HardwareConfigToggle (1)/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x0200032B RID: 811
					public class HardwareConfigToggle_4_4
					{
						// Token: 0x170007BA RID: 1978
						// (get) Token: 0x06001076 RID: 4214 RVA: 0x00033180 File Offset: 0x00031380
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VoiceOptionsPanel/HardwareConfigToggle (4)/Background");
							}
						}

						// Token: 0x170007BB RID: 1979
						// (get) Token: 0x06001077 RID: 4215 RVA: 0x0003319C File Offset: 0x0003139C
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VoiceOptionsPanel/HardwareConfigToggle (4)/Label");
							}
						}

						// Token: 0x020003FA RID: 1018
						public class Background_5
						{
							// Token: 0x17000936 RID: 2358
							// (get) Token: 0x060012C1 RID: 4801 RVA: 0x000364C4 File Offset: 0x000346C4
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VoiceOptionsPanel/HardwareConfigToggle (4)/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x0200032C RID: 812
					public class HardwareConfigToggle_6_4
					{
						// Token: 0x170007BC RID: 1980
						// (get) Token: 0x06001079 RID: 4217 RVA: 0x000331C4 File Offset: 0x000313C4
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VoiceOptionsPanel/HardwareConfigToggle (6)/Background");
							}
						}

						// Token: 0x170007BD RID: 1981
						// (get) Token: 0x0600107A RID: 4218 RVA: 0x000331E0 File Offset: 0x000313E0
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VoiceOptionsPanel/HardwareConfigToggle (6)/Label");
							}
						}

						// Token: 0x020003FB RID: 1019
						public class Background_5
						{
							// Token: 0x17000937 RID: 2359
							// (get) Token: 0x060012C3 RID: 4803 RVA: 0x000364EC File Offset: 0x000346EC
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VoiceOptionsPanel/HardwareConfigToggle (6)/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x0200032D RID: 813
					public class HardwareConfigToggle_2_4
					{
						// Token: 0x170007BE RID: 1982
						// (get) Token: 0x0600107C RID: 4220 RVA: 0x00033208 File Offset: 0x00031408
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VoiceOptionsPanel/HardwareConfigToggle (2)/Background");
							}
						}

						// Token: 0x170007BF RID: 1983
						// (get) Token: 0x0600107D RID: 4221 RVA: 0x00033224 File Offset: 0x00031424
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VoiceOptionsPanel/HardwareConfigToggle (2)/Label");
							}
						}

						// Token: 0x020003FC RID: 1020
						public class Background_5
						{
							// Token: 0x17000938 RID: 2360
							// (get) Token: 0x060012C5 RID: 4805 RVA: 0x00036514 File Offset: 0x00034714
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VoiceOptionsPanel/HardwareConfigToggle (2)/Background/Checkmark");
								}
							}
						}
					}
				}

				// Token: 0x020001E0 RID: 480
				public class OtherOptionsPanel_3
				{
					// Token: 0x170004F3 RID: 1267
					// (get) Token: 0x06000C64 RID: 3172 RVA: 0x0002D438 File Offset: 0x0002B638
					public static GameObject Panel_Header_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/OtherOptionsPanel/Panel_Header (1)");
						}
					}

					// Token: 0x170004F4 RID: 1268
					// (get) Token: 0x06000C65 RID: 3173 RVA: 0x0002D454 File Offset: 0x0002B654
					public static GameObject TitleText_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/OtherOptionsPanel/TitleText (1)");
						}
					}

					// Token: 0x170004F5 RID: 1269
					// (get) Token: 0x06000C66 RID: 3174 RVA: 0x0002D470 File Offset: 0x0002B670
					public static GameObject HeadLookToggle
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/OtherOptionsPanel/HeadLookToggle");
						}
					}

					// Token: 0x170004F6 RID: 1270
					// (get) Token: 0x06000C67 RID: 3175 RVA: 0x0002D48C File Offset: 0x0002B68C
					public static GameObject TooltipsToggle
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/OtherOptionsPanel/TooltipsToggle");
						}
					}

					// Token: 0x170004F7 RID: 1271
					// (get) Token: 0x06000C68 RID: 3176 RVA: 0x0002D4A8 File Offset: 0x0002B6A8
					public static GameObject PRotationToggle
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/OtherOptionsPanel/3PRotationToggle");
						}
					}

					// Token: 0x170004F8 RID: 1272
					// (get) Token: 0x06000C69 RID: 3177 RVA: 0x0002D4C4 File Offset: 0x0002B6C4
					public static GameObject ViveAdvancedToggle
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/OtherOptionsPanel/ViveAdvancedToggle");
						}
					}

					// Token: 0x170004F9 RID: 1273
					// (get) Token: 0x06000C6A RID: 3178 RVA: 0x0002D4E0 File Offset: 0x0002B6E0
					public static GameObject SkipGoButtonInLoad
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/OtherOptionsPanel/SkipGoButtonInLoad");
						}
					}

					// Token: 0x170004FA RID: 1274
					// (get) Token: 0x06000C6B RID: 3179 RVA: 0x0002D4FC File Offset: 0x0002B6FC
					public static GameObject DesktopReticle
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/OtherOptionsPanel/DesktopReticle");
						}
					}

					// Token: 0x170004FB RID: 1275
					// (get) Token: 0x06000C6C RID: 3180 RVA: 0x0002D518 File Offset: 0x0002B718
					public static GameObject AllowAvatarCopyingToggle
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/OtherOptionsPanel/AllowAvatarCopyingToggle");
						}
					}

					// Token: 0x170004FC RID: 1276
					// (get) Token: 0x06000C6D RID: 3181 RVA: 0x0002D534 File Offset: 0x0002B734
					public static GameObject ShowCommunityLabsToggle
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/OtherOptionsPanel/ShowCommunityLabsToggle");
						}
					}

					// Token: 0x0200032E RID: 814
					public class HeadLookToggle_4
					{
						// Token: 0x170007C0 RID: 1984
						// (get) Token: 0x0600107F RID: 4223 RVA: 0x0003324C File Offset: 0x0003144C
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/OtherOptionsPanel/HeadLookToggle/Background");
							}
						}

						// Token: 0x170007C1 RID: 1985
						// (get) Token: 0x06001080 RID: 4224 RVA: 0x00033268 File Offset: 0x00031468
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/OtherOptionsPanel/HeadLookToggle/Label");
							}
						}

						// Token: 0x020003FD RID: 1021
						public class Background_5
						{
							// Token: 0x17000939 RID: 2361
							// (get) Token: 0x060012C7 RID: 4807 RVA: 0x0003653C File Offset: 0x0003473C
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/OtherOptionsPanel/HeadLookToggle/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x0200032F RID: 815
					public class TooltipsToggle_4
					{
						// Token: 0x170007C2 RID: 1986
						// (get) Token: 0x06001082 RID: 4226 RVA: 0x00033290 File Offset: 0x00031490
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/OtherOptionsPanel/TooltipsToggle/Background");
							}
						}

						// Token: 0x170007C3 RID: 1987
						// (get) Token: 0x06001083 RID: 4227 RVA: 0x000332AC File Offset: 0x000314AC
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/OtherOptionsPanel/TooltipsToggle/Label");
							}
						}

						// Token: 0x020003FE RID: 1022
						public class Background_5
						{
							// Token: 0x1700093A RID: 2362
							// (get) Token: 0x060012C9 RID: 4809 RVA: 0x00036564 File Offset: 0x00034764
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/OtherOptionsPanel/TooltipsToggle/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x02000330 RID: 816
					public class PRotationToggle_4
					{
						// Token: 0x170007C4 RID: 1988
						// (get) Token: 0x06001085 RID: 4229 RVA: 0x000332D4 File Offset: 0x000314D4
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/OtherOptionsPanel/3PRotationToggle/Background");
							}
						}

						// Token: 0x170007C5 RID: 1989
						// (get) Token: 0x06001086 RID: 4230 RVA: 0x000332F0 File Offset: 0x000314F0
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/OtherOptionsPanel/3PRotationToggle/Label");
							}
						}

						// Token: 0x020003FF RID: 1023
						public class Background_5
						{
							// Token: 0x1700093B RID: 2363
							// (get) Token: 0x060012CB RID: 4811 RVA: 0x0003658C File Offset: 0x0003478C
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/OtherOptionsPanel/3PRotationToggle/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x02000331 RID: 817
					public class ViveAdvancedToggle_4
					{
						// Token: 0x170007C6 RID: 1990
						// (get) Token: 0x06001088 RID: 4232 RVA: 0x00033318 File Offset: 0x00031518
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/OtherOptionsPanel/ViveAdvancedToggle/Background");
							}
						}

						// Token: 0x170007C7 RID: 1991
						// (get) Token: 0x06001089 RID: 4233 RVA: 0x00033334 File Offset: 0x00031534
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/OtherOptionsPanel/ViveAdvancedToggle/Label");
							}
						}

						// Token: 0x02000400 RID: 1024
						public class Background_5
						{
							// Token: 0x1700093C RID: 2364
							// (get) Token: 0x060012CD RID: 4813 RVA: 0x000365B4 File Offset: 0x000347B4
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/OtherOptionsPanel/ViveAdvancedToggle/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x02000332 RID: 818
					public class SkipGoButtonInLoad_4
					{
						// Token: 0x170007C8 RID: 1992
						// (get) Token: 0x0600108B RID: 4235 RVA: 0x0003335C File Offset: 0x0003155C
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/OtherOptionsPanel/SkipGoButtonInLoad/Background");
							}
						}

						// Token: 0x170007C9 RID: 1993
						// (get) Token: 0x0600108C RID: 4236 RVA: 0x00033378 File Offset: 0x00031578
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/OtherOptionsPanel/SkipGoButtonInLoad/Label");
							}
						}

						// Token: 0x02000401 RID: 1025
						public class Background_5
						{
							// Token: 0x1700093D RID: 2365
							// (get) Token: 0x060012CF RID: 4815 RVA: 0x000365DC File Offset: 0x000347DC
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/OtherOptionsPanel/SkipGoButtonInLoad/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x02000333 RID: 819
					public class DesktopReticle_4
					{
						// Token: 0x170007CA RID: 1994
						// (get) Token: 0x0600108E RID: 4238 RVA: 0x000333A0 File Offset: 0x000315A0
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/OtherOptionsPanel/DesktopReticle/Background");
							}
						}

						// Token: 0x170007CB RID: 1995
						// (get) Token: 0x0600108F RID: 4239 RVA: 0x000333BC File Offset: 0x000315BC
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/OtherOptionsPanel/DesktopReticle/Label");
							}
						}

						// Token: 0x02000402 RID: 1026
						public class Background_5
						{
							// Token: 0x1700093E RID: 2366
							// (get) Token: 0x060012D1 RID: 4817 RVA: 0x00036604 File Offset: 0x00034804
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/OtherOptionsPanel/DesktopReticle/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x02000334 RID: 820
					public class AllowAvatarCopyingToggle_4
					{
						// Token: 0x170007CC RID: 1996
						// (get) Token: 0x06001091 RID: 4241 RVA: 0x000333E4 File Offset: 0x000315E4
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/OtherOptionsPanel/AllowAvatarCopyingToggle/Background");
							}
						}

						// Token: 0x170007CD RID: 1997
						// (get) Token: 0x06001092 RID: 4242 RVA: 0x00033400 File Offset: 0x00031600
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/OtherOptionsPanel/AllowAvatarCopyingToggle/Label");
							}
						}

						// Token: 0x02000403 RID: 1027
						public class Background_5
						{
							// Token: 0x1700093F RID: 2367
							// (get) Token: 0x060012D3 RID: 4819 RVA: 0x0003662C File Offset: 0x0003482C
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/OtherOptionsPanel/AllowAvatarCopyingToggle/Background/Checkmark");
								}
							}
						}
					}

					// Token: 0x02000335 RID: 821
					public class ShowCommunityLabsToggle_4
					{
						// Token: 0x170007CE RID: 1998
						// (get) Token: 0x06001094 RID: 4244 RVA: 0x00033428 File Offset: 0x00031628
						public static GameObject Background
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/OtherOptionsPanel/ShowCommunityLabsToggle/Background");
							}
						}

						// Token: 0x170007CF RID: 1999
						// (get) Token: 0x06001095 RID: 4245 RVA: 0x00033444 File Offset: 0x00031644
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/OtherOptionsPanel/ShowCommunityLabsToggle/Label");
							}
						}

						// Token: 0x02000404 RID: 1028
						public class Background_5
						{
							// Token: 0x17000940 RID: 2368
							// (get) Token: 0x060012D5 RID: 4821 RVA: 0x00036654 File Offset: 0x00034854
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/OtherOptionsPanel/ShowCommunityLabsToggle/Background/Checkmark");
								}
							}
						}
					}
				}

				// Token: 0x020001E1 RID: 481
				public class VolumePanel_3
				{
					// Token: 0x170004FD RID: 1277
					// (get) Token: 0x06000C6F RID: 3183 RVA: 0x0002D55C File Offset: 0x0002B75C
					public static GameObject Panel_Header_Top
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VolumePanel/Panel_Header Top");
						}
					}

					// Token: 0x170004FE RID: 1278
					// (get) Token: 0x06000C70 RID: 3184 RVA: 0x0002D578 File Offset: 0x0002B778
					public static GameObject Panel_Header_Side
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VolumePanel/Panel_Header Side");
						}
					}

					// Token: 0x170004FF RID: 1279
					// (get) Token: 0x06000C71 RID: 3185 RVA: 0x0002D594 File Offset: 0x0002B794
					public static GameObject TitleText_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VolumePanel/TitleText (1)");
						}
					}

					// Token: 0x17000500 RID: 1280
					// (get) Token: 0x06000C72 RID: 3186 RVA: 0x0002D5B0 File Offset: 0x0002B7B0
					public static GameObject VolumeMaster
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VolumePanel/VolumeMaster");
						}
					}

					// Token: 0x17000501 RID: 1281
					// (get) Token: 0x06000C73 RID: 3187 RVA: 0x0002D5CC File Offset: 0x0002B7CC
					public static GameObject VolumeUi
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VolumePanel/VolumeUi");
						}
					}

					// Token: 0x17000502 RID: 1282
					// (get) Token: 0x06000C74 RID: 3188 RVA: 0x0002D5E8 File Offset: 0x0002B7E8
					public static GameObject VolumeGameWorld
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VolumePanel/VolumeGameWorld");
						}
					}

					// Token: 0x17000503 RID: 1283
					// (get) Token: 0x06000C75 RID: 3189 RVA: 0x0002D604 File Offset: 0x0002B804
					public static GameObject VolumeGameVoice
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VolumePanel/VolumeGameVoice");
						}
					}

					// Token: 0x17000504 RID: 1284
					// (get) Token: 0x06000C76 RID: 3190 RVA: 0x0002D620 File Offset: 0x0002B820
					public static GameObject VolumeGameAvatars
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VolumePanel/VolumeGameAvatars");
						}
					}

					// Token: 0x02000336 RID: 822
					public class VolumeMaster_4
					{
						// Token: 0x170007D0 RID: 2000
						// (get) Token: 0x06001097 RID: 4247 RVA: 0x0003346C File Offset: 0x0003166C
						public static GameObject FillArea
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VolumePanel/VolumeMaster/FillArea");
							}
						}

						// Token: 0x170007D1 RID: 2001
						// (get) Token: 0x06001098 RID: 4248 RVA: 0x00033488 File Offset: 0x00031688
						public static GameObject SliderLabel
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VolumePanel/VolumeMaster/SliderLabel");
							}
						}

						// Token: 0x170007D2 RID: 2002
						// (get) Token: 0x06001099 RID: 4249 RVA: 0x000334A4 File Offset: 0x000316A4
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VolumePanel/VolumeMaster/Label");
							}
						}

						// Token: 0x02000405 RID: 1029
						public class FillArea_5
						{
							// Token: 0x17000941 RID: 2369
							// (get) Token: 0x060012D7 RID: 4823 RVA: 0x0003667C File Offset: 0x0003487C
							public static GameObject Fill
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VolumePanel/VolumeMaster/FillArea/Fill");
								}
							}
						}
					}

					// Token: 0x02000337 RID: 823
					public class VolumeUi_4
					{
						// Token: 0x170007D3 RID: 2003
						// (get) Token: 0x0600109B RID: 4251 RVA: 0x000334CC File Offset: 0x000316CC
						public static GameObject FillArea
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VolumePanel/VolumeUi/FillArea");
							}
						}

						// Token: 0x170007D4 RID: 2004
						// (get) Token: 0x0600109C RID: 4252 RVA: 0x000334E8 File Offset: 0x000316E8
						public static GameObject SliderLabel
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VolumePanel/VolumeUi/SliderLabel");
							}
						}

						// Token: 0x170007D5 RID: 2005
						// (get) Token: 0x0600109D RID: 4253 RVA: 0x00033504 File Offset: 0x00031704
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VolumePanel/VolumeUi/Label");
							}
						}

						// Token: 0x02000406 RID: 1030
						public class FillArea_5
						{
							// Token: 0x17000942 RID: 2370
							// (get) Token: 0x060012D9 RID: 4825 RVA: 0x000366A4 File Offset: 0x000348A4
							public static GameObject Fill
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VolumePanel/VolumeUi/FillArea/Fill");
								}
							}
						}
					}

					// Token: 0x02000338 RID: 824
					public class VolumeGameWorld_4
					{
						// Token: 0x170007D6 RID: 2006
						// (get) Token: 0x0600109F RID: 4255 RVA: 0x0003352C File Offset: 0x0003172C
						public static GameObject FillArea
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VolumePanel/VolumeGameWorld/FillArea");
							}
						}

						// Token: 0x170007D7 RID: 2007
						// (get) Token: 0x060010A0 RID: 4256 RVA: 0x00033548 File Offset: 0x00031748
						public static GameObject SliderLabel
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VolumePanel/VolumeGameWorld/SliderLabel");
							}
						}

						// Token: 0x170007D8 RID: 2008
						// (get) Token: 0x060010A1 RID: 4257 RVA: 0x00033564 File Offset: 0x00031764
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VolumePanel/VolumeGameWorld/Label");
							}
						}

						// Token: 0x02000407 RID: 1031
						public class FillArea_5
						{
							// Token: 0x17000943 RID: 2371
							// (get) Token: 0x060012DB RID: 4827 RVA: 0x000366CC File Offset: 0x000348CC
							public static GameObject Fill
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VolumePanel/VolumeGameWorld/FillArea/Fill");
								}
							}
						}
					}

					// Token: 0x02000339 RID: 825
					public class VolumeGameVoice_4
					{
						// Token: 0x170007D9 RID: 2009
						// (get) Token: 0x060010A3 RID: 4259 RVA: 0x0003358C File Offset: 0x0003178C
						public static GameObject FillArea
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VolumePanel/VolumeGameVoice/FillArea");
							}
						}

						// Token: 0x170007DA RID: 2010
						// (get) Token: 0x060010A4 RID: 4260 RVA: 0x000335A8 File Offset: 0x000317A8
						public static GameObject SliderLabel
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VolumePanel/VolumeGameVoice/SliderLabel");
							}
						}

						// Token: 0x170007DB RID: 2011
						// (get) Token: 0x060010A5 RID: 4261 RVA: 0x000335C4 File Offset: 0x000317C4
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VolumePanel/VolumeGameVoice/Label");
							}
						}

						// Token: 0x02000408 RID: 1032
						public class FillArea_5
						{
							// Token: 0x17000944 RID: 2372
							// (get) Token: 0x060012DD RID: 4829 RVA: 0x000366F4 File Offset: 0x000348F4
							public static GameObject Fill
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VolumePanel/VolumeGameVoice/FillArea/Fill");
								}
							}
						}
					}

					// Token: 0x0200033A RID: 826
					public class VolumeGameAvatars_4
					{
						// Token: 0x170007DC RID: 2012
						// (get) Token: 0x060010A7 RID: 4263 RVA: 0x000335EC File Offset: 0x000317EC
						public static GameObject FillArea
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VolumePanel/VolumeGameAvatars/FillArea");
							}
						}

						// Token: 0x170007DD RID: 2013
						// (get) Token: 0x060010A8 RID: 4264 RVA: 0x00033608 File Offset: 0x00031808
						public static GameObject SliderLabel
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VolumePanel/VolumeGameAvatars/SliderLabel");
							}
						}

						// Token: 0x170007DE RID: 2014
						// (get) Token: 0x060010A9 RID: 4265 RVA: 0x00033624 File Offset: 0x00031824
						public static GameObject Label
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VolumePanel/VolumeGameAvatars/Label");
							}
						}

						// Token: 0x02000409 RID: 1033
						public class FillArea_5
						{
							// Token: 0x17000945 RID: 2373
							// (get) Token: 0x060012DF RID: 4831 RVA: 0x0003671C File Offset: 0x0003491C
							public static GameObject Fill
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/VolumePanel/VolumeGameAvatars/FillArea/Fill");
								}
							}
						}
					}
				}

				// Token: 0x020001E2 RID: 482
				public class Footer_3
				{
					// Token: 0x17000505 RID: 1285
					// (get) Token: 0x06000C78 RID: 3192 RVA: 0x0002D648 File Offset: 0x0002B848
					public static GameObject Logout
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/Footer/Logout");
						}
					}

					// Token: 0x17000506 RID: 1286
					// (get) Token: 0x06000C79 RID: 3193 RVA: 0x0002D664 File Offset: 0x0002B864
					public static GameObject Exit
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/Footer/Exit");
						}
					}

					// Token: 0x17000507 RID: 1287
					// (get) Token: 0x06000C7A RID: 3194 RVA: 0x0002D680 File Offset: 0x0002B880
					public static GameObject NameText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/Footer/NameText");
						}
					}

					// Token: 0x17000508 RID: 1288
					// (get) Token: 0x06000C7B RID: 3195 RVA: 0x0002D69C File Offset: 0x0002B89C
					public static GameObject UpgradeAccount
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/Footer/UpgradeAccount");
						}
					}

					// Token: 0x0200033B RID: 827
					public class Logout_4
					{
						// Token: 0x170007DF RID: 2015
						// (get) Token: 0x060010AB RID: 4267 RVA: 0x0003364C File Offset: 0x0003184C
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/Footer/Logout/Text");
							}
						}
					}

					// Token: 0x0200033C RID: 828
					public class Exit_4
					{
						// Token: 0x170007E0 RID: 2016
						// (get) Token: 0x060010AD RID: 4269 RVA: 0x00033674 File Offset: 0x00031874
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/Footer/Exit/Text");
							}
						}
					}

					// Token: 0x0200033D RID: 829
					public class UpgradeAccount_4
					{
						// Token: 0x170007E1 RID: 2017
						// (get) Token: 0x060010AF RID: 4271 RVA: 0x0003369C File Offset: 0x0003189C
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/Footer/UpgradeAccount/Text");
							}
						}
					}
				}

				// Token: 0x020001E3 RID: 483
				public class Button_AdvancedOptions_3
				{
					// Token: 0x17000509 RID: 1289
					// (get) Token: 0x06000C7D RID: 3197 RVA: 0x0002D6C4 File Offset: 0x0002B8C4
					public static GameObject Text
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/Button_AdvancedOptions/Text");
						}
					}
				}

				// Token: 0x020001E4 RID: 484
				public class Button_EditBindings_3
				{
					// Token: 0x1700050A RID: 1290
					// (get) Token: 0x06000C7F RID: 3199 RVA: 0x0002D6EC File Offset: 0x0002B8EC
					public static GameObject Image_NEW
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/Button_EditBindings/Image_NEW");
						}
					}

					// Token: 0x1700050B RID: 1291
					// (get) Token: 0x06000C80 RID: 3200 RVA: 0x0002D708 File Offset: 0x0002B908
					public static GameObject Text
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/Button_EditBindings/Text");
						}
					}
				}

				// Token: 0x020001E5 RID: 485
				public class UserVolumeOptions_3
				{
					// Token: 0x1700050C RID: 1292
					// (get) Token: 0x06000C82 RID: 3202 RVA: 0x0002D730 File Offset: 0x0002B930
					public static GameObject Panel_Header_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/UserVolumeOptions/Panel_Header (1)");
						}
					}

					// Token: 0x1700050D RID: 1293
					// (get) Token: 0x06000C83 RID: 3203 RVA: 0x0002D74C File Offset: 0x0002B94C
					public static GameObject TitleText_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/UserVolumeOptions/TitleText (1)");
						}
					}

					// Token: 0x1700050E RID: 1294
					// (get) Token: 0x06000C84 RID: 3204 RVA: 0x0002D768 File Offset: 0x0002B968
					public static GameObject Button_ClearChanges
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/UserVolumeOptions/Button_ClearChanges");
						}
					}

					// Token: 0x0200033E RID: 830
					public class Button_ClearChanges_4
					{
						// Token: 0x170007E2 RID: 2018
						// (get) Token: 0x060010B1 RID: 4273 RVA: 0x000336C4 File Offset: 0x000318C4
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Screens/Menu_wqoRd0Fot3fW91RAccountswqoRd0Fot3fW91R/UserVolumeOptions/Button_ClearChanges/Text");
							}
						}
					}
				}
			}
		}

		// Token: 0x020000AE RID: 174
		public class Popups_1
		{
			// Token: 0x17000137 RID: 311
			// (get) Token: 0x060006F5 RID: 1781 RVA: 0x000244A8 File Offset: 0x000226A8
			public static GameObject AddToAvatarFavoritesPopup
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Popups/AddToAvatarFavoritesPopup");
				}
			}

			// Token: 0x17000138 RID: 312
			// (get) Token: 0x060006F6 RID: 1782 RVA: 0x000244C4 File Offset: 0x000226C4
			public static GameObject AddToPlaylistPopup
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Popups/AddToPlaylistPopup");
				}
			}

			// Token: 0x17000139 RID: 313
			// (get) Token: 0x060006F7 RID: 1783 RVA: 0x000244E0 File Offset: 0x000226E0
			public static GameObject AddInviteMessagePopup
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Popups/AddInviteMessagePopup");
				}
			}

			// Token: 0x1700013A RID: 314
			// (get) Token: 0x060006F8 RID: 1784 RVA: 0x000244FC File Offset: 0x000226FC
			public static GameObject AlertPopup
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Popups/AlertPopup");
				}
			}

			// Token: 0x1700013B RID: 315
			// (get) Token: 0x060006F9 RID: 1785 RVA: 0x00024518 File Offset: 0x00022718
			public static GameObject CreateUserIconFromImagePopup
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup");
				}
			}

			// Token: 0x1700013C RID: 316
			// (get) Token: 0x060006FA RID: 1786 RVA: 0x00024534 File Offset: 0x00022734
			public static GameObject BookmarkFriendPopup
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Popups/BookmarkFriendPopup");
				}
			}

			// Token: 0x1700013D RID: 317
			// (get) Token: 0x060006FB RID: 1787 RVA: 0x00024550 File Offset: 0x00022750
			public static GameObject ClearPlaylistPopup
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Popups/ClearPlaylistPopup");
				}
			}

			// Token: 0x1700013E RID: 318
			// (get) Token: 0x060006FC RID: 1788 RVA: 0x0002456C File Offset: 0x0002276C
			public static GameObject CommunityLabsPopup
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Popups/CommunityLabsPopup");
				}
			}

			// Token: 0x1700013F RID: 319
			// (get) Token: 0x060006FD RID: 1789 RVA: 0x00024588 File Offset: 0x00022788
			public static GameObject DatePopup
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup");
				}
			}

			// Token: 0x17000140 RID: 320
			// (get) Token: 0x060006FE RID: 1790 RVA: 0x000245A4 File Offset: 0x000227A4
			public static GameObject EditPlaylistPopup
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Popups/EditPlaylistPopup");
				}
			}

			// Token: 0x17000141 RID: 321
			// (get) Token: 0x060006FF RID: 1791 RVA: 0x000245C0 File Offset: 0x000227C0
			public static GameObject LoadingPopup
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup");
				}
			}

			// Token: 0x17000142 RID: 322
			// (get) Token: 0x06000700 RID: 1792 RVA: 0x000245DC File Offset: 0x000227DC
			public static GameObject ReportWorldPopup
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup");
				}
			}

			// Token: 0x17000143 RID: 323
			// (get) Token: 0x06000701 RID: 1793 RVA: 0x000245F8 File Offset: 0x000227F8
			public static GameObject RoomInfoPopup
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInfoPopup");
				}
			}

			// Token: 0x17000144 RID: 324
			// (get) Token: 0x06000702 RID: 1794 RVA: 0x00024614 File Offset: 0x00022814
			public static GameObject RoomInstancePopup
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup");
				}
			}

			// Token: 0x17000145 RID: 325
			// (get) Token: 0x06000703 RID: 1795 RVA: 0x00024630 File Offset: 0x00022830
			public static GameObject SearchOptionsPopup
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Popups/SearchOptionsPopup");
				}
			}

			// Token: 0x17000146 RID: 326
			// (get) Token: 0x06000704 RID: 1796 RVA: 0x0002464C File Offset: 0x0002284C
			public static GameObject StandardPopup
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup");
				}
			}

			// Token: 0x17000147 RID: 327
			// (get) Token: 0x06000705 RID: 1797 RVA: 0x00024668 File Offset: 0x00022868
			public static GameObject StandardPopupV2
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopupV2");
				}
			}

			// Token: 0x17000148 RID: 328
			// (get) Token: 0x06000706 RID: 1798 RVA: 0x00024684 File Offset: 0x00022884
			public static GameObject ReportUserPopup
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup");
				}
			}

			// Token: 0x17000149 RID: 329
			// (get) Token: 0x06000707 RID: 1799 RVA: 0x000246A0 File Offset: 0x000228A0
			public static GameObject UpdateStatusPopup
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup");
				}
			}

			// Token: 0x1700014A RID: 330
			// (get) Token: 0x06000708 RID: 1800 RVA: 0x000246BC File Offset: 0x000228BC
			public static GameObject RequestInvitePopup
			{
				get
				{
					return GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup");
				}
			}

			// Token: 0x02000101 RID: 257
			public class AddToAvatarFavoritesPopup_2
			{
				// Token: 0x1700024A RID: 586
				// (get) Token: 0x060008D3 RID: 2259 RVA: 0x00027F2C File Offset: 0x0002612C
				public static GameObject Darkness
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/AddToAvatarFavoritesPopup/Darkness");
					}
				}

				// Token: 0x1700024B RID: 587
				// (get) Token: 0x060008D4 RID: 2260 RVA: 0x00027F48 File Offset: 0x00026148
				public static GameObject Popup
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/AddToAvatarFavoritesPopup/Popup");
					}
				}

				// Token: 0x020001E6 RID: 486
				public class Popup_3
				{
					// Token: 0x1700050F RID: 1295
					// (get) Token: 0x06000C86 RID: 3206 RVA: 0x0002D790 File Offset: 0x0002B990
					public static GameObject BorderImage
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/AddToAvatarFavoritesPopup/Popup/BorderImage");
						}
					}

					// Token: 0x17000510 RID: 1296
					// (get) Token: 0x06000C87 RID: 3207 RVA: 0x0002D7AC File Offset: 0x0002B9AC
					public static GameObject Panel
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/AddToAvatarFavoritesPopup/Popup/Panel");
						}
					}

					// Token: 0x17000511 RID: 1297
					// (get) Token: 0x06000C88 RID: 3208 RVA: 0x0002D7C8 File Offset: 0x0002B9C8
					public static GameObject InstanceText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/AddToAvatarFavoritesPopup/Popup/InstanceText");
						}
					}

					// Token: 0x17000512 RID: 1298
					// (get) Token: 0x06000C89 RID: 3209 RVA: 0x0002D7E4 File Offset: 0x0002B9E4
					public static GameObject Checkboxes
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/AddToAvatarFavoritesPopup/Popup/Checkboxes");
						}
					}

					// Token: 0x17000513 RID: 1299
					// (get) Token: 0x06000C8A RID: 3210 RVA: 0x0002D800 File Offset: 0x0002BA00
					public static GameObject AddButton
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/AddToAvatarFavoritesPopup/Popup/AddButton");
						}
					}

					// Token: 0x17000514 RID: 1300
					// (get) Token: 0x06000C8B RID: 3211 RVA: 0x0002D81C File Offset: 0x0002BA1C
					public static GameObject ExitButton
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/AddToAvatarFavoritesPopup/Popup/ExitButton");
						}
					}

					// Token: 0x0200033F RID: 831
					public class Checkboxes_4
					{
						// Token: 0x170007E3 RID: 2019
						// (get) Token: 0x060010B3 RID: 4275 RVA: 0x000336EC File Offset: 0x000318EC
						public static GameObject Favorites1
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/AddToAvatarFavoritesPopup/Popup/Checkboxes/Favorites1");
							}
						}

						// Token: 0x170007E4 RID: 2020
						// (get) Token: 0x060010B4 RID: 4276 RVA: 0x00033708 File Offset: 0x00031908
						public static GameObject Favorites2
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/AddToAvatarFavoritesPopup/Popup/Checkboxes/Favorites2");
							}
						}

						// Token: 0x170007E5 RID: 2021
						// (get) Token: 0x060010B5 RID: 4277 RVA: 0x00033724 File Offset: 0x00031924
						public static GameObject Favorites
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/AddToAvatarFavoritesPopup/Popup/Checkboxes/Favorites3");
							}
						}

						// Token: 0x170007E6 RID: 2022
						// (get) Token: 0x060010B6 RID: 4278 RVA: 0x00033740 File Offset: 0x00031940
						public static GameObject Favorites4
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/AddToAvatarFavoritesPopup/Popup/Checkboxes/Favorites4");
							}
						}

						// Token: 0x0200040A RID: 1034
						public class Favorites1_5
						{
							// Token: 0x17000946 RID: 2374
							// (get) Token: 0x060012E1 RID: 4833 RVA: 0x00036744 File Offset: 0x00034944
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/AddToAvatarFavoritesPopup/Popup/Checkboxes/Favorites1/Checkmark");
								}
							}

							// Token: 0x17000947 RID: 2375
							// (get) Token: 0x060012E2 RID: 4834 RVA: 0x00036760 File Offset: 0x00034960
							public static GameObject Description
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/AddToAvatarFavoritesPopup/Popup/Checkboxes/Favorites1/Description");
								}
							}
						}

						// Token: 0x0200040B RID: 1035
						public class Favorites2_5
						{
							// Token: 0x17000948 RID: 2376
							// (get) Token: 0x060012E4 RID: 4836 RVA: 0x00036788 File Offset: 0x00034988
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/AddToAvatarFavoritesPopup/Popup/Checkboxes/Favorites2/Checkmark");
								}
							}

							// Token: 0x17000949 RID: 2377
							// (get) Token: 0x060012E5 RID: 4837 RVA: 0x000367A4 File Offset: 0x000349A4
							public static GameObject Description
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/AddToAvatarFavoritesPopup/Popup/Checkboxes/Favorites2/Description");
								}
							}
						}

						// Token: 0x0200040C RID: 1036
						public class Favorites_5
						{
							// Token: 0x1700094A RID: 2378
							// (get) Token: 0x060012E7 RID: 4839 RVA: 0x000367CC File Offset: 0x000349CC
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/AddToAvatarFavoritesPopup/Popup/Checkboxes/Favorites3/Checkmark");
								}
							}

							// Token: 0x1700094B RID: 2379
							// (get) Token: 0x060012E8 RID: 4840 RVA: 0x000367E8 File Offset: 0x000349E8
							public static GameObject Description
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/AddToAvatarFavoritesPopup/Popup/Checkboxes/Favorites3/Description");
								}
							}
						}

						// Token: 0x0200040D RID: 1037
						public class Favorites4_5
						{
							// Token: 0x1700094C RID: 2380
							// (get) Token: 0x060012EA RID: 4842 RVA: 0x00036810 File Offset: 0x00034A10
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/AddToAvatarFavoritesPopup/Popup/Checkboxes/Favorites4/Checkmark");
								}
							}

							// Token: 0x1700094D RID: 2381
							// (get) Token: 0x060012EB RID: 4843 RVA: 0x0003682C File Offset: 0x00034A2C
							public static GameObject Description
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/AddToAvatarFavoritesPopup/Popup/Checkboxes/Favorites4/Description");
								}
							}
						}
					}

					// Token: 0x02000340 RID: 832
					public class AddButton_4
					{
						// Token: 0x170007E7 RID: 2023
						// (get) Token: 0x060010B8 RID: 4280 RVA: 0x00033768 File Offset: 0x00031968
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/AddToAvatarFavoritesPopup/Popup/AddButton/Text");
							}
						}
					}
				}
			}

			// Token: 0x02000102 RID: 258
			public class AddToPlaylistPopup_2
			{
				// Token: 0x1700024C RID: 588
				// (get) Token: 0x060008D6 RID: 2262 RVA: 0x00027F70 File Offset: 0x00026170
				public static GameObject Darkness
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/AddToPlaylistPopup/Darkness");
					}
				}

				// Token: 0x1700024D RID: 589
				// (get) Token: 0x060008D7 RID: 2263 RVA: 0x00027F8C File Offset: 0x0002618C
				public static GameObject Popup
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/AddToPlaylistPopup/Popup");
					}
				}

				// Token: 0x020001E7 RID: 487
				public class Popup_3
				{
					// Token: 0x17000515 RID: 1301
					// (get) Token: 0x06000C8D RID: 3213 RVA: 0x0002D844 File Offset: 0x0002BA44
					public static GameObject BorderImage
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/AddToPlaylistPopup/Popup/BorderImage");
						}
					}

					// Token: 0x17000516 RID: 1302
					// (get) Token: 0x06000C8E RID: 3214 RVA: 0x0002D860 File Offset: 0x0002BA60
					public static GameObject Panel
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/AddToPlaylistPopup/Popup/Panel");
						}
					}

					// Token: 0x17000517 RID: 1303
					// (get) Token: 0x06000C8F RID: 3215 RVA: 0x0002D87C File Offset: 0x0002BA7C
					public static GameObject InstanceText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/AddToPlaylistPopup/Popup/InstanceText");
						}
					}

					// Token: 0x17000518 RID: 1304
					// (get) Token: 0x06000C90 RID: 3216 RVA: 0x0002D898 File Offset: 0x0002BA98
					public static GameObject Checkboxes
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/AddToPlaylistPopup/Popup/Checkboxes");
						}
					}

					// Token: 0x17000519 RID: 1305
					// (get) Token: 0x06000C91 RID: 3217 RVA: 0x0002D8B4 File Offset: 0x0002BAB4
					public static GameObject AddButton
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/AddToPlaylistPopup/Popup/AddButton");
						}
					}

					// Token: 0x1700051A RID: 1306
					// (get) Token: 0x06000C92 RID: 3218 RVA: 0x0002D8D0 File Offset: 0x0002BAD0
					public static GameObject ExitButton
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/AddToPlaylistPopup/Popup/ExitButton");
						}
					}

					// Token: 0x02000341 RID: 833
					public class Checkboxes_4
					{
						// Token: 0x170007E8 RID: 2024
						// (get) Token: 0x060010BA RID: 4282 RVA: 0x00033790 File Offset: 0x00031990
						public static GameObject Playlist1
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/AddToPlaylistPopup/Popup/Checkboxes/Playlist1");
							}
						}

						// Token: 0x170007E9 RID: 2025
						// (get) Token: 0x060010BB RID: 4283 RVA: 0x000337AC File Offset: 0x000319AC
						public static GameObject Playlist2
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/AddToPlaylistPopup/Popup/Checkboxes/Playlist2");
							}
						}

						// Token: 0x170007EA RID: 2026
						// (get) Token: 0x060010BC RID: 4284 RVA: 0x000337C8 File Offset: 0x000319C8
						public static GameObject Playlist
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/AddToPlaylistPopup/Popup/Checkboxes/Playlist3");
							}
						}

						// Token: 0x170007EB RID: 2027
						// (get) Token: 0x060010BD RID: 4285 RVA: 0x000337E4 File Offset: 0x000319E4
						public static GameObject Playlist4
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/AddToPlaylistPopup/Popup/Checkboxes/Playlist4");
							}
						}

						// Token: 0x0200040E RID: 1038
						public class Playlist1_5
						{
							// Token: 0x1700094E RID: 2382
							// (get) Token: 0x060012ED RID: 4845 RVA: 0x00036854 File Offset: 0x00034A54
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/AddToPlaylistPopup/Popup/Checkboxes/Playlist1/Checkmark");
								}
							}

							// Token: 0x1700094F RID: 2383
							// (get) Token: 0x060012EE RID: 4846 RVA: 0x00036870 File Offset: 0x00034A70
							public static GameObject Description
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/AddToPlaylistPopup/Popup/Checkboxes/Playlist1/Description");
								}
							}
						}

						// Token: 0x0200040F RID: 1039
						public class Playlist2_5
						{
							// Token: 0x17000950 RID: 2384
							// (get) Token: 0x060012F0 RID: 4848 RVA: 0x00036898 File Offset: 0x00034A98
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/AddToPlaylistPopup/Popup/Checkboxes/Playlist2/Checkmark");
								}
							}

							// Token: 0x17000951 RID: 2385
							// (get) Token: 0x060012F1 RID: 4849 RVA: 0x000368B4 File Offset: 0x00034AB4
							public static GameObject Description
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/AddToPlaylistPopup/Popup/Checkboxes/Playlist2/Description");
								}
							}
						}

						// Token: 0x02000410 RID: 1040
						public class Playlist_5
						{
							// Token: 0x17000952 RID: 2386
							// (get) Token: 0x060012F3 RID: 4851 RVA: 0x000368DC File Offset: 0x00034ADC
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/AddToPlaylistPopup/Popup/Checkboxes/Playlist3/Checkmark");
								}
							}

							// Token: 0x17000953 RID: 2387
							// (get) Token: 0x060012F4 RID: 4852 RVA: 0x000368F8 File Offset: 0x00034AF8
							public static GameObject Description
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/AddToPlaylistPopup/Popup/Checkboxes/Playlist3/Description");
								}
							}
						}

						// Token: 0x02000411 RID: 1041
						public class Playlist4_5
						{
							// Token: 0x17000954 RID: 2388
							// (get) Token: 0x060012F6 RID: 4854 RVA: 0x00036920 File Offset: 0x00034B20
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/AddToPlaylistPopup/Popup/Checkboxes/Playlist4/Checkmark");
								}
							}

							// Token: 0x17000955 RID: 2389
							// (get) Token: 0x060012F7 RID: 4855 RVA: 0x0003693C File Offset: 0x00034B3C
							public static GameObject Description
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/AddToPlaylistPopup/Popup/Checkboxes/Playlist4/Description");
								}
							}
						}
					}

					// Token: 0x02000342 RID: 834
					public class AddButton_4
					{
						// Token: 0x170007EC RID: 2028
						// (get) Token: 0x060010BF RID: 4287 RVA: 0x0003380C File Offset: 0x00031A0C
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/AddToPlaylistPopup/Popup/AddButton/Text");
							}
						}
					}
				}
			}

			// Token: 0x02000103 RID: 259
			public class AddInviteMessagePopup_2
			{
				// Token: 0x1700024E RID: 590
				// (get) Token: 0x060008D9 RID: 2265 RVA: 0x00027FB4 File Offset: 0x000261B4
				public static GameObject Darkness
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/AddInviteMessagePopup/Darkness");
					}
				}

				// Token: 0x1700024F RID: 591
				// (get) Token: 0x060008DA RID: 2266 RVA: 0x00027FD0 File Offset: 0x000261D0
				public static GameObject InviteResponseAddMessageMenu
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/AddInviteMessagePopup/InviteResponseAddMessageMenu");
					}
				}

				// Token: 0x020001E8 RID: 488
				public class InviteResponseAddMessageMenu_3
				{
					// Token: 0x1700051B RID: 1307
					// (get) Token: 0x06000C94 RID: 3220 RVA: 0x0002D8F8 File Offset: 0x0002BAF8
					public static GameObject BorderImage
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/AddInviteMessagePopup/InviteResponseAddMessageMenu/BorderImage");
						}
					}

					// Token: 0x1700051C RID: 1308
					// (get) Token: 0x06000C95 RID: 3221 RVA: 0x0002D914 File Offset: 0x0002BB14
					public static GameObject Panel
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/AddInviteMessagePopup/InviteResponseAddMessageMenu/Panel");
						}
					}

					// Token: 0x1700051D RID: 1309
					// (get) Token: 0x06000C96 RID: 3222 RVA: 0x0002D930 File Offset: 0x0002BB30
					public static GameObject TitleText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/AddInviteMessagePopup/InviteResponseAddMessageMenu/TitleText");
						}
					}

					// Token: 0x1700051E RID: 1310
					// (get) Token: 0x06000C97 RID: 3223 RVA: 0x0002D94C File Offset: 0x0002BB4C
					public static GameObject BackButton
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/AddInviteMessagePopup/InviteResponseAddMessageMenu/BackButton");
						}
					}

					// Token: 0x1700051F RID: 1311
					// (get) Token: 0x06000C98 RID: 3224 RVA: 0x0002D968 File Offset: 0x0002BB68
					public static GameObject ScrollRect
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/AddInviteMessagePopup/InviteResponseAddMessageMenu/ScrollRect");
						}
					}

					// Token: 0x02000343 RID: 835
					public class BackButton_4
					{
						// Token: 0x170007ED RID: 2029
						// (get) Token: 0x060010C1 RID: 4289 RVA: 0x00033834 File Offset: 0x00031A34
						public static GameObject ArrowImage
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/AddInviteMessagePopup/InviteResponseAddMessageMenu/BackButton/ArrowImage");
							}
						}
					}
				}
			}

			// Token: 0x02000104 RID: 260
			public class AlertPopup_2
			{
				// Token: 0x17000250 RID: 592
				// (get) Token: 0x060008DC RID: 2268 RVA: 0x00027FF8 File Offset: 0x000261F8
				public static GameObject Darkness
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/AlertPopup/Darkness");
					}
				}

				// Token: 0x17000251 RID: 593
				// (get) Token: 0x060008DD RID: 2269 RVA: 0x00028014 File Offset: 0x00026214
				public static GameObject Lighter
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/AlertPopup/Lighter");
					}
				}

				// Token: 0x17000252 RID: 594
				// (get) Token: 0x060008DE RID: 2270 RVA: 0x00028030 File Offset: 0x00026230
				public static GameObject TitleText
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/AlertPopup/TitleText");
					}
				}

				// Token: 0x17000253 RID: 595
				// (get) Token: 0x060008DF RID: 2271 RVA: 0x0002804C File Offset: 0x0002624C
				public static GameObject BodyText
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/AlertPopup/BodyText");
					}
				}

				// Token: 0x17000254 RID: 596
				// (get) Token: 0x060008E0 RID: 2272 RVA: 0x00028068 File Offset: 0x00026268
				public static GameObject TimerText
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/AlertPopup/TimerText");
					}
				}

				// Token: 0x17000255 RID: 597
				// (get) Token: 0x060008E1 RID: 2273 RVA: 0x00028084 File Offset: 0x00026284
				public static GameObject Button
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/AlertPopup/Button");
					}
				}

				// Token: 0x020001E9 RID: 489
				public class Button_3
				{
					// Token: 0x17000520 RID: 1312
					// (get) Token: 0x06000C9A RID: 3226 RVA: 0x0002D990 File Offset: 0x0002BB90
					public static GameObject Text
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/AlertPopup/Button/Text");
						}
					}
				}
			}

			// Token: 0x02000105 RID: 261
			public class CreateUserIconFromImagePopup_2
			{
				// Token: 0x17000256 RID: 598
				// (get) Token: 0x060008E3 RID: 2275 RVA: 0x000280AC File Offset: 0x000262AC
				public static GameObject Darkness
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Darkness");
					}
				}

				// Token: 0x17000257 RID: 599
				// (get) Token: 0x060008E4 RID: 2276 RVA: 0x000280C8 File Offset: 0x000262C8
				public static GameObject Popup
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup");
					}
				}

				// Token: 0x020001EA RID: 490
				public class Popup_3
				{
					// Token: 0x17000521 RID: 1313
					// (get) Token: 0x06000C9C RID: 3228 RVA: 0x0002D9B8 File Offset: 0x0002BBB8
					public static GameObject BorderImage
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/BorderImage");
						}
					}

					// Token: 0x17000522 RID: 1314
					// (get) Token: 0x06000C9D RID: 3229 RVA: 0x0002D9D4 File Offset: 0x0002BBD4
					public static GameObject UserIconRoundBorderImage
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/UserIconRoundBorderImage");
						}
					}

					// Token: 0x17000523 RID: 1315
					// (get) Token: 0x06000C9E RID: 3230 RVA: 0x0002D9F0 File Offset: 0x0002BBF0
					public static GameObject Panel
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/Panel");
						}
					}

					// Token: 0x17000524 RID: 1316
					// (get) Token: 0x06000C9F RID: 3231 RVA: 0x0002DA0C File Offset: 0x0002BC0C
					public static GameObject TitleText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/TitleText");
						}
					}

					// Token: 0x17000525 RID: 1317
					// (get) Token: 0x06000CA0 RID: 3232 RVA: 0x0002DA28 File Offset: 0x0002BC28
					public static GameObject CreateUserIconGroup
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/CreateUserIconGroup");
						}
					}

					// Token: 0x17000526 RID: 1318
					// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x0002DA44 File Offset: 0x0002BC44
					public static GameObject SetAsCurrentIconGroup
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/SetAsCurrentIconGroup");
						}
					}

					// Token: 0x17000527 RID: 1319
					// (get) Token: 0x06000CA2 RID: 3234 RVA: 0x0002DA60 File Offset: 0x0002BC60
					public static GameObject ExitButton
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/ExitButton");
						}
					}

					// Token: 0x17000528 RID: 1320
					// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x0002DA7C File Offset: 0x0002BC7C
					public static GameObject Max_Icons
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/Max Icons");
						}
					}

					// Token: 0x17000529 RID: 1321
					// (get) Token: 0x06000CA4 RID: 3236 RVA: 0x0002DA98 File Offset: 0x0002BC98
					public static GameObject Upload_Group
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/Upload Group");
						}
					}

					// Token: 0x02000344 RID: 836
					public class CreateUserIconGroup_4
					{
						// Token: 0x170007EE RID: 2030
						// (get) Token: 0x060010C3 RID: 4291 RVA: 0x0003385C File Offset: 0x00031A5C
						public static GameObject Preview_Window
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/CreateUserIconGroup/Preview Window");
							}
						}

						// Token: 0x170007EF RID: 2031
						// (get) Token: 0x060010C4 RID: 4292 RVA: 0x00033878 File Offset: 0x00031A78
						public static GameObject Zoom_Pan_Group
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/CreateUserIconGroup/Zoom Pan Group");
							}
						}

						// Token: 0x170007F0 RID: 2032
						// (get) Token: 0x060010C5 RID: 4293 RVA: 0x00033894 File Offset: 0x00031A94
						public static GameObject SaveAndApplyButton
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/CreateUserIconGroup/SaveAndApplyButton");
							}
						}

						// Token: 0x02000412 RID: 1042
						public class Preview_Window_5
						{
							// Token: 0x17000956 RID: 2390
							// (get) Token: 0x060012F9 RID: 4857 RVA: 0x00036964 File Offset: 0x00034B64
							public static GameObject Preview
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/CreateUserIconGroup/Preview Window/Preview");
								}
							}

							// Token: 0x17000957 RID: 2391
							// (get) Token: 0x060012FA RID: 4858 RVA: 0x00036980 File Offset: 0x00034B80
							public static GameObject Overlay
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/CreateUserIconGroup/Preview Window/Overlay");
								}
							}

							// Token: 0x17000958 RID: 2392
							// (get) Token: 0x060012FB RID: 4859 RVA: 0x0003699C File Offset: 0x00034B9C
							public static GameObject Bounds
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/CreateUserIconGroup/Preview Window/Bounds");
								}
							}
						}

						// Token: 0x02000413 RID: 1043
						public class Zoom_Pan_Group_5
						{
							// Token: 0x17000959 RID: 2393
							// (get) Token: 0x060012FD RID: 4861 RVA: 0x000369C4 File Offset: 0x00034BC4
							public static GameObject Zoom
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/CreateUserIconGroup/Zoom Pan Group/Zoom");
								}
							}

							// Token: 0x1700095A RID: 2394
							// (get) Token: 0x060012FE RID: 4862 RVA: 0x000369E0 File Offset: 0x00034BE0
							public static GameObject Move_Icon
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/CreateUserIconGroup/Zoom Pan Group/Move Icon");
								}
							}
						}

						// Token: 0x02000414 RID: 1044
						public class SaveAndApplyButton_5
						{
							// Token: 0x1700095B RID: 2395
							// (get) Token: 0x06001300 RID: 4864 RVA: 0x00036A08 File Offset: 0x00034C08
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/CreateUserIconGroup/SaveAndApplyButton/Text");
								}
							}
						}
					}

					// Token: 0x02000345 RID: 837
					public class SetAsCurrentIconGroup_4
					{
						// Token: 0x170007F1 RID: 2033
						// (get) Token: 0x060010C7 RID: 4295 RVA: 0x000338BC File Offset: 0x00031ABC
						public static GameObject Preview_Window
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/SetAsCurrentIconGroup/Preview Window");
							}
						}

						// Token: 0x170007F2 RID: 2034
						// (get) Token: 0x060010C8 RID: 4296 RVA: 0x000338D8 File Offset: 0x00031AD8
						public static GameObject UserIconCreatedText
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/SetAsCurrentIconGroup/UserIconCreatedText");
							}
						}

						// Token: 0x170007F3 RID: 2035
						// (get) Token: 0x060010C9 RID: 4297 RVA: 0x000338F4 File Offset: 0x00031AF4
						public static GameObject SetAsCurrentIconButton
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/SetAsCurrentIconGroup/SetAsCurrentIconButton");
							}
						}

						// Token: 0x170007F4 RID: 2036
						// (get) Token: 0x060010CA RID: 4298 RVA: 0x00033910 File Offset: 0x00031B10
						public static GameObject CloseCreateUserIconPopupButton
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/SetAsCurrentIconGroup/CloseCreateUserIconPopupButton");
							}
						}

						// Token: 0x02000415 RID: 1045
						public class Preview_Window_5
						{
							// Token: 0x1700095C RID: 2396
							// (get) Token: 0x06001302 RID: 4866 RVA: 0x00036A30 File Offset: 0x00034C30
							public static GameObject Preview
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/SetAsCurrentIconGroup/Preview Window/Preview");
								}
							}

							// Token: 0x1700095D RID: 2397
							// (get) Token: 0x06001303 RID: 4867 RVA: 0x00036A4C File Offset: 0x00034C4C
							public static GameObject Overlay
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/SetAsCurrentIconGroup/Preview Window/Overlay");
								}
							}
						}

						// Token: 0x02000416 RID: 1046
						public class SetAsCurrentIconButton_5
						{
							// Token: 0x1700095E RID: 2398
							// (get) Token: 0x06001305 RID: 4869 RVA: 0x00036A74 File Offset: 0x00034C74
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/SetAsCurrentIconGroup/SetAsCurrentIconButton/Text");
								}
							}
						}

						// Token: 0x02000417 RID: 1047
						public class CloseCreateUserIconPopupButton_5
						{
							// Token: 0x1700095F RID: 2399
							// (get) Token: 0x06001307 RID: 4871 RVA: 0x00036A9C File Offset: 0x00034C9C
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/SetAsCurrentIconGroup/CloseCreateUserIconPopupButton/Text");
								}
							}
						}
					}

					// Token: 0x02000346 RID: 838
					public class Max_Icons_4
					{
						// Token: 0x170007F5 RID: 2037
						// (get) Token: 0x060010CC RID: 4300 RVA: 0x00033938 File Offset: 0x00031B38
						public static GameObject Manage_Icons
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/Max Icons/Manage Icons");
							}
						}

						// Token: 0x170007F6 RID: 2038
						// (get) Token: 0x060010CD RID: 4301 RVA: 0x00033954 File Offset: 0x00031B54
						public static GameObject BackButton
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/Max Icons/BackButton");
							}
						}

						// Token: 0x170007F7 RID: 2039
						// (get) Token: 0x060010CE RID: 4302 RVA: 0x00033970 File Offset: 0x00031B70
						public static GameObject Info
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/Max Icons/Info");
							}
						}

						// Token: 0x02000418 RID: 1048
						public class Manage_Icons_5
						{
							// Token: 0x17000960 RID: 2400
							// (get) Token: 0x06001309 RID: 4873 RVA: 0x00036AC4 File Offset: 0x00034CC4
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/Max Icons/Manage Icons/Text");
								}
							}
						}

						// Token: 0x02000419 RID: 1049
						public class BackButton_5
						{
							// Token: 0x17000961 RID: 2401
							// (get) Token: 0x0600130B RID: 4875 RVA: 0x00036AEC File Offset: 0x00034CEC
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/Max Icons/BackButton/Text");
								}
							}
						}

						// Token: 0x0200041A RID: 1050
						public class Info_5
						{
							// Token: 0x17000962 RID: 2402
							// (get) Token: 0x0600130D RID: 4877 RVA: 0x00036B14 File Offset: 0x00034D14
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/Max Icons/Info/Text");
								}
							}

							// Token: 0x17000963 RID: 2403
							// (get) Token: 0x0600130E RID: 4878 RVA: 0x00036B30 File Offset: 0x00034D30
							public static GameObject InfoIcon
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/Max Icons/Info/InfoIcon");
								}
							}
						}
					}

					// Token: 0x02000347 RID: 839
					public class Upload_Group_4
					{
						// Token: 0x170007F8 RID: 2040
						// (get) Token: 0x060010D0 RID: 4304 RVA: 0x00033998 File Offset: 0x00031B98
						public static GameObject Info
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/Upload Group/Info");
							}
						}

						// Token: 0x0200041B RID: 1051
						public class Info_5
						{
							// Token: 0x17000964 RID: 2404
							// (get) Token: 0x06001310 RID: 4880 RVA: 0x00036B58 File Offset: 0x00034D58
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/Upload Group/Info/Text");
								}
							}
						}
					}
				}
			}

			// Token: 0x02000106 RID: 262
			public class BookmarkFriendPopup_2
			{
				// Token: 0x17000258 RID: 600
				// (get) Token: 0x060008E6 RID: 2278 RVA: 0x000280F0 File Offset: 0x000262F0
				public static GameObject Darkness
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/BookmarkFriendPopup/Darkness");
					}
				}

				// Token: 0x17000259 RID: 601
				// (get) Token: 0x060008E7 RID: 2279 RVA: 0x0002810C File Offset: 0x0002630C
				public static GameObject Popup
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/BookmarkFriendPopup/Popup");
					}
				}

				// Token: 0x020001EB RID: 491
				public class Popup_3
				{
					// Token: 0x1700052A RID: 1322
					// (get) Token: 0x06000CA6 RID: 3238 RVA: 0x0002DAC0 File Offset: 0x0002BCC0
					public static GameObject BorderImage
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/BookmarkFriendPopup/Popup/BorderImage");
						}
					}

					// Token: 0x1700052B RID: 1323
					// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x0002DADC File Offset: 0x0002BCDC
					public static GameObject Panel_2
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/BookmarkFriendPopup/Popup/Panel (2)");
						}
					}

					// Token: 0x1700052C RID: 1324
					// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x0002DAF8 File Offset: 0x0002BCF8
					public static GameObject InstanceText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/BookmarkFriendPopup/Popup/InstanceText");
						}
					}

					// Token: 0x1700052D RID: 1325
					// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x0002DB14 File Offset: 0x0002BD14
					public static GameObject Checkboxes
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/BookmarkFriendPopup/Popup/Checkboxes");
						}
					}

					// Token: 0x1700052E RID: 1326
					// (get) Token: 0x06000CAA RID: 3242 RVA: 0x0002DB30 File Offset: 0x0002BD30
					public static GameObject AddButton
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/BookmarkFriendPopup/Popup/AddButton");
						}
					}

					// Token: 0x1700052F RID: 1327
					// (get) Token: 0x06000CAB RID: 3243 RVA: 0x0002DB4C File Offset: 0x0002BD4C
					public static GameObject ExitButton
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/BookmarkFriendPopup/Popup/ExitButton");
						}
					}

					// Token: 0x02000348 RID: 840
					public class Checkboxes_4
					{
						// Token: 0x170007F9 RID: 2041
						// (get) Token: 0x060010D2 RID: 4306 RVA: 0x000339C0 File Offset: 0x00031BC0
						public static GameObject Bookmark1
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/BookmarkFriendPopup/Popup/Checkboxes/Bookmark1");
							}
						}

						// Token: 0x170007FA RID: 2042
						// (get) Token: 0x060010D3 RID: 4307 RVA: 0x000339DC File Offset: 0x00031BDC
						public static GameObject Bookmark2
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/BookmarkFriendPopup/Popup/Checkboxes/Bookmark2");
							}
						}

						// Token: 0x170007FB RID: 2043
						// (get) Token: 0x060010D4 RID: 4308 RVA: 0x000339F8 File Offset: 0x00031BF8
						public static GameObject Bookmark
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/BookmarkFriendPopup/Popup/Checkboxes/Bookmark3");
							}
						}

						// Token: 0x0200041C RID: 1052
						public class Bookmark1_5
						{
							// Token: 0x17000965 RID: 2405
							// (get) Token: 0x06001312 RID: 4882 RVA: 0x00036B80 File Offset: 0x00034D80
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/BookmarkFriendPopup/Popup/Checkboxes/Bookmark1/Checkmark");
								}
							}

							// Token: 0x17000966 RID: 2406
							// (get) Token: 0x06001313 RID: 4883 RVA: 0x00036B9C File Offset: 0x00034D9C
							public static GameObject Description
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/BookmarkFriendPopup/Popup/Checkboxes/Bookmark1/Description");
								}
							}
						}

						// Token: 0x0200041D RID: 1053
						public class Bookmark2_5
						{
							// Token: 0x17000967 RID: 2407
							// (get) Token: 0x06001315 RID: 4885 RVA: 0x00036BC4 File Offset: 0x00034DC4
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/BookmarkFriendPopup/Popup/Checkboxes/Bookmark2/Checkmark");
								}
							}

							// Token: 0x17000968 RID: 2408
							// (get) Token: 0x06001316 RID: 4886 RVA: 0x00036BE0 File Offset: 0x00034DE0
							public static GameObject Description
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/BookmarkFriendPopup/Popup/Checkboxes/Bookmark2/Description");
								}
							}
						}

						// Token: 0x0200041E RID: 1054
						public class Bookmark_5
						{
							// Token: 0x17000969 RID: 2409
							// (get) Token: 0x06001318 RID: 4888 RVA: 0x00036C08 File Offset: 0x00034E08
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/BookmarkFriendPopup/Popup/Checkboxes/Bookmark3/Checkmark");
								}
							}

							// Token: 0x1700096A RID: 2410
							// (get) Token: 0x06001319 RID: 4889 RVA: 0x00036C24 File Offset: 0x00034E24
							public static GameObject Description
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/BookmarkFriendPopup/Popup/Checkboxes/Bookmark3/Description");
								}
							}
						}
					}

					// Token: 0x02000349 RID: 841
					public class AddButton_4
					{
						// Token: 0x170007FC RID: 2044
						// (get) Token: 0x060010D6 RID: 4310 RVA: 0x00033A20 File Offset: 0x00031C20
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/BookmarkFriendPopup/Popup/AddButton/Text");
							}
						}
					}
				}
			}

			// Token: 0x02000107 RID: 263
			public class ClearPlaylistPopup_2
			{
				// Token: 0x1700025A RID: 602
				// (get) Token: 0x060008E9 RID: 2281 RVA: 0x00028134 File Offset: 0x00026334
				public static GameObject Darkness
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/ClearPlaylistPopup/Darkness");
					}
				}

				// Token: 0x1700025B RID: 603
				// (get) Token: 0x060008EA RID: 2282 RVA: 0x00028150 File Offset: 0x00026350
				public static GameObject Popup
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/ClearPlaylistPopup/Popup");
					}
				}

				// Token: 0x020001EC RID: 492
				public class Popup_3
				{
					// Token: 0x17000530 RID: 1328
					// (get) Token: 0x06000CAD RID: 3245 RVA: 0x0002DB74 File Offset: 0x0002BD74
					public static GameObject BorderImage
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/ClearPlaylistPopup/Popup/BorderImage");
						}
					}

					// Token: 0x17000531 RID: 1329
					// (get) Token: 0x06000CAE RID: 3246 RVA: 0x0002DB90 File Offset: 0x0002BD90
					public static GameObject Panel
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/ClearPlaylistPopup/Popup/Panel");
						}
					}

					// Token: 0x17000532 RID: 1330
					// (get) Token: 0x06000CAF RID: 3247 RVA: 0x0002DBAC File Offset: 0x0002BDAC
					public static GameObject ExitButton
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/ClearPlaylistPopup/Popup/ExitButton");
						}
					}

					// Token: 0x17000533 RID: 1331
					// (get) Token: 0x06000CB0 RID: 3248 RVA: 0x0002DBC8 File Offset: 0x0002BDC8
					public static GameObject ClearPlaylistTitleText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/ClearPlaylistPopup/Popup/ClearPlaylistTitleText");
						}
					}

					// Token: 0x17000534 RID: 1332
					// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x0002DBE4 File Offset: 0x0002BDE4
					public static GameObject ClearPlaylistInfoText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/ClearPlaylistPopup/Popup/ClearPlaylistInfoText");
						}
					}

					// Token: 0x17000535 RID: 1333
					// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x0002DC00 File Offset: 0x0002BE00
					public static GameObject Buttons
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/ClearPlaylistPopup/Popup/Buttons");
						}
					}

					// Token: 0x0200034A RID: 842
					public class Buttons_4
					{
						// Token: 0x170007FD RID: 2045
						// (get) Token: 0x060010D8 RID: 4312 RVA: 0x00033A48 File Offset: 0x00031C48
						public static GameObject CancelButton
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/ClearPlaylistPopup/Popup/Buttons/CancelButton");
							}
						}

						// Token: 0x170007FE RID: 2046
						// (get) Token: 0x060010D9 RID: 4313 RVA: 0x00033A64 File Offset: 0x00031C64
						public static GameObject ClearButton
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/ClearPlaylistPopup/Popup/Buttons/ClearButton");
							}
						}

						// Token: 0x0200041F RID: 1055
						public class CancelButton_5
						{
							// Token: 0x1700096B RID: 2411
							// (get) Token: 0x0600131B RID: 4891 RVA: 0x00036C4C File Offset: 0x00034E4C
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/ClearPlaylistPopup/Popup/Buttons/CancelButton/Text");
								}
							}
						}

						// Token: 0x02000420 RID: 1056
						public class ClearButton_5
						{
							// Token: 0x1700096C RID: 2412
							// (get) Token: 0x0600131D RID: 4893 RVA: 0x00036C74 File Offset: 0x00034E74
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/ClearPlaylistPopup/Popup/Buttons/ClearButton/Text");
								}
							}
						}
					}
				}
			}

			// Token: 0x02000108 RID: 264
			public class CommunityLabsPopup_2
			{
				// Token: 0x1700025C RID: 604
				// (get) Token: 0x060008EC RID: 2284 RVA: 0x00028178 File Offset: 0x00026378
				public static GameObject Darkness
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/CommunityLabsPopup/Darkness");
					}
				}

				// Token: 0x1700025D RID: 605
				// (get) Token: 0x060008ED RID: 2285 RVA: 0x00028194 File Offset: 0x00026394
				public static GameObject Rectangle
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/CommunityLabsPopup/Rectangle");
					}
				}

				// Token: 0x1700025E RID: 606
				// (get) Token: 0x060008EE RID: 2286 RVA: 0x000281B0 File Offset: 0x000263B0
				public static GameObject UpperPanel
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/CommunityLabsPopup/UpperPanel");
					}
				}

				// Token: 0x1700025F RID: 607
				// (get) Token: 0x060008EF RID: 2287 RVA: 0x000281CC File Offset: 0x000263CC
				public static GameObject TitlePanel
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/CommunityLabsPopup/TitlePanel");
					}
				}

				// Token: 0x17000260 RID: 608
				// (get) Token: 0x060008F0 RID: 2288 RVA: 0x000281E8 File Offset: 0x000263E8
				public static GameObject TitleText
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/CommunityLabsPopup/TitleText");
					}
				}

				// Token: 0x17000261 RID: 609
				// (get) Token: 0x060008F1 RID: 2289 RVA: 0x00028204 File Offset: 0x00026404
				public static GameObject Icon_CL
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/CommunityLabsPopup/Icon_CL");
					}
				}

				// Token: 0x17000262 RID: 610
				// (get) Token: 0x060008F2 RID: 2290 RVA: 0x00028220 File Offset: 0x00026420
				public static GameObject BodyText
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/CommunityLabsPopup/BodyText");
					}
				}

				// Token: 0x17000263 RID: 611
				// (get) Token: 0x060008F3 RID: 2291 RVA: 0x0002823C File Offset: 0x0002643C
				public static GameObject ReportText
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/CommunityLabsPopup/ReportText");
					}
				}

				// Token: 0x17000264 RID: 612
				// (get) Token: 0x060008F4 RID: 2292 RVA: 0x00028258 File Offset: 0x00026458
				public static GameObject Graphic_CL_Report
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/CommunityLabsPopup/Graphic_CL_Report");
					}
				}

				// Token: 0x17000265 RID: 613
				// (get) Token: 0x060008F5 RID: 2293 RVA: 0x00028274 File Offset: 0x00026474
				public static GameObject Icon_Warning
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/CommunityLabsPopup/Icon_Warning");
					}
				}

				// Token: 0x17000266 RID: 614
				// (get) Token: 0x060008F6 RID: 2294 RVA: 0x00028290 File Offset: 0x00026490
				public static GameObject WarningText
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/CommunityLabsPopup/WarningText");
					}
				}

				// Token: 0x17000267 RID: 615
				// (get) Token: 0x060008F7 RID: 2295 RVA: 0x000282AC File Offset: 0x000264AC
				public static GameObject CancelButton
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/CommunityLabsPopup/CancelButton");
					}
				}

				// Token: 0x17000268 RID: 616
				// (get) Token: 0x060008F8 RID: 2296 RVA: 0x000282C8 File Offset: 0x000264C8
				public static GameObject AcceptButton
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/CommunityLabsPopup/AcceptButton");
					}
				}

				// Token: 0x17000269 RID: 617
				// (get) Token: 0x060008F9 RID: 2297 RVA: 0x000282E4 File Offset: 0x000264E4
				public static GameObject ExitButton
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/CommunityLabsPopup/ExitButton");
					}
				}

				// Token: 0x020001ED RID: 493
				public class CancelButton_3
				{
					// Token: 0x17000536 RID: 1334
					// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x0002DC28 File Offset: 0x0002BE28
					public static GameObject Text
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/CommunityLabsPopup/CancelButton/Text");
						}
					}
				}

				// Token: 0x020001EE RID: 494
				public class AcceptButton_3
				{
					// Token: 0x17000537 RID: 1335
					// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x0002DC50 File Offset: 0x0002BE50
					public static GameObject Text
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/CommunityLabsPopup/AcceptButton/Text");
						}
					}
				}
			}

			// Token: 0x02000109 RID: 265
			public class DatePopup_2
			{
				// Token: 0x1700026A RID: 618
				// (get) Token: 0x060008FB RID: 2299 RVA: 0x0002830C File Offset: 0x0002650C
				public static GameObject Darkness
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/Darkness");
					}
				}

				// Token: 0x1700026B RID: 619
				// (get) Token: 0x060008FC RID: 2300 RVA: 0x00028328 File Offset: 0x00026528
				public static GameObject Rectangle
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/Rectangle");
					}
				}

				// Token: 0x1700026C RID: 620
				// (get) Token: 0x060008FD RID: 2301 RVA: 0x00028344 File Offset: 0x00026544
				public static GameObject TitleText
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/TitleText");
					}
				}

				// Token: 0x1700026D RID: 621
				// (get) Token: 0x060008FE RID: 2302 RVA: 0x00028360 File Offset: 0x00026560
				public static GameObject ButtonLeft
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/ButtonLeft");
					}
				}

				// Token: 0x1700026E RID: 622
				// (get) Token: 0x060008FF RID: 2303 RVA: 0x0002837C File Offset: 0x0002657C
				public static GameObject ButtonRight
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/ButtonRight");
					}
				}

				// Token: 0x1700026F RID: 623
				// (get) Token: 0x06000900 RID: 2304 RVA: 0x00028398 File Offset: 0x00026598
				public static GameObject ButtonCenter
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/ButtonCenter");
					}
				}

				// Token: 0x17000270 RID: 624
				// (get) Token: 0x06000901 RID: 2305 RVA: 0x000283B4 File Offset: 0x000265B4
				public static GameObject MonthSpinner
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/MonthSpinner");
					}
				}

				// Token: 0x17000271 RID: 625
				// (get) Token: 0x06000902 RID: 2306 RVA: 0x000283D0 File Offset: 0x000265D0
				public static GameObject DayTenSpinner
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/DayTenSpinner");
					}
				}

				// Token: 0x17000272 RID: 626
				// (get) Token: 0x06000903 RID: 2307 RVA: 0x000283EC File Offset: 0x000265EC
				public static GameObject DayOneSpinner
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/DayOneSpinner");
					}
				}

				// Token: 0x17000273 RID: 627
				// (get) Token: 0x06000904 RID: 2308 RVA: 0x00028408 File Offset: 0x00026608
				public static GameObject YearCenturySpinner
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/YearCenturySpinner");
					}
				}

				// Token: 0x17000274 RID: 628
				// (get) Token: 0x06000905 RID: 2309 RVA: 0x00028424 File Offset: 0x00026624
				public static GameObject YearTenSpinner
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/YearTenSpinner");
					}
				}

				// Token: 0x17000275 RID: 629
				// (get) Token: 0x06000906 RID: 2310 RVA: 0x00028440 File Offset: 0x00026640
				public static GameObject YearOneSpinner
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/YearOneSpinner");
					}
				}

				// Token: 0x17000276 RID: 630
				// (get) Token: 0x06000907 RID: 2311 RVA: 0x0002845C File Offset: 0x0002665C
				public static GameObject MonthLabel
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/MonthLabel");
					}
				}

				// Token: 0x17000277 RID: 631
				// (get) Token: 0x06000908 RID: 2312 RVA: 0x00028478 File Offset: 0x00026678
				public static GameObject DayLabel
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/DayLabel");
					}
				}

				// Token: 0x17000278 RID: 632
				// (get) Token: 0x06000909 RID: 2313 RVA: 0x00028494 File Offset: 0x00026694
				public static GameObject YearLabel
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/YearLabel");
					}
				}

				// Token: 0x020001EF RID: 495
				public class ButtonLeft_3
				{
					// Token: 0x17000538 RID: 1336
					// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x0002DC78 File Offset: 0x0002BE78
					public static GameObject Text
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/ButtonLeft/Text");
						}
					}
				}

				// Token: 0x020001F0 RID: 496
				public class ButtonRight_3
				{
					// Token: 0x17000539 RID: 1337
					// (get) Token: 0x06000CBA RID: 3258 RVA: 0x0002DCA0 File Offset: 0x0002BEA0
					public static GameObject Text
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/ButtonRight/Text");
						}
					}
				}

				// Token: 0x020001F1 RID: 497
				public class ButtonCenter_3
				{
					// Token: 0x1700053A RID: 1338
					// (get) Token: 0x06000CBC RID: 3260 RVA: 0x0002DCC8 File Offset: 0x0002BEC8
					public static GameObject Text
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/ButtonCenter/Text");
						}
					}
				}

				// Token: 0x020001F2 RID: 498
				public class MonthSpinner_3
				{
					// Token: 0x1700053B RID: 1339
					// (get) Token: 0x06000CBE RID: 3262 RVA: 0x0002DCF0 File Offset: 0x0002BEF0
					public static GameObject SpinnerInput
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/MonthSpinner/SpinnerInput");
						}
					}

					// Token: 0x1700053C RID: 1340
					// (get) Token: 0x06000CBF RID: 3263 RVA: 0x0002DD0C File Offset: 0x0002BF0C
					public static GameObject Minus
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/MonthSpinner/Minus");
						}
					}

					// Token: 0x1700053D RID: 1341
					// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x0002DD28 File Offset: 0x0002BF28
					public static GameObject Plus
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/MonthSpinner/Plus");
						}
					}
				}

				// Token: 0x020001F3 RID: 499
				public class DayTenSpinner_3
				{
					// Token: 0x1700053E RID: 1342
					// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x0002DD50 File Offset: 0x0002BF50
					public static GameObject SpinnerInput
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/DayTenSpinner/SpinnerInput");
						}
					}

					// Token: 0x1700053F RID: 1343
					// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x0002DD6C File Offset: 0x0002BF6C
					public static GameObject Minus
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/DayTenSpinner/Minus");
						}
					}

					// Token: 0x17000540 RID: 1344
					// (get) Token: 0x06000CC4 RID: 3268 RVA: 0x0002DD88 File Offset: 0x0002BF88
					public static GameObject Plus
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/DayTenSpinner/Plus");
						}
					}
				}

				// Token: 0x020001F4 RID: 500
				public class DayOneSpinner_3
				{
					// Token: 0x17000541 RID: 1345
					// (get) Token: 0x06000CC6 RID: 3270 RVA: 0x0002DDB0 File Offset: 0x0002BFB0
					public static GameObject SpinnerInput
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/DayOneSpinner/SpinnerInput");
						}
					}

					// Token: 0x17000542 RID: 1346
					// (get) Token: 0x06000CC7 RID: 3271 RVA: 0x0002DDCC File Offset: 0x0002BFCC
					public static GameObject Minus
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/DayOneSpinner/Minus");
						}
					}

					// Token: 0x17000543 RID: 1347
					// (get) Token: 0x06000CC8 RID: 3272 RVA: 0x0002DDE8 File Offset: 0x0002BFE8
					public static GameObject Plus
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/DayOneSpinner/Plus");
						}
					}
				}

				// Token: 0x020001F5 RID: 501
				public class YearCenturySpinner_3
				{
					// Token: 0x17000544 RID: 1348
					// (get) Token: 0x06000CCA RID: 3274 RVA: 0x0002DE10 File Offset: 0x0002C010
					public static GameObject SpinnerInput
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/YearCenturySpinner/SpinnerInput");
						}
					}

					// Token: 0x17000545 RID: 1349
					// (get) Token: 0x06000CCB RID: 3275 RVA: 0x0002DE2C File Offset: 0x0002C02C
					public static GameObject Minus
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/YearCenturySpinner/Minus");
						}
					}

					// Token: 0x17000546 RID: 1350
					// (get) Token: 0x06000CCC RID: 3276 RVA: 0x0002DE48 File Offset: 0x0002C048
					public static GameObject Plus
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/YearCenturySpinner/Plus");
						}
					}
				}

				// Token: 0x020001F6 RID: 502
				public class YearTenSpinner_3
				{
					// Token: 0x17000547 RID: 1351
					// (get) Token: 0x06000CCE RID: 3278 RVA: 0x0002DE70 File Offset: 0x0002C070
					public static GameObject SpinnerInput
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/YearTenSpinner/SpinnerInput");
						}
					}

					// Token: 0x17000548 RID: 1352
					// (get) Token: 0x06000CCF RID: 3279 RVA: 0x0002DE8C File Offset: 0x0002C08C
					public static GameObject Minus
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/YearTenSpinner/Minus");
						}
					}

					// Token: 0x17000549 RID: 1353
					// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x0002DEA8 File Offset: 0x0002C0A8
					public static GameObject Plus
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/YearTenSpinner/Plus");
						}
					}
				}

				// Token: 0x020001F7 RID: 503
				public class YearOneSpinner_3
				{
					// Token: 0x1700054A RID: 1354
					// (get) Token: 0x06000CD2 RID: 3282 RVA: 0x0002DED0 File Offset: 0x0002C0D0
					public static GameObject SpinnerInput
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/YearOneSpinner/SpinnerInput");
						}
					}

					// Token: 0x1700054B RID: 1355
					// (get) Token: 0x06000CD3 RID: 3283 RVA: 0x0002DEEC File Offset: 0x0002C0EC
					public static GameObject Minus
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/YearOneSpinner/Minus");
						}
					}

					// Token: 0x1700054C RID: 1356
					// (get) Token: 0x06000CD4 RID: 3284 RVA: 0x0002DF08 File Offset: 0x0002C108
					public static GameObject Plus
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/YearOneSpinner/Plus");
						}
					}
				}
			}

			// Token: 0x0200010A RID: 266
			public class EditPlaylistPopup_2
			{
				// Token: 0x17000279 RID: 633
				// (get) Token: 0x0600090B RID: 2315 RVA: 0x000284BC File Offset: 0x000266BC
				public static GameObject Darkness
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/EditPlaylistPopup/Darkness");
					}
				}

				// Token: 0x1700027A RID: 634
				// (get) Token: 0x0600090C RID: 2316 RVA: 0x000284D8 File Offset: 0x000266D8
				public static GameObject Popup
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/EditPlaylistPopup/Popup");
					}
				}

				// Token: 0x020001F8 RID: 504
				public class Popup_3
				{
					// Token: 0x1700054D RID: 1357
					// (get) Token: 0x06000CD6 RID: 3286 RVA: 0x0002DF30 File Offset: 0x0002C130
					public static GameObject BorderImage
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/EditPlaylistPopup/Popup/BorderImage");
						}
					}

					// Token: 0x1700054E RID: 1358
					// (get) Token: 0x06000CD7 RID: 3287 RVA: 0x0002DF4C File Offset: 0x0002C14C
					public static GameObject Panel
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/EditPlaylistPopup/Popup/Panel");
						}
					}

					// Token: 0x1700054F RID: 1359
					// (get) Token: 0x06000CD8 RID: 3288 RVA: 0x0002DF68 File Offset: 0x0002C168
					public static GameObject ExitButton
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/EditPlaylistPopup/Popup/ExitButton");
						}
					}

					// Token: 0x17000550 RID: 1360
					// (get) Token: 0x06000CD9 RID: 3289 RVA: 0x0002DF84 File Offset: 0x0002C184
					public static GameObject EditPlaylistTitleText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/EditPlaylistPopup/Popup/EditPlaylistTitleText");
						}
					}

					// Token: 0x17000551 RID: 1361
					// (get) Token: 0x06000CDA RID: 3290 RVA: 0x0002DFA0 File Offset: 0x0002C1A0
					public static GameObject InputFieldPlaylistTitle
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/EditPlaylistPopup/Popup/InputFieldPlaylistTitle");
						}
					}

					// Token: 0x17000552 RID: 1362
					// (get) Token: 0x06000CDB RID: 3291 RVA: 0x0002DFBC File Offset: 0x0002C1BC
					public static GameObject PrivacyStatus
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/EditPlaylistPopup/Popup/PrivacyStatus");
						}
					}

					// Token: 0x17000553 RID: 1363
					// (get) Token: 0x06000CDC RID: 3292 RVA: 0x0002DFD8 File Offset: 0x0002C1D8
					public static GameObject Buttons
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/EditPlaylistPopup/Popup/Buttons");
						}
					}

					// Token: 0x0200034B RID: 843
					public class PrivacyStatus_4
					{
						// Token: 0x170007FF RID: 2047
						// (get) Token: 0x060010DB RID: 4315 RVA: 0x00033A8C File Offset: 0x00031C8C
						public static GameObject Public
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/EditPlaylistPopup/Popup/PrivacyStatus/Public");
							}
						}

						// Token: 0x17000800 RID: 2048
						// (get) Token: 0x060010DC RID: 4316 RVA: 0x00033AA8 File Offset: 0x00031CA8
						public static GameObject Friends
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/EditPlaylistPopup/Popup/PrivacyStatus/Friends");
							}
						}

						// Token: 0x17000801 RID: 2049
						// (get) Token: 0x060010DD RID: 4317 RVA: 0x00033AC4 File Offset: 0x00031CC4
						public static GameObject Private
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/EditPlaylistPopup/Popup/PrivacyStatus/Private");
							}
						}

						// Token: 0x02000421 RID: 1057
						public class Public_5
						{
							// Token: 0x1700096D RID: 2413
							// (get) Token: 0x0600131F RID: 4895 RVA: 0x00036C9C File Offset: 0x00034E9C
							public static GameObject PrivacyIcon
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/EditPlaylistPopup/Popup/PrivacyStatus/Public/PrivacyIcon");
								}
							}

							// Token: 0x1700096E RID: 2414
							// (get) Token: 0x06001320 RID: 4896 RVA: 0x00036CB8 File Offset: 0x00034EB8
							public static GameObject Description
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/EditPlaylistPopup/Popup/PrivacyStatus/Public/Description");
								}
							}

							// Token: 0x1700096F RID: 2415
							// (get) Token: 0x06001321 RID: 4897 RVA: 0x00036CD4 File Offset: 0x00034ED4
							public static GameObject Highlight
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/EditPlaylistPopup/Popup/PrivacyStatus/Public/Highlight");
								}
							}
						}

						// Token: 0x02000422 RID: 1058
						public class Friends_5
						{
							// Token: 0x17000970 RID: 2416
							// (get) Token: 0x06001323 RID: 4899 RVA: 0x00036CFC File Offset: 0x00034EFC
							public static GameObject PrivacyIcon
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/EditPlaylistPopup/Popup/PrivacyStatus/Friends/PrivacyIcon");
								}
							}

							// Token: 0x17000971 RID: 2417
							// (get) Token: 0x06001324 RID: 4900 RVA: 0x00036D18 File Offset: 0x00034F18
							public static GameObject Description
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/EditPlaylistPopup/Popup/PrivacyStatus/Friends/Description");
								}
							}

							// Token: 0x17000972 RID: 2418
							// (get) Token: 0x06001325 RID: 4901 RVA: 0x00036D34 File Offset: 0x00034F34
							public static GameObject Highlight
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/EditPlaylistPopup/Popup/PrivacyStatus/Friends/Highlight");
								}
							}
						}

						// Token: 0x02000423 RID: 1059
						public class Private_5
						{
							// Token: 0x17000973 RID: 2419
							// (get) Token: 0x06001327 RID: 4903 RVA: 0x00036D5C File Offset: 0x00034F5C
							public static GameObject PrivacyIcon
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/EditPlaylistPopup/Popup/PrivacyStatus/Private/PrivacyIcon");
								}
							}

							// Token: 0x17000974 RID: 2420
							// (get) Token: 0x06001328 RID: 4904 RVA: 0x00036D78 File Offset: 0x00034F78
							public static GameObject Description
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/EditPlaylistPopup/Popup/PrivacyStatus/Private/Description");
								}
							}

							// Token: 0x17000975 RID: 2421
							// (get) Token: 0x06001329 RID: 4905 RVA: 0x00036D94 File Offset: 0x00034F94
							public static GameObject Highlight
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/EditPlaylistPopup/Popup/PrivacyStatus/Private/Highlight");
								}
							}
						}
					}

					// Token: 0x0200034C RID: 844
					public class Buttons_4
					{
						// Token: 0x17000802 RID: 2050
						// (get) Token: 0x060010DF RID: 4319 RVA: 0x00033AEC File Offset: 0x00031CEC
						public static GameObject ClearButton
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/EditPlaylistPopup/Popup/Buttons/ClearButton");
							}
						}

						// Token: 0x17000803 RID: 2051
						// (get) Token: 0x060010E0 RID: 4320 RVA: 0x00033B08 File Offset: 0x00031D08
						public static GameObject UpdateButton
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/EditPlaylistPopup/Popup/Buttons/UpdateButton");
							}
						}

						// Token: 0x02000424 RID: 1060
						public class ClearButton_5
						{
							// Token: 0x17000976 RID: 2422
							// (get) Token: 0x0600132B RID: 4907 RVA: 0x00036DBC File Offset: 0x00034FBC
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/EditPlaylistPopup/Popup/Buttons/ClearButton/Text");
								}
							}
						}

						// Token: 0x02000425 RID: 1061
						public class UpdateButton_5
						{
							// Token: 0x17000977 RID: 2423
							// (get) Token: 0x0600132D RID: 4909 RVA: 0x00036DE4 File Offset: 0x00034FE4
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/EditPlaylistPopup/Popup/Buttons/UpdateButton/Text");
								}
							}
						}
					}
				}
			}

			// Token: 0x0200010B RID: 267
			public class LoadingPopup_2
			{
				// Token: 0x1700027B RID: 635
				// (get) Token: 0x0600090E RID: 2318 RVA: 0x00028500 File Offset: 0x00026700
				public static GameObject ButtonMiddle
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/ButtonMiddle");
					}
				}

				// Token: 0x1700027C RID: 636
				// (get) Token: 0x0600090F RID: 2319 RVA: 0x0002851C File Offset: 0x0002671C
				public static GameObject LoadingSound
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/LoadingSound");
					}
				}

				// Token: 0x1700027D RID: 637
				// (get) Token: 0x06000910 RID: 2320 RVA: 0x00028538 File Offset: 0x00026738
				public static GameObject ProgressPanel
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel");
					}
				}

				// Token: 0x1700027E RID: 638
				// (get) Token: 0x06000911 RID: 2321 RVA: 0x00028554 File Offset: 0x00026754
				public static GameObject DElements
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements");
					}
				}

				// Token: 0x1700027F RID: 639
				// (get) Token: 0x06000912 RID: 2322 RVA: 0x00028570 File Offset: 0x00026770
				public static GameObject MirroredElements
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/MirroredElements");
					}
				}

				// Token: 0x020001F9 RID: 505
				public class ButtonMiddle_3
				{
					// Token: 0x17000554 RID: 1364
					// (get) Token: 0x06000CDE RID: 3294 RVA: 0x0002E000 File Offset: 0x0002C200
					public static GameObject Text
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/ButtonMiddle/Text");
						}
					}
				}

				// Token: 0x020001FA RID: 506
				public class ProgressPanel_3
				{
					// Token: 0x17000555 RID: 1365
					// (get) Token: 0x06000CE0 RID: 3296 RVA: 0x0002E028 File Offset: 0x0002C228
					public static GameObject Parent_Loading_Progress
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress");
						}
					}

					// Token: 0x0200034D RID: 845
					public class Parent_Loading_Progress_4
					{
						// Token: 0x17000804 RID: 2052
						// (get) Token: 0x060010E2 RID: 4322 RVA: 0x00033B30 File Offset: 0x00031D30
						public static GameObject Panel_Backdrop
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Panel_Backdrop");
							}
						}

						// Token: 0x17000805 RID: 2053
						// (get) Token: 0x060010E3 RID: 4323 RVA: 0x00033B4C File Offset: 0x00031D4C
						public static GameObject Decoration_Left
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Decoration_Left");
							}
						}

						// Token: 0x17000806 RID: 2054
						// (get) Token: 0x060010E4 RID: 4324 RVA: 0x00033B68 File Offset: 0x00031D68
						public static GameObject Decoration_Right
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Decoration_Right");
							}
						}

						// Token: 0x17000807 RID: 2055
						// (get) Token: 0x060010E5 RID: 4325 RVA: 0x00033B84 File Offset: 0x00031D84
						public static GameObject Loading_Elements
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Loading Elements");
							}
						}

						// Token: 0x17000808 RID: 2056
						// (get) Token: 0x060010E6 RID: 4326 RVA: 0x00033BA0 File Offset: 0x00031DA0
						public static GameObject GoButton
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/GoButton");
							}
						}

						// Token: 0x02000426 RID: 1062
						public class Loading_Elements_5
						{
							// Token: 0x17000978 RID: 2424
							// (get) Token: 0x0600132F RID: 4911 RVA: 0x00036E0C File Offset: 0x0003500C
							public static GameObject txt_LOADING
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Loading Elements/txt_LOADING");
								}
							}

							// Token: 0x17000979 RID: 2425
							// (get) Token: 0x06001330 RID: 4912 RVA: 0x00036E28 File Offset: 0x00035028
							public static GameObject txt_Percent
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Loading Elements/txt_Percent");
								}
							}

							// Token: 0x1700097A RID: 2426
							// (get) Token: 0x06001331 RID: 4913 RVA: 0x00036E44 File Offset: 0x00035044
							public static GameObject txt_LOADING_Size
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Loading Elements/txt_LOADING_Size");
								}
							}

							// Token: 0x1700097B RID: 2427
							// (get) Token: 0x06001332 RID: 4914 RVA: 0x00036E60 File Offset: 0x00035060
							public static GameObject LOADING_BAR_BG
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Loading Elements/LOADING_BAR_BG");
								}
							}

							// Token: 0x1700097C RID: 2428
							// (get) Token: 0x06001333 RID: 4915 RVA: 0x00036E7C File Offset: 0x0003507C
							public static GameObject LOADING_BAR
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Loading Elements/LOADING_BAR");
								}
							}
						}

						// Token: 0x02000427 RID: 1063
						public class GoButton_5
						{
							// Token: 0x1700097D RID: 2429
							// (get) Token: 0x06001335 RID: 4917 RVA: 0x00036EA4 File Offset: 0x000350A4
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/GoButton/Text");
								}
							}
						}
					}
				}

				// Token: 0x020001FB RID: 507
				public class DElements_3
				{
					// Token: 0x17000556 RID: 1366
					// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x0002E050 File Offset: 0x0002C250
					public static GameObject LoadingBackground_TealGradient
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingBackground_TealGradient");
						}
					}

					// Token: 0x17000557 RID: 1367
					// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x0002E06C File Offset: 0x0002C26C
					public static GameObject LoadingInfoPanel
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingInfoPanel");
						}
					}

					// Token: 0x0200034E RID: 846
					public class LoadingBackground_TealGradient_4
					{
						// Token: 0x17000809 RID: 2057
						// (get) Token: 0x060010E8 RID: 4328 RVA: 0x00033BC8 File Offset: 0x00031DC8
						public static GameObject _FX_ParticleBubbles
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingBackground_TealGradient/_FX_ParticleBubbles");
							}
						}

						// Token: 0x1700080A RID: 2058
						// (get) Token: 0x060010E9 RID: 4329 RVA: 0x00033BE4 File Offset: 0x00031DE4
						public static GameObject SkyCube_Baked
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingBackground_TealGradient/SkyCube_Baked");
							}
						}

						// Token: 0x1700080B RID: 2059
						// (get) Token: 0x060010EA RID: 4330 RVA: 0x00033C00 File Offset: 0x00031E00
						public static GameObject _Lighting_1
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingBackground_TealGradient/_Lighting (1)");
							}
						}

						// Token: 0x02000428 RID: 1064
						public class _FX_ParticleBubbles_5
						{
							// Token: 0x1700097E RID: 2430
							// (get) Token: 0x06001337 RID: 4919 RVA: 0x00036ECC File Offset: 0x000350CC
							public static GameObject FX_snow
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingBackground_TealGradient/_FX_ParticleBubbles/FX_snow");
								}
							}

							// Token: 0x1700097F RID: 2431
							// (get) Token: 0x06001338 RID: 4920 RVA: 0x00036EE8 File Offset: 0x000350E8
							public static GameObject FX_floor
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingBackground_TealGradient/_FX_ParticleBubbles/FX_floor");
								}
							}

							// Token: 0x17000980 RID: 2432
							// (get) Token: 0x06001339 RID: 4921 RVA: 0x00036F04 File Offset: 0x00035104
							public static GameObject FX_CloseParticles
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingBackground_TealGradient/_FX_ParticleBubbles/FX_CloseParticles");
								}
							}
						}

						// Token: 0x02000429 RID: 1065
						public class _Lighting_1_5
						{
							// Token: 0x17000981 RID: 2433
							// (get) Token: 0x0600133B RID: 4923 RVA: 0x00036F2C File Offset: 0x0003512C
							public static GameObject Reflection_Probe
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingBackground_TealGradient/_Lighting (1)/Reflection Probe");
								}
							}

							// Token: 0x17000982 RID: 2434
							// (get) Token: 0x0600133C RID: 4924 RVA: 0x00036F48 File Offset: 0x00035148
							public static GameObject Point_light
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingBackground_TealGradient/_Lighting (1)/Point light");
								}
							}

							// Token: 0x17000983 RID: 2435
							// (get) Token: 0x0600133D RID: 4925 RVA: 0x00036F64 File Offset: 0x00035164
							public static GameObject Light_Probe_Group
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingBackground_TealGradient/_Lighting (1)/Light Probe Group");
								}
							}
						}
					}

					// Token: 0x0200034F RID: 847
					public class LoadingInfoPanel_4
					{
						// Token: 0x1700080C RID: 2060
						// (get) Token: 0x060010EC RID: 4332 RVA: 0x00033C28 File Offset: 0x00031E28
						public static GameObject InfoPanel_Template_ANIM
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingInfoPanel/InfoPanel_Template_ANIM");
							}
						}

						// Token: 0x0200042A RID: 1066
						public class InfoPanel_Template_ANIM_5
						{
							// Token: 0x17000984 RID: 2436
							// (get) Token: 0x0600133F RID: 4927 RVA: 0x00036F8C File Offset: 0x0003518C
							public static GameObject ICON
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingInfoPanel/InfoPanel_Template_ANIM/ICON");
								}
							}

							// Token: 0x17000985 RID: 2437
							// (get) Token: 0x06001340 RID: 4928 RVA: 0x00036FA8 File Offset: 0x000351A8
							public static GameObject SCREEN
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingInfoPanel/InfoPanel_Template_ANIM/SCREEN");
								}
							}

							// Token: 0x17000986 RID: 2438
							// (get) Token: 0x06001341 RID: 4929 RVA: 0x00036FC4 File Offset: 0x000351C4
							public static GameObject TITLE
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingInfoPanel/InfoPanel_Template_ANIM/TITLE");
								}
							}

							// Token: 0x17000987 RID: 2439
							// (get) Token: 0x06001342 RID: 4930 RVA: 0x00036FE0 File Offset: 0x000351E0
							public static GameObject LoadingSceen_2_Sstatic_colliders
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingInfoPanel/InfoPanel_Template_ANIM/LoadingSceen_2_Sstatic_colliders");
								}
							}
						}
					}
				}

				// Token: 0x020001FC RID: 508
				public class MirroredElements_3
				{
					// Token: 0x17000558 RID: 1368
					// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x0002E094 File Offset: 0x0002C294
					public static GameObject ButtonMiddle_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/MirroredElements/ButtonMiddle (1)");
						}
					}

					// Token: 0x17000559 RID: 1369
					// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x0002E0B0 File Offset: 0x0002C2B0
					public static GameObject ProgressPanel_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/MirroredElements/ProgressPanel (1)");
						}
					}

					// Token: 0x1700055A RID: 1370
					// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x0002E0CC File Offset: 0x0002C2CC
					public static GameObject LoadingInfoPanel
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/MirroredElements/LoadingInfoPanel");
						}
					}

					// Token: 0x02000350 RID: 848
					public class ButtonMiddle_1_4
					{
						// Token: 0x1700080D RID: 2061
						// (get) Token: 0x060010EE RID: 4334 RVA: 0x00033C50 File Offset: 0x00031E50
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/MirroredElements/ButtonMiddle (1)/Text");
							}
						}
					}

					// Token: 0x02000351 RID: 849
					public class ProgressPanel_1_4
					{
						// Token: 0x1700080E RID: 2062
						// (get) Token: 0x060010F0 RID: 4336 RVA: 0x00033C78 File Offset: 0x00031E78
						public static GameObject Parent_Loading_Progress
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/MirroredElements/ProgressPanel (1)/Parent_Loading_Progress");
							}
						}

						// Token: 0x0200042B RID: 1067
						public class Parent_Loading_Progress_5
						{
							// Token: 0x17000988 RID: 2440
							// (get) Token: 0x06001344 RID: 4932 RVA: 0x00037008 File Offset: 0x00035208
							public static GameObject Panel_Backdrop
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/MirroredElements/ProgressPanel (1)/Parent_Loading_Progress/Panel_Backdrop");
								}
							}

							// Token: 0x17000989 RID: 2441
							// (get) Token: 0x06001345 RID: 4933 RVA: 0x00037024 File Offset: 0x00035224
							public static GameObject Decoration_Left
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/MirroredElements/ProgressPanel (1)/Parent_Loading_Progress/Decoration_Left");
								}
							}

							// Token: 0x1700098A RID: 2442
							// (get) Token: 0x06001346 RID: 4934 RVA: 0x00037040 File Offset: 0x00035240
							public static GameObject Decoration_Right
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/MirroredElements/ProgressPanel (1)/Parent_Loading_Progress/Decoration_Right");
								}
							}

							// Token: 0x1700098B RID: 2443
							// (get) Token: 0x06001347 RID: 4935 RVA: 0x0003705C File Offset: 0x0003525C
							public static GameObject Loading_Elements
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/MirroredElements/ProgressPanel (1)/Parent_Loading_Progress/Loading Elements");
								}
							}

							// Token: 0x1700098C RID: 2444
							// (get) Token: 0x06001348 RID: 4936 RVA: 0x00037078 File Offset: 0x00035278
							public static GameObject GoButton
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/MirroredElements/ProgressPanel (1)/Parent_Loading_Progress/GoButton");
								}
							}
						}
					}

					// Token: 0x02000352 RID: 850
					public class LoadingInfoPanel_4
					{
						// Token: 0x1700080F RID: 2063
						// (get) Token: 0x060010F2 RID: 4338 RVA: 0x00033CA0 File Offset: 0x00031EA0
						public static GameObject InfoPanel_Template_ANIM
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/MirroredElements/LoadingInfoPanel/InfoPanel_Template_ANIM");
							}
						}

						// Token: 0x0200042C RID: 1068
						public class InfoPanel_Template_ANIM_5
						{
							// Token: 0x1700098D RID: 2445
							// (get) Token: 0x0600134A RID: 4938 RVA: 0x000370A0 File Offset: 0x000352A0
							public static GameObject ICON
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/MirroredElements/LoadingInfoPanel/InfoPanel_Template_ANIM/ICON");
								}
							}

							// Token: 0x1700098E RID: 2446
							// (get) Token: 0x0600134B RID: 4939 RVA: 0x000370BC File Offset: 0x000352BC
							public static GameObject SCREEN
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/MirroredElements/LoadingInfoPanel/InfoPanel_Template_ANIM/SCREEN");
								}
							}

							// Token: 0x1700098F RID: 2447
							// (get) Token: 0x0600134C RID: 4940 RVA: 0x000370D8 File Offset: 0x000352D8
							public static GameObject TITLE
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/MirroredElements/LoadingInfoPanel/InfoPanel_Template_ANIM/TITLE");
								}
							}

							// Token: 0x17000990 RID: 2448
							// (get) Token: 0x0600134D RID: 4941 RVA: 0x000370F4 File Offset: 0x000352F4
							public static GameObject LoadingSceen_2_Sstatic_colliders
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/MirroredElements/LoadingInfoPanel/InfoPanel_Template_ANIM/LoadingSceen_2_Sstatic_colliders");
								}
							}
						}
					}
				}
			}

			// Token: 0x0200010C RID: 268
			public class ReportWorldPopup_2
			{
				// Token: 0x17000280 RID: 640
				// (get) Token: 0x06000914 RID: 2324 RVA: 0x00028598 File Offset: 0x00026798
				public static GameObject Darkness
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Darkness");
					}
				}

				// Token: 0x17000281 RID: 641
				// (get) Token: 0x06000915 RID: 2325 RVA: 0x000285B4 File Offset: 0x000267B4
				public static GameObject Popup
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup");
					}
				}

				// Token: 0x020001FD RID: 509
				public class Popup_3
				{
					// Token: 0x1700055B RID: 1371
					// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x0002E0F4 File Offset: 0x0002C2F4
					public static GameObject BorderImage
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/BorderImage");
						}
					}

					// Token: 0x1700055C RID: 1372
					// (get) Token: 0x06000CEA RID: 3306 RVA: 0x0002E110 File Offset: 0x0002C310
					public static GameObject Panel
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Panel");
						}
					}

					// Token: 0x1700055D RID: 1373
					// (get) Token: 0x06000CEB RID: 3307 RVA: 0x0002E12C File Offset: 0x0002C32C
					public static GameObject TitleText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/TitleText");
						}
					}

					// Token: 0x1700055E RID: 1374
					// (get) Token: 0x06000CEC RID: 3308 RVA: 0x0002E148 File Offset: 0x0002C348
					public static GameObject ExitButton
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/ExitButton");
						}
					}

					// Token: 0x1700055F RID: 1375
					// (get) Token: 0x06000CED RID: 3309 RVA: 0x0002E164 File Offset: 0x0002C364
					public static GameObject EmailText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/EmailText");
						}
					}

					// Token: 0x17000560 RID: 1376
					// (get) Token: 0x06000CEE RID: 3310 RVA: 0x0002E180 File Offset: 0x0002C380
					public static GameObject Pages
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages");
						}
					}

					// Token: 0x02000353 RID: 851
					public class Pages_4
					{
						// Token: 0x17000810 RID: 2064
						// (get) Token: 0x060010F4 RID: 4340 RVA: 0x00033CC8 File Offset: 0x00031EC8
						public static GameObject Page1
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/Page1");
							}
						}

						// Token: 0x17000811 RID: 2065
						// (get) Token: 0x060010F5 RID: 4341 RVA: 0x00033CE4 File Offset: 0x00031EE4
						public static GameObject Page2
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/Page2");
							}
						}

						// Token: 0x17000812 RID: 2066
						// (get) Token: 0x060010F6 RID: 4342 RVA: 0x00033D00 File Offset: 0x00031F00
						public static GameObject ThanksPage
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/ThanksPage");
							}
						}

						// Token: 0x17000813 RID: 2067
						// (get) Token: 0x060010F7 RID: 4343 RVA: 0x00033D1C File Offset: 0x00031F1C
						public static GameObject ErrorPage
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/ErrorPage");
							}
						}

						// Token: 0x17000814 RID: 2068
						// (get) Token: 0x060010F8 RID: 4344 RVA: 0x00033D38 File Offset: 0x00031F38
						public static GameObject ResetPage
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/ResetPage");
							}
						}

						// Token: 0x0200042D RID: 1069
						public class Page1_5
						{
							// Token: 0x17000991 RID: 2449
							// (get) Token: 0x0600134F RID: 4943 RVA: 0x0003711C File Offset: 0x0003531C
							public static GameObject Checkboxes
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/Page1/Checkboxes");
								}
							}

							// Token: 0x17000992 RID: 2450
							// (get) Token: 0x06001350 RID: 4944 RVA: 0x00037138 File Offset: 0x00035338
							public static GameObject NextButton
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/Page1/NextButton");
								}
							}

							// Token: 0x17000993 RID: 2451
							// (get) Token: 0x06001351 RID: 4945 RVA: 0x00037154 File Offset: 0x00035354
							public static GameObject WhereText
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/Page1/WhereText");
								}
							}
						}

						// Token: 0x0200042E RID: 1070
						public class Page2_5
						{
							// Token: 0x17000994 RID: 2452
							// (get) Token: 0x06001353 RID: 4947 RVA: 0x0003717C File Offset: 0x0003537C
							public static GameObject Checkboxes
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/Page2/Checkboxes");
								}
							}

							// Token: 0x17000995 RID: 2453
							// (get) Token: 0x06001354 RID: 4948 RVA: 0x00037198 File Offset: 0x00035398
							public static GameObject SubmitButton
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/Page2/SubmitButton");
								}
							}

							// Token: 0x17000996 RID: 2454
							// (get) Token: 0x06001355 RID: 4949 RVA: 0x000371B4 File Offset: 0x000353B4
							public static GameObject WhereCategoryText
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/Page2/WhereCategoryText");
								}
							}

							// Token: 0x17000997 RID: 2455
							// (get) Token: 0x06001356 RID: 4950 RVA: 0x000371D0 File Offset: 0x000353D0
							public static GameObject WhyText
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/Page2/WhyText");
								}
							}
						}

						// Token: 0x0200042F RID: 1071
						public class ThanksPage_5
						{
							// Token: 0x17000998 RID: 2456
							// (get) Token: 0x06001358 RID: 4952 RVA: 0x000371F8 File Offset: 0x000353F8
							public static GameObject CloseButton
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/ThanksPage/CloseButton");
								}
							}

							// Token: 0x17000999 RID: 2457
							// (get) Token: 0x06001359 RID: 4953 RVA: 0x00037214 File Offset: 0x00035414
							public static GameObject ThanksText
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/ThanksPage/ThanksText");
								}
							}

							// Token: 0x1700099A RID: 2458
							// (get) Token: 0x0600135A RID: 4954 RVA: 0x00037230 File Offset: 0x00035430
							public static GameObject WarningText
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/ThanksPage/WarningText");
								}
							}
						}

						// Token: 0x02000430 RID: 1072
						public class ErrorPage_5
						{
							// Token: 0x1700099B RID: 2459
							// (get) Token: 0x0600135C RID: 4956 RVA: 0x00037258 File Offset: 0x00035458
							public static GameObject CloseButton
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/ErrorPage/CloseButton");
								}
							}

							// Token: 0x1700099C RID: 2460
							// (get) Token: 0x0600135D RID: 4957 RVA: 0x00037274 File Offset: 0x00035474
							public static GameObject ErrorText
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/ErrorPage/ErrorText");
								}
							}
						}

						// Token: 0x02000431 RID: 1073
						public class ResetPage_5
						{
							// Token: 0x1700099D RID: 2461
							// (get) Token: 0x0600135F RID: 4959 RVA: 0x0003729C File Offset: 0x0003549C
							public static GameObject CloseButton
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/ResetPage/CloseButton");
								}
							}

							// Token: 0x1700099E RID: 2462
							// (get) Token: 0x06001360 RID: 4960 RVA: 0x000372B8 File Offset: 0x000354B8
							public static GameObject Reset_Report
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/ResetPage/Reset Report");
								}
							}

							// Token: 0x1700099F RID: 2463
							// (get) Token: 0x06001361 RID: 4961 RVA: 0x000372D4 File Offset: 0x000354D4
							public static GameObject ResetText
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/ResetPage/ResetText");
								}
							}
						}
					}
				}
			}

			// Token: 0x0200010D RID: 269
			public class RoomInfoPopup_2
			{
				// Token: 0x17000282 RID: 642
				// (get) Token: 0x06000917 RID: 2327 RVA: 0x000285DC File Offset: 0x000267DC
				public static GameObject Darkness
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInfoPopup/Darkness");
					}
				}

				// Token: 0x17000283 RID: 643
				// (get) Token: 0x06000918 RID: 2328 RVA: 0x000285F8 File Offset: 0x000267F8
				public static GameObject Popup
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInfoPopup/Popup");
					}
				}

				// Token: 0x020001FE RID: 510
				public class Popup_3
				{
					// Token: 0x17000561 RID: 1377
					// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x0002E1A8 File Offset: 0x0002C3A8
					public static GameObject BorderImage
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInfoPopup/Popup/BorderImage");
						}
					}

					// Token: 0x17000562 RID: 1378
					// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x0002E1C4 File Offset: 0x0002C3C4
					public static GameObject RoomPicture
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInfoPopup/Popup/RoomPicture");
						}
					}

					// Token: 0x17000563 RID: 1379
					// (get) Token: 0x06000CF2 RID: 3314 RVA: 0x0002E1E0 File Offset: 0x0002C3E0
					public static GameObject NameText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInfoPopup/Popup/NameText");
						}
					}

					// Token: 0x17000564 RID: 1380
					// (get) Token: 0x06000CF3 RID: 3315 RVA: 0x0002E1FC File Offset: 0x0002C3FC
					public static GameObject AuthorText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInfoPopup/Popup/AuthorText");
						}
					}

					// Token: 0x17000565 RID: 1381
					// (get) Token: 0x06000CF4 RID: 3316 RVA: 0x0002E218 File Offset: 0x0002C418
					public static GameObject Buttons
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInfoPopup/Popup/Buttons");
						}
					}

					// Token: 0x17000566 RID: 1382
					// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x0002E234 File Offset: 0x0002C434
					public static GameObject ExitButton
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInfoPopup/Popup/ExitButton");
						}
					}

					// Token: 0x02000354 RID: 852
					public class RoomPicture_4
					{
						// Token: 0x17000815 RID: 2069
						// (get) Token: 0x060010FA RID: 4346 RVA: 0x00033D60 File Offset: 0x00031F60
						public static GameObject RoomImage
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInfoPopup/Popup/RoomPicture/RoomImage");
							}
						}

						// Token: 0x17000816 RID: 2070
						// (get) Token: 0x060010FB RID: 4347 RVA: 0x00033D7C File Offset: 0x00031F7C
						public static GameObject RoomBorder
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInfoPopup/Popup/RoomPicture/RoomBorder");
							}
						}
					}

					// Token: 0x02000355 RID: 853
					public class Buttons_4
					{
						// Token: 0x17000817 RID: 2071
						// (get) Token: 0x060010FD RID: 4349 RVA: 0x00033DA4 File Offset: 0x00031FA4
						public static GameObject PortalButton
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInfoPopup/Popup/Buttons/PortalButton");
							}
						}

						// Token: 0x17000818 RID: 2072
						// (get) Token: 0x060010FE RID: 4350 RVA: 0x00033DC0 File Offset: 0x00031FC0
						public static GameObject JoinButton
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInfoPopup/Popup/Buttons/JoinButton");
							}
						}

						// Token: 0x17000819 RID: 2073
						// (get) Token: 0x060010FF RID: 4351 RVA: 0x00033DDC File Offset: 0x00031FDC
						public static GameObject CloseButton
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInfoPopup/Popup/Buttons/CloseButton");
							}
						}

						// Token: 0x02000432 RID: 1074
						public class PortalButton_5
						{
							// Token: 0x170009A0 RID: 2464
							// (get) Token: 0x06001363 RID: 4963 RVA: 0x000372FC File Offset: 0x000354FC
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInfoPopup/Popup/Buttons/PortalButton/Text");
								}
							}
						}

						// Token: 0x02000433 RID: 1075
						public class JoinButton_5
						{
							// Token: 0x170009A1 RID: 2465
							// (get) Token: 0x06001365 RID: 4965 RVA: 0x00037324 File Offset: 0x00035524
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInfoPopup/Popup/Buttons/JoinButton/Text");
								}
							}
						}

						// Token: 0x02000434 RID: 1076
						public class CloseButton_5
						{
							// Token: 0x170009A2 RID: 2466
							// (get) Token: 0x06001367 RID: 4967 RVA: 0x0003734C File Offset: 0x0003554C
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInfoPopup/Popup/Buttons/CloseButton/Text");
								}
							}
						}
					}
				}
			}

			// Token: 0x0200010E RID: 270
			public class RoomInstancePopup_2
			{
				// Token: 0x17000284 RID: 644
				// (get) Token: 0x0600091A RID: 2330 RVA: 0x00028620 File Offset: 0x00026820
				public static GameObject Darkness
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Darkness");
					}
				}

				// Token: 0x17000285 RID: 645
				// (get) Token: 0x0600091B RID: 2331 RVA: 0x0002863C File Offset: 0x0002683C
				public static GameObject Popup
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup");
					}
				}

				// Token: 0x020001FF RID: 511
				public class Popup_3
				{
					// Token: 0x17000567 RID: 1383
					// (get) Token: 0x06000CF7 RID: 3319 RVA: 0x0002E25C File Offset: 0x0002C45C
					public static GameObject BorderImage
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/BorderImage");
						}
					}

					// Token: 0x17000568 RID: 1384
					// (get) Token: 0x06000CF8 RID: 3320 RVA: 0x0002E278 File Offset: 0x0002C478
					public static GameObject BorderImage_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/BorderImage (1)");
						}
					}

					// Token: 0x17000569 RID: 1385
					// (get) Token: 0x06000CF9 RID: 3321 RVA: 0x0002E294 File Offset: 0x0002C494
					public static GameObject Panel
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Panel");
						}
					}

					// Token: 0x1700056A RID: 1386
					// (get) Token: 0x06000CFA RID: 3322 RVA: 0x0002E2B0 File Offset: 0x0002C4B0
					public static GameObject InstanceText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/InstanceText");
						}
					}

					// Token: 0x1700056B RID: 1387
					// (get) Token: 0x06000CFB RID: 3323 RVA: 0x0002E2CC File Offset: 0x0002C4CC
					public static GameObject NameText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/NameText");
						}
					}

					// Token: 0x1700056C RID: 1388
					// (get) Token: 0x06000CFC RID: 3324 RVA: 0x0002E2E8 File Offset: 0x0002C4E8
					public static GameObject Buttons
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Buttons");
						}
					}

					// Token: 0x1700056D RID: 1389
					// (get) Token: 0x06000CFD RID: 3325 RVA: 0x0002E304 File Offset: 0x0002C504
					public static GameObject ExitButton
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/ExitButton");
						}
					}

					// Token: 0x02000356 RID: 854
					public class Buttons_4
					{
						// Token: 0x1700081A RID: 2074
						// (get) Token: 0x06001101 RID: 4353 RVA: 0x00033E04 File Offset: 0x00032004
						public static GameObject PublicButton
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Buttons/PublicButton");
							}
						}

						// Token: 0x1700081B RID: 2075
						// (get) Token: 0x06001102 RID: 4354 RVA: 0x00033E20 File Offset: 0x00032020
						public static GameObject FriendsOfGuestsButton
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Buttons/FriendsOfGuestsButton");
							}
						}

						// Token: 0x1700081C RID: 2076
						// (get) Token: 0x06001103 RID: 4355 RVA: 0x00033E3C File Offset: 0x0003203C
						public static GameObject FriendsOnlyButton
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Buttons/FriendsOnlyButton");
							}
						}

						// Token: 0x1700081D RID: 2077
						// (get) Token: 0x06001104 RID: 4356 RVA: 0x00033E58 File Offset: 0x00032058
						public static GameObject InvitePlusButton
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Buttons/InvitePlusButton");
							}
						}

						// Token: 0x1700081E RID: 2078
						// (get) Token: 0x06001105 RID: 4357 RVA: 0x00033E74 File Offset: 0x00032074
						public static GameObject InviteOnlyButton
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Buttons/InviteOnlyButton");
							}
						}

						// Token: 0x02000435 RID: 1077
						public class PublicButton_5
						{
							// Token: 0x170009A3 RID: 2467
							// (get) Token: 0x06001369 RID: 4969 RVA: 0x00037374 File Offset: 0x00035574
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Buttons/PublicButton/Text");
								}
							}

							// Token: 0x170009A4 RID: 2468
							// (get) Token: 0x0600136A RID: 4970 RVA: 0x00037390 File Offset: 0x00035590
							public static GameObject PublicDescription
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Buttons/PublicButton/PublicDescription");
								}
							}
						}

						// Token: 0x02000436 RID: 1078
						public class FriendsOfGuestsButton_5
						{
							// Token: 0x170009A5 RID: 2469
							// (get) Token: 0x0600136C RID: 4972 RVA: 0x000373B8 File Offset: 0x000355B8
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Buttons/FriendsOfGuestsButton/Text");
								}
							}

							// Token: 0x170009A6 RID: 2470
							// (get) Token: 0x0600136D RID: 4973 RVA: 0x000373D4 File Offset: 0x000355D4
							public static GameObject FOGDescription
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Buttons/FriendsOfGuestsButton/FOGDescription");
								}
							}
						}

						// Token: 0x02000437 RID: 1079
						public class FriendsOnlyButton_5
						{
							// Token: 0x170009A7 RID: 2471
							// (get) Token: 0x0600136F RID: 4975 RVA: 0x000373FC File Offset: 0x000355FC
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Buttons/FriendsOnlyButton/Text");
								}
							}

							// Token: 0x170009A8 RID: 2472
							// (get) Token: 0x06001370 RID: 4976 RVA: 0x00037418 File Offset: 0x00035618
							public static GameObject FriendsDescription
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Buttons/FriendsOnlyButton/FriendsDescription");
								}
							}
						}

						// Token: 0x02000438 RID: 1080
						public class InvitePlusButton_5
						{
							// Token: 0x170009A9 RID: 2473
							// (get) Token: 0x06001372 RID: 4978 RVA: 0x00037440 File Offset: 0x00035640
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Buttons/InvitePlusButton/Text");
								}
							}

							// Token: 0x170009AA RID: 2474
							// (get) Token: 0x06001373 RID: 4979 RVA: 0x0003745C File Offset: 0x0003565C
							public static GameObject InviteDescription
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Buttons/InvitePlusButton/InviteDescription");
								}
							}
						}

						// Token: 0x02000439 RID: 1081
						public class InviteOnlyButton_5
						{
							// Token: 0x170009AB RID: 2475
							// (get) Token: 0x06001375 RID: 4981 RVA: 0x00037484 File Offset: 0x00035684
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Buttons/InviteOnlyButton/Text");
								}
							}

							// Token: 0x170009AC RID: 2476
							// (get) Token: 0x06001376 RID: 4982 RVA: 0x000374A0 File Offset: 0x000356A0
							public static GameObject InviteDescription
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Buttons/InviteOnlyButton/InviteDescription");
								}
							}
						}
					}
				}
			}

			// Token: 0x0200010F RID: 271
			public class SearchOptionsPopup_2
			{
				// Token: 0x17000286 RID: 646
				// (get) Token: 0x0600091D RID: 2333 RVA: 0x00028664 File Offset: 0x00026864
				public static GameObject Darkness
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/SearchOptionsPopup/Darkness");
					}
				}

				// Token: 0x17000287 RID: 647
				// (get) Token: 0x0600091E RID: 2334 RVA: 0x00028680 File Offset: 0x00026880
				public static GameObject Popup
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/SearchOptionsPopup/Popup");
					}
				}

				// Token: 0x02000200 RID: 512
				public class Popup_3
				{
					// Token: 0x1700056E RID: 1390
					// (get) Token: 0x06000CFF RID: 3327 RVA: 0x0002E32C File Offset: 0x0002C52C
					public static GameObject BorderImage
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/SearchOptionsPopup/Popup/BorderImage");
						}
					}

					// Token: 0x1700056F RID: 1391
					// (get) Token: 0x06000D00 RID: 3328 RVA: 0x0002E348 File Offset: 0x0002C548
					public static GameObject Panel_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/SearchOptionsPopup/Popup/Panel (1)");
						}
					}

					// Token: 0x17000570 RID: 1392
					// (get) Token: 0x06000D01 RID: 3329 RVA: 0x0002E364 File Offset: 0x0002C564
					public static GameObject InstanceText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/SearchOptionsPopup/Popup/InstanceText");
						}
					}

					// Token: 0x17000571 RID: 1393
					// (get) Token: 0x06000D02 RID: 3330 RVA: 0x0002E380 File Offset: 0x0002C580
					public static GameObject Checkboxes
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/SearchOptionsPopup/Popup/Checkboxes");
						}
					}

					// Token: 0x17000572 RID: 1394
					// (get) Token: 0x06000D03 RID: 3331 RVA: 0x0002E39C File Offset: 0x0002C59C
					public static GameObject ConfirmButton
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/SearchOptionsPopup/Popup/ConfirmButton");
						}
					}

					// Token: 0x17000573 RID: 1395
					// (get) Token: 0x06000D04 RID: 3332 RVA: 0x0002E3B8 File Offset: 0x0002C5B8
					public static GameObject ExitButton
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/SearchOptionsPopup/Popup/ExitButton");
						}
					}

					// Token: 0x02000357 RID: 855
					public class Checkboxes_4
					{
						// Token: 0x1700081F RID: 2079
						// (get) Token: 0x06001107 RID: 4359 RVA: 0x00033E9C File Offset: 0x0003209C
						public static GameObject Tags
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/SearchOptionsPopup/Popup/Checkboxes/Tags");
							}
						}

						// Token: 0x17000820 RID: 2080
						// (get) Token: 0x06001108 RID: 4360 RVA: 0x00033EB8 File Offset: 0x000320B8
						public static GameObject Title
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/SearchOptionsPopup/Popup/Checkboxes/Title");
							}
						}

						// Token: 0x0200043A RID: 1082
						public class Tags_5
						{
							// Token: 0x170009AD RID: 2477
							// (get) Token: 0x06001378 RID: 4984 RVA: 0x000374C8 File Offset: 0x000356C8
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/SearchOptionsPopup/Popup/Checkboxes/Tags/Checkmark");
								}
							}

							// Token: 0x170009AE RID: 2478
							// (get) Token: 0x06001379 RID: 4985 RVA: 0x000374E4 File Offset: 0x000356E4
							public static GameObject Description
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/SearchOptionsPopup/Popup/Checkboxes/Tags/Description");
								}
							}
						}

						// Token: 0x0200043B RID: 1083
						public class Title_5
						{
							// Token: 0x170009AF RID: 2479
							// (get) Token: 0x0600137B RID: 4987 RVA: 0x0003750C File Offset: 0x0003570C
							public static GameObject Checkmark
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/SearchOptionsPopup/Popup/Checkboxes/Title/Checkmark");
								}
							}

							// Token: 0x170009B0 RID: 2480
							// (get) Token: 0x0600137C RID: 4988 RVA: 0x00037528 File Offset: 0x00035728
							public static GameObject Description
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/SearchOptionsPopup/Popup/Checkboxes/Title/Description");
								}
							}
						}
					}

					// Token: 0x02000358 RID: 856
					public class ConfirmButton_4
					{
						// Token: 0x17000821 RID: 2081
						// (get) Token: 0x0600110A RID: 4362 RVA: 0x00033EE0 File Offset: 0x000320E0
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/SearchOptionsPopup/Popup/ConfirmButton/Text");
							}
						}
					}
				}
			}

			// Token: 0x02000110 RID: 272
			public class StandardPopup_2
			{
				// Token: 0x17000288 RID: 648
				// (get) Token: 0x06000920 RID: 2336 RVA: 0x000286A8 File Offset: 0x000268A8
				public static GameObject Darkness
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/Darkness");
					}
				}

				// Token: 0x17000289 RID: 649
				// (get) Token: 0x06000921 RID: 2337 RVA: 0x000286C4 File Offset: 0x000268C4
				public static GameObject Rectangle
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/Rectangle");
					}
				}

				// Token: 0x1700028A RID: 650
				// (get) Token: 0x06000922 RID: 2338 RVA: 0x000286E0 File Offset: 0x000268E0
				public static GameObject MidRing
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/MidRing");
					}
				}

				// Token: 0x1700028B RID: 651
				// (get) Token: 0x06000923 RID: 2339 RVA: 0x000286FC File Offset: 0x000268FC
				public static GameObject InnerDashRing
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/InnerDashRing");
					}
				}

				// Token: 0x1700028C RID: 652
				// (get) Token: 0x06000924 RID: 2340 RVA: 0x00028718 File Offset: 0x00026918
				public static GameObject RingGlow
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/RingGlow");
					}
				}

				// Token: 0x1700028D RID: 653
				// (get) Token: 0x06000925 RID: 2341 RVA: 0x00028734 File Offset: 0x00026934
				public static GameObject TitleText
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/TitleText");
					}
				}

				// Token: 0x1700028E RID: 654
				// (get) Token: 0x06000926 RID: 2342 RVA: 0x00028750 File Offset: 0x00026950
				public static GameObject BodyText
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/BodyText");
					}
				}

				// Token: 0x1700028F RID: 655
				// (get) Token: 0x06000927 RID: 2343 RVA: 0x0002876C File Offset: 0x0002696C
				public static GameObject ArrowLeft
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/ArrowLeft");
					}
				}

				// Token: 0x17000290 RID: 656
				// (get) Token: 0x06000928 RID: 2344 RVA: 0x00028788 File Offset: 0x00026988
				public static GameObject ArrowRight
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/ArrowRight");
					}
				}

				// Token: 0x17000291 RID: 657
				// (get) Token: 0x06000929 RID: 2345 RVA: 0x000287A4 File Offset: 0x000269A4
				public static GameObject CornerBL
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/CornerBL");
					}
				}

				// Token: 0x17000292 RID: 658
				// (get) Token: 0x0600092A RID: 2346 RVA: 0x000287C0 File Offset: 0x000269C0
				public static GameObject CornerTL
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/CornerTL");
					}
				}

				// Token: 0x17000293 RID: 659
				// (get) Token: 0x0600092B RID: 2347 RVA: 0x000287DC File Offset: 0x000269DC
				public static GameObject CornerBR
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/CornerBR");
					}
				}

				// Token: 0x17000294 RID: 660
				// (get) Token: 0x0600092C RID: 2348 RVA: 0x000287F8 File Offset: 0x000269F8
				public static GameObject CornerTR
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/CornerTR");
					}
				}

				// Token: 0x17000295 RID: 661
				// (get) Token: 0x0600092D RID: 2349 RVA: 0x00028814 File Offset: 0x00026A14
				public static GameObject ProgressLine
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/ProgressLine");
					}
				}

				// Token: 0x17000296 RID: 662
				// (get) Token: 0x0600092E RID: 2350 RVA: 0x00028830 File Offset: 0x00026A30
				public static GameObject LowPercent
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/LowPercent");
					}
				}

				// Token: 0x17000297 RID: 663
				// (get) Token: 0x0600092F RID: 2351 RVA: 0x0002884C File Offset: 0x00026A4C
				public static GameObject HighPercent
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/HighPercent");
					}
				}

				// Token: 0x17000298 RID: 664
				// (get) Token: 0x06000930 RID: 2352 RVA: 0x00028868 File Offset: 0x00026A68
				public static GameObject ButtonLeft
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/ButtonLeft");
					}
				}

				// Token: 0x17000299 RID: 665
				// (get) Token: 0x06000931 RID: 2353 RVA: 0x00028884 File Offset: 0x00026A84
				public static GameObject ButtonMiddle
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/ButtonMiddle");
					}
				}

				// Token: 0x1700029A RID: 666
				// (get) Token: 0x06000932 RID: 2354 RVA: 0x000288A0 File Offset: 0x00026AA0
				public static GameObject ButtonRight
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/ButtonRight");
					}
				}

				// Token: 0x02000201 RID: 513
				public class ButtonLeft_3
				{
					// Token: 0x17000574 RID: 1396
					// (get) Token: 0x06000D06 RID: 3334 RVA: 0x0002E3E0 File Offset: 0x0002C5E0
					public static GameObject Text
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/ButtonLeft/Text");
						}
					}
				}

				// Token: 0x02000202 RID: 514
				public class ButtonMiddle_3
				{
					// Token: 0x17000575 RID: 1397
					// (get) Token: 0x06000D08 RID: 3336 RVA: 0x0002E408 File Offset: 0x0002C608
					public static GameObject Text
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/ButtonMiddle/Text");
						}
					}
				}

				// Token: 0x02000203 RID: 515
				public class ButtonRight_3
				{
					// Token: 0x17000576 RID: 1398
					// (get) Token: 0x06000D0A RID: 3338 RVA: 0x0002E430 File Offset: 0x0002C630
					public static GameObject Text
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/ButtonRight/Text");
						}
					}
				}
			}

			// Token: 0x02000111 RID: 273
			public class StandardPopupV2_2
			{
				// Token: 0x1700029B RID: 667
				// (get) Token: 0x06000934 RID: 2356 RVA: 0x000288C8 File Offset: 0x00026AC8
				public static GameObject Darkness
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopupV2/Darkness");
					}
				}

				// Token: 0x1700029C RID: 668
				// (get) Token: 0x06000935 RID: 2357 RVA: 0x000288E4 File Offset: 0x00026AE4
				public static GameObject Popup
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopupV2/Popup");
					}
				}

				// Token: 0x02000204 RID: 516
				public class Popup_3
				{
					// Token: 0x17000577 RID: 1399
					// (get) Token: 0x06000D0C RID: 3340 RVA: 0x0002E458 File Offset: 0x0002C658
					public static GameObject BorderImage
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopupV2/Popup/BorderImage");
						}
					}

					// Token: 0x17000578 RID: 1400
					// (get) Token: 0x06000D0D RID: 3341 RVA: 0x0002E474 File Offset: 0x0002C674
					public static GameObject Panel
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopupV2/Popup/Panel");
						}
					}

					// Token: 0x17000579 RID: 1401
					// (get) Token: 0x06000D0E RID: 3342 RVA: 0x0002E490 File Offset: 0x0002C690
					public static GameObject ExitButton
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopupV2/Popup/ExitButton");
						}
					}

					// Token: 0x1700057A RID: 1402
					// (get) Token: 0x06000D0F RID: 3343 RVA: 0x0002E4AC File Offset: 0x0002C6AC
					public static GameObject TitleText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopupV2/Popup/TitleText");
						}
					}

					// Token: 0x1700057B RID: 1403
					// (get) Token: 0x06000D10 RID: 3344 RVA: 0x0002E4C8 File Offset: 0x0002C6C8
					public static GameObject InfoText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopupV2/Popup/InfoText");
						}
					}

					// Token: 0x1700057C RID: 1404
					// (get) Token: 0x06000D11 RID: 3345 RVA: 0x0002E4E4 File Offset: 0x0002C6E4
					public static GameObject Buttons
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopupV2/Popup/Buttons");
						}
					}

					// Token: 0x02000359 RID: 857
					public class Buttons_4
					{
						// Token: 0x17000822 RID: 2082
						// (get) Token: 0x0600110C RID: 4364 RVA: 0x00033F08 File Offset: 0x00032108
						public static GameObject LeftButton
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopupV2/Popup/Buttons/LeftButton");
							}
						}

						// Token: 0x17000823 RID: 2083
						// (get) Token: 0x0600110D RID: 4365 RVA: 0x00033F24 File Offset: 0x00032124
						public static GameObject MiddleButton
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopupV2/Popup/Buttons/MiddleButton");
							}
						}

						// Token: 0x17000824 RID: 2084
						// (get) Token: 0x0600110E RID: 4366 RVA: 0x00033F40 File Offset: 0x00032140
						public static GameObject RightButton
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopupV2/Popup/Buttons/RightButton");
							}
						}

						// Token: 0x0200043C RID: 1084
						public class LeftButton_5
						{
							// Token: 0x170009B1 RID: 2481
							// (get) Token: 0x0600137E RID: 4990 RVA: 0x00037550 File Offset: 0x00035750
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopupV2/Popup/Buttons/LeftButton/Text");
								}
							}
						}

						// Token: 0x0200043D RID: 1085
						public class MiddleButton_5
						{
							// Token: 0x170009B2 RID: 2482
							// (get) Token: 0x06001380 RID: 4992 RVA: 0x00037578 File Offset: 0x00035778
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopupV2/Popup/Buttons/MiddleButton/Text");
								}
							}
						}

						// Token: 0x0200043E RID: 1086
						public class RightButton_5
						{
							// Token: 0x170009B3 RID: 2483
							// (get) Token: 0x06001382 RID: 4994 RVA: 0x000375A0 File Offset: 0x000357A0
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopupV2/Popup/Buttons/RightButton/Text");
								}
							}
						}
					}
				}
			}

			// Token: 0x02000112 RID: 274
			public class ReportUserPopup_2
			{
				// Token: 0x1700029D RID: 669
				// (get) Token: 0x06000937 RID: 2359 RVA: 0x0002890C File Offset: 0x00026B0C
				public static GameObject Darkness
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Darkness");
					}
				}

				// Token: 0x1700029E RID: 670
				// (get) Token: 0x06000938 RID: 2360 RVA: 0x00028928 File Offset: 0x00026B28
				public static GameObject Popup
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup");
					}
				}

				// Token: 0x02000205 RID: 517
				public class Popup_3
				{
					// Token: 0x1700057D RID: 1405
					// (get) Token: 0x06000D13 RID: 3347 RVA: 0x0002E50C File Offset: 0x0002C70C
					public static GameObject BorderImage
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/BorderImage");
						}
					}

					// Token: 0x1700057E RID: 1406
					// (get) Token: 0x06000D14 RID: 3348 RVA: 0x0002E528 File Offset: 0x0002C728
					public static GameObject Panel
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Panel");
						}
					}

					// Token: 0x1700057F RID: 1407
					// (get) Token: 0x06000D15 RID: 3349 RVA: 0x0002E544 File Offset: 0x0002C744
					public static GameObject TitleText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/TitleText");
						}
					}

					// Token: 0x17000580 RID: 1408
					// (get) Token: 0x06000D16 RID: 3350 RVA: 0x0002E560 File Offset: 0x0002C760
					public static GameObject ExitButton
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/ExitButton");
						}
					}

					// Token: 0x17000581 RID: 1409
					// (get) Token: 0x06000D17 RID: 3351 RVA: 0x0002E57C File Offset: 0x0002C77C
					public static GameObject EmailText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/EmailText");
						}
					}

					// Token: 0x17000582 RID: 1410
					// (get) Token: 0x06000D18 RID: 3352 RVA: 0x0002E598 File Offset: 0x0002C798
					public static GameObject Pages
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages");
						}
					}

					// Token: 0x0200035A RID: 858
					public class Pages_4
					{
						// Token: 0x17000825 RID: 2085
						// (get) Token: 0x06001110 RID: 4368 RVA: 0x00033F68 File Offset: 0x00032168
						public static GameObject Page1
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/Page1");
							}
						}

						// Token: 0x17000826 RID: 2086
						// (get) Token: 0x06001111 RID: 4369 RVA: 0x00033F84 File Offset: 0x00032184
						public static GameObject Page2
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/Page2");
							}
						}

						// Token: 0x17000827 RID: 2087
						// (get) Token: 0x06001112 RID: 4370 RVA: 0x00033FA0 File Offset: 0x000321A0
						public static GameObject ThanksPage
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/ThanksPage");
							}
						}

						// Token: 0x17000828 RID: 2088
						// (get) Token: 0x06001113 RID: 4371 RVA: 0x00033FBC File Offset: 0x000321BC
						public static GameObject ErrorPage
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/ErrorPage");
							}
						}

						// Token: 0x17000829 RID: 2089
						// (get) Token: 0x06001114 RID: 4372 RVA: 0x00033FD8 File Offset: 0x000321D8
						public static GameObject ResetPage
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/ResetPage");
							}
						}

						// Token: 0x0200043F RID: 1087
						public class Page1_5
						{
							// Token: 0x170009B4 RID: 2484
							// (get) Token: 0x06001384 RID: 4996 RVA: 0x000375C8 File Offset: 0x000357C8
							public static GameObject Checkboxes
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/Page1/Checkboxes");
								}
							}

							// Token: 0x170009B5 RID: 2485
							// (get) Token: 0x06001385 RID: 4997 RVA: 0x000375E4 File Offset: 0x000357E4
							public static GameObject NextButton
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/Page1/NextButton");
								}
							}

							// Token: 0x170009B6 RID: 2486
							// (get) Token: 0x06001386 RID: 4998 RVA: 0x00037600 File Offset: 0x00035800
							public static GameObject WhereText
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/Page1/WhereText");
								}
							}
						}

						// Token: 0x02000440 RID: 1088
						public class Page2_5
						{
							// Token: 0x170009B7 RID: 2487
							// (get) Token: 0x06001388 RID: 5000 RVA: 0x00037628 File Offset: 0x00035828
							public static GameObject Checkboxes
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/Page2/Checkboxes");
								}
							}

							// Token: 0x170009B8 RID: 2488
							// (get) Token: 0x06001389 RID: 5001 RVA: 0x00037644 File Offset: 0x00035844
							public static GameObject SubmitButton
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/Page2/SubmitButton");
								}
							}

							// Token: 0x170009B9 RID: 2489
							// (get) Token: 0x0600138A RID: 5002 RVA: 0x00037660 File Offset: 0x00035860
							public static GameObject WhereCategoryText
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/Page2/WhereCategoryText");
								}
							}

							// Token: 0x170009BA RID: 2490
							// (get) Token: 0x0600138B RID: 5003 RVA: 0x0003767C File Offset: 0x0003587C
							public static GameObject WhyText
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/Page2/WhyText");
								}
							}
						}

						// Token: 0x02000441 RID: 1089
						public class ThanksPage_5
						{
							// Token: 0x170009BB RID: 2491
							// (get) Token: 0x0600138D RID: 5005 RVA: 0x000376A4 File Offset: 0x000358A4
							public static GameObject CloseButton
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/ThanksPage/CloseButton");
								}
							}

							// Token: 0x170009BC RID: 2492
							// (get) Token: 0x0600138E RID: 5006 RVA: 0x000376C0 File Offset: 0x000358C0
							public static GameObject ThanksText
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/ThanksPage/ThanksText");
								}
							}

							// Token: 0x170009BD RID: 2493
							// (get) Token: 0x0600138F RID: 5007 RVA: 0x000376DC File Offset: 0x000358DC
							public static GameObject WarningText
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/ThanksPage/WarningText");
								}
							}
						}

						// Token: 0x02000442 RID: 1090
						public class ErrorPage_5
						{
							// Token: 0x170009BE RID: 2494
							// (get) Token: 0x06001391 RID: 5009 RVA: 0x00037704 File Offset: 0x00035904
							public static GameObject CloseButton
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/ErrorPage/CloseButton");
								}
							}

							// Token: 0x170009BF RID: 2495
							// (get) Token: 0x06001392 RID: 5010 RVA: 0x00037720 File Offset: 0x00035920
							public static GameObject ErrorText
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/ErrorPage/ErrorText");
								}
							}
						}

						// Token: 0x02000443 RID: 1091
						public class ResetPage_5
						{
							// Token: 0x170009C0 RID: 2496
							// (get) Token: 0x06001394 RID: 5012 RVA: 0x00037748 File Offset: 0x00035948
							public static GameObject CloseButton
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/ResetPage/CloseButton");
								}
							}

							// Token: 0x170009C1 RID: 2497
							// (get) Token: 0x06001395 RID: 5013 RVA: 0x00037764 File Offset: 0x00035964
							public static GameObject ResetButton
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/ResetPage/ResetButton");
								}
							}

							// Token: 0x170009C2 RID: 2498
							// (get) Token: 0x06001396 RID: 5014 RVA: 0x00037780 File Offset: 0x00035980
							public static GameObject ResetText
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/ResetPage/ResetText");
								}
							}
						}
					}
				}
			}

			// Token: 0x02000113 RID: 275
			public class UpdateStatusPopup_2
			{
				// Token: 0x1700029F RID: 671
				// (get) Token: 0x0600093A RID: 2362 RVA: 0x00028950 File Offset: 0x00026B50
				public static GameObject Darkness
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Darkness");
					}
				}

				// Token: 0x170002A0 RID: 672
				// (get) Token: 0x0600093B RID: 2363 RVA: 0x0002896C File Offset: 0x00026B6C
				public static GameObject Popup
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup");
					}
				}

				// Token: 0x02000206 RID: 518
				public class Popup_3
				{
					// Token: 0x17000583 RID: 1411
					// (get) Token: 0x06000D1A RID: 3354 RVA: 0x0002E5C0 File Offset: 0x0002C7C0
					public static GameObject BorderImage
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/BorderImage");
						}
					}

					// Token: 0x17000584 RID: 1412
					// (get) Token: 0x06000D1B RID: 3355 RVA: 0x0002E5DC File Offset: 0x0002C7DC
					public static GameObject BorderImage_1
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/BorderImage (1)");
						}
					}

					// Token: 0x17000585 RID: 1413
					// (get) Token: 0x06000D1C RID: 3356 RVA: 0x0002E5F8 File Offset: 0x0002C7F8
					public static GameObject Panel
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/Panel");
						}
					}

					// Token: 0x17000586 RID: 1414
					// (get) Token: 0x06000D1D RID: 3357 RVA: 0x0002E614 File Offset: 0x0002C814
					public static GameObject ExitButton
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/ExitButton");
						}
					}

					// Token: 0x17000587 RID: 1415
					// (get) Token: 0x06000D1E RID: 3358 RVA: 0x0002E630 File Offset: 0x0002C830
					public static GameObject StatusHistoryButton
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusHistoryButton");
						}
					}

					// Token: 0x17000588 RID: 1416
					// (get) Token: 0x06000D1F RID: 3359 RVA: 0x0002E64C File Offset: 0x0002C84C
					public static GameObject UpdateStatusTitleText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/UpdateStatusTitleText");
						}
					}

					// Token: 0x17000589 RID: 1417
					// (get) Token: 0x06000D20 RID: 3360 RVA: 0x0002E668 File Offset: 0x0002C868
					public static GameObject InputFieldStatus
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/InputFieldStatus");
						}
					}

					// Token: 0x1700058A RID: 1418
					// (get) Token: 0x06000D21 RID: 3361 RVA: 0x0002E684 File Offset: 0x0002C884
					public static GameObject StatusSettings
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings");
						}
					}

					// Token: 0x1700058B RID: 1419
					// (get) Token: 0x06000D22 RID: 3362 RVA: 0x0002E6A0 File Offset: 0x0002C8A0
					public static GameObject Buttons
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/Buttons");
						}
					}

					// Token: 0x0200035B RID: 859
					public class StatusHistoryButton_4
					{
						// Token: 0x1700082A RID: 2090
						// (get) Token: 0x06001116 RID: 4374 RVA: 0x00034000 File Offset: 0x00032200
						public static GameObject Icon
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusHistoryButton/Icon");
							}
						}

						// Token: 0x1700082B RID: 2091
						// (get) Token: 0x06001117 RID: 4375 RVA: 0x0003401C File Offset: 0x0003221C
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusHistoryButton/Text");
							}
						}
					}

					// Token: 0x0200035C RID: 860
					public class StatusSettings_4
					{
						// Token: 0x1700082C RID: 2092
						// (get) Token: 0x06001119 RID: 4377 RVA: 0x00034044 File Offset: 0x00032244
						public static GameObject JoinMeStatus
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/JoinMeStatus");
							}
						}

						// Token: 0x1700082D RID: 2093
						// (get) Token: 0x0600111A RID: 4378 RVA: 0x00034060 File Offset: 0x00032260
						public static GameObject OnlineStatus
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/OnlineStatus");
							}
						}

						// Token: 0x1700082E RID: 2094
						// (get) Token: 0x0600111B RID: 4379 RVA: 0x0003407C File Offset: 0x0003227C
						public static GameObject AskMeStatus
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/AskMeStatus");
							}
						}

						// Token: 0x1700082F RID: 2095
						// (get) Token: 0x0600111C RID: 4380 RVA: 0x00034098 File Offset: 0x00032298
						public static GameObject DoNotDisturbStatus
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/DoNotDisturbStatus");
							}
						}

						// Token: 0x17000830 RID: 2096
						// (get) Token: 0x0600111D RID: 4381 RVA: 0x000340B4 File Offset: 0x000322B4
						public static GameObject OfflineStatus
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/OfflineStatus");
							}
						}

						// Token: 0x02000444 RID: 1092
						public class JoinMeStatus_5
						{
							// Token: 0x170009C3 RID: 2499
							// (get) Token: 0x06001398 RID: 5016 RVA: 0x000377A8 File Offset: 0x000359A8
							public static GameObject StatusIcon
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/JoinMeStatus/StatusIcon");
								}
							}

							// Token: 0x170009C4 RID: 2500
							// (get) Token: 0x06001399 RID: 5017 RVA: 0x000377C4 File Offset: 0x000359C4
							public static GameObject Description
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/JoinMeStatus/Description");
								}
							}

							// Token: 0x170009C5 RID: 2501
							// (get) Token: 0x0600139A RID: 5018 RVA: 0x000377E0 File Offset: 0x000359E0
							public static GameObject Highlight
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/JoinMeStatus/Highlight");
								}
							}
						}

						// Token: 0x02000445 RID: 1093
						public class OnlineStatus_5
						{
							// Token: 0x170009C6 RID: 2502
							// (get) Token: 0x0600139C RID: 5020 RVA: 0x00037808 File Offset: 0x00035A08
							public static GameObject StatusIcon
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/OnlineStatus/StatusIcon");
								}
							}

							// Token: 0x170009C7 RID: 2503
							// (get) Token: 0x0600139D RID: 5021 RVA: 0x00037824 File Offset: 0x00035A24
							public static GameObject Description
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/OnlineStatus/Description");
								}
							}

							// Token: 0x170009C8 RID: 2504
							// (get) Token: 0x0600139E RID: 5022 RVA: 0x00037840 File Offset: 0x00035A40
							public static GameObject Highlight
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/OnlineStatus/Highlight");
								}
							}
						}

						// Token: 0x02000446 RID: 1094
						public class AskMeStatus_5
						{
							// Token: 0x170009C9 RID: 2505
							// (get) Token: 0x060013A0 RID: 5024 RVA: 0x00037868 File Offset: 0x00035A68
							public static GameObject StatusIcon
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/AskMeStatus/StatusIcon");
								}
							}

							// Token: 0x170009CA RID: 2506
							// (get) Token: 0x060013A1 RID: 5025 RVA: 0x00037884 File Offset: 0x00035A84
							public static GameObject Description
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/AskMeStatus/Description");
								}
							}

							// Token: 0x170009CB RID: 2507
							// (get) Token: 0x060013A2 RID: 5026 RVA: 0x000378A0 File Offset: 0x00035AA0
							public static GameObject Highlight
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/AskMeStatus/Highlight");
								}
							}
						}

						// Token: 0x02000447 RID: 1095
						public class DoNotDisturbStatus_5
						{
							// Token: 0x170009CC RID: 2508
							// (get) Token: 0x060013A4 RID: 5028 RVA: 0x000378C8 File Offset: 0x00035AC8
							public static GameObject StatusIcon
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/DoNotDisturbStatus/StatusIcon");
								}
							}

							// Token: 0x170009CD RID: 2509
							// (get) Token: 0x060013A5 RID: 5029 RVA: 0x000378E4 File Offset: 0x00035AE4
							public static GameObject Description
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/DoNotDisturbStatus/Description");
								}
							}

							// Token: 0x170009CE RID: 2510
							// (get) Token: 0x060013A6 RID: 5030 RVA: 0x00037900 File Offset: 0x00035B00
							public static GameObject Highlight
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/DoNotDisturbStatus/Highlight");
								}
							}
						}

						// Token: 0x02000448 RID: 1096
						public class OfflineStatus_5
						{
							// Token: 0x170009CF RID: 2511
							// (get) Token: 0x060013A8 RID: 5032 RVA: 0x00037928 File Offset: 0x00035B28
							public static GameObject StatusIcon
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/OfflineStatus/StatusIcon");
								}
							}

							// Token: 0x170009D0 RID: 2512
							// (get) Token: 0x060013A9 RID: 5033 RVA: 0x00037944 File Offset: 0x00035B44
							public static GameObject Description
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/OfflineStatus/Description");
								}
							}

							// Token: 0x170009D1 RID: 2513
							// (get) Token: 0x060013AA RID: 5034 RVA: 0x00037960 File Offset: 0x00035B60
							public static GameObject Highlight
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/OfflineStatus/Highlight");
								}
							}
						}
					}

					// Token: 0x0200035D RID: 861
					public class Buttons_4
					{
						// Token: 0x17000831 RID: 2097
						// (get) Token: 0x0600111F RID: 4383 RVA: 0x000340DC File Offset: 0x000322DC
						public static GameObject UpdateButton
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/Buttons/UpdateButton");
							}
						}

						// Token: 0x02000449 RID: 1097
						public class UpdateButton_5
						{
							// Token: 0x170009D2 RID: 2514
							// (get) Token: 0x060013AC RID: 5036 RVA: 0x00037988 File Offset: 0x00035B88
							public static GameObject Text
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/Buttons/UpdateButton/Text");
								}
							}
						}
					}
				}
			}

			// Token: 0x02000114 RID: 276
			public class RequestInvitePopup_2
			{
				// Token: 0x170002A1 RID: 673
				// (get) Token: 0x0600093D RID: 2365 RVA: 0x00028994 File Offset: 0x00026B94
				public static GameObject Darkness
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/Darkness");
					}
				}

				// Token: 0x170002A2 RID: 674
				// (get) Token: 0x0600093E RID: 2366 RVA: 0x000289B0 File Offset: 0x00026BB0
				public static GameObject RequestInviteMenu
				{
					get
					{
						return GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu");
					}
				}

				// Token: 0x02000207 RID: 519
				public class RequestInviteMenu_3
				{
					// Token: 0x1700058C RID: 1420
					// (get) Token: 0x06000D24 RID: 3364 RVA: 0x0002E6C8 File Offset: 0x0002C8C8
					public static GameObject BorderImage
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/BorderImage");
						}
					}

					// Token: 0x1700058D RID: 1421
					// (get) Token: 0x06000D25 RID: 3365 RVA: 0x0002E6E4 File Offset: 0x0002C8E4
					public static GameObject Panel
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/Panel");
						}
					}

					// Token: 0x1700058E RID: 1422
					// (get) Token: 0x06000D26 RID: 3366 RVA: 0x0002E700 File Offset: 0x0002C900
					public static GameObject TitleText
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/TitleText");
						}
					}

					// Token: 0x1700058F RID: 1423
					// (get) Token: 0x06000D27 RID: 3367 RVA: 0x0002E71C File Offset: 0x0002C91C
					public static GameObject SubscribeToAddPhotosButton
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/SubscribeToAddPhotosButton");
						}
					}

					// Token: 0x17000590 RID: 1424
					// (get) Token: 0x06000D28 RID: 3368 RVA: 0x0002E738 File Offset: 0x0002C938
					public static GameObject AddPhotoOrImageAttachment
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/AddPhotoOrImageAttachment");
						}
					}

					// Token: 0x17000591 RID: 1425
					// (get) Token: 0x06000D29 RID: 3369 RVA: 0x0002E754 File Offset: 0x0002C954
					public static GameObject AddMessageButton
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/AddMessageButton");
						}
					}

					// Token: 0x17000592 RID: 1426
					// (get) Token: 0x06000D2A RID: 3370 RVA: 0x0002E770 File Offset: 0x0002C970
					public static GameObject EditMessageButton
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/EditMessageButton");
						}
					}

					// Token: 0x17000593 RID: 1427
					// (get) Token: 0x06000D2B RID: 3371 RVA: 0x0002E78C File Offset: 0x0002C98C
					public static GameObject SendButton
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/SendButton");
						}
					}

					// Token: 0x17000594 RID: 1428
					// (get) Token: 0x06000D2C RID: 3372 RVA: 0x0002E7A8 File Offset: 0x0002C9A8
					public static GameObject CancelButton
					{
						get
						{
							return GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/CancelButton");
						}
					}

					// Token: 0x0200035E RID: 862
					public class AddPhotoOrImageAttachment_4
					{
						// Token: 0x17000832 RID: 2098
						// (get) Token: 0x06001121 RID: 4385 RVA: 0x00034104 File Offset: 0x00032304
						public static GameObject PhotoToAttach
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/AddPhotoOrImageAttachment/PhotoToAttach");
							}
						}

						// Token: 0x17000833 RID: 2099
						// (get) Token: 0x06001122 RID: 4386 RVA: 0x00034120 File Offset: 0x00032320
						public static GameObject AddPhotoBackground
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/AddPhotoOrImageAttachment/AddPhotoBackground");
							}
						}

						// Token: 0x17000834 RID: 2100
						// (get) Token: 0x06001123 RID: 4387 RVA: 0x0003413C File Offset: 0x0003233C
						public static GameObject AddGalleryImageGroup
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/AddPhotoOrImageAttachment/AddGalleryImageGroup");
							}
						}

						// Token: 0x17000835 RID: 2101
						// (get) Token: 0x06001124 RID: 4388 RVA: 0x00034158 File Offset: 0x00032358
						public static GameObject VRCPlus
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/AddPhotoOrImageAttachment/VRC+");
							}
						}

						// Token: 0x0200044A RID: 1098
						public class PhotoToAttach_5
						{
							// Token: 0x170009D3 RID: 2515
							// (get) Token: 0x060013AE RID: 5038 RVA: 0x000379B0 File Offset: 0x00035BB0
							public static GameObject AddPhotoOrImageGroup
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/AddPhotoOrImageAttachment/PhotoToAttach/AddPhotoOrImageGroup");
								}
							}
						}
					}

					// Token: 0x0200035F RID: 863
					public class AddMessageButton_4
					{
						// Token: 0x17000836 RID: 2102
						// (get) Token: 0x06001126 RID: 4390 RVA: 0x00034180 File Offset: 0x00032380
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/AddMessageButton/Text");
							}
						}

						// Token: 0x17000837 RID: 2103
						// (get) Token: 0x06001127 RID: 4391 RVA: 0x0003419C File Offset: 0x0003239C
						public static GameObject Icon_AddMessage
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/AddMessageButton/Icon_AddMessage");
							}
						}
					}

					// Token: 0x02000360 RID: 864
					public class EditMessageButton_4
					{
						// Token: 0x17000838 RID: 2104
						// (get) Token: 0x06001129 RID: 4393 RVA: 0x000341C4 File Offset: 0x000323C4
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/EditMessageButton/Text");
							}
						}

						// Token: 0x17000839 RID: 2105
						// (get) Token: 0x0600112A RID: 4394 RVA: 0x000341E0 File Offset: 0x000323E0
						public static GameObject Icon_EditMessage
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/EditMessageButton/Icon_EditMessage");
							}
						}

						// Token: 0x1700083A RID: 2106
						// (get) Token: 0x0600112B RID: 4395 RVA: 0x000341FC File Offset: 0x000323FC
						public static GameObject ClearSelectedMessage
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/EditMessageButton/ClearSelectedMessage");
							}
						}

						// Token: 0x0200044B RID: 1099
						public class ClearSelectedMessage_5
						{
							// Token: 0x170009D4 RID: 2516
							// (get) Token: 0x060013B0 RID: 5040 RVA: 0x000379D8 File Offset: 0x00035BD8
							public static GameObject Icon
							{
								get
								{
									return GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/EditMessageButton/ClearSelectedMessage/Icon");
								}
							}
						}
					}

					// Token: 0x02000361 RID: 865
					public class SendButton_4
					{
						// Token: 0x1700083B RID: 2107
						// (get) Token: 0x0600112D RID: 4397 RVA: 0x00034224 File Offset: 0x00032424
						public static GameObject Text
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/SendButton/Text");
							}
						}
					}

					// Token: 0x02000362 RID: 866
					public class CancelButton_4
					{
						// Token: 0x1700083C RID: 2108
						// (get) Token: 0x0600112F RID: 4399 RVA: 0x0003424C File Offset: 0x0003244C
						public static GameObject Icon
						{
							get
							{
								return GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/CancelButton/Icon");
							}
						}
					}
				}
			}
		}
	}
}
