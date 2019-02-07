using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;               // Permite buscar objetos en GetComponent UI.

/* UI - Ejercicio 15
	Recrea el mismo ejercicio anterior, ejercicio 14, pero con botones UI.

	Cuando se pulse el [botón│Aumentar]:	El [marcador] debe subir 10 puntos.
	Cuando se pulse el [botón│Reducir]:		El [marcador] debe bajar  5 puntos.
*/
public class ejercicio15 : MonoBehaviour {
	public int marcador = 0;							// Marcador
	public Button btnEj15_aumentar, btnEj15_reducir;	// Botones
	
	void Start(){
		// Inicio del programa.
		Debug.Log("╔═════[►   Ejercicio 15   ◄]═════");

		// Listeners onClick
		btnEj15_aumentar.onClick.AddListener(aumentar);
		btnEj15_reducir.onClick.AddListener(reducir);
	}

	// Aumenta el valor de [atributo│marcador]
	private void aumentar(){ marcador += 10; }

	// Reduce el valor de [atributo│marcador]
	private void reducir(){ marcador -= 5; }
}
