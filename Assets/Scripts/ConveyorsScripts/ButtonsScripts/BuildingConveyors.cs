using UnityEngine;

public class BuildingConveyors : MonoBehaviour
{
    [SerializeField] protected GameObject _objectPrefab; // Префаб объекта, который появится при нажатии

    private protected GameObject _currentDraggedObject;

    private Camera _mainCamera;

    private void Awake()
    {
        _mainCamera = Camera.main;
    }

    public void Update()
    {
        if (_currentDraggedObject != null)
        {
            var groundPlane = new Plane(Vector3.up, Vector3.zero);
            Ray ray = _mainCamera.ScreenPointToRay(Input.mousePosition);

            if (groundPlane.Raycast(ray, out float position))
            {
                Vector3 worldPosition = ray.GetPoint(position);

                int x = Mathf.RoundToInt(worldPosition.x); // здесь мы округляем до целочисленных значений чтоб мы могли ставить объект по клеткам(сетка) как система строительства зданий
                int z = Mathf.RoundToInt(worldPosition.z);

                _currentDraggedObject.transform.position = new Vector3(x, 0, z);

                if (Input.GetMouseButtonDown(0)) // Ставим объект в выбранной области
                {
                    _currentDraggedObject = null;
                }
            }
        }
    }
}
