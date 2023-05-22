using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onTouch2 : MonoBehaviour
{
[SerializeField] GameObject [] plane =new GameObject[9];

[SerializeField] GameObject door;

private void OnCollisionEnter(Collision other) {
   if (other.gameObject.tag=="Player")
   {
     foreach (GameObject item in plane)
{
 item.GetComponent<MeshRenderer>().enabled=true; 

}
door.GetComponent<MeshRenderer>().enabled=true;
door.GetComponent<Rigidbody>().useGravity=true;
   }
}


}
          

