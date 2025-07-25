using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000E5 RID: 229
public class IntroSplash : MonoBehaviour
{
	// Token: 0x060003B1 RID: 945 RVA: 0x00020EA0 File Offset: 0x0001F2A0
	public IntroSplash()
	{
	}

	// Token: 0x060003B2 RID: 946 RVA: 0x00020F1C File Offset: 0x0001F31C
	public void Start()
	{
		int num = Mathf.RoundToInt(UnityEngine.Random.Range(0f, 29f));
		this.TipText.text = this.Tips[num];
	}

	// Token: 0x060003B3 RID: 947 RVA: 0x00020F64 File Offset: 0x0001F364
	public void Update()
	{
	}

	// Token: 0x060003B4 RID: 948 RVA: 0x00020F66 File Offset: 0x0001F366
	public void PutTip()
	{
	}

	// Token: 0x04000688 RID: 1672
	public Text TipText;

	// Token: 0x04000689 RID: 1673
	private string[] Tips = new string[]
	{
		"Mayrotastic Kompani!",
		"Luggy?.",
		"Randomh Spaslh Teksxt!!",
		"Brign it onh!",
		"Letsa Go!!",
		"Wah Wah Wah!",
		"Hapi Biday Mayro!",
		"Jummy andh noice!.",
		"WAAAAAAAAAAH!",
		"Luggy iz in de kastel koutrjard!",
		"9 + 10 = 21",
		"All Toasters Toast Toast!",
		"Interactive Media!",
		"So much fun!",
		"Wayro?",
		"Is the best!",
		"Full Metal Mayro!",
		"Where's Waluggy?",
		"Mayro Mowee!",
		"Noice!",
		"Happi Birfday To Yu!",
		"Gusvenga!",
		"The Klassik!",
		"No Question!",
		"I never doubted it!",
		"You cannot beat me!",
		"Speen!",
		"I Wonder What's for Dinner!",
		"Hav a Noice Day!",
		"Fsave da Princes!",
		"Vinny Plaiyed dis!",
		"Best Gaemz Kompani!",
		"Lotsa Spaghetti!",
		"When Update?",
		"Kuality Gaemz!",
		"Yez!",
		"Squadala!",
		"Fantaztik!",
		"De Ultimeyt Kompani!",
		"Sampel Teksd!",
		"Enjoay!",
		"Goodie Gaems Kompani!",
	};

	// Token: 0x0400068A RID: 1674
	public RawImage TipImage;

	// Token: 0x0400068B RID: 1675
	public Texture[] TipTexture;
}
