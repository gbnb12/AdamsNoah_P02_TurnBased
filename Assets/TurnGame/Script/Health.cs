using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour, IDamageable
{
    public int _currentHealth = 100;

    [SerializeField] Text _healthText;

    void Start()
    {
        _currentHealth = 100;
    }

    public void Kill()
    {
        Destroy(gameObject);
    }

    public void TakeDamage(int amount)
    {
        _currentHealth -= amount;
        _healthText.GetComponent<Text>().text = "Health: " + _currentHealth;
        Debug.Log("Game Piece took damage: " + amount);
        if(_currentHealth <= 0)
        {
            Kill();
        }
    }

    public void Heal(int level)
    {
        _currentHealth += level;
    }
}
