using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FantomeFugDeTine : MonoBehaviour
{
    private UnityEngine.AI.NavMeshAgent _agent;

    public GameObject Pacman;

    public float DistantaPacman = 20.0f;

    void Start()
    {
        _agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    void Update()
    {

        float distanta = Vector3.Distance(transform.position, Pacman.transform.position);

        //Debug.Log("Distanta =" + distanta);

        //Se indeparteaza de Pacman
        if(distanta < DistantaPacman)
        {
            Vector3 DisPanaLaPacman = transform.position - Pacman.transform.position;

            Vector3 newPos = transform.position + DisPanaLaPacman;

            _agent.SetDestination(newPos);

        }



    }
}
