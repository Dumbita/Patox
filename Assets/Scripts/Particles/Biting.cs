using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Biting : MonoBehaviour
{
    [SerializeField] ParticleSystem a = null;

    void Start()
    {


        
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {

            a.Play();

        }
        
    }

}
