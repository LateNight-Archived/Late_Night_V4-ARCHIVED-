using System;
using System.IO;
using System.Net;
using UnityEngine;
using UnityEngine.UI;

namespace Late_Night_V2_LoadSprite
{
	// Token: 0x0200002F RID: 47
	internal static class LoadSprite
	{
		// Token: 0x060001B7 RID: 439 RVA: 0x00013458 File Offset: 0x00011658
		internal static Sprite LoadSpriteFromDisk(this string path)
		{
			bool flag = string.IsNullOrEmpty(path);
			Sprite result;
			if (flag)
			{
				result = null;
			}
			else
			{
				byte[] array = File.ReadAllBytes(path);
				bool flag2 = array.Length == 0;
				if (flag2)
				{
					result = null;
				}
				else
				{
					Texture2D texture2D = new Texture2D(512, 512);
					bool flag3 = !Il2CppImageConversionManager.LoadImage(texture2D, array);
					if (flag3)
					{
						result = null;
					}
					else
					{
						Sprite sprite = Sprite.CreateSprite(texture2D, new Rect(0f, 0f, (float)texture2D.width, (float)texture2D.height), new Vector2(0.5f, 0.5f), 100f, 0U, 0, default(Vector4), false);
						sprite.hideFlags |= 32;
						result = sprite;
					}
				}
			}
			return result;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0001351C File Offset: 0x0001171C
		public static Image LoadSpriteFromUrl(this Image Instance, string url)
		{
			bool flag = string.IsNullOrEmpty(url);
			Image result;
			if (flag)
			{
				result = null;
			}
			else
			{
				byte[] array = new WebClient().DownloadData(url);
				bool flag2 = array == null || array.Length == 0;
				bool flag3 = flag2;
				if (flag3)
				{
					result = null;
				}
				else
				{
					Texture2D texture2D = new Texture2D(512, 512);
					bool flag4 = !Il2CppImageConversionManager.LoadImage(texture2D, array);
					bool flag5 = flag4;
					if (flag5)
					{
						result = null;
					}
					else
					{
						Sprite sprite = Sprite.CreateSprite(texture2D, new Rect(0f, 0f, (float)texture2D.width, (float)texture2D.height), new Vector2(0.5f, 0.5f), 100f, 0U, 0, default(Vector4), false);
						sprite.hideFlags |= 32;
						Instance.sprite = sprite;
						Instance.color = Color.white;
						result = Instance;
					}
				}
			}
			return result;
		}
	}
}
