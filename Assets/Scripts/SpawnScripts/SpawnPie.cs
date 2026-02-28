using UnityEngine;

public class SpawnPie : MonoBehaviour
{
    [SerializeField] GameObject prefabsIngridientPie;

    [SerializeField] GameObject _effectForDestroy;

    [SerializeField] Transform spawnPointForIngridientPie;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Dough"))
        {
            GameObject spawnEffect = Instantiate(_effectForDestroy, transform.position, Quaternion.identity);
            StartSpawnIngridientPie();

            Destroy(spawnEffect, 1f);
        }
    }

    public void StartSpawnIngridientPie() 
    {
        Instantiate(prefabsIngridientPie, spawnPointForIngridientPie.position, Quaternion.identity);
    } 
}
