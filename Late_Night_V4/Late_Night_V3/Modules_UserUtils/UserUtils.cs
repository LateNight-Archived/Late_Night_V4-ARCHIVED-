using System;
using System.Diagnostics;
using DayClientML2.Utility.Extensions;
using Late_Night_V2_lewd;
using Late_Night_V2_popshit;
using Late_Night_V2_wrappers;
using Late_Night_V3.Modules_Funny;
using Late_Night_V3_AviFave;
using Late_Night_V3_colnsole;
using Late_Night_V3_Config_AVI_FAVE;
using UnityEngine;
using UnityEngine.SceneManagement;
using VRC;
using VRC.Core;
using XButtonAPI;

namespace Late_Night_V3.Modules_UserUtils
{
	// Token: 0x02000022 RID: 34
	internal class UserUtils
	{
		// Token: 0x06000176 RID: 374 RVA: 0x0000E2FC File Offset: 0x0000C4FC
		internal static void UserUtils_menu(QMNestedButton Submenu2, QMCategory Submenu)
		{
			Submenu2.AddButton("Teleport", "Teleport", delegate
			{
				bool flag = PlayerWrapper.GetSelectedPlayer(false) == null;
				if (!flag)
				{
					UserUtils.GetLocalPlayer().transform.position = PlayerWrapper.GetSelectedPlayer(false).gameObject.transform.position;
				}
			}, null);
			Submenu2.AddToggle("Focus user", "Focus user", delegate(bool B)
			{
				bool flag = PlayerWrapper.GetSelectedPlayer(false) == null;
				if (!flag)
				{
					if (B)
					{
						string b = PlayerWrapper.GetSelectedPlayer(false).UserID();
						foreach (GameObject gameObject in Funny.GetAllGameObjects())
						{
							bool flag2 = gameObject.name.StartsWith("VRCPlayer[Remote]");
							if (flag2)
							{
								bool flag3 = PlayerWrapper.GetCurrentPlayer().UserID() == b;
								if (!flag3)
								{
									bool flag4 = !(gameObject.GetComponent<VRCPlayer>().UserID() == b);
									if (flag4)
									{
										gameObject.GetComponent<Player>()._USpeaker.field_Private_SimpleAudioGain_0.field_Public_Single_0 = 1f;
									}
								}
							}
						}
					}
					else
					{
						string text = PlayerWrapper.GetSelectedPlayer(false).UserID();
						foreach (GameObject gameObject2 in Funny.GetAllGameObjects())
						{
							bool flag5 = gameObject2.name.StartsWith("VRCPlayer[Remote]");
							if (flag5)
							{
								gameObject2.GetComponent<Player>()._USpeaker.field_Private_SimpleAudioGain_0.field_Public_Single_0 = 6f;
							}
						}
					}
				}
			}, false);
			QMNestedButton qmnestedButton = Submenu.AddMenuPage("Avi utils", "Avi utils", "avi shit", false, null);
			qmnestedButton.AddButton("Quick Favorites", "Quick Favorites", delegate
			{
				bool flag = PlayerWrapper.GetSelectedPlayer(false) == null;
				if (!flag)
				{
					ApiAvatar apiAvatar = PlayerWrapper.GetSelectedPlayer(false).Method_Public_get_ApiAvatar_0();
					bool flag2 = apiAvatar.releaseStatus != "private";
					if (flag2)
					{
						AviFave.FaveAvi(apiAvatar, 1);
						Config_AVI_FAVE.Instance.SaveConfig_AVIS_FAVE();
					}
					else
					{
						LNCcolnsole.Log("!!!YOU CANT FAV A PRIVATE AVATAR!!!", true, ConsoleColor.Red);
					}
				}
			}, null);
			qmnestedButton.AddButton("Force Clone", "Force Clone", delegate
			{
				bool flag = PlayerWrapper.GetSelectedPlayer(false) == null;
				if (!flag)
				{
					Player selectedPlayer = PlayerWrapper.GetSelectedPlayer(false);
					string id = selectedPlayer.Method_Internal_get_VRCPlayer_0().Method_Public_get_ApiAvatar_0().id;
					bool flag2 = selectedPlayer.Method_Internal_get_VRCPlayer_0().Method_Public_get_ApiAvatar_0().releaseStatus != "private";
					if (flag2)
					{
						LNCcolnsole.Log("Force Cloning avatar with ID: " + id, false, ConsoleColor.Green);
						popshit.avatarbyid(id);
					}
					else
					{
						LNCcolnsole.Log("!!!YOU CANT CLONE A PRIVATE AVATAR!!!", false, ConsoleColor.Red);
					}
				}
			}, null);
			qmnestedButton.AddButton("Reload player", "Reload player", delegate
			{
				bool flag = PlayerWrapper.GetSelectedPlayer(false) == null;
				if (!flag)
				{
					Player selectedPlayer = PlayerWrapper.GetSelectedPlayer(false);
					selectedPlayer.ReloadAvatar();
				}
			}, null);
			qmnestedButton.AddButton("VRCA download", "VRCA download", delegate
			{
				bool flag = PlayerWrapper.GetSelectedPlayer(false) == null;
				if (!flag)
				{
					Process.Start(PlayerWrapper.GetSelectedPlayer(false).Method_Public_get_ApiAvatar_0().assetUrl);
					Process.Start(PlayerWrapper.GetSelectedPlayer(false).Method_Public_get_ApiAvatar_0().imageUrl);
					LNCcolnsole.Log("Avi Asset url : " + PlayerWrapper.GetSelectedPlayer(false).Method_Public_get_ApiAvatar_0().assetUrl, false, ConsoleColor.Cyan);
					LNCcolnsole.Log("Avi Inage url : " + PlayerWrapper.GetSelectedPlayer(false).Method_Public_get_ApiAvatar_0().imageUrl, false, ConsoleColor.Cyan);
				}
			}, null);
			qmnestedButton.AddButton("Avatar id to clipboard", "Avatar id to clipboard", delegate
			{
				bool flag = PlayerWrapper.GetSelectedPlayer(false) == null;
				if (!flag)
				{
					popshit.SetClipboard(PlayerWrapper.GetSelectedPlayer(false).Method_Public_get_ApiAvatar_0().id);
					LNCcolnsole.Log("Avi id is : " + PlayerWrapper.GetSelectedPlayer(false).Method_Public_get_ApiAvatar_0().id, false, ConsoleColor.Cyan);
				}
			}, null);
			qmnestedButton.AddButton("Particles Deleter", "Particles Deleter", delegate
			{
				bool flag = PlayerWrapper.GetSelectedPlayer(false) == null;
				if (!flag)
				{
					string b = PlayerWrapper.GetSelectedPlayer(false).UserID();
					Player selectedPlayer = PlayerWrapper.GetSelectedPlayer(false);
					string text = selectedPlayer.UserID();
					GameObject field_Internal_GameObject_ = selectedPlayer.Method_Internal_get_VRCPlayer_0().field_Internal_GameObject_0;
					bool flag2 = PlayerWrapper.GetCurrentPlayer().UserID() == b;
					if (flag2)
					{
						GameObject localPlayer = UserUtils.GetLocalPlayer();
						GameObject playerMirrFix = UserUtils.GetPlayerMirrFix();
						GameObject playerMirrFix2 = UserUtils.GetPlayerMirrFix2();
						localPlayer.ByePart();
						playerMirrFix.ByePart();
						playerMirrFix2.ByePart();
					}
					else
					{
						field_Internal_GameObject_.ByePart();
					}
					LNCcolnsole.Log("Particles Deleted", false, ConsoleColor.Green);
				}
			}, null);
			qmnestedButton.AddButton("Audio Deleter", "Audio Deleter", delegate
			{
				bool flag = PlayerWrapper.GetSelectedPlayer(false) == null;
				if (!flag)
				{
					string b = PlayerWrapper.GetSelectedPlayer(false).UserID();
					Player selectedPlayer = PlayerWrapper.GetSelectedPlayer(false);
					string text = selectedPlayer.UserID();
					GameObject field_Internal_GameObject_ = selectedPlayer.Method_Internal_get_VRCPlayer_0().field_Internal_GameObject_0;
					bool flag2 = PlayerWrapper.GetCurrentPlayer().UserID() == b;
					if (flag2)
					{
						GameObject localPlayer = UserUtils.GetLocalPlayer();
						GameObject playerMirrFix = UserUtils.GetPlayerMirrFix();
						GameObject playerMirrFix2 = UserUtils.GetPlayerMirrFix2();
						localPlayer.ByeSound();
						playerMirrFix.ByeSound();
						playerMirrFix2.ByeSound();
					}
					else
					{
						field_Internal_GameObject_.ByeSound();
					}
					LNCcolnsole.Log("Audio Deleted", false, ConsoleColor.Green);
				}
			}, null);
			qmnestedButton.AddButton("Force lewd", "Force lewd", delegate
			{
				bool flag = PlayerWrapper.GetSelectedPlayer(false) == null;
				if (!flag)
				{
					string b = PlayerWrapper.GetSelectedPlayer(false).UserID();
					Player selectedPlayer = PlayerWrapper.GetSelectedPlayer(false);
					string text = selectedPlayer.UserID();
					GameObject field_Internal_GameObject_ = selectedPlayer.Method_Internal_get_VRCPlayer_0().field_Internal_GameObject_0;
					bool flag2 = PlayerWrapper.GetCurrentPlayer().UserID() == b;
					if (flag2)
					{
						GameObject localPlayer = UserUtils.GetLocalPlayer();
						GameObject playerMirrFix = UserUtils.GetPlayerMirrFix();
						GameObject playerMirrFix2 = UserUtils.GetPlayerMirrFix2();
						localPlayer.Lewdify();
						playerMirrFix.Lewdify();
						playerMirrFix2.Lewdify();
					}
					else
					{
						field_Internal_GameObject_.Lewdify();
					}
				}
			}, null);
			qmnestedButton.AddButton("Avis info to clipboard", "Avis info to clipboard", delegate
			{
				bool flag = PlayerWrapper.GetSelectedPlayer(false) == null;
				if (!flag)
				{
					string text = string.Concat(new string[]
					{
						"Name Of Avatar : ",
						PlayerWrapper.GetSelectedPlayer(false).Method_Public_get_ApiAvatar_0().name,
						"\nName Of Author : ",
						PlayerWrapper.GetSelectedPlayer(false).Method_Public_get_ApiAvatar_0().authorName,
						"\nRelease Status : ",
						PlayerWrapper.GetSelectedPlayer(false).Method_Public_get_ApiAvatar_0().releaseStatus,
						"\nSupported Platforms : ",
						PlayerWrapper.GetSelectedPlayer(false).Method_Public_get_ApiAvatar_0().supportedPlatforms.ToString(),
						"\nAvatar Id : ",
						PlayerWrapper.GetSelectedPlayer(false).Method_Public_get_ApiAvatar_0().id,
						"\nAsset Url : ",
						PlayerWrapper.GetSelectedPlayer(false).Method_Public_get_ApiAvatar_0().assetUrl,
						"\nImage Url : ",
						PlayerWrapper.GetSelectedPlayer(false).Method_Public_get_ApiAvatar_0().imageUrl,
						"\nAuthor iD : ",
						PlayerWrapper.GetSelectedPlayer(false).Method_Public_get_ApiAvatar_0().authorId
					});
					popshit.SetClipboard(text);
					LNCcolnsole.Log("Info Copied \n" + text, false, ConsoleColor.Cyan);
				}
			}, null);
			qmnestedButton.AddButton("Get Mesh names to clipboard", "Get Mesh names to clipboard", delegate
			{
				bool flag = PlayerWrapper.GetSelectedPlayer(false) == null;
				if (!flag)
				{
					Player selectedPlayer = PlayerWrapper.GetSelectedPlayer(false);
					GameObject field_Internal_GameObject_ = selectedPlayer.Method_Internal_get_VRCPlayer_0().field_Internal_GameObject_0;
					bool flag2 = field_Internal_GameObject_ != null;
					if (flag2)
					{
						field_Internal_GameObject_.getnames(true);
					}
				}
			}, null);
			qmnestedButton.AddButton("Hide Avi", "Hide Avi", delegate
			{
				bool flag = PlayerWrapper.GetSelectedPlayer(false) == null;
				if (!flag)
				{
					string b = PlayerWrapper.GetSelectedPlayer(false).UserID();
					Player selectedPlayer = PlayerWrapper.GetSelectedPlayer(false);
					string text = selectedPlayer.UserID();
					GameObject field_Internal_GameObject_ = selectedPlayer.Method_Internal_get_VRCPlayer_0().field_Internal_GameObject_0;
					bool flag2 = PlayerWrapper.GetCurrentPlayer().UserID() == b;
					if (flag2)
					{
						LNCcolnsole.Log("cant hide your self", true, ConsoleColor.White);
					}
					else
					{
						field_Internal_GameObject_.SetActive(false);
					}
				}
			}, null);
			qmnestedButton.AddButton("Show Avi", "Show Avi", delegate
			{
				bool flag = PlayerWrapper.GetSelectedPlayer(false) == null;
				if (!flag)
				{
					string b = PlayerWrapper.GetSelectedPlayer(false).UserID();
					Player selectedPlayer = PlayerWrapper.GetSelectedPlayer(false);
					string text = selectedPlayer.UserID();
					GameObject field_Internal_GameObject_ = selectedPlayer.Method_Internal_get_VRCPlayer_0().field_Internal_GameObject_0;
					bool flag2 = PlayerWrapper.GetCurrentPlayer().UserID() == b;
					if (flag2)
					{
						LNCcolnsole.Log("cant hide your self", true, ConsoleColor.White);
					}
					else
					{
						field_Internal_GameObject_.SetActive(true);
					}
				}
			}, null);
			QMNestedButton qmnestedButton2 = qmnestedButton.AddMenuPage("Dyn Tools", "Dyn Tools", "kill me", false, null);
			qmnestedButton2.AddButton("Delete DynamicBone", "Delete DynamicBone", delegate
			{
				bool flag = PlayerWrapper.GetSelectedPlayer(false) == null;
				if (!flag)
				{
					string b = PlayerWrapper.GetSelectedPlayer(false).UserID();
					Player selectedPlayer = PlayerWrapper.GetSelectedPlayer(false);
					string text = selectedPlayer.UserID();
					GameObject field_Internal_GameObject_ = selectedPlayer.Method_Internal_get_VRCPlayer_0().field_Internal_GameObject_0;
					bool flag2 = PlayerWrapper.GetCurrentPlayer().UserID() == b;
					if (flag2)
					{
						GameObject localPlayer = UserUtils.GetLocalPlayer();
						GameObject playerMirrFix = UserUtils.GetPlayerMirrFix();
						GameObject playerMirrFix2 = UserUtils.GetPlayerMirrFix2();
						localPlayer.ByeDynBoneJustBones();
						playerMirrFix.ByeDynBoneJustBones();
						playerMirrFix2.ByeDynBoneJustBones();
					}
					else
					{
						field_Internal_GameObject_.ByeDynBoneJustBones();
					}
				}
			}, null);
			qmnestedButton2.AddButton("Delete DynamicBoneCollider", "Delete DynamicBoneCollider", delegate
			{
				bool flag = PlayerWrapper.GetSelectedPlayer(false) == null;
				if (!flag)
				{
					string b = PlayerWrapper.GetSelectedPlayer(false).UserID();
					Player selectedPlayer = PlayerWrapper.GetSelectedPlayer(false);
					string text = selectedPlayer.UserID();
					GameObject field_Internal_GameObject_ = selectedPlayer.Method_Internal_get_VRCPlayer_0().field_Internal_GameObject_0;
					bool flag2 = PlayerWrapper.GetCurrentPlayer().UserID() == b;
					if (flag2)
					{
						GameObject localPlayer = UserUtils.GetLocalPlayer();
						GameObject playerMirrFix = UserUtils.GetPlayerMirrFix();
						GameObject playerMirrFix2 = UserUtils.GetPlayerMirrFix2();
						localPlayer.ByeDynBoneJustColliders();
						playerMirrFix.ByeDynBoneJustColliders();
						playerMirrFix2.ByeDynBoneJustColliders();
					}
					else
					{
						field_Internal_GameObject_.ByeDynBoneJustColliders();
					}
				}
			}, null);
			qmnestedButton2.AddButton("Delete all  Dynamics", "Delete all  Dynamics", delegate
			{
				bool flag = PlayerWrapper.GetSelectedPlayer(false) == null;
				if (!flag)
				{
					string b = PlayerWrapper.GetSelectedPlayer(false).UserID();
					Player selectedPlayer = PlayerWrapper.GetSelectedPlayer(false);
					string text = selectedPlayer.UserID();
					GameObject field_Internal_GameObject_ = selectedPlayer.Method_Internal_get_VRCPlayer_0().field_Internal_GameObject_0;
					bool flag2 = PlayerWrapper.GetCurrentPlayer().UserID() == b;
					if (flag2)
					{
						GameObject localPlayer = UserUtils.GetLocalPlayer();
						GameObject playerMirrFix = UserUtils.GetPlayerMirrFix();
						GameObject playerMirrFix2 = UserUtils.GetPlayerMirrFix2();
						localPlayer.ByeDynBone();
						playerMirrFix.ByeDynBone();
						playerMirrFix2.ByeDynBone();
					}
					else
					{
						field_Internal_GameObject_.ByeDynBone();
					}
				}
			}, null);
			qmnestedButton2.AddButton("Delete Cloth", "Delete Cloth", delegate
			{
				bool flag = PlayerWrapper.GetSelectedPlayer(false) == null;
				if (!flag)
				{
					string b = PlayerWrapper.GetSelectedPlayer(false).UserID();
					Player selectedPlayer = PlayerWrapper.GetSelectedPlayer(false);
					string text = selectedPlayer.UserID();
					GameObject field_Internal_GameObject_ = selectedPlayer.Method_Internal_get_VRCPlayer_0().field_Internal_GameObject_0;
					bool flag2 = PlayerWrapper.GetCurrentPlayer().UserID() == b;
					if (flag2)
					{
						GameObject localPlayer = UserUtils.GetLocalPlayer();
						GameObject playerMirrFix = UserUtils.GetPlayerMirrFix();
						GameObject playerMirrFix2 = UserUtils.GetPlayerMirrFix2();
						localPlayer.byeCloth();
						playerMirrFix.byeCloth();
						playerMirrFix2.byeCloth();
					}
					else
					{
						field_Internal_GameObject_.byeCloth();
					}
				}
			}, null);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0000E6AC File Offset: 0x0000C8AC
		internal static GameObject GetLocalPlayer()
		{
			foreach (GameObject gameObject in UserUtils.GetAllGameObjects())
			{
				bool flag = gameObject.name.StartsWith("VRCPlayer[Local]");
				if (flag)
				{
					return gameObject;
				}
			}
			return new GameObject();
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000E6F8 File Offset: 0x0000C8F8
		internal static GameObject[] GetAllGameObjects()
		{
			return SceneManager.GetActiveScene().GetRootGameObjects();
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000E71C File Offset: 0x0000C91C
		internal static GameObject GetPlayerMirrFix()
		{
			foreach (GameObject gameObject in UserUtils.GetAllGameObjects())
			{
				bool flag = gameObject.name.StartsWith("_AvatarMirrorClone");
				if (flag)
				{
					return gameObject;
				}
			}
			return new GameObject();
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000E768 File Offset: 0x0000C968
		internal static GameObject GetPlayerMirrFix2()
		{
			foreach (GameObject gameObject in UserUtils.GetAllGameObjects())
			{
				bool flag = gameObject.name.StartsWith("_AvatarShadowClone");
				if (flag)
				{
					return gameObject;
				}
			}
			return new GameObject();
		}
	}
}
