using UnityEngine;
using UnityEngine.InputSystem;

public class TeleportToggle : MonoBehaviour
{
    public InputActionReference action;
    public Transform outsidePoint;

    private Vector3 insidePosition;
    private bool isOutside = false;

    void Start()
    {
        insidePosition = transform.position;

        action.action.Enable();
        action.action.performed += ctx =>
        {
            TogglePosition();
        };
    }

    void TogglePosition()
    {
        if (isOutside)
        {
            transform.position = insidePosition;
        }
        else
        {
            transform.position = outsidePoint.position;
        }

        isOutside = !isOutside;
    }
}
