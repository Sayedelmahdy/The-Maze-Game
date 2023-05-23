using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CongOpen : MonoBehaviour
{
    // Start is called before the first frame update


    public static int  counter =0;

private void Start() {
    counter=0;
}
 private void Update() {
   counter=Colorn1.coun1+Colorn2.coun2+Colorn3.coun3+Colorn4.coun4;
    if (counter==4)
    {
       
        transform.position=  new Vector3 (-5.1607f,-0.85f,-8.7213f);
    }
 }
}
