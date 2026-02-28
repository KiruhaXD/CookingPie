using System.Collections.Generic;
using UnityEngine;

public class SpawnMilk : MonoBehaviour
{
    [SerializeField] List<GameObject> prefabsIngridients;

    [SerializeField] GameObject _effectForDestroy;

    [SerializeField] public Transform[] spawnPointForIngridients;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Eggs"))
        {
            GameObject spawnEffect = Instantiate(_effectForDestroy, transform.position, Quaternion.identity);
            StartSpawnIngridientMilk();

            Destroy(spawnEffect, 1f);
        }
    }

    public void StartSpawnIngridientMilk()
    {
        // Да да я знаю выглядит не очень
        Instantiate(prefabsIngridients[0], spawnPointForIngridients[0].position, Quaternion.identity);
        Instantiate(prefabsIngridients[1], spawnPointForIngridients[1].position, Quaternion.identity);
        Instantiate(prefabsIngridients[2], spawnPointForIngridients[2].position, Quaternion.identity);
        Instantiate(prefabsIngridients[3], spawnPointForIngridients[3].position, Quaternion.identity);
    }
}
