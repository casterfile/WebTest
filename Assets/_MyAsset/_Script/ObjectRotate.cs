using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectRotate : MonoBehaviour {

    private float RotationSpeed = 90.0f;
    private string DataString = "";
    public Text DataText;
    // Use this for initialization
    void Start () {
        DataString = SystemInfo.deviceUniqueIdentifier;
        DataText.text = DataString;
        print("DataString: "+ DataString);
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up * (RotationSpeed * Time.deltaTime));

    }
}
