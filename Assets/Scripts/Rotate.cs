using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	public int x;
	public int y;
	public int z;

	void Update ()
	{
		transform.Rotate (x,y,z*Time.deltaTime); //rotates degrees per second around axis as defined
	}

}