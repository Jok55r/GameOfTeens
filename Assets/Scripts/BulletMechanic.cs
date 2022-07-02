using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMechanic : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        PlayerHealth.TakeDamage();
        print("Spawned");
    }
}
