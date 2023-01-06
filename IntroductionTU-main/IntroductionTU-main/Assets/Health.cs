using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Events;
using System.Runtime.InteropServices;

public struct Health
{
    [SerializeField] int _maxHealth;
    [SerializeField] int _currentHealth;
    bool _isDead;

    public int MaxHealth { get => _maxHealth; set => _maxHealth = value; }
    public int CurrentHealth { get => _currentHealth; set => _currentHealth = value; }

    public bool IsDead { get => _isDead; set => _isDead = value; }

    public Health(int maxH, int currentH)
    {
        Assert.IsFalse(maxH < currentH || maxH <= 0 || currentH < 0);
        _maxHealth = maxH;
        _currentHealth = currentH;

        if(currentH == 0)
        {
            _isDead = true;
        }
        else
        {
            _isDead = false;
        }
    }

    public Health(int maxH)
    {
        Assert.IsFalse(maxH <= 0);
        _maxHealth = maxH;
        _currentHealth = maxH;
        _isDead = false;
    }

    public void TakeDamage(int damages)
    {
        
    }

}
