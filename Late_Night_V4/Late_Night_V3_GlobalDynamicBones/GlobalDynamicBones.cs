using System;
using System.Collections.Generic;
using System.Linq;
using DayClientML2.Utility.Extensions;
using Il2CppSystem.Collections.Generic;
using Late_Night_config;
using Late_Night_V3_colnsole;
using UnityEngine;
using VRC;
using VRC.Core;

namespace Late_Night_V3_GlobalDynamicBones
{
	// Token: 0x0200002A RID: 42
	public class GlobalDynamicBones
	{
		// Token: 0x06000197 RID: 407 RVA: 0x00011DD0 File Offset: 0x0000FFD0
		public static void clearlistDyn()
		{
			GlobalDynamicBones.currentWorldDynamicBoneColliders.Clear();
			GlobalDynamicBones.currentWorldDynamicBones.Clear();
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00011DEC File Offset: 0x0000FFEC
		public static void ProcessDynamicBones(GameObject avatarObject, APIUser user)
		{
			bool flag = (Config.Instance.GB_Friends && !user.GetIsFriend() && user.id != APIUser.CurrentUser.id) || !Config.Instance.GB_Enabled;
			if (!flag)
			{
				bool gb_HeadBones = Config.Instance.GB_HeadBones;
				if (gb_HeadBones)
				{
					foreach (DynamicBone item in avatarObject.GetComponentInChildren<Animator>().GetBoneTransform(10).GetComponentsInChildren<DynamicBone>())
					{
						GlobalDynamicBones.currentWorldDynamicBones.Add(item);
					}
				}
				bool gb_ChestBones = Config.Instance.GB_ChestBones;
				if (gb_ChestBones)
				{
					foreach (DynamicBone item2 in avatarObject.GetComponentInChildren<Animator>().GetBoneTransform(8).GetComponentsInChildren<DynamicBone>())
					{
						GlobalDynamicBones.currentWorldDynamicBones.Add(item2);
					}
				}
				bool gb_HipBones = Config.Instance.GB_HipBones;
				if (gb_HipBones)
				{
					foreach (DynamicBone item3 in avatarObject.GetComponentInChildren<Animator>().GetBoneTransform(0).GetComponentsInChildren<DynamicBone>())
					{
						GlobalDynamicBones.currentWorldDynamicBones.Add(item3);
					}
				}
				bool gb_HandColliders = Config.Instance.GB_HandColliders;
				if (gb_HandColliders)
				{
					foreach (DynamicBoneCollider dynamicBoneCollider in avatarObject.GetComponentInChildren<Animator>().GetBoneTransform(17).GetComponentsInChildren<DynamicBoneCollider>())
					{
						bool flag2 = dynamicBoneCollider.m_Bound != 1;
						if (flag2)
						{
							GlobalDynamicBones.currentWorldDynamicBoneColliders.Add(dynamicBoneCollider);
						}
					}
					foreach (DynamicBoneCollider dynamicBoneCollider2 in avatarObject.GetComponentInChildren<Animator>().GetBoneTransform(18).GetComponentsInChildren<DynamicBoneCollider>())
					{
						bool flag3 = dynamicBoneCollider2.m_Bound != 1;
						if (flag3)
						{
							GlobalDynamicBones.currentWorldDynamicBoneColliders.Add(dynamicBoneCollider2);
						}
					}
				}
				bool gb_FeetColliders = Config.Instance.GB_FeetColliders;
				if (gb_FeetColliders)
				{
					foreach (DynamicBoneCollider dynamicBoneCollider3 in avatarObject.GetComponentInChildren<Animator>().GetBoneTransform(5).GetComponentsInChildren<DynamicBoneCollider>())
					{
						bool flag4 = dynamicBoneCollider3.m_Bound != 1;
						if (flag4)
						{
							GlobalDynamicBones.currentWorldDynamicBoneColliders.Add(dynamicBoneCollider3);
						}
					}
					foreach (DynamicBoneCollider dynamicBoneCollider4 in avatarObject.GetComponentInChildren<Animator>().GetBoneTransform(6).GetComponentsInChildren<DynamicBoneCollider>())
					{
						bool flag5 = dynamicBoneCollider4.m_Bound != 1;
						if (flag5)
						{
							GlobalDynamicBones.currentWorldDynamicBoneColliders.Add(dynamicBoneCollider4);
						}
					}
				}
				foreach (DynamicBone dynamicBone in GlobalDynamicBones.currentWorldDynamicBones.ToList<DynamicBone>())
				{
					bool flag6 = dynamicBone == null;
					if (flag6)
					{
						GlobalDynamicBones.currentWorldDynamicBones.Remove(dynamicBone);
					}
					else
					{
						foreach (DynamicBoneCollider dynamicBoneCollider5 in GlobalDynamicBones.currentWorldDynamicBoneColliders.ToList<DynamicBoneCollider>())
						{
							bool flag7 = dynamicBoneCollider5 == null;
							if (flag7)
							{
								GlobalDynamicBones.currentWorldDynamicBoneColliders.Remove(dynamicBoneCollider5);
							}
							bool flag8 = dynamicBone.m_Colliders.IndexOf(dynamicBoneCollider5) == -1;
							if (flag8)
							{
								dynamicBone.m_Colliders.Add(dynamicBoneCollider5);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0001224C File Offset: 0x0001044C
		public static void RemoveDynamicBones(GameObject avatarObject, APIUser user)
		{
			bool flag = (Config.Instance.GB_Friends && !user.GetIsFriend() && user.id != APIUser.CurrentUser.id) || !Config.Instance.GB_Enabled;
			if (!flag)
			{
				List<DynamicBone> list = new List<DynamicBone>();
				List<DynamicBoneCollider> list2 = new List<DynamicBoneCollider>();
				foreach (DynamicBone dynamicBone in avatarObject.GetComponentInChildren<Animator>().GetComponentsInChildren<DynamicBone>())
				{
					list.Add(dynamicBone);
				}
				foreach (DynamicBoneCollider dynamicBoneCollider in avatarObject.GetComponentInChildren<Animator>().GetComponentsInChildren<DynamicBoneCollider>())
				{
					bool flag2 = dynamicBoneCollider.m_Bound != 1;
					if (flag2)
					{
						list2.Add(dynamicBoneCollider);
					}
				}
				foreach (DynamicBone dynamicBone2 in list)
				{
					bool flag3 = dynamicBone2 == null;
					if (!flag3)
					{
						GlobalDynamicBones.currentWorldDynamicBones.Remove(dynamicBone2);
						dynamicBone2.m_Colliders = list2;
					}
				}
				foreach (DynamicBoneCollider dynamicBoneCollider2 in list2)
				{
					bool flag4 = dynamicBoneCollider2 != null;
					if (flag4)
					{
						GlobalDynamicBones.currentWorldDynamicBoneColliders.Remove(dynamicBoneCollider2);
					}
				}
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000123DC File Offset: 0x000105DC
		public static void AddFakeColliders(Player selectedPlayer)
		{
			Animator componentInChildren = selectedPlayer.GetComponentInChildren<Animator>();
			Transform boneTransform = componentInChildren.GetBoneTransform(17);
			Transform boneTransform2 = componentInChildren.GetBoneTransform(18);
			bool flag = boneTransform == null || boneTransform2 == null;
			if (!flag)
			{
				bool flag2 = boneTransform.GetComponent<DynamicBoneCollider>() != null || boneTransform2.GetComponent<DynamicBoneCollider>() != null;
				if (!flag2)
				{
					Transform boneTransform3 = componentInChildren.GetBoneTransform(32);
					Transform boneTransform4 = componentInChildren.GetBoneTransform(47);
					Transform boneTransform5 = componentInChildren.GetBoneTransform(24);
					Transform boneTransform6 = componentInChildren.GetBoneTransform(48);
					float height = 0.007f;
					float height2 = 0.007f;
					float num = 0.0009f;
					float num2 = (float)Math.Pow(10.0, 2.0);
					bool flag3 = boneTransform5 != null && boneTransform6 != null;
					if (flag3)
					{
						num = Mathf.Floor(Vector3.Distance(boneTransform5.position, boneTransform6.position) * num2) / num2 / 1000f;
						num += num / 4f;
					}
					bool flag4 = boneTransform3 != null;
					if (flag4)
					{
						height = Mathf.Floor(Vector3.Distance(boneTransform.position, boneTransform3.position) * num2) / num2 / 100f + num * 4f;
					}
					bool flag5 = boneTransform4 != null;
					if (flag5)
					{
						height2 = Mathf.Floor(Vector3.Distance(boneTransform2.position, boneTransform4.position) * num2) / num2 / 100f + num * 4f;
					}
					LNCcolnsole.Log(string.Concat(new string[]
					{
						"[DynamicBones] Collider stats: ",
						height.ToString(),
						", ",
						height2.ToString(),
						", ",
						num.ToString()
					}), false, ConsoleColor.White);
					DynamicBoneCollider dynamicBoneCollider = boneTransform.gameObject.AddComponent<DynamicBoneCollider>();
					DynamicBoneCollider dynamicBoneCollider2 = boneTransform2.gameObject.AddComponent<DynamicBoneCollider>();
					dynamicBoneCollider.m_Radius = num * 12f;
					dynamicBoneCollider.m_Height = height;
					dynamicBoneCollider.m_Center = new Vector3(0f, 0f, 0f);
					dynamicBoneCollider.m_Bound = 0;
					dynamicBoneCollider2.m_Radius = num * 12f;
					dynamicBoneCollider2.m_Height = height2;
					dynamicBoneCollider2.m_Center = new Vector3(0f, 0f, 0f);
					dynamicBoneCollider2.m_Bound = 0;
					LNCcolnsole.Log("[DynamicBones] Added fake colliders to " + selectedPlayer.GetAPIUser().displayName, false, ConsoleColor.White);
				}
			}
		}

		// Token: 0x040000D2 RID: 210
		public static List<DynamicBone> currentWorldDynamicBones = new List<DynamicBone>();

		// Token: 0x040000D3 RID: 211
		public static List<DynamicBoneCollider> currentWorldDynamicBoneColliders = new List<DynamicBoneCollider>();
	}
}
