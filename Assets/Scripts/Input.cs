using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Input : MonoBehaviour
{
    public InputActionProperty manoIzquierdaBotonMenu;
    public InputActionProperty manoIzquierdaAccionPrimaria;
    public InputActionProperty manoIzquierdaDisparador;

    private void OnEnable()
    {
        manoIzquierdaBotonMenu.action.performed += BotonMenu_Presionado;
        manoIzquierdaBotonMenu.action.canceled += BotonMenu_Liberado;
        manoIzquierdaAccionPrimaria.action.performed += AccionPrimaria_Presionado;
        manoIzquierdaAccionPrimaria.action.canceled += AccionPrimaria_Liberado;
        manoIzquierdaDisparador.action.performed += Disparador_Presionado;
        manoIzquierdaDisparador.action.canceled += Disparador_Liberado;
    }

    private void OnDisable()
    {
        manoIzquierdaBotonMenu.action.performed -= BotonMenu_Presionado;
        manoIzquierdaBotonMenu.action.canceled -= BotonMenu_Liberado;
        manoIzquierdaAccionPrimaria.action.performed -= AccionPrimaria_Presionado;
        manoIzquierdaAccionPrimaria.action.canceled -= AccionPrimaria_Liberado;
        manoIzquierdaDisparador.action.performed -= Disparador_Presionado;
        manoIzquierdaDisparador.action.canceled -= Disparador_Liberado;
    }

    private void Disparador_Liberado(InputAction.CallbackContext context)
    {
        Debug.Log("Disparador Liberado");

    }

    private void Disparador_Presionado(InputAction.CallbackContext context)
    {
        Debug.Log("Disparador Presionado");

    }

    private void AccionPrimaria_Liberado(InputAction.CallbackContext context)
    {
        Debug.Log("Accion Primaria Liberada");
    }

    private void AccionPrimaria_Presionado(InputAction.CallbackContext context)
    {
        Debug.Log("Accion Primaria Presionada");
    }

    private void BotonMenu_Liberado(InputAction.CallbackContext context)
    {
        Debug.Log("Boton Menu Liberado");
    }

    

    public void BotonMenu_Presionado(InputAction.CallbackContext context)
    {
        Debug.Log("Boton Menu Presionado");

    }
}
