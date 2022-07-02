using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed;

    public bool canMove = true;
    public bool isPlayer;

    public bool isInTriggerOfCar;

    private void FixedUpdate()
    {
        isInTriggerOfCar = false;
    }

    private void Update()
    {
        if (!canMove)
            return;

        if (isPlayer)
            PlayerMove();
        else
            CarMove();
    }

    void CarMove()
    {
        float rotate = Input.GetAxis("Horizontal") * speed * Time.deltaTime * 10;
        float move = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        gameObject.transform.Translate(0f, move, 0f);
        gameObject.transform.Rotate(0f, 0f, -rotate);
    }

    void PlayerMove()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        gameObject.transform.position += new Vector3(x, y, 0f) * speed * Time.deltaTime;

        if (x < 0)
            gameObject.transform.localScale = new Vector3(-5, 5, 1);
        else if (x > 0)
            gameObject.transform.localScale = new Vector3(5, 5, 1);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isPlayer)
            isInTriggerOfCar = true;
    }
}