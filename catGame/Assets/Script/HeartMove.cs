using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartMove : MonoBehaviour
{
    public GameObject cat;
    public GameObject heart;
    private Vector2 pos;
    // Use this for initialization
    void Start()
    {
        pos = cat.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (cat.GetComponent<Cat>().hunger > 30)
        {
            heart.SetActive(true);
            pos = cat.transform.position;
            heart.transform.position = new Vector2(pos.x, pos.y + (float)0.8);
        }
        else
        {
            heart.SetActive(false);
        }
    }
}
