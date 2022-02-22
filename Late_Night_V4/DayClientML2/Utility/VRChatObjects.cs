using System;
using DayClientML2.Utility.Extensions;
using UnityEngine;

namespace DayClientML2.Utility
{
	// Token: 0x02000054 RID: 84
	internal class VRChatObjects
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x0001864C File Offset: 0x0001684C
		public static GameObject SettingsPage
		{
			get
			{
				return GameObject.Find("UserInterface/MenuContent/Screens/Settings");
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x00018668 File Offset: 0x00016868
		public static GameObject SafetyPage
		{
			get
			{
				return GameObject.Find("UserInterface/MenuContent/Screens/Settings_Safety");
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x00018684 File Offset: 0x00016884
		public static GameObject SocialPage
		{
			get
			{
				return GameObject.Find("UserInterface/MenuContent/Screens/Social");
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x000186A0 File Offset: 0x000168A0
		public static GameObject UserInfoPage
		{
			get
			{
				return GameObject.Find("UserInterface/MenuContent/Screens/UserInfo");
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x000186BC File Offset: 0x000168BC
		public static GameObject AvatarPage
		{
			get
			{
				return GameObject.Find("UserInterface/MenuContent/Screens/Avatar");
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x000186D8 File Offset: 0x000168D8
		public static GameObject WorldsPage
		{
			get
			{
				return GameObject.Find("UserInterface/MenuContent/Screens/Worlds");
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060002CA RID: 714 RVA: 0x000186F4 File Offset: 0x000168F4
		public static GameObject TabHeader
		{
			get
			{
				return GameObject.Find("UserInterface/MenuContent/Backdrop/Header/Tabs/ViewPort/Content");
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060002CB RID: 715 RVA: 0x00018710 File Offset: 0x00016910
		public static GameObject WorldsPageTab
		{
			get
			{
				return GameObject.Find("UserInterface/MenuContent/Backdrop/Header/Tabs/ViewPort/Content/WorldsPageTab");
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060002CC RID: 716 RVA: 0x0001872C File Offset: 0x0001692C
		public static Transform NotificationMenu
		{
			get
			{
				return Utils.QuickMenu.transform.Find("NotificationInteractMenu");
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060002CD RID: 717 RVA: 0x00018754 File Offset: 0x00016954
		public static GameObject NotificationMenuOBJ
		{
			get
			{
				return Utils.QuickMenu.transform.Find("NotificationInteractMenu").gameObject;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060002CE RID: 718 RVA: 0x00018780 File Offset: 0x00016980
		public static GameObject QMInfoBar
		{
			get
			{
				return Utils.QuickMenu.transform.Find("QuickMenu_NewElements/_InfoBar").gameObject;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060002CF RID: 719 RVA: 0x000187AC File Offset: 0x000169AC
		public static GameObject QMWorldsButton
		{
			get
			{
				return Utils.QuickMenu.transform.Find("ShortcutMenu/WorldsButton").gameObject;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x000187D8 File Offset: 0x000169D8
		public static GameObject QMAvatarButton
		{
			get
			{
				return Utils.QuickMenu.transform.Find("ShortcutMenu/AvatarButton").gameObject;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x00018804 File Offset: 0x00016A04
		public static GameObject QMSocialButton
		{
			get
			{
				return Utils.QuickMenu.transform.Find("ShortcutMenu/SocialButton").gameObject;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x00018830 File Offset: 0x00016A30
		public static GameObject QMSafetyButton
		{
			get
			{
				return Utils.QuickMenu.transform.Find("ShortcutMenu/SafetyButton").gameObject;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x0001885C File Offset: 0x00016A5C
		public static GameObject QMTrustRankToggle
		{
			get
			{
				return Utils.QuickMenu.transform.Find("ShortcutMenu/Toggle_States_ShowTrustRank_Colors").gameObject;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x00018888 File Offset: 0x00016A88
		public static GameObject QMGoHomeButton
		{
			get
			{
				return Utils.QuickMenu.transform.Find("ShortcutMenu/GoHomeButton").gameObject;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x000188B4 File Offset: 0x00016AB4
		public static GameObject QMRespawnButton
		{
			get
			{
				return Utils.QuickMenu.transform.Find("ShortcutMenu/RespawnButton").gameObject;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x000188E0 File Offset: 0x00016AE0
		public static GameObject QMSitButton
		{
			get
			{
				return Utils.QuickMenu.transform.Find("ShortcutMenu/SitButton").gameObject;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x0001890C File Offset: 0x00016B0C
		public static GameObject QmCalibrateButton
		{
			get
			{
				return Utils.QuickMenu.transform.Find("ShortcutMenu/CalibrateButton").gameObject;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x00018938 File Offset: 0x00016B38
		public static GameObject QMSettingsButton
		{
			get
			{
				return Utils.QuickMenu.transform.Find("ShortcutMenu/SettingsButton").gameObject;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x00018964 File Offset: 0x00016B64
		public static GameObject QMReportWorldButton
		{
			get
			{
				return Utils.QuickMenu.transform.Find("ShortcutMenu/ReportWorldButton").gameObject;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060002DA RID: 730 RVA: 0x00018990 File Offset: 0x00016B90
		public static GameObject QMUIElementsButton
		{
			get
			{
				return Utils.QuickMenu.transform.Find("ShortcutMenu/UIElementsButton").gameObject;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060002DB RID: 731 RVA: 0x000189BC File Offset: 0x00016BBC
		public static GameObject QMCameraButton
		{
			get
			{
				return Utils.QuickMenu.transform.Find("ShortcutMenu/CameraButton").gameObject;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060002DC RID: 732 RVA: 0x000189E8 File Offset: 0x00016BE8
		public static GameObject QMEmoteButton
		{
			get
			{
				return Utils.QuickMenu.transform.Find("ShortcutMenu/EmoteButton").gameObject;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060002DD RID: 733 RVA: 0x00018A14 File Offset: 0x00016C14
		public static GameObject QMEmojiButton
		{
			get
			{
				return Utils.QuickMenu.transform.Find("ShortcutMenu/EmojiButton").gameObject;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060002DE RID: 734 RVA: 0x00018A40 File Offset: 0x00016C40
		public static GameObject QMEmojiDown
		{
			get
			{
				return GameObject.Find("/UserInterface/QuickMenu/EmojiMenu/PageDown");
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060002DF RID: 735 RVA: 0x00018A5C File Offset: 0x00016C5C
		public static GameObject QMEmojiUp
		{
			get
			{
				return GameObject.Find("/UserInterface/QuickMenu/EmojiMenu/PageUp");
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x00018A78 File Offset: 0x00016C78
		public static GameObject QMMicButton
		{
			get
			{
				return Utils.QuickMenu.transform.Find("MicControls/MicButton").gameObject;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x00018AA4 File Offset: 0x00016CA4
		public static GameObject QMStatusInfoBar
		{
			get
			{
				return GameObject.Find("/UserInterface/QuickMenu/QuickMenu_NewElements/_CONTEXT/QM_Context_User_Hover/_UserStatus/Text");
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x00018AC0 File Offset: 0x00016CC0
		public static GameObject QMFPSText
		{
			get
			{
				return Utils.QuickMenu.transform.Find("ShortcutMenu/FPSText").gameObject;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x00018AEC File Offset: 0x00016CEC
		public static GameObject RemoveBackdrop
		{
			get
			{
				return Utils.QuickMenu.transform.Find("/UserInterface/MenuContent/Backdrop/Backdrop/Background").gameObject;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x00018B18 File Offset: 0x00016D18
		public static GameObject RemoveSkyCube
		{
			get
			{
				return Utils.QuickMenu.transform.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingBackground_TealGradient/SkyCube_Baked").gameObject;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x00018B44 File Offset: 0x00016D44
		public static GameObject QMPingText
		{
			get
			{
				return Utils.QuickMenu.transform.Find("ShortcutMenu/PingText").gameObject;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x00018B70 File Offset: 0x00016D70
		public static GameObject QMEarlyAccessText
		{
			get
			{
				return Utils.QuickMenu.transform.Find("ShortcutMenu/EarlyAccessText").gameObject;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x00018B9C File Offset: 0x00016D9C
		public static GameObject UIEarlyAccessText
		{
			get
			{
				return Utils.QuickMenu.transform.Find("/UserInterface/MenuContent/Backdrop/Backdrop/Image").gameObject;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x00018BC8 File Offset: 0x00016DC8
		public static GameObject UIBetaShit
		{
			get
			{
				return Utils.QuickMenu.transform.Find("/UserInterface/MenuContent/Backdrop/Header/Tabs/ViewPort/Content/SafetyPageTab/Image (1)").gameObject;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x00018BF4 File Offset: 0x00016DF4
		public static GameObject QMNameText
		{
			get
			{
				return Utils.QuickMenu.transform.Find("ShortcutMenu/NameText").gameObject;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060002EA RID: 746 RVA: 0x00018C20 File Offset: 0x00016E20
		public static GameObject QMBuildNumText
		{
			get
			{
				return Utils.QuickMenu.transform.Find("ShortcutMenu/BuildNumText").gameObject;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060002EB RID: 747 RVA: 0x00018C4C File Offset: 0x00016E4C
		public static GameObject VRCSettingsBuildNumText
		{
			get
			{
				return Utils.QuickMenu.transform.Find("/UserInterface/MenuContent/Screens/Settings/TitlePanel/VersionText").gameObject;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060002EC RID: 748 RVA: 0x00018C78 File Offset: 0x00016E78
		public static GameObject QMBuildNumTextUI
		{
			get
			{
				return Utils.QuickMenu.transform.Find("/UserInterface/MenuContent/Screens/Settings/TitlePanel/VersionText").gameObject;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060002ED RID: 749 RVA: 0x00018CA4 File Offset: 0x00016EA4
		public static GameObject QMWorldText
		{
			get
			{
				return Utils.QuickMenu.transform.Find("ShortcutMenu/WorldText").gameObject;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060002EE RID: 750 RVA: 0x00018CD0 File Offset: 0x00016ED0
		public static GameObject AdvancedSettingsMenu
		{
			get
			{
				return Utils.QuickMenu.transform.Find("/UserInterface/MenuContent/Screens/Settings/Button_AdvancedOptions/Image_NEW").gameObject;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060002EF RID: 751 RVA: 0x00018CFC File Offset: 0x00016EFC
		public static GameObject SafetyMenuBetaText
		{
			get
			{
				return Utils.QuickMenu.transform.Find("/UserInterface/MenuContent/Screens/Settings_Safety/TitlePanel/Image").gameObject;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x00018D28 File Offset: 0x00016F28
		public static GameObject SafetyMenuPerformanceOptions
		{
			get
			{
				return Utils.QuickMenu.transform.Find("/UserInterface/MenuContent/Screens/Settings_Safety/TitlePanel/Button_PerformanceOptions/Image_NEW").gameObject;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x00018D54 File Offset: 0x00016F54
		public static GameObject BindingsNew
		{
			get
			{
				return Utils.QuickMenu.transform.Find("/UserInterface/MenuContent/Screens/Settings/Button_EditBindings/Image_NEW").gameObject;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x00018D80 File Offset: 0x00016F80
		public static GameObject RemoveInfoPanel
		{
			get
			{
				return Utils.QuickMenu.transform.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingInfoPanel/InfoPanel_Template_ANIM").gameObject;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x00018DAC File Offset: 0x00016FAC
		public static GameObject Ads1
		{
			get
			{
				return Utils.QuickMenu.transform.Find("ShortcutMenu/VRCPlusMiniBanner").gameObject;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x00018DD8 File Offset: 0x00016FD8
		public static GameObject Ads2
		{
			get
			{
				return Utils.QuickMenu.transform.Find("ShortcutMenu/VRCPlusThankYou").gameObject;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x00018E04 File Offset: 0x00017004
		public static GameObject Ads3
		{
			get
			{
				return Utils.QuickMenu.transform.Find("ShortcutMenu/UserIconButton").gameObject;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x00018E30 File Offset: 0x00017030
		public static GameObject Ads4
		{
			get
			{
				return Utils.QuickMenu.transform.Find("ShortcutMenu/UserIconCameraButton").gameObject;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x00018E5C File Offset: 0x0001705C
		public static GameObject Ads5
		{
			get
			{
				return Utils.QuickMenu.transform.Find("ShortcutMenu/HeaderContainer/VRCPlusBanner").gameObject;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x00018E88 File Offset: 0x00017088
		public static GameObject UserInteractMenu
		{
			get
			{
				return Utils.QuickMenu.transform.Find("UserInteractMenu").gameObject;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x00018EB4 File Offset: 0x000170B4
		public static GameObject UIFriendButton
		{
			get
			{
				return Utils.QuickMenu.transform.Find("UserInteractMenu/FriendButton").gameObject;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060002FA RID: 762 RVA: 0x00018EE0 File Offset: 0x000170E0
		public static GameObject UIDetailsButton
		{
			get
			{
				return Utils.QuickMenu.transform.Find("UserInteractMenu/DetailsButton").gameObject;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060002FB RID: 763 RVA: 0x00018F0C File Offset: 0x0001710C
		public static GameObject UIBlockButton
		{
			get
			{
				return Utils.QuickMenu.transform.Find("UserInteractMenu/BlockButton").gameObject;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060002FC RID: 764 RVA: 0x00018F38 File Offset: 0x00017138
		public static GameObject UIViewAvatarThreeToggle
		{
			get
			{
				return Utils.QuickMenu.transform.Find("UserInteractMenu/ViewAvatarThreeToggle").gameObject;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060002FD RID: 765 RVA: 0x00018F64 File Offset: 0x00017164
		public static GameObject UIMuteButton
		{
			get
			{
				return Utils.QuickMenu.transform.Find("UserInteractMenu/MuteButton").gameObject;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060002FE RID: 766 RVA: 0x00018F90 File Offset: 0x00017190
		public static GameObject UIMicOffButton
		{
			get
			{
				return Utils.QuickMenu.transform.Find("UserInteractMenu/MicOffButton").gameObject;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060002FF RID: 767 RVA: 0x00018FBC File Offset: 0x000171BC
		public static GameObject UIReportAbuseButton
		{
			get
			{
				return Utils.QuickMenu.transform.Find("UserInteractMenu/ReportAbuseButton").gameObject;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000300 RID: 768 RVA: 0x00018FE8 File Offset: 0x000171E8
		public static GameObject UIWarnButton
		{
			get
			{
				return Utils.QuickMenu.transform.Find("UserInteractMenu/WarnButton").gameObject;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000301 RID: 769 RVA: 0x00019014 File Offset: 0x00017214
		public static GameObject UIKickButton
		{
			get
			{
				return Utils.QuickMenu.transform.Find("UserInteractMenu/KickButton").gameObject;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000302 RID: 770 RVA: 0x00019040 File Offset: 0x00017240
		public static GameObject UIBackButton
		{
			get
			{
				return Utils.QuickMenu.transform.Find("UserInteractMenu/BackButton").gameObject;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000303 RID: 771 RVA: 0x0001906C File Offset: 0x0001726C
		public static GameObject UIViewPlaylistsButton
		{
			get
			{
				return Utils.QuickMenu.transform.Find("UserInteractMenu/ViewPlaylistsButton").gameObject;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000304 RID: 772 RVA: 0x00019098 File Offset: 0x00017298
		public static GameObject UIShowAvatarStatsButton
		{
			get
			{
				return Utils.QuickMenu.transform.Find("UserInteractMenu/ShowAvatarStatsButton").gameObject;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000305 RID: 773 RVA: 0x000190C4 File Offset: 0x000172C4
		public static GameObject UICloneAvatarButton
		{
			get
			{
				return Utils.QuickMenu.transform.Find("UserInteractMenu/CloneAvatarButton").gameObject;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000306 RID: 774 RVA: 0x000190F0 File Offset: 0x000172F0
		public static GameObject UIShowAuthorButton
		{
			get
			{
				return Utils.QuickMenu.transform.Find("UserInteractMenu/ShowAuthorButton").gameObject;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000307 RID: 775 RVA: 0x0001911C File Offset: 0x0001731C
		public static GameObject AvatarFavoriteButton
		{
			get
			{
				return GameObject.Find("UserInterface/MenuContent/Screens/Settings/Favorite Button");
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000308 RID: 776 RVA: 0x00019138 File Offset: 0x00017338
		public static GameObject AvatarTitleText
		{
			get
			{
				return GameObject.Find("UserInterface/MenuContent/Screens/Settings/TitlePanel (1)/TitleText");
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000309 RID: 777 RVA: 0x00019154 File Offset: 0x00017354
		public static GameObject AvatarPublicAvatarList
		{
			get
			{
				return GameObject.Find("UserInterface/MenuContent/Screens/Settings/Vertical Scroll View/Viewport/Content/Public Avatar List");
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600030A RID: 778 RVA: 0x00019170 File Offset: 0x00017370
		public static GameObject AvatarChangeButton
		{
			get
			{
				return GameObject.Find("UserInterface/MenuContent/Screens/Settings/Change Button");
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600030B RID: 779 RVA: 0x0001918C File Offset: 0x0001738C
		public static GameObject AvatarStatsButton
		{
			get
			{
				return GameObject.Find("UserInterface/MenuContent/Screens/Settings/Stats Button");
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600030C RID: 780 RVA: 0x000191A8 File Offset: 0x000173A8
		public static GameObject AvatarModel
		{
			get
			{
				return GameObject.Find("UserInterface/MenuContent/Screens/Settings/AvatarModel");
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600030D RID: 781 RVA: 0x000191C4 File Offset: 0x000173C4
		public static GameObject SocialSearch
		{
			get
			{
				return GameObject.Find("UserInterface/MenuContent/Social/Vertical Scroll View/Viewport/Content/Search");
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600030E RID: 782 RVA: 0x000191E0 File Offset: 0x000173E0
		public static GameObject SocialOfflineFriendsList
		{
			get
			{
				return GameObject.Find("UserInterface/MenuContent/Social/Vertical Scroll View/Viewport/Content/OfflineFriends");
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600030F RID: 783 RVA: 0x000191FC File Offset: 0x000173FC
		public static GameObject SocialOnlineFriendsList
		{
			get
			{
				return GameObject.Find("UserInterface/MenuContent/Social/Vertical Scroll View/Viewport/Content/OfflineFriends");
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000310 RID: 784 RVA: 0x00019218 File Offset: 0x00017418
		public static GameObject SocialFriendRequestList
		{
			get
			{
				return GameObject.Find("UserInterface/MenuContent/Social/ Vertical Scroll View/Viewport/Content/FriendRequests");
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000311 RID: 785 RVA: 0x00019234 File Offset: 0x00017434
		public static GameObject SocialFriendsGroup1List
		{
			get
			{
				return GameObject.Find("UserInterface/MenuContent/Social/Vertical Scroll View/Viewport/Content/FriendsGroup1");
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000312 RID: 786 RVA: 0x00019250 File Offset: 0x00017450
		public static GameObject SocialFriendsGroup2List
		{
			get
			{
				return GameObject.Find("UserInterface/MenuContent/Social/Vertical Scroll View/Viewport/Content/FriendsGroup2");
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000313 RID: 787 RVA: 0x0001926C File Offset: 0x0001746C
		public static GameObject SocialFriendsGroup3List
		{
			get
			{
				return GameObject.Find("UserInterface/MenuContent/Social/Vertical Scroll View/Viewport/Content/FriendsGroup3");
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000314 RID: 788 RVA: 0x00019288 File Offset: 0x00017488
		public static GameObject UserInfoPlaylistButton
		{
			get
			{
				return GameObject.Find("UserInterface/MenuContent/Screens/UserInfo/Buttons/RightSideButtons/RightUpperButtonColumn/PlaylistsButton");
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000315 RID: 789 RVA: 0x000192A4 File Offset: 0x000174A4
		public static GameObject USINFOVRCSupportButton
		{
			get
			{
				return GameObject.Find("UserInterface/MenuContent/Screens/UserInfo/User Panel/Supporter");
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000316 RID: 790 RVA: 0x000192C0 File Offset: 0x000174C0
		public static GameObject USINFOStupidCat
		{
			get
			{
				return GameObject.Find("UserInterface/MenuContent/Screens/UserInfo/User Panel/VRCPlusEarlyAdopter");
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000317 RID: 791 RVA: 0x000192DC File Offset: 0x000174DC
		public static GameObject SettingsTitleText
		{
			get
			{
				return Utils.VRCUiManager.GetMenuContent().transform.Find("Screens/Settings/TitlePanel/TitleText").gameObject;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000318 RID: 792 RVA: 0x0001930C File Offset: 0x0001750C
		public static GameObject SettingsVersionText
		{
			get
			{
				return Utils.VRCUiManager.GetMenuContent().transform.Find("Screens/Settings/TitlePanel/VersionText").gameObject;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000319 RID: 793 RVA: 0x0001933C File Offset: 0x0001753C
		public static GameObject SettingsAudioSlider
		{
			get
			{
				return Utils.VRCUiManager.GetMenuContent().transform.Find("Screens/Settings/AudioDevicePanel/VolumeSlider").gameObject;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600031A RID: 794 RVA: 0x0001936C File Offset: 0x0001756C
		public static GameObject SettingsAudioSelectNextMic
		{
			get
			{
				return Utils.VRCUiManager.GetMenuContent().transform.Find("Screens/Settings/AudioDevicePanel").gameObject;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600031B RID: 795 RVA: 0x0001939C File Offset: 0x0001759C
		public static GameObject SettingsAudioSelectPrevMic
		{
			get
			{
				return Utils.VRCUiManager.GetMenuContent().transform.Find("Screens/Settings/AudioDevicePanel/SelectPrevMic").gameObject;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600031C RID: 796 RVA: 0x000193CC File Offset: 0x000175CC
		public static GameObject SettingsAudioPanel
		{
			get
			{
				return Utils.VRCUiManager.GetMenuContent().transform.Find("Screens/Settings/AudioDevicePanel").gameObject;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600031D RID: 797 RVA: 0x000193FC File Offset: 0x000175FC
		public static GameObject SettingsNameText
		{
			get
			{
				return Utils.VRCUiManager.GetMenuContent().transform.Find("Screens/Settings/Footer/NameText").gameObject;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600031E RID: 798 RVA: 0x0001942C File Offset: 0x0001762C
		public static GameObject hudRoot
		{
			get
			{
				return GameObject.Find("UserInterface/UnscaledUI/HudContent/Hud").gameObject;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600031F RID: 799 RVA: 0x00019450 File Offset: 0x00017650
		public static GameObject inviteObj
		{
			get
			{
				return VRChatObjects.hudRoot.transform.Find("NotificationDotParent/InviteDot").gameObject;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000320 RID: 800 RVA: 0x0001947C File Offset: 0x0001767C
		public static GameObject inviteReqObj
		{
			get
			{
				return VRChatObjects.hudRoot.transform.Find("NotificationDotParent/InviteRequestDot").gameObject;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000321 RID: 801 RVA: 0x000194A8 File Offset: 0x000176A8
		public static GameObject notificationObj
		{
			get
			{
				return VRChatObjects.hudRoot.transform.Find("NotificationDotParent/NotificationDot").gameObject;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000322 RID: 802 RVA: 0x000194D4 File Offset: 0x000176D4
		public static GameObject voteKickObj
		{
			get
			{
				return VRChatObjects.hudRoot.transform.Find("NotificationDotParent/VoteKickDot").gameObject;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000323 RID: 803 RVA: 0x00019500 File Offset: 0x00017700
		public static GameObject friendRequestObj
		{
			get
			{
				return VRChatObjects.hudRoot.transform.Find("NotificationDotParent/FriendRequestDot").gameObject;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000324 RID: 804 RVA: 0x0001952C File Offset: 0x0001772C
		public static GameObject voiceDotObj
		{
			get
			{
				return VRChatObjects.hudRoot.transform.Find("VoiceDotParent/VoiceDot").gameObject;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000325 RID: 805 RVA: 0x00019558 File Offset: 0x00017758
		public static GameObject voiceDotDisabledObj
		{
			get
			{
				return VRChatObjects.hudRoot.transform.Find("VoiceDotParent/VoiceDotDisabled").gameObject;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000326 RID: 806 RVA: 0x00019584 File Offset: 0x00017784
		public static GameObject voicePushToTalkKeybd
		{
			get
			{
				return VRChatObjects.hudRoot.transform.Find("VoiceDotParent/PushToTalkKeybd").gameObject;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000327 RID: 807 RVA: 0x000195B0 File Offset: 0x000177B0
		public static GameObject voicePushToTalkXboxj
		{
			get
			{
				return VRChatObjects.hudRoot.transform.Find("VoiceDotParent/PushToTalkXbox").gameObject;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000328 RID: 808 RVA: 0x000195DC File Offset: 0x000177DC
		public static GameObject Mouse
		{
			get
			{
				return GameObject.Find("/_Application/CursorManager/BlueFireballMouse");
			}
		}
	}
}
