using UnityEngine;

public class DynamicCameraController : MonoBehaviour
{
    public float sensitivity = 2.0f;
    public float clampAngle = 80.0f;
    private float rotationY = 0.0f; 
    private float rotationX = 0.0f;

    void Start()
    {
        //You dont need to lock the cursor to the center of the screen if its locked already in another script like PlayerMovement.cs in this repository
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        rotationY += mouseX;
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -clampAngle, clampAngle);
        transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0);
    }
}