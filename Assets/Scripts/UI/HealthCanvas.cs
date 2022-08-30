using CaveDweller.Common;
using CaveDweller.UI;
using UnityEngine;

namespace CaveDweller
{
    public class HealthCanvas : MonoBehaviour
    {
        [SerializeField] private HealthBar healthBar;

        private Health playerHealth;
        
        public void Init(Health playerHealth)
        {
            this.playerHealth = playerHealth;
            
            healthBar.Init(playerHealth);
        }
    }
}
