using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class setcolors : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Camera mainCamer;
    bool firsttime = false;
    [SerializeField] GameObject player;
    [SerializeField] GameObject stop;
  [ SerializeField] GameObject [] cubes = new GameObject[4];
  Color [] color = {Color.red,Color.magenta,Color.black,Color.white};
  string [] tags = {"Red","Magenta","Black","White"};
  private void Start() {
     firsttime=false;
    stop.GetComponent<BoxCollider>().enabled=false;
   
  }
  Vector3 go;
  int rnd;
  private void OnCollisionEnter(Collision other) {
    
    
    if (firsttime==false)
    {
      mainCamer.GetComponent<followMover>().enabled=false;
       player.GetComponent<mover>().enabled=false;
    stop.GetComponent<BoxCollider>().enabled=true;
     go = mainCamer.transform.position;
     Vector3 neww = go;
     neww.x+=-13f;
     neww.z+=-7f;
    mainCamer.transform.position = neww;
    if (other.gameObject.tag=="Player"){

     List<int> listNumbers = new List<int>();
    foreach (var cube in cubes)
    {

  do {
      rnd = Random.Range(0,4);
  } while (listNumbers.Contains(rnd));
  listNumbers.Add(rnd);
  Debug.Log(rnd);
  Debug.Log(color[rnd].ToString());

  cube.GetComponent<MeshRenderer>().material.color=color[rnd];
  cube.tag=tags[rnd];

    }
   
   
     
     
    Invoke("returnCamera",6);
    }
     firsttime=true;
    }
  }
  void returnCamera()
  {
     rnd = Random.Range(0,4);
     foreach (var cube in cubes)
    {
      cube.GetComponent<MeshRenderer>().material.color=color[rnd];
    }
    stop.GetComponent<BoxCollider>().enabled=false;
    mainCamer.GetComponent<followMover>().enabled=true;
    player.GetComponent<mover>().enabled=true;
    mainCamer.transform.position=go;
  }
}
