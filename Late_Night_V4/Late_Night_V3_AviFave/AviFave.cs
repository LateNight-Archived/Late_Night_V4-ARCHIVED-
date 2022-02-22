using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DayClientML2.Utility.MenuApi;
using Il2CppSystem.Collections.Generic;
using Late_Night_V3_AvatarObject;
using Late_Night_V3_colnsole;
using Late_Night_V3_Config_AVI_FAVE;
using Late_Night_V3_Config_Seen_AVIS;
using MelonLoader;
using Newtonsoft.Json;
using UnityEngine;
using VRC.Core;

namespace Late_Night_V3_AviFave
{
	// Token: 0x0200006E RID: 110
	internal class AviFave
	{
		// Token: 0x06000474 RID: 1140 RVA: 0x0001E394 File Offset: 0x0001C594
		internal static void startAvis()
		{
			AviFave.Avis = new VRCList(VRCList.PublicAvatarList.transform.parent, "Late Night Favorites", 0);
			List<ApiAvatar> AvatarList = new List<ApiAvatar>();
			Config_AVI_FAVE.Instance.Avis.ForEach(delegate(AvatarObject avi)
			{
				AvatarList.Add(avi.ToApiAvatar());
			});
			AviFave.Avis.RenderElement(AvatarList);
			AviFave.SEENAvis = new VRCList(VRCList.PublicAvatarList.transform.parent, "Late Night Recently Seen", 1);
			List<ApiAvatar> AvatarList2 = new List<ApiAvatar>();
			Config_Seen_AVIS.Instance.SEEN_AVIS.ForEach(delegate(AvatarObject avi2)
			{
				AvatarList2.Add(avi2.ToApiAvatar());
			});
			AviFave.SEENAvis.RenderElement(AvatarList2);
			AviFave.AviSearchlist = new VRCList(VRCList.PublicAvatarList.transform.parent, "Late Night Search", 2);
			List<ApiAvatar> AvatarList3 = new List<ApiAvatar>();
			AviFave.Searchedavis.ForEach(delegate(AvatarObject avi3)
			{
				AvatarList3.Add(avi3.ToApiAvatar());
			});
			AviFave.AviSearchlist.RenderElement(AvatarList3);
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x0001E4A8 File Offset: 0x0001C6A8
		internal static void FaveAvi(ApiAvatar ApiAvi, int list)
		{
			bool flag = false;
			string id = ApiAvi.id;
			if (list != 1)
			{
				if (list == 2)
				{
					IEnumerable<AvatarObject> seen_AVIS = Config_Seen_AVIS.Instance.SEEN_AVIS;
					Func<AvatarObject, bool> <>9__3;
					Func<AvatarObject, bool> predicate;
					if ((predicate = <>9__3) == null)
					{
						predicate = (<>9__3 = ((AvatarObject idS) => idS.id == id));
					}
					foreach (AvatarObject avatarObject in seen_AVIS.Where(predicate))
					{
						flag = true;
					}
				}
			}
			else
			{
				IEnumerable<AvatarObject> avis = Config_AVI_FAVE.Instance.Avis;
				Func<AvatarObject, bool> <>9__2;
				Func<AvatarObject, bool> predicate2;
				if ((predicate2 = <>9__2) == null)
				{
					predicate2 = (<>9__2 = ((AvatarObject idS) => idS.id == id));
				}
				foreach (AvatarObject avatarObject2 in avis.Where(predicate2))
				{
					flag = true;
					LNCcolnsole.Log("This avi is already saved !!!", true, ConsoleColor.Yellow);
				}
			}
			bool flag2 = !flag;
			if (flag2)
			{
				if (list != 1)
				{
					if (list == 2)
					{
						Config_Seen_AVIS.Instance.SEEN_AVIS.Insert(0, new AvatarObject(ApiAvi));
					}
				}
				else
				{
					Config_AVI_FAVE.Instance.Avis.Insert(0, new AvatarObject(ApiAvi));
					LNCcolnsole.Log("Avi Save!!!", true, ConsoleColor.Green);
					LNCcolnsole.Log("Total Avis : " + Config_AVI_FAVE.Instance.Avis.Count.ToString(), true, ConsoleColor.Green);
				}
			}
			List<ApiAvatar> AvatarList = new List<ApiAvatar>();
			Config_AVI_FAVE.Instance.Avis.ForEach(delegate(AvatarObject avi)
			{
				AvatarList.Add(avi.ToApiAvatar());
			});
			AviFave.Avis.RenderElement(AvatarList);
			List<ApiAvatar> AvatarList2 = new List<ApiAvatar>();
			Config_Seen_AVIS.Instance.SEEN_AVIS.ForEach(delegate(AvatarObject avi2)
			{
				AvatarList2.Add(avi2.ToApiAvatar());
			});
			AviFave.SEENAvis.RenderElement(AvatarList2);
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0001E6CC File Offset: 0x0001C8CC
		internal static void UnFaveAvi(ApiAvatar ApiAvi)
		{
			string id = ApiAvi.id;
			AvatarObject avatarObject = null;
			IEnumerable<AvatarObject> avis = Config_AVI_FAVE.Instance.Avis;
			Func<AvatarObject, bool> <>9__2;
			Func<AvatarObject, bool> predicate;
			if ((predicate = <>9__2) == null)
			{
				predicate = (<>9__2 = ((AvatarObject idS) => idS.id == id));
			}
			foreach (AvatarObject avatarObject2 in avis.Where(predicate))
			{
				avatarObject = avatarObject2;
			}
			bool flag = avatarObject != null;
			if (flag)
			{
				Config_AVI_FAVE.Instance.Avis.Remove(avatarObject);
				LNCcolnsole.Log("This avi has been removed !!!", true, ConsoleColor.Yellow);
				LNCcolnsole.Log("Total Avis : " + Config_AVI_FAVE.Instance.Avis.Count.ToString(), true, ConsoleColor.Yellow);
			}
			List<ApiAvatar> AvatarList = new List<ApiAvatar>();
			Config_AVI_FAVE.Instance.Avis.ForEach(delegate(AvatarObject avi)
			{
				AvatarList.Add(avi.ToApiAvatar());
			});
			AviFave.Avis.RenderElement(AvatarList);
			List<ApiAvatar> AvatarList2 = new List<ApiAvatar>();
			Config_Seen_AVIS.Instance.SEEN_AVIS.ForEach(delegate(AvatarObject avi2)
			{
				AvatarList2.Add(avi2.ToApiAvatar());
			});
			AviFave.SEENAvis.RenderElement(AvatarList2);
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x0001E820 File Offset: 0x0001CA20
		internal static void showList()
		{
			List<ApiAvatar> AvatarList = new List<ApiAvatar>();
			Config_AVI_FAVE.Instance.Avis.ForEach(delegate(AvatarObject avi)
			{
				AvatarList.Add(avi.ToApiAvatar());
			});
			AviFave.Avis.RenderElement(AvatarList);
			List<ApiAvatar> AvatarList2 = new List<ApiAvatar>();
			Config_Seen_AVIS.Instance.SEEN_AVIS.ForEach(delegate(AvatarObject avi2)
			{
				AvatarList2.Add(avi2.ToApiAvatar());
			});
			AviFave.SEENAvis.RenderElement(AvatarList2);
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x0001E8A4 File Offset: 0x0001CAA4
		internal static void ClearSEENLIST()
		{
			Config_Seen_AVIS.Instance.SEEN_AVIS.Clear();
			List<ApiAvatar> AvatarList2 = new List<ApiAvatar>();
			Config_Seen_AVIS.Instance.SEEN_AVIS.ForEach(delegate(AvatarObject avi2)
			{
				AvatarList2.Add(avi2.ToApiAvatar());
			});
			AviFave.SEENAvis.RenderElement(AvatarList2);
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0001E900 File Offset: 0x0001CB00
		private static IEnumerator DeShow()
		{
			yield return new WaitForSeconds(2f);
			AviFave.SearchShow();
			yield break;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0001E908 File Offset: 0x0001CB08
		internal static void REEEEEEEEEEE(string text)
		{
			AviFave.SearchClaer();
			AviFave.AviSearchList(text, delegate(List<AvatarObject> list)
			{
				AviFave.Searchedavis = list;
			}, 75);
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0001E93C File Offset: 0x0001CB3C
		internal static void SearchShow()
		{
			List<ApiAvatar> AvatarList3 = new List<ApiAvatar>();
			AviFave.Searchedavis.ForEach(delegate(AvatarObject avi3)
			{
				AvatarList3.Add(avi3.ToApiAvatar());
			});
			AviFave.AviSearchlist.RenderElement(AvatarList3);
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0001E984 File Offset: 0x0001CB84
		internal static void SearchClaer()
		{
			AviFave.Searchedavis.Clear();
			List<ApiAvatar> AvatarList3 = new List<ApiAvatar>();
			AviFave.Searchedavis.ForEach(delegate(AvatarObject avi3)
			{
				AvatarList3.Add(avi3.ToApiAvatar());
			});
			AviFave.AviSearchlist.RenderElement(AvatarList3);
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0001E9D8 File Offset: 0x0001CBD8
		internal static void AviSearchList(string Searchpattern, Action<List<AvatarObject>> OnFinish, int Limit = 40)
		{
			Task.Factory.StartNew(delegate()
			{
				try
				{
					LNCcolnsole.Log("Search start", true, ConsoleColor.Blue);
					string requestUriString = string.Format("https://late-night.skid-hub.com/api/AviSearch?Search={0}&Author={1}&Fetchlimit={2}", Searchpattern, AviFave.ByNameOrAuther, Limit);
					HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
					HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
					using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
					{
						string text = streamReader.ReadToEnd();
						try
						{
							List<AvatarObject> list = JsonConvert.DeserializeObject<List<AvatarObject>>(text);
							List<AvatarObject> list2 = new List<AvatarObject>();
							foreach (AvatarObject avatarObject in list)
							{
								bool flag = !AviFave.PublicOrPrivate;
								bool flag2 = flag;
								if (flag2)
								{
									bool flag3 = avatarObject.releaseStatus.ToLower().Contains("private");
									bool flag4 = flag3;
									if (flag4)
									{
										list2.Add(avatarObject);
									}
								}
								else
								{
									bool flag5 = avatarObject.releaseStatus.ToLower().Contains("public");
									bool flag6 = flag5;
									if (flag6)
									{
										list2.Add(avatarObject);
									}
								}
							}
							foreach (AvatarObject item in list2)
							{
								try
								{
									list.Remove(item);
								}
								catch
								{
								}
							}
							LNCcolnsole.Log("Found " + list.Count.ToString() + " Avis", true, ConsoleColor.Green);
							Action<List<AvatarObject>> onFinish = OnFinish;
							if (onFinish != null)
							{
								onFinish(list);
							}
							LNCcolnsole.Log("Search ready", true, ConsoleColor.Green);
							MelonCoroutines.Start(AviFave.DeShow());
						}
						catch
						{
							LNCcolnsole.ERROR("Avi Search List Failed", true, ConsoleColor.Red);
						}
					}
				}
				catch
				{
				}
			});
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x0001EA18 File Offset: 0x0001CC18
		internal static void UploadOne(ApiAvatar A)
		{
			try
			{
				AviFave.SendtoServer(new serverAvatarObject
				{
					Avis = new List<AvatarObject>
					{
						new AvatarObject(A)
					}
				});
			}
			catch
			{
			}
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0001EA64 File Offset: 0x0001CC64
		internal static void SendtoServer(serverAvatarObject upload)
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://late-night.skid-hub.com/api/AviSearch");
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = "application/json";
			string value = JsonConvert.SerializeObject(upload);
			using (StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
			{
				streamWriter.Write(value);
			}
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
			{
				string text = streamReader.ReadToEnd();
			}
		}

		// Token: 0x040001F2 RID: 498
		internal static VRCList Avis;

		// Token: 0x040001F3 RID: 499
		internal static VRCList SEENAvis;

		// Token: 0x040001F4 RID: 500
		internal static VRCList AviSearchlist;

		// Token: 0x040001F5 RID: 501
		public static bool ByNameOrAuther = false;

		// Token: 0x040001F6 RID: 502
		public static bool PublicOrPrivate = false;

		// Token: 0x040001F7 RID: 503
		public static List<AvatarObject> Searchedavis = new List<AvatarObject>();
	}
}
