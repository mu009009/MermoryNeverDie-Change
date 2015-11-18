using UnityEngine;
using System.Collections;

public class Changescene : MonoBehaviour {

	
	
	public void ChangeToscene (string ChangeToscene) {
        Application.LoadLevel(ChangeToscene);
	}
}
