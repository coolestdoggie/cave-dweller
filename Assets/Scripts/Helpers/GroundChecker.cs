using UnityEngine;

namespace CaveDweller.Helpers
{
    public class GroundChecker : MonoBehaviour
    {
        [SerializeField] private Collider2D collider;
        [SerializeField] private LayerMask ground;
        public bool IsGrounded()
        {
            RaycastHit2D raycastInfo = Physics2D.BoxCast(collider.bounds.center, collider.bounds.size,
                0f, Vector3.down, .1f, ground);
            print(raycastInfo.collider != null);
            return raycastInfo.collider != null;
        }       
    }
}