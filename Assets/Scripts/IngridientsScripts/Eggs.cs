using UnityEngine;

public class Eggs : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MilkConveyor") || other.CompareTag("YeastConveyor"))
        {
            Destroy(gameObject);
        }

    }
}
