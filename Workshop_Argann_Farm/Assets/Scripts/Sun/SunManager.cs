using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// <summary>
/// Script that manages the _speed of appearance of suns in the garden before instantiating it.
/// </summary>
public class SunManager : MonoBehaviour
{
    /// <summary>
    /// List of positions where the sun can appear.
    /// </summary>
    [SerializeField]
    private List<Transform> _spawn_positions;

    /// <summary>
    /// Prefab of the gameObject Sun
    /// </summary>
    [SerializeField]
    private GameObject _sun;

    /// <summary>
    /// Text that allows the instantiated sun to recover the score.
    /// </summary>
    [SerializeField]
    private TextMeshProUGUI _txt_score;

    /// <summary>
    /// Links to the Score script.
    /// </summary>
    [field : SerializeField]
    public Score _scriptScore {  get; set; }

    /// <summary>
    /// Links to the Sun script.
    /// </summary>
    [SerializeField]
    private Sun _sunscript;


    private void Start()
    {
        StartCoroutine(Sun_delay());
    }

    /// <summary>
    /// Determines the spawn of garden suns.
    /// </summary>
    /// <returns>Coroutine who return a new WaitForSeconds (10)f.</returns>
    IEnumerator Sun_delay()
    {
        while (true)
        {
            yield return new WaitForSeconds(10f);
            int random = Random.Range(1, _spawn_positions.Count);
            Transform spawnPos = _spawn_positions[random];
            GameObject new_sun = Instantiate(_sun);
            new_sun.transform.position = spawnPos.position;
            new_sun.AddComponent<Score>();
            new_sun.GetComponent<Score>().TxtScore = _txt_score;
            new_sun.GetComponent<SunInteract>().ScoreSun = _scriptScore;
        }
    }
}
