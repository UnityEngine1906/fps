using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spavn : MonoBehaviour
{
    public float reloadtime;
    public GameObject bullet;
    public float nextsp;
    public GameObject bullrtpoz;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextsp)
        {
            nextsp = Time.time + 5f;
            StartCoroutine(Reload());
            return;
        }
        IEnumerator Reload()
        {
            yield return new WaitForSeconds(reloadtime);
            GameObject bulletObj = Instantiate(bullet);
            bulletObj.transform.position = bullrtpoz.transform.position + bullrtpoz.transform.forward;
            bulletObj.transform.forward = bullrtpoz.transform.forward;
        }
    }
}
