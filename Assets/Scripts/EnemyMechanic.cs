using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMechanic : MonoBehaviour
{
    [SerializeField] private float range;
    [SerializeField] private Transform target;
    [SerializeField] private bool detected;
    [SerializeField] private Vector2 direction;

    private void Update()
    {
        Vector2 targetPos = target.position;
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
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
