using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   [SerializeField] private int speedPlayer;
private Rigidbody2D rb;
private Vector2 moveDirection;
private Transform transform;
void Start()
{
    rb = GetComponent<Rigidbody2D>();  
    transform = GetComponent<Transform>();
 
}

void FixedUpdate()
{
    Move();
}



void Move()
{
   
    
    float horizontal = Input.GetAxisRaw("Horizontal");
    float vertical = Input.GetAxisRaw("Vertical");
    
    moveDirection = new Vector2(horizontal, vertical);
    
    Vector3 movePosition = (speedPlayer * Time.fixedDeltaTime * moveDirection.normalized) + rb.position;
    rb.MovePosition(movePosition);

    

}


}
