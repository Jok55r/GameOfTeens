using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject car;

    [SerializeField] Movement playerMovement;

    void Update()
    {
        if (playerMovement.canMove)
            gameObject.transform.position = player.transform.position;
        else
            gameObject.transform.position = car.transform.position;
    }
}