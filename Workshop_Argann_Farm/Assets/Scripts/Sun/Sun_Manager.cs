using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// <summary>
/// Script that manages the _speed of appearance of suns in the garden before instantiating it.
/// </summary>
public class Sun_Manager : MonoBehaviour
{

    [SerializeField]
    private List<Transform> _spawn_positions;
    [SerializeField]
    private GameObject _sun;
    [SerializeField]
    private TextMeshProUGUI _txt_score;
    [field : SerializeField]
    public Score _scriptScore {  get; set; }
    //Take the Player_score and give to the instance
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
            new_sun.GetComponent<Score>().Txt_score = _txt_score;
            new_sun.GetComponent<Sun_Interact>().Score_Sun = _scriptScore;
        }
    }
}
