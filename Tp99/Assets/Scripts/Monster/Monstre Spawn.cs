using UnityEngine;

public class MonstreSpawn : MonoBehaviour
{
    public Monster monstre1;
    public Monster monstre2;
    public Monster monstre;
    public SpriteRenderer spriteRenderer_Monstre;
    public float speed = 0f;
    public int life = 0;
    private int index_monster;
    void Start()
    {
        Random_monster();
    }

    public void Random_monster()
    {
        index_monster = Random.Range(1,3);
        if (index_monster == 1)
        {
            monstre = monstre1;
        }
        else
        {
            monstre = monstre2;
        }

        spriteRenderer_Monstre.sprite = monstre.Monster_Character;
        speed = monstre.Monster_Speed;
        life = monstre.Monster_pv;
        Instantiate(monstre);
    }
}
