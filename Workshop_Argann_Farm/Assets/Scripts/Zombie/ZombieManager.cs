using UnityEngine;

/// <summary>
/// Script that manages zombie behavior. It manages the life of zombies as well as their movement.
/// </summary>
public class ZombieManager : MonoBehaviour
{
    /// <summary>
    /// Link to Scriptable Object Zombie
    /// </summary>
    [SerializeField]
    private Zombie1 _zombie;

    /// <summary>
    /// SpriteRenderer of the gameObject carrying the script in order to change its appearance
    /// </summary>
    [SerializeField]
    private SpriteRenderer _skin;

    /// <summary>
    /// Float which defines the speed of zombies
    /// </summary>
    private float _speed;

    /// <summary>
    /// Int which defines the zombie's health
    /// </summary>
    private int _health;

    /// <summary>
    /// Boolean which defines if the zombie can move to the left
    /// </summary>
    internal bool _can_move { get;  set; } = true;

    private void Start()
    {
        _speed = _zombie.Movespeed;
        _health = _zombie.Health;
        _skin.sprite = _zombie.Sprite;
    }

    private void FixedUpdate()
    {
        if (!_can_move) return;
        transform.Translate(Vector3.left * _speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            _health--;
            if (_health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
