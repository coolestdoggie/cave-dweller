using UnityEngine;

namespace CaveDweller.Enemy
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private SideToSideMovement sideToSideMovement;
        [SerializeField] private JumpingAttack jumpingAttack;
        [SerializeField] private Rigidbody2D rb2d;
        private void Start()
        {
            var player = FindObjectOfType<Player>();
            jumpingAttack.Init(player.transform, rb2d);
        }
        
        private void Update()
        {
            Move();
            jumpingAttack.CheckForAttack();
        }

        private void Move()
        {
            sideToSideMovement.Move();
        }
    }
}
