using UnityEngine;
using CreatorKitCode;

public class PotionSpawner : MonoBehaviour
{
    // This is the object we want to spawn (set this in the Inspector)
    public GameObject ObjectToSpawn;

    void Start()
    {
        // First spawn angle
        int angle = 15;
        // Start spawning from the object's position
        Vector3 spawnPosition = transform.position;

        // Rotate the direction by 15 degrees on the Y-axis
        Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        // Move the spawn position 2 units away in the calculated direction
        spawnPosition = transform.position + direction * 2;
        // Create (spawn) the object at that position
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);

        // Now, do the same thing with a different angle (55 degrees)
        angle = 55;
        direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        spawnPosition = transform.position + direction * 2;
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);

        // And again with another angle (95 degrees)
        angle = 95;
        direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        spawnPosition = transform.position + direction * 2;
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);
    }
}
