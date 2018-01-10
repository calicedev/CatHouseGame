using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class Cat : MonoBehaviour {
    [SerializeField]
    private int _hunger;
    [SerializeField]
    private int _happiness;
    [SerializeField]
    private int _money;
    [SerializeField]
    private string _name;
    [SerializeField]
    private string _name2;
    [SerializeField]
    private string _food;

    public GameObject heart;

    private bool _serverTime;

    void Start() {
        PlayerPrefs.SetString("then","01/08/2018");
        updateStatus();
        if (!PlayerPrefs.HasKey("name")) {
            PlayerPrefs.SetString("name", "Cat");
            _name = PlayerPrefs.GetString("name");
        }
        if (!PlayerPrefs.HasKey("name2"))
        {
            PlayerPrefs.SetString("name2", "User");
            _name2 = PlayerPrefs.GetString("name2");
        }
    }
    private void Update()
    {
        if (Input.GetMouseButtonUp(0)) {
            Vector2 v = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(v), Vector2.zero);
            if (hit) {
                Debug.Log(hit.transform.gameObject.name);
                if (hit.transform.gameObject.tag == "whiteCat") {


                    if (_happiness >= 200)
                        updateMoney(4);
                    else if (_happiness >= 150)
                        updateMoney(3);
                    else if (_happiness >= 100)
                        updateMoney(2);
                    else updateMoney(1);

                }

            }

        }

        if (_hunger == 0) { SceneManager.LoadScene(2); }
    }
    void updateStatus() {
        if (!PlayerPrefs.HasKey("_hunger"))
        {
            _hunger = 100;
            PlayerPrefs.SetInt("_hunger", _hunger);
        }
        else {
            _hunger = PlayerPrefs.GetInt("_hunger");
        }
        if (!PlayerPrefs.HasKey("_happiness"))
        {
            _happiness = 0;
            PlayerPrefs.SetInt("_happiness", _happiness);
        }
        else
        {
            _happiness = PlayerPrefs.GetInt("_happiness");
        }
        if (!PlayerPrefs.HasKey("_money"))
        {
            _money = 0;
            PlayerPrefs.SetInt("_money", _money);
        }
        else
        {
            _money = PlayerPrefs.GetInt("_money");
        }
        if (!PlayerPrefs.HasKey("then"))
            PlayerPrefs.SetString("then", getStringTime());

        /*TimeSpan ts = getTimeSpan();
        _hunger += (int)(ts.TotalHours * 3);*/
        if (_hunger < 0)
            _hunger = 0;
        

        //_happiness -= (int)((100-_hunger) * (ts.TotalHours/5));
        if (_happiness < 0)
            _happiness = 0;

        if (_money < 0)
            _money = 0;

        Debug.Log(getTimeSpan().ToString());
        Debug.Log(getTimeSpan().TotalHours);

        if (_serverTime)
            updateServer();
        else
            InvokeRepeating ("updateDevice",0f,30f);//30초마다 시간 계속 업데이트함 

    }
    void updateServer() {
    }
    void updateDevice()
    {
        PlayerPrefs.SetString("then", getStringTime());
    }
    TimeSpan getTimeSpan() {
        if (_serverTime)
            return new TimeSpan();
        else
            return DateTime.Now - Convert.ToDateTime(PlayerPrefs.GetString("then"));

    }//시간과 시간사이를 빼서 시간이 얼마나 지났는지 알수 있다. 
    string getStringTime() {
        DateTime now = DateTime.Now;
        return now.Month + "/" + now.Day + "/" + now.Year + " " + now.Hour + ":" + now.Minute + ":" + now.Second;

    }
    public int hunger {
        get { return _hunger; }
        set { _hunger = value; }
    }
    public int happiness {
        get { return _happiness;}
        set { _happiness = value; }
    }
    public int money {
        get { return _money; }
        set { _money = value; }
    }
    public void updateMoney (int i){
        money += i;
        Debug.Log(money);
    }
    public string name {
        get { return _name; }
        set { _name = value; }
    }
    public string name2
    {
        get { return _name2; }
        set { _name2 = value; }
    }
    public string food
    {
        get { return _food; }
        set { _food = value; }
    }
    public void saveCat() {
        if (!_serverTime) {
            updateDevice();
        }
        PlayerPrefs.SetInt("_hunger",_hunger);
        PlayerPrefs.SetInt("_happiness", _happiness);
    }
    public void plusMinusHunger(bool a) {
        if (a)
            _hunger = _hunger + 1;
        else
            _hunger = _hunger - 1;
        PlayerPrefs.SetInt("hunger", _hunger);
    }
    public void plusMinusHappiness(bool a) {
        if (a)
            _happiness = _happiness + 1;
        else
            _happiness = _happiness - 1;
        PlayerPrefs.SetInt("happiness", _happiness);
    }
    public void plusMinusCoin(bool a) {
        if (a)
            _money = _money - 1;
        else
            _money = _money + 1;
    }
}
