using System;
using UnityEditor;
using UnityEngine;

namespace Assets.Scripts.GameCore.Health
{
    public abstract class objectHealth : MonoBehaviour, IDamagible
    {
        [SerializeField] private float _maxHealth;
        [SerializeField] private float _currentHealth;

        public float MaxHealth => _maxHealth;
        public float CurrentHealth => _currentHealth;

        public virtual void TakeDamage(float damage)
        {
            if(damage <= 0)
                throw new ArgumentOutOfRangeException(nameof(damage));
             _currentHealth -= damage;
        }

        public void TakeHeal(float value)
        {
            if(value <= 0)
                throw new ArgumentOutOfRangeException(nameof(value));
            _currentHealth += value;
            if(_currentHealth > _maxHealth)
                _currentHealth = _maxHealth;
        }

        private void OnEnable() => _currentHealth = _maxHealth;
    }
}