using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject damageZones;
    public int maxSpawns;        // How many hazards to spawn
    public float spawnRange;    // Max distance from the spawner

    void Start()
    {
        for (int i = 0; i < maxSpawns; i++)
        {
            float randomX = Random.Range(-spawnRange, spawnRange);
            float randomY = Random.Range(-spawnRange, spawnRange);
            float randomZ = Random.Range(-spawnRange, spawnRange);
            Vector3 spawnPos = new Vector3(transform.position.x + randomX, transform.position.y + randomY, transform.position.z + randomZ);

            Instantiate(damageZones, spawnPos, damageZones.transform.rotation);
        }
    }

   
   
   
    // Update is called once per frame
    void Update()
    {
        
    }
}
