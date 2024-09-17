using UnityEngine;

[CreateAssetMenu(menuName = "DefenceObject", fileName = "NewDefenceObject")]
public class DefenseObjectSO : ScriptableObject
{
    public string objectName;
    public string description;
    public GameObject objectPrefab;
    public Sprite objecticon;
    public int price;
}

