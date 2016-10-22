using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;

public class CSVReader : MonoBehaviour {

	public TextAsset csvFile;
	public GameObject objectToSpawn;
	private char lineSeperator = '\n';
	private char fieldSeperator = ',';

	private string[] records;
	private string[] fields;

	void Start()
	{
		spawnObjectsFromCSV ();
	}

	//Spawn the intended objects from the parsed locations.
	private void spawnObjectsFromCSV()
	{
		records = csvFile.text.Split (lineSeperator);
		for (int i = 0; i < records.Length; i++) {
			fields = records [i].Split (fieldSeperator);
			float x = float.Parse(fields [0]);
			float y = float.Parse(fields [1]);
			float z = float.Parse(fields [2]);
			Instantiate (objectToSpawn, new Vector3 (x, y, z), Quaternion.identity);
		}
	}

}
