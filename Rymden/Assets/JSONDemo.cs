using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class JSONDemo : MonoBehaviour {

	string path;
	string jsonString;
	// Use this for initialization
	void Start () {

		path = Application.streamingAssetsPath + "/100.json";
		jsonString = File.ReadAllText (path);
		Creature Yumo = JsonUtility.FromJson<Creature> (jsonString);
		Debug.Log (Yumo.kluster);


		
	}

	
	// Update is called once per frame

}
[System.Serializable]
public class Creature
{
	public int kluster;
	public string[] koncept;
	public int[] vektor;
	public string rubrik;
	public int annonsid;

}
