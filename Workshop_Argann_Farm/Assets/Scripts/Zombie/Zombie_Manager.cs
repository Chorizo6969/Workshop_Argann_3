using UnityEngine;

/// <summary>
/// Script that manages zombie behavior. It manages the life of zombies as well as their movement.
/// </summary>
public class Zombie_Manager : MonoBehaviour
{
    [SerializeField]
    private Zombie_1 _zombie;

    [SerializeField]
    private SpriteRenderer _skin;

    private float _speed;
    private int _health;
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
