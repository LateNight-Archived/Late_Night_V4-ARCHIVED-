using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Il2CppSystem;
using MelonLoader;
using UnhollowerRuntimeLib.XrefScans;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR;
using VRC.SDKBase;

namespace DayClientML2.Utility.Extensions
{
	// Token: 0x0200005C RID: 92
	public static class MiskExtension
	{
		// Token: 0x06000366 RID: 870 RVA: 0x0001A204 File Offset: 0x00018404
		public static GameObject GetUniqueGameObject(string name)
		{
			GameObject[] array = SceneManager.GetActiveScene().GetRootGameObjects().ToArray<GameObject>();
			for (int i = 0; i < array.Length; i++)
			{
				bool flag = Networking.GetUniqueName(array[i]) == name;
				if (flag)
				{
					return array[i];
				}
			}
			return null;
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0001A25C File Offset: 0x0001845C
		public static void SetToolTipBasedOnToggle(this UiTooltip tooltip)
		{
			UiToggleButton componentInChildren = tooltip.gameObject.GetComponentInChildren<UiToggleButton>();
			bool flag = componentInChildren != null && !string.IsNullOrEmpty(tooltip.GetAlternateText());
			if (flag)
			{
				string text = (!componentInChildren.field_Public_Boolean_0) ? tooltip.GetAlternateText() : tooltip.GetText();
				bool flag2 = TooltipManager.field_Private_Static_Text_0 != null;
				if (flag2)
				{
					TooltipManager.Method_Public_Static_Void_String_0(text);
				}
				bool flag3 = tooltip.GetToolTip() != null;
				if (flag3)
				{
					tooltip.GetToolTip().text = text;
				}
			}
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0001A2E4 File Offset: 0x000184E4
		internal static Text GetToolTip(this UiTooltip Instance)
		{
			return Instance.field_Public_Text_0;
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0001A2FC File Offset: 0x000184FC
		internal static string GetText(this UiTooltip Instance)
		{
			return Instance.field_Public_String_0;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0001A314 File Offset: 0x00018514
		internal static string GetAlternateText(this UiTooltip Instance)
		{
			return Instance.field_Public_String_1;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0001A32C File Offset: 0x0001852C
		internal static bool GetToggledOn(this UiTooltip Instance)
		{
			return Instance.field_Private_Boolean_0;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0001A344 File Offset: 0x00018544
		public static void EnterPortal(this PortalInternal Instance, string WorldID, string InstanceID)
		{
			Instance.Method_Private_Void_String_String_PDM_0(WorldID, InstanceID);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0001A350 File Offset: 0x00018550
		public static bool IsInVR()
		{
			return XRDevice.isPresent;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0001A368 File Offset: 0x00018568
		[Obsolete("This Doenst always works -Day <3")]
		public static bool IsCurrentWorldUdon()
		{
			return RoomManager.field_Internal_Static_ApiWorld_0.tags.Contains("Udon");
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0001A38E File Offset: 0x0001858E
		public static void Start(this IEnumerator e)
		{
			MelonCoroutines.Start(e);
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0001A398 File Offset: 0x00018598
		public static bool XRefScanForGlobal(this MethodBase methodBase, string searchTerm, bool ignoreCase = true)
		{
			bool flag = !string.IsNullOrEmpty(searchTerm);
			bool result;
			if (flag)
			{
				result = XrefScanner.XrefScan(methodBase).Any(delegate(XrefInstance xref)
				{
					bool result2;
					if (xref.Type == null)
					{
						Object @object = xref.ReadAsObject();
						result2 = (@object != null && @object.ToString().IndexOf(searchTerm, ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal) >= 0);
					}
					else
					{
						result2 = false;
					}
					return result2;
				});
			}
			else
			{
				MelonLogger.Error(string.Format("XRefScanForGlobal \"{0}\" has an empty searchTerm. Returning false", methodBase));
				result = false;
			}
			return result;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0001A3FC File Offset: 0x000185FC
		public static bool XRefScanForMethod(this MethodBase methodBase, string methodName = null, string parentType = null, bool ignoreCase = true)
		{
			bool flag = !string.IsNullOrEmpty(methodName) || !string.IsNullOrEmpty(parentType);
			bool result;
			if (flag)
			{
				result = XrefScanner.XrefScan(methodBase).Any(delegate(XrefInstance xref)
				{
					bool flag2 = xref.Type != 1;
					bool result2;
					if (flag2)
					{
						result2 = false;
					}
					else
					{
						bool flag3 = false;
						MethodBase methodBase2 = xref.TryResolve();
						bool flag4 = methodBase2 == null;
						if (flag4)
						{
							result2 = false;
						}
						else
						{
							bool flag5 = !string.IsNullOrEmpty(methodName);
							if (flag5)
							{
								flag3 = (!string.IsNullOrEmpty(methodBase2.Name) && methodBase2.Name.IndexOf(methodName, ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal) >= 0);
							}
							bool flag6 = !string.IsNullOrEmpty(parentType);
							if (flag6)
							{
								Type reflectedType = methodBase2.ReflectedType;
								flag3 = (!string.IsNullOrEmpty((reflectedType != null) ? reflectedType.Name : null) && methodBase2.ReflectedType.Name.IndexOf(parentType, ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal) >= 0);
							}
							result2 = flag3;
						}
					}
					return result2;
				});
			}
			else
			{
				MelonLogger.Error(string.Format("XRefScanForMethod \"{0}\" has all null/empty parameters. Returning false", methodBase));
				result = false;
			}
			return result;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0001A478 File Offset: 0x00018678
		internal static bool XRefScanForMethod2(this MethodBase methodBase, string methodName = null, string reflectedType = null)
		{
			bool flag = false;
			foreach (XrefInstance xrefInstance in XrefScanner.XrefScan(methodBase))
			{
				bool flag2 = xrefInstance.Type != 1;
				if (!flag2)
				{
					MethodBase methodBase2 = xrefInstance.TryResolve();
					bool flag3 = methodBase2 == null;
					if (!flag3)
					{
						bool flag4 = !string.IsNullOrEmpty(methodName);
						if (flag4)
						{
							flag = (!string.IsNullOrEmpty(methodBase2.Name) && methodBase2.Name.IndexOf(methodName, StringComparison.OrdinalIgnoreCase) >= 0);
						}
						bool flag5 = !string.IsNullOrEmpty(reflectedType);
						if (flag5)
						{
							Type reflectedType2 = methodBase2.ReflectedType;
							flag = (!string.IsNullOrEmpty((reflectedType2 != null) ? reflectedType2.Name : null) && methodBase2.ReflectedType.Name.IndexOf(reflectedType, StringComparison.OrdinalIgnoreCase) >= 0);
						}
						bool flag6 = flag;
						if (flag6)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0001A588 File Offset: 0x00018788
		public static int XRefScanMethodCount(this MethodBase methodBase, string methodName = null, string parentType = null, bool ignoreCase = true)
		{
			bool flag = !string.IsNullOrEmpty(methodName) || !string.IsNullOrEmpty(parentType);
			int result;
			if (flag)
			{
				result = XrefScanner.XrefScan(methodBase).Count(delegate(XrefInstance xref)
				{
					bool flag2 = xref.Type != 1;
					bool result2;
					if (flag2)
					{
						result2 = false;
					}
					else
					{
						bool flag3 = false;
						MethodBase methodBase2 = xref.TryResolve();
						bool flag4 = methodBase2 == null;
						if (flag4)
						{
							result2 = false;
						}
						else
						{
							bool flag5 = !string.IsNullOrEmpty(methodName);
							if (flag5)
							{
								flag3 = (!string.IsNullOrEmpty(methodBase2.Name) && methodBase2.Name.IndexOf(methodName, ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal) >= 0);
							}
							bool flag6 = !string.IsNullOrEmpty(parentType);
							if (flag6)
							{
								Type reflectedType = methodBase2.ReflectedType;
								flag3 = (!string.IsNullOrEmpty((reflectedType != null) ? reflectedType.Name : null) && methodBase2.ReflectedType.Name.IndexOf(parentType, ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal) >= 0);
							}
							result2 = flag3;
						}
					}
					return result2;
				});
			}
			else
			{
				MelonLogger.Error(string.Format("XRefScanMethodCount \"{0}\" has all null/empty parameters. Returning -1", methodBase));
				result = -1;
			}
			return result;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0001A604 File Offset: 0x00018804
		public static bool checkXref(this MethodBase m, string match)
		{
			try
			{
				return XrefScanner.XrefScan(m).Any((XrefInstance instance) => instance.Type == null && instance.ReadAsObject() != null && instance.ReadAsObject().ToString().Equals(match, StringComparison.OrdinalIgnoreCase));
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0001A654 File Offset: 0x00018854
		public static List<List<T>> SplitIntoChunks<T>(List<T> list, int chunkSize)
		{
			bool flag = chunkSize <= 0;
			if (flag)
			{
				throw new ArgumentException("chunkSize must be greater than 0.");
			}
			List<List<T>> list2 = new List<List<T>>();
			for (int i = 0; i < list.Count; i += chunkSize)
			{
				int count = (list.Count - i > chunkSize) ? chunkSize : (list.Count - i);
				list2.Add(list.GetRange(i, count));
			}
			return list2;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0001A6C8 File Offset: 0x000188C8
		public static T Cast<T>(this object o)
		{
			return (T)((object)o);
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0001A6E0 File Offset: 0x000188E0
		public static List<List<T>> SplitList<T>(this List<T> Instance, int Count)
		{
			List<List<T>> list = new List<List<T>>();
			int num = Instance.Count / Count;
			for (int i = 0; i < num; i++)
			{
				list[Count * i].AddRange(Instance.GetRange(i * Count, Count));
			}
			Console.WriteLine(string.Format("List Count: {0} | Count: {1} | Splits: {2}", Instance.Count, Count, Count));
			return list;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0001A754 File Offset: 0x00018954
		internal static bool IsRunningNotorious()
		{
			return Assembly.GetExecutingAssembly().GetType("Notorious") != null;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0001A780 File Offset: 0x00018980
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
				bool flag2 = array == null || array.Length == 0;
				if (flag2)
				{
					result = null;
				}
				else
				{
					Texture2D texture2D = new Texture2D(2, 2);
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

		// Token: 0x0600037A RID: 890 RVA: 0x0001A840 File Offset: 0x00018A40
		public static bool IsVisible(this GameObject go)
		{
			Renderer[] source = go.GetComponentsInChildren<Renderer>();
			return source.Any((Renderer r) => r != null && r.enabled && r.isVisible);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0001A884 File Offset: 0x00018A84
		public static bool IsVisibleLocally(this GameObject go)
		{
			return !(Utils.VRCVrCamera == null) && go.IsVisibleTo(Utils.VRCVrCamera.field_Public_Camera_0);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0001A8B8 File Offset: 0x00018AB8
		public static bool IsVisibleTo(this GameObject go, Camera camera)
		{
			bool flag = camera == null;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				Renderer[] source = go.GetComponentsInChildren<Renderer>();
				foreach (Renderer renderer in from r in source
				where r != null && r.enabled
				select r)
				{
					Plane[] array = GeometryUtility.CalculateFrustumPlanes(camera);
					bool flag2 = GeometryUtility.TestPlanesAABB(array, renderer.bounds);
					if (flag2)
					{
						return true;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0001A974 File Offset: 0x00018B74
		public static bool IsPickup(this GameObject go)
		{
			return go != null && go.GetComponentInParent<VRC_Pickup>() != null;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0001A9A0 File Offset: 0x00018BA0
		public static bool IsHeld(this GameObject go)
		{
			bool flag = go == null;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				VRC_Pickup componentInParent = go.GetComponentInParent<VRC_Pickup>();
				result = (componentInParent != null && componentInParent.IsHeld);
			}
			return result;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0001A9DC File Offset: 0x00018BDC
		public static bool IsPlayer(this GameObject go)
		{
			return go != null && go.GetComponentInParent<VRCPlayer>() != null;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0001AA08 File Offset: 0x00018C08
		public static bool IsMine(this GameObject go)
		{
			return Networking.IsOwner(go);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0001AA20 File Offset: 0x00018C20
		public static bool IsReady(this GameObject go)
		{
			return Networking.IsObjectReady(go);
		}
	}
}
