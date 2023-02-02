using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    CharacterController characterController;
    Vector3 currentMovement;

    [SerializeField] private GameObject description;

    [SerializeField] float speedp = 4.0f;
    [SerializeField] float rotationFactorPerFrame = 5.0f;
    bool isMovementPressed;
   
    private Vector2 movement;

    private bool isOpen = false;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    public void OnMoveCharacter(InputAction.CallbackContext ctx)
    {
        movement = ctx.ReadValue<Vector2>();

        currentMovement.x = movement.x;
        currentMovement.z = movement.y;

        isMovementPressed = movement.x != 0 || movement.y != 0;
    }

    void Update()
    {
        characterController.Move((currentMovement.x * transform.right + currentMovement.z * transform.forward) * speedp * Time.deltaTime);
      //  transform.Translate(currentMovement.x * speedp * Time.deltaTime, 0, currentMovement.z * speedp * Time.deltaTime, Space.Self);
    
      if (Input.GetKeyDown(KeyCode.I))
        {
            if (isOpen)
            {
                CloseDescription();
            }
            else
            {
              OpenDescription();
            }
        }
    }

    public void OpenDescription()
    {
        description.SetActive(true);
        isOpen = true;
    }
    public void CloseDescription()
    {
        description.SetActive(false);
        isOpen = false;
    }
}
