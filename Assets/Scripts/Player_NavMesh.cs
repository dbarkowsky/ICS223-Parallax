using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player_NavMesh : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent; // for moving on the nav mesh

    // Start is called before the first frame update
    void Start()
    {
        agent.SetDestination(Vector3.zero); // go to [0,0,0]
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
