using System.Collections;
using UnityEngine;

/// <summary>
/// Script that destroys the sun instance after few seconds.
/// </summary>
public class DestroySun : MonoBehaviour
{
    private void Awake()
    {
        StartCoroutine(Destroy());
    }

    /// <summary>
    /// Coroutine that destroys the sun instance after 16 seconds
    /// </summary>
    /// <returns> returns a new WaitForSeconds(16) </returns>
    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(16);
        Destroy(gameObject);
    }
}
