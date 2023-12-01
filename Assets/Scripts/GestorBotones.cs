using UnityEngine;
using UnityEngine.UI;

public class GestorBotones : MonoBehaviour
{
    private Color colorOriginal;
    private Button[] botones;

    void Start()
    {
        botones = GetComponentsInChildren<Button>(); // Con esto obtengo todos los objetos que sean botones, que est�n dentro de donde ponga el script

        colorOriginal = botones[0].image.color; // Para poder volver a su color original

        foreach (var boton in botones) // Una funci�n para hacer PARA CADA variable (en este caso es "var" porque no he definido anteriormente qu� tipo de variable)
        {
            boton.onClick.AddListener(() => CambiarColor(boton));
        }
    }

    void CambiarColor(Button botonPresionado)
    {
        foreach (var boton in botones)
        {
            boton.image.color = colorOriginal;
        }

        botonPresionado.image.color = new Color(0.486f, 0.898f, 0.141f);
    }
}




