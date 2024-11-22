using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] Transform zombiePrefab;
    [SerializeField] Transform[] spawnLocations;

    private void Start()
    {
        InvokeRepeating("SpawnZombie", 1.0f, 1.0f);
    }
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
            //SpawnZombie();
       
    }
    public void SpawnZombie()
    {
        int i = Random.Range(0, spawnLocations.Length);

        Instantiate(zombiePrefab, spawnLocations[i].position, spawnLocations[i].rotation);
    }
}