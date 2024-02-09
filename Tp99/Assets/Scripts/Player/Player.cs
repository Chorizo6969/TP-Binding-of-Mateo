using UnityEngine;
using TMPro;
public class Player : MonoBehaviour
{
    public CharacterClass character;
    public Rigidbody2D rb;
    public float speed;
    public int life;
    public TextMeshProUGUI TMP;
    public SpriteRenderer spriteRenderer;

    Vector3 moveAxis;

    private void Start()
    {
        spriteRenderer.sprite = character.Character;
        speed = character.speed;
        life = character.life;
        TMP.text = life.ToString();
    }
    void Update()
    {
        moveAxis = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized;

    }
    private void FixedUpdate()
    {
        rb.velocity = moveAxis * speed * Time.fixedDeltaTime;
    }
    public void OnCollisionEnter2D(Collision2D monstre)
    {
        if (monstre.collider.tag == "Monstre")
        {
            if (life > 1)
            {
                life = life - 1 ;
                TMP.text = life.ToString();
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
