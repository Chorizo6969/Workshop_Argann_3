using System.Collections;
using TMPro;
using UnityEngine;

/// <summary>
/// Script that manages the spawn of suns in the game.
/// </summary>
public class Sun_Spawn : MonoBehaviour
{
    [SerializeField]
    private GameObject _sunPrefab;
    [SerializeField]
    private Sun_Manager _manager;


    [SerializeField]
    private Score _scriptScore;
    [SerializeField]
    private TextMeshProUGUI _txt_score;


    private void Start()
    {
        _manager = FindObjectOfType<Sun_Manager>();
        _scriptScore = _manager._scriptScore;
        _txt_score = _scriptScore.Txt_score;
        StartCoroutine(Sunny());
    }

    IEnumerator Sunny()
    {
        while (true)
        {
            yield return new WaitForSeconds(15f);
            GameObject new_sun = Instantiate(_sunPrefab);
            new_sun.transform.position = gameObject.transform.position;
            new_sun.AddComponent<Score>();
            new_sun.GetComponent<Score>().Txt_score = _txt_score;
            new_sun.GetComponent<Sun_Interact>().Score_Sun = _scriptScore;
        }
    }
}
