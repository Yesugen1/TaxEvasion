using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleSound : MonoBehaviour
{
    // Declaring A new Audio Source
    public AudioSource Ding;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If Space is pressed then play the ding sound
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Ding.Play();
        }
    }
}
