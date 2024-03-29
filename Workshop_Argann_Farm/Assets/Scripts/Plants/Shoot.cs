using System.Collections;
using UnityEngine;

/// <summary>
/// Script that allows plants to fire projectiles when it sees a zombie.
/// </summary>
public class Shoot : MonoBehaviour
{
    /// <summary>
    /// Prefab of the gameObject Bullet.
    /// </summary>
    [SerializeField]
    private GameObject _bulletPrefab;

    /// <summary>
    /// GameObject which allows spawn point for bullets.
    /// </summary>
    [SerializeField]
    private GameObject _spawnpoint;

    /// <summary>
    /// Variable that stores the coroutine
    /// </summary>
    private Coroutine _coroutine;

    /// <summary>
    /// Int which allows you to define in the inspector whether the plant produces 1 or 2 peas.
    /// </summary>
    [SerializeField]
    private int _numberShoot = 1;

    /// <summary>
    /// Allows you to know the number of zombies in the plant's line of sight.
    /// </summary>
    private int _zombiesInRange;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != ("Zombie")) return;

        _zombiesInRange++;
        if (_zombiesInRange == 1)
        {
            _coroutine = StartCoroutine(Cooldown());
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag != ("Zombie")) return;

        _zombiesInRange--;
        if (_zombiesInRange != 0) return;

            StopCoroutine(_coroutine);
    }

    /// <summary>
    /// Allows you to put a cooldown on the plants when it shoots.
    /// </summary>
    /// <returns></returns>
    IEnumerator Cooldown()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            GameObject newbullet = Instantiate(_bulletPrefab);
            newbullet.transform.position = _spawnpoint.transform.position;
            if (_numberShoot != 2) yield return Cooldown();
            yield return new WaitForSeconds(0.3f);
            GameObject newbullet2 = Instantiate(_bulletPrefab);
            newbullet2.transform.position = _spawnpoint.transform.position;
        }
    }
}
