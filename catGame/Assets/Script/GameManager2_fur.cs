using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManager2_fur : MonoBehaviour
{


    public GameObject bluesofa;
    public GameObject pinksofa;
    public GameObject browndesk;
    public GameObject bluedesk;
    public GameObject cactus;
    public GameObject flower;
    public GameObject graydesk;
    public GameObject tv;
    public GameObject whitechair;
    public GameObject milk;
    public GameObject bed;
    public GameObject books;
    public Text scoreText;
    public int score;
    public GameObject cat;

    public GameObject noMoneyPanel;


    public void triggerbluesofa(bool b)
    {
        if (cat.GetComponent<Cat>().money < 70)
            noMoneyPanel.SetActive(!noMoneyPanel.activeInHierarchy);
        else
        {
            bluesofa.SetActive(!bluesofa.activeInHierarchy);
            if (bluesofa.activeInHierarchy == false)
            {
                score = score - 70;
                for (int i = 0; i < 70; i++)
                {
                    cat.GetComponent<Cat>().plusMinusHappiness(false);
                    cat.GetComponent<Cat>().plusMinusCoin(false);
                }
            }
            else
            {
                score = score + 70;
                for (int i = 0; i < 70; i++)
                {
                    cat.GetComponent<Cat>().plusMinusHappiness(true);
                    cat.GetComponent<Cat>().plusMinusCoin(true);
                }

            }
        }


    }

    public void triggerpinksofa(bool b)
    {
        if (cat.GetComponent<Cat>().money < 40)
            noMoneyPanel.SetActive(!noMoneyPanel.activeInHierarchy);
        else
        {

            pinksofa.SetActive(!pinksofa.activeInHierarchy);
            if (pinksofa.activeInHierarchy == false)
            {
                score = score - 40;
                for (int i = 0; i < 40; i++)
                {
                    cat.GetComponent<Cat>().plusMinusHappiness(false);
                    cat.GetComponent<Cat>().plusMinusCoin(false);
                }
            }
            else
            {
                score = score + 40;
                for (int i = 0; i < 40; i++)
                {
                    cat.GetComponent<Cat>().plusMinusHappiness(true);
                    cat.GetComponent<Cat>().plusMinusCoin(true);
                }
            }
        }
    }
    public void triggerbrowndesk(bool b)
    {
        if (cat.GetComponent<Cat>().money < 40)
            noMoneyPanel.SetActive(!noMoneyPanel.activeInHierarchy);
        else
        {
            browndesk.SetActive(!browndesk.activeInHierarchy);
            if (browndesk.activeInHierarchy == false)
            {
                score = score - 40;
                for (int i = 0; i < 40; i++)
                {
                    cat.GetComponent<Cat>().plusMinusHappiness(false);
                    cat.GetComponent<Cat>().plusMinusCoin(false);
                }
            }
            else
            {
                score = score + 40;
                for (int i = 0; i < 40; i++)
                {
                    cat.GetComponent<Cat>().plusMinusHappiness(true);
                    cat.GetComponent<Cat>().plusMinusCoin(true);
                }
            }
        }
    }
    public void triggerbluedesk(bool b)
    {
        if (cat.GetComponent<Cat>().money < 10)
            noMoneyPanel.SetActive(!noMoneyPanel.activeInHierarchy);
        else
        {
            bluedesk.SetActive(!bluedesk.activeInHierarchy);
            if (bluedesk.activeInHierarchy == false)
            {
                score = score - 10;
                for (int i = 0; i < 10; i++)
                {
                    cat.GetComponent<Cat>().plusMinusHappiness(false);
                    cat.GetComponent<Cat>().plusMinusCoin(false);

                }
            }
            else
            {
                score = score + 10;
                for (int i = 0; i < 10; i++)
                {
                    cat.GetComponent<Cat>().plusMinusHappiness(true);
                    cat.GetComponent<Cat>().plusMinusCoin(true);
                }
            }
        }
    }

    public void triggercactus(bool b)
    {
        if (cat.GetComponent<Cat>().money < 10)
            noMoneyPanel.SetActive(!noMoneyPanel.activeInHierarchy);
        else
        {
            cactus.SetActive(!cactus.activeInHierarchy);
            if (cactus.activeInHierarchy == false)
            {
                score = score - 10;
                for (int i = 0; i < 10; i++)
                {
                    cat.GetComponent<Cat>().plusMinusHappiness(false);
                    cat.GetComponent<Cat>().plusMinusCoin(false);
                }
            }
            else
            {
                score = score - 10;
                for (int i = 0; i < 10; i++)
                {
                    cat.GetComponent<Cat>().plusMinusHappiness(true);
                    cat.GetComponent<Cat>().plusMinusCoin(true);
                }
            }
        }
    }

    public void triggerflower(bool b)
    {
        if (cat.GetComponent<Cat>().money < 10)
            noMoneyPanel.SetActive(!noMoneyPanel.activeInHierarchy);
        else
        {
            flower.SetActive(!flower.activeInHierarchy);
            if (flower.activeInHierarchy == false)
            {
                score = score - 10;
                for (int i = 0; i < 10; i++)
                {
                    cat.GetComponent<Cat>().plusMinusHappiness(false);
                    cat.GetComponent<Cat>().plusMinusCoin(false);
                }
            }
            else
            {
                score = score - 10;
                for (int i = 0; i < 10; i++)
                {
                    cat.GetComponent<Cat>().plusMinusCoin(true);
                    cat.GetComponent<Cat>().plusMinusHappiness(true);
                }
            }
        }
    }

    public void triggergraydesk(bool b)
    {
        if (cat.GetComponent<Cat>().money < 10)
            noMoneyPanel.SetActive(!noMoneyPanel.activeInHierarchy);
        else
        {
            graydesk.SetActive(!graydesk.activeInHierarchy);
            if (graydesk.activeInHierarchy == false)
            {
                score = score - 10;
                for (int i = 0; i < 10; i++)
                {
                    cat.GetComponent<Cat>().plusMinusHappiness(false);
                    cat.GetComponent<Cat>().plusMinusCoin(false);
                }
            }
            else
            {
                score = score - 10;
                for (int i = 0; i < 10; i++)
                {
                    cat.GetComponent<Cat>().plusMinusHappiness(true);
                    cat.GetComponent<Cat>().plusMinusCoin(true);
                }
            }
        }
    }

    public void triggertv(bool b)
    {
        if (cat.GetComponent<Cat>().money < 10)
            noMoneyPanel.SetActive(!noMoneyPanel.activeInHierarchy);
        else
        {
            tv.SetActive(!tv.activeInHierarchy);
            if (tv.activeInHierarchy == false)
            {
                score = score - 10;
                for (int i = 0; i < 10; i++)
                {
                    cat.GetComponent<Cat>().plusMinusHappiness(false);
                    cat.GetComponent<Cat>().plusMinusCoin(false);
                }
            }
            else
            {
                score = score - 10;
                for (int i = 0; i < 10; i++)
                {
                    cat.GetComponent<Cat>().plusMinusHappiness(true);
                    cat.GetComponent<Cat>().plusMinusCoin(true);
                }
            }
        }
    }

    public void triggerwhitechair(bool b)
    {
        if (cat.GetComponent<Cat>().money < 10)
            noMoneyPanel.SetActive(!noMoneyPanel.activeInHierarchy);
        else
        {
            whitechair.SetActive(!whitechair.activeInHierarchy);
            if (whitechair.activeInHierarchy == false)
            {
                score = score - 10;
                for (int i = 0; i < 10; i++)
                {
                    cat.GetComponent<Cat>().plusMinusHappiness(false);
                    cat.GetComponent<Cat>().plusMinusCoin(false);
                }
            }
            else
            {
                score = score - 10;
                for (int i = 0; i < 10; i++)
                {
                    cat.GetComponent<Cat>().plusMinusHappiness(true);
                    cat.GetComponent<Cat>().plusMinusCoin(true);
                }
            }
        }
    }
    public void triggermilk(bool b)
    {
        if (cat.GetComponent<Cat>().money < 10)
            noMoneyPanel.SetActive(!noMoneyPanel.activeInHierarchy);
        else
        {
            milk.SetActive(!milk.activeInHierarchy);
            if (milk.activeInHierarchy == false)
            {
                score = score - 10;
                for (int i = 0; i < 10; i++)
                {
                    cat.GetComponent<Cat>().plusMinusHappiness(false);
                    cat.GetComponent<Cat>().plusMinusCoin(true);
                }
            }
            else
            {
                score = score - 10;
                for (int i = 0; i < 10; i++)
                {
                    cat.GetComponent<Cat>().plusMinusHappiness(true);
                    cat.GetComponent<Cat>().plusMinusCoin(true);
                }
            }
        }
    }

    public void triggerbed(bool b)
    {
        if (cat.GetComponent<Cat>().money < 10)
            noMoneyPanel.SetActive(!noMoneyPanel.activeInHierarchy);
        else
        {
            bed.SetActive(!bed.activeInHierarchy);
            if (bed.activeInHierarchy == false)
            {
                score = score - 10;
                for (int i = 0; i < 10; i++)
                {
                    cat.GetComponent<Cat>().plusMinusHappiness(false);
                    cat.GetComponent<Cat>().plusMinusCoin(false);
                }
            }
            else
            {
                score = score - 10;
                for (int i = 0; i < 10; i++)
                {
                    cat.GetComponent<Cat>().plusMinusHappiness(true);
                    cat.GetComponent<Cat>().plusMinusCoin(true);
                }
            }
        }
    }


    public void triggerbooks(bool b)
    {
        if (cat.GetComponent<Cat>().money < 10)
            noMoneyPanel.SetActive(!noMoneyPanel.activeInHierarchy);
        else
        {
            books.SetActive(!books.activeInHierarchy);
            if (books.activeInHierarchy == false)
            {
                score = score - 10;
                for (int i = 0; i < 10; i++)
                {
                    cat.GetComponent<Cat>().plusMinusHappiness(false);
                    cat.GetComponent<Cat>().plusMinusCoin(false);
                }
            }
            else
            {
                score = score - 10;
                for (int i = 0; i < 10; i++)
                {
                    cat.GetComponent<Cat>().plusMinusHappiness(true);
                    cat.GetComponent<Cat>().plusMinusCoin(true);
                }
            }
        }
    }
    public void triggerMoneyPanel(bool a)
    {
        noMoneyPanel.SetActive(false);
    }




}
