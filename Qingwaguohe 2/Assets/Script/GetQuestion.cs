using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetQuestion : MonoBehaviour
{
    public static GetQuestion Instance;
    public Button NextLevel;

    public Button up;
    public Button left;
    public Button right;
    public List<Text> AllText = new List<Text>();

    public void Awake()
    {

    }

    public void SetQueestion(int LevelNum)
    {
        GamesManager.Instance.GameStart = true;
        GamesManager.LevelNum = LevelNum;
        for (int i = 0; i < 3; i++)
        {

            string q = QuestionInfo.Instance.QuestionInfos[(LevelNum - 1) * 3 + i];
            string a1 = QuestionInfo.Instance.Answers1[(LevelNum - 1) * 3 + i];
            string a2 = QuestionInfo.Instance.Answers2[(LevelNum - 1) * 3 + i];
            string a3 = QuestionInfo.Instance.Answers3[(LevelNum - 1) * 3 + i];
            AllText[i * 4].text = q;
            AllText[i * 4].transform.parent.gameObject.transform.parent.gameObject.name = ((LevelNum - 1) * 3 + i + 1).ToString();
            AllText[i * 4 + 1].text = a1;
            AllText[i * 4 + 2].text = a2;
            AllText[i * 4 + 3].text = a3;
        }
    }
    void Start()
    {
        if (Application.platform == RuntimePlatform.Android )
        {

            up.transform.parent.gameObject.SetActive(true);
        }
        else
        {
            up.transform.parent.gameObject.SetActive(false);
        }
        up.onClick.AddListener(delegate
        {
            ButtonOnclick.Instance.panduantimu();
        });
        left.onClick.AddListener(delegate
        {
            GamesManager.Instance.left();
        });
        right.onClick.AddListener(delegate
        {
            GamesManager.Instance.right();
        });
        Instance = this;
        NextLevel.onClick.AddListener(delegate
        {
            GamesManager.Instance.Qingwa.SetActive(true);
            Destroy(gameObject.transform.gameObject);
            GamesManager.LevelNum++;
            if (GamesManager.LevelNum <= 6)
            {

                GamesManager.Instance.SetQuestion(GamesManager.LevelNum);
                ButtonOnclick.Instance.posId = 0;
                GamesManager.Instance.pos = 0;
                GamesManager.Instance.SetPos();
                //Debug.Log("Next");
            }
            else
            {
                Debug.Log("GameOver");
            }
        });
    }

    // Update is called once per frame
    void Update()
    {

        //var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //RaycastHit hit = new RaycastHit();
        //if (Input.GetMouseButtonDown(0))
        //{

        //    if (Physics.Raycast(ray,out hit))
        //    {
        //        Debug.Log(hit.transform.gameObject);
        //        if (hit.transform .gameObject .name=="up")
        //        {
        //            ButtonOnclick.Instance.panduantimu();
        //        }
        //        if (hit.transform.gameObject.name == "left")
        //        {

        //            GamesManager.Instance.left();
        //        }
        //        if (hit.transform.gameObject.name == "right")
        //        {
        //            GamesManager.Instance.right();

        //        }

        //    }
        //}
    }
}
