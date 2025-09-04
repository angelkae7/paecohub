using UnityEngine;

public class SimpleFPSController : MonoBehaviour
{
    private CharacterController characterController;
    public float speed = 5f;
    public float mouseSensitivity = 2f;
    public Transform cameraTransform;

    float verticalLookRotation;
    private bool cursorLocked = true;

    void Start()
    {
        LockCursor(true);
    }

    void Update()
    {
        // Touche pour basculer entre contrôle FPS et interaction UI
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            cursorLocked = !cursorLocked;
            LockCursor(cursorLocked);
        }

        if (cursorLocked)
        {
            // Mouvement
            float moveX = Input.GetAxis("Horizontal");
            float moveZ = Input.GetAxis("Vertical");
            Vector3 move = transform.right * moveX + transform.forward * moveZ;

            if (characterController == null)
                characterController = GetComponent<CharacterController>();

            characterController.Move(move * speed * Time.deltaTime);

            // Rotation souris horizontale
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
            transform.Rotate(Vector3.up * mouseX);

            // Rotation verticale caméra
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;
            verticalLookRotation -= mouseY;
            verticalLookRotation = Mathf.Clamp(verticalLookRotation, -90f, 90f);
            cameraTransform.localEulerAngles = Vector3.right * verticalLookRotation;
        }
    }

    void LockCursor(bool locked)
    {
        Cursor.lockState = locked ? CursorLockMode.Locked : CursorLockMode.None;
        Cursor.visible = !locked;
    }
}
