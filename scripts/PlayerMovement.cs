using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed;

    void Update()
    {
        float horizontalMovement = Input.GetAxisRaw("Horizontal");
        float verticalMovement = Input.GetAxisRaw("Vertical");
        Vector3 movementVector = new Vector3(horizontalMovement, 0f, verticalMovement).normalized;
        Debug.Log(movementVector);
        

        transform.Translate(movementVector * movementSpeed * Time.deltaTime);
    }
}
