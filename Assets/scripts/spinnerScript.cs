using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinnerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 3f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0f, speed * Time.deltaTime / 0.01f,  0f,Space.Self);
    }
}
