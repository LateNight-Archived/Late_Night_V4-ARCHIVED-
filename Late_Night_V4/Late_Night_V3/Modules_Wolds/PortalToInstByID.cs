using System;
using Il2CppSystem;
using UnityEngine;
using VRC.SDKBase;

namespace Late_Night_V3.Modules_Wolds
{
	// Token: 0x02000021 RID: 33
	internal static class PortalToInstByID
	{
		// Token: 0x06000175 RID: 373 RVA: 0x0000E248 File Offset: 0x0000C448
		internal static void PortalToInstanceByID(string id)
		{
			VRCPlayer field_Internal_Static_VRCPlayer_ = VRCPlayer.field_Internal_Static_VRCPlayer_0;
			string[] array = id.Split(new char[]
			{
				':'
			});
			GameObject gameObject = Networking.Instantiate(0, "Portals/PortalInternalDynamic", field_Internal_Static_VRCPlayer_.transform.position + field_Internal_Static_VRCPlayer_.transform.forward * 1.5f, field_Internal_Static_VRCPlayer_.transform.rotation);
			string text = array[0];
			string text2 = array[1];
			int value = 0;
			RPC.Destination destination = 7;
			GameObject gameObject2 = gameObject;
			string text3 = "ConfigurePortal";
			Object[] array2 = new Object[3];
			array2[0] = text;
			array2[1] = text2;
			int num = 2;
			Int32 @int = default(Int32);
			@int.m_value = value;
			array2[num] = @int.BoxIl2CppObject();
			Networking.RPC(destination, gameObject2, text3, array2);
		}
	}
}
