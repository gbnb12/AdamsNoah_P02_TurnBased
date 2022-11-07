using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    public void TakeDamage(int amount);
    public void Kill();

    public void Heal(int amount);
}
