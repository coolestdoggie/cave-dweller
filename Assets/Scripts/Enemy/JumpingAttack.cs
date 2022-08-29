using System;
using UnityEngine;

namespace CaveDweller
{
    public class JumpingAttack : MonoBehaviour
    {
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
            float distanceBtwTargetAndAttacker = (target.position - transform.position).magnitude;
            if (distanceBtwTargetAndAttacker <= attackRange)
            {
                Attack();
            }
        }

        private void Attack()
        {
            if (rb2d.velocity.y > Mathf.Epsilon)
            {
                return;
            }
            
            rb2d.AddForce(new Vector3(0, jumpForce));    
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.GetComponent<Player>() == null) return;

            OnCollidedWithPlayer();
        }

        protected virtual void OnCollidedWithPlayer()
        {
            CollidedWithPlayer?.Invoke();
        }
    }
}
