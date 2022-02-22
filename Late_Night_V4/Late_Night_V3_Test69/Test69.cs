using System;
using Late_Night_V3_colnsole;
using UnityEngine;

namespace Late_Night_V3_Test69
{
	// Token: 0x02000011 RID: 17
	internal class Test69 : MonoBehaviour
	{
		// Token: 0x060000A7 RID: 167 RVA: 0x00005714 File Offset: 0x00003914
		public Test69(IntPtr ptr) : base(ptr)
		{
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000571F File Offset: 0x0000391F
		public void Start()
		{
			LNCcolnsole.Log("Start", false, ConsoleColor.White);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00005730 File Offset: 0x00003930
		public void Update()
		{
			Test69.time += Time.deltaTime;
			bool flag = Test69.time > 1f;
			if (flag)
			{
				LNCcolnsole.Log("UpDate", false, ConsoleColor.White);
				Test69.time = 0f;
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00005778 File Offset: 0x00003978
		public void OnDisable()
		{
			LNCcolnsole.Log("Disable", false, ConsoleColor.White);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00005789 File Offset: 0x00003989
		public void OnEnable()
		{
			LNCcolnsole.Log("Enable", false, ConsoleColor.White);
		}

		// Token: 0x0400005C RID: 92
		public static float time;
	}
}
