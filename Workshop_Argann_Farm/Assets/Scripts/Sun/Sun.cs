using UnityEngine;

/// <summary>
/// Script that manages the movement of suns in the garden.
/// </summary>
public class Sun : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.position += Vector3.down * Time.deltaTime * 2;
        Destroy(GetComponent<Sun>(), 5);
    }
}
