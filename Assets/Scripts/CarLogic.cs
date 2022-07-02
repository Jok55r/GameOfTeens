using UnityEngine;

public class CarLogic : MonoBehaviour
{
    [SerializeField] Movement player;
    [SerializeField] Movement car;

    [SerializeField] GameObject playerObj;

    public static bool canRide = true;

    private void Start()
    {
        canRide = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && canRide)
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