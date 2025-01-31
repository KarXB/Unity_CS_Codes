using UnityEngine;
using CreatorKitCode;

//add to a model to spawn potions with , and assign the object you want to spawn to the ObjectToSpawn variable
//This script spawns three copies of a specified object in a circular pattern around the original object's position at angles of 15°, 55°, and 95°
public class PotionSpawner : MonoBehaviour
{
    // The object (potion) to spawn, assign it in the Inspector.
    public GameObject ObjectToSpawn;

    void Start()
    {
        // Call the SpawnPotion method with different angles to place the potions in a circular pattern.
        SpawnPotion(0);    // Spawns a potion at 0° right side
        SpawnPotion(45);   // Spawns a potion at 45° 45 angles to front-right
        SpawnPotion(90);   // Spawns a potion at 90° front
        SpawnPotion(135);  // Spawns a potion at 135° 45 angles to front-left
    }

    // Spawns a potion at a specified angle around the object
    void SpawnPotion(int angle)
    {
        int radius = 5; // Distance from the center where potions will spawn
        // Calculate direction based on the angle
        Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        // Determine the spawn position by moving 'radius' units in the calculated direction
        Vector3 spawnPosition = transform.position + direction * radius;
        // Instantiate (spawn) the potion at the calculated position
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);
    }
}