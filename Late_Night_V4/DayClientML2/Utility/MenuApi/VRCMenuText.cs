using System;
using UnityEngine;
using UnityEngine.UI;

namespace DayClientML2.Utility.MenuApi
{
	// Token: 0x02000058 RID: 88
	internal class VRCMenuText
	{
		// Token: 0x06000342 RID: 834 RVA: 0x00019944 File Offset: 0x00017B44
		public VRCMenuText(MenuType type, float x_pos, float y_pos, string text, int TextSize = 20)
		{
			try
			{
				this.SettingsPage = GameObject.Find("UserInterface/MenuContent/Screens/Settings");
				this.SocialPage = GameObject.Find("UserInterface/MenuContent/Screens/Social");
				this.UserInfoPage = GameObject.Find("UserInterface/MenuContent/Screens/UserInfo");
				this.AvatarPage = GameObject.Find("UserInterface/MenuContent/Screens/Avatar");
				this.WorldsPage = GameObject.Find("UserInterface/MenuContent/Screens/Worlds");
			}
			catch (Exception)
			{
				throw;
			}
			try
			{
				GameObject gameObject = GameObject.Find("UserInterface/MenuContent/Screens/Avatar/TitlePanel (1)/TitleText");
				this.Button = Object.Instantiate<GameObject>(gameObject, gameObject.transform);
			}
			catch (Exception)
			{
				throw;
			}
			try
			{
				switch (type)
				{
				case MenuType.UserInfo:
					this.Button.transform.SetParent(this.UserInfoPage.transform);
					break;
				case MenuType.AvatarMenu:
					this.Button.transform.SetParent(this.AvatarPage.transform);
					break;
				case MenuType.SettingsMenu:
					this.Button.transform.SetParent(this.SettingsPage.transform);
					break;
				case MenuType.SocialMenu:
					this.Button.transform.SetParent(this.SocialPage.transform);
					break;
				case MenuType.WorldMenu:
					this.Button.transform.SetParent(this.WorldsPage.transform);
					break;
				case MenuType.WorldInfo:
					break;
				default:
					throw new ArgumentOutOfRangeException("type", type, null);
				}
			}
			catch (Exception)
			{
				throw;
			}
			this.Button.GetComponentInChildren<Text>().text = text;
			this.Button.GetComponentInChildren<Text>().resizeTextMaxSize = TextSize;
			this.Button.GetComponent<RectTransform>().anchoredPosition = new Vector2(x_pos, y_pos);
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00019B1C File Offset: 0x00017D1C
		public VRCMenuText(Transform transform, float x_pos, float y_pos, string text, int TextSize = 20)
		{
			try
			{
				GameObject gameObject = GameObject.Find("UserInterface/MenuContent/Screens/Avatar/TitlePanel (1)/TitleText");
				this.Button = Object.Instantiate<GameObject>(gameObject, gameObject.transform);
			}
			catch (Exception)
			{
				throw;
			}
			try
			{
				this.Button.transform.SetParent(transform);
			}
			catch (Exception)
			{
				throw;
			}
			this.Button.name = string.Format("VRCMenuText_{0}_{1}_{2}", text, x_pos, y_pos);
			this.SetText(text);
			this.SetSize(TextSize);
			this.SetPosition(x_pos, y_pos);
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00019BCC File Offset: 0x00017DCC
		public void SetText(string text)
		{
			this.Button.GetComponentInChildren<Text>().text = text;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00019BE1 File Offset: 0x00017DE1
		public void SetColor(float r, float g, float b, float a)
		{
			this.Button.GetComponent<Text>().color = new Color(r, g, b, a);
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00019BFF File Offset: 0x00017DFF
		public void SetColor(Color Color)
		{
			this.Button.GetComponent<Text>().color = Color;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00019C14 File Offset: 0x00017E14
		public void SetSize(int size)
		{
			this.Button.GetComponentInChildren<Text>().resizeTextMaxSize = size;
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00019C29 File Offset: 0x00017E29
		public void SetPosition(float x_pos, float y_pos)
		{
			this.Button.GetComponent<RectTransform>().anchoredPosition = new Vector2(x_pos, y_pos);
		}

		// Token: 0x040001C6 RID: 454
		public GameObject Button;

		// Token: 0x040001C7 RID: 455
		private GameObject UserInfoPage;

		// Token: 0x040001C8 RID: 456
		private GameObject AvatarPage;

		// Token: 0x040001C9 RID: 457
		private GameObject SettingsPage;

		// Token: 0x040001CA RID: 458
		private GameObject SocialPage;

		// Token: 0x040001CB RID: 459
		private GameObject WorldsPage;
	}
}
