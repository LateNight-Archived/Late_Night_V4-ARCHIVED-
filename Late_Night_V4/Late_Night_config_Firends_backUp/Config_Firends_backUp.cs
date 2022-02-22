using System;
using System.Collections.Generic;
using System.IO;
using Late_Night_V3_PlayerObjects;
using Newtonsoft.Json;

namespace Late_Night_config_Firends_backUp
{
	// Token: 0x0200006B RID: 107
	internal class Config_Firends_backUp
	{
		// Token: 0x06000464 RID: 1124 RVA: 0x0001DE04 File Offset: 0x0001C004
		internal void SaveConfig_Firends_backUp()
		{
			string contents = JsonConvert.SerializeObject(this, 1);
			File.WriteAllText("Late_night_V4/LNC_Firends_backUp.json", contents);
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x0001DE28 File Offset: 0x0001C028
		internal static Config_Firends_backUp Load_Firends_backUp()
		{
			bool flag = !File.Exists("Late_night_V4/LNC_Firends_backUp.json");
			Config_Firends_backUp result;
			if (flag)
			{
				result = new Config_Firends_backUp();
			}
			else
			{
				Config_Firends_backUp.Instance = JsonConvert.DeserializeObject<Config_Firends_backUp>(File.ReadAllText("Late_night_V4/LNC_Firends_backUp.json"));
				result = Config_Firends_backUp.Instance;
			}
			return result;
		}

		// Token: 0x040001EE RID: 494
		public List<PLayerObjects> firends = new List<PLayerObjects>();

		// Token: 0x040001EF RID: 495
		public static Config_Firends_backUp Instance;
	}
}
