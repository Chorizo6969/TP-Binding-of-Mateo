using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterClass character;
    public Rigidbody2D rb;
    public float speed;
    public Tears projectile;
    public int life;

    Vector3 moveAxis;

    void Update()
    {
        moveAxis = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized;
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            TIRE();
        }
    }

    private void FixedUpdate()
    {
        speed = character.speed;
        life = character.life;
        rb.velocity = moveAxis * speed * Time.fixedDeltaTime;
    }

    public void TIRE()
    {
        Instantiate(projectile.larme);
        Rigidbody2D rbBullet = projectile.larme.GetComponent<Rigidbody2D>();
        rbBullet.AddForce(projectile.larme.transform.right * projectile.speedTears);
    }
}
