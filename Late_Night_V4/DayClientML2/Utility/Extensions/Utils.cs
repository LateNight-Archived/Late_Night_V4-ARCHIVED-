using System;
using Il2CppSystem;
using Photon.Realtime;
using UnhollowerRuntimeLib;
using UnityEngine;
using UnityEngine.XR;
using VRC;
using VRC.Management;
using VRC.SDKBase;
using VRC.UserCamera;

namespace DayClientML2.Utility.Extensions
{
	// Token: 0x02000066 RID: 102
	public static class Utils
	{
		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x0001D688 File Offset: 0x0001B888
		public static VRCUiCursorManager VRCUiCursorManager
		{
			get
			{
				return VRCUiCursorManager.field_Private_Static_VRCUiCursorManager_0;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x0001D68F File Offset: 0x0001B88F
		public static VRCUiPopupManager VRCUiPopupManager
		{
			get
			{
				return VRCUiPopupManager.field_Private_Static_VRCUiPopupManager_0;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x0001D696 File Offset: 0x0001B896
		public static VRCUiManager VRCUiManager
		{
			get
			{
				return VRCUiManager.Method_Internal_Static_get_VRCUiManager_PDM_0();
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x0001D69D File Offset: 0x0001B89D
		public static ModerationManager ModerationManager
		{
			get
			{
				return ModerationManager.Method_Public_Static_get_ModerationManager_PDM_0();
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x0001D6A4 File Offset: 0x0001B8A4
		public static LoadBalancingClient LoadBalancingPeer
		{
			get
			{
				return MonoBehaviour1PrivateObInPrInBoInInInInUnique.field_Internal_Static_MonoBehaviour1PrivateObInPrInBoInInInInUnique_0.Method_Public_get_LoadBalancingClient_0();
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x0001D6B0 File Offset: 0x0001B8B0
		public static MonoBehaviour1PrivateObInPrInBoInInInInUnique PhotonHandler
		{
			get
			{
				return MonoBehaviour1PrivateObInPrInBoInInInInUnique.field_Internal_Static_MonoBehaviour1PrivateObInPrInBoInInInInUnique_0;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x0001D6B7 File Offset: 0x0001B8B7
		public static NotificationManager NotificationManager
		{
			get
			{
				return NotificationManager.field_Private_Static_NotificationManager_0;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x0001D6BE File Offset: 0x0001B8BE
		public static VRCWebSocketsManager VRCWebSocketsManager
		{
			get
			{
				return VRCWebSocketsManager.field_Private_Static_VRCWebSocketsManager_0;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x0001D6C5 File Offset: 0x0001B8C5
		public static NetworkManager NetworkManager
		{
			get
			{
				return NetworkManager.field_Internal_Static_NetworkManager_0;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x0001D6CC File Offset: 0x0001B8CC
		public static PlayerManager PlayerManager
		{
			get
			{
				return PlayerManager.field_Private_Static_PlayerManager_0;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x0001D6D3 File Offset: 0x0001B8D3
		// (set) Token: 0x06000442 RID: 1090 RVA: 0x0001D6DA File Offset: 0x0001B8DA
		public static VRCPlayer CurrentUser
		{
			get
			{
				return VRCPlayer.field_Internal_Static_VRCPlayer_0;
			}
			set
			{
				Utils.CurrentUser = Utils.CurrentUser;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x0001D6E7 File Offset: 0x0001B8E7
		public static VRCPlayerApi LocalPlayer
		{
			get
			{
				return Networking.LocalPlayer;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x0001D6EE File Offset: 0x0001B8EE
		public static QuickMenu QuickMenu
		{
			get
			{
				return QuickMenu.Method_Public_Static_get_QuickMenu_PDM_0();
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x0001D6F5 File Offset: 0x0001B8F5
		public static UserInteractMenu UserInteractMenu
		{
			get
			{
				return Resources.FindObjectsOfTypeAll<UserInteractMenu>()[0];
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x0001D702 File Offset: 0x0001B902
		public static QuickMenuContextualDisplay QuickMenuContextualDisplay
		{
			get
			{
				return Utils.QuickMenu.field_Private_QuickMenuContextualDisplay_0;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x0001D70E File Offset: 0x0001B90E
		public static Camera Camera
		{
			get
			{
				return VRCVrCamera.field_Private_Static_VRCVrCamera_0.field_Public_Camera_0;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x0001D71A File Offset: 0x0001B91A
		public static VRCVrCamera VRCVrCamera
		{
			get
			{
				return VRCVrCamera.field_Private_Static_VRCVrCamera_0;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x0001D721 File Offset: 0x0001B921
		public static UserCameraController UserCameraController
		{
			get
			{
				return UserCameraController.field_Internal_Static_UserCameraController_0;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x0001D728 File Offset: 0x0001B928
		public static VRCTrackingManager VRCTrackingManager
		{
			get
			{
				return VRCTrackingManager.field_Private_Static_VRCTrackingManager_0;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x0001D72F File Offset: 0x0001B92F
		public static ActionMenu ActionMenu
		{
			get
			{
				return Utils.ActionMenu.field_Private_ActionMenuOpener_0.field_Public_ActionMenu_0;
			}
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0001D740 File Offset: 0x0001B940
		public static Vector3 GetWorldCameraPosition()
		{
			VRCVrCamera vrcvrCamera = Utils.VRCVrCamera;
			Type il2CppType = vrcvrCamera.GetIl2CppType();
			bool flag = il2CppType == Il2CppType.Of<VRCVrCameraSteam>();
			if (flag)
			{
				VRCVrCameraSteam vrcvrCameraSteam = vrcvrCamera.Cast<VRCVrCameraSteam>();
				Transform field_Private_Transform_ = vrcvrCameraSteam.field_Private_Transform_0;
				Transform field_Private_Transform_2 = vrcvrCameraSteam.field_Private_Transform_1;
				bool flag2 = field_Private_Transform_.name == "Camera (eye)";
				if (flag2)
				{
					return field_Private_Transform_.position;
				}
				bool flag3 = field_Private_Transform_2.name == "Camera (eye)";
				if (flag3)
				{
					return field_Private_Transform_2.position;
				}
			}
			bool flag4 = il2CppType == Il2CppType.Of<VRCVrCameraUnity>();
			Vector3 result;
			if (flag4)
			{
				VRCVrCameraUnity vrcvrCameraUnity = vrcvrCamera.Cast<VRCVrCameraUnity>();
				result = vrcvrCameraUnity.field_Public_Camera_0.transform.position;
			}
			else
			{
				bool flag5 = il2CppType != Il2CppType.Of<VRCVrCameraWave>();
				if (flag5)
				{
					result = vrcvrCamera.transform.parent.TransformPoint(Utils.GetLocalCameraPosition());
				}
				else
				{
					VRCVrCameraWave vrcvrCameraWave = vrcvrCamera.Cast<VRCVrCameraWave>();
					result = vrcvrCameraWave.transform.position;
				}
			}
			return result;
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0001D840 File Offset: 0x0001BA40
		public static Vector3 GetLocalCameraPosition()
		{
			VRCVrCamera vrcvrCamera = Utils.VRCVrCamera;
			Type il2CppType = vrcvrCamera.GetIl2CppType();
			bool flag = il2CppType == Il2CppType.Of<VRCVrCamera>();
			Vector3 result;
			if (flag)
			{
				result = vrcvrCamera.transform.localPosition;
			}
			else
			{
				bool flag2 = il2CppType == Il2CppType.Of<VRCVrCameraSteam>();
				if (flag2)
				{
					VRCVrCameraSteam vrcvrCameraSteam = vrcvrCamera.Cast<VRCVrCameraSteam>();
					Transform field_Private_Transform_ = vrcvrCameraSteam.field_Private_Transform_0;
					Transform field_Private_Transform_2 = vrcvrCameraSteam.field_Private_Transform_1;
					bool flag3 = field_Private_Transform_.name == "Camera (eye)";
					if (flag3)
					{
						result = vrcvrCamera.transform.parent.InverseTransformPoint(field_Private_Transform_.position);
					}
					else
					{
						result = ((field_Private_Transform_2.name == "Camera (eye)") ? vrcvrCamera.transform.parent.InverseTransformPoint(field_Private_Transform_2.position) : Vector3.zero);
					}
				}
				else
				{
					bool flag4 = il2CppType == Il2CppType.Of<VRCVrCameraUnity>();
					if (flag4)
					{
						bool flag5 = MiskExtension.IsInVR();
						if (flag5)
						{
							result = vrcvrCamera.transform.localPosition + InputTracking.GetLocalPosition(2);
						}
						else
						{
							VRCVrCameraUnity vrcvrCameraUnity = vrcvrCamera.Cast<VRCVrCameraUnity>();
							result = vrcvrCamera.transform.parent.InverseTransformPoint(vrcvrCameraUnity.field_Public_Camera_0.transform.position);
						}
					}
					else
					{
						bool flag6 = il2CppType != Il2CppType.Of<VRCVrCameraWave>();
						if (flag6)
						{
							result = Vector3.zero;
						}
						else
						{
							VRCVrCameraWave vrcvrCameraWave = vrcvrCamera.Cast<VRCVrCameraWave>();
							result = vrcvrCameraWave.field_Public_Transform_0.InverseTransformPoint(vrcvrCamera.transform.position);
						}
					}
				}
			}
			return result;
		}
	}
}
