using UnityEngine;

public class DropZone : MonoBehaviour
{
    public string expectedObjectTag;
    public bool isOccuiped = false;

    [SerializeField] public GameObject placedObject; // —сылка на размещенный объект

    private void OnTriggerStay(Collider other)
    {
        if (isOccuiped == false && other.CompareTag(expectedObjectTag)) 
        {
            // ‘иксируем объект в зоне
            other.transform.position = transform.position;
            other.transform.rotation = transform.rotation;
            isOccuiped = true;

            placedObject = other.gameObject;


        }
    }

    private void OnTriggerExit(Collider other)
    {
        isOccuiped = false;
        placedObject = null;
    }

}
