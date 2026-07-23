using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int startingHealth = 2;
    int currentHealth;

    void Awake()
    {
        currentHealth = startingHealth;
    }

    public void TakeDamage(int amount)
    {
        currentHealth-= amount;
        Debug.Log("current health: " + currentHealth);

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
