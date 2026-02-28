using UnityEngine;

public class ConveyorMove : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float speedMove;
    [SerializeField] Material material;

    private void FixedUpdate()
    {
        material.mainTextureOffset = new Vector2(0f, -(Time.time * 5 * Time.deltaTime)); // задаем движение текстуры со скоростью 5 по Y координате(инвертируем)
        Vector3 pos = rb.position;
        rb.position += -(Vector3.forward) * speedMove * Time.fixedDeltaTime; // задаем позицию объекта который будет соприкосаться с конвеером и двигаем объект, например(молоко) вперед(инвертируем)
        rb.MovePosition(pos); 
    }
}
