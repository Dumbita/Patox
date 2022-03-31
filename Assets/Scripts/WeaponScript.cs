using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    //bala
    public GameObject BulletPrefab;
    public GameObject Fire;
    // camera
    public Camera cam;
    //tempo de espera
    public float t;
    //bandeira para Coroutine funcionar
    bool flag = true;
    bool flag1 = true;

    private void Start()
    {

        System.OutOfMemoryException.println("oi");
    }
    //Coroutine de Bullet
    void Update()
    {

        StartCoroutine(Timer(t));
        StartCoroutine(Bomb(t));

    }
    /*private void FixedUpdate()
    {
        //disparo
        if (Input.GetMouseButtonDown(0))
        {

            

            Instantiate(BulletPrefab, transform.position, transform.rotation);

             Ray ray = cam.ScreenPointToRay(Input.mousePosition);

             if (Physics.Raycast(ray, out RaycastHit hitpoint))
             {
                 Instantiate(BulletPrefab, transform.position, transform.rotation);
                 if (hitpoint.collider.gameObject.GetComponent<Enemy>() != null)
                 {
                     Vector3 distanciaTarget = hitpoint.point - transform.position;
                     Vector3 direção = distanciaTarget.normalized;
                     Instantiate(BulletPrefab, transform.position, transform.rotation);
                 }
        }
        }*/
    //ratio de bullet spamming
    IEnumerator Timer(float t)
    {
        if (flag == true)
        {

            if (Input.GetMouseButtonDown(1))
            {

                Instantiate(BulletPrefab, transform.position, transform.rotation);

                flag = false;

                yield return new WaitForSeconds(t);

                flag = true;

            }

        }

    }

    IEnumerator Bomb(float t)
    {
        if (flag1 == true)
        {

            if (Input.GetButtonDown("Jump"))
            {

                Instantiate(Fire, transform.position, transform.rotation);

                flag1 = false;

                yield return new WaitForSeconds(t);

                flag1 = true;

            }

        }

    }

}
