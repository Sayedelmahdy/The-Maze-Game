using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorn4 : MonoBehaviour
{
     public static int coun4=0;
   void Start()
    {
        
        GetComponent<MeshRenderer>().material.color=Color.white;
    }
      private void OnCollisionEnter(Collision other) {
        if ( other.gameObject.tag!="Player" && other.gameObject.tag== gameObject.tag)
        {
             coun4=1;
        }
       
        
        }
}
