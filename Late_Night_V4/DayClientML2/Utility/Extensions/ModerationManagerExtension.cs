using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using VRC.Core;
using VRC.Management;

namespace DayClientML2.Utility.Extensions
{
	// Token: 0x0200005D RID: 93
	internal static class ModerationManagerExtension
	{
		// Token: 0x06000382 RID: 898 RVA: 0x0001AA38 File Offset: 0x00018C38
		internal static bool GetBlocked(this ModerationManager Instance, string UserId)
		{
			return Instance.Get(UserId).Contains(1);
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0001AA58 File Offset: 0x00018C58
		internal static bool GetMuted(this ModerationManager Instance, string UserId)
		{
			return Instance.Get(UserId).Contains(2);
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0001AA78 File Offset: 0x00018C78
		internal static bool GetUnMuted(this ModerationManager Instance, string UserId)
		{
			return Instance.Get(UserId).Contains(3);
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0001AA98 File Offset: 0x00018C98
		internal static bool GetShown(this ModerationManager Instance, string UserId)
		{
			return Instance.Get(UserId).Contains(5);
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0001AAB8 File Offset: 0x00018CB8
		internal static bool GetHide(this ModerationManager Instance, string UserId)
		{
			return Instance.Get(UserId).Contains(4);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0001AAD8 File Offset: 0x00018CD8
		internal static bool GetSafety(this ModerationManager Instance, string UserId)
		{
			return !Instance.GetShown(UserId) && !Instance.GetHide(UserId);
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0001AB00 File Offset: 0x00018D00
		internal static List<ApiPlayerModeration.ModerationType> Get(this ModerationManager Instance, string UserId)
		{
			bool flag = ModerationManagerExtension.PlayerModerations.ContainsKey(UserId);
			List<ApiPlayerModeration.ModerationType> result;
			if (flag)
			{
				List<ApiPlayerModeration> list = ModerationManagerExtension.PlayerModerations[UserId];
				List<ApiPlayerModeration.ModerationType> list2 = new List<ApiPlayerModeration.ModerationType>();
				IEnumerable<ApiPlayerModeration> source = list;
				Func<ApiPlayerModeration, bool> <>9__0;
				Func<ApiPlayerModeration, bool> predicate;
				if ((predicate = <>9__0) == null)
				{
					predicate = (<>9__0 = ((ApiPlayerModeration m) => m.targetUserId == UserId));
				}
				foreach (ApiPlayerModeration apiPlayerModeration in source.Where(predicate))
				{
					list2.Add(apiPlayerModeration.moderationType);
				}
				result = list2;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000389 RID: 905 RVA: 0x0001ABC4 File Offset: 0x00018DC4
		private static Dictionary<string, List<ApiPlayerModeration>> PlayerModerations
		{
			get
			{
				object obj = ModerationManagerExtension.FromIL2CPPToManaged<object>(Utils.ModerationManager.field_Private_Dictionary_2_String_List_1_ApiPlayerModeration_0);
				return obj as Dictionary<string, List<ApiPlayerModeration>>;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600038A RID: 906 RVA: 0x0001ABEC File Offset: 0x00018DEC
		private static Dictionary<string, List<ApiModeration>> ApiModerations
		{
			get
			{
				return Utils.ModerationManager.field_Private_Dictionary_2_String_List_1_ApiModeration_0;
			}
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0001AC08 File Offset: 0x00018E08
		public static T FromIL2CPPToManaged<T>(Object obj)
		{
			return ModerationManagerExtension.FromByteArray<T>(ModerationManagerExtension.ToByteArray(obj));
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0001AC28 File Offset: 0x00018E28
		public static T FromByteArray<T>(byte[] data)
		{
			bool flag = data == null;
			T result;
			if (flag)
			{
				result = default(T);
			}
			else
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				using (MemoryStream memoryStream = new MemoryStream(data))
				{
					object obj = binaryFormatter.Deserialize(memoryStream);
					result = (T)((object)obj);
				}
			}
			return result;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0001AC8C File Offset: 0x00018E8C
		public static byte[] ToByteArray(object obj)
		{
			bool flag = obj == null;
			byte[] result;
			if (flag)
			{
				result = null;
			}
			else
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				MemoryStream memoryStream = new MemoryStream();
				binaryFormatter.Serialize(memoryStream, obj);
				result = memoryStream.ToArray();
			}
			return result;
		}
	}
}
