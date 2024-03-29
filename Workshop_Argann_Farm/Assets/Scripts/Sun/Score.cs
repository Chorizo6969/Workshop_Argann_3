using TMPro;
using UnityEngine;

/// <summary>
/// Script that updates the text that displays the Player_score.
/// </summary>
public class Score : MonoBehaviour
{
    /// <summary>
    /// Text that displays the number of suns the player has.
    /// </summary>
    [field: SerializeField]
    public TextMeshProUGUI Txt_score { get; set; }

    /// <summary>
    /// Int that stores the number of suns the player has.
    /// </summary>
    [field: SerializeField]
    public int Player_score { get; set; }

    /// <summary>
    /// Function that is activated when you click on a sun
    /// </summary>
    /// <param name="sun"> Gameobject retrieved by raycast in the script Sun_interact</param>
    public void CollectSun(GameObject sun)
    {
        Player_score += 50;
        Txt_score.text = Player_score.ToString();
        Destroy(sun);
    }
}
