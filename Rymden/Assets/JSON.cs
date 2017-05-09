using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class JSON : MonoBehaviour {
	
	string path;
	string jsonString;
	string realJobPath;
	string realJobString;
	int spawnPlanet;


	[SerializeField]
	private string[] haha;
	public GameObject Cube;



	// Use this for initialization
	void Start () {
		
		path = Application.streamingAssetsPath + "/100.json";	
		jsonString = File.ReadAllText(path);

		//realJobPath = ;
		//realJobString = File.ReadAllText(realJobPath);
		Debug.Log (jsonString);
		Debug.Log ("Multi");

		Planeter Jobb = JsonUtility.FromJson<Planeter>(fixJson(jsonString));
	//	newṔlanet (Jobb);
		Debug.Log ("Wooo");
		//Debug.Log (planet);



		foreach (var planet in Jobb.items){


			if(planet.rubrik == null){

				Debug.Log ("Null");


			}

			else{
			//	Debug.Log (planetX);
			//	Debug.Log (planetZ);
			//	Debug.Log (planetY);
				//Debug.Log ("Not Null");
				//Debug.Log (planet.vektor[0]);
				//Debug.Log (planet.vektor[1]);
				//Debug.Log (planet.vektor[2]);



				float x = float.Parse (planet.vektor [0]);
				float y = float.Parse (planet.vektor [1]);
				float z = float.Parse (planet.vektor [2]);
				float X = x * 300;
				float Y = y * 300;
				float Z = z * 400;
				string text = (planet.rubrik);
				string content = (planet.koncept);
				int AnnonsID = (planet.annonsid);
				//string TextID = text;
			
				Debug.Log (AnnonsID);
				//Instantiate(Cube, new Vector3(planet.vektor[0] , planet.vektor[1], planet.vektor[2]), Quaternion.identity);
				var gameo = Instantiate(Cube, new Vector3(X, Y, Z), Quaternion.identity);

				//gameo.tag = text;
				var r=gameo.GetComponentInChildren<TextMesh> ();
				var c = gameo.GetComponentInChildren<Canvas> ();
				//var cont = c.GetComponentInChildren<Text> ();
				r.text = (text);
				//c.content = (content);
				//TextMesh textObject = GameObject.Find ("planetText").GetComponent<TextMesh> ();
				//textObject.text = (text) ; 

				print (GetInstanceID ());


				//id++;
			}
				

		}


	}


	string fixJson(string value)
	{
		var res  = "{\"items\":" + value + "}";
		return res;
	}



	[System.Serializable]
	public class Planeter{
		public List<Planet> items;
	}

	[System.Serializable]
	public class Planet
	{
		
		public int kluster;
		public string koncept;
		public List<string> vektor;
		public string rubrik;
		public int annonsid;


	}

	public void newPlanet(Planeter Jobb){

		var planetX = Jobb.items.ToArray()[1].vektor[0];
		var planetY = Jobb.items.ToArray()[1].vektor[1];
		var planetZ = Jobb.items.ToArray()[1].vektor[2];

	}








}



