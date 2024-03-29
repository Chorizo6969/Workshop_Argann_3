using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Script that manages the appearance of zombies on the right of the screen
/// </summary>
public class ZombieSpawn : MonoBehaviour
{
    /// <summary>
    /// List of different zombie prefabs.
    /// </summary>
    [SerializeField]
    private List<GameObject> _zombiePrefab;

    /// <summary>
    /// List of different Transform positions to spawn zombies.
    /// </summary>
    [SerializeField]
    private List<Transform> _spawn_positions;

    private void Start()
    {
        StartCoroutine(Zombie());
    }

    /// <summary>
    /// Coroutine which manages the appearance of zombies on the right of the screen.
    /// </summary>
    /// <returns> Return a new WaitForSeconds (10).</returns>
    IEnumerator Zombie()
    {
        while (true)
        {
            yield return new WaitForSeconds(10);
            int random_pos = Random.Range(0, _spawn_positions.Count);
            Transform spawnPos = _spawn_positions[random_pos];
            int random_zombie = Random.Range(0, _zombiePrefab.Count);
            GameObject zombiePos = _zombiePrefab[random_zombie];
            GameObject newzombie = Instantiate(zombiePos);
            newzombie.transform.position = spawnPos.transform.position;
        }
    }
}
