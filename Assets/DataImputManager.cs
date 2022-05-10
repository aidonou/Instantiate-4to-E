using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataImputManager : MonoBehaviour
{
    public Text txtUsername;

public void ShowGreetings()
    {
    Debug.Log("Hola " + txtUsername.text);
    }

    public void ShowDouble()
    {
        if (txtUsername.text != "")
        {
            Debug.Log(int.Parse(txtUsername.text) * 2);
        }
        else
        {
            Debug.Log("no podes poner aceptar con el texto vacio pedazo de gaucho");
        }
    }
}
