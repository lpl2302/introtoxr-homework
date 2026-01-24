using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
    public InputActionReference action; // button input
    private Light lightComp;            // the light component

    void Start()
    {
        lightComp = GetComponent<Light>();   // get the Light component
        action.action.Enable();

        action.action.performed += ctx =>
        {
            ChangeColor();
        };
    }

    void ChangeColor()
    {
        lightComp.color = Color.red;
    }
}
