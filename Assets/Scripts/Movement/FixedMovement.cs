using UnityEngine;
using UnityEngine.AI;

namespace TerraFirma.Movement
{
    public class FixedMovement : MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private Animator playerAnimator;
        [SerializeField] private NavMeshAgent navMeshAgent;

        private void FixedUpdate()
        {
            Vector3 moveForce = Vector3.zero;

            if (Input.GetKey(KeyCode.A))
                moveForce += MoveDirection.Left;
            if (Input.GetKey(KeyCode.D))
                moveForce += MoveDirection.Right;
            if (Input.GetKey(KeyCode.W))
                moveForce += MoveDirection.Up;
            if (Input.GetKey(KeyCode.S))
                moveForce += MoveDirection.Down;

            playerAnimator.SetBool("isRunning", moveForce != Vector3.zero);

            navMeshAgent.Move(moveForce * speed * Time.deltaTime);
            Rotate(moveForce);
        }

        private void Rotate(Vector3 to)
        {
            Quaternion facedirection = Quaternion.LookRotation(to);
            this.transform.rotation = facedirection;
        }
    }
}
