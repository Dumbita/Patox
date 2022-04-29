using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Inimigo;
    GameObject Creator;

    public float hXL, hZL;
    public float tempoDeTimer;

    void Start()
    {

        StartCoroutine(EnemyCreator(tempoDeTimer));

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator EnemyCreator(float i)
    {


        float x = Random.Range(-hXL, hXL);
        float z = Random.Range(-hZL, hZL);

        float x1 = transform.position.x - x;
        float z1 = transform.position.z - z;

        Vector3 j = new Vector3(x1, transform.position.y, z1);

        Inimigo.transform.position = j;

        Creator = Instantiate(Inimigo);

        Destroy(Creator, 10f);

        yield return new WaitForSeconds(i);

        StartCoroutine(EnemyCreator(i));

    }

}
