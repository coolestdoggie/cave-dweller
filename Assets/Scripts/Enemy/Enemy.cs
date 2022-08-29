using UnityEngine;

namespace CaveDweller.Enemy
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private SideToSideMovement sideToSideMovement;

        private void Update()
        {
            Move();
        }

        private void Move()
        {
            sideToSideMovement.Move();
        }
    }
}
