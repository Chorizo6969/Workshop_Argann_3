using TMPro;
using UnityEngine;

/// <summary>
/// Script that updates the text that displays the PlayerScore.
/// </summary>
public class Score : MonoBehaviour
{
    /// <summary>
    /// Text that displays the number of suns the player has.
    /// </summary>
    [field: SerializeField]
    public TextMeshProUGUI TxtScore { get; set; }

    /// <summary>
    /// Int that stores the number of suns the player has.
    /// </summary>
    [field: SerializeField]
    public int PlayerScore { get; set; }

    /// <summary>
    /// Function that is activated when you click on a sun
    /// </summary>
    /// <param name="sun"> Gameobject retrieved by raycast in the script Sun_interact</param>
    public void CollectSun(GameObject sun)
    {
        PlayerScore += 50;
        TxtScore.text = PlayerScore.ToString();
        Destroy(sun);
    }
}
