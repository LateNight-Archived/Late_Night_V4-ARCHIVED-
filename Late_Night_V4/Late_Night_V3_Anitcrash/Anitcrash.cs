using System;
using System.Linq;
using DayClientML2.Utility.Extensions;
using Late_Night_config;
using Late_Night_V2_lewd;
using Late_Night_V2_wrappers;
using UnityEngine;

namespace Late_Night_V3_Anitcrash
{
	// Token: 0x02000070 RID: 112
	public static class Anitcrash
	{
		// Token: 0x06000485 RID: 1157 RVA: 0x0001EE70 File Offset: 0x0001D070
		public static void anti_spwan_mian(this GameObject Avi, VRCPlayer p)
		{
			bool flag = p.UserID() == PlayerWrapper.GetCurrentPlayer().UserID();
			if (flag)
			{
				bool self_bypass_Spwan = Config.Instance.Self_bypass_Spwan;
				if (!self_bypass_Spwan)
				{
					bool anti_spawn_Audio = Config.Instance.Anti_spawn_Audio;
					if (anti_spawn_Audio)
					{
						Avi.ByeSound();
					}
					bool anti_spawn_Particals = Config.Instance.Anti_spawn_Particals;
					if (anti_spawn_Particals)
					{
						Avi.ByePart();
					}
				}
			}
			else
			{
				bool flag2 = p.GetAPIUser().GetIsFriend() && !Config.Instance.Firend_bypass;
				if (flag2)
				{
					bool anti_spawn_Audio2 = Config.Instance.Anti_spawn_Audio;
					if (anti_spawn_Audio2)
					{
						Avi.ByeSound();
					}
					bool anti_spawn_Particals2 = Config.Instance.Anti_spawn_Particals;
					if (anti_spawn_Particals2)
					{
						Avi.ByePart();
					}
				}
				else
				{
					bool anti_spawn_Audio3 = Config.Instance.Anti_spawn_Audio;
					if (anti_spawn_Audio3)
					{
						Avi.ByeSound();
					}
					bool anti_spawn_Particals3 = Config.Instance.Anti_spawn_Particals;
					if (anti_spawn_Particals3)
					{
						Avi.ByePart();
					}
				}
			}
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0001EF70 File Offset: 0x0001D170
		internal static void ByeSound(this GameObject avatar)
		{
			bool flag = avatar == null;
			if (flag)
			{
			}
			foreach (Transform transform in from G in avatar.GetAllTransforms(true)
			where G.GetComponent<AudioSource>() != null
			select G)
			{
				Object.DestroyImmediate(transform.GetComponent<AudioSource>());
			}
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x0001EFFC File Offset: 0x0001D1FC
		internal static void ByePart(this GameObject avatar)
		{
			bool flag = avatar == null;
			if (flag)
			{
			}
			foreach (Transform transform in from G in avatar.GetAllTransforms(true)
			where G.GetComponent<ParticleSystem>() != null || G.GetComponent<ParticleSystemRenderer>()
			select G)
			{
				Object.DestroyImmediate(transform.GetComponent<ParticleSystem>());
				Object.DestroyImmediate(transform.GetComponent<ParticleSystemRenderer>());
			}
		}
	}
}
