using UnityEngine;

public class Sugar : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EggsConveyor") || other.CompareTag("MilkConveyor") || other.CompareTag("YeastConveyor"))
        {
            Destroy(gameObject);
        }

    }
}
