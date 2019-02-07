using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Condicionales - Ejercicio 10
	Crea una variable voleana collectOK.
	Cada vez que la variable esté en true, durante el juego, suma un punto a la variable puntuacio.
*/

/* Nota
	Hay 2 formas de hacerlo:
	 1.		Como indica el anunciado: A cada frame que la variable collectOK tenga el valor true, se aumentará el número a puntuacio.
	[2].	Solo cuando haga el cambio de false a true se aumenta el valor de puntuacio.
*/

/* ¿Qué versión se ha escogido?
	Usaré el punto 2 de Nota.
*/

public class ejercicio10_v2 : MonoBehaviour {
	int puntuacio;					// Almacena la puntuación actual.
	public bool collectOK		= false;

	// Hostorial de collectOK
	bool collectOK_ant	= false;	// Estado ANTerior de collectOK.
	bool collectOK_act	= false;	// Estado ACTual de collectOK.

	// Reinicia la variable puntuación por si acaso.
	void Start () {
		Debug.Log("╔═════[►   Ejercicio 10 (versión 2)   ◄]═════");
		puntuacio = 0;	// Reinicia la puntuación.
	}
	
	//
	void Update () {
		// Se almacena el estado actual de collectOK.
		collectOK_act = collectOK;

		// Si el actual es diferente al anterior quiere decir que ha cambiado.
		if( collectOK_act != collectOK_ant ){
			// puntuacio solo aumentará cuando collectOK cambie a true.
			if( collectOK_act ){ puntuacio++; Debug.Log("│ Puntuación: "+ puntuacio); }

			// El estado actual se actualiza al actual.
			collectOK_ant = collectOK_act;
		}
	}
}
