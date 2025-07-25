using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefab: MonoBehaviour
{
	public void InstantiateCaller(GameObject prefab)
	{
		Instantiate(prefab);
	}
}