using UnityEngine;

public class Milk : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("YeastConveyor"))
        {
            Destroy(gameObject);
        }

    }
}
