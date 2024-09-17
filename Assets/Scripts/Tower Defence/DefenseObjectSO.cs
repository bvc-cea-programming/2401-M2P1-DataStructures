using UnityEngine;
[CreateAssetMenu(fileName = "DefenseOBJ", menuName = "DefenseSO")]
public class DefenseObjectSO : ScriptableObject
{
    public string Name;
    public int Price;
    public float FireRate;
    public GameObject TowerPrefab;
    public Sprite IconSprite;
}
