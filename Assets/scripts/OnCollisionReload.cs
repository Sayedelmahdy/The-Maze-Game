using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class OnCollisionReload : MonoBehaviour
{
    // Start is called before the first frame update

    int scoress=0;
    [SerializeField] GameObject player;
    [SerializeField] GameObject text;
    private void Start() {
        text.GetComponent<TextMeshProUGUI>().enabled=false;
    }
   private void OnCollisionEnter(Collision other) {
    if (other.gameObject.tag=="Player")
    {
        player.GetComponent<mover>().enabled=false;
          text.GetComponent<TextMeshProUGUI>().enabled=true;
           scoress=scoreScript.score;
            Invoke("LoadScenee",3);
     if (scoress>PlayerPrefs.GetInt("HighScore")){
     PlayerPrefs.SetInt("HighScore",scoress);
     PlayerPrefs.Save();
   
    }
}
   }
void LoadScenee()
{
    Physics.gravity=new Vector3(0,-15.5f,0);
       SceneManager.LoadScene(0);
}
}
