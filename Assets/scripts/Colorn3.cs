using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorn3 : MonoBehaviour
{
    // Start is called before the first frame update
       public static int coun3=0;
   void Start()
    {
        
        GetComponent<MeshRenderer>().material.color=Color.black;
    }
      private void OnCollisionEnter(Collision other) {
        if ( other.gameObject.tag!="Player" && other.gameObject.GetComponent<MeshRenderer>().material.color== GetComponent<MeshRenderer>().material.color)
        {
             coun3=1;
        }
        
        
        }
}
