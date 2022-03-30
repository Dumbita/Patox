using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject Inimigo;
    GameObject Creator;
    GameObject[] Count;


    public float hXL, hZL, y;

    void Start()
    {

        StartCoroutine(EnemyCreator(3f));

    }

    void Update()
    {

    }

    IEnumerator EnemyCreator(float i)
    {
        Count = GameObject.FindGameObjectsWithTag("Inimigo");

        if (Count.Length < 3)
        {

            Creator = Instantiate(Inimigo);

            Vector3 j = new Vector3(Random.Range(-hXL, hXL), y, Random.Range(-hZL, hZL));

            Inimigo.transform.position = j;

            yield return new WaitForSeconds(i);

        }
        else
        {

            yield return new WaitForSeconds(0.1f);

        }

        StartCoroutine(EnemyCreator(i));

    }

}
