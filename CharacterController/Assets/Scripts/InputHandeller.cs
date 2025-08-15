using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandeller : MonoBehaviour
{
    [SerializeField] PlayerController playerController;

    private InputAction moveAction, lookAction;
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        lookAction = InputSystem.actions.FindAction("Look");

        Cursor.visible = false; //so that cursor is not visible in gameplay mode.
    }

    void Update()
    {
        Vector2 moveVector = moveAction.ReadValue<Vector2>();
        playerController.Move(moveVector);

        Vector2 lookVector = lookAction.ReadValue<Vector2>();
        playerController.Look(lookVector);
        
    }
}
