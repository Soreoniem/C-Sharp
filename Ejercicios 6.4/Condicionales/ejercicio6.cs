using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;           // resDiv.GetComponent<Text> │ Para que funcione el Text
using System;
using System.Threading;

/* Condicionales - Ejercicio 6
	Compara dos números enteros, mostrar si el primer número es mayor o menor que  el segundo.
*/
public class ejercicio6 : MonoBehaviour {
	void Start () {
		Debug.Log("╔═════[►   Ejercicio 6   ◄]═════");

		// 2 números aleatorios.
		int	num1 = aleatorio(0, 10),
			num2 = aleatorio(0, 10)
		;

		// Muestra los números escogidos.
		d("Número 1: "+ num1);
		d("Número 2: "+ num2);

		//Imprime el resultado según especificaciones del ejercicio.
		d(
			( num1 > num2 )?	"El número 1 es el mayor."
			:( num2 > num1 )?	"El número 1 es más pequeño."
			:"El número 1 y el 2 son iguales."
		);
	}

	/** d
		📜 Info
			Imprime por consola con una peculiaridad.
			La función se llama "d" para simplificar.

		🖊 Parametros
			@param mensaje	- (String)	Mensaje para imprimir por consola

		🛠 Resolución de problemas
			• Reduce el código necesario para imprimir por consola.
			• Añade una │ al inicio
	*/
	private void d(string mensaje){
		Debug.Log("│ "+ mensaje);
	}

	/** Aleatorio
		📜 Info
			Calcula un número aleatorio y devuelve el resultado.

		🖊 Parametros
			@param minimo	- (Int)	Número mínimo
			@param maximo	- (Int)	Número máximo

			◄return			- (Int)	Número aleatorio

		🛠 Resolución de probleams
			• No es necesario aumentar el número máximo por que el alatorio lo reduce.
			• No es necesario escribir tanto para calcular un aleatorio
	*/
	private int aleatorio(int minimo, int maximo)
	{
		return UnityEngine.Random.Range(minimo, maximo + 1);
	}
}
