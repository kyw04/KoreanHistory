using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Year : MonoBehaviour
{
    public GameObject[] number;
    public Text year_text;
    public string[] year = { "1919��", "1920��", "1926��", "1929��", "1935��", "1940��" };
    public int show = 0;
    // Start is called before the first frame update
    void Start()
    {
        Close();
    }

    // Update is called once per frame
    void Update()
    {
        if (show > year.Length - 1)
            show = 0;
        else if (show < 0)
            show = year.Length - 1;
        year_text.text = year[show];
        Close();
        number[show].SetActive(true);
    }

    public void Close()
    {
        int i;
        for (i = 0; i < number.Length; i++)
            number[i].SetActive(false);
    }
}
