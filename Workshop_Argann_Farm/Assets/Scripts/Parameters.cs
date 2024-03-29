using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Script that allows you to control the game parameters. It manages the sound and the restart button.
/// </summary>
public class Parameters : MonoBehaviour
{
    [SerializeField]
    private AudioSource _audioSource;
    [SerializeField]
    private GameObject _on;

    /// <summary>
    /// Function which restarts the "Level_1" scene
    /// </summary>
    public void Restart()
    {
        SceneManager.LoadScene("Level_1");
    }

    /// <summary>
    /// Function that mutes game sound.
    /// </summary>
    public void Song_off()
    {
        _audioSource.Stop();
        _on.SetActive(false);
    }

    /// <summary>
    /// Function that starts the game sound.
    /// </summary>
    public void Song_on()
    {
        _audioSource.Play();
        _on.SetActive(true);
    }
}
