using UnityEngine;
[CreateAssetMenu(fileName = "New Character", menuName = "Characters")]
public class CharacterClass : ScriptableObject
{
    //Il faudra changer manuellemnt le Scriptable Object du joueur, au niveau du player ET de son arme (GameObject enfant : Weapon)
    public Tears Tears;
    public Sprite Character;
    public int life;
    public int attack;
    public int speed;
}
