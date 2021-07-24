using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 3;
    public int damage;
    public Transform Pl;
    public float sped;
    private bool ispause = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(ispause == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, Pl.position, sped);
        }

        if (Input.GetKeyDown(KeyCode.R) && ispause == false)
        {
            ispause = true;
        }
        if (Input.GetKeyDown(KeyCode.R) && ispause == true)
        {
            ispause = false;
        }

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
        public void TakeDamage(int damage)
        {
            health -= damage;
        }
}
