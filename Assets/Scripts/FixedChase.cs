using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FixedChase : MonoBehaviour {

    [SerializeField] private Transform Player;
    
    private NavMeshAgent navmeshAgent;

    // Get the Component Things
    private void Awake() {
        navmeshAgent = GetComponent<NavMeshAgent>();
    }

    // Follow Something
    private void Update() {
        navmeshAgent.destination = Player.position;
    }

}
