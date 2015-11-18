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

        if(GameObject.Find("GodivaImage"))
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
        if (GameObject.Find("GodivaImage"))
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
            var CenterPart = GameObject.Find("GodivaImage");
            this.transform.SetParent(CenterPart.transform);

            this.transform.GetComponentInChildren<LayoutElement>().preferredWidth = 50f;
            this.transform.GetComponentInChildren<LayoutElement>().preferredHeight = 50f;
        }
        if (Application.loadedLevelName == "Main_Scene")
        {
        }
        if (Application.loadedLevelName == "scene_2")
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


    }

    void OnmouseUpinMainmenu()
    {
        Debug.Log(this.transform.name.ToString());
        if ((135 <= Input.mousePosition.x) && (Input.mousePosition.x <= 265))
        {
            if ((380 <= Input.mousePosition.y) && (Input.mousePosition.y <= 465))
            {
                Debug.Log("Godiva");
                DestroyObject(this, 1);
                PlayerPrefs.SetInt(this.transform.name.ToString(), 1);
                PlayerPrefs.Save();
            }
        }

        DestroyObject(GameObject.Find(this.transform.name.ToString()), 1);
    }
}

