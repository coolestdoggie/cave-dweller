using UnityEngine;

namespace CaveDweller.Common
{
    public class GroundChecker : MonoBehaviour
    {
        [SerializeField] private Collider2D collider;
        [SerializeField] private LayerMask ground;
        
        public bool IsGrounded()
        {
            RaycastHit2D raycastInfo = Physics2D.BoxCast(collider.bounds.center, collider.bounds.size,
                0f, Vector3.down, .1f, ground);
            return raycastInfo.collider != null;
        }       
    }
}