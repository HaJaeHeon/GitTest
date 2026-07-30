using UnityEngine;

public class FireBlast : MonoBehaviour
{
    private void Update()
    {
        
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {

        }
    }
}
