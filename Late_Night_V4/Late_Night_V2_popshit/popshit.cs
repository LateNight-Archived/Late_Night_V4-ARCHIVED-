using System;
using System.Windows.Forms;
using UnityEngine;
using VRC.Core;
using VRC.SDKBase;
using VRC.UI;

namespace Late_Night_V2_popshit
{
	// Token: 0x02000017 RID: 23
	internal class popshit
	{
		// Token: 0x060000DB RID: 219 RVA: 0x00007134 File Offset: 0x00005334
		public static bool JoinWorldById(string id)
		{
			bool flag = Networking.GoToRoom(id);
			bool result;
			if (flag)
			{
				result = true;
			}
			else
			{
				string[] array = id.Split(new char[]
				{
					':'
				});
				bool flag2 = array.Length != 2;
				if (flag2)
				{
					result = false;
				}
				else
				{
					new PortalInternal().Method_Private_Void_String_String_PDM_0(array[0], array[1]);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000718C File Offset: 0x0000538C
		internal static void avatarbyid(string AVI)
		{
			PageAvatar component = GameObject.Find("Screens").transform.Find("Avatar").GetComponent<PageAvatar>();
			component.field_Public_SimpleAvatarPedestal_0.field_Internal_ApiAvatar_0 = new ApiAvatar
			{
				id = AVI
			};
			component.ChangeToSelectedAvatar();
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000071DC File Offset: 0x000053DC
		internal static string GetClipboard()
		{
			return Clipboard.ContainsText() ? Clipboard.GetText() : null;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00007200 File Offset: 0x00005400
		internal static void SetClipboard(string Set)
		{
			bool flag = Clipboard.ContainsText();
			if (flag)
			{
				Clipboard.Clear();
				Clipboard.SetText(Set);
			}
			else
			{
				Clipboard.SetText(Set);
			}
		}
	}
}
