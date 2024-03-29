using UnityEngine;
using UnityEngine.EventSystems;
/// <summary>
/// Script that subtracts suns when using plants.
/// </summary>
public class Substract : MonoBehaviour, IPointerUpHandler
{
    [SerializeField]
    private Score _scoreScript;

    [SerializeField]
    private Plants Plants_script;

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
                Plants_script.can_plants = false;
            }
            else
            {
                Plants_script.can_plants = true;
                _scoreScript.Player_score -= Sun_lose;
                _scoreScript.Txt_score.text = _scoreScript.Player_score.ToString();
            }
        }
    }
}
