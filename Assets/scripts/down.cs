using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class down : MonoBehaviour
{
    public bool istouch=false;
    Rigidbody rb ;
    MeshRenderer msh;
    // Start is called before the first frame update
    void Start()
    {
        rb.useGravity=false;
        msh.enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
