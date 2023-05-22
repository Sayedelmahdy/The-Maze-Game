using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainScript : MonoBehaviour
{
  
 [SerializeField] TextMeshProUGUI text;
  private void Start() {
    text.text="HIGH SCORE : "+PlayerPrefs.GetInt("HighScore").ToString();
  }
  public void playGame()
  {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
  }
  public void Quit()
  {
    Application.Quit();
  }
}
