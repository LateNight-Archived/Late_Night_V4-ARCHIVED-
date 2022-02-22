using System;
using System.Diagnostics;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace ProjectXoX.Utility
{
	// Token: 0x0200004C RID: 76
	public class ActionListenerLNC_ : MonoBehaviour
	{
		// Token: 0x06000293 RID: 659 RVA: 0x0001708E File Offset: 0x0001528E
		public ActionListenerLNC_(IntPtr obj0) : base(obj0)
		{
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000294 RID: 660 RVA: 0x0001709C File Offset: 0x0001529C
		// (remove) Token: 0x06000295 RID: 661 RVA: 0x000170D4 File Offset: 0x000152D4
		[method: HideFromIl2Cpp]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event Action OnEnabled;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000296 RID: 662 RVA: 0x0001710C File Offset: 0x0001530C
		// (remove) Token: 0x06000297 RID: 663 RVA: 0x00017144 File Offset: 0x00015344
		[method: HideFromIl2Cpp]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event Action OnDisabled;

		// Token: 0x06000298 RID: 664 RVA: 0x0001717C File Offset: 0x0001537C
		private void OnEnable()
		{
			Action onEnabled = this.OnEnabled;
			if (onEnabled != null)
			{
				onEnabled();
			}
		}

		// Token: 0x06000299 RID: 665 RVA: 0x000171A0 File Offset: 0x000153A0
		private void OnDisable()
		{
			Action onDisabled = this.OnDisabled;
			if (onDisabled != null)
			{
				onDisabled();
			}
		}
	}
}
