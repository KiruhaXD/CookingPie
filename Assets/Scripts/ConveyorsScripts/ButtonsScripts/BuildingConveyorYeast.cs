using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class BuildingConveyorYeast : BuildingConveyors
{
    private SpawnDough _spawnDough;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnClick); // Подписываемся на нажатие кнопки
    }

    void OnClick()
    {
        GameObject yeastConveyor = GameObject.FindGameObjectWithTag("YeastConveyor");

        if (yeastConveyor != null)
        {
            Destroy(yeastConveyor); // Удаляем предыдущий объект, если он был
        }

        _currentDraggedObject = Instantiate(_objectPrefab);

        _spawnDough = _currentDraggedObject.GetComponentInChildren<SpawnDough>();

        Transform newSpawnPoint = _currentDraggedObject.GetComponentInChildren<Transform>().Find("SpawnPointDough");

        if (newSpawnPoint != null)
        {
            _spawnDough.spawnPointForIngridientDough = newSpawnPoint;
        }


    }
}
