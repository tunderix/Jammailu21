using UnityEngine;
using UnityEngine.AI;

namespace TerraFirma.Movement
{
    public class FixedMovement : MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private Animator playerAnimator;
        [SerializeField] private NavMeshAgent navMeshAgent;
        [SerializeField] private Transform playerGraphics;
        private void FixedUpdate()
        {
            Vector3 moveForce = Vector3.zero;

            if (Input.GetKey(KeyCode.A))
                moveForce += MoveDirection.Down;
            if (Input.GetKey(KeyCode.D))
                moveForce += MoveDirection.Up;
            if (Input.GetKey(KeyCode.W))
                moveForce += MoveDirection.Left;
            if (Input.GetKey(KeyCode.S))
                moveForce += MoveDirection.Right;

            playerAnimator.SetBool("isRunning", moveForce != Vector3.zero);

            transform.Translate(moveForce * speed * Time.deltaTime);
            Rotate(moveForce);
        }

        private void Rotate(Vector3 to)
        {
            if (to == Vector3.zero) return;

            Quaternion facedirection = Quaternion.LookRotation(to);
            playerGraphics.rotation = facedirection;
        }
    }
}
