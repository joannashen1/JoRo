using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedBar : MonoBehaviour
{

    //public GameObject birb = GameObject.FindGameObjectWithTag("Player");
    // Start is called before the first frame update

    //public ThirdPersonCharacter script;
    int seedCount = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        seedCount++;
        GetComponent<RectTransform>().sizeDelta = new Vector2(seedCount, 10);
    }
}
