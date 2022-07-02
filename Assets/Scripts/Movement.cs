using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed;

    public bool canMove = true;
    public bool isPlayer;

    public bool isInTriggerOfCar;

    private void Start()
    {
        gameObject.SetActive(true);
        if (isPlayer)
            canMove = true;

        InvokeRepeating("IsntIn", 0.5f, 0.5f);
    }

    void IsntIn()
    {
        isInTriggerOfCar = false;
    }

    private void Update()
    {
        if (PlayerHealth.hp <= 0)
            canMove = false;

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

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (isPlayer)
            isInTriggerOfCar = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Water" && isPlayer)
        {
            PlayerHealth.hp--;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Water" && isPlayer)
        {
            PlayerHealth.hp--;
        }
    }
}