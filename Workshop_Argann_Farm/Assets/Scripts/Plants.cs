using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// Script that manages the drag and drop of plants on the ground.
/// </summary>
public class Plants : MonoBehaviour, IPointerDownHandler, IPointerUpHandler  // Merci à la chaine code Monkey pour le code (ce n'est pas le même mais ils m'ont bien aider
{
    /// <summary>
    /// Boolean which allows you to check if the player can plant a plant.
    /// </summary>
    [field: SerializeField]
    public bool can_plants { get; set; } = false;

    /// <summary>
    /// Plant prefab
    /// </summary>
    [SerializeField]
    private GameObject _plantPrefab;

    /// <summary>
    /// Instance of my plant prefab
    /// </summary>
    private GameObject _draggedObject;

    /// <summary>
    /// Boolean that checks if the player is currently dragging the plant
    /// </summary>
    private bool _isDragging = false;

    /// <summary>
    /// Vector 2 which determines the position where the plant can be placed
    /// </summary>
    private Vector2 _spawnPosition;

    private void Update()
    {
        if (!_isDragging) return;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _draggedObject.transform.position = mousePosition;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (!can_plants) return;
            _isDragging = true;
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            _spawnPosition = mousePosition;
            _draggedObject = Instantiate(_plantPrefab, _spawnPosition, Quaternion.identity);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _isDragging = false;
    }
}
