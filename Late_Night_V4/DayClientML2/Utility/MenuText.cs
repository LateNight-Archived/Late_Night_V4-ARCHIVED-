using System;
using TMPro;
using UnityEngine;

namespace DayClientML2.Utility
{
	// Token: 0x02000052 RID: 82
	public class MenuText
	{
		// Token: 0x060002BC RID: 700 RVA: 0x00018484 File Offset: 0x00016684
		public MenuText(Transform parent, float posx, float poxy, float ScaleY, float ScaleX, string text, TextAlignmentOptions alignment = 257, int size = 30)
		{
			GameObject gameObject = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/Header_H1/LeftItemContainer/Text_Title");
			this.menuTitle = Object.Instantiate<GameObject>(gameObject, parent);
			this.menuTitle.GetComponent<TextMeshProUGUI>().fontStyle = 0;
			this.menuTitle.GetComponent<TextMeshProUGUI>().alignment = alignment;
			this.menuTitle.GetComponent<TextMeshProUGUI>().text = text;
			this.menuTitle.GetComponent<TextMeshProUGUI>().fontSize = (float)size;
			this.menuTitle.GetComponent<TextMeshProUGUI>().richText = true;
			this.menuTitle.GetComponent<RectTransform>().anchoredPosition = new Vector2(posx, -poxy);
			this.menuTitle.GetComponent<RectTransform>().sizeDelta = new Vector2(ScaleY, ScaleX);
			this.menuTitle.GetComponent<TextMeshProUGUI>().color = Color.white;
			this.Posx = posx;
			this.Posy = -poxy;
			this.Text = text;
			this.menuTitle.name = string.Format("MenuText_{0}_{1}_{2}", text, posx, -this.Posy);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00018599 File Offset: 0x00016799
		public void setactive(bool value)
		{
			this.menuTitle.SetActive(value);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x000185A9 File Offset: 0x000167A9
		public void Delete()
		{
			Object.Destroy(this.menuTitle);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x000185B8 File Offset: 0x000167B8
		public void SetText(string text)
		{
			this.menuTitle.GetComponent<TextMeshProUGUI>().text = text;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x000185CD File Offset: 0x000167CD
		public void SetPos(float x, float y)
		{
			this.Posy = y;
			this.Posx = x;
			this.menuTitle.GetComponent<RectTransform>().anchoredPosition = new Vector2(this.Posx, this.Posy);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00018600 File Offset: 0x00016800
		public void SetColor(float r, float g, float b, float a)
		{
			this.menuTitle.GetComponent<TextMeshProUGUI>().color = new Color(r, g, b, a);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0001861E File Offset: 0x0001681E
		public void SetColor(Color color)
		{
			this.menuTitle.GetComponent<TextMeshProUGUI>().color = color;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00018633 File Offset: 0x00016833
		public void SetFontSize(int size)
		{
			this.menuTitle.GetComponent<TextMeshProUGUI>().fontSize = (float)size;
		}

		// Token: 0x040001BA RID: 442
		public GameObject menuTitle;

		// Token: 0x040001BB RID: 443
		public float Posx;

		// Token: 0x040001BC RID: 444
		public float Posy;

		// Token: 0x040001BD RID: 445
		public string Text;
	}
}
