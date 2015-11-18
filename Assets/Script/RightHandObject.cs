using UnityEngine;
using System.Collections;

public class RightHandObject : MonoBehaviour {

    public string[] Objectnames = new string[] { "Dragon", "Archer" , "Alien" , "Clown_SNU" , "Horse" ,"M1","M2","Joker","Sports_Car","Emperor_Penguin"};

	// Use this for initialization
	void Start () {

        for(int i=0;i< Objectnames.Length; i++)
        {
            if (PlayerPrefs.HasKey(Objectnames[i]))
            {
                if (PlayerPrefs.GetInt(Objectnames[i] + "(Clone)") == 1)
                {
                    if(Application.loadedLevelName == "Godiva")
                    {
                        Debug.Log("Yeah!!!");
                        var RightPart = GameObject.Find("Right Part");
                        var SelectGameObject = GameObject.Find(PlayerPrefs.GetString(Objectnames[i]));
                        SelectGameObject.transform.SetParent(RightPart.transform);
                    }
                }

                if (PlayerPrefs.GetInt(Objectnames[i] + "(Clone)") == 2)
                {
                    if (Application.loadedLevelName == "Bubble")
                    {
                        Debug.Log("Cool!!!");
                        var RightPart = GameObject.Find("Right Part");
                        var SelectGameObject = GameObject.Find(PlayerPrefs.GetString(Objectnames[i]));
                        SelectGameObject.transform.SetParent(RightPart.transform);
                    }
                }

            }
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
