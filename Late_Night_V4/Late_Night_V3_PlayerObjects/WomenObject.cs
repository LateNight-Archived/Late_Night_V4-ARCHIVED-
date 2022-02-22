using System;

namespace Late_Night_V3_PlayerObjects
{
	// Token: 0x02000032 RID: 50
	public class WomenObject
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x000137EE File Offset: 0x000119EE
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x000137F6 File Offset: 0x000119F6
		public string name { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x000137FF File Offset: 0x000119FF
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x00013807 File Offset: 0x00011A07
		public string id { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00013810 File Offset: 0x00011A10
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x00013818 File Offset: 0x00011A18
		public string age { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00013821 File Offset: 0x00011A21
		// (set) Token: 0x060001CB RID: 459 RVA: 0x00013829 File Offset: 0x00011A29
		public string race { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060001CC RID: 460 RVA: 0x00013832 File Offset: 0x00011A32
		// (set) Token: 0x060001CD RID: 461 RVA: 0x0001383A File Offset: 0x00011A3A
		public bool CanCook { get; set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00013843 File Offset: 0x00011A43
		// (set) Token: 0x060001CF RID: 463 RVA: 0x0001384B File Offset: 0x00011A4B
		public bool isCooking { get; set; }

		// Token: 0x060001D0 RID: 464 RVA: 0x00013854 File Offset: 0x00011A54
		public WomenObject(string Name, string ID, string AgeYears, string race_, bool cancook, bool iscooking)
		{
			this.name = Name;
			this.id = ID;
			this.age = AgeYears;
			this.race = race_;
			this.CanCook = cancook;
			this.isCooking = iscooking;
		}
	}
}
