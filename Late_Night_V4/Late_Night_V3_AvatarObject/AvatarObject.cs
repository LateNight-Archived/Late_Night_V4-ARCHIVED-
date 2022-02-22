using System;
using VRC.Core;

namespace Late_Night_V3_AvatarObject
{
	// Token: 0x02000035 RID: 53
	public class AvatarObject
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x00013E2A File Offset: 0x0001202A
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x00013E32 File Offset: 0x00012032
		public string name { get; set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x00013E3B File Offset: 0x0001203B
		// (set) Token: 0x060001DA RID: 474 RVA: 0x00013E43 File Offset: 0x00012043
		public string id { get; set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060001DB RID: 475 RVA: 0x00013E4C File Offset: 0x0001204C
		// (set) Token: 0x060001DC RID: 476 RVA: 0x00013E54 File Offset: 0x00012054
		public string authorId { get; set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060001DD RID: 477 RVA: 0x00013E5D File Offset: 0x0001205D
		// (set) Token: 0x060001DE RID: 478 RVA: 0x00013E65 File Offset: 0x00012065
		public string authorName { get; set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060001DF RID: 479 RVA: 0x00013E6E File Offset: 0x0001206E
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x00013E76 File Offset: 0x00012076
		public string assetUrl { get; set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x00013E7F File Offset: 0x0001207F
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x00013E87 File Offset: 0x00012087
		public string thumbnailImageUrl { get; set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00013E90 File Offset: 0x00012090
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x00013E98 File Offset: 0x00012098
		public string supportedPlatforms { get; set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x00013EA1 File Offset: 0x000120A1
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x00013EA9 File Offset: 0x000120A9
		public string releaseStatus { get; set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x00013EB2 File Offset: 0x000120B2
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x00013EBA File Offset: 0x000120BA
		public string description { get; set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x00013EC3 File Offset: 0x000120C3
		// (set) Token: 0x060001EA RID: 490 RVA: 0x00013ECB File Offset: 0x000120CB
		public int version { get; set; }

		// Token: 0x060001EB RID: 491 RVA: 0x00013ED4 File Offset: 0x000120D4
		public ApiAvatar ToApiAvatar()
		{
			return new ApiAvatar
			{
				name = this.name,
				id = this.id,
				authorId = this.authorId,
				authorName = this.authorName,
				assetUrl = this.assetUrl,
				thumbnailImageUrl = this.thumbnailImageUrl,
				supportedPlatforms = ((this.supportedPlatforms == "All ") ? 3 : 1),
				description = this.description,
				releaseStatus = this.releaseStatus,
				version = this.version
			};
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00013F80 File Offset: 0x00012180
		public static ApiAvatar ApiAvatar(AvatarObject avatar)
		{
			return new ApiAvatar
			{
				name = avatar.name,
				id = avatar.id,
				authorId = avatar.authorId,
				authorName = avatar.authorName,
				assetUrl = avatar.assetUrl,
				thumbnailImageUrl = avatar.thumbnailImageUrl,
				supportedPlatforms = ((avatar.supportedPlatforms == "All") ? 3 : 1),
				description = avatar.description,
				releaseStatus = avatar.releaseStatus,
				version = avatar.version
			};
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0001402C File Offset: 0x0001222C
		public AvatarObject(ApiAvatar avtr)
		{
			this.name = avtr.name;
			this.id = avtr.id;
			this.authorId = avtr.authorId;
			this.authorName = avtr.authorName;
			this.assetUrl = avtr.assetUrl;
			this.thumbnailImageUrl = avtr.thumbnailImageUrl;
			this.supportedPlatforms = avtr.supportedPlatforms.ToString();
			this.description = avtr.description;
			this.releaseStatus = avtr.releaseStatus;
			this.version = avtr.version;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x000140D1 File Offset: 0x000122D1
		public AvatarObject()
		{
		}
	}
}
