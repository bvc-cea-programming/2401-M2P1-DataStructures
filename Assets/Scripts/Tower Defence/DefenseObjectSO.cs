using UnityEngine;

[CreateAssetMenu(menuName = "Chanakan/DefenseObject", fileName = "New Defense Object")]
public class DefenseObjectSO : ScriptableObject
{
    public string objectName;
    public string description;
    public GameObject objectPrefab;
    public Sprite objectIcon;
    public int price;

}
