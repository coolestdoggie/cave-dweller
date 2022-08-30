using CaveDweller.Common;
using UnityEngine;

namespace CaveDweller.Enemy
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private SideToSideMovement sideToSideMovement;
        [SerializeField] private JumpingAttack jumpingAttack;
        [SerializeField] private GroundChecker groundChecker;
        [Header("Components")]
        [SerializeField] private Rigidbody2D rb2d;
        
        private void Start()
        {
            var player = FindObjectOfType<Player.Player>();
            jumpingAttack.Init(player.transform, rb2d);
        }

        private void OnEnable()
        {
            jumpingAttack.CollidedWithPlayer += sideToSideMovement.Flip;
        }

        private void OnDisable()
        {
            jumpingAttack.CollidedWithPlayer -= sideToSideMovement.Flip;
        }

        private void Update()
        {
            Move();
        }

        private void FixedUpdate()
        {
            CheckForAttack();
        }

        private void Move()
        {
            sideToSideMovement.Move();
        }

        private void CheckForAttack()
        {
            if (groundChecker.IsGrounded())
            {
                jumpingAttack.CheckForAttack();
            }
        }
    }
}
