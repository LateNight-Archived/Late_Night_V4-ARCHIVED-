using System;
using UnityEngine;
using UnityEngine.UI;

namespace DayClientML2.Utility.Menu
{
	// Token: 0x0200005A RID: 90
	internal class UnityUIUtils
	{
		// Token: 0x020000BE RID: 190
		public class Scroll
		{
			// Token: 0x170001C6 RID: 454
			// (get) Token: 0x06000794 RID: 1940 RVA: 0x00025509 File Offset: 0x00023709
			// (set) Token: 0x06000795 RID: 1941 RVA: 0x00025511 File Offset: 0x00023711
			public GameObject Scroll_View { get; set; }

			// Token: 0x170001C7 RID: 455
			// (get) Token: 0x06000796 RID: 1942 RVA: 0x0002551A File Offset: 0x0002371A
			// (set) Token: 0x06000797 RID: 1943 RVA: 0x00025522 File Offset: 0x00023722
			public ScrollRect ScrollRect { get; set; }

			// Token: 0x170001C8 RID: 456
			// (get) Token: 0x06000798 RID: 1944 RVA: 0x0002552B File Offset: 0x0002372B
			// (set) Token: 0x06000799 RID: 1945 RVA: 0x00025533 File Offset: 0x00023733
			public GameObject ViewPort { get; set; }

			// Token: 0x170001C9 RID: 457
			// (get) Token: 0x0600079A RID: 1946 RVA: 0x0002553C File Offset: 0x0002373C
			// (set) Token: 0x0600079B RID: 1947 RVA: 0x00025544 File Offset: 0x00023744
			public GameObject Content { get; set; }

			// Token: 0x0600079C RID: 1948 RVA: 0x00025550 File Offset: 0x00023750
			public Scroll(Transform parentTransform, float viewWidth, float viewHeight, float maxWidth, float maxHeight, bool scrollHorizontally, bool scrollVertically)
			{
				this.Scroll_View = new GameObject("Scroll View");
				this.Scroll_View.AddComponent<RectTransform>();
				this.ScrollRect = this.Scroll_View.AddComponent<ScrollRect>();
				this.Scroll_View.transform.SetParent(parentTransform);
				this.Scroll_View.transform.localScale = Vector3.one;
				this.Scroll_View.transform.localRotation = Quaternion.identity;
				this.Scroll_View.transform.localPosition = Vector3.zero;
				this.Scroll_View.GetComponent<RectTransform>().sizeDelta = new Vector2(viewWidth, viewHeight);
				this.Scroll_View.GetComponent<ScrollRect>().horizontal = scrollHorizontally;
				this.Scroll_View.GetComponent<ScrollRect>().vertical = scrollVertically;
				this.Scroll_View.layer = parentTransform.gameObject.layer;
				this.ViewPort = new GameObject("Viewport");
				this.ViewPort.AddComponent<RectTransform>();
				this.ViewPort.AddComponent<Image>();
				this.ViewPort.AddComponent<Mask>();
				this.ViewPort.transform.SetParent(this.Scroll_View.transform);
				this.ViewPort.transform.localScale = Vector3.one;
				this.ViewPort.transform.localRotation = Quaternion.identity;
				this.ViewPort.transform.localPosition = Vector3.zero;
				this.ViewPort.GetComponent<RectTransform>().sizeDelta = new Vector2(viewWidth, viewHeight);
				this.ViewPort.layer = this.Scroll_View.layer;
				this.ViewPort.GetComponent<Mask>().showMaskGraphic = false;
				this.Content = new GameObject("Content");
				this.Content.AddComponent<RectTransform>();
				this.Content.transform.SetParent(this.ViewPort.transform);
				this.Content.transform.localScale = Vector3.one;
				this.Content.transform.localRotation = Quaternion.identity;
				this.Content.transform.localPosition = Vector3.zero;
				this.Content.GetComponent<RectTransform>().sizeDelta = new Vector2(scrollHorizontally ? maxWidth : 0f, scrollVertically ? maxHeight : 0f);
				this.Content.GetComponent<RectTransform>().anchorMin = new Vector2((float)(scrollHorizontally ? 1 : 0), (float)(scrollVertically ? 1 : 0));
				this.Content.GetComponent<RectTransform>().anchorMax = new Vector2(1f, 1f);
				this.Content.GetComponent<RectTransform>().pivot = new Vector2(0f, 1f);
				this.Content.layer = this.ViewPort.layer;
				this.Scroll_View.GetComponent<ScrollRect>().content = this.Content.GetComponent<RectTransform>();
				this.Scroll_View.GetComponent<ScrollRect>().viewport = this.ViewPort.GetComponent<RectTransform>();
			}

			// Token: 0x170001CA RID: 458
			// (get) Token: 0x0600079D RID: 1949 RVA: 0x00025873 File Offset: 0x00023A73
			// (set) Token: 0x0600079E RID: 1950 RVA: 0x00025885 File Offset: 0x00023A85
			public Vector2 MaxWH
			{
				get
				{
					return this.Content.GetComponent<RectTransform>().sizeDelta;
				}
				set
				{
					this.Content.GetComponent<RectTransform>().sizeDelta = value;
				}
			}
		}
	}
}
