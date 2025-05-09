using UnityEngine;

public class Player : MonoBehaviour {
    [SerializeField] private float moveSpeed = 7f;
    private bool isWalking;

    private void Update() {
        PlayerMovement();
    }

    private void PlayerMovement() {
        float inputAD = Input.GetAxis("Horizontal");
        float inputWS = Input.GetAxis("Vertical");

        Vector3 moveDirection = new(inputAD, 0, inputWS);
        transform.position += moveSpeed * Time.deltaTime * moveDirection;

        isWalking = moveDirection != Vector3.zero;
        float rotateSpeed = 10f;
        transform.forward = Vector3.Slerp(transform.forward, moveDirection, Time.deltaTime * rotateSpeed);
    }

    public bool IsWalking() {
        return isWalking;
    }
}
