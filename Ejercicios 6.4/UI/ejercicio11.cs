using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;				// Permite buscar objetos en GetComponent UI.

/* UI - Ejercicio 11
	Escribe en un texto de UI el contenido de una variable.
*/
public class ejercicio11 : MonoBehaviour{
	private string myText = "Generador de texto v11.";	// Variable con el texto
	public GameObject ui_ej11;							// Caja de texto UI

	void Start(){
		Debug.Log("╔═════[►   Ejercicio 11   ◄]═════");
		
		// Actualiza la caja de texto con el contenido de la variable
		ui_ej11.GetComponent<Text>().text = "Ejercicio 11: "+ myText;
	}
	
	// Update is called once per frame
	void Update(){
		
	}
}
