using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follower : MonoBehaviour
{
    // referencia de objeto sendo criado e destruido
    public GameObject a;
    GameObject b;

    public float t;
    void Start()
    {

     b = Instantiate(a,transform.position,transform.rotation) as GameObject;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (b != null)
        {

            b.transform.position = Vector3.MoveTowards(b.transform.position, transform.position, t);

        }
        Destroy(b, 5f);

    }
}
