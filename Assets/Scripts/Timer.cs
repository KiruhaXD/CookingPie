using System.Collections;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] int _startTime = 1;
    [SerializeField] SpawnFlour _spawnFlour;

    private void Awake()
    {
        _spawnFlour.isCanSpawn = false;
    }

    private void Update()
    {
        if (_spawnFlour.isCanSpawn == true) 
        {
            _spawnFlour.StartSpawnIngridientFlour();
        }

    }

    public void СoutDown()
    {
        StartCoroutine(CoutDownTime());
    }

    IEnumerator CoutDownTime()
    {
        Debug.Log("Кнопка нажата");

        while (_startTime > 0)
        {
            yield return new WaitForSeconds(1);
            _startTime--;
        }

        yield return new WaitForSeconds(1);

        _spawnFlour.isCanSpawn = true;
        Debug.Log("Спавн начался");
    }
}
