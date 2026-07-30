using UnityEngine;

public class EnemyCollision : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Skill"))
        {
            Debug.Log("TriggerStay");
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Skill"))
        {
            Debug.Log("CollisionStay");
        }
    }
}
