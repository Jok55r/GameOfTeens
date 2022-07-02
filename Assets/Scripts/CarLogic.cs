using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarLogic : MonoBehaviour
{
    [SerializeField] Movement player;
    [SerializeField] Movement car;

    [SerializeField] GameObject playerObj;
    bool isIn;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            player.canMove = !player.canMove;
            car.canMove = !car.canMove;

            if (!player.canMove)
            {
                playerObj.SetActive(false);
            }
            else
            {
                playerObj.SetActive(true);
                playerObj.transform.position = gameObject.transform.position;
            }
        }
    }
}