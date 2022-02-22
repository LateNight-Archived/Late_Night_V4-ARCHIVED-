using System;
using System.IO;
using System.Reflection;
using UnhollowerRuntimeLib;
using UnityEngine;

namespace IL2CPPAssetBundleAPI
{
	// Token: 0x02000033 RID: 51
	public class IL2CPPAssetBundle
	{
		// Token: 0x060001D1 RID: 465 RVA: 0x00013894 File Offset: 0x00011A94
		internal bool LoadBundle(string resource)
		{
			bool hasLoadedABundle = this.HasLoadedABundle;
			bool result;
			if (hasLoadedABundle)
			{
				result = true;
			}
			else
			{
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource);
				try
				{
					bool flag = string.IsNullOrEmpty(resource);
					if (flag)
					{
						result = false;
					}
					else
					{
						bool flag2 = manifestResourceStream == null;
						if (flag2)
						{
							result = false;
						}
						else
						{
							MemoryStream memoryStream = new MemoryStream((int)manifestResourceStream.Length);
							manifestResourceStream.CopyTo(memoryStream);
							bool flag3 = memoryStream == null;
							if (flag3)
							{
								result = false;
							}
							else
							{
								AssetBundle assetBundle = AssetBundle.LoadFromMemory_Internal(memoryStream.ToArray(), 0U);
								bool flag4 = assetBundle == null;
								if (flag4)
								{
									result = false;
								}
								else
								{
									assetBundle.hideFlags |= 32;
									this.bundle = assetBundle;
									this.HasLoadedABundle = true;
									result = true;
								}
							}
						}
					}
				}
				catch
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00013968 File Offset: 0x00011B68
		internal T Load<T>(string str) where T : Object
		{
			bool flag = !this.HasLoadedABundle;
			T result;
			if (flag)
			{
				result = default(T);
			}
			else
			{
				T t = this.bundle.LoadAsset(str, Il2CppType.Of<T>()).Cast<T>();
				ref T ptr = ref t;
				ptr.hideFlags |= 32;
				result = t;
			}
			return result;
		}

		// Token: 0x040000E3 RID: 227
		internal AssetBundle bundle = null;

		// Token: 0x040000E4 RID: 228
		internal bool HasLoadedABundle = false;
	}
}
