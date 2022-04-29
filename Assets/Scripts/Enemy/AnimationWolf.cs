using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationWolf : MonoBehaviour
{
    Animator animator;

    void Start()
    {

        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {

            animator.SetBool("Run Forward", true);

        }
        else if(!Input.GetKey(KeyCode.W))
        {

            animator.SetBool("Run Forward", false);

        }

        if (Input.GetKey(KeyCode.S))
        {

            animator.SetBool("Run Backward", true);

        }
        else if(!Input.GetKey(KeyCode.S))
        {

            animator.SetBool("Run Backward", false);

        }

    }
}
