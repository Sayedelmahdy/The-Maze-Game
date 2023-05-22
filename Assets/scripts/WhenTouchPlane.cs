using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhenTouchPlane : MonoBehaviour
{
    bool ist=false;
  [SerializeField] GameObject player;
    public static bool istouch=false;
   
    [SerializeField] GameObject Plane;


 
    private void Start() {
      ist = false;
    }
    private void Update() {
       if (ist)
       {
        Vector3 direction = new Vector3(0, 0, -18);
        Quaternion targetRotation = Quaternion.Euler(direction);
        Plane.GetComponent<Transform>().rotation = Quaternion.RotateTowards(Plane.GetComponent<Transform>().rotation, targetRotation, Time.deltaTime * 20f);
       }
      }
      private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag=="Player")
        {
        ist=true;
        Physics.gravity= new Vector3(7,-4,-2.5f);
      /* Plane.GetComponent<Transform>().rotation =  Quaternion.Euler(0, 0, -15);
        player.GetComponent<Transform>().position =  new Vector3(-6.82f,9f,0.28f);*/
        }
      }
    
      
}
