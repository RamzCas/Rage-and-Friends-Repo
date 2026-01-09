using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterControler : MonoBehaviour
{
    [Header("MOVEMENT SETTINGS")]
    public float moveSpeed = 3f;
    public float lookSpeed = 2f;
    public float CurrentGravity;
    public float gravity = -9.81f;
    public float ZeroGravity = 0;
    public float jumpHeight = 1.0f;
    public Transform playerCamera;

    private Vector2 moveInput;
    private Vector2 lookInput;
    private float verticalLookRotation;
    private Vector3 velocity;

    private CharacterController characterController;
    private Controls controls;

    [Header("CROUCH SETTINGS")]
    public float crouchHeight = 1f;
    public float standingHeight = 2f;
    public float crouchSpeed = 1.5f;
    public bool isCrouching;
    public bool canCrouch = true;

    private float currentSpeed;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
        controls = new Controls();
        currentSpeed = moveSpeed;
        CurrentGravity = gravity;
    }

    private void OnEnable()
    {
        controls.Player.Enable();

        controls.Player.Move.performed += OnMove;
        controls.Player.Move.canceled += OnMoveCanceled;

        controls.Player.Look.performed += OnLook;
        controls.Player.Look.canceled += OnLookCanceled;

        controls.Player.Jump.performed += OnJump;

        controls.Player.Crouch.performed += OnCrouch;
    }

    private void OnDisable()
    {
        controls.Player.Move.performed -= OnMove;
        controls.Player.Move.canceled -= OnMoveCanceled;

        controls.Player.Look.performed -= OnLook;
        controls.Player.Look.canceled -= OnLookCanceled;

        controls.Player.Jump.performed -= OnJump;
        controls.Player.Crouch.performed -= OnCrouch;

        controls.Player.Disable();
    }

    private void Update()
    {
        LookAround();
        Move();
        ApplyGravity();
    }

    private void Move()
    {
        Vector3 move = new Vector3(moveInput.x, 0f, moveInput.y);
        move = transform.TransformDirection(move);

        characterController.Move(move * currentSpeed * Time.deltaTime);
    }

    private void LookAround()
    {
        float lookX = lookInput.x * lookSpeed;
        float lookY = lookInput.y * lookSpeed;

        transform.Rotate(0f, lookX, 0f);

        verticalLookRotation -= lookY;
        verticalLookRotation = Mathf.Clamp(verticalLookRotation, -90f, 90f);

        playerCamera.localEulerAngles = new Vector3(verticalLookRotation, 0f, 0f);
    }

    private void ApplyGravity()
    {
        if (characterController.isGrounded && velocity.y < 0f)
        {
            velocity.y = -2f;
        }

        velocity.y += CurrentGravity * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);
    }

    private void Jump()
    {
        if (characterController.isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
    }

    private void ToggleCrouch()
    {
        if (!canCrouch) return;

        isCrouching = !isCrouching;

        characterController.height = isCrouching ? crouchHeight : standingHeight;
        currentSpeed = isCrouching ? crouchSpeed : moveSpeed;
    }

    private void OnMove(InputAction.CallbackContext ctx)
    {
        moveInput = ctx.ReadValue<Vector2>();
    }

    private void OnMoveCanceled(InputAction.CallbackContext ctx)
    {
        moveInput = Vector2.zero;
    }

    private void OnLook(InputAction.CallbackContext ctx)
    {
        lookInput = ctx.ReadValue<Vector2>();
    }

    private void OnLookCanceled(InputAction.CallbackContext ctx)
    {
        lookInput = Vector2.zero;
    }

    private void OnJump(InputAction.CallbackContext ctx)
    {
        Jump();
    }

    private void OnCrouch(InputAction.CallbackContext ctx)
    {
        ToggleCrouch();
    }

  
}
