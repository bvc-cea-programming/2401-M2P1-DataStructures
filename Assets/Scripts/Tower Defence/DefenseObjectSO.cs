using UnityEngine;
[CreateAssetMenu(fileName = "DefenseTower", menuName = "DefenseTower")]
public class DefenseObjectSO : ScriptableObject
{
    public string Name;
    public string Description;
    public int Price;
    public float FireRate;
    public GameObject TowerPrefab;
    public Sprite TowerSprite;
}
