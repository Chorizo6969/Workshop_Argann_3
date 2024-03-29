using UnityEngine;

/// <summary>
/// Emergency script that allows you to destroy plant projectiles if they go too far
/// </summary>
public class Destroy_bulllet : MonoBehaviour
{
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
