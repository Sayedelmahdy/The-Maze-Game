using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    public static int hit=0;
    [SerializeField] float speed=10.0f;
    // Start is called before the first frame update
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        hit=0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         float xvalue = Input.GetAxis("Horizontal");
       float zvalue = Input.GetAxis("Vertical");
       Vector3 mov = new Vector3 (zvalue,0.0f,xvalue);
       rb.AddForce(mov*speed);
       if (Input.GetKey(KeyCode.C))
       {
        speed=16;
        Invoke("returnSpeed",5);
       }

    }
    private void OnCollisionEnter(Collision other) {
        
        if (other.gameObject.tag=="NotFriendly")
        {
              hit++;
        }
    }
    void returnSpeed()
    {
        speed=7;
    }
}
