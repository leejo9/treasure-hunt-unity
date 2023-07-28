using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instructions : MonoBehaviour
{
    public Button start_button;
    // Start is called before the first frame update
    void Start()
    {
        Button start = start_button.GetComponent<Button>();
    }

    // Update is called once per frame
    public void game_start()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Start");
    }
}