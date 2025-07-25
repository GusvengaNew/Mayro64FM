using System;
using UnityEngine;
using UnityEngine.AI;

// Token: 0x02000091 RID: 145
public class Wander : MonoBehaviour
{
	// Token: 0x060001F8 RID: 504 RVA: 0x0000DA2E File Offset: 0x0000BE2E
	public Wander()
	{
	}

	// Token: 0x060001F9 RID: 505 RVA: 0x0000DA4C File Offset: 0x0000BE4C
	private void Start()
	{
		this.ChangeDirection();
	}

	// Token: 0x060001FA RID: 506 RVA: 0x0000DA54 File Offset: 0x0000BE54
	private void Update()
	{
		this.directionTime -= Time.deltaTime;
		if (this.directionTime <= 0f)
		{
			this.ChangeDirection();
			this.directionTime = 5f;
		}
		this.rb.velocity = this.direction * this.speed;
	}

	// Token: 0x060001FB RID: 507 RVA: 0x0000DAB0 File Offset: 0x0000BEB0
	private void ChangeDirection()
	{
		this.direction.x = UnityEngine.Random.Range(-1f, 1f);
		this.direction.z = UnityEngine.Random.Range(-1f, 1f);
		this.direction = this.direction.normalized;
	}

	// Token: 0x040002C2 RID: 706
	public float directionTime = 10f;

	// Token: 0x040002C3 RID: 707
	public Vector3 direction;

	// Token: 0x040002C4 RID: 708
	public float speed = 10f;

	// Token: 0x040002C5 RID: 709
	[SerializeField]
	public NavMeshAgent rb;
}
