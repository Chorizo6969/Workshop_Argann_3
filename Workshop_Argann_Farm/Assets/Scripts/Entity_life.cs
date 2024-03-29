using UnityEngine;

/// <summary>
/// Script that manages plant life.
/// </summary>
public class Entity_life : MonoBehaviour
{
    [field: SerializeField]
    public int Life { get; set; }

    private void FixedUpdate()
    {
        if (Life <= 0)
        {
            Destroy(gameObject);
        }
    }
}
