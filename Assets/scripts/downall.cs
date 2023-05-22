using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class downall : MonoBehaviour
{
 [SerializeField] public int time;
    // Start is called before the first frame update
    void Start()
    {
        time=0;
    }

    // Update is called once per frame
    void Update()
    {
      time+=1;
        if (gameObject.tag=="spike1" && time>3)
        {
            this.GetComponent<Rigidbody>().useGravity=true;
        }
        else if  (gameObject.tag=="spike2" && time>5)
        {
            this.GetComponent<Rigidbody>().useGravity=true;
        }
         else if  (gameObject.tag=="spike3" && time>7)
        {
            this.GetComponent<Rigidbody>().useGravity=true;
        }
         else if  (gameObject.tag=="spike4" && time>9)
        {
            this.GetComponent<Rigidbody>().useGravity=true;
        }
         else if  (gameObject.tag=="spike5" && time>12)
        {
            this.GetComponent<Rigidbody>().useGravity=true;
        }
          else if  (gameObject.tag=="spike6" && time>16)
        {
            this.GetComponent<Rigidbody>().useGravity=true;
        }
          else if  (gameObject.tag=="spike7" && time>19)
        {
            this.GetComponent<Rigidbody>().useGravity=true;
        }
          else if  (gameObject.tag=="spike8" && time>23)
        {
            this.GetComponent<Rigidbody>().useGravity=true;
        }
          else if  (gameObject.tag=="spike9" && time>26)
        {
            this.GetComponent<Rigidbody>().useGravity=true;
        }
          else if  (gameObject.tag=="spike10" && time>30)
        {
            this.GetComponent<Rigidbody>().useGravity=true;
        }
          else if  (gameObject.tag=="spike11" && time>33)
        {
            this.GetComponent<Rigidbody>().useGravity=true;
        }
          else if  (gameObject.tag=="spike12" && time>37)
        {
            this.GetComponent<Rigidbody>().useGravity=true;
        }
          else if  (gameObject.tag=="spike13" && time>41)
        {
            this.GetComponent<Rigidbody>().useGravity=true;
        }
          else if  (gameObject.tag=="spike 14" && time>45)
        {
            this.GetComponent<Rigidbody>().useGravity=true;
        }
          else if  (gameObject.tag=="spike 15" && time>50)
        {
            this.GetComponent<Rigidbody>().useGravity=true;
        }
          else if  (gameObject.tag=="spike 16" && time>55)
        {
            this.GetComponent<Rigidbody>().useGravity=true;
        }
    }
}
