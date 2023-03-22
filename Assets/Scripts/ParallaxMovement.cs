using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxMovement : MonoBehaviour
{
    [SerializeField] private Transform cam;
    [SerializeField] private float matchCamXMovement = 0f; // range 0...1    1 matches camera move
    [SerializeField] private float matchCamYMovement = 0f; // same as above
    [SerializeField] private Vector2 offset; // offsets position relative to the camera

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // only fires after update has already happened
    private void LateUpdate()
    {
        // move object relative to the camera
        transform.position = new Vector2(cam.position.x * matchCamXMovement, cam.position.y * matchCamYMovement) + offset;
    }
}
