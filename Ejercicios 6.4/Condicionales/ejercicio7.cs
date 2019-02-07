using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Condicionales - Ejercicio 7
	La variable 'hurt' puede tener 2 estados: true o false.
	Imprimir por consola según el resultado de esa vairable:
		true:	"ferit",
		false:	"player ok"
 */
public class ejercicio7 : MonoBehaviour {
	// Nota para el profe (por si acaso)
	// Si este comentario se transforma en /* al inicio se comentará en bloque y vicebersa con //*
	
	//* Ejercicio con la casilla de activación en el Inspector
		public bool hurt = true;

		// Solo imprime el título del ejercicio
		void Start(){
			Debug.Log("╔═════[►   Ejercicio 7   ◄]═════");
		}

		// Imprime por consola el estado de hurt
		void Update(){
			Debug.Log("│ hurt: "+ ( (hurt)?"ferit":"player ok" ));
		}
	// */

	/* Ejercicio solo por código
	void Start(){
		Debug.Log("╔═════[►   Ejercicio 7   ◄]═════");

		bool hurt = false;
		Debug.Log("│ hurt: "+ ( (hurt)?"ferit":"player ok" ));
	}
	// */
}
