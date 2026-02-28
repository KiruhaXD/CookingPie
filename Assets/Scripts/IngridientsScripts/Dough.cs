using UnityEngine;

public class Dough : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Stove"))
        {
            Destroy(gameObject, 1f);
        }

    }
}
