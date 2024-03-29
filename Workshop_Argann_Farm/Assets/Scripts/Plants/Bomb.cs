using UnityEngine;

/// <summary>
/// Script that manages the behavior of the plant : Bomb.
/// </summary>
public class Bomb : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Zombie"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
