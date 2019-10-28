using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class SampleNavMeshAgent : MonoBehaviour {

	public Transform target;
	NavMeshAgent agent;

	public float proximidad;

	Animator animator;
	void Start () {
		agent = GetComponent<NavMeshAgent>();
		agent.autoBraking = false;
		animator = target.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		agent.SetDestination(target.position);

		if (!agent.pathPending && agent.remainingDistance < proximidad){
			Debug.Log("Peligro");
			animator.SetBool("EstaEnPeligro", true);	
		}
		else {
			Debug.Log("Tranquilo");
			animator.SetBool("EstaEnPeligro",false);
		}

	}
}
