using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    static int PinCollisionCount = 0;

    private TextMeshPro scoreText;

    // Start is called before the first frame update
    void Start()
    {
        GameObject PinCountGameObject = GameObject.Find("Score");

        scoreText = PinCountGameObject.GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score:" + PinCollisionCount;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Pin")
        {
            PinCollisionCount++;
        }

        if (collision.gameObject.tag == "Wall")
        {
            PinCollisionCount = 0;
        }

    }
}