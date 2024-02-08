using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterClass character;
    public Rigidbody2D rb;
    public float speed;
    public Tears projectile;

    Vector3 moveAxis;

    void Update()
    {
        moveAxis = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized;
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(projectile);
        }
    }

    private void FixedUpdate()
    {
        speed = character.speed;
        rb.velocity = moveAxis * speed * Time.fixedDeltaTime;
    }
}
