using System;
using System.Linq;
using System.Reflection;
using VRC.Core;

namespace DayClientML2.Utility.Extensions
{
	// Token: 0x02000065 RID: 101
	internal static class RoomManagerExtension
	{
		// Token: 0x06000430 RID: 1072 RVA: 0x0001D59C File Offset: 0x0001B79C
		public static bool IsInWorld()
		{
			return RoomManagerExtension.GetWorld() != null || RoomManagerExtension.GetWorldInstance() != null;
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x0001D5C0 File Offset: 0x0001B7C0
		public static ApiWorld GetWorld()
		{
			return RoomManager.field_Internal_Static_ApiWorld_0;
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x0001D5D8 File Offset: 0x0001B7D8
		public static string GetWorldName()
		{
			return RoomManagerExtension.GetWorld().name;
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x0001D5F4 File Offset: 0x0001B7F4
		public static ApiWorldInstance GetWorldInstance()
		{
			return RoomManager.field_Internal_Static_ApiWorldInstance_0;
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0001D60C File Offset: 0x0001B80C
		public static string GetInstanceID()
		{
			bool flag = RoomManagerExtension.IsInWorld();
			string result;
			if (flag)
			{
				result = RoomManagerExtension.GetWorld().id + ":" + RoomManagerExtension.GetWorldInstance().instanceId;
			}
			else
			{
				result = "No World";
			}
			return result;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0001D650 File Offset: 0x0001B850
		public static int GetWorldOccupants()
		{
			return RoomManagerExtension.GetWorld().occupants;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x0001D66C File Offset: 0x0001B86C
		public static int GetWorldCapacity()
		{
			return RoomManagerExtension.GetWorld().capacity;
		}

		// Token: 0x020000E0 RID: 224
		private static class WorldStuff2
		{
			// Token: 0x0600081F RID: 2079 RVA: 0x00026AFC File Offset: 0x00024CFC
			internal static RoomManagerExtension.WorldStuff2.APIWorldDelegate GetWorld()
			{
				return RoomManagerExtension.WorldStuff2.APIWorld;
			}

			// Token: 0x170001D7 RID: 471
			// (get) Token: 0x06000820 RID: 2080 RVA: 0x00026B14 File Offset: 0x00024D14
			internal static RoomManagerExtension.WorldStuff2.APIWorldDelegate ApiWorld
			{
				get
				{
					bool flag = RoomManagerExtension.WorldStuff2.APIWorld != null;
					RoomManagerExtension.WorldStuff2.APIWorldDelegate apiworld;
					if (flag)
					{
						apiworld = RoomManagerExtension.WorldStuff2.APIWorld;
					}
					else
					{
						MethodInfo method = typeof(RoomManager).GetMethods().First((MethodInfo x) => x.ReturnType == typeof(ApiWorldInstance));
						RoomManagerExtension.WorldStuff2.APIWorld = (RoomManagerExtension.WorldStuff2.APIWorldDelegate)Delegate.CreateDelegate(typeof(RoomManagerExtension.WorldStuff2.APIWorldDelegate), method);
						apiworld = RoomManagerExtension.WorldStuff2.APIWorld;
					}
					return apiworld;
				}
			}

			// Token: 0x06000821 RID: 2081 RVA: 0x00026B90 File Offset: 0x00024D90
			internal static RoomManagerExtension.WorldStuff2.APIWorldInstanceDelegate GetWorldInstance()
			{
				return RoomManagerExtension.WorldStuff2.APIWorldInstance;
			}

			// Token: 0x170001D8 RID: 472
			// (get) Token: 0x06000822 RID: 2082 RVA: 0x00026BA8 File Offset: 0x00024DA8
			internal static RoomManagerExtension.WorldStuff2.APIWorldInstanceDelegate ApiWorldInstance
			{
				get
				{
					bool flag = RoomManagerExtension.WorldStuff2.APIWorldInstance != null;
					RoomManagerExtension.WorldStuff2.APIWorldInstanceDelegate apiworldInstance;
					if (flag)
					{
						apiworldInstance = RoomManagerExtension.WorldStuff2.APIWorldInstance;
					}
					else
					{
						MethodInfo method = typeof(RoomManager).GetMethods().First((MethodInfo x) => x.ReturnType == typeof(ApiWorldInstance));
						RoomManagerExtension.WorldStuff2.APIWorldInstance = (RoomManagerExtension.WorldStuff2.APIWorldInstanceDelegate)Delegate.CreateDelegate(typeof(RoomManagerExtension.WorldStuff2.APIWorldInstanceDelegate), method);
						apiworldInstance = RoomManagerExtension.WorldStuff2.APIWorldInstance;
					}
					return apiworldInstance;
				}
			}

			// Token: 0x0400043F RID: 1087
			private static RoomManagerExtension.WorldStuff2.APIWorldDelegate APIWorld;

			// Token: 0x04000440 RID: 1088
			private static RoomManagerExtension.WorldStuff2.APIWorldInstanceDelegate APIWorldInstance;

			// Token: 0x02000188 RID: 392
			// (Invoke) Token: 0x06000AAF RID: 2735
			internal delegate RoomManager APIWorldDelegate();

			// Token: 0x02000189 RID: 393
			// (Invoke) Token: 0x06000AB3 RID: 2739
			internal delegate RoomManager APIWorldInstanceDelegate();
		}
	}
}
