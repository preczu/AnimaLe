using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    private Text scoreText;
    private Text mistakeText;

    private int score = 0;
    private int mistakes = 0;

    // Start is called before the first frame update
    void Awake()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<Text> ();
        mistakeText = GameObject.Find("MistakeText").GetComponent<Text> ();
        scoreText.text = "0";
        mistakeText.text = "0";
    }

    // Update is called once per frame
    void OnTriggerEnter( Collider target)
    {
        if (target.tag == "Cube") {
            //transform.position = new Vector3(0, 100, 0);
            ////gameObject.S etActive(false);        //coroutine will not start
            target.gameObject.SetActive(false);
            mistakes++;
            mistakeText.text = mistakes.ToString();
            //StartCoroutine(RestartGame());
                if(mistakes >= 3)
                {
                transform.position = new Vector3(0, 100, 0);
                StartCoroutine(RestartGame());
                }
		}
        if (target.tag == "Bananas") {
            target.gameObject.SetActive (false);
            score++;
            scoreText.text = score.ToString();
		}
    }

    IEnumerator RestartGame() {
     yield return new WaitForSeconds(2f);
     SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
