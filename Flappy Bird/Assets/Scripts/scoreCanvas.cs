using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreCanvas : MonoBehaviour
{
    public Text scoreText;
    public FlappyBird flappyBird;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + flappyBird.score.ToString();
    }
}
