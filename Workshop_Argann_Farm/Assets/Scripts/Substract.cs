using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// Script that subtracts suns when using plants.
/// </summary>
public class Substract : MonoBehaviour, IPointerUpHandler
{
    /// <summary>
    /// Links to the Score script.
    /// </summary>
    [SerializeField]
    private Score _scoreScript;

    /// <summary>
    /// Links to the Plants script.
    /// </summary>
    [SerializeField]
    private Plants Plants_script;

    /// <summary>
    /// Int which defines the cost of the plant
    /// </summary>
    [field : SerializeField]
    public int Sun_lose { get; set; }

    /// <summary>
    /// Function that removes suns then changes the display of the player's score.
    /// </summary>
    public void OnPointerUp(PointerEventData eventData)
    {
        {
            if (_scoreScript.Player_score < Sun_lose)
            {
                Plants_script.CanPlants = false;
            }
            else
            {
                Plants_script.CanPlants = true;
                _scoreScript.Player_score -= Sun_lose;
                _scoreScript.Txt_score.text = _scoreScript.Player_score.ToString();
            }
        }
    }
}
