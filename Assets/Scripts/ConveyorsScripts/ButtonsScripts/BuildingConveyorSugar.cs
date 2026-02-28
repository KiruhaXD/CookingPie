using System.Linq;
using UnityEngine;
using UnityEngine.UI;


public class BuildingConveyorSugar : BuildingConveyors
{
    private SpawnSugar _spawnSugar;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnClick); // Подписываемся на нажатие кнопки
    }

    void OnClick()
    {
        GameObject sugarConveyor = GameObject.FindGameObjectWithTag("SugarConveyor");

        if (sugarConveyor != null)
        {
            Destroy(sugarConveyor); // Удаляем предыдущий объект, если он был
        }

        _currentDraggedObject = Instantiate(_objectPrefab);

        _spawnSugar = _currentDraggedObject.GetComponentInChildren<SpawnSugar>();

        if (_spawnSugar != null) 
        {
            Transform[] spawnPoints = _currentDraggedObject.GetComponentsInChildren<Transform>()
                 .Where(t => t.name.StartsWith("SpawnPoint"))
                 .ToArray();

            _spawnSugar.spawnPointForIngridients = spawnPoints;
        }
        

    }
}
