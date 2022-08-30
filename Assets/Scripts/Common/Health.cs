using System;
using UnityEngine;

namespace CaveDweller.Common
{
    [Serializable]
    public class Health
    {
        [field: SerializeField] public float MaxHealth { get; private set; }
        
        public float CurrentHealth { get; set; }

        public void Init()
        {
            CurrentHealth = MaxHealth;
        }
    }
}