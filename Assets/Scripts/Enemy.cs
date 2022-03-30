using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //renderer para cor
    Renderer render;

    void Start()
    {
        render = GetComponent<Renderer>();
    }

    void Update()
    {
        
    }

    //troca de cor com ponteiro
    private void OnMouseEnter()
    {
        render.material.color = Color.red;
    }
    
    private void OnMouseExit()
    {
        
        if(gameObject.tag == "Inimigo")
        {
            
            render.material.color = new Color(255.0f, 255.0f, 255.0f);

        }
        else if(gameObject.tag == "Malvado")
        {

            render.material.color = new Color(0.0f, 255.0f, 0.0f);

        }


    }
}
