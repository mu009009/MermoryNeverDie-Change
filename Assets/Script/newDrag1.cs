using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class newDrag1 : MonoBehaviour
{

    Vector3 dist;
    float posX;
    float posY;

    void Start()
    {

    }

    void Update()
    {

    }


    void OnMouseDown()
    {
        Debug.Log("Mouse down on " + gameObject.name);
        dist = Camera.main.WorldToScreenPoint(transform.position);
        posX = Input.mousePosition.x - dist.x;
        posY = Input.mousePosition.y - dist.y;

    }

    void OnMouseDrag()
    {
        Vector3 curPos =
                  new Vector3(Input.mousePosition.x - posX,
                  Input.mousePosition.y - posY, dist.z);

        Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos);
        transform.position = worldPos;

        if (Input.mousePosition.y > 100)
        {
            var CenterPart = GameObject.Find("Image2");
            this.transform.SetParent(CenterPart.transform);

            this.transform.GetComponentInChildren<LayoutElement>().preferredWidth = 50f;
            this.transform.GetComponentInChildren<LayoutElement>().preferredHeight = 50f;
        }
    }

    void OnMouseUp()
    {

        if (Input.mousePosition.y <= 100)
        {
            var LeftPart = GameObject.Find("buttonPart");
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

        }

    }
}
