using UnityEngine;


[CreateAssetMenu(fileName = "New Monstre", menuName = "Monstres")]
public class Monster : ScriptableObject
{
    public Sprite Monster_Character;
    public int Monster_pv;
    public GameObject prefab_Monstre;
    public float Monster_Speed;
}
