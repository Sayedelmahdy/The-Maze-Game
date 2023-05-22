using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class scoreScript : MonoBehaviour
{
    // Start is called before the first frame update
   public static int score ;
    int lasthitscore;
    int hitscore;
    int bounsscore;
    int  lastbounsscore;
    void Start()
    {
        score=1000;
        lastbounsscore=Bouns.bouns;
        bounsscore=Bouns.bouns;
        hitscore=mover.hit;
        lasthitscore=mover.hit;
    }

    // Update is called once per frame
    void Update()
    {
        
       scoredec();
       scoreinc();
        GetComponent<TextMeshProUGUI>().text="Score :"+score.ToString();
    }
    void scoredec()
    {
        if (hitscore!=lasthitscore)
    {
         score-=50;
       if (score<0)
       score=0;
       lasthitscore=mover.hit;
    }
    else
    {
        hitscore=mover.hit;
    }
    }
    void scoreinc()
    {
        if (bounsscore!=lastbounsscore)
    {
        score+=Bouns.bouns;
     
       lastbounsscore=Bouns.bouns;
    }
    else
    {
       bounsscore=Bouns.bouns;
    }
    }
}
