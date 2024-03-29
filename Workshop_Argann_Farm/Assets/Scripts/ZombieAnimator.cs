using System.Collections;
using UnityEngine;

/// <summary>
/// Script that manages zombie animations
/// </summary>
public class ZombieAnimator : MonoBehaviour
{
    /// <summary>
    /// Links to the animation animator
    /// </summary>
    [SerializeField]
    private Animator _zombieAnimator;

    [SerializeField]
    private ZombieManager _zombieManager;

    /// <summary>
    /// Function that starts a death animation for the zombie before killing it
    /// </summary>
    public void OnDeath()
    {
        _zombieManager._canMove = false;
        _zombieAnimator.SetBool("isDeath", true);
        StartCoroutine(Delay());
    }

    /// <summary>
    /// Function that starts the attack animation
    /// </summary>
    public void OnAttack()
    {
        _zombieAnimator.SetBool("isAttack", true);
    }

    /// <summary>
    /// Function that ends the attack animation
    /// </summary>
    public void OnEndAttack()
    {
        _zombieAnimator.SetBool("isAttack", false);
    }

    /// <summary>
    /// Coroutine which allows you to see the death animation before destroying the zombie
    /// </summary>
    /// <returns> Returns a new WaitForSeconds (1.5f) </returns>
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1.7f);
        Destroy(gameObject);
    }
}
