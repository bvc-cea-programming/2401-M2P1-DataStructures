using UnityEngine;
[CreateAssetMenu(menuName ="DefenseObject",fileName ="New Defebse Ibhect")]

public class DefenseObjectSO : ScriptableObject
{
    public string name;
    public string description;
    public GameObject objectPerfabs;
    public Sprite objectIcon;
    public int price;

    private void Interact()
    {

    }

}
