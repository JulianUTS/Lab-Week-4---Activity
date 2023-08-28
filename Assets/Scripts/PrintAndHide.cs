using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
public int i = 3; 
public Renderer rend;
private int randomInt;
    // Start is called before the first frame update
    void Start()
    {
randomInt = Random.Range(150,251);
Debug.Log(gameObject.name + ':' + i);
i++;

        
    }

    // Update is called once per frame
    void Update()
    {
Debug.Log(gameObject.name + ':'  + i);
if(gameObject.tag == "Red" && i == 100){
gameObject.SetActive(false);
}
if(gameObject.tag == "Blue" && i == randomInt){
Destroy(rend);
}
i++;

        
    }
}
