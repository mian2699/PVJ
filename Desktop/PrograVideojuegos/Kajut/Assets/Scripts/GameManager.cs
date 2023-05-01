using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class Pregunta {

    public string Texto;
    public List <string> Opciones;
    public int IndexCorrecta;

    public Pregunta()
    {
        Opciones = new List<string>();
    }
}


public class GameManager : MonoBehaviour
{
   public TextMeshProUGUI TextoPregunta;
   public TextMeshProUGUI TextoTimer;
   public Button ButOpcion1;
   public Button ButOpcion2;
   public Button ButOpcion3;
   public Button ButOpcion4;

  // public int number;
   private List<Pregunta> listaPreguntas;
   private int index = 0;

   private float timer = 20f ;

   private void Start()
   {
 
        // 1. Crear las preguntas
        CrearPreguntas();
        // 2. Pregunta inicial
        CargarPregunta(0);

   }

    private void Update()
   {
 
       TextoTimer.text = Mathf.RoundToInt(timer).ToString();

       timer -= Time.deltaTime;

       if (timer < 0f){
                // acabo el tiempo

                TextoTimer.text = "-";

       }

   }

   private void CrearPreguntas ()
    {
            Pregunta p1 = new Pregunta();
            p1.Texto = "Esta es la pregunta 1?";
            p1.Opciones.Add("OPCION 1");
            p1.Opciones.Add("OPCION 2");
            p1.Opciones.Add("OPCION 3");
            p1.Opciones.Add("OPCION 4");
            p1.IndexCorrecta= 1;

            Pregunta p2 = new Pregunta();
            p2.Texto = "Esta es la pregunta 2?";
            p2.Opciones.Add("OPCION 1");
            p2.Opciones.Add("OPCION 2");
            p2.Opciones.Add("OPCION 3");
            p2.Opciones.Add("OPCION 4");
            p2.IndexCorrecta= 2;

            listaPreguntas = new List<Pregunta>();

            listaPreguntas.Add(p1);
            listaPreguntas.Add(p2);



    }

    private void CargarPregunta(int index)
    {

        Pregunta pregunta = listaPreguntas[index];
        TextoPregunta.text = pregunta.Texto;

        TextMeshProUGUI textoBoton1 = 
            ButOpcion1.transform.Find("Text").GetComponent<TextMeshProUGUI>();
        textoBoton1.text = pregunta.Opciones[0];

         TextMeshProUGUI textoBoton2 = 
            ButOpcion2.transform.Find("Text").GetComponent<TextMeshProUGUI>();
        textoBoton2.text = pregunta.Opciones[1];

         TextMeshProUGUI textoBoton3 = 
            ButOpcion3.transform.Find("Text").GetComponent<TextMeshProUGUI>();
        textoBoton3.text = pregunta.Opciones[2];

         TextMeshProUGUI textoBoton4 = 
            ButOpcion4.transform.Find("Text").GetComponent<TextMeshProUGUI>();
        textoBoton4.text = pregunta.Opciones[3];
    }


   public void SeleccionarOpcion(int num) {


         Pregunta pregunta = listaPreguntas[index];

         Color color;
           Debug.Log(num);
         if (pregunta.IndexCorrecta == num){
                    color = Color.green;
         }
             
         else {
                   color = Color.red;

         }

         
        switch(num){

        case 0:
            var colors = ButOpcion1.colors;
          
            colors.normalColor = color;
            colors.highlightedColor= color;
            colors.selectedColor = color;
            ButOpcion1.colors = colors;
        break;

        case 1:
            colors = ButOpcion2.colors;
            colors.normalColor = color;
            colors.highlightedColor= color;
            colors.selectedColor = color;
            ButOpcion2.colors = colors;
        break;

        case 2:
            colors = ButOpcion3.colors;
            colors.normalColor = color;
            colors.highlightedColor= color;
            colors.selectedColor = color;
            ButOpcion3.colors = colors;        
        break;

        case 3:
            colors = ButOpcion4.colors;
            colors.normalColor = color;
            colors.highlightedColor= color;
            colors.selectedColor = color;
            ButOpcion4.colors = colors;        
        break;
    }

   }

  
    

}
