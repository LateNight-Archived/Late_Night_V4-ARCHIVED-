using System;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VRC.Core;

namespace DayClientML2.Utility.MenuApi
{
	// Token: 0x02000059 RID: 89
	public class VRCList
	{
		// Token: 0x06000349 RID: 841 RVA: 0x00019C44 File Offset: 0x00017E44
		public VRCList(Transform parent, string name, int Position = 0)
		{
			this.GameObject = Object.Instantiate<GameObject>(VRCList.PublicAvatarList.gameObject, parent);
			this.UiAvatarList = this.GameObject.GetComponent<UiAvatarList>();
			this.UiAvatarList.field_Public_Category_0 = 4;
			this.UiAvatarList.field_Protected_Dictionary_2_Int32_List_1_ApiModel_0.Clear();
			this.UiAvatarList.field_Private_Dictionary_2_String_ApiAvatar_0.Clear();
			this.UiAvatarList.disabledOnMobile = false;
			this.UiAvatarList.disabledOnPc = false;
			this.UiVRCList = this.GameObject.GetComponent<UiVRCList>();
			this.Text = this.GameObject.transform.Find("Button").GetComponentInChildren<Text>();
			this.GameObject.transform.SetSiblingIndex(Position);
			this.UiVRCList.clearUnseenListOnCollapse = false;
			this.UiVRCList.usePagination = false;
			this.UiVRCList.hideElementsWhenContracted = false;
			this.UiVRCList.hideWhenEmpty = false;
			this.UiVRCList.startExpanded = false;
			this.GameObject.SetActive(true);
			this.GameObject.name = name;
			this.Text.text = name;
			this.RenderElement(new List<ApiAvatar>());
			this.UiAvatarList.field_Protected_Dictionary_2_Int32_List_1_ApiModel_0.Clear();
			this.UiAvatarList.field_Private_Dictionary_2_String_ApiAvatar_0.Clear();
			this.RenderElement(new List<ApiAvatar>());
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00019DAE File Offset: 0x00017FAE
		public void RenderElement(List<ApiAvatar> AvatarList)
		{
			this.UiVRCList.Method_Protected_Void_List_1_T_Int32_Boolean_VRCUiContentButton_0<ApiAvatar>(AvatarList, 0, true, null);
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600034B RID: 843 RVA: 0x00019DC4 File Offset: 0x00017FC4
		// (set) Token: 0x0600034C RID: 844 RVA: 0x00019E38 File Offset: 0x00018038
		public bool Expanded
		{
			get
			{
				bool flag = this.UiVRCList.field_Private_Int32_0 == this.UiVRCList.expandedCount && this.UiVRCList.field_Protected_Boolean_0;
				bool result;
				if (flag)
				{
					result = true;
				}
				else
				{
					bool flag2 = this.UiVRCList.field_Private_Int32_0 == this.UiVRCList.collapsedCount && !this.UiVRCList.field_Protected_Boolean_0;
					result = (flag2 && false);
				}
				return result;
			}
			set
			{
				bool flag = this.Expanded != value;
				if (flag)
				{
					this.UiVRCList.ToggleExtend();
				}
			}
		}

		// Token: 0x040001CC RID: 460
		public GameObject GameObject;

		// Token: 0x040001CD RID: 461
		public UiVRCList UiVRCList;

		// Token: 0x040001CE RID: 462
		private UiAvatarList UiAvatarList;

		// Token: 0x040001CF RID: 463
		public Text Text;

		// Token: 0x040001D0 RID: 464
		public static GameObject PublicAvatarList = GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/Content/Public Avatar List");
	}
}
