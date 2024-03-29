using System.Collections;
using UnityEngine;

/// <summary>
/// Script that manages the behavior of zombies during an encounter with 1 plant.
/// </summary>
public class Zombie_attack : MonoBehaviour
{
    /// <summary>
    /// Links to th scripts Zombie_Manager
    /// </summary>
    [SerializeField]
    private Zombie_Manager _zombie_move; // boolean which allows the zombie to move, if false then it no longer moves

    /// <summary>
    /// Collect the plant that the zombie touches
    /// </summary>
    private GameObject _plants;

    /// <summary>
    /// Recovers the number of HP the plant has
    /// </summary>
    private int _pvPlants;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Plante") return;
            _plants = collision.gameObject;
            _pvPlants = collision.GetComponent<Entity_life>().Life;
            StartCoroutine(Attack());
    }

    /// <summary>
    /// Coroutine that executes the zombie attack.
    /// </summary>
    /// <returns> Return a new WaitForSeconds (1).</returns>
    IEnumerator Attack()
    {
        _zombie_move._can_move = false;
        while (_pvPlants > 0)
        {
            yield return new WaitForSeconds (1);
            _pvPlants -= 2;
            _plants.GetComponent<Entity_life>().Life = _pvPlants;
        }
        _zombie_move._can_move = true;
    }
}
