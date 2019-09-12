using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GamesManager : MonoBehaviour
{
    public Vector3 qingwa;
    public GameObject Qingwa;
    public static GamesManager Instance;
    public static int LevelNum = 1;
    public GameObject Parent;
    public GameObject Obj;

    public List<GameObject> timu1 = new List<GameObject>();
    public List<GameObject> timu2 = new List<GameObject>();
    public List<GameObject> timu3 = new List<GameObject>();
    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        // SetQuestion(LevelNum);
    }
    public bool GameStart = false;
    public void SetQuestion(int levelNum)
    {
        var o = Instantiate(Obj, Parent.transform);
        o.SetActive(true);
        Qingwa.transform.SetParent(o.transform);
        Qingwa.transform.parent = Parent.transform;
        GamesManager.Instance.Qingwa.transform.localPosition = GamesManager.Instance.qingwa;
        o.GetComponent<GetQuestion>().SetQueestion(levelNum);
        ButtonOnclick.Instance.posId = 0;
        GamesManager.Instance.SetPos();
    }
    public  int pos = 0;
    // Update is called once per frame
   public  void SetPos()
    {
        List<GameObject> vectors = new List<GameObject>();
        if (ButtonOnclick.Instance.posId == 0)
        {
            vectors = timu1;
        }
        else if (ButtonOnclick.Instance.posId == 1)
        {
            vectors = timu2;


        }
        else if (ButtonOnclick.Instance.posId == 2)
        {
            vectors = timu3;

        }
        Qingwa.transform.DOMove(vectors[pos].transform .position, 1);
    }
    void Update()
    {
       
     
    
        if (GameStart)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                ButtonOnclick.Instance.panduantimu();


            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {


            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                left();
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                right();
            }
        }
    
    }

    public  void right()
    {
        pos++;
        if (pos >= 0 && pos <= 2)
        {
            SetPos();
        }
        else
        {
            pos--;
        }
    }

    public void left()
    {
        pos--;
        if (pos >= 0 && pos <= 2)
        {
            SetPos();
        }
        else
        {
            pos++;
        }
    }
}
