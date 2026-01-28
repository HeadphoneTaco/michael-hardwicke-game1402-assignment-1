using UnityEngine;

public class Collector : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Debug.Log("Coin Collected");
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Health"))
        {
            Debug.Log("Health Collected");
            Destroy(other.gameObject);
        }
    }
}
