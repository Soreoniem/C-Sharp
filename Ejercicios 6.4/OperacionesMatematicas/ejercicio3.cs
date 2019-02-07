using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;           // resDiv.GetComponent<Text> │ Para que funcione el Text
using System;
using System.Threading;

/* Operaciones matemáticas - Ejercicio 3
	Divide 2 números decimales y muestra el resultado.
 */
public class ejercicio3 : MonoBehaviour{
	void Start(){
		Debug.Log("╔═════[►   Ejercicio 3   ◄]═════");
		
		// 2 números aleatorios y el resultado
		float	dividendo	= aleatorio(0, 10),
				divisor		= aleatorio(0, 10),
				resultado	= (divisor != 0)		// Calcula y almacena el resultado. Si el número 2 (divisor) es 0 el resultado devolverá 0
					?(dividendo / divisor)
					:0
		;

		// Mostrará el resultado
		Debug.Log("│ Resultado de " + dividendo + " / " + divisor + " = " + resultado);
	}

	/** Aleatorio
		📜 Info
			Calcula un número aleatorio y devuelve el resultado.

		🖊 Parametros
			@param minimo	- (float)	Número mínimo
			@param maximo	- (float)	Número máximo

			◄return			- (float)	Número aleatorio

		🛠 Resolución de problemas
			• No es necesario escribir tanto para calcular un aleatorio
	*/
	private float aleatorio(float minimo, float maximo){
		return UnityEngine.Random.Range(minimo, maximo);
	}
}
