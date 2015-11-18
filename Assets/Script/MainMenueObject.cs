using UnityEngine;
using System.Collections;

public class MainMenueObject : MonoBehaviour {

    RightHandObject nameNumber = new RightHandObject();

    public GameObject preFab;

	// Use this for initialization
	void Start () {

        var nameCount = nameNumber.Objectnames.Length;

        var Container = GameObject.Find("buttonPart");

        for (int i = 0;i<nameCount;i++)
        {   
            if (PlayerPrefs.HasKey(nameNumber.Objectnames[i]))
            {
                if(preFab.transform.name.ToString()== PlayerPrefs.GetString(nameNumber.Objectnames[i]))
                {
                    var PositionPoint = new Vector3(10, 10, -32);
                    var Object = Instantiate(preFab, PositionPoint, Quaternion.identity);
                    GameObject.Find(preFab.transform.name.ToString() + "(Clone)").transform.SetParent(Container.transform);
                }
            }
        }

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
