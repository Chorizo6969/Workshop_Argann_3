﻿using System.Collections;
using TMPro;
using UnityEngine;

/// <summary>
/// Script that manages the spawn of suns in the game.
/// </summary>
public class SunSpawn : MonoBehaviour
{
    /// <summary>
    /// Prefab of the gameObject Sun
    /// </summary>
    [SerializeField]
    private GameObject _sunPrefab;

    /// <summary>
    /// Links to the SunManager script.
    /// </summary>
    [SerializeField]
    private SunManager _manager;

    /// <summary>
    /// Links to the Score script.
    /// </summary>
    [SerializeField]
    private Score _script_Score;

    /// <summary>
    /// Text which will store the number of points the player has before redistributing it to the sun instance (which the sunflower produces)
    /// </summary>
    [SerializeField]
    private TextMeshProUGUI _txt_score;


    private void Start()
    {
        _manager = FindObjectOfType<SunManager>();
        _script_Score = _manager._scriptScore;
        _txt_score = _script_Score.TxtScore;
        StartCoroutine(Sunny());
    }

    /// <summary>
    /// Coroutine that allows the sunflower to make suns appear
    /// </summary>
    /// <returns> returns a new WaitForSeconds (15) </returns>
    IEnumerator Sunny()
    {
        while (true)
        {
            yield return new WaitForSeconds(15f);
            GameObject new_sun = Instantiate(_sunPrefab);
            new_sun.transform.position = gameObject.transform.position;
            new_sun.AddComponent<Score>();
            new_sun.GetComponent<Score>().TxtScore = _txt_score;
            new_sun.GetComponent<SunInteract>().ScoreSun = _script_Score;
            new_sun.GetComponent<Sun>().enabled = false;
        }
    }
}
