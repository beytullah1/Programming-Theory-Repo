using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shapes : MonoBehaviour
{
    private Camera mainCam;
    private const int MaxLength = 8;
    private string colorName;

    private string _name = "Shape";
    public string Name
    {
        get { return _name; }
        set
        {
            _name = value != null && value.Length > MaxLength
                ? value.Substring(0, MaxLength)
                : value;
        }
    }
    private void Start()
    {
        mainCam = Camera.main;
        SetName();
    }
    // Update is called once per frame
    void Update()
    {
        MouseClickOnWorld();
    }
    private void MouseClickOnWorld()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, float.MaxValue))
            {
                if (hit.transform.name == Name)
                {
                    colorName = hit.transform.GetComponent<MeshRenderer>().material.name;                 
                    DisplayText();
                }
            }
        }
    }
    private void DisplayText()
    {
        GameManager.Instance.NameText.text = "Object name is: " + Name + " Color is: " + colorName;
        Debug.Log(Name);
        Debug.Log(colorName);
    }
    protected abstract void SetName();

}
