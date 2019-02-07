using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Condicionales - Ejercicio 9
	Crea una variable arma.
	Sus poibles valores son de 0 a 4.
	Cada número corresponde a un arma diferente.

	Tabla de armas:
	╔════════════╦═══════════════════╗
	║   Número   │       Arma        ║
	╠────────────┼───────────────────╣
	║     0      │     Cuchillo      ║
	║     1      │      Pistola      ║
	║     2      │    Metralleta     ║
	║     3      │     Escopeta      ║
	║     4      │   LanzaGranadas   ║
	╚════════════╩═══════════════════╝
 */
public class ejercicio9 : MonoBehaviour {
	void Start(){
		Debug.Log("╔═════[►   Ejercicio 9   ◄]═════");
		
		// arma:		Número aleatorio entre 0 y 4.
		// resultado:	Contenedor de la información del arma escogida.
		int arma			= 5;
		string resultado	= "SinDatos";
		
		// Comprueba el id del arma y almacena el resultado en la variable resultado o el error.
		switch( arma ){
			case 0:		resultado =	"Cuchillo";				break;
			case 1:		resultado =	"Pistola";				break;
			case 2:		resultado =	"Metralleta";			break;
			case 3:		resultado =	"Escopeta";				break;
			case 4:		resultado =	"LanzaGranadas";		break;
			default:	resultado = "err_DatosErroneos";	break;
		}

		/* Comprueba si hay errores
			Si hay errores muestra el problema por consola.
			
			De lo contrario mostrará el resultado.
		*/
		if( resultado == "err_DatosErroneos" ){
			Debug.LogError("Error 404: No se encuentra el arma con id "+ arma);
		} else {
			Debug.Log("│ ["+ arma +"] "+ resultado );
		}
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
