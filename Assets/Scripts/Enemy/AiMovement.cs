using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiMovement : MonoBehaviour
{

    public float speed;
    float distance;

    GameObject player;

    Animator animator;

    void Start()
    {

        animator = GetComponent<Animator>();

    }

    private void Update()
    {
        //rotates fast
        //transform.LookAt(player.transform);

        player = GameObject.FindGameObjectWithTag("Player");

        distance = Vector3.Distance(transform.position, player.transform.position);

        if (distance > 2f)
        {

            animator.SetBool("Run Forward", true);

            Quaternion targetRotation = Quaternion.LookRotation(player.transform.position - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, speed * Time.deltaTime);

            transform.position += transform.forward * speed * Time.deltaTime;

        }
        else
        {

            animator.SetBool("Run Forward", false);

        }

    }

}
