using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	public GameObject BodyInventory;

	// Use this for initialization
	void Start () {
		
	} 
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Tab))
		{
			if (BodyInventory.activeInHierarchy == true) {
				BodyInventory.SetActive (false);
			} else 
			{ 
				BodyInventory.SetActive (true);
			}

		}
	}
}
