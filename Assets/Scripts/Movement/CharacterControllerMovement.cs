using UnityEngine;

namespace TerraFirma.Movement
{
    [RequireComponent(typeof(CharacterController))]
    public class CharacterControllerMovement : MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private float gravityValue = -9.81f;

        private CharacterController _characterController { get => this.gameObject.GetComponent<CharacterController>(); }

        private void Update()
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

            moveForce.y += gravityValue * Time.deltaTime;

            _characterController.Move(moveForce * Time.deltaTime * speed);
        }
    }
}
