using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;

    void Start()
    {
        
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        gameObject.transform.position += new Vector3(x, y, 0f) * speed * Time.deltaTime;

        if (x < 0)
            gameObject.transform.localScale = new Vector3(-5, 5, 1);
        else if (x > 0)
            gameObject.transform.localScale = new Vector3(5, 5, 1);

    }
}