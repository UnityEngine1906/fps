using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadScene : MonoBehaviour
{
    public GameObject pause1;
    public float reloadtime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void load()
    {
        StartCoroutine(Reload());
        return;
        pause1.SetActive(true);
      
    }
    IEnumerator Reload()
    {
        yield return new WaitForSeconds(reloadtime);
    }
}
