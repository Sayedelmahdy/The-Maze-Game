using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class onc : MonoBehaviour
{
    int scoress=0;
   [SerializeField] GameObject textmesh;
    // Start is called before the first frame update
  private void OnCollisionEnter(Collision other) {
    if (other.gameObject.tag=="Player")
    {
        Debug.Log("congratulation");
        Physics.gravity=new Vector3(9,-9.8f,5);
        other.gameObject.GetComponent<mover>().enabled=false;
     textmesh.GetComponent<TextMeshProUGUI>().enabled=true;
     scoress=scoreScript.score;
     if (scoress>PlayerPrefs.GetInt("HighScore")){
     PlayerPrefs.SetInt("HighScore",scoress);
     PlayerPrefs.Save();
     }
        Invoke("returnload",6);
    }
    
   
  }
  public void returnload()
  {
    Physics.gravity=new Vector3(0,-15.5f,0);
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
  }
}
