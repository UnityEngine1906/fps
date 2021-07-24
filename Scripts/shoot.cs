using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bullrtpoz;
    public int maxammo = 0;
    public int ammo;
    public float firerate = 15f;
    public float nexttimefire;
    public float reloadtime;
    private bool isreload = false;
    public AudioClip AudioShoot;
    public AudioSource проигрыавтель;
    public AudioClip GetStart;

    // Start is called before the first frame update
    private void Start()
    {
        ammo = maxammo;
    }
    void Update()
    {
        if (isreload)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            StartCoroutine(Reload());
            return;
        }
        if (Input.GetButton("Fire1") && Time.time >= nexttimefire && ammo > 0)
        {
            nexttimefire = Time.time + 1f / firerate;
            --ammo;
            Shoot();
        }
    }
    
    IEnumerator Reload()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            проигрыавтель.PlayOneShot(GetStart);
            isreload = true;
            yield return new WaitForSeconds(reloadtime);

            ammo = maxammo;
            isreload = false;
        }

    }
    void Shoot()
    {
        GameObject bulletObj = Instantiate(bullet);
        bulletObj.transform.position = bullrtpoz.transform.position + bullrtpoz.transform.forward;
        bulletObj.transform.forward = bullrtpoz.transform.forward;
        проигрыавтель.PlayOneShot(AudioShoot);
    }
}