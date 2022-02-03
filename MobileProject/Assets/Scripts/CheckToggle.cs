using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckToggle : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Exit;
    public GameObject CheckBox;
    private void Start()
    {
        if (PlayerPrefs.HasKey("Key"))
        {
            string value = PlayerPrefs.GetString("Key");
            bool v = bool.Parse(value);
            Panel.gameObject.SetActive(v);
            Exit.gameObject.SetActive(v);
            CheckBox.gameObject.SetActive(v);
            if (!v)
            {
                GameObject.Find("Toggle").GetComponent<UnityEngine.UI.Toggle>().isOn = false;
            }
        }
    }
    public void Check()
    {
        if (GameObject.Find("Toggle").GetComponent<Toggle>().isOn)
        {
            PlayerPrefs.SetString("Key", true.ToString());
        }
        else
        {
            PlayerPrefs.SetString("Key", false.ToString());
        }
    }
}
