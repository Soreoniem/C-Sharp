using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;               // Permite buscar objetos en GetComponent UI.

/* UI - Ejercicio 14
	Cuando se pulse la tecla A se debe sumar 10 puntos al marcador.
	Si pulsas la tecla D restará 5 puntos.

	Resumen:
	Tecla A - marcador += 10
	Tecla D - marcador -= 5
*/
public class ejercicio14 : MonoBehaviour {
	public int marcador = 0;

	void Start(){
		// Inicio del programa.
		Debug.Log("╔═════[►   Ejercicio 14   ◄]═════");
	}
	
	void Update(){
		// Pulsar tecla A: Suma 10 al marcador
		if( Input.GetKeyDown(KeyCode.A) ){ marcador += 10; }

		// Pulsar tecla D: Resta 5 al marcador
		if( Input.GetKeyDown(KeyCode.D) ){ marcador -= 5; }
	}
}
