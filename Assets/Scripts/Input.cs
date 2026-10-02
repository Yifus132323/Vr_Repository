using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Input : MonoBehaviour
{
    public InputActionProperty manoIzquierdaBotonMenu;
    public InputActionProperty manoIzquierdaAccionPrimaria;
    public InputActionProperty manoIzquierdaDisparador;
    public InputActionProperty manoIzquierdaDisparadorBoton;
    public InputActionProperty manoIzquierdaAgarre;
    public InputActionProperty manoIzquierdaAgarreBoton;
    public InputActionProperty manoIzquierdaAccionSecundaria;
    public InputActionProperty manoIzquierdaEje2DSectorN;
    public InputActionProperty manoIzquierdaEje2DSectorS;
    public InputActionProperty manoIzquierdaEje2DSectorE;
    public InputActionProperty manoIzquierdaEje2DSectorO;
    public InputActionProperty manoIzquierdaBotonEje2D;

    public InputActionProperty manoDerechaBotonMenu;
    public InputActionProperty manoDerechaAccionPrimaria;
    public InputActionProperty manoDerechaDisparador;
    public InputActionProperty manoDerechaDisparadorBoton;
    public InputActionProperty manoDerechaAgarre;
    public InputActionProperty manoDerechaAgarreBoton;
    public InputActionProperty manoDerechaAccionSecundaria;
    public InputActionProperty manoDerechaEje2DSectorN;
    public InputActionProperty manoDerechaEje2DSectorS;
    public InputActionProperty manoDerechaEje2DSectorE;
    public InputActionProperty manoDerechaEje2DSectorO;
    public InputActionProperty manoDerechaBotonEje2D;

    private Vector2 valor;
    private float valorDisparador;
    private float valorAgarre;
    private string ejePresionado;
    private bool disparadorIzqPresionado = false;
    private bool disparadorDerPresionado = false;
    private bool agarreIzqPresionado = false;
    private bool agarreDerPresionado = false;

    private void OnEnable()
    {
        manoIzquierdaBotonMenu.action.performed += BotonMenu_Presionado;
        manoIzquierdaBotonMenu.action.canceled += BotonMenu_Liberado;
        manoIzquierdaAccionPrimaria.action.performed += AccionPrimaria_Presionado;
        manoIzquierdaAccionPrimaria.action.canceled += AccionPrimaria_Liberado;
        manoIzquierdaDisparador.action.performed += DisparadorIzq_Presionado;
        manoIzquierdaDisparador.action.canceled += DisparadorIzq_Liberado;
        manoIzquierdaDisparadorBoton.action.performed += DisparadorBoton_Presionado;
        manoIzquierdaDisparadorBoton.action.canceled += DisparadorBoton_Liberado;
        manoIzquierdaAgarre.action.performed += AgarreIzq_Presionado;
        manoIzquierdaAgarre.action.canceled += AgarreIzq_Liberado;
        manoIzquierdaAgarreBoton.action.performed += AgarreBoton_Presionado;
        manoIzquierdaAgarreBoton.action.canceled += AgarreBoton_Liberado;
        manoIzquierdaAccionSecundaria.action.performed += AccionSecundaria_Presionado;
        manoIzquierdaAccionSecundaria.action.canceled += AccionSecundaria_Liberado;
        manoIzquierdaEje2DSectorN.action.performed += EjeIzq2DSectorN_Presionado;
        manoIzquierdaEje2DSectorN.action.canceled += EjeIzq2DSectorN_Liberado;
        manoIzquierdaEje2DSectorS.action.performed += EjeIzq2DSectorS_Presionado;
        manoIzquierdaEje2DSectorS.action.canceled += EjeIzq2DSectorS_Liberado;
        manoIzquierdaEje2DSectorE.action.performed += EjeIzq2DSectorE_Presionado;
        manoIzquierdaEje2DSectorE.action.canceled += EjeIzq2DSectorE_Liberado;
        manoIzquierdaEje2DSectorO.action.performed += EjeIzq2DSectorO_Presionado;
        manoIzquierdaEje2DSectorO.action.canceled += EjeIzq2DSectorO_Liberado;
        manoIzquierdaBotonEje2D.action.performed += BotonEje2D_Presionado;
        manoIzquierdaBotonEje2D.action.canceled += BotonEje2D_Liberado;

        manoDerechaBotonMenu.action.performed += BotonMenu_Presionado;
        manoDerechaBotonMenu.action.canceled += BotonMenu_Liberado;
        manoDerechaAccionPrimaria.action.performed += AccionPrimaria_Presionado;
        manoDerechaAccionPrimaria.action.canceled += AccionPrimaria_Liberado;
        manoDerechaDisparador.action.performed += DisparadorDer_Presionado;
        manoDerechaDisparador.action.canceled += DisparadorDer_Liberado;
        manoDerechaDisparadorBoton.action.performed += DisparadorBoton_Presionado;
        manoDerechaDisparadorBoton.action.canceled += DisparadorBoton_Liberado;
        manoDerechaAgarre.action.performed += AgarreDer_Presionado;
        manoDerechaAgarre.action.canceled += AgarreDer_Liberado;
        manoDerechaAgarreBoton.action.performed += AgarreBoton_Presionado;
        manoDerechaAgarreBoton.action.canceled += AgarreBoton_Liberado;
        manoDerechaAccionSecundaria.action.performed += AccionSecundaria_Presionado;
        manoDerechaAccionSecundaria.action.canceled += AccionSecundaria_Liberado;
        manoDerechaEje2DSectorN.action.performed += EjeDer2DSectorN_Presionado;
        manoDerechaEje2DSectorN.action.canceled += EjeDer2DSectorN_Liberado;
        manoDerechaEje2DSectorS.action.performed += EjeDer2DSectorS_Presionado;
        manoDerechaEje2DSectorS.action.canceled += EjeDer2DSectorS_Liberado;
        manoDerechaEje2DSectorE.action.performed += EjeDer2DSectorE_Presionado;
        manoDerechaEje2DSectorE.action.canceled += EjeDer2DSectorE_Liberado;
        manoDerechaEje2DSectorO.action.performed += EjeDer2DSectorO_Presionado;
        manoDerechaEje2DSectorO.action.canceled += EjeDer2DSectorO_Liberado;
        manoDerechaBotonEje2D.action.performed += BotonEje2D_Presionado;
        manoDerechaBotonEje2D.action.canceled += BotonEje2D_Liberado;
    }

    private void OnDisable()
    {
        manoIzquierdaBotonMenu.action.performed -= BotonMenu_Presionado;
        manoIzquierdaBotonMenu.action.canceled -= BotonMenu_Liberado;
        manoIzquierdaAccionPrimaria.action.performed -= AccionPrimaria_Presionado;
        manoIzquierdaAccionPrimaria.action.canceled -= AccionPrimaria_Liberado;
        manoIzquierdaDisparador.action.performed -= DisparadorIzq_Presionado;
        manoIzquierdaDisparador.action.canceled -= DisparadorIzq_Liberado;
        manoIzquierdaDisparadorBoton.action.performed -= DisparadorBoton_Presionado;
        manoIzquierdaDisparadorBoton.action.canceled -= DisparadorBoton_Liberado;
        manoIzquierdaAgarre.action.performed -= AgarreIzq_Presionado;
        manoIzquierdaAgarre.action.canceled -= AgarreIzq_Liberado;
        manoIzquierdaAgarreBoton.action.performed -= AgarreBoton_Presionado;
        manoIzquierdaAgarreBoton.action.canceled -= AgarreBoton_Liberado;
        manoIzquierdaAccionSecundaria.action.performed -= AccionSecundaria_Presionado;
        manoIzquierdaAccionSecundaria.action.canceled -= AccionSecundaria_Liberado;
        manoIzquierdaEje2DSectorN.action.performed -= EjeIzq2DSectorN_Presionado;
        manoIzquierdaEje2DSectorN.action.canceled -= EjeIzq2DSectorN_Liberado;
        manoIzquierdaEje2DSectorS.action.performed -= EjeIzq2DSectorS_Presionado;
        manoIzquierdaEje2DSectorS.action.canceled -= EjeIzq2DSectorS_Liberado;
        manoIzquierdaEje2DSectorE.action.performed -= EjeIzq2DSectorE_Presionado;
        manoIzquierdaEje2DSectorE.action.canceled -= EjeIzq2DSectorE_Liberado;
        manoIzquierdaEje2DSectorO.action.performed -= EjeIzq2DSectorO_Presionado;
        manoIzquierdaEje2DSectorO.action.canceled -= EjeIzq2DSectorO_Liberado;
        manoIzquierdaBotonEje2D.action.performed -= BotonEje2D_Presionado;
        manoIzquierdaBotonEje2D.action.canceled -= BotonEje2D_Liberado;

        manoDerechaBotonMenu.action.performed -= BotonMenu_Presionado;
        manoDerechaBotonMenu.action.canceled -= BotonMenu_Liberado;
        manoDerechaAccionPrimaria.action.performed -= AccionPrimaria_Presionado;
        manoDerechaAccionPrimaria.action.canceled -= AccionPrimaria_Liberado;
        manoDerechaDisparador.action.performed -= DisparadorDer_Presionado;
        manoDerechaDisparador.action.canceled -= DisparadorDer_Liberado;
        manoDerechaDisparadorBoton.action.performed -= DisparadorBoton_Presionado;
        manoDerechaDisparadorBoton.action.canceled -= DisparadorBoton_Liberado;
        manoDerechaAgarre.action.performed -= AgarreDer_Presionado;
        manoDerechaAgarre.action.canceled -= AgarreDer_Liberado;
        manoDerechaAgarreBoton.action.performed -= AgarreBoton_Presionado;
        manoDerechaAgarreBoton.action.canceled -= AgarreBoton_Liberado;
        manoDerechaAccionSecundaria.action.performed -= AccionSecundaria_Presionado;
        manoDerechaAccionSecundaria.action.canceled -= AccionSecundaria_Liberado;
        manoDerechaEje2DSectorN.action.performed -= EjeDer2DSectorN_Presionado;
        manoDerechaEje2DSectorN.action.canceled -= EjeDer2DSectorN_Liberado;
        manoDerechaEje2DSectorS.action.performed -= EjeDer2DSectorS_Presionado;
        manoDerechaEje2DSectorS.action.canceled -= EjeDer2DSectorS_Liberado;
        manoDerechaEje2DSectorE.action.performed -= EjeDer2DSectorE_Presionado;
        manoDerechaEje2DSectorE.action.canceled -= EjeDer2DSectorE_Liberado;
        manoDerechaEje2DSectorO.action.performed -= EjeDer2DSectorO_Presionado;
        manoDerechaEje2DSectorO.action.canceled -= EjeDer2DSectorO_Liberado;
        manoDerechaBotonEje2D.action.performed -= BotonEje2D_Presionado;
        manoDerechaBotonEje2D.action.canceled -= BotonEje2D_Liberado;
    }

    private void Update()
    {
        if (disparadorIzqPresionado||disparadorDerPresionado)
        {
            if (disparadorIzqPresionado)
            {
                valorDisparador = manoIzquierdaDisparador.action.ReadValue<float>();
                Debug.Log("Valor del disparador: " + valorDisparador);
            }
            else
            {
                valorDisparador = manoDerechaDisparador.action.ReadValue<float>();
                Debug.Log("Valor del disparador: " + valorDisparador);
            }
        }

        if (agarreIzqPresionado||agarreDerPresionado)
        {
            if (agarreIzqPresionado)
            {
                valorAgarre = manoIzquierdaAgarre.action.ReadValue<float>();
                Debug.Log("Valor del agarre: " + valorAgarre);
            }
            else
            {
                valorAgarre = manoDerechaAgarre.action.ReadValue<float>();
                Debug.Log("Valor del agarre: " + valorAgarre);
            }
        }
    }

    private void DisparadorIzq_Liberado(InputAction.CallbackContext context)
    {
        disparadorIzqPresionado = false;

    }

    private void DisparadorIzq_Presionado(InputAction.CallbackContext context)
    {
        disparadorIzqPresionado = true;

    }

    private void DisparadorDer_Liberado(InputAction.CallbackContext context)
    {
        disparadorDerPresionado= false;

    }

    private void DisparadorDer_Presionado(InputAction.CallbackContext context)
    {
        disparadorDerPresionado = true;

    }

    private void DisparadorBoton_Liberado(InputAction.CallbackContext context)
    {
        Debug.Log("Disparador Liberado");

    }

    private void DisparadorBoton_Presionado(InputAction.CallbackContext context)
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

    private void AgarreIzq_Liberado(InputAction.CallbackContext context)
    {
        agarreIzqPresionado = false;
    }

    private void AgarreIzq_Presionado(InputAction.CallbackContext context)
    {
        agarreIzqPresionado = true;
    }

    private void AgarreDer_Liberado(InputAction.CallbackContext context)
    {
        agarreDerPresionado = false;
    }

    private void AgarreDer_Presionado(InputAction.CallbackContext context)
    {
        agarreDerPresionado = true;
    }

    private void AgarreBoton_Liberado(InputAction.CallbackContext context)
    {
        Debug.Log("Agarre Liberado");
    }

    private void AgarreBoton_Presionado(InputAction.CallbackContext context)
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

    private void EjeIzq2DSectorN_Liberado(InputAction.CallbackContext context)
    {
        valor = manoIzquierdaEje2DSectorN.action.ReadValue<Vector2>();
        if (ejePresionado.Equals("N"))
        {
            Debug.Log("Eje Izquierdo 2D Sector N Liberado. Valor: " + valor);
        }
        
    }

    private void EjeIzq2DSectorN_Presionado(InputAction.CallbackContext context)
    {
        valor = manoIzquierdaEje2DSectorN.action.ReadValue<Vector2>();
        ejePresionado = "N";
        Debug.Log("Eje Izquierdo 2D Sector N Presionado. Valor: " + valor);
    }

    private void EjeIzq2DSectorS_Liberado(InputAction.CallbackContext context)
    {
        valor = manoIzquierdaEje2DSectorS.action.ReadValue<Vector2>();
        if (ejePresionado.Equals("S"))
        {
            Debug.Log("Eje Izquierdo 2D Sector S Liberado. Valor: " + valor);
        }
        
    }

    private void EjeIzq2DSectorS_Presionado(InputAction.CallbackContext context)
    {
        valor = manoIzquierdaEje2DSectorS.action.ReadValue<Vector2>();
        ejePresionado = "S";
        Debug.Log("Eje Izquierdo 2D Sector S Presionado. Valor: " + valor);
    }

    private void EjeIzq2DSectorE_Liberado(InputAction.CallbackContext context)
    {
        valor = manoIzquierdaEje2DSectorE.action.ReadValue<Vector2>();
        if (ejePresionado.Equals("E"))
        {
            Debug.Log("Eje Izquierdo 2D Sector E Liberado. Valor: " + valor);
        }
        
    }

    private void EjeIzq2DSectorE_Presionado(InputAction.CallbackContext context)
    {
        valor = manoIzquierdaEje2DSectorE.action.ReadValue<Vector2>();
        ejePresionado = "E";
        Debug.Log("Eje Izquierdo 2D Sector E Presionado. Valor: " + valor);
    }

    private void EjeIzq2DSectorO_Liberado(InputAction.CallbackContext context)
    {
        valor = manoIzquierdaEje2DSectorO.action.ReadValue<Vector2>();
        if (ejePresionado.Equals("O"))
        {
            Debug.Log("Eje Izquierdo 2D Sector O Liberado. Valor: " + valor);
        }
        
    }

    private void EjeIzq2DSectorO_Presionado(InputAction.CallbackContext context)
    {
        valor = manoIzquierdaEje2DSectorO.action.ReadValue<Vector2>();
        ejePresionado = "O";
        Debug.Log("Eje Izquierdo 2D Sector O Presionado. Valor: " + valor);
    }

    private void EjeDer2DSectorN_Liberado(InputAction.CallbackContext context)
    {
        valor = manoDerechaEje2DSectorN.action.ReadValue<Vector2>();
        if (ejePresionado.Equals("N"))
        {
            Debug.Log("Eje Derecho 2D Sector N Liberado. Valor: " + valor);
        }

    }

    private void EjeDer2DSectorN_Presionado(InputAction.CallbackContext context)
    {
        valor = manoDerechaEje2DSectorN.action.ReadValue<Vector2>();
        ejePresionado = "N";
        Debug.Log("Eje Derecho 2D Sector N Presionado. Valor: " + valor);
        

    }

    private void EjeDer2DSectorS_Liberado(InputAction.CallbackContext context)
    {
        valor = manoDerechaEje2DSectorS.action.ReadValue<Vector2>();
        if (ejePresionado.Equals("S"))
        {
            Debug.Log("Eje Derecho 2D Sector S Liberado. Valor: " + valor);
        }

    }

    private void EjeDer2DSectorS_Presionado(InputAction.CallbackContext context)
    {
        valor = manoDerechaEje2DSectorS.action.ReadValue<Vector2>();
        ejePresionado = "S";
        Debug.Log("Eje Derecho 2D Sector S Presionado. Valor: " + valor);

    }

    private void EjeDer2DSectorE_Liberado(InputAction.CallbackContext context)
    {
        valor = manoDerechaEje2DSectorE.action.ReadValue<Vector2>();
        if (ejePresionado.Equals("E"))
        {
            Debug.Log("Eje Derecho 2D Sector E Liberado. Valor: " + valor);
        }

    }

    private void EjeDer2DSectorE_Presionado(InputAction.CallbackContext context)
    {
        valor = manoDerechaEje2DSectorE.action.ReadValue<Vector2>();
        ejePresionado = "E";
        Debug.Log("Eje Derecho 2D Sector E Presionado. Valor: " + valor);

    }

    private void EjeDer2DSectorO_Liberado(InputAction.CallbackContext context)
    {
        valor = manoDerechaEje2DSectorO.action.ReadValue<Vector2>();
        if (ejePresionado.Equals("O"))
        {
            Debug.Log("Eje Derecho 2D Sector O Liberado. Valor: " + valor);
        }

    }

    private void EjeDer2DSectorO_Presionado(InputAction.CallbackContext context)
    {
        valor = manoDerechaEje2DSectorO.action.ReadValue<Vector2>();
        ejePresionado = "O";
        Debug.Log("Eje Derecho 2D Sector O Presionado. Valor: " + valor);

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
