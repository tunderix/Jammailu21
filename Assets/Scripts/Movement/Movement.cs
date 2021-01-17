using UnityEngine;

namespace TerraFirma.Movement
{
    [RequireComponent(typeof(Rigidbody))]
    public class Movement : MonoBehaviour
    {
        [SerializeField] private float speed;

        Rigidbody _rigidbody { get => this.gameObject.GetComponent<Rigidbody>(); }

        private void Update()
        {
            Vector3 moveForce = Vector3.zero;

            if (Input.GetKey(KeyCode.A))
                moveForce = MoveDirection.Left;
            if (Input.GetKey(KeyCode.D))
                moveForce = MoveDirection.Right;
            if (Input.GetKey(KeyCode.W))
                moveForce = MoveDirection.Up;
            if (Input.GetKey(KeyCode.S))
                moveForce = MoveDirection.Down;

            _rigidbody.AddForce(moveForce * speed);
        }
    }
}
