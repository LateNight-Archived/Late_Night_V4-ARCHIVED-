using System;
using System.Collections.Generic;
using System.IO;
using Late_Night_V3_WorldObjects;
using Newtonsoft.Json;

namespace Late_Night_V3_Config_World_Histoy
{
	// Token: 0x02000068 RID: 104
	internal class Config_World_Histoy
	{
		// Token: 0x0600045B RID: 1115 RVA: 0x0001DC84 File Offset: 0x0001BE84
		internal void SaveConfig()
		{
			string contents = JsonConvert.SerializeObject(this, 1);
			File.WriteAllText("Late_night_V4/LNC_WORLD_HISTORY.json", contents);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0001DCA8 File Offset: 0x0001BEA8
		internal static Config_World_Histoy Load()
		{
			bool flag = !File.Exists("Late_night_V4/LNC_WORLD_HISTORY.json");
			Config_World_Histoy result;
			if (flag)
			{
				result = new Config_World_Histoy();
			}
			else
			{
				Config_World_Histoy.Instance = JsonConvert.DeserializeObject<Config_World_Histoy>(File.ReadAllText("Late_night_V4/LNC_WORLD_HISTORY.json"));
				result = Config_World_Histoy.Instance;
			}
			return result;
		}

		// Token: 0x040001E8 RID: 488
		public List<WorldObjects> WorldHist = new List<WorldObjects>();

		// Token: 0x040001E9 RID: 489
		public static Config_World_Histoy Instance;
	}
}
