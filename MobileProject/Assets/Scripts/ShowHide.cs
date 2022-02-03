using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHide : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Exit;
    public GameObject CheckBox;

    public void Show()
    {
        Panel.gameObject.SetActive(true);
        Exit.gameObject.SetActive(true);
        CheckBox.gameObject.SetActive(true);
        if (PlayerPrefs.HasKey("Key"))
        {
            string value = PlayerPrefs.GetString("Key");
            bool v = bool.Parse(value);
            if (!v)
            {
                GameObject.Find("Toggle").GetComponent<UnityEngine.UI.Toggle>().isOn = false;
            }
        }
    }
    public void Hide()
    {
        Panel.gameObject.SetActive(false);
        Exit.gameObject.SetActive(false);
        CheckBox.gameObject.SetActive(false);
    }
}

