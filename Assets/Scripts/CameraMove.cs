using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject car;

    [SerializeField] Movement playerMovement;

    void Update()
    {
        if (playerMovement.canMove)
            gameObject.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10f);
        else
            gameObject.transform.position = new Vector3(car.transform.position.x, car.transform.position.y, -10f);
    }
}