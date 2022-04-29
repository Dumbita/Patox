using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiMovement : MonoBehaviour
{

    public float speed;
    float distance;

    GameObject player;

    void Start()
    {
        

    }

    private void Update()
    {
        //rotates fast
        //transform.LookAt(player.transform);

        player = GameObject.FindGameObjectWithTag("Player");

        distance = Vector3.Distance(transform.position, player.transform.position);

        if (distance > 1f)
        {

            Quaternion targetRotation = Quaternion.LookRotation(player.transform.position - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, speed * Time.deltaTime);

            transform.position += transform.forward * speed * Time.deltaTime;

        }

    }

}
