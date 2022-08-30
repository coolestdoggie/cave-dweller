using CaveDweller.Common;
using UnityEngine;

namespace CaveDweller.Player
{
    public class Player : MonoBehaviour
    {
        [field: SerializeField] public Health Health { get; private set; }

        public void Init()
        {
            Health.Init();
        }
        
    }
}
