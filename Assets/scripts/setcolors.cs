using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class setcolors : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Camera mainCamer;
    [SerializeField] GameObject player;
  [ SerializeField] GameObject [] cubes = new GameObject[4];
  Color [] color = {Color.red,Color.magenta,Color.black,Color.white};
  private void Start() {
    
   
  }
  Vector3 go;
  private void OnCollisionEnter(Collision other) {
    
    if (other.gameObject.tag=="Player"){

     List<int> listNumbers = new List<int>();
    foreach (var cube in cubes)
    {
int rnd;
  do {
      rnd = Random.Range(0,4);
  } while (listNumbers.Contains(rnd));
  listNumbers.Add(rnd);
  Debug.Log(rnd);
  Debug.Log(color[rnd].ToString());

  cube.GetComponent<MeshRenderer>().material.color=color[rnd];

    }
    player.GetComponent<mover>().enabled=false;
    mainCamer.GetComponent<followMover>().enabled=false;
      go = mainCamer.transform.position;
     Vector3 neww = go;
     neww.x+=-13f;
     neww.z+=-7f;
    mainCamer.transform.position = neww;
    Invoke("returnCamera",4);
    }

    
  }
  void returnCamera()
  {
    
    mainCamer.GetComponent<followMover>().enabled=true;
    player.GetComponent<mover>().enabled=true;
    mainCamer.transform.position=go;
  }
}
