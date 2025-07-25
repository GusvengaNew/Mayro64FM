using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000E4 RID: 228
public class Discord : MonoBehaviour
{
	// Token: 0x060003AE RID: 942 RVA: 0x00020E78 File Offset: 0x0001F278
	public Discord()
	{
	}

	// Token: 0x060003AF RID: 943 RVA: 0x00020E80 File Offset: 0x0001F280
	private void Start()
	{
		this.button = base.GetComponent<Button>();
	}

	// Token: 0x060003B0 RID: 944 RVA: 0x00020E8E File Offset: 0x0001F28E
	public void OpenLink()
	{
		Application.OpenURL("https://discord.gg/aq9PBfv7xJ");
		Application.Quit();
	}

	// Token: 0x04000687 RID: 1671
	private Button button;
}
