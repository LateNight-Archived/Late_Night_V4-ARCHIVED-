using System;
using System.Collections.Generic;
using System.IO;
using Late_Night_V3_AvatarObject;
using Newtonsoft.Json;

namespace Late_Night_V3_Config_Seen_AVIS
{
	// Token: 0x02000069 RID: 105
	internal class Config_Seen_AVIS
	{
		// Token: 0x0600045E RID: 1118 RVA: 0x0001DD04 File Offset: 0x0001BF04
		internal void SaveConfig_AVIS_SEEN()
		{
			string contents = JsonConvert.SerializeObject(this, 1);
			File.WriteAllText("Late_night_V4/LNC_AVI_SEEN.json", contents);
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0001DD28 File Offset: 0x0001BF28
		internal static Config_Seen_AVIS Load_AVIS_SEEN()
		{
			bool flag = !File.Exists("Late_night_V4/LNC_AVI_SEEN.json");
			Config_Seen_AVIS result;
			if (flag)
			{
				result = new Config_Seen_AVIS();
			}
			else
			{
				Config_Seen_AVIS.Instance = JsonConvert.DeserializeObject<Config_Seen_AVIS>(File.ReadAllText("Late_night_V4/LNC_AVI_SEEN.json"));
				result = Config_Seen_AVIS.Instance;
			}
			return result;
		}

		// Token: 0x040001EA RID: 490
		public List<AvatarObject> SEEN_AVIS = new List<AvatarObject>();

		// Token: 0x040001EB RID: 491
		public static Config_Seen_AVIS Instance;
	}
}
