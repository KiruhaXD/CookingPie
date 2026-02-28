using UnityEngine;
using UnityEngine.UI;

public class BuildingConveyorFlour : BuildingConveyors
{
    [SerializeField] SpawnFlour _spawnFlour;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnClick); // Подписываемся на нажатие кнопки
    }

    void OnClick()
    {
        GameObject flourConveyor = GameObject.FindGameObjectWithTag("FlourConveyor");

        if (flourConveyor != null)
        {
            Destroy(flourConveyor); // Удаляем предыдущий объект, если он был
        }

        _currentDraggedObject = Instantiate(_objectPrefab);

        Transform newSpawnPoint = _currentDraggedObject.GetComponentInChildren<Transform>().Find("SpawnPointFlour");

        if (newSpawnPoint != null)
        {
            _spawnFlour.spawnPoint = newSpawnPoint;
        }
    }
}
