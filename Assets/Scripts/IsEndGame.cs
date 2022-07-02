using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsEndGame : MonoBehaviour
{
    public static bool isGameEnd = false;
    [SerializeField] private Movement playerMove;
    [SerializeField] private AudioSource winEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Finish")
        {
            CarLogic.canRide = false;
            playerMove.canMove = false;
            winEffect.Play();
            gameObject.SetActive(false);
            isGameEnd = true;
            print("putin pidor");
        }
    }
}
