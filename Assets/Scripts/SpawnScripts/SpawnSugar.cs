using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSugar : MonoBehaviour
{
    [SerializeField] List<GameObject> prefabsIngridients;

    [SerializeField] GameObject _effectForDestroy;

    [SerializeField] public Transform[] spawnPointForIngridients;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Flour")) 
        {
            GameObject spawnEffect = Instantiate(_effectForDestroy, transform.position, Quaternion.identity);
            StartSpawnIngridientSugar();

            Destroy(spawnEffect, 1f);
        }
    }

    public void StartSpawnIngridientSugar() 
    {
        // Да да я знаю выглядит не очень
        Instantiate(prefabsIngridients[0], spawnPointForIngridients[0].position, Quaternion.identity);
        Instantiate(prefabsIngridients[1], spawnPointForIngridients[1].position, Quaternion.identity);
    } 

}
