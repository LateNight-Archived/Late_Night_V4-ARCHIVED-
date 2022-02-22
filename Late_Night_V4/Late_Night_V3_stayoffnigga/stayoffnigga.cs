using System;
using UnityEngine;

namespace Late_Night_V3_stayoffnigga
{
	// Token: 0x02000012 RID: 18
	internal class stayoffnigga : MonoBehaviour
	{
		// Token: 0x060000AC RID: 172 RVA: 0x0000579A File Offset: 0x0000399A
		public stayoffnigga(IntPtr ptr) : base(ptr)
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000057A5 File Offset: 0x000039A5
		public void Start()
		{
			base.gameObject.SetActive(false);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000057B5 File Offset: 0x000039B5
		public void OnEnable()
		{
			base.gameObject.SetActive(false);
		}
	}
}
