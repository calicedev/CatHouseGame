using UnityEngine;
using System.Collections;


public class drag2 : MonoBehaviour
{
 
    void OnMouseDrag()
    {

        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.y);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.position = objPosition;

   

        /* if (Input.getMouseButtomUp(0))
        {
            Debug.Log("Clicked");
        }*/
    }
}