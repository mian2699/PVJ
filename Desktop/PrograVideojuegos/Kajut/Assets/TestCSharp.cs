using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Tipo
{
    ACTIVO , INACTIVO
}

public class TestCSharp : MonoBehaviour
{
   
    // se va ejecutar una sola vez en el inicio
    private void Start()
    {
       int num = 10;
       float peso = 40.5f;
       bool verdad = true;
       string nombre = "MIGUEL";
       
      // string numbero = num.ToString(); // NullReferenceException
      //string numero = (string)num; // InvalidCastException
      //string numero = num as string; // numero = null
       Debug.Log($"Hola {nombre} "); 
    }

    // Update is called once per frame
    // siempre se va ejecutar 
    // ya que el object esta en un while 
    /*  private void Update()
    {
       Debug.Log("Hola"); 
    }*/


}
