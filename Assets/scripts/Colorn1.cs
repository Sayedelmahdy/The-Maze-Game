using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorn1 : MonoBehaviour
{
    public static int coun1=0;
    // Start is called before the first frame update
    void Start()
    {
        
        GetComponent<MeshRenderer>().material.color=Color.red;
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision other) {
        if ( other.gameObject.tag!="Player" && other.gameObject.GetComponent<MeshRenderer>().material.color== GetComponent<MeshRenderer>().material.color)
        {
           coun1=1;
        }
       
        
        
        }
}
