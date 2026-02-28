using System.Collections;
using UnityEngine;

public class SpawnBox : MonoBehaviour
{
    [SerializeField] GameObject prefabBox;

    [SerializeField] GameObject _effectForDestroy;
    [SerializeField] AudioSource _audioSource;
    [SerializeField] AudioClip _clip;   

    [SerializeField] Transform spawnPointBox;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pie"))
        {
            GameObject spawnEffect = Instantiate(_effectForDestroy, transform.position, Quaternion.identity);
            StartSpawnBox();

            Destroy(spawnEffect, 1f);
        }
    }

    public void StartSpawnBox() 
    {
        Instantiate(prefabBox, spawnPointBox.position, Quaternion.identity);
        _audioSource.PlayOneShot(_clip);
    }
}
