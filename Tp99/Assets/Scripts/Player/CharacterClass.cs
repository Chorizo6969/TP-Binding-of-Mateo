using UnityEngine;


[CreateAssetMenu(fileName = "New Character", menuName = "Characters")]
public class CharacterClass : ScriptableObject
{
    public ScriptableObject Tears;
    public Sprite Character;

    public int life;
    public int attack;
    public int speed;
}
