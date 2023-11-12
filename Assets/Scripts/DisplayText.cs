using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class DisplayText : MonoBehaviour
{
    public string currentName;
    public GameObject inputField;
    public Text bestScore;
    public Text bestScoreName;
    

    private void Start()
    {
        bestScore.text = PlayerPrefs.GetInt("SavedHighScore").ToString();
        bestScoreName.text = PlayerPrefs.GetString("SavedHighScoreName");
    }
    public void StoreName() 
    {
        currentName = inputField.GetComponent<Text>().text;
        PlayerPrefs.SetString("SavedName", currentName);
    }
}
