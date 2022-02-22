using System;
using System.Collections.Generic;

namespace Late_Night_V4.External_Libraries.SkidHubAPI
{
	// Token: 0x0200002C RID: 44
	internal class NetworkingObject
	{
		// Token: 0x02000099 RID: 153
		public class Plans
		{
			// Token: 0x170000FE RID: 254
			// (get) Token: 0x06000661 RID: 1633 RVA: 0x00023C86 File Offset: 0x00021E86
			// (set) Token: 0x06000662 RID: 1634 RVA: 0x00023C8E File Offset: 0x00021E8E
			public string Name { get; set; }

			// Token: 0x170000FF RID: 255
			// (get) Token: 0x06000663 RID: 1635 RVA: 0x00023C97 File Offset: 0x00021E97
			// (set) Token: 0x06000664 RID: 1636 RVA: 0x00023C9F File Offset: 0x00021E9F
			public DateTime bought { get; set; }

			// Token: 0x17000100 RID: 256
			// (get) Token: 0x06000665 RID: 1637 RVA: 0x00023CA8 File Offset: 0x00021EA8
			// (set) Token: 0x06000666 RID: 1638 RVA: 0x00023CB0 File Offset: 0x00021EB0
			public DateTime Duration { get; set; }

			// Token: 0x17000101 RID: 257
			// (get) Token: 0x06000667 RID: 1639 RVA: 0x00023CB9 File Offset: 0x00021EB9
			// (set) Token: 0x06000668 RID: 1640 RVA: 0x00023CC1 File Offset: 0x00021EC1
			public bool Lifetime { get; set; }
		}

		// Token: 0x0200009A RID: 154
		public class Avi
		{
			// Token: 0x17000102 RID: 258
			// (get) Token: 0x0600066A RID: 1642 RVA: 0x00023CD3 File Offset: 0x00021ED3
			// (set) Token: 0x0600066B RID: 1643 RVA: 0x00023CDB File Offset: 0x00021EDB
			public string id { get; set; }

			// Token: 0x17000103 RID: 259
			// (get) Token: 0x0600066C RID: 1644 RVA: 0x00023CE4 File Offset: 0x00021EE4
			// (set) Token: 0x0600066D RID: 1645 RVA: 0x00023CEC File Offset: 0x00021EEC
			public string name { get; set; }

			// Token: 0x17000104 RID: 260
			// (get) Token: 0x0600066E RID: 1646 RVA: 0x00023CF5 File Offset: 0x00021EF5
			// (set) Token: 0x0600066F RID: 1647 RVA: 0x00023CFD File Offset: 0x00021EFD
			public string authorId { get; set; }

			// Token: 0x17000105 RID: 261
			// (get) Token: 0x06000670 RID: 1648 RVA: 0x00023D06 File Offset: 0x00021F06
			// (set) Token: 0x06000671 RID: 1649 RVA: 0x00023D0E File Offset: 0x00021F0E
			public string authorName { get; set; }

			// Token: 0x17000106 RID: 262
			// (get) Token: 0x06000672 RID: 1650 RVA: 0x00023D17 File Offset: 0x00021F17
			// (set) Token: 0x06000673 RID: 1651 RVA: 0x00023D1F File Offset: 0x00021F1F
			public string assetUrl { get; set; }

			// Token: 0x17000107 RID: 263
			// (get) Token: 0x06000674 RID: 1652 RVA: 0x00023D28 File Offset: 0x00021F28
			// (set) Token: 0x06000675 RID: 1653 RVA: 0x00023D30 File Offset: 0x00021F30
			public string thumbnailImageUrl { get; set; }

			// Token: 0x17000108 RID: 264
			// (get) Token: 0x06000676 RID: 1654 RVA: 0x00023D39 File Offset: 0x00021F39
			// (set) Token: 0x06000677 RID: 1655 RVA: 0x00023D41 File Offset: 0x00021F41
			public string supportedPlatforms { get; set; }

			// Token: 0x17000109 RID: 265
			// (get) Token: 0x06000678 RID: 1656 RVA: 0x00023D4A File Offset: 0x00021F4A
			// (set) Token: 0x06000679 RID: 1657 RVA: 0x00023D52 File Offset: 0x00021F52
			public string releaseStatus { get; set; }

			// Token: 0x1700010A RID: 266
			// (get) Token: 0x0600067A RID: 1658 RVA: 0x00023D5B File Offset: 0x00021F5B
			// (set) Token: 0x0600067B RID: 1659 RVA: 0x00023D63 File Offset: 0x00021F63
			public string description { get; set; }

			// Token: 0x1700010B RID: 267
			// (get) Token: 0x0600067C RID: 1660 RVA: 0x00023D6C File Offset: 0x00021F6C
			// (set) Token: 0x0600067D RID: 1661 RVA: 0x00023D74 File Offset: 0x00021F74
			public int version { get; set; }
		}

		// Token: 0x0200009B RID: 155
		public class User
		{
			// Token: 0x1700010C RID: 268
			// (get) Token: 0x0600067F RID: 1663 RVA: 0x00023D86 File Offset: 0x00021F86
			// (set) Token: 0x06000680 RID: 1664 RVA: 0x00023D8E File Offset: 0x00021F8E
			public string _id { get; set; }

			// Token: 0x1700010D RID: 269
			// (get) Token: 0x06000681 RID: 1665 RVA: 0x00023D97 File Offset: 0x00021F97
			// (set) Token: 0x06000682 RID: 1666 RVA: 0x00023D9F File Offset: 0x00021F9F
			public string Username { get; set; }

			// Token: 0x1700010E RID: 270
			// (get) Token: 0x06000683 RID: 1667 RVA: 0x00023DA8 File Offset: 0x00021FA8
			// (set) Token: 0x06000684 RID: 1668 RVA: 0x00023DB0 File Offset: 0x00021FB0
			public ulong DiscordID { get; set; }

			// Token: 0x1700010F RID: 271
			// (get) Token: 0x06000685 RID: 1669 RVA: 0x00023DB9 File Offset: 0x00021FB9
			// (set) Token: 0x06000686 RID: 1670 RVA: 0x00023DC1 File Offset: 0x00021FC1
			public string DiscordTag { get; set; }

			// Token: 0x17000110 RID: 272
			// (get) Token: 0x06000687 RID: 1671 RVA: 0x00023DCA File Offset: 0x00021FCA
			// (set) Token: 0x06000688 RID: 1672 RVA: 0x00023DD2 File Offset: 0x00021FD2
			public string Password { get; set; }

			// Token: 0x17000111 RID: 273
			// (get) Token: 0x06000689 RID: 1673 RVA: 0x00023DDB File Offset: 0x00021FDB
			// (set) Token: 0x0600068A RID: 1674 RVA: 0x00023DE3 File Offset: 0x00021FE3
			public string HWID { get; set; }

			// Token: 0x17000112 RID: 274
			// (get) Token: 0x0600068B RID: 1675 RVA: 0x00023DEC File Offset: 0x00021FEC
			// (set) Token: 0x0600068C RID: 1676 RVA: 0x00023DF4 File Offset: 0x00021FF4
			public string IP { get; set; }

			// Token: 0x17000113 RID: 275
			// (get) Token: 0x0600068D RID: 1677 RVA: 0x00023DFD File Offset: 0x00021FFD
			// (set) Token: 0x0600068E RID: 1678 RVA: 0x00023E05 File Offset: 0x00022005
			public List<string> VRCId { get; set; }

			// Token: 0x17000114 RID: 276
			// (get) Token: 0x0600068F RID: 1679 RVA: 0x00023E0E File Offset: 0x0002200E
			// (set) Token: 0x06000690 RID: 1680 RVA: 0x00023E16 File Offset: 0x00022016
			public List<string> AllHWID { get; set; }

			// Token: 0x17000115 RID: 277
			// (get) Token: 0x06000691 RID: 1681 RVA: 0x00023E1F File Offset: 0x0002201F
			// (set) Token: 0x06000692 RID: 1682 RVA: 0x00023E27 File Offset: 0x00022027
			public List<string> AllIP { get; set; }

			// Token: 0x17000116 RID: 278
			// (get) Token: 0x06000693 RID: 1683 RVA: 0x00023E30 File Offset: 0x00022030
			// (set) Token: 0x06000694 RID: 1684 RVA: 0x00023E38 File Offset: 0x00022038
			public bool Banned { get; set; }

			// Token: 0x17000117 RID: 279
			// (get) Token: 0x06000695 RID: 1685 RVA: 0x00023E41 File Offset: 0x00022041
			// (set) Token: 0x06000696 RID: 1686 RVA: 0x00023E49 File Offset: 0x00022049
			public string Message { get; set; }

			// Token: 0x17000118 RID: 280
			// (get) Token: 0x06000697 RID: 1687 RVA: 0x00023E52 File Offset: 0x00022052
			// (set) Token: 0x06000698 RID: 1688 RVA: 0x00023E5A File Offset: 0x0002205A
			public bool Beta { get; set; }

			// Token: 0x17000119 RID: 281
			// (get) Token: 0x06000699 RID: 1689 RVA: 0x00023E63 File Offset: 0x00022063
			// (set) Token: 0x0600069A RID: 1690 RVA: 0x00023E6B File Offset: 0x0002206B
			public bool Admin { get; set; }

			// Token: 0x1700011A RID: 282
			// (get) Token: 0x0600069B RID: 1691 RVA: 0x00023E74 File Offset: 0x00022074
			// (set) Token: 0x0600069C RID: 1692 RVA: 0x00023E7C File Offset: 0x0002207C
			public bool Staff { get; set; }

			// Token: 0x1700011B RID: 283
			// (get) Token: 0x0600069D RID: 1693 RVA: 0x00023E85 File Offset: 0x00022085
			// (set) Token: 0x0600069E RID: 1694 RVA: 0x00023E8D File Offset: 0x0002208D
			public bool Registered { get; set; }

			// Token: 0x1700011C RID: 284
			// (get) Token: 0x0600069F RID: 1695 RVA: 0x00023E96 File Offset: 0x00022096
			// (set) Token: 0x060006A0 RID: 1696 RVA: 0x00023E9E File Offset: 0x0002209E
			public bool UnlockedSafety { get; set; }

			// Token: 0x1700011D RID: 285
			// (get) Token: 0x060006A1 RID: 1697 RVA: 0x00023EA7 File Offset: 0x000220A7
			// (set) Token: 0x060006A2 RID: 1698 RVA: 0x00023EAF File Offset: 0x000220AF
			public int SkidCoins { get; set; }

			// Token: 0x1700011E RID: 286
			// (get) Token: 0x060006A3 RID: 1699 RVA: 0x00023EB8 File Offset: 0x000220B8
			// (set) Token: 0x060006A4 RID: 1700 RVA: 0x00023EC0 File Offset: 0x000220C0
			public List<string> CrashedUsernames { get; set; }

			// Token: 0x1700011F RID: 287
			// (get) Token: 0x060006A5 RID: 1701 RVA: 0x00023EC9 File Offset: 0x000220C9
			// (set) Token: 0x060006A6 RID: 1702 RVA: 0x00023ED1 File Offset: 0x000220D1
			public double PlayTime { get; set; }

			// Token: 0x17000120 RID: 288
			// (get) Token: 0x060006A7 RID: 1703 RVA: 0x00023EDA File Offset: 0x000220DA
			// (set) Token: 0x060006A8 RID: 1704 RVA: 0x00023EE2 File Offset: 0x000220E2
			public List<NetworkingObject.Avi> Avatarsseen { get; set; }

			// Token: 0x17000121 RID: 289
			// (get) Token: 0x060006A9 RID: 1705 RVA: 0x00023EEB File Offset: 0x000220EB
			// (set) Token: 0x060006AA RID: 1706 RVA: 0x00023EF3 File Offset: 0x000220F3
			public List<NetworkingObject.Plans> Access { get; set; }

			// Token: 0x17000122 RID: 290
			// (get) Token: 0x060006AB RID: 1707 RVA: 0x00023EFC File Offset: 0x000220FC
			// (set) Token: 0x060006AC RID: 1708 RVA: 0x00023F04 File Offset: 0x00022104
			public List<string> Userseen { get; set; }

			// Token: 0x17000123 RID: 291
			// (get) Token: 0x060006AD RID: 1709 RVA: 0x00023F0D File Offset: 0x0002210D
			// (set) Token: 0x060006AE RID: 1710 RVA: 0x00023F15 File Offset: 0x00022115
			public int MeetedBlankinlobby { get; set; }

			// Token: 0x17000124 RID: 292
			// (get) Token: 0x060006AF RID: 1711 RVA: 0x00023F1E File Offset: 0x0002211E
			// (set) Token: 0x060006B0 RID: 1712 RVA: 0x00023F26 File Offset: 0x00022126
			public int CrashedbyBlank { get; set; }

			// Token: 0x060006B1 RID: 1713 RVA: 0x00023F30 File Offset: 0x00022130
			public bool HasPlan(string Plan)
			{
				bool result = false;
				foreach (NetworkingObject.Plans plans in this.Access)
				{
					bool flag = plans.Name == Plan;
					if (flag)
					{
						bool lifetime = plans.Lifetime;
						if (lifetime)
						{
							result = true;
						}
						bool flag2 = DateTime.Compare(DateTime.UtcNow, plans.Duration) == 0 || DateTime.Compare(DateTime.Now, plans.Duration) == -1;
						if (flag2)
						{
							result = true;
						}
					}
				}
				return result;
			}
		}
	}
}
