using System;
using UnhollowerBaseLib;
using UnhollowerRuntimeLib;
using UnityEngine;
using UnityEngine.UI;

namespace DayClientML2.Utility
{
	// Token: 0x0200004E RID: 78
	internal class MenuButton
	{
		// Token: 0x060002A1 RID: 673 RVA: 0x000171C4 File Offset: 0x000153C4
		public MenuButton(MenuType type, MenuButtonType buttontype, string text, float x_pos, float y_pos, Action listener)
		{
			try
			{
				switch (buttontype)
				{
				case MenuButtonType.PlaylistButton:
				{
					GameObject playlistsButton = MenuContent.Screens_1.UserInfo_2.Buttons_3.RightSideButtons_4.RightUpperButtonColumn_5.PlaylistsButton;
					this.Button = Object.Instantiate<GameObject>(playlistsButton, playlistsButton.transform);
					break;
				}
				case MenuButtonType.AvatarFavButton:
				{
					GameObject favorite_Button = MenuContent.Screens_1.Avatar_2.Favorite_Button;
					this.Button = Object.Instantiate<GameObject>(favorite_Button, favorite_Button.transform.parent);
					break;
				}
				case MenuButtonType.HeaderButton:
				{
					GameObject worldsPageTab = MenuButton.WorldsPageTab;
					this.Button = Object.Instantiate<GameObject>(worldsPageTab, worldsPageTab.transform.parent);
					break;
				}
				default:
				{
					GameObject favorite_Button2 = MenuContent.Screens_1.Avatar_2.Favorite_Button;
					this.Button = Object.Instantiate<GameObject>(favorite_Button2, favorite_Button2.transform.parent);
					break;
				}
				}
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
					this.Button.transform.SetParent(MenuContent.Screens_1.UserInfo.transform);
					break;
				case MenuType.AvatarMenu:
					this.Button.transform.SetParent(MenuContent.Screens_1.Avatar.transform);
					break;
				case MenuType.SettingsMenu:
					this.Button.transform.SetParent(MenuContent.Screens_1.Settings.transform);
					break;
				case MenuType.SocialMenu:
					this.Button.transform.SetParent(MenuContent.Screens_1.Social.transform);
					break;
				case MenuType.WorldMenu:
					this.Button.transform.SetParent(MenuContent.Screens_1.Worlds.transform);
					break;
				case MenuType.WorldInfo:
					break;
				default:
					this.Button.transform.SetParent(MenuContent.Screens_1.UserInfo.transform);
					break;
				}
			}
			catch (Exception)
			{
				throw;
			}
			foreach (Text text2 in this.Button.GetComponentsInChildren<Text>(true))
			{
				text2.text = "";
			}
			foreach (Image image in this.Button.GetComponentsInChildren<Image>(true))
			{
				bool flag = image.name.ToLower().Contains("icon");
				if (flag)
				{
					Object.Destroy(image);
				}
			}
			this.Button.GetComponentInChildren<Text>().text = text;
			this.Button.name = text;
			this.Button.GetComponentInChildren<Button>().onClick = new Button.ButtonClickedEvent();
			this.Button.GetComponentInChildren<Button>().onClick.AddListener(listener);
			this.Button.GetComponentInChildren<Button>().m_Interactable = true;
			this.Button.GetComponent<RectTransform>().anchoredPosition = new Vector2(x_pos, y_pos);
			this.Button.name = string.Format("MenuButton_{0}_{1}_{2}", text, x_pos, y_pos);
			this.Button.SetActive(true);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x000174E4 File Offset: 0x000156E4
		public MenuButton(MenuType type, MenuButtonType buttontype, string text, float x_pos, float y_pos, Action listener, float xSize, float ySize)
		{
			try
			{
				switch (buttontype)
				{
				case MenuButtonType.PlaylistButton:
				{
					GameObject playlistsButton = MenuContent.Screens_1.UserInfo_2.Buttons_3.RightSideButtons_4.RightUpperButtonColumn_5.PlaylistsButton;
					this.Button = Object.Instantiate<GameObject>(playlistsButton, playlistsButton.transform);
					break;
				}
				case MenuButtonType.AvatarFavButton:
				{
					GameObject favorite_Button = MenuContent.Screens_1.Avatar_2.Favorite_Button;
					this.Button = Object.Instantiate<GameObject>(favorite_Button, favorite_Button.transform.parent);
					break;
				}
				case MenuButtonType.HeaderButton:
				{
					GameObject worldsPageTab = MenuButton.WorldsPageTab;
					this.Button = Object.Instantiate<GameObject>(worldsPageTab, worldsPageTab.transform.parent);
					break;
				}
				default:
				{
					GameObject favorite_Button2 = MenuContent.Screens_1.Avatar_2.Favorite_Button;
					this.Button = Object.Instantiate<GameObject>(favorite_Button2, favorite_Button2.transform.parent);
					break;
				}
				}
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
					this.Button.transform.SetParent(MenuButton.UserInfoPage.transform);
					goto IL_181;
				case MenuType.AvatarMenu:
					this.Button.transform.SetParent(MenuButton.AvatarPage.transform);
					goto IL_181;
				case MenuType.SettingsMenu:
					this.Button.transform.SetParent(MenuButton.SettingsPage.transform);
					goto IL_181;
				case MenuType.SocialMenu:
					this.Button.transform.SetParent(MenuButton.SocialPage.transform);
					goto IL_181;
				case MenuType.WorldMenu:
					this.Button.transform.SetParent(MenuButton.WorldsPage.transform);
					goto IL_181;
				}
				this.Button.transform.SetParent(MenuButton.UserInfoPage.transform);
				IL_181:;
			}
			catch (Exception)
			{
				throw;
			}
			foreach (Text text2 in this.Button.GetComponentsInChildren<Text>(true))
			{
				text2.text = "";
			}
			foreach (Image image in this.Button.GetComponentsInChildren<Image>(true))
			{
				bool flag = image.name.ToLower().Contains("icon");
				if (flag)
				{
					Object.Destroy(image);
				}
			}
			this.Button.GetComponentInChildren<Text>().text = text;
			this.Button.name = text;
			this.Button.GetComponentInChildren<Button>().onClick = new Button.ButtonClickedEvent();
			this.Button.GetComponentInChildren<Button>().onClick.AddListener(listener);
			this.Button.GetComponentInChildren<Button>().m_Interactable = true;
			this.Button.GetComponent<RectTransform>().anchoredPosition = new Vector2(x_pos, y_pos);
			this.Button.GetComponent<RectTransform>().sizeDelta += new Vector2(xSize, ySize);
			this.Button.name = string.Format("MenuButton_{0}_{1}_{2}", text, x_pos, y_pos);
			this.Button.SetActive(true);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00017828 File Offset: 0x00015A28
		public MenuButton(Transform Parent, MenuButtonType buttontype, string text, float x_pos, float y_pos, Action listener, float xSize, float ySize)
		{
			try
			{
				switch (buttontype)
				{
				case MenuButtonType.PlaylistButton:
				{
					GameObject playlistsButton = MenuContent.Screens_1.UserInfo_2.Buttons_3.RightSideButtons_4.RightUpperButtonColumn_5.PlaylistsButton;
					this.Button = Object.Instantiate<GameObject>(playlistsButton, playlistsButton.transform);
					break;
				}
				case MenuButtonType.AvatarFavButton:
				{
					GameObject favorite_Button = MenuContent.Screens_1.Avatar_2.Favorite_Button;
					this.Button = Object.Instantiate<GameObject>(favorite_Button, favorite_Button.transform.parent);
					break;
				}
				case MenuButtonType.HeaderButton:
				{
					GameObject worldsPageTab = MenuButton.WorldsPageTab;
					this.Button = Object.Instantiate<GameObject>(worldsPageTab, worldsPageTab.transform.parent);
					break;
				}
				default:
				{
					GameObject favorite_Button2 = MenuContent.Screens_1.Avatar_2.Favorite_Button;
					this.Button = Object.Instantiate<GameObject>(favorite_Button2, favorite_Button2.transform.parent);
					break;
				}
				}
				this.Button.transform.SetParent(Parent);
				foreach (Text text2 in this.Button.GetComponentsInChildren<Text>(true))
				{
					text2.text = "";
				}
				foreach (Image image in this.Button.GetComponentsInChildren<Image>(true))
				{
					bool flag = image.name.ToLower().Contains("icon");
					if (flag)
					{
						Object.Destroy(image);
					}
				}
				this.Button.GetComponentInChildren<Text>().text = text;
				this.Button.GetComponentInChildren<Button>().onClick = new Button.ButtonClickedEvent();
				this.Button.GetComponentInChildren<Button>().onClick.AddListener(listener);
				this.Button.GetComponentInChildren<Button>().m_Interactable = true;
				this.Button.GetComponent<RectTransform>().anchoredPosition = new Vector2(x_pos, y_pos);
				Il2CppReferenceArray<Component> componentsInChildren = this.Button.GetComponentsInChildren(Il2CppType.Of<Image>());
				this.Button.GetComponent<RectTransform>().sizeDelta += new Vector2(xSize, ySize);
				this.Button.name = text;
			}
			catch (Exception)
			{
				throw;
			}
			this.Button.SetActive(true);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00017AA0 File Offset: 0x00015CA0
		public MenuButton(Transform Parent, GameObject Tmeplate, string text, float x_pos, float y_pos, Action listener, float xSize, float ySize)
		{
			try
			{
				this.Button = Object.Instantiate<GameObject>(Tmeplate, Tmeplate.transform.parent);
				this.Button.transform.SetParent(Parent);
				foreach (Text text2 in this.Button.GetComponentsInChildren<Text>(true))
				{
					text2.text = "";
				}
				foreach (Image image in this.Button.GetComponentsInChildren<Image>(true))
				{
					bool flag = image.name.ToLower().Contains("icon");
					if (flag)
					{
						Object.Destroy(image);
					}
				}
				this.Button.GetComponentInChildren<Text>().text = text;
				this.Button.GetComponentInChildren<Button>().onClick = new Button.ButtonClickedEvent();
				this.Button.GetComponentInChildren<Button>().onClick.AddListener(listener);
				this.Button.GetComponentInChildren<Button>().m_Interactable = true;
				this.Button.GetComponent<RectTransform>().anchoredPosition = new Vector2(x_pos, y_pos);
				Il2CppReferenceArray<Component> componentsInChildren = this.Button.GetComponentsInChildren(Il2CppType.Of<Image>());
				this.Button.GetComponent<RectTransform>().sizeDelta += new Vector2(xSize, ySize);
				this.Button.name = text;
			}
			catch (Exception)
			{
				throw;
			}
			this.Button.SetActive(true);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00017C8C File Offset: 0x00015E8C
		public MenuButton(Transform Parent, MenuButtonType buttontype, string text, float x_pos, float y_pos, Action listener)
		{
			try
			{
				switch (buttontype)
				{
				case MenuButtonType.PlaylistButton:
				{
					GameObject playlistsButton = MenuContent.Screens_1.UserInfo_2.Buttons_3.RightSideButtons_4.RightUpperButtonColumn_5.PlaylistsButton;
					this.Button = Object.Instantiate<GameObject>(playlistsButton, playlistsButton.transform);
					break;
				}
				case MenuButtonType.AvatarFavButton:
				{
					GameObject favorite_Button = MenuContent.Screens_1.Avatar_2.Favorite_Button;
					this.Button = Object.Instantiate<GameObject>(favorite_Button, favorite_Button.transform.parent);
					break;
				}
				case MenuButtonType.HeaderButton:
				{
					GameObject worldsPageTab = MenuButton.WorldsPageTab;
					this.Button = Object.Instantiate<GameObject>(worldsPageTab, worldsPageTab.transform.parent);
					break;
				}
				default:
					throw new ArgumentOutOfRangeException("buttontype", buttontype, null);
				}
				this.Button.transform.SetParent(Parent);
				this.Button.name = text;
				foreach (Text text2 in this.Button.GetComponentsInChildren<Text>(true))
				{
					text2.text = "";
				}
				foreach (Image image in this.Button.GetComponentsInChildren<Image>(true))
				{
					bool flag = image.name.ToLower().Contains("icon");
					if (flag)
					{
						Object.Destroy(image);
					}
				}
				this.Button.GetComponentInChildren<Text>().text = text;
				this.Button.GetComponentInChildren<Button>().onClick = new Button.ButtonClickedEvent();
				this.Button.GetComponentInChildren<Button>().onClick.AddListener(listener);
				this.Button.GetComponentInChildren<Button>().m_Interactable = true;
				this.Button.GetComponent<RectTransform>().anchoredPosition = new Vector2(x_pos, y_pos);
				this.Button.name = string.Format("MenuButton_{0}_{1}_{2}", text, x_pos, y_pos);
			}
			catch (Exception)
			{
				throw;
			}
			this.Button.SetActive(true);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00017EE0 File Offset: 0x000160E0
		public void SetPos(float x, float y)
		{
			this.Button.GetComponent<RectTransform>().anchoredPosition += new Vector2(x, y);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00017F06 File Offset: 0x00016106
		public void SetSize(float x, float y)
		{
			this.Button.GetComponent<RectTransform>().sizeDelta += new Vector2(x, y);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00017F2C File Offset: 0x0001612C
		public void SetText(string Text)
		{
			this.Button.GetComponentInChildren<Text>().text = Text;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00017F41 File Offset: 0x00016141
		public void SetAction(Action listener)
		{
			this.Button.GetComponentInChildren<Button>().onClick = new Button.ButtonClickedEvent();
			this.Button.GetComponentInChildren<Button>().onClick.AddListener(listener);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00017F76 File Offset: 0x00016176
		public void Delete()
		{
			Object.Destroy(this.Button);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00017F85 File Offset: 0x00016185
		public void SetActive(bool value)
		{
			this.Button.SetActive(value);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00017F95 File Offset: 0x00016195
		public void SetBackgroundColor(Color color)
		{
			this.Button.GetComponentInChildren<Image>().color = color;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00017FAA File Offset: 0x000161AA
		public void SetTextColor(Color color)
		{
			this.Button.GetComponentInChildren<Text>().color = color;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00017FBF File Offset: 0x000161BF
		public void SetInteractable(bool result)
		{
			this.Button.GetComponentInChildren<Button>().interactable = result;
		}

		// Token: 0x040001AB RID: 427
		internal static GameObject WorldsPageTab = GameObject.Find("/UserInterface/MenuContent/Screens/Worlds");

		// Token: 0x040001AC RID: 428
		internal static GameObject UserInfoPage = GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo");

		// Token: 0x040001AD RID: 429
		internal static GameObject AvatarPage = GameObject.Find("/UserInterface/MenuContent/Screens/Avatar");

		// Token: 0x040001AE RID: 430
		internal static GameObject SettingsPage = GameObject.Find("/UserInterface/MenuContent/Screens/Settings");

		// Token: 0x040001AF RID: 431
		internal static GameObject SocialPage = GameObject.Find("/UserInterface/MenuContent/Screens/Social");

		// Token: 0x040001B0 RID: 432
		internal static GameObject WorldsPage = GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo");

		// Token: 0x040001B1 RID: 433
		public GameObject Button;
	}
}
