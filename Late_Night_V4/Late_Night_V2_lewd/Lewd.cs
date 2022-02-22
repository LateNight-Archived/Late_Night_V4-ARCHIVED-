using System;
using System.Collections.Generic;
using System.Linq;
using Late_Night_V2_popshit;
using Late_Night_V3_colnsole;
using UnityEngine;

namespace Late_Night_V2_lewd
{
	// Token: 0x0200001D RID: 29
	internal static class Lewd
	{
		// Token: 0x06000102 RID: 258 RVA: 0x00007D34 File Offset: 0x00005F34
		public static List<Transform> GetAllTransforms(this GameObject g, bool getHidden = true)
		{
			List<Transform> list = new List<Transform>();
			Transform[] array = g.GetComponents<Transform>();
			Transform[] array2 = g.GetComponentsInChildren<Transform>(getHidden);
			int num = array.Length;
			int num2 = array2.Length;
			for (int i = 0; i < num; i++)
			{
				bool flag = !list.Contains(array[i]);
				if (flag)
				{
					list.Add(array[i]);
				}
			}
			for (int j = 0; j < num2; j++)
			{
				bool flag2 = !list.Contains(array2[j]);
				if (flag2)
				{
					list.Add(array2[j]);
				}
			}
			return list;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00007DDC File Offset: 0x00005FDC
		internal static void Lewdify(this GameObject avatar)
		{
			bool flag = avatar == null;
			if (!flag)
			{
				foreach (Transform transform in from T in avatar.GetAllTransforms(true)
				where Lewd.Oldlist.Contains(T.gameObject.name.ToLower())
				where T.GetComponent<MeshRenderer>() || T.GetComponent<SkinnedMeshRenderer>()
				select T)
				{
					Object.DestroyImmediate(transform.gameObject);
				}
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00007E90 File Offset: 0x00006090
		internal static void getnames(this GameObject avatar, bool Toclip)
		{
			Lewd.Names = null;
			bool flag = avatar == null;
			if (!flag)
			{
				foreach (Transform transform in from T in avatar.GetAllTransforms(true)
				where T.GetComponent<MeshRenderer>() || T.GetComponent<SkinnedMeshRenderer>()
				select T)
				{
					Lewd.Names = Lewd.Names + transform.gameObject.name.ToLower() + ",\n";
				}
				LNCcolnsole.Log("Mesh Names : \n" + Lewd.Names, false, ConsoleColor.White);
				if (Toclip)
				{
					popshit.SetClipboard(Lewd.Names ?? "");
				}
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00007F70 File Offset: 0x00006170
		internal static void ByeSound(this GameObject avatar)
		{
			bool flag = avatar == null;
			if (!flag)
			{
				foreach (Transform transform in from T in avatar.GetAllTransforms(true)
				where T.GetComponent<AudioSource>()
				select T)
				{
					Object.Destroy(transform.GetComponent<AudioSource>());
				}
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00007FFC File Offset: 0x000061FC
		internal static void ByePart(this GameObject avatar)
		{
			bool flag = avatar == null;
			if (!flag)
			{
				foreach (Transform transform in from T in avatar.GetAllTransforms(true)
				where T.GetComponent<ParticleSystem>() || T.GetComponent<ParticleSystemRenderer>()
				select T)
				{
					Object.Destroy(transform.GetComponent<ParticleSystemRenderer>());
					Object.Destroy(transform.GetComponent<ParticleSystem>());
				}
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00008094 File Offset: 0x00006294
		internal static void ByeDynBone(this GameObject avatar)
		{
			bool flag = avatar == null;
			if (!flag)
			{
				foreach (Transform transform in from T in avatar.GetAllTransforms(true)
				where T.GetComponent<DynamicBone>() || T.GetComponent<DynamicBoneCollider>() || T.GetComponent<Cloth>()
				select T)
				{
					Object.Destroy(transform.GetComponent<DynamicBone>());
					Object.Destroy(transform.GetComponent<DynamicBoneCollider>());
					Object.Destroy(transform.GetComponent<Cloth>());
				}
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00008138 File Offset: 0x00006338
		internal static void ByeDynBoneJustBones(this GameObject avatar)
		{
			bool flag = avatar == null;
			if (!flag)
			{
				foreach (Transform transform in from T in avatar.GetAllTransforms(true)
				where T.GetComponent<DynamicBone>()
				select T)
				{
					Object.Destroy(transform.GetComponent<DynamicBone>());
				}
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000081C4 File Offset: 0x000063C4
		internal static void ByeDynBoneJustColliders(this GameObject avatar)
		{
			bool flag = avatar == null;
			if (!flag)
			{
				foreach (Transform transform in from T in avatar.GetAllTransforms(true)
				where T.GetComponent<DynamicBoneCollider>()
				select T)
				{
					Object.Destroy(transform.GetComponent<DynamicBoneCollider>());
				}
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00008250 File Offset: 0x00006450
		internal static void byeCloth(this GameObject avatar)
		{
			bool flag = avatar == null;
			if (!flag)
			{
				foreach (Transform transform in from T in avatar.GetAllTransforms(true)
				where T.GetComponent<Cloth>()
				select T)
				{
					Object.Destroy(transform.GetComponent<Cloth>());
				}
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000082DC File Offset: 0x000064DC
		internal static void ListOFMesh(this GameObject avatar)
		{
			Lewd.MeshUwU.Clear();
			bool flag = avatar == null;
			if (!flag)
			{
				foreach (Transform transform in from T in avatar.GetAllTransforms(true)
				where T.GetComponent<MeshRenderer>() || T.GetComponent<SkinnedMeshRenderer>()
				select T)
				{
					Lewd.MeshUwU.Insert(0, transform.gameObject);
				}
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00008378 File Offset: 0x00006578
		internal static string MeshNeme()
		{
			bool flag = Lewd.MeshUwU[Lewd.listIndex].gameObject == null;
			string result;
			if (flag)
			{
				result = "Game obj is Null";
			}
			else
			{
				bool flag2 = Lewd.MeshUwU.Count == 0;
				if (flag2)
				{
					result = "No Meshs";
				}
				else
				{
					result = string.Format("{0}. ", Lewd.listIndex) + Lewd.MeshUwU[Lewd.listIndex].name;
				}
			}
			return result;
		}

		// Token: 0x04000077 RID: 119
		public static List<string> Oldlist = new List<string>
		{
			"cloth",
			"shirt",
			"pant",
			"under",
			"undi",
			"jacket",
			"top",
			"bra",
			"bra ",
			"skirt",
			"jean",
			"trouser",
			"boxers",
			"hoodi",
			"bottom",
			"dress",
			"bandage",
			"bondage",
			"sweat",
			"cardig",
			"corset",
			"tiddy",
			"pastie",
			"suit",
			"stocking",
			"jewel",
			"frill",
			"gauze",
			"cover",
			"pubic",
			"sfw",
			"harn",
			"biki",
			"outfit",
			"panties",
			"short",
			"clothing",
			"shirt top",
			"pasties",
			"inv_swimsuit",
			"pants",
			"shoes",
			"underclothes",
			"shorts",
			"Hoodie",
			"plaster",
			"pussy cover",
			"radialswitch",
			"ribbon",
			"bottom1",
			"shorts nsfw",
			"top nsfw",
			"pastie+harness",
			"bralette harness",
			"bottom2",
			"robe",
			"rope",
			"ropes",
			"ropes",
			"lingerie toggle",
			"sandals",
			"shirt.001",
			"skrt",
			"sleeve",
			"sleeves",
			"snapdress",
			"socks",
			"tank",
			"stickers",
			"denimtop_b",
			"fish nets",
			"chest harness",
			"stockings",
			"straps",
			"strapsbottom",
			"body suit",
			"sweater",
			"swimsuit",
			"tank top",
			"tape",
			"shirt dress",
			"tearsweater",
			"thong",
			"toob",
			"toppants",
			"rf mask top",
			"longshirt",
			"asphalttop",
			"hood",
			"sweatshirt",
			"uppertop",
			"toggle top.001",
			"jacket.002",
			"underwear",
			"undies",
			"tokyohoodie",
			"wraps",
			"wrap",
			"outerwear",
			"wraps-top",
			"Одежка",
			"sticker",
			"dressy",
			"capeyyy",
			"bodysuity",
			"bodysuit",
			"верх",
			"низ",
			"パンティー",
			"ビキニ",
			"ブラジャー",
			"下着",
			"무녀복",
			"브라",
			"비키니",
			"속옷",
			"젖소",
			"gasmask",
			"팬티",
			"skirt.001",
			"huku_top",
			"other_glasses",
			"other_mask",
			"huku_pants",
			"huku_skirt",
			"huku_jacket",
			"clothes",
			"top_mesh",
			"kemono",
			"garterbelt",
			"langerie",
			"tap",
			"calça",
			"camisa",
			"beziercircle.001",
			"dress.001",
			"floof corset",
			"paisties",
			"string and gatter",
			"crop top",
			"panty",
			"sleeveless",
			"harness",
			"pantie",
			"bandaid",
			"mask",
			"chainsleeve",
			"hat",
			"hoodoff",
			"hoodon",
			"metal muzzle",
			"top2",
			"rush",
			"huku_bra",
			"huku_lace shirt",
			"huku_panties",
			"huku_shoes",
			"huku_shorts",
			"o_harness",
			"o_mask",
			"bottoms",
			"daddys slut",
			"bra.strapless",
			"butterfly dress",
			"chainnecklace",
			"denim shorts",
			"panties_berryvee",
			"tanktop",
			"waist jacket",
			"chocker_jhp",
			"brazbikini_bottoms",
			"brazbikini_top",
			"full harness",
			"glasses",
			"panty_misepan",
			"top1",
			"top3",
			"top4",
			"top5_bottom",
			"top5_top",
			"top6",
			"eraser",
			"bikini",
			"headset",
			"screen",
			"就是一个胡萝卜",
			"chain",
			"hesopi",
			"merino_scarf",
			"merino_bag",
			"bikini bottoms",
			"merino_panties",
			"tsg_buruma",
			"merino_cap",
			"kyoueimizugi",
			"kyoueimizugi_oppaiooki",
			"leotard",
			"hotpants",
			"hotpants_side_open",
			"merino_culottes",
			"merino_leggins",
			"merino_socks",
			"bikini",
			"merino_bra",
			"merino_jacket",
			"merino_inner",
			"tsg_shirt",
			"beer hat",
			"cuffs",
			"lace",
			"panties",
			"pasties",
			"shorts and shoes",
			"undergarments",
			"irukanicar",
			"ベルト",
			"wear",
			"tshirt",
			"waistbag",
			"nekomimicasquette",
			"dango",
			"penetrator",
			"comfy bottom",
			"comfy top",
			"hoodie",
			"strawberry panty",
			"strawberry top",
			"vest",
			"sleevedtop",
			"baggy top by cupkake",
			"harness by heyblake",
			"heart pasties by cupkake",
			"straps!",
			"crop strap hoodie flat",
			"harness & panties",
			"bunnycostume",
			"handwarmers",
			"belt",
			"cardigan",
			"turtle neck",
			"bandages",
			"holysuit",
			"nipplecovers",
			"panti",
			"Panti 2",
			"nipple covers",
			"maid outfit",
			"P&U",
			"nsfw",
			"heart pasties",
			"body lingerie",
			"sluttytop",
			"sports bra",
			"bear",
			"fishnets",
			"shirtone",
			"shirttwo",
			"bodymesh",
			"bikinitop"
		};

		// Token: 0x04000078 RID: 120
		public static string Names;

		// Token: 0x04000079 RID: 121
		internal static List<GameObject> MeshUwU = new List<GameObject>();

		// Token: 0x0400007A RID: 122
		internal static int listIndex = 0;
	}
}
