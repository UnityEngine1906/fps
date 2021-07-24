using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class granateBoom : MonoBehaviour
{
    public float dely = 3f;
    float contdown;
    public GameObject effect;
    bool expl = false;
    public float force;
    public float radiuse;
    public float health;
    public float damage;

    void Start()
    {
        contdown = dely;
    }
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        contdown -= Time.deltaTime;
        if (contdown <= 0f && !expl)
        {
            Explode();
            expl = true;
        }
    }
    void Explode()
    {
        Instantiate(effect, transform.position, transform.rotation);

        Collider[] col = Physics.OverlapSphere(transform.position, radiuse);
        foreach (Collider nearbyObject in col)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(force, transform.position, radiuse);
                health -= 3;
            }
        }

        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemy") && health <= 0)
        {
            other.gameObject.GetComponent<Enemy>().TakeDamage(1);
        }
    }
}
