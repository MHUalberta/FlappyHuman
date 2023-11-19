using UnityEngine;
using UnityEngine.InputSystem;

public class ControlObject : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    private Vector3 movement;
    private Keyboard keyboard;

    private void Awake()
    {
        keyboard = Keyboard.current;
    }

    void Update()
    {
        movement.y = keyboard.qKey.isPressed ? 1 : keyboard.eKey.isPressed ? -1 : 0;
        movement.x = keyboard.dKey.isPressed ? 1 : keyboard.aKey.isPressed ? -1 : 0;
        movement.z = keyboard.wKey.isPressed ? 1 : keyboard.sKey.isPressed ? -1 : 0;
        movement = movement.normalized * moveSpeed * Time.deltaTime;
        transform.Translate(movement);
    }
}
public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 100.0f;

    void Update()
    {
        float rotateHorizontal = Input.GetAxis("Horizontal");
        float rotateVertical = Input.GetAxis("Vertical");

        Vector3 rotation = new Vector3(rotateHorizontal, 0, rotateVertical) * rotationSpeed * Time.deltaTime;
        transform.Rotate(rotation);
    }
}