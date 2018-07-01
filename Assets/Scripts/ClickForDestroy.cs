using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickForDestroy : MonoBehaviour {

	void OnMouseDown()
	{
		Destroy (this.gameObject);
	}

}
