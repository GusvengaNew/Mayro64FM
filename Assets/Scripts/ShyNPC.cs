using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShyNPC : MonoBehaviour
{

	public Transform Player;
	int MoveSpeed = 4;
	int MaxDist = 60;
	int MinDist = 15;




	void Start()
	{

	}

	void Update()
	{

		if (Vector3.Distance(transform.position, Player.position) >= MinDist)
		{

			transform.position += transform.forward * MoveSpeed * Time.deltaTime;



			if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
			{
				//Here Call any function U want Like Shoot at here or something
			}

		}
	}
}
