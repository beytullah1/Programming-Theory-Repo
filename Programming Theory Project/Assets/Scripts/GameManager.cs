using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] TextMeshProUGUI nameText;
    public TextMeshProUGUI NameText { get => nameText; set => nameText = value; }
    private void Awake()
    {
        Instance = this;
    }
}
