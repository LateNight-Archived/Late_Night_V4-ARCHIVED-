using System;
using System.Collections;
using Late_Night_config;
using Late_Night_V3_colnsole;
using Late_Night_V3_stayoffnigga;
using MelonLoader;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using VRC.UI.Elements;
using XButtonAPI;

namespace Late_Night_V2_Move_vrc_ui
{
	// Token: 0x02000010 RID: 16
	internal class Move_vrc_ui
	{
		// Token: 0x060000A3 RID: 163 RVA: 0x00005524 File Offset: 0x00003724
		public static void MoveSmallUI()
		{
			try
			{
				GameObject gameObject = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Carousel_Banners");
				gameObject.AddComponent<stayoffnigga>();
			}
			catch
			{
				LNCcolnsole.Log("Failed to find and toggle : Carousel_Banners", false, ConsoleColor.White);
			}
			try
			{
				GameObject gameObject2 = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/ThankYouCharacter");
				gameObject2.AddComponent<stayoffnigga>();
			}
			catch
			{
				LNCcolnsole.Log("Failed to find and toggle : ThankYouCharacter", false, ConsoleColor.White);
			}
			try
			{
				GameObject gameObject3 = GameObject.Find("UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingInfoPanel");
				gameObject3.AddComponent<stayoffnigga>();
			}
			catch
			{
				LNCcolnsole.Log("Failed to find and toggle : LoadingInfoPanel", false, ConsoleColor.White);
			}
			try
			{
				GameObject gameObject4 = GameObject.Find("UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingBackground_TealGradient/SkyCube_Baked");
				gameObject4.AddComponent<stayoffnigga>();
			}
			catch
			{
				LNCcolnsole.Log("Failed to find and toggle : SkyCube_Baked", false, ConsoleColor.White);
			}
			try
			{
				GameObject gameObject5 = GameObject.Find("UserInterface/MenuContent/Backdrop/Backdrop/Background");
				gameObject5.AddComponent<stayoffnigga>();
			}
			catch
			{
				LNCcolnsole.Log("Failed to find and toggle : Big Menu Background", false, ConsoleColor.White);
			}
			UIPage component = QMStuff.Instance.field_Public_Transform_0.Find("Window/QMParent/Menu_Dashboard").GetComponent<UIPage>();
			ScrollRect componentInChildren = component.GetComponentInChildren<ScrollRect>();
			Scrollbar component2 = componentInChildren.transform.Find("Scrollbar").GetComponent<Scrollbar>();
			RectTransform content = componentInChildren.content;
			content.GetComponent<VerticalLayoutGroup>().childControlHeight = true;
			componentInChildren.enabled = true;
			componentInChildren.verticalScrollbar = component2;
			componentInChildren.viewport.GetComponent<RectMask2D>().enabled = true;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000056BC File Offset: 0x000038BC
		public static void StartMus(AudioSource A, string path)
		{
			bool flag = path != "" && Config.Instance.LoadIng_Audio_Enabled;
			if (flag)
			{
				MelonCoroutines.Start(Move_vrc_ui.menuMus(A, path));
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000056F5 File Offset: 0x000038F5
		public static IEnumerator menuMus(AudioSource A, string path)
		{
			UnityWebRequest www = UnityWebRequest.Get(string.Format("file://{0}", path).Replace("\\", "/"));
			www.SendWebRequest();
			while (!www.isDone)
			{
			}
			AudioClip audioClip = WebRequestWWW.InternalCreateAudioClipUsingDH(www.downloadHandler, www.url, false, false, 0);
			A.clip = audioClip;
			A.Stop();
			A.Play();
			yield break;
		}
	}
}
