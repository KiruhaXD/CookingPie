using UnityEngine;

public class Box : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FinishPie"))
        {
            Destroy(gameObject);
        }

    }
}
