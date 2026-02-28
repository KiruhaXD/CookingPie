using Unity.VisualScripting;
using UnityEngine;

public class DisableGravityGround : MonoBehaviour
{
    [SerializeField] Rigidbody rb;

    private void Start()
    {
        rb.useGravity = true;
        rb.isKinematic = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground") 
        {
            FixedJoint joint = gameObject.AddComponent<FixedJoint>();
            joint.connectedBody = transform.parent.GetComponent<Rigidbody>();
            joint.enableCollision = true;

            rb.useGravity = false;
            rb.isKinematic = true;
        }
    }
}
