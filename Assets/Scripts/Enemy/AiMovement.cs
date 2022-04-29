using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiMovement : MonoBehaviour
{

    public float speed;

    GameObject player;

    void Start()
    {
        

    }

    private void Update()
    {
        //rotates fast
        //transform.LookAt(player.transform);

        player = GameObject.FindGameObjectWithTag("Player");

        Quaternion targetRotation = Quaternion.LookRotation(player.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, speed * Time.deltaTime);

        transform.position += transform.forward * speed * Time.deltaTime;

    }

}
