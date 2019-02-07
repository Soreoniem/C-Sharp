using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;				// resDiv.GetComponent<Text> │ Para que funcione el Text
using System;
using System.Threading;

/* Operaciones matemáticas - Ejercicio 4
	Di si un número es par o impar (usar if else)
 */
public class ejercicio4 : MonoBehaviour {

	// Use this for initialization
	void Start() {
		Debug.Log("╔═════[►   Ejercicio 4   ◄]═════");

		// Número aleatorio entre 0 y 10
		int numero = aleatorio(0, 10);

		// Devolver el resultado por consola
		Debug.Log("│ El número " + numero + " es " + ((numero % 2 == 0) ? "Par" : "Impar"));
	}

	/** Aleatorio
		📜 Info
			Calcula un número aleatorio y devuelve el resultado.

		🖊 Parametros
			@param minimo	- (Int)	Número mínimo
			@param maximo	- (Int)	Número máximo

			◄return			- (Int)	Número aleatorio

		🛠 Resolución de problemas
			• No es necesario aumentar el número máximo por que el alatorio lo reduce.
			• No es necesario escribir tanto para calcular un aleatorio
	*/
	private int aleatorio(int minimo, int maximo){
		return UnityEngine.Random.Range(minimo, (maximo + 1));
	}
}
