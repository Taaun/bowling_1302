using UnityEngine;
using UnityEngine.InputSystem;

public class Bowling : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private int ForcePower;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
            ShootBall();

        if (Keyboard.current.rightArrowKey.isPressed)
            MoveRight();

        if (Keyboard.current.leftArrowKey.isPressed)
            MoveLeft();
        if (Keyboard.current.upArrowKey.isPressed)
            MoveForward();
        if (Keyboard.current.downArrowKey.isPressed)
            MoveBack();
    }
    public void ShootBall()
    {
        rb.AddForce(Vector3.forward * ForcePower, ForceMode.Impulse);
    }

    private void MoveRight()
    {
        transform.position += new Vector3(1f, 0f, 0f) * Time.deltaTime;
    }

    private void MoveLeft()
    {
        transform.position += new Vector3(-1f, 0f, 0f) * Time.deltaTime;
    }

    private void MoveForward()
    {
        transform.position += new Vector3(0f, 0f, 1f) * Time.deltaTime;
    }

    private void MoveBack()
    {
        transform.position += new Vector3(0f, 0f, -1f) * Time.deltaTime;
    }
}
