using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FlappyBird : MonoBehaviour
{
    int score;
    public float jumpForce = 5;
    public Text output;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            Vector3 oldVelocity = GetComponent<Rigidbody>().velocity;
            GetComponent<Rigidbody>().velocity = new Vector3(oldVelocity.x, jumpForce, 0);
        }
    }


    private void OnCollisionEnter(Collision pipePair){
        SceneManager.LoadScene(0);
    }

    private void onTriggerEnter(Collider pass){
        score++;
        print(score);
    }
}
