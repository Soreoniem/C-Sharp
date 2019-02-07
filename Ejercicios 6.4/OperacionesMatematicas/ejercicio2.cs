using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;           // resDiv.GetComponent<Text> │ Para que funcione el Text
using System;
using System.Threading;

/* Operaciones matemáticas - Ejercicio 2
	Multiplica 2 números enteros y devuelve el resultado.
 */
public class ejercicio2 : MonoBehaviour{
	void Start(){
		Debug.Log("╔═════[►   Ejercicio 2   ◄]═════");
		
		// 2 Números aleatorios de 0 a 10.
		int num1 = aleatorio(0, 10),
			num2 = aleatorio(0, 10);
		
		// Imprimir el resultado por pantalla.
		Debug.Log("│ Resultado de "+ num1 +" * "+ num2 +" = "+ (num1 * num2));
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
	private int aleatorio(int minimo, int maximo)
	{
		return UnityEngine.Random.Range(minimo, maximo + 1);
	}
}
