﻿using UnityEngine;

/// <summary>
/// Script that manages plant life.
/// </summary>
public class EntityLife : MonoBehaviour
{
    /// <summary>
    /// Int which defines the number of HP a plant has.
    /// </summary>
    [field: SerializeField]
    public int Life { get; set; }

    private void FixedUpdate()
    {
        if (Life <= 0)
        {
            Destroy(gameObject);
        }
    }
}
