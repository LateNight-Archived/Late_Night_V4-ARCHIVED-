using System;
using Late_Night_V3_colnsole;
using UnityEngine;
using UnityEngine.SceneManagement;
using VRCSDK2;

namespace Late_Night_V3_Enderpearl
{
	// Token: 0x0200001B RID: 27
	internal class Enderpearl : MonoBehaviour
	{
		// Token: 0x060000EE RID: 238 RVA: 0x00007960 File Offset: 0x00005B60
		public Enderpearl(IntPtr ptr) : base(ptr)
		{
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000796B File Offset: 0x00005B6B
		public void Start()
		{
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00007970 File Offset: 0x00005B70
		public void Update()
		{
			Enderpearl.time += Time.deltaTime;
			bool flag = Enderpearl.time <= 0.3f;
			if (!flag)
			{
				bool isHeld = base.gameObject.GetComponent<VRC_Pickup>().IsHeld;
				if (isHeld)
				{
					Enderpearl.Held = true;
				}
				bool held = Enderpearl.Held;
				if (held)
				{
					base.gameObject.GetComponent<Rigidbody>().useGravity = true;
					base.gameObject.GetComponent<BoxCollider>().isTrigger = false;
				}
				Enderpearl.time = 0f;
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000079F8 File Offset: 0x00005BF8
		public void OnDisable()
		{
			Enderpearl.Held = false;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00007A01 File Offset: 0x00005C01
		public void OnEnable()
		{
			Enderpearl.Held = false;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00007A0C File Offset: 0x00005C0C
		private void OnCollisionEnter(Collision collision)
		{
			bool flag = collision.transform.name.Contains("VRCPlayer");
			if (!flag)
			{
				foreach (ContactPoint contactPoint in collision.contacts)
				{
					bool flag2 = !Enderpearl.Held;
					if (!flag2)
					{
						LNCcolnsole.Log(contactPoint.point.ToString() + "Point To Tp To", false, ConsoleColor.White);
						Vector3 position;
						position..ctor(contactPoint.point.x, contactPoint.point.y, contactPoint.point.z);
						Enderpearl.GetLocalPlayer().transform.position = position;
						Object.Destroy(base.gameObject);
					}
				}
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00007AF8 File Offset: 0x00005CF8
		private void OnCollisionExit(Collision other)
		{
			LNCcolnsole.Log("No longer in contact with " + other.transform.name, false, ConsoleColor.White);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00007B19 File Offset: 0x00005D19
		private void OnDestroy()
		{
			Enderpearl.Held = false;
			LNCcolnsole.Log("GameObject Was Destroyed", false, ConsoleColor.White);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00007B30 File Offset: 0x00005D30
		internal static GameObject GetLocalPlayer()
		{
			foreach (GameObject gameObject in Enderpearl.GetAllGameObjects())
			{
				bool flag = gameObject.name.StartsWith("VRCPlayer[Local]");
				if (flag)
				{
					return gameObject;
				}
			}
			return new GameObject();
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00007B7C File Offset: 0x00005D7C
		internal static GameObject[] GetAllGameObjects()
		{
			return SceneManager.GetActiveScene().GetRootGameObjects();
		}

		// Token: 0x0400006D RID: 109
		public static bool Held;

		// Token: 0x0400006E RID: 110
		public static float time;
	}
}
