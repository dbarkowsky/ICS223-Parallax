using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController3D : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) // left click
        {
            // extend ray from camera into 3D world to mouse click location
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            // check if ray hits world colliders
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
    }
}
