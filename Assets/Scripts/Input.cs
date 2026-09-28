using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Input : MonoBehaviour
{
    public InputActionProperty manoIzquierdaBotonMenu;
    public InputActionProperty manoIzquierdaAccionPrimaria;
    public InputActionProperty manoIzquierdaDisparador;
    public InputActionProperty manoIzquierdaAgarre;
    public InputActionProperty manoIzquierdaAccionSecundaria;
    public InputActionProperty manoIzquierdaEje2DSectorN;
    public InputActionProperty manoIzquierdaEje2DSectorS;
    public InputActionProperty manoIzquierdaEje2DSectorE;
    public InputActionProperty manoIzquierdaEje2DSectorO;
    public InputActionProperty manoIzquierdaBotonEje2D;

    public InputActionProperty manoDerechaBotonMenu;
    public InputActionProperty manoDerechaAccionPrimaria;
    public InputActionProperty manoDerechaDisparador;
    public InputActionProperty manoDerechaAgarre;
    public InputActionProperty manoDerechaAccionSecundaria;
    public InputActionProperty manoDerechaEje2DSectorN;
    public InputActionProperty manoDerechaEje2DSectorS;
    public InputActionProperty manoDerechaEje2DSectorE;
    public InputActionProperty manoDerechaEje2DSectorO;
    public InputActionProperty manoDerechaBotonEje2D;

    private Vector2 valor;
    private string ejePresionado;

    private void OnEnable()
    {
        manoIzquierdaBotonMenu.action.performed += BotonMenu_Presionado;
        manoIzquierdaBotonMenu.action.canceled += BotonMenu_Liberado;
        manoIzquierdaAccionPrimaria.action.performed += AccionPrimaria_Presionado;
        manoIzquierdaAccionPrimaria.action.canceled += AccionPrimaria_Liberado;
        manoIzquierdaDisparador.action.performed += Disparador_Presionado;
        manoIzquierdaDisparador.action.canceled += Disparador_Liberado;
        manoIzquierdaAgarre.action.performed += Agarre_Presionado;
        manoIzquierdaAgarre.action.canceled += Agarre_Liberado;
        manoIzquierdaAccionSecundaria.action.performed += AccionSecundaria_Presionado;
        manoIzquierdaAccionSecundaria.action.canceled += AccionSecundaria_Liberado;
        manoIzquierdaEje2DSectorN.action.performed += Eje2DSectorN_Presionado;
        manoIzquierdaEje2DSectorN.action.canceled += Eje2DSectorN_Liberado;
        manoIzquierdaEje2DSectorS.action.performed += Eje2DSectorS_Presionado;
        manoIzquierdaEje2DSectorS.action.canceled += Eje2DSectorS_Liberado;
        manoIzquierdaEje2DSectorE.action.performed += Eje2DSectorE_Presionado;
        manoIzquierdaEje2DSectorE.action.canceled += Eje2DSectorE_Liberado;
        manoIzquierdaEje2DSectorO.action.performed += Eje2DSectorO_Presionado;
        manoIzquierdaEje2DSectorO.action.canceled += Eje2DSectorO_Liberado;
        manoIzquierdaBotonEje2D.action.performed += BotonEje2D_Presionado;
        manoIzquierdaBotonEje2D.action.canceled += BotonEje2D_Liberado;

        manoDerechaBotonMenu.action.performed += BotonMenu_Presionado;
        manoDerechaBotonMenu.action.canceled += BotonMenu_Liberado;
        manoDerechaAccionPrimaria.action.performed += AccionPrimaria_Presionado;
        manoDerechaAccionPrimaria.action.canceled += AccionPrimaria_Liberado;
        manoDerechaDisparador.action.performed += Disparador_Presionado;
        manoDerechaDisparador.action.canceled += Disparador_Liberado;
        manoDerechaAgarre.action.performed += Agarre_Presionado;
        manoDerechaAgarre.action.canceled += Agarre_Liberado;
        manoDerechaAccionSecundaria.action.performed += AccionSecundaria_Presionado;
        manoDerechaAccionSecundaria.action.canceled += AccionSecundaria_Liberado;
        manoDerechaEje2DSectorN.action.performed += Eje2DSectorN_Presionado;
        manoDerechaEje2DSectorN.action.canceled += Eje2DSectorN_Liberado;
        manoDerechaEje2DSectorS.action.performed += Eje2DSectorS_Presionado;
        manoDerechaEje2DSectorS.action.canceled += Eje2DSectorS_Liberado;
        manoDerechaEje2DSectorE.action.performed += Eje2DSectorE_Presionado;
        manoDerechaEje2DSectorE.action.canceled += Eje2DSectorE_Liberado;
        manoDerechaEje2DSectorO.action.performed += Eje2DSectorO_Presionado;
        manoDerechaEje2DSectorO.action.canceled += Eje2DSectorO_Liberado;
        manoDerechaBotonEje2D.action.performed += BotonEje2D_Presionado;
        manoDerechaBotonEje2D.action.canceled += BotonEje2D_Liberado;
    }

    private void OnDisable()
    {
        manoIzquierdaBotonMenu.action.performed -= BotonMenu_Presionado;
        manoIzquierdaBotonMenu.action.canceled -= BotonMenu_Liberado;
        manoIzquierdaAccionPrimaria.action.performed -= AccionPrimaria_Presionado;
        manoIzquierdaAccionPrimaria.action.canceled -= AccionPrimaria_Liberado;
        manoIzquierdaDisparador.action.performed -= Disparador_Presionado;
        manoIzquierdaDisparador.action.canceled -= Disparador_Liberado;
        manoIzquierdaAgarre.action.performed -= Agarre_Presionado;
        manoIzquierdaAgarre.action.canceled -= Agarre_Liberado;
        manoIzquierdaAccionSecundaria.action.performed -= AccionSecundaria_Presionado;
        manoIzquierdaAccionSecundaria.action.canceled -= AccionSecundaria_Liberado;
        manoIzquierdaEje2DSectorN.action.performed -= Eje2DSectorN_Presionado;
        manoIzquierdaEje2DSectorN.action.canceled -= Eje2DSectorN_Liberado;
        manoIzquierdaEje2DSectorS.action.performed -= Eje2DSectorS_Presionado;
        manoIzquierdaEje2DSectorS.action.canceled -= Eje2DSectorS_Liberado;
        manoIzquierdaEje2DSectorE.action.performed -= Eje2DSectorE_Presionado;
        manoIzquierdaEje2DSectorE.action.canceled -= Eje2DSectorE_Liberado;
        manoIzquierdaEje2DSectorO.action.performed -= Eje2DSectorO_Presionado;
        manoIzquierdaEje2DSectorO.action.canceled -= Eje2DSectorO_Liberado;
        manoIzquierdaBotonEje2D.action.performed -= BotonEje2D_Presionado;
        manoIzquierdaBotonEje2D.action.canceled -= BotonEje2D_Liberado;

        manoDerechaBotonMenu.action.performed -= BotonMenu_Presionado;
        manoDerechaBotonMenu.action.canceled -= BotonMenu_Liberado;
        manoDerechaAccionPrimaria.action.performed -= AccionPrimaria_Presionado;
        manoDerechaAccionPrimaria.action.canceled -= AccionPrimaria_Liberado;
        manoDerechaDisparador.action.performed -= Disparador_Presionado;
        manoDerechaDisparador.action.canceled -= Disparador_Liberado;
        manoDerechaAgarre.action.performed -= Agarre_Presionado;
        manoDerechaAgarre.action.canceled -= Agarre_Liberado;
        manoDerechaAccionSecundaria.action.performed -= AccionSecundaria_Presionado;
        manoDerechaAccionSecundaria.action.canceled -= AccionSecundaria_Liberado;
        manoDerechaEje2DSectorN.action.performed -= Eje2DSectorN_Presionado;
        manoDerechaEje2DSectorN.action.canceled -= Eje2DSectorN_Liberado;
        manoDerechaEje2DSectorS.action.performed -= Eje2DSectorS_Presionado;
        manoDerechaEje2DSectorS.action.canceled -= Eje2DSectorS_Liberado;
        manoDerechaEje2DSectorE.action.performed -= Eje2DSectorE_Presionado;
        manoDerechaEje2DSectorE.action.canceled -= Eje2DSectorE_Liberado;
        manoDerechaEje2DSectorO.action.performed -= Eje2DSectorO_Presionado;
        manoDerechaEje2DSectorO.action.canceled -= Eje2DSectorO_Liberado;
        manoDerechaBotonEje2D.action.performed -= BotonEje2D_Presionado;
        manoDerechaBotonEje2D.action.canceled -= BotonEje2D_Liberado;
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

    private void Agarre_Liberado(InputAction.CallbackContext context)
    {
        Debug.Log("Agarre Liberado");
    }

    private void Agarre_Presionado(InputAction.CallbackContext context)
    {
        Debug.Log("Agarre Presionado");
    }

    private void AccionSecundaria_Liberado(InputAction.CallbackContext context)
    {
        Debug.Log("Accion Secundaria Liberada");
    }

    private void AccionSecundaria_Presionado(InputAction.CallbackContext context)
    {
        Debug.Log("Accion Secundaria Presionada");
    }

    private void Eje2DSectorN_Liberado(InputAction.CallbackContext context)
    {
        valor = manoIzquierdaEje2DSectorN.action.ReadValue<Vector2>();
        if (ejePresionado.Equals("N"))
        {
            Debug.Log("Eje 2D Sector N Liberado. Valor: " + valor);
        }
        
    }

    private void Eje2DSectorN_Presionado(InputAction.CallbackContext context)
    {
        valor = manoIzquierdaEje2DSectorN.action.ReadValue<Vector2>();
        ejePresionado = "N";
        Debug.Log("Eje 2D Sector N Presionado. Valor: " + valor);
    }

    private void Eje2DSectorS_Liberado(InputAction.CallbackContext context)
    {
        valor = manoIzquierdaEje2DSectorS.action.ReadValue<Vector2>();
        if (ejePresionado.Equals("S"))
        {
            Debug.Log("Eje 2D Sector S Liberado. Valor: " + valor);
        }
        
    }

    private void Eje2DSectorS_Presionado(InputAction.CallbackContext context)
    {
        valor = manoIzquierdaEje2DSectorS.action.ReadValue<Vector2>();
        ejePresionado = "S";
        Debug.Log("Eje 2D Sector S Presionado. Valor: " + valor);
    }

    private void Eje2DSectorE_Liberado(InputAction.CallbackContext context)
    {
        valor = manoIzquierdaEje2DSectorE.action.ReadValue<Vector2>();
        if (ejePresionado.Equals("E"))
        {
            Debug.Log("Eje 2D Sector E Liberado. Valor: " + valor);
        }
        
    }

    private void Eje2DSectorE_Presionado(InputAction.CallbackContext context)
    {
        valor = manoIzquierdaEje2DSectorE.action.ReadValue<Vector2>();
        ejePresionado = "E";
        Debug.Log("Eje 2D Sector E Presionado. Valor: " + valor);
    }

    private void Eje2DSectorO_Liberado(InputAction.CallbackContext context)
    {
        valor = manoIzquierdaEje2DSectorO.action.ReadValue<Vector2>();
        if (ejePresionado.Equals("O"))
        {
            Debug.Log("Eje 2D Sector O Liberado. Valor: " + valor);
        }
        
    }

    private void Eje2DSectorO_Presionado(InputAction.CallbackContext context)
    {
        valor = manoIzquierdaEje2DSectorO.action.ReadValue<Vector2>();
        ejePresionado = "O";
        Debug.Log("Eje 2D Sector O Presionado. Valor: " + valor);
    }

    private void BotonEje2D_Liberado(InputAction.CallbackContext context)
    {
        Debug.Log("Boton Eje 2D Liberado");
    }

    private void BotonEje2D_Presionado(InputAction.CallbackContext context)
    {
        Debug.Log("Boton Eje 2D Presionado");
    }
}
