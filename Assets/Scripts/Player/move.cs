using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float a = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;

        float b = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
        transform.Translate(a,0.0f,b);

    }
}
