using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Birb_Script : MonoBehaviour
{

    public GameObject seedBar;
    public Rect seedRect;
    // Start is called before the first frame update


    public Text countText;
    public Text winText;
    private static int seed_count;
    private bool youWin;
    private float yPos;
    private AudioSource seedPop;

    void Start()
    {
        //seedBar = GameObject.FindGameObjectWithTag("UI_SeedBar");

        seedPop = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        seedBar.GetComponent<RectTransform>().sizeDelta = new Vector2(seed_count*10, 10);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Seed"))
        {
            other.gameObject.SetActive(false);
            seedPop.Play();
            seed_count = seed_count + 1;
            //count = 10;
            SetCountText();
        }

        if (other.gameObject.CompareTag("EndBox") && seed_count >= 15)

        {
            Debug.Log("show win text");
            //winText.text = "You did it! You're flying!";
            youWin = true;
            GameObject birbchild = GameObject.FindGameObjectWithTag("birb");


            if (other.gameObject.CompareTag("EndBox") && seed_count < 15)
            {
                Debug.Log("collided with box");
                SceneManager.LoadScene(2);

            }

            if (other.gameObject.CompareTag("Respawn"))
            {
                Debug.Log("collided with restart box");
                SceneManager.LoadScene(1);
            }
        }
    }

    void SetCountText()
    {
        countText.text = "Seeds: " + seed_count.ToString();
        //countText.text = "Seeds: " + 10;
    }
}
