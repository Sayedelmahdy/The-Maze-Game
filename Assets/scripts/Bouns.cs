using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouns : MonoBehaviour
{
   [SerializeField] GameObject finsih; 
    public static int bouns;

     private void Start() {
      bouns=0;
     }
    // Start is called before the first frame update
   private void OnCollisionEnter(Collision other) {
      if (other.gameObject.tag=="Player")
      {
         if (gameObject.tag=="Finish"){
          finsih.GetComponent<MeshCollider>().enabled=false;
         bouns+=5000;
         Debug.Log("finish");
         }
         else
         bouns+=1000;
         GetComponent<MeshCollider>().enabled=false;
         GetComponent<Bounce>().enabled=false;
      }
   }
}
