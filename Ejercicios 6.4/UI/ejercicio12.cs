using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Threading;

/* UI - Ejercicio 12
	Escribe en un texto de UI el contenido de un campo de entrada de texto.
*/
public class ejercicio12 : MonoBehaviour{
	public string texto;		// Puede cambiar el texto.
	public GameObject ui_ej12;	// Texto UI.
	
	// Mensaje de inicio del script
	void Start(){
		Debug.Log("╔═════[►   Ejercicio 12   ◄]═════");
	}

	void Update(){
		// Modifica el texto UI.
		ui_ej12.GetComponent<Text>().text = "Ejercicio 12: " + texto;
	}
}
