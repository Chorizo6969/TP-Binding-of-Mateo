using UnityEngine;

public class CharactersSpawn : MonoBehaviour
{
    public CharacterClass character;
    public GameObject Player;
    public SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer.sprite = character.Character;
    }
}
