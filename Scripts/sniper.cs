using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sniper : MonoBehaviour
{
    public Camera camera;
    public GameObject sn;
    public GameObject sn1;
    public GameObject sn2;
    public GameObject sn3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            camera.fieldOfView = 20f;
            sn.SetActive(true);
            sn1.SetActive(true);
            sn2.SetActive(true);
            sn3.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            camera.fieldOfView = 60f;
            sn.SetActive(false);
            sn1.SetActive(false);
            sn2.SetActive(false);
            sn3.SetActive(false);
        }
    }
}
