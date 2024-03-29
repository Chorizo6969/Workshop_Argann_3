using UnityEngine;

/// <summary>
/// Script that allows you to create a Scriptable Object of zombies.
/// </summary>
[CreateAssetMenu(fileName = "Zombie_1", menuName = "Zombie", order = 1)]
public class Zombie_1 : ScriptableObject
{
    [field: SerializeField]
    public float Movespeed { get; private set; }

    [field: SerializeField]
    public int Health { get; private set; }

    [field: SerializeField]
    public Sprite Sprite { get; private set; }
}
