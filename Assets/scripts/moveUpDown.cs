using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveUpDown : MonoBehaviour
{
    Vector3 startingPoint;

    [SerializeField] Vector3 moveVector;
   [SerializeField] [Range(0,1)]float movementFactor;
    [SerializeField] float period = 2f;
    // Start is called before the first frame update
    void Start()
    {
        startingPoint=transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float cycles = Time.time/period;
        const float ta = Mathf.PI*2;
        float sinWave = Mathf.Sin(cycles*ta);
        Vector3 offest = moveVector*movementFactor;
        movementFactor=(sinWave+1f)/2f;
        transform.position=startingPoint+offest;
    }
}
