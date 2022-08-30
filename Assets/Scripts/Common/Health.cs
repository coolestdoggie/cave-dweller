using System;
using UnityEngine;

namespace CaveDweller.Common
{
    [Serializable]
    public class Health
    {
        [field: SerializeField] public float MaxHealth { get; private set; }
        
        public float CurrentHealth { get; set; }

        public event Action Damaged;
        public event Action HealthReducedToZero;
        
        public void Init()
        {
            CurrentHealth = MaxHealth;
        }

        public void GetDamage(float damage)
        {
            if (damage <= 0)
            {
                return;
            }
            
            CurrentHealth -= damage;
            CurrentHealth = Mathf.Max(0, CurrentHealth);
            OnDamaged();
            
            if (CurrentHealth <= 0)
            {
                OnHealthReducedToZero();
            }
        }

        protected virtual void OnDamaged()
        {
            Damaged?.Invoke();
        }

        protected virtual void OnHealthReducedToZero()
        {
            HealthReducedToZero?.Invoke();
        }

    }
}