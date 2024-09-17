using UnityEngine;



[CreateAssetMenu(menuName = "DefenceObject", fileName = "NewDefenceObject")] // gives ability to create instance of this object

public class DefenseObjectSO : ScriptableObject
{
    public string objectname;
    public string description;
    public GameObject objectprefab;
    public Sprite objectIcon;
    public int Price;


}
