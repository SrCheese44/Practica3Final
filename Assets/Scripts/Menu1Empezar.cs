using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu1Empezar : MonoBehaviour
{
    [SerializeField] private GameObject Poly_text;
   
    void Start()
    {
        LeanTween.moveY(Poly_text.GetComponent<RectTransform>(), 0, 1.5f).setDelay(1f);
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
         SceneManager.LoadScene(1);
        }

    }
}

 
