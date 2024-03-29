using TMPro;
using UnityEngine;

/// <summary>
/// Script that updates the text that displays the Player_score.
/// </summary>
public class Score : MonoBehaviour
{
    [field: SerializeField]
    public TextMeshProUGUI Txt_score { get; set; }

    [field: SerializeField]
    public int Player_score { get; set; }

    /// <summary>
    /// Fonction qui s'active lorsque l'on clique sur un soleil
    /// </summary>
    /// <param name="sun"> Gameobject retrieved by raycast in the script Sun_interact</param>
    public void CollectSun(GameObject sun)
    {
        Player_score += 50;
        Txt_score.text = Player_score.ToString();
        Destroy(sun);
    }
}
