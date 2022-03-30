using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    //velocidade
    public float speed;
   //bala comecando
    void Start()
    {

        Destroy(gameObject, 5.0f);
        
    }

    //tiro de bala
    void Update()
    {

        transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }
    //dano no inimigo
    private void OnCollisionEnter(Collision collision)
    {
        //collider?
        if (gameObject.tag == "Bullet")
        {

            if (collision.gameObject.tag == "Inimigo")
            {

                Destroy(gameObject);

                collision.gameObject.GetComponent<Renderer>().material.color = new Color(0.0f, 255.0f, 0.0f);
                collision.gameObject.tag = "Malvado";

            }
            else if (collision.gameObject.tag == "Malvado")
            {

                Destroy(gameObject);

                Destroy(collision.gameObject);

            }

        }
        else if (gameObject.tag == "Magic")
        {    

            if (collision.gameObject.tag == "Inimigo" || collision.gameObject.tag == "Malvado")
            {

                Destroy(gameObject);
                Destroy(collision.gameObject);

            }

        }

        }

    
}
