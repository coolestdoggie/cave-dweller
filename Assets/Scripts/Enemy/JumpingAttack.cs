using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CaveDweller
{
    public class JumpingAttack : MonoBehaviour
    {
        [SerializeField] private float attackRange;
        [SerializeField] private float jumpForce;
        
        private Transform target;
        private Rigidbody2D rb2d;

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
            rb2d.AddForce(new Vector3(0, jumpForce));    
        }
    }
}
