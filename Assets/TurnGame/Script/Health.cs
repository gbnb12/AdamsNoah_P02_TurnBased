using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
<<<<<<< HEAD
using UnityEngine.SceneManagement;
=======
>>>>>>> main

public class Health : MonoBehaviour, IDamageable
{
    public int _currentHealth = 100;

    [SerializeField] Text _healthText;

<<<<<<< HEAD
    public GameObject targetObject;


=======
>>>>>>> main
    void Start()
    {
        _currentHealth = 100;
    }

    public void Kill()
    {
<<<<<<< HEAD
        Destroy(targetObject);
    }

    public void TakeAttackDamage(int amount)
=======
        Destroy(gameObject);
    }

    public void TakeDamage(int amount)
>>>>>>> main
    {
        _currentHealth -= amount;
        _healthText.GetComponent<Text>().text = "Health: " + _currentHealth;
        Debug.Log("Game Piece took damage: " + amount);
        if(_currentHealth <= 0)
        {
            Kill();
        }
    }

<<<<<<< HEAD
    public void TakeLaserDamage(int number)
    {
        _currentHealth -= number;
        _healthText.GetComponent<Text>().text = "Health: " + _currentHealth;
        Debug.Log("Game Piece took damage: " + number);
        if (_currentHealth <= 0)
        {
            Kill();
        }
    }

    public void Heal(int level)
    {
        _currentHealth += level;
        _healthText.GetComponent<Text>().text = "Health: " + _currentHealth;
=======
    public void Heal(int level)
    {
        _currentHealth += level;
>>>>>>> main
    }
}
