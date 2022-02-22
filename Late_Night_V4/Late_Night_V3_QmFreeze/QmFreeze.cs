using System;
using Late_Night_config;
using Late_Night_V3.Modules_Funny;
using Late_Night_V3.Modules_Movement;
using UnityEngine;
using VRC.SDKBase;

namespace Late_Night_V3_QmFreeze
{
	// Token: 0x02000015 RID: 21
	internal class QmFreeze : MonoBehaviour
	{
		// Token: 0x060000B9 RID: 185 RVA: 0x00005BC9 File Offset: 0x00003DC9
		public QmFreeze(IntPtr ptr) : base(ptr)
		{
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00005BD4 File Offset: 0x00003DD4
		public void OnDisable()
		{
			bool flag = !Config.Instance.QmFreeze;
			if (!flag)
			{
				bool flag2 = !RoomManager.Method_Public_Static_get_Boolean_3();
				if (!flag2)
				{
					bool flag3 = Funny.GetLocalPlayer() == null || Networking.LocalPlayer == null;
					if (!flag3)
					{
						bool flag4 = Networking.LocalPlayer.IsPlayerGrounded();
						if (!flag4)
						{
							Vector3 velocity;
							velocity..ctor(0f, 0f, 0f);
							Networking.LocalPlayer.SetVelocity(velocity);
							bool flag5 = !Late_Night_V3.Modules_Movement.Movement.GetCurentBehaviour().NoclipG && !Late_Night_V3.Modules_Movement.Movement.GetCurentBehaviour().FlyG;
							if (flag5)
							{
								Physics.gravity = new Vector3(0f, 0f, 0f);
							}
						}
					}
				}
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00005C9C File Offset: 0x00003E9C
		public void OnEnable()
		{
			bool flag = !Config.Instance.QmFreeze;
			if (!flag)
			{
				bool flag2 = !RoomManager.Method_Public_Static_get_Boolean_3();
				if (!flag2)
				{
					bool flag3 = Funny.GetLocalPlayer() == null || Networking.LocalPlayer == null;
					if (!flag3)
					{
						bool flag4 = !Late_Night_V3.Modules_Movement.Movement.GetCurentBehaviour().NoclipG && !Late_Night_V3.Modules_Movement.Movement.GetCurentBehaviour().FlyG;
						if (flag4)
						{
							Physics.gravity = new Vector3(0f, -9.81f, 0f);
						}
					}
				}
			}
		}
	}
}
