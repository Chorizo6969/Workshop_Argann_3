using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Class which manages the reloading of the scene.
/// </summary>
public class RestartButton : MonoBehaviour
{
    /// <summary>
    /// Function which restarts the "Level_1" scene
    /// </summary>
    public void Restart()
    {
        SceneManager.LoadScene("Level_1");
    }
}
