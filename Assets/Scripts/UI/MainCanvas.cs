using CaveDweller.Common;
using UnityEngine;

namespace CaveDweller
{
    public class MainCanvas : MonoBehaviour
    {
        [SerializeField] private HealthCanvas healthCanvas;

        public void Init(Health playerHealth)
        {
            healthCanvas.Init(playerHealth);
        }
    }
}
