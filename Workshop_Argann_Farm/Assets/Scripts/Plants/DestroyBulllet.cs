using UnityEngine;

/// <summary>
/// Emergency script that allows you to destroy plant projectiles if they go too far
/// </summary>
public class DestroyBulllet : MonoBehaviour
{
    /// <summary>
    /// string which allows you to change the gameObject to destroy.
    /// </summary>
    [SerializeField]
    private string _layer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == _layer)
        {
            Destroy(collision.gameObject);
        }
    }
}
