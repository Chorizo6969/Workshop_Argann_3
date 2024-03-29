using UnityEngine;

/// <summary>
/// Scripts that manage the movement of the peeshooters ball.
/// </summary>
public class Bullet : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.Translate(Vector3.right * Time.deltaTime * 4);
    }
}
