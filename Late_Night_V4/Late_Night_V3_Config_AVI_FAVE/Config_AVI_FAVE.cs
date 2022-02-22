using System;
using System.Collections.Generic;
using System.IO;
using Late_Night_V3_AvatarObject;
using Newtonsoft.Json;

namespace Late_Night_V3_Config_AVI_FAVE
{
	// Token: 0x0200006A RID: 106
	internal class Config_AVI_FAVE
	{
		// Token: 0x06000461 RID: 1121 RVA: 0x0001DD84 File Offset: 0x0001BF84
		internal void SaveConfig_AVIS_FAVE()
		{
			string contents = JsonConvert.SerializeObject(this, 1);
			File.WriteAllText("Late_night_V4/LNC_AVI_FAVE.json", contents);
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0001DDA8 File Offset: 0x0001BFA8
		internal static Config_AVI_FAVE Load_AVIS_FAVE()
		{
			bool flag = !File.Exists("Late_night_V4/LNC_AVI_FAVE.json");
			Config_AVI_FAVE result;
			if (flag)
			{
				result = new Config_AVI_FAVE();
			}
			else
			{
				Config_AVI_FAVE.Instance = JsonConvert.DeserializeObject<Config_AVI_FAVE>(File.ReadAllText("Late_night_V4/LNC_AVI_FAVE.json"));
				result = Config_AVI_FAVE.Instance;
			}
			return result;
		}

		// Token: 0x040001EC RID: 492
		public List<AvatarObject> Avis = new List<AvatarObject>();

		// Token: 0x040001ED RID: 493
		public static Config_AVI_FAVE Instance;
	}
}
