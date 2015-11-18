using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class classdrag : MonoBehaviour {

    Vector3 dist;
    float posX;
    float posY;

    void OnMouseDown()
    {
        //Debug.Log("Mouse down on " + gameObject.name);
        dist = Camera.main.WorldToScreenPoint(transform.position);
        posX = Input.mousePosition.x - dist.x;
        posY = Input.mousePosition.y - dist.y;

        OnmouseDowninScence();

    }

    void OnMouseDrag()
    {
        Vector3 curPos =
        new Vector3(Input.mousePosition.x - posX,
        Input.mousePosition.y - posY, dist.z);

        Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos);
        transform.position = worldPos;

<<<<<<< HEAD
        if(GameObject.Find("PlanentScene"))
=======
        if(GameObject.Find("GodivaImage"))
>>>>>>> 030538d46f39f3843591c7b19de7a92c5a9eb4c2
        {
            MouseDraginScence(curPos, worldPos);
        }
        else if(GameObject.Find("Mainmenu"))
        {
            Debug.Log(GameObject.Find("Mainmenu"));
            MouseDraginMainmenu(curPos, worldPos);
        }
        else
        {
            Debug.Log("Nothing Here");
        }

    }

    void OnMouseUp()
    {
<<<<<<< HEAD
        if (GameObject.Find("PlanentScene"))
=======
        if (GameObject.Find("GodivaImage"))
>>>>>>> 030538d46f39f3843591c7b19de7a92c5a9eb4c2
        {
            OnmouseUpinScence();
        }
        else if (GameObject.Find("Mainmenu"))
        {
            OnmouseUpinMainmenu();
        }

    }

    void MouseDraginScence(Vector3 curPos, Vector3 worldPos)
    {
        if (Input.mousePosition.y > 52)
        {
<<<<<<< HEAD
            var CenterPart = GameObject.Find("PlanentScene");
=======
            var CenterPart = GameObject.Find("GodivaImage");
>>>>>>> 030538d46f39f3843591c7b19de7a92c5a9eb4c2
            this.transform.SetParent(CenterPart.transform);

            this.transform.GetComponentInChildren<LayoutElement>().preferredWidth = 50f;
            this.transform.GetComponentInChildren<LayoutElement>().preferredHeight = 50f;
        }
<<<<<<< HEAD
        if (Application.loadedLevelName == "Godiva")
        {
        }
        if (Application.loadedLevelName == "Mainmenu")
=======
        if (Application.loadedLevelName == "Main_Scene")
        {
        }
        if (Application.loadedLevelName == "scene_2")
>>>>>>> 030538d46f39f3843591c7b19de7a92c5a9eb4c2
        {
        }
    }

    void OnmouseDowninScence()
    {

    }

    void OnmouseUpinScence()
    {
        if (Input.mousePosition.y <= 52)
        {
            var LeftPart = GameObject.Find("Left Part");
            this.transform.SetParent(LeftPart.transform);


            PlayerPrefs.SetString(this.transform.name.ToString(), this.transform.name.ToString());
            PlayerPrefs.Save();
        }
        else
        {

            this.transform.GetComponentInChildren<LayoutElement>().preferredWidth = 100f;
            this.transform.GetComponentInChildren<LayoutElement>().preferredHeight = 100f;

            this.transform.GetComponentInChildren<RectTransform>().sizeDelta = new Vector2(100f, 100f);

            PlayerPrefs.DeleteKey(this.transform.name.ToString());
            PlayerPrefs.DeleteKey(this.transform.name.ToString() + "(Clone)");

        }
    }

    void MouseDraginMainmenu(Vector3 curPos, Vector3 worldPos)
    {
<<<<<<< HEAD
        Debug.Log(Input.mousePosition.x + "     " + Input.mousePosition.y);
=======


>>>>>>> 030538d46f39f3843591c7b19de7a92c5a9eb4c2
    }

    void OnmouseUpinMainmenu()
    {
<<<<<<< HEAD
=======
        Debug.Log(this.transform.name.ToString());
>>>>>>> 030538d46f39f3843591c7b19de7a92c5a9eb4c2
        if ((135 <= Input.mousePosition.x) && (Input.mousePosition.x <= 265))
        {
            if ((380 <= Input.mousePosition.y) && (Input.mousePosition.y <= 465))
            {
                Debug.Log("Godiva");
<<<<<<< HEAD
                PlayerPrefs.SetInt(this.transform.name.ToString(), 1);
                PlayerPrefs.Save();

                DestroyObject(GameObject.Find(this.transform.name.ToString()), 1);
            }
        }

        if ((310 <= Input.mousePosition.x) && (Input.mousePosition.x <= 415))
        {
            if ((230 <= Input.mousePosition.y) && (Input.mousePosition.y <= 305))
            {
                Debug.Log("Bubble");
                PlayerPrefs.SetInt(this.transform.name.ToString(), 2);
                PlayerPrefs.Save();

                DestroyObject(GameObject.Find(this.transform.name.ToString()), 1);
            }
        }
=======
                DestroyObject(this, 1);
                PlayerPrefs.SetInt(this.transform.name.ToString(), 1);
                PlayerPrefs.Save();
            }
        }

        DestroyObject(GameObject.Find(this.transform.name.ToString()), 1);
>>>>>>> 030538d46f39f3843591c7b19de7a92c5a9eb4c2
    }
}

