using System.Collections;
using UnityEngine;

/// <summary>
/// Script that manages the behavior of zombies during an encounter with 1 plant.
/// </summary>
public class ZombieAttack : MonoBehaviour
{
    /// <summary>
    /// Links to th scripts ZombieManager
    /// </summary>
    [SerializeField]
    private ZombieManager _zombieMove; // boolean which allows the zombie to move, if false then it no longer moves

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
            _pvPlants = collision.GetComponent<EntityLife>().Life;
            StartCoroutine(Attack());
    }

    /// <summary>
    /// Coroutine that executes the zombie attack.
    /// </summary>
    /// <returns> Return a new WaitForSeconds (1).</returns>
    IEnumerator Attack()
    {
        _zombieMove._canMove = false;
        while (_pvPlants > 0)
        {
            yield return new WaitForSeconds (1);
            _pvPlants -= 2;
            if (_plants != null)
            {
                _plants.GetComponent<EntityLife>().Life = _pvPlants;
            }
        }
        _zombieMove._canMove = true;
    }
}
