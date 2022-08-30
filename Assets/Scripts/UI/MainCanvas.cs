using System.Collections;
using System.Collections.Generic;
using CaveDweller.Common;
using CaveDweller.Player;
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
