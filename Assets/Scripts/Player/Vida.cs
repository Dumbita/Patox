using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    
    public Text vida;
    public Text barra;

    public byte health = 10;
    public byte mana = 0;

    void Start()
    {
        
    }

    void Update()
    {

        vida.text = health.ToString();
        barra.text = mana.ToString();

    }

}
