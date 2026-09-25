using UnityEngine;
using UnityEngine.InputSystem;

public class Input : MonoBehaviour
{
    public InputActionProperty manoIzquierdaBotonMenu;

    private void OnEnable()
    {
        manoIzquierdaBotonMenu.action.Enable();
        manoIzquierdaBotonMenu.action.performed += BotonMenuPresionado;
    }

    private void OnDisable()
    {
        manoIzquierdaBotonMenu.action.performed -= BotonMenuPresionado;
        manoIzquierdaBotonMenu.action.Disable();
    }

    public void BotonMenuPresionado(InputAction.CallbackContext context)
    {
        Debug.Log("Boton menu presionado");

    }
}
