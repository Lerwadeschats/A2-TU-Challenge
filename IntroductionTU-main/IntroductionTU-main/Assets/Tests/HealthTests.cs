using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class HealthTests
{
    /*[Test]
    public void HealthMustBeStruct()
    {
        Assert.IsTrue(typeof(Health).IsClass == false);
    }

    #region Constructor
    [Test]
    public void CreateHealthWithMaxAndCurrent()
    {
        int maxHealth = 100;
        int health = 10;
        Health h = new Health(maxHealth, health);

        Assert.AreEqual(h.MaxHealth, maxHealth);
        Assert.AreEqual(h.CurrentHealth, health);
    }

    [Test]
    public void CreateHealthWithOnlyMax()
    {
        int maxHealth = 100;
        Health h = new Health(maxHealth);

        Assert.AreEqual(h.MaxHealth, maxHealth);
        Assert.AreEqual(h.CurrentHealth, maxHealth);
    }

    [Test]
    public void CreateHealthWithHigherCurrentHealthThanMax()
    {
        Assert.Throws(typeof(UnityEngine.Assertions.AssertionException), () =>
        {
            Health h = new Health(100, 200);
        });

    }

    [Test]
    public void CreateHealthWithNegativMaxHealth()
    {
        Assert.Throws(typeof(UnityEngine.Assertions.AssertionException), () =>
        {
            Health h = new Health(-100, 10);
        });
    }

    [Test]
    public void CreateHealthWithNegativHealth()
    {
        Assert.Throws(typeof(UnityEngine.Assertions.AssertionException), () =>
        {
            Health h = new Health(100, -10);
        });
    }

    [Test]
    public void CreateHealthWith0MaxHealth()
    {
        Assert.Throws(typeof(UnityEngine.Assertions.AssertionException), () =>
        {
            Health h = new Health(0);
        });
    }

    [Test]
    public void CreateHealthWith0Health()
    {
        Health h = new Health(100, 0);
        Assert.IsTrue(h.IsDead);
    }
    #endregion

    #region Damage
    [Test]
    public void CreateHealthThenTakeDamage()
    {
        Health h = new Health(100); 

        h.TakeDamage(10);

        Assert.AreEqual(90, h.CurrentHealth);
        Assert.AreEqual(100, h.MaxHealth);
        Assert.IsFalse(h.IsDead);
    }

    [Test]
    public void CreateHealthThenHugeTakeDamage()
    {
        Health h = new Health(100);

        h.TakeDamage(1000);

        Assert.AreEqual(0, h.CurrentHealth);
        Assert.AreEqual(100, h.MaxHealth);
        Assert.IsTrue(h.IsDead);
    }

    [Test]
    public void HealthTakeNegativDamage()
    {
        Health h = new Health(100);

        Assert.Throws(typeof(UnityEngine.Assertions.AssertionException), () =>
        {
            h.TakeDamage(-1000);
        });
    }

    [Test]
    public void HealthTake0Damage()
    {
        Health h = new Health(100);

        h.TakeDamage(0);

        Assert.AreEqual(100, h.CurrentHealth);
        Assert.AreEqual(100, h.MaxHealth);
    }

#endregion

    #region Heal
    [Test]
    public void Heal()
    {
        Health h = new Health(100, 50);

        h.Heal(10);

        Assert.AreEqual(60, h.CurrentHealth);
        Assert.AreEqual(100, h.MaxHealth);
    }
    [Test]
    public void Healhuge()
    {
        Health h = new Health(100, 50);

        h.Heal(1000);

        Assert.AreEqual(100, h.CurrentHealth);
        Assert.AreEqual(100, h.MaxHealth);
    }
    [Test]
    public void HealWith0()
    {
        Health h = new Health(100, 50);

        h.Heal(0);

        Assert.AreEqual(50, h.CurrentHealth);
        Assert.AreEqual(100, h.MaxHealth);
    }
    [Test]
    public void HealWithNegativ()
    {
        Health h = new Health(100, 50);

        Assert.Throws(typeof(UnityEngine.Assertions.AssertionException), () =>
        {
            h.Heal(-10);
        });
    }
    #endregion

    #region DamageAndHeal
    [Test]
    public void DamageAndHeal()
    {
        Health h = new Health(100, 60);

        h.TakeDamage(10);
        Assert.AreEqual(50, h.CurrentHealth);

        h.Heal(20);
        Assert.AreEqual(70, h.CurrentHealth);
    }

    [Test]
    public void DamageAndRevive()
    {
        Health h = new Health(100, 60);

        h.TakeDamage(1000);
        Assert.AreEqual(0, h.CurrentHealth);
        Assert.IsTrue(h.IsDead);

        h.Heal(20);
        Assert.AreEqual(20, h.CurrentHealth);
        Assert.IsFalse(h.IsDead);
    }
    #endregion*/

}
