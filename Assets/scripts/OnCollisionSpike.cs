using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class OnCollisionSpike : MonoBehaviour
{
    // Start is called before the first frame update
     [SerializeField] GameObject player;
      [SerializeField] GameObject text;
      int scoress=0;
    private void Start() {
        text.GetComponent<TextMeshProUGUI>().enabled=false;
    }
private void OnCollisionEnter(Collision other) {
    if (other.gameObject.tag=="Player")
    {
        GetComponent<MeshRenderer>().enabled=true;
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
       SceneManager.LoadScene(0);
}
}
