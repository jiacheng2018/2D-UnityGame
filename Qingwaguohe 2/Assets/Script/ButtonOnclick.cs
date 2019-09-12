using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ButtonOnclick : MonoBehaviour
{
    public GameObject cuowu;
    public Text timu;
    public Text daan;
    public int posId = 0;
    private GameObject TragetObj;
    public static ButtonOnclick Instance;
    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        //gameObject.GetComponent<Button>().onClick.AddListener(delegate
        //{
        //    panduantimu();
        //});
    }

    public void OnTriggerStay(Collider other)
    {
        TragetObj = other.gameObject;
        Debug.Log(other.gameObject);
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("2");

        TragetObj = null;
    }

    private void OnCollisionStay(Collision collision)
    {
        TragetObj = collision.gameObject;
        Debug.Log(collision.gameObject);
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("2");

        TragetObj = null;
    }
    public void panduantimu()
    {
        if (Panduan())
        {
            foreach (var item in TragetObj.transform.parent.transform.gameObject.GetComponentsInChildren<BoxCollider>())

            {
                item.enabled = false;
            }
            if (int.Parse(TragetObj.transform.parent.name) % 3 != 0)
            {
                GameObject.FindGameObjectsWithTag("Question")[GameObject.FindGameObjectsWithTag("Question").Length - 1].SetActive(false);
                GameObject.FindGameObjectsWithTag("Mask")[GameObject.FindGameObjectsWithTag("Mask").Length - 1].SetActive(false);
                posId++;
                GamesManager.Instance.SetPos();
            }
            else
            {
                GamesManager.Instance.Qingwa.SetActive(false);
                GetQuestion.Instance.NextLevel.transform.parent.gameObject.SetActive(true);
                //Destroy(gameObject.transform.parent.transform.parent.gameObject);
                //GamesManager.LevelNum++;
                //if (GamesManager.LevelNum <= 6)
                //{
                //    GamesManager.Instance.SetQuestion(GamesManager.LevelNum);
               
                //}
                //else
                //{
                //    Debug.Log("GameOver");
                //}

            }


        }
        else
        {
            RightDaAn();
            Debug.Log("cuowu");
            foreach (var item in TragetObj.transform.parent.gameObject.transform.GetComponentsInChildren<Text>())
            {
                if (item.transform.parent.gameObject.name == daanshu.ToString())
                {
                    daan.text = "Answer:" + item.text;
                }
            }


            timu.text = "Question" + GameObject.FindGameObjectsWithTag("Question")[GameObject.FindGameObjectsWithTag("Question").Length - 1].GetComponentsInChildren<Text>()[0].text;
            cuowu.transform.parent = gameObject.transform;
            cuowu.transform.SetParent(GamesManager.Instance.Parent.transform);

            cuowu.SetActive(true);
        }
    }
    private int daanshu = 30;
    void RightDaAn()
    {
        switch (TragetObj.transform.parent.gameObject.name)
        {
            case "1":
                daanshu = 1;
                break;
            case "2":
                daanshu = 1;
                break;
            case "3":
                daanshu = 2;
                break;
            case "4":
                daanshu = 1;
                break;
            case "5":
                daanshu = 2;
                break;
            case "6":
                daanshu = 3;
                break;
            case "7":
                daanshu = 2;
                break;
            case "8":
                daanshu = 2;
                break;
            case "9":
                daanshu = 3;
                break;
            case "10":
                daanshu = 2;
                break;
            case "11":
                daanshu = 1;
                break;
            case "12":
                daanshu = 1;
                break;
            case "13":
                daanshu = 2;
                break;
            case "14":
                daanshu = 1;
                break;
            case "15":
                daanshu = 3;
                break;
            case "16":
                daanshu = 3;
                break;
            case "17":
                daanshu = 2;
                break;
            case "18":
                daanshu = 1;
                break;
            default:
                daanshu = 30;
                break;
        }
    }
    // Update is called once per frame

    bool Panduan()
    {
        bool a = false;
        switch (TragetObj.transform.parent.gameObject.name)
        {
            case "1":
                a = Pos1();
                break;
            case "2":
                a = Pos1();
                break;
            case "3":
                a = Pos2();
                break;
            case "4":
                a = Pos1();
                break;
            case "5":
                a = Pos2();
                break;
            case "6":
                a = Pos3();
                break;
            case "7":
                a = Pos2();
                break;
            case "8":
                a = Pos2();
                break;
            case "9":
                a = Pos3();
                break;
            case "10":
                a = Pos2();
                break;
            case "11":
                a = Pos1();
                break;
            case "12":
                a = Pos1();
                break;
            case "13":
                a = Pos2();
                break;
            case "14":
                a = Pos1();
                break;
            case "15":
                a = Pos3();
                break;
            case "16":
                a = Pos3();
                break;
            case "17":
                a = Pos2();
                break;
            case "18":
                a = Pos1();
                break;
            default:
                a = false;
                break;
        }
        return a;
    }

    private bool Pos1()
    {
        if (TragetObj.name == "1")
        {
            // GamesManager.Instance.Qingwa.transform.DOMove(gameObject.transform.position, 1f);
            return true;
        }
        else
        {
            return false;
        }


    }
    private bool Pos2()
    {
        if (TragetObj.name == "2")
        {
            // GamesManager.Instance.Qingwa.transform.DOMove(gameObject.transform.position, 1f);
            return true;
        }
        else
        {
            return false;
        }

    }
    private bool Pos3()
    {
        if (TragetObj.name == "3")
        {
            //s GamesManager.Instance.Qingwa.transform.DOMove(gameObject.transform.position, 1f);
            return true;
        }
        else
        {
            return false;
        }


    }
    void Update()
    {

    }
}
