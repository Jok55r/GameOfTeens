using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsEndGame : MonoBehaviour
{
    public static bool isGameEnd = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Finish"))
        {
            isGameEnd = true;
            print("putin pidor");
        }
    }
}
