using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetsGo : MonoBehaviour
{

    Animator dog;

    void Start()
    {

        dog = GetComponent<Animator>();

    }

    void Update()
    {

        float i = Input.GetAxis("Horizontal") * Time.deltaTime *2;
        float j = Input.GetAxis("Vertical") * Time.deltaTime * 2;

        transform.Translate(i,0,j);

        dog.SetFloat("Move", Mathf.Abs(Input.GetAxisRaw("Horizontal")) + Mathf.Abs(Input.GetAxisRaw("Vertical")));

        if (Input.GetKey(KeyCode.Space))
        {

            dog.SetTrigger("Attack");

        }
        else
        {

            dog.ResetTrigger("Attack");

        }
       
    }

}
