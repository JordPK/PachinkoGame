using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroidscript : MonoBehaviour
{
    public float asteroidRotate = 1.0f;
    public float asteroidmovespeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 1 * asteroidRotate * Time.deltaTime);
        transform.Translate(0, 1 * asteroidmovespeed * Time.deltaTime, 0);
    }
}
