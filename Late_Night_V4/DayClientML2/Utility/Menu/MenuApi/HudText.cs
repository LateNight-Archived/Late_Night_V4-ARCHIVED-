using System;
using System.Collections;
using MelonLoader;
using UnityEngine;
using UnityEngine.UI;

namespace DayClientML2.Utility.Menu.MenuApi
{
	// Token: 0x0200005B RID: 91
	public class HudText
	{
		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600034F RID: 847 RVA: 0x00019E7C File Offset: 0x0001807C
		// (set) Token: 0x06000350 RID: 848 RVA: 0x00019E84 File Offset: 0x00018084
		public GameObject GameObject { get; set; }

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000351 RID: 849 RVA: 0x00019E8D File Offset: 0x0001808D
		// (set) Token: 0x06000352 RID: 850 RVA: 0x00019E95 File Offset: 0x00018095
		public Text Text { get; set; }

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000353 RID: 851 RVA: 0x00019E9E File Offset: 0x0001809E
		// (set) Token: 0x06000354 RID: 852 RVA: 0x00019EA6 File Offset: 0x000180A6
		public Image Image { get; set; }

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000355 RID: 853 RVA: 0x00019EAF File Offset: 0x000180AF
		// (set) Token: 0x06000356 RID: 854 RVA: 0x00019EB7 File Offset: 0x000180B7
		public bool Reactive { get; set; } = true;

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000357 RID: 855 RVA: 0x00019EC0 File Offset: 0x000180C0
		// (set) Token: 0x06000358 RID: 856 RVA: 0x00019EC8 File Offset: 0x000180C8
		public float FadeDelay { get; set; } = 2f;

		// Token: 0x06000359 RID: 857 RVA: 0x00019ED4 File Offset: 0x000180D4
		public HudText(string text, float Rightoffset, float VerticalOffset, TextAnchor anchor = 7)
		{
			this.Image = HudText.CreateImage(string.Format("HUD_Text_{0}_{1}_{2}", text, Rightoffset, VerticalOffset));
			this.Text = this.CreateTextNear(this.Image, Rightoffset, VerticalOffset, anchor);
			this.Text.text = text;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00019F54 File Offset: 0x00018154
		public void SetText(string text)
		{
			this.SetActive(true);
			this.Text.text = text;
			this.Updated();
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00019F73 File Offset: 0x00018173
		public void SetPos(float Rightoffset, float VerticalOffset)
		{
			this.GameObject.transform.localPosition = this.DefaultPosition + Vector3.up * VerticalOffset + Vector3.right * Rightoffset;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00019FAD File Offset: 0x000181AD
		public void SetActive(bool enabled)
		{
			this.GameObject.SetActive(enabled);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00019FBD File Offset: 0x000181BD
		public void Destroy()
		{
			Object.Destroy(this.Text);
			Object.Destroy(this.Image);
			Object.Destroy(this.GameObject);
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00019FE4 File Offset: 0x000181E4
		private void Updated()
		{
			bool flag = !this.Reactive;
			if (!flag)
			{
				bool flag2 = this.UpdateCourtine == null;
				if (flag2)
				{
					this.UpdateCourtine = MelonCoroutines.Start(this.Update(this.FadeDelay));
				}
				else
				{
					this.time = 0f;
				}
			}
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0001A033 File Offset: 0x00018233
		private IEnumerator Update(float Time)
		{
			this.time = 0f;
			for (;;)
			{
				this.time += Time.deltaTime;
				bool flag = this.time > Time;
				if (flag)
				{
					break;
				}
				yield return new WaitForEndOfFrame();
			}
			this.time = 0f;
			this.SetActive(false);
			this.UpdateCourtine = null;
			yield break;
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000360 RID: 864 RVA: 0x0001A049 File Offset: 0x00018249
		// (set) Token: 0x06000361 RID: 865 RVA: 0x0001A051 File Offset: 0x00018251
		private Vector3 DefaultPosition { get; set; }

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000362 RID: 866 RVA: 0x0001A05A File Offset: 0x0001825A
		// (set) Token: 0x06000363 RID: 867 RVA: 0x0001A062 File Offset: 0x00018262
		private float time { get; set; } = 0f;

		// Token: 0x06000364 RID: 868 RVA: 0x0001A06C File Offset: 0x0001826C
		private static Image CreateImage(string name)
		{
			GameObject gameObject = GameObject.Find("UserInterface/UnscaledUI/HudContent/Hud");
			Transform transform = gameObject.transform.Find("NotificationDotParent");
			GameObject gameObject2 = Object.Instantiate<GameObject>(gameObject.transform.Find("NotificationDotParent/NotificationDot").gameObject, transform, false).Cast<GameObject>();
			gameObject2.name = "NotifyDot-" + name;
			gameObject2.SetActive(true);
			Image component = gameObject2.GetComponent<Image>();
			component.enabled = false;
			return component;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0001A0E8 File Offset: 0x000182E8
		private Text CreateTextNear(Component image, float Rightoffset, float Verticaloffset, TextAnchor alignment)
		{
			this.GameObject = new GameObject(image.gameObject.name + "-text");
			this.GameObject.AddComponent<Text>();
			this.GameObject.transform.SetParent(image.transform, false);
			this.GameObject.transform.localScale = Vector3.one;
			this.DefaultPosition = this.GameObject.transform.localPosition;
			this.GameObject.transform.localPosition = Vector3.up * Verticaloffset + Vector3.right * Rightoffset;
			Text component = this.GameObject.GetComponent<Text>();
			component.color = Color.white;
			component.fontStyle = 1;
			component.horizontalOverflow = 1;
			component.verticalOverflow = 1;
			component.alignment = alignment;
			component.fontSize = 30;
			component.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
			component.supportRichText = true;
			this.GameObject.SetActive(true);
			return component;
		}

		// Token: 0x040001D7 RID: 471
		private object UpdateCourtine = null;
	}
}
