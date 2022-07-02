using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMechanic : MonoBehaviour
{
    [SerializeField] private float range;
    [SerializeField] private Transform targetPlayer;
    [SerializeField] private Transform targetVan;
    [SerializeField] private Movement movement;
    [SerializeField] private GameObject bullet;
    [SerializeField] private float fireRate;
    [SerializeField] private Transform shootPoint;
    [SerializeField] private float force;
    private Vector2 direction;
    private float nextTimeToFire = 0;
    private bool detected;

    private void Update()
    {
        //Vector2 targetPos = movement.canMove ? targetPlayer.position : targetVan.position;
        Vector2 targetPos = targetVan.position;
        direction = targetPos - (Vector2)transform.position;
        RaycastHit2D rayInfo = Physics2D.Raycast(transform.position, direction, range);

        if (rayInfo)
        {
            if(rayInfo.collider.gameObject.tag == "Player")
            {
                if(detected == false)
                {
                    detected = true;
                }
            }
            else
            {
                if(detected == true)
                {
                    detected = false;
                }
            }
        }
        if (detected)
        {
            if(Time.time > nextTimeToFire)
            {
                nextTimeToFire = Time.time + 1 / fireRate;
                Shoot();
            }
        }
    }

    private void Shoot()
    {
        GameObject bulletIns = Instantiate(bullet, shootPoint.position, Quaternion.identity);
        bulletIns.GetComponent<Rigidbody2D>().AddForce(direction * force);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
