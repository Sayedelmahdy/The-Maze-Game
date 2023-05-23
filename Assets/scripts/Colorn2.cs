using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorn2 : MonoBehaviour
{
    // Start is called before the first frame update
     public static int coun2=0;
   void Start()
    {
        
        GetComponent<MeshRenderer>().material.color=Color.magenta;
    }
      private void OnCollisionEnter(Collision other) {
        if ( other.gameObject.tag!="Player" && other.gameObject.tag== gameObject.tag)
        {
             coun2=1;
        }
     
        
        }
}
