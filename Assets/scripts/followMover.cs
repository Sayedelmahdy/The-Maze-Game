using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followMover : MonoBehaviour
{
    public GameObject player;
    Vector3 offest;
    // Start is called before the first frame update
    void Start()
    {
        
        offest=transform.position-player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position=player.transform.position+offest;
    }
}
