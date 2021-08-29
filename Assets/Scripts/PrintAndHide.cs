using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    // Start is called before the first frame update
    int i = 3;
    int genNumber;
    public Renderer rend;
    void Start()
    {
       genNumber = Random.Range(200, 250);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + ":" + ++i);
        if (gameObject.tag == "Red" && i == 100){
        gameObject.SetActive(false);
        }
        if (gameObject.tag == "Blue" && i == genNumber){
        gameObject.SetActive(false);
        }
    }
}
