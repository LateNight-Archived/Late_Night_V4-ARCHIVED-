using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Late_Night_config
{
	// Token: 0x02000034 RID: 52
	internal class Config
	{
		// Token: 0x060001D4 RID: 468 RVA: 0x000139E4 File Offset: 0x00011BE4
		internal void SaveConfig()
		{
			string contents = JsonConvert.SerializeObject(this, 1);
			File.WriteAllText("Late_night_V4/NEW_LNC_config.json", contents);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00013A08 File Offset: 0x00011C08
		internal static Config Load()
		{
			bool flag = !File.Exists("Late_night_V4/NEW_LNC_config.json");
			Config result;
			if (flag)
			{
				result = new Config();
			}
			else
			{
				Config.Instance = JsonConvert.DeserializeObject<Config>(File.ReadAllText("Late_night_V4/NEW_LNC_config.json"));
				result = Config.Instance;
			}
			return result;
		}

		// Token: 0x040000E5 RID: 229
		public int PolyLimit = 2000000;

		// Token: 0x040000E6 RID: 230
		public int MaterialLimit = 225;

		// Token: 0x040000E7 RID: 231
		public int DynamicBoneLimit = 75;

		// Token: 0x040000E8 RID: 232
		public int DBColiderLimit = 50;

		// Token: 0x040000E9 RID: 233
		public int ShaderLimit = 100;

		// Token: 0x040000EA RID: 234
		public int ClothVertLimit = 15000;

		// Token: 0x040000EB RID: 235
		public int LSorceLimit = 2;

		// Token: 0x040000EC RID: 236
		public int ColliderLimit = 0;

		// Token: 0x040000ED RID: 237
		public int SpringJLimit = 10;

		// Token: 0x040000EE RID: 238
		public int TransformLimit = 3000;

		// Token: 0x040000EF RID: 239
		public int PartLimit = 5000;

		// Token: 0x040000F0 RID: 240
		public int ParticleMVLimit = 1000000;

		// Token: 0x040000F1 RID: 241
		public int MeshLimit = 16;

		// Token: 0x040000F2 RID: 242
		public int BoLimit = 0;

		// Token: 0x040000F3 RID: 243
		public string Friend = "#ffd000";

		// Token: 0x040000F4 RID: 244
		public string Trusted = "#9000ff";

		// Token: 0x040000F5 RID: 245
		public string known = "#ff6200";

		// Token: 0x040000F6 RID: 246
		public string user = "#02e020";

		// Token: 0x040000F7 RID: 247
		public string Newuser = "#2977ff";

		// Token: 0x040000F8 RID: 248
		public string vistor = "#848587";

		// Token: 0x040000F9 RID: 249
		public string SpeckingBubble = "#000000";

		// Token: 0x040000FA RID: 250
		public string Master = "#00e5ff";

		// Token: 0x040000FB RID: 251
		public bool Limiter = true;

		// Token: 0x040000FC RID: 252
		public bool PolyLimitb = true;

		// Token: 0x040000FD RID: 253
		public bool MaterialLimitb = true;

		// Token: 0x040000FE RID: 254
		public bool DynamicBoneLimitb = true;

		// Token: 0x040000FF RID: 255
		public bool DBColiderLimitb = true;

		// Token: 0x04000100 RID: 256
		public bool ShaderLimitb = true;

		// Token: 0x04000101 RID: 257
		public bool ClothVertLimitb = true;

		// Token: 0x04000102 RID: 258
		public bool LSorceLimitb = true;

		// Token: 0x04000103 RID: 259
		public bool ColliderLimitb = true;

		// Token: 0x04000104 RID: 260
		public bool SpringJLimitb = true;

		// Token: 0x04000105 RID: 261
		public bool TransformLimitB = true;

		// Token: 0x04000106 RID: 262
		public bool PartLimitB = true;

		// Token: 0x04000107 RID: 263
		public bool ParticleMVLimitB = true;

		// Token: 0x04000108 RID: 264
		public bool MeshLimitB = true;

		// Token: 0x04000109 RID: 265
		public bool BCLimitB = true;

		// Token: 0x0400010A RID: 266
		public bool RigidBody = true;

		// Token: 0x0400010B RID: 267
		public bool screenspace = true;

		// Token: 0x0400010C RID: 268
		public bool duplacate = true;

		// Token: 0x0400010D RID: 269
		public string UserName = "";

		// Token: 0x0400010E RID: 270
		public string PassWorld = "";

		// Token: 0x0400010F RID: 271
		public string LoadIng_Audio = "";

		// Token: 0x04000110 RID: 272
		public bool LoadIng_Audio_Enabled = false;

		// Token: 0x04000111 RID: 273
		public bool LoadIng_Music_off = true;

		// Token: 0x04000112 RID: 274
		public float RunSpeed = 16f;

		// Token: 0x04000113 RID: 275
		public float WalkSpeed = 8f;

		// Token: 0x04000114 RID: 276
		public float JumpPower = 8f;

		// Token: 0x04000115 RID: 277
		public float FlySpeed = 6f;

		// Token: 0x04000116 RID: 278
		public bool JoinNotif = true;

		// Token: 0x04000117 RID: 279
		public bool JoinOnlyFriend = false;

		// Token: 0x04000118 RID: 280
		public bool FavList = true;

		// Token: 0x04000119 RID: 281
		public bool SearchList = true;

		// Token: 0x0400011A RID: 282
		public bool QuickMediaOrMove = false;

		// Token: 0x0400011B RID: 283
		public bool Nopost = false;

		// Token: 0x0400011C RID: 284
		public bool NoChairs = false;

		// Token: 0x0400011D RID: 285
		public bool NoVideo = false;

		// Token: 0x0400011E RID: 286
		public bool NoPickUp = false;

		// Token: 0x0400011F RID: 287
		public bool HidePickUps = false;

		// Token: 0x04000120 RID: 288
		public bool PickUpAutoHolder = false;

		// Token: 0x04000121 RID: 289
		public bool Inf_jump = false;

		// Token: 0x04000122 RID: 290
		public bool Rock_jump = false;

		// Token: 0x04000123 RID: 291
		public bool QmFreeze = true;

		// Token: 0x04000124 RID: 292
		public bool ComfyMode = true;

		// Token: 0x04000125 RID: 293
		public bool FPSunlock = true;

		// Token: 0x04000126 RID: 294
		public bool leftHandSetting = false;

		// Token: 0x04000127 RID: 295
		public bool rightHandSetting = false;

		// Token: 0x04000128 RID: 296
		public bool min_clip = false;

		// Token: 0x04000129 RID: 297
		public bool far_clip = false;

		// Token: 0x0400012A RID: 298
		public bool keysbinding = true;

		// Token: 0x0400012B RID: 299
		public bool BetterNamePlate = true;

		// Token: 0x0400012C RID: 300
		public bool InfoList = true;

		// Token: 0x0400012D RID: 301
		public bool betterhudtext = true;

		// Token: 0x0400012E RID: 302
		public bool ConsoleCleaner = true;

		// Token: 0x0400012F RID: 303
		public bool Clock = true;

		// Token: 0x04000130 RID: 304
		public bool LNCinfo = true;

		// Token: 0x04000131 RID: 305
		public bool LocalAvatarLog = true;

		// Token: 0x04000132 RID: 306
		public bool Anti_spawn_Audio = false;

		// Token: 0x04000133 RID: 307
		public bool Anti_spawn_Particals = false;

		// Token: 0x04000134 RID: 308
		public bool Self_bypass_Spwan = false;

		// Token: 0x04000135 RID: 309
		public bool Firend_bypass = false;

		// Token: 0x04000136 RID: 310
		public bool Reload_players_on_aply = true;

		// Token: 0x04000137 RID: 311
		public bool Ctozoom = false;

		// Token: 0x04000138 RID: 312
		public bool ESPPlayer = false;

		// Token: 0x04000139 RID: 313
		public bool AskPortals = true;

		// Token: 0x0400013A RID: 314
		public bool autodeletePortals = false;

		// Token: 0x0400013B RID: 315
		public bool ASKonAdminJoin = true;

		// Token: 0x0400013C RID: 316
		public bool LeaveOnAdminjoin = false;

		// Token: 0x0400013D RID: 317
		public bool autoforcelewd = false;

		// Token: 0x0400013E RID: 318
		public bool GB_FeetColliders = true;

		// Token: 0x0400013F RID: 319
		public bool GB_HandColliders = true;

		// Token: 0x04000140 RID: 320
		public bool GB_HipBones = true;

		// Token: 0x04000141 RID: 321
		public bool GB_ChestBones = true;

		// Token: 0x04000142 RID: 322
		public bool GB_HeadBones = true;

		// Token: 0x04000143 RID: 323
		public bool GB_Friends = true;

		// Token: 0x04000144 RID: 324
		public bool GB_Enabled = false;

		// Token: 0x04000145 RID: 325
		public bool GB_Spine = false;

		// Token: 0x04000146 RID: 326
		public bool GB_line = false;

		// Token: 0x04000147 RID: 327
		public bool Restartkey = false;

		// Token: 0x04000148 RID: 328
		public bool E9AntiNonfriends = false;

		// Token: 0x04000149 RID: 329
		public bool E9Antifriends = false;

		// Token: 0x0400014A RID: 330
		public bool Event8blockNonfriends = false;

		// Token: 0x0400014B RID: 331
		public bool Event8blockfriend = false;

		// Token: 0x0400014C RID: 332
		public bool Event9blockNonfriends = false;

		// Token: 0x0400014D RID: 333
		public bool Event9blockfriend = false;

		// Token: 0x0400014E RID: 334
		public bool Event6blockNonfriends = false;

		// Token: 0x0400014F RID: 335
		public bool Event6blockfriend = false;

		// Token: 0x04000150 RID: 336
		public bool Event4blockNonfriends = false;

		// Token: 0x04000151 RID: 337
		public bool Event4blockfriend = false;

		// Token: 0x04000152 RID: 338
		public bool Event33blockNonfriends = false;

		// Token: 0x04000153 RID: 339
		public bool Event33blockfriend = false;

		// Token: 0x04000154 RID: 340
		public bool Event210blockNonfriends = false;

		// Token: 0x04000155 RID: 341
		public bool Event210blockfriend = false;

		// Token: 0x04000156 RID: 342
		public bool Event209blockNonfriends = false;

		// Token: 0x04000157 RID: 343
		public bool Event209blockfriend = false;

		// Token: 0x04000158 RID: 344
		public bool Woldtrig = false;

		// Token: 0x04000159 RID: 345
		public bool FakeFPS = false;

		// Token: 0x0400015A RID: 346
		public float setFakeFPSto = 100f;

		// Token: 0x0400015B RID: 347
		public bool FakePing = false;

		// Token: 0x0400015C RID: 348
		public int setFakePingto = 10;

		// Token: 0x0400015D RID: 349
		public bool AntiTP = false;

		// Token: 0x0400015E RID: 350
		public List<string> StatusV2 = new List<string>();

		// Token: 0x0400015F RID: 351
		public bool statusRandom = false;

		// Token: 0x04000160 RID: 352
		public bool statusNext = false;

		// Token: 0x04000161 RID: 353
		public static Config Instance;
	}
}
