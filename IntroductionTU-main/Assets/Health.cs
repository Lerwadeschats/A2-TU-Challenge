using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Events;

public struct Health
{
    [SerializeField] int _maxHealth;
    int _currentHealth;
    bool _isDead;
    public int MaxHealth { get => _maxHealth; set => _maxHealth = value; }
    public int CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
    public bool IsDead { get => _isDead; set => _isDead = value; }

    public Health(int max,int current)
    {
        Assert.IsFalse(max < current || max <= 0|| current<0);
        _maxHealth = max;
        _currentHealth = current;
        if (current == 0)
        {
            _isDead = true;
        }
        else
        {
            _isDead = false;
        }
    }
    public Health(int max)
    {
        Assert.IsFalse(max <= 0);
        _maxHealth = max;
        _currentHealth = max;
        _isDead = false;
    }
    public void TakeDamage(int damage)
    {
        Assert.IsFalse(damage < 0);
        CurrentHealth -= damage;
        if (CurrentHealth < 0)
        {
            CurrentHealth = 0;
        }
        if (CurrentHealth == 0)
        {
            IsDead = true;
        }
        else
        {
            IsDead = false;
        }
    }
    public void Heal(int heal)
    {
        Assert.IsFalse(heal < 0);
        CurrentHealth += heal;
        if(CurrentHealth > MaxHealth)
        {
            CurrentHealth = MaxHealth;
        }
        if (CurrentHealth == 0)
        {
            IsDead = true;
        }
        else
        {
            IsDead = false;
        }
    }    
}
