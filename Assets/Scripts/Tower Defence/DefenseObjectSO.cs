using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/DefenseScriptableObject", order = 1)]
public class DefenseObjectSO : ScriptableObject
{
    [SerializeField] public string objectName;
    [SerializeField] public string objectDescription;
    [SerializeField] public int objectPrice;
    [SerializeField] public float fireRate;
    [SerializeField] public GridObject objectPrefab;
    [SerializeField] public Sprite objectSprite;
    [SerializeField] public Vector3 locationOffset;
}
