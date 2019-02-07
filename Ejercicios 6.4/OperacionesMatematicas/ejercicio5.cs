using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;           // resDiv.GetComponent<Text> │ Para que funcione el Text
using System;
using System.Threading;

/* Operaciones matemáticas - Ejercicio 5
	Suma 2 palabras y devuelve el resultado en una frase.
 */
public class ejercicio5 : MonoBehaviour {
	void Start () {
		Debug.Log("╔═════[►   Ejercicio 5   ◄]═════");

		// 2 palabras y 1 resultado vacío.
		string palabra1 = "Lorem Ipsum", palabra2 = "dolor is amet", resultado;
		
		// Concatenar las palabras.
		resultado = palabra1 +" "+ palabra2;
		
		// Mostrar el resultado.
		Debug.Log("│ Concatenación de palabras: \""+ resultado +"\"");
	}
}
