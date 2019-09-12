using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoBack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(delegate
        {
          
            if (gameObject.name=="Goback")
            {
                GamesManager.Instance.Qingwa.transform.position = GamesManager.Instance.qingwa;
                GamesManager.Instance.GameStart = false;

                Destroy(gameObject.transform.parent.transform . gameObject);
            }
            if (gameObject.name == "GameOver")
            {
                Application.Quit();
            }
            if (gameObject.name == "StartGame")
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
            }
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
