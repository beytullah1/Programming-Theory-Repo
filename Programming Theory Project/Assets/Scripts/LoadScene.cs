using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LoadScene : MonoBehaviour
{
    public static LoadScene Instance { get; private set; }
    [SerializeField] private TMP_InputField nameInputField;
    public TMP_InputField NameInputField { get { return nameInputField; } }
    private string playerName;
    public string PlayerName { get { return playerName; } set { playerName = value; } }
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void LoadMainScene()
    {
        playerName = nameInputField.text;
        SceneManager.LoadScene(1);
    }
}
