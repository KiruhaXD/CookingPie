using UnityEngine;

public class Flour : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SugarConveyor") || other.CompareTag("EggsConveyor") || other.CompareTag("MilkConveyor") || other.CompareTag("YeastConveyor")) 
        {
            Destroy(gameObject);
        }

    }
}
