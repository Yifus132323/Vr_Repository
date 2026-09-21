using UnityEngine;
using UnityEngine.InputSystem;

public class Input : MonoBehaviour
{
    public InputActionProperty ManoIzquierdaBotonMenu;

    public void BotonMenuPresionado()
    {
        print("Menu presionado");
        print("Menu liberado");
    }

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }
}
