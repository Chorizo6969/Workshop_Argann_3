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
    private Plants _plantsScript;

    /// <summary>
    /// Int which defines the cost of the plant
    /// </summary>
    [field : SerializeField]
    public int SunLose { get; set; }

    /// <summary>
    /// Function that removes suns then changes the display of the player's score.
    /// </summary>
    public void OnPointerUp(PointerEventData eventData)
    {
        {
            if (!_plantsScript.CanPlants) return;
            _scoreScript.PlayerScore -= SunLose;
            _scoreScript.TxtScore.text = _scoreScript.PlayerScore.ToString();
        }
    }

    private void Update()
    {
        if (_scoreScript.PlayerScore < SunLose)
        {
            _plantsScript.CanPlants = false;
        }
        else
        {
            _plantsScript.CanPlants = true;
        }
    }
}
