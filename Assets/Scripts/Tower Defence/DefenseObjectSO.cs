using UnityEngine;

[CreateAssetMenu(fileName = "NewDefenseObject", menuName = "Defense Object", order = 51)]
public class DefenseObjectSO : ScriptableObject
{
    public string objectName;
    public GameObject prefab;
}
