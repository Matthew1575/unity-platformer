using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    PlayerInput playerinput;

    InputAction moveAction;


    private void Start()
    {
        playerinput = GetComponent<PlayerInput>();
        moveAction = playerinput.actions.FindAction("Move");
    }

    // updates once per frame
    void Update()
    {
        MovePlayer();
    }

    public void MovePlayer()
    {   
        // checking debugger in unity engine check console
        Debug.Log(moveAction.ReadValue<Vector2>());

        // creates a x, y vector
        Vector2 direction = moveAction.ReadValue<Vector2>();
        transform.position += new Vector3(direction.x, 0 , direction.y) * Time.deltaTime;  //  Time.deltatime makes the game smoother with high or low frames
    }
}
