using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhenTouch : MonoBehaviour
{
   public GameObject sp;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other) {
        
       
        if (other.gameObject.tag=="Player")
        {
             Debug.Log("obbbbbbs");
          sp.GetComponent<MeshRenderer>().enabled=true;
          sp.GetComponent<Rigidbody>().useGravity=true;
          //sp.GetComponent<Transform>().localScale=new Vector3(1.25f,1.25f,1.25f);
          
        }
    }
}
