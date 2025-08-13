using UnityEngine;

public class Inimigo : MonoBehaviour
{
   private Vida hp;

// Start is called once before the first execution of Update after the MonoBehaviour is created
void Start()
{
    hp = GetComponent<Vida>();
}

// Update is called once per frame
void Update()
{
    
}

void OnCollisionEnter2D(Collision2D collision) 
{
    if (collision.gameObject.tag == "Player")
    {
        hp.vida = hp.vida - 20;
    }
}
}
