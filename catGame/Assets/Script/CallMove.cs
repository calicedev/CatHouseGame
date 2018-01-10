using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallMove : MonoBehaviour
{
    public GameObject cat;
    public GameObject hungry;
    private Vector2 pos;
    public Camera camera;

    // Use this for initialization
    void Start()
    {
        pos = cat.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (cat.GetComponent<Cat>().hunger <= 30)
        {
            pos = cat.transform.position;
            Vector3 screenPos = camera.WorldToScreenPoint(pos);
            hungry.SetActive(true);
      
            hungry.transform.position = new Vector3(screenPos.x, screenPos.y + (float)80, hungry.transform.position.z);
        }
        else
        {
            hungry.SetActive(false);
        }
    }
}
