using System.Runtime.CompilerServices;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed;

    private PlayerControls playerControls;

    private void Awake()
    {
        playerControls = new PlayerControls();
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    void Update()
    {
        Vector2 inputVector = playerControls.Player1.Move.ReadValue<Vector2>();
        Vector3 movementVector = new Vector3(inputVector.x, 0f, inputVector.y);
        
        transform.Translate(movementVector * movementSpeed * Time.deltaTime);
    }
}

