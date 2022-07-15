using UnityEngine;

public class HealthPowerup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == Constants.PLAYER_OBJECT)
        {
            Destroy(gameObject);
        }
    }
}
