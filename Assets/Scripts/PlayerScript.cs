using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    RaycastHit hit;
    Rigidbody rb;
    Vector3 movimento;

    public bool movimentoMouse = false;
    public float speed;



    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {


    }
    private void FixedUpdate()
    {
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 1000))
        {
            Vector3 playerMouse = hit.point - transform.position;
            playerMouse.y = 0;
            Quaternion newRotation = Quaternion.LookRotation(playerMouse);
            rb.MoveRotation(newRotation);

            movimento = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            movimento = movimento.normalized * speed * Time.deltaTime;
            rb.MovePosition(transform.position + movimento);
        }

    }

}