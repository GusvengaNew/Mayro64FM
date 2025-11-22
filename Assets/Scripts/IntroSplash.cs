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
		int num = Mathf.RoundToInt(UnityEngine.Random.Range(0f, 94f));
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
		"I wonder what's for dinner!",
		"Hav a Noice Day!",
		"Fsave da Princes!",
		"Vinny plaiyed dis!",
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
		"Teto!",
		"Will make ur heart go bang bang!",
		"Grab a Diet Shasta and play!",
		"November 20, 2025 splash text!",
		"Makes you weep!",
		"Makes you spin a green onion!",
		"Nyan nyan ni hao nyan!",
		"Better than that one Japanese company!",
		"Beter than Ubisoft!",
		"Better than Bethesda!",
		"Better than Rockstar Games!",
		"Drink up my vegetable juice!",
		"The American dream!",
		"Let's go bowling!",
		"Occupies your brain!",
		"Freeman!",
		"Minecraft reference?",
		"Doesn't glow in the dark!",
		"Now the flowers will grow!",
		"That's the ticket!",
		"Why is the English not broken?",
		"Better than the Switch 2!",
		"Papa, tutu, tutu, tu wawa!",
		"Still alive!",
		"Have some bird ideas!",
		"Makes you confused!",
		"Is this real?",
		"Swear word here!",
		"No more broken English :(",
		"Owen was... who?",
		"SANDVICH!",
		"Gentlemen?",
		"Has standards!",
		"Obviously grilled!",
		"Steamed!",
		"Not on Steam!",
		"It's yours, my friend!",
		"Polska!",
		"Outta touch!",
		"European classic!",
		"Mistakes into miracles!",
		"Makes you sob!",
		"Sponsored by nothing!",
		"What?",
		"Say that again!",
		"Hold Shift to run!",
		"PoPiPo!",
		"Baka baka baka!",
		"Divine intellect!",
		"Worth the wait!",
		"These things, they take time!",
		"Makes life fumofumo!"
	};

	// Token: 0x0400068A RID: 1674
	public RawImage TipImage;

	// Token: 0x0400068B RID: 1675
	public Texture[] TipTexture;
}
