using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public int initialHealth = 100;
    public float hurtDuration = 0.5f;
    public int health;

    private bool isHurt;

    // Start is called before the first frame update
    void Start()
    {
        health = initialHealth;
    }

    // Update is called once per frame
    void Update()
    {
    }
}