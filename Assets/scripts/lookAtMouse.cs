using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAtMouse : MonoBehaviour
{
    bool showcursor;
    [SerializeField] float sinstavtiy;
    // Start is called before the first frame update
    void Start()
    {
        
        if (showcursor==false)
        {
            Cursor.visible=false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float rotationX=transform.localEulerAngles.y+Input.GetAxis("Mouse X")*sinstavtiy;
         float rotationY=transform.localEulerAngles.x+Input.GetAxis("Mouse Y")*sinstavtiy;
         gameObject.transform.localEulerAngles=new Vector3(rotationX,rotationY,0);   
    }
}
