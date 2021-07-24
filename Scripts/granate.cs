using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class granate : MonoBehaviour
{

    public float reloadtime;
    public GameObject bullet;
    public float nextsp;
    public GameObject bullrtpoz;
    public float doodo;

    //public TrajectoryRendererAdvanced Trajectory;



    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Time.time >= nextsp)
        {
            nextsp = Time.time + doodo;
            GameObject bulletObj = Instantiate(bullet);
            bulletObj.transform.position = bullrtpoz.transform.position + bullrtpoz.transform.forward;
            bulletObj.transform.forward = bullrtpoz.transform.forward;

        }

    }
}
