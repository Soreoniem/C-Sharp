using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Condicionales - Ejercicio 8
	Crea una variable playerPoints.
	Cuando esta variable sea más grande que o igual a 10 muestra un mensaje el siguiente mensaje "Bonus OK".
	Si además si es más grande que 50 da el mensaje de "vida extra".
	Y si es más pequeño de 10 muestra el mensaje de "No bonus"
 */
public class ejercicio8 : MonoBehaviour{
	public int playerPoints = 0;	// Puntaje del jugador

	// Solo imprime el título del ejercicio.
	void Start(){
		Debug.Log("╔═════[►   Ejercicio 8   ◄]═════");
	}


	void Update(){
		// Menor a 10: No bonus.
		if( playerPoints < 10 ){
			Debug.Log("│ " + "No bonus");
		
		} else {
			// Mayor o igual a 10: Bonus OK.
			if (playerPoints >= 10) { Debug.Log("│ Bonus OK"); }

			// Y mayor a 50: vida extra.
			if (playerPoints > 50) { Debug.Log("│ vida extra"); }
		}
	}
}
