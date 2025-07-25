using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoisePlayer : MonoBehaviour {

	// Use this for initialization
	private void Start()
	{
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00003024 File Offset: 0x00001224
	public void PlayAudio()
	{
		int num = Mathf.RoundToInt(UnityEngine.Random.Range(0f, 45f));
		if (!this.audioDevice.isPlaying & num == 0)
		{
			base.transform.position = this.noisegenerator.position;
			int num2 = Mathf.RoundToInt(UnityEngine.Random.Range(0f, (float)(this.sounds.Length - 1)));
			this.audioDevice.PlayOneShot(this.sounds[num2]);
		}
	}

	// Token: 0x04000007 RID: 7
	public Transform noisegenerator;

	// Token: 0x04000008 RID: 8
	public AudioClip[] sounds;

	// Token: 0x04000009 RID: 9
	public AudioSource audioDevice;
}
