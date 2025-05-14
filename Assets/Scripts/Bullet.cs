using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Bullet : MonoBehaviour
{
    [Header("Component")]
    [SerializeField] Rigidbody rigid;

    [Header("Propertis")]
    [SerializeField] GameObject explosionEffetPrefab;

    private void Update()
    {
        if (rigid.velocity.magnitude > 2)
        {
            transform.forward = rigid.velocity;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Instantiate(explosionEffetPrefab, transform.position, transform.rotation);
    }
}
