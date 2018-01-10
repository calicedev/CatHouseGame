using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour {

    public GameObject food;
    private void Update()
    {
       
    }
    public void triggerFood(bool b) {
        food.SetActive(!food.activeInHierarchy);
    }
}
