using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class BuildingConveyorMilk : BuildingConveyors
{
    private SpawnMilk _spawnMilk;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnClick); // Подписываемся на нажатие кнопки
    }

    void OnClick()
    {
        GameObject milkConveyor = GameObject.FindGameObjectWithTag("MilkConveyor");

        if (milkConveyor != null)
        {
            Destroy(milkConveyor); // Удаляем предыдущий объект, если он был
        }

        _currentDraggedObject = Instantiate(_objectPrefab);

        _spawnMilk = _currentDraggedObject.GetComponentInChildren<SpawnMilk>();

        if (_spawnMilk != null)
        {
            Transform[] spawnPoints = _currentDraggedObject.GetComponentsInChildren<Transform>()
                .Where(t => t.name.StartsWith("SpawnPoint"))
                .ToArray();

            _spawnMilk.spawnPointForIngridients = spawnPoints;
        }


    }
}
