using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    public static int hit=0;
    [SerializeField] float speed;
    // Start is called before the first frame update
    Rigidbody rb;
     float xvalue;
      float zvalue;
    private void Awake() {
         rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
       Application.targetFrameRate=60;
        hit=0;
    }
    void Update()
    {
        input();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         
       Vector3 mov = new Vector3 (zvalue,0.0f,xvalue);
       rb.AddForce(mov*speed);
       if (Input.GetKey(KeyCode.Space))
       {
        speed=18;
        Invoke("returnSpeed",4);
       }

    }
    private void input()
    {
         xvalue = Input.GetAxis("Horizontal");
        zvalue = Input.GetAxis("Vertical");
    }
    private void OnCollisionEnter(Collision other) {
        
        if (other.gameObject.tag=="NotFriendly")
        {
              hit++;
        }
    }
    void returnSpeed()
    {
        speed=14;
    }
}
