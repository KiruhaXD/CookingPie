using UnityEngine;

public class Pie : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PackagedPie")) 
        {
            Destroy(gameObject);
        }
    }
}
