using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Condicionales - Ejercicio 10
	Crea una variable voleana collectOK.
	Cada vez que la variable esté en true, durante el juego, suma un punto a la variable puntuacio.
*/

/* Nota
	Hay 2 formas de hacerlo:
	[1].	Como indica el anunciado: A cada frame que la variable collectOK tenga el valor true, se aumentará el número a puntuacio.
	 2.		Solo cuando haga el cambio de false a true se aumenta el valor de puntuacio.
*/

/* ¿Qué versión se ha escogido?
	Usaré el punto 1 de Nota.
*/
public class ejercicio10_v1 : MonoBehaviour {
	int puntuacio;					// Almacena la puntuación actual.
	public bool collectOK = false;

	// Reinicia la variable puntuación por si acaso.
	void Start () {
		Debug.Log("╔═════[►   Ejercicio 10 (versión 1)   ◄]═════");
		puntuacio = 0;	// Reinicia la puntuación.
	}
	
	//
	void Update () {
		// collectOK es true: Aumenta puntuacio
		if( collectOK ){ puntuacio++; }

		// Imprime la variable puntuacio
		Debug.Log("│ "+ puntuacio);
	}
}
