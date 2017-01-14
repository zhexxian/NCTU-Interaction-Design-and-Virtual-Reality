using UnityEngine;
using System.Collections;

public class RandomMaterial : MonoBehaviour {
	// Use this for initialization
	void Awake () {
		GetComponent<Renderer> ().material = GetRandomMaterial ();
    }
	


    /// <summary>
    /// helper method to get a random color
    /// </summary>
    /// <returns></returns>
	public Material GetRandomMaterial()
    {
		int x = Random.Range (0, 10);
        if (x == 0)
			return Resources.Load("Materials/Materials/101-section") as Material;
        else
			return Resources.Load("Materials/Materials/101-normal") as Material;
    }

}
