using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;               // Permite buscar objetos en GetComponent UI.

/* UI - Ejercicio 13
	Pide al usuario que introduzca su edad (variable pública)
	Y muestra el siguiente mensaje según su edad:
		• "ets major d’edat"
		• "ets menor d’edat"
*/
public class ejercicio13 : MonoBehaviour {
	public int			edad;
	public GameObject	ui_ej13;

	void Start(){
		Debug.Log("╔═════[►   Ejercicio 13   ◄]═════");

		// Pedir al usuario que introduzca su edad.
		ui_ej13.GetComponent<Text>().text = "Ejercicio 13: Por favor introduce tu edad.";
	}
	
	// Update is called once per frame
	void Update(){
		/*
			Menor o igual a 0:	Pedir edad.
			Mayor o igual a 18:	Mayor de edad.
			Resto:				Menor de edad.

			Info como se ha comprobado los 2 extremos (0 y 18) el resto es entre ellos (menor de edad).
		*/
		ui_ej13.GetComponent<Text>().text =
			 ( edad <= 0 )?		"Ejercicio 13: Por favor introduce tu edad."
			:( edad >= 18 )?	"Ejercicio 13: ets major d'edat"
			:	"Ejercicio 13: ets menor d'edat"
		;
	}
}
