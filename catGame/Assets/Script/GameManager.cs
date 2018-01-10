using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {
    public GameObject happinessText;
    public GameObject hungerText;
    public Image happinessBar;
    public Image hungerBar;
    public GameObject moneyText;

    public GameObject namePanel;
    public GameObject nameInput;
    public GameObject nameInput2;
    public GameObject nameText;
    public GameObject nameText2;

    public GameObject foodPanel;
    public GameObject foodbutton;
    public Sprite[] foodIcons;

    public GameObject myFurniture;
    public GameObject FurnitureStore;
    public GameObject Food;
    public GameObject Developer;
    public GameObject cat;
    public GameObject user;

    // Update is called once per frame
    void Update () {
        float calc_happiness = (float)(((float)cat.GetComponent<Cat>().happiness) / (float)500);
        float calc_hunger = (float)((float)cat.GetComponent<Cat>().hunger / (float)100);
        happinessBar.fillAmount = calc_happiness;
        hungerBar.fillAmount = calc_hunger;

        happinessText.GetComponent<Text> ().text = cat.GetComponent<Cat> ().happiness.ToString();
        hungerText.GetComponent<Text>().text = cat.GetComponent<Cat>().hunger.ToString();
        moneyText.GetComponent<Text>().text = cat.GetComponent<Cat>().money.ToString();
        nameText.GetComponent<Text>().text = cat.GetComponent<Cat>().name + "..";
        nameText2.GetComponent<Text>().text = cat.GetComponent<Cat>().name2;
    }


    public void triggerNamePanel(bool b)
    {
        namePanel.SetActive(!namePanel.activeInHierarchy);
        if (b)
        {
            cat.GetComponent<Cat>().name = nameInput.GetComponent<InputField>().text;
            PlayerPrefs.SetString("name", cat.GetComponent<Cat>().name);
            cat.GetComponent<Cat>().name2 = nameInput2.GetComponent<InputField>().text;
            PlayerPrefs.SetString("name2", cat.GetComponent<Cat>().name2);
        }
    }

    public void buttonBehavior(int i)
    {
        switch (i)
        {
            case (0):
                foodPanel.SetActive(!foodPanel.activeInHierarchy);
                break;

        }
       
    }

    public void selctfood(int i)
    {
        toggle(foodPanel);
    }

    public void toggle(GameObject g)
    {
        if (g.activeInHierarchy)
            g.SetActive(false);
    }
    // Use this for initialization
    public void triggerMenuPanel1(bool b)
    {
        myFurniture.SetActive(!myFurniture.activeInHierarchy);
    }
    public void triggerMenuPanel2(bool b)
    {
        FurnitureStore.SetActive(!FurnitureStore.activeInHierarchy);
    }

    public void triggerMenuPanel3(bool b)
    {
        Food.SetActive(!Food.activeInHierarchy);
    }
    public void triggerMenuPanelDeveloper(bool b) {
        Developer.SetActive(!Developer.activeInHierarchy);
    }

    public void DeveloperbuttonBehavior(int i) {
        switch (i) {
            case 0:
                cat.GetComponent<Cat>().plusMinusHunger(false);
                break;
                /*cat.GetComponent<Cat>().saveCat();
                Application.Quit();
                break;*/
            case 1:
                cat.GetComponent<Cat>().plusMinusHunger(true);
                break;
            case 2:
                cat.GetComponent<Cat>().plusMinusHappiness(false);
                break;
            case 3:
                cat.GetComponent<Cat>().plusMinusHappiness(true);
                break;
        }

    }
    
}

