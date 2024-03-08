using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemigoIA : MonoBehaviour
{
    // Start is called before the first frame update

    NavMeshAgent myNavMeshAgent;
    public GameObject jugador;
    void Start()
    {
        myNavMeshAgent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if(myNavMeshAgent.enabled){
            myNavMeshAgent.SetDestination(jugador.transform.position);
        }
    }

    void OnTriggerEnter(Collider c){
        if(c.gameObject.tag == "Player"){
            myNavMeshAgent.enabled=true;
        }
    }
}
