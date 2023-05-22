using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HitScript : MonoBehaviour
{
   // Start is called before the first frame update
  
    int lasthitscore;
    int hitscore;
    void Start()
    {
        hitscore=mover.hit;
        lasthitscore=mover.hit;
    }

    // Update is called once per frame
    void Update()
    {
        
       scoredec();
        GetComponent<TextMeshProUGUI>().text="Hit :"+hitscore.ToString();
    }
    void scoredec()
    {
        if (hitscore!=lasthitscore)
    {
    
       lasthitscore=mover.hit;
    }
    else
    {
        hitscore=mover.hit;
    }
    }
}
