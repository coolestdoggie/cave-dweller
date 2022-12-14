using CaveDweller.Common;
using UnityEngine;

namespace CaveDweller.Enemy
{
    public class SideToSideMovement : MonoBehaviour
    {
        [SerializeField] private float padding;
        [SerializeField] private float speed;

        private Sides side = Sides.Left;
        private float xMin;
        private float xMax;
        private float move;

        public void Flip()
        {
            side = side == Sides.Left ? Sides.Right : Sides.Left;
            FlipSprite();
        }
        
        public void Move()
        {
            move = speed * (int)side * Time.deltaTime;
            transform.position += new Vector3(move, 0);
        
            CheckForChangeDirection();
            FlipSprite();
        }
    
        private void CheckForChangeDirection()
        {
            if (transform.position.x > padding)
            {
                side = Sides.Left;
            }
            else if (transform.position.x < -padding)
            {
                side = Sides.Right;
            }
        }

        private void FlipSprite()
        {
            if (move > 0 && side == Sides.Left)
            {
                FlipScale();
            }
            else if (move < 0 && side == Sides.Right)
            {
                FlipScale();
            }
        
            void FlipScale()
            {
                Vector3 newScale = transform.localScale;
                newScale.x *= -1;
                transform.localScale = newScale;
            }
        }
    }
}
