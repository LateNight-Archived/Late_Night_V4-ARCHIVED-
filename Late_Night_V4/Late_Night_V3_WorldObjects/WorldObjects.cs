using System;

namespace Late_Night_V3_WorldObjects
{
	// Token: 0x0200000E RID: 14
	public class WorldObjects
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00005115 File Offset: 0x00003315
		// (set) Token: 0x06000099 RID: 153 RVA: 0x0000511D File Offset: 0x0000331D
		public string name { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00005126 File Offset: 0x00003326
		// (set) Token: 0x0600009B RID: 155 RVA: 0x0000512E File Offset: 0x0000332E
		public string id { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00005137 File Offset: 0x00003337
		// (set) Token: 0x0600009D RID: 157 RVA: 0x0000513F File Offset: 0x0000333F
		public string Type { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00005148 File Offset: 0x00003348
		// (set) Token: 0x0600009F RID: 159 RVA: 0x00005150 File Offset: 0x00003350
		public string TimeJoin { get; set; }

		// Token: 0x060000A0 RID: 160 RVA: 0x00005159 File Offset: 0x00003359
		public WorldObjects(string WorldName, string ID, string type, string time)
		{
			this.name = WorldName;
			this.id = ID;
			this.Type = type;
			this.TimeJoin = time;
		}
	}
}
