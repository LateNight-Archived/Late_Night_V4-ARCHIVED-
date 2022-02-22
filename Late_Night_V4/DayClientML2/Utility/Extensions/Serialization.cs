using System;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.Serialization.Formatters.Binary;

namespace DayClientML2.Utility.Extensions
{
	// Token: 0x02000061 RID: 97
	public class Serialization
	{
		// Token: 0x060003C7 RID: 967 RVA: 0x0001BBB8 File Offset: 0x00019DB8
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

		// Token: 0x060003C8 RID: 968 RVA: 0x0001BBF8 File Offset: 0x00019DF8
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

		// Token: 0x060003C9 RID: 969 RVA: 0x0001BC34 File Offset: 0x00019E34
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

		// Token: 0x060003CA RID: 970 RVA: 0x0001BC98 File Offset: 0x00019E98
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

		// Token: 0x060003CB RID: 971 RVA: 0x0001BCE4 File Offset: 0x00019EE4
		public static T FromIL2CPPToManaged<T>(Object obj)
		{
			return Serialization.FromByteArray<T>(Serialization.ToByteArray(obj));
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0001BD04 File Offset: 0x00019F04
		public static T FromManagedToIL2CPP<T>(object obj)
		{
			return Serialization.IL2CPPFromByteArray<T>(Serialization.ToByteArray(obj));
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0001BD24 File Offset: 0x00019F24
		public static object[] FromIL2CPPArrayToManagedArray(Object[] obj)
		{
			object[] array = new object[obj.Length];
			for (int i = 0; i < obj.Length; i++)
			{
				bool flag = obj[i].GetIl2CppType().Attributes == 8192;
				if (flag)
				{
					array[i] = Serialization.FromIL2CPPToManaged<object>(obj[i]);
				}
				else
				{
					array[i] = obj[i];
				}
			}
			return array;
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0001BD80 File Offset: 0x00019F80
		public static Object[] FromManagedArrayToIL2CPPArray(object[] obj)
		{
			Object[] array = new Object[obj.Length];
			for (int i = 0; i < obj.Length; i++)
			{
				bool flag = obj[i].GetType().Attributes == TypeAttributes.Serializable;
				if (flag)
				{
					array[i] = Serialization.FromManagedToIL2CPP<Object>(obj[i]);
				}
				else
				{
					array[i] = (Object)obj[i];
				}
			}
			return array;
		}
	}
}
