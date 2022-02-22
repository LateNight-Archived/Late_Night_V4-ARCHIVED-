using System;

namespace Late_Night_V3_PlayerObjects
{
	// Token: 0x02000031 RID: 49
	public class PLayerObjects
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060001BF RID: 447 RVA: 0x000137B2 File Offset: 0x000119B2
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x000137BA File Offset: 0x000119BA
		public string name { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x000137C3 File Offset: 0x000119C3
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x000137CB File Offset: 0x000119CB
		public string id { get; set; }

		// Token: 0x060001C3 RID: 451 RVA: 0x000137D4 File Offset: 0x000119D4
		public PLayerObjects(string Name, string ID)
		{
			this.name = Name;
			this.id = ID;
		}
	}
}
