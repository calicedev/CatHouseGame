using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager1_menu : MonoBehaviour {


    public GameObject myFurniture;
    public GameObject FurnitureStore;
    public GameObject Food;
   

    // Use this for initialization
    public void triggerMenuPanel1(bool b) {
        myFurniture.SetActive(!myFurniture.activeInHierarchy);
    }
    public void triggerMenuPanel2(bool b) {
        FurnitureStore.SetActive(!FurnitureStore.activeInHierarchy); }

    public void triggerMenuPanel3(bool b) {
        Food.SetActive(!Food.activeInHierarchy);
        }

  
}
