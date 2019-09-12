using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(delegate 
        {
            GamesManager.Instance.SetQuestion(int.Parse(gameObject.name));
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
