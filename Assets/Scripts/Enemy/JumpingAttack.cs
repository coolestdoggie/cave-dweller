using System;
using UnityEngine;

namespace CaveDweller
{
    public class JumpingAttack : MonoBehaviour
    {
        [SerializeField] private float damage;
        [SerializeField] private float attackRange;
        [SerializeField] private float jumpForce;

        private Transform target;
        private Rigidbody2D rb2d;

        public event Action CollidedWithPlayer;
        
        public void Init(Transform target, Rigidbody2D rb2d)
        {
           this.target = target;
           this.rb2d = rb2d;
        }

        public void CheckForAttack()
        {
            if (!target.gameObject.activeSelf)
            {
                return;
            }
            
            float distanceBtwTargetAndAttacker = (target.position - transform.position).magnitude;
            if (distanceBtwTargetAndAttacker <= attackRange)
            {
                Attack();
            }
        }

        private void Attack()
        {
            rb2d.velocity = Vector2.up * jumpForce;
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            var player = other.gameObject.GetComponent<Player.Player>();
            if (player == null) return;
            player.Health.GetDamage(damage);
            
            OnCollidedWithPlayer();
        }

        protected virtual void OnCollidedWithPlayer()
        {
            CollidedWithPlayer?.Invoke();
        }
    }
}
