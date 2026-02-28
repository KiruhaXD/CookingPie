using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SpawnFlour : MonoBehaviour
{
    [SerializeField] GameObject flourPrefab;
    [SerializeField] public Transform spawnPoint;

    // Время спавна
    [SerializeField] float _timeBtwSpawns = 10f;
    [SerializeField] float _startTimeBtwSpawns = 4f;

    public bool isCanSpawn = false;

    private void Awake()
    {
        isCanSpawn = false;
    }

    private void Start()
    {
        _timeBtwSpawns = _startTimeBtwSpawns;
    }

    public void StartSpawnIngridientFlour() 
    {
        if (_timeBtwSpawns <= 0)
        {
            GameObject flour = Instantiate(flourPrefab, spawnPoint.position, Quaternion.identity);
            _timeBtwSpawns = _startTimeBtwSpawns;
        }

        else
        {
            _timeBtwSpawns -= Time.deltaTime;
        }
    } 
}
