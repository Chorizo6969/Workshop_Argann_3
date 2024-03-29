﻿using UnityEngine;

/// <summary>
/// Script that manages the interaction between the mouse and the suns.
/// </summary>
public class Sun_Interact : MonoBehaviour
{
    [field :SerializeField]
    public Score Score_Sun { get; set; }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Clic gauche
        {
            Vector2 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(clickPosition, Vector2.zero);

            if (hit.collider != null)
            {
                GameObject hitObject = hit.collider.gameObject;
                if (hitObject.CompareTag("Soleil")) // Si le tag est soleil je lance la fonction pour le détruire
                {
                    Score_Sun.CollectSun(hitObject);
                }
            }
        }
    }
}