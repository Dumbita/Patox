using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiMovement : MonoBehaviour
{

    public float speed;

    public GameObject player; 

    void Start()
    {
        

    }

    private void Update()
    {
        //rotates fast
        //transform.LookAt(player.transform);

        Quaternion targetRotation = Quaternion.LookRotation(player.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, speed * Time.deltaTime);

        transform.position += transform.forward * speed * Time.deltaTime;

    }

}
