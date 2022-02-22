using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.Serialization.Formatters.Binary;

namespace Late_Night_V3_StarLag
{
	// Token: 0x02000014 RID: 20
	internal static class Serialization
	{
		// Token: 0x060000B4 RID: 180 RVA: 0x00005A84 File Offset: 0x00003C84
		public static byte[] ToByteArray(Object obj)
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

		// Token: 0x060000B5 RID: 181 RVA: 0x00005AC4 File Offset: 0x00003CC4
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

		// Token: 0x060000B6 RID: 182 RVA: 0x00005B00 File Offset: 0x00003D00
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

		// Token: 0x060000B7 RID: 183 RVA: 0x00005B60 File Offset: 0x00003D60
		public static T IL2CPPFromByteArray<T>(byte[] data)
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
				MemoryStream memoryStream = new MemoryStream(data);
				object obj = binaryFormatter.Deserialize(memoryStream);
				result = (T)((object)obj);
			}
			return result;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00005BAC File Offset: 0x00003DAC
		public static T FromManagedToIL2CPP<T>(object obj)
		{
			return Serialization.IL2CPPFromByteArray<T>(Serialization.ToByteArray(obj));
		}
	}
}
