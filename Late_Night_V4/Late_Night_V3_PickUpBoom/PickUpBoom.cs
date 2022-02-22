using System;
using System.Linq;
using Late_Night_V3_colnsole;
using UnityEngine;
using VRC.SDK3.Components;
using VRC.SDKBase;
using VRCSDK2;

namespace Late_Night_V3_PickUpBoom
{
	// Token: 0x02000019 RID: 25
	internal class PickUpBoom : MonoBehaviour
	{
		// Token: 0x060000E3 RID: 227 RVA: 0x00007559 File Offset: 0x00005759
		public PickUpBoom(IntPtr ptr) : base(ptr)
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00007564 File Offset: 0x00005764
		public void Start()
		{
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00007568 File Offset: 0x00005768
		public void Update()
		{
			PickUpBoom.time += Time.deltaTime;
			bool flag = PickUpBoom.time > 0.3f;
			if (flag)
			{
				bool isHeld = base.gameObject.GetComponent<VRC_Pickup>().IsHeld;
				if (isHeld)
				{
					PickUpBoom.Held = true;
				}
				bool held = PickUpBoom.Held;
				if (held)
				{
					base.gameObject.GetComponent<Rigidbody>().useGravity = true;
					base.gameObject.GetComponent<BoxCollider>().isTrigger = false;
				}
				PickUpBoom.time = 0f;
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000075ED File Offset: 0x000057ED
		public void OnDisable()
		{
			PickUpBoom.Held = false;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000075F6 File Offset: 0x000057F6
		public void OnEnable()
		{
			PickUpBoom.Held = false;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00007600 File Offset: 0x00005800
		private void OnCollisionEnter(Collision collision)
		{
			bool flag = !collision.transform.name.Contains("VRCPlayer");
			if (flag)
			{
				foreach (ContactPoint contactPoint in collision.contacts)
				{
					bool held = PickUpBoom.Held;
					if (held)
					{
						LNCcolnsole.Log(contactPoint.point.ToString() + "Point To Tp To", false, ConsoleColor.White);
						Vector3 vector;
						vector..ctor(contactPoint.point.x, contactPoint.point.y, contactPoint.point.z);
						PickUpBoom.bringpickupsTOaVector(vector);
						Object.Destroy(base.gameObject);
					}
				}
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000076DC File Offset: 0x000058DC
		private void OnCollisionExit(Collision other)
		{
			LNCcolnsole.Log("No longer in contact with " + other.transform.name, false, ConsoleColor.White);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000076FD File Offset: 0x000058FD
		private void OnDestroy()
		{
			PickUpBoom.Held = false;
			LNCcolnsole.Log("GameObject Was Destroyed", false, ConsoleColor.White);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00007714 File Offset: 0x00005914
		internal static void bringpickupsTOaVector(Vector3 vector)
		{
			VRC_Pickup[] array = Resources.FindObjectsOfTypeAll<VRC_Pickup>().ToArray<VRC_Pickup>();
			for (int i = 0; i < array.Length; i++)
			{
				bool flag = array[i].gameObject;
				if (flag)
				{
					Networking.LocalPlayer.TakeOwnership(array[i].gameObject);
					array[i].transform.localPosition = new Vector3(0f, 0.3f, 0f);
					Transform transform = array[i].transform;
					transform.position = vector;
				}
			}
			VRC_Pickup[] array2 = Resources.FindObjectsOfTypeAll<VRC_Pickup>().ToArray<VRC_Pickup>();
			for (int j = 0; j < array2.Length; j++)
			{
				bool flag2 = array2[j].gameObject;
				if (flag2)
				{
					Networking.LocalPlayer.TakeOwnership(array2[j].gameObject);
					array2[j].transform.localPosition = new Vector3(0f, 0.3f, 0f);
					Transform transform2 = array2[j].transform;
					transform2.position = vector;
				}
			}
			VRCPickup[] array3 = Resources.FindObjectsOfTypeAll<VRCPickup>().ToArray<VRCPickup>();
			for (int k = 0; k < array3.Length; k++)
			{
				bool flag3 = array3[k].gameObject;
				if (flag3)
				{
					Networking.LocalPlayer.TakeOwnership(array3[k].gameObject);
					array3[k].transform.localPosition = new Vector3(0f, 0.3f, 0f);
					Transform transform3 = array3[k].transform;
					transform3.position = vector;
				}
			}
		}

		// Token: 0x0400006A RID: 106
		public static bool Held;

		// Token: 0x0400006B RID: 107
		public static float time;
	}
}
