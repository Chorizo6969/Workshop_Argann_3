using UnityEngine;

/// <summary>
/// Script that allows you to create a Scriptable Object of zombies.
/// </summary>
[CreateAssetMenu(fileName = "Zombie1", menuName = "Zombie", order = 1)]
public class Zombie1 : ScriptableObject
{
    /// <summary>
    /// Set the speed of the zombie
    /// </summary>
    [field: SerializeField]
    public float MoveSpeed { get; private set; }

    /// <summary>
    /// Set the health of the zombie
    /// </summary>
    [field: SerializeField]
    public int Health { get; private set; }

    /// <summary>
    /// Set the sprite of the zombie
    /// </summary>
    [field: SerializeField]
    public Sprite Sprite { get; private set; }
}
