using UnityEngine;

public class PracticeArrays : MonoBehaviour
{
    [SerializeField]
    public GameObject[] skeletonP;
    [SerializeField]
    public Transform spawner;
    [SerializeField]
    private GameObject cEnemy; //current enemy
    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DestroyPreviousEnemy();
            GenerateRandomEnemy();
        }
    }
    
    private void GenerateRandomEnemy()
    {
        int randomIndex = Random.Range(0, skeletonP.Length);

        cEnemy = Instantiate(skeletonP[randomIndex], spawner.position, spawner.rotation);
    }
    public void DestroyPreviousEnemy()
    {
        if (cEnemy != null)
        {
            Destroy(cEnemy);
        }

    }
}
