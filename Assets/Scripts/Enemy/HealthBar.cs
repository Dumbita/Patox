using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    [Header("Life bars")]
    public Image b;
    public Sprite [] a;
    public float t;
    int j;

    void Start()
    {
        b.sprite = a[0];
        j = 0;

        StartCoroutine(Timer(t));

    }

    void Update()
    {

        transform.LookAt(Camera.main.transform.position);

    }

    IEnumerator Timer(float t)
    {
       
        b.sprite = a[j];

        yield return new WaitForSeconds(t);

        j++;

        if (j < a.Length)
        {

            StartCoroutine(Timer(t));

        }

    }
}
