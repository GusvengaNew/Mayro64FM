using System;
using UnityEngine;

// Token: 0x0200000A RID: 10
public class LookAt : MonoBehaviour
{
	// Token: 0x0600002A RID: 42 RVA: 0x00002064 File Offset: 0x00000264
	public LookAt()
	{
	}

	// Token: 0x0600002B RID: 43 RVA: 0x0000226A File Offset: 0x0000046A
	private void Start()
	{
		this.m_Camera = GameObject.Find("Camera").GetComponent<Camera>();
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00003750 File Offset: 0x00001950
	private void LateUpdate()
	{
		base.transform.LookAt(base.transform.position + this.m_Camera.transform.rotation * Vector3.forward, this.m_Camera.transform.rotation * Vector3.up);
	}

	// Token: 0x0400003A RID: 58
	private Camera m_Camera;
}
