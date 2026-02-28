using System.Linq;
using UnityEngine;
using UnityEngine.UI;


public class BuildingConveyorEggs : BuildingConveyors
{
    private SpawnEggs _spawnEggs;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnClick); // Подписываемся на нажатие кнопки
    }

    void OnClick()
    {
        GameObject eggsConveyor = GameObject.FindGameObjectWithTag("EggsConveyor");

        if (eggsConveyor != null)
        {
            Destroy(eggsConveyor); // Удаляем предыдущий объект, если он был
        }

        _currentDraggedObject = Instantiate(_objectPrefab);

        _spawnEggs = _currentDraggedObject.GetComponentInChildren<SpawnEggs>();

        if (_spawnEggs != null)
        {
            Transform[] spawnPoints = _currentDraggedObject.GetComponentsInChildren<Transform>()
                .Where(t => t.name.StartsWith("SpawnPoint"))
                .ToArray();

            _spawnEggs.spawnPointForIngridients = spawnPoints;
        }


    }
}
