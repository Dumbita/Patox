using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RayCasting : MonoBehaviour
{

    [SerializeField] private Camera mainCamera;

    public Image a;

    public Button b;

    void Start()
    {

        Button button = GetComponent<Button>();
        
    }

    void Update()
    {

        Debug.Log(mainCamera.ScreenToWorldPoint(Input.mousePosition));

        Vector3 mouse = mainCamera.ScreenToWorldPoint(Input.mousePosition);

        mouse.z = 0f;

    }

}
