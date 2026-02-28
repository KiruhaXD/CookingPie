using System.Collections.Generic;
using UnityEngine;

public class SpawnDough : MonoBehaviour
{
    [SerializeField] GameObject prefabsIngridientDough;

    [SerializeField] GameObject _effectForDestroy;

    [SerializeField] public Transform spawnPointForIngridientDough;

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Milk"))
        {
            GameObject spawnEffect = Instantiate(_effectForDestroy, transform.position, Quaternion.identity);
            StartSpawnIngridientDough();

            Destroy(spawnEffect, 1f);
        }
    }

    public void StartSpawnIngridientDough() 
    {
        Instantiate(prefabsIngridientDough, spawnPointForIngridientDough.position, Quaternion.identity);
    }

}
