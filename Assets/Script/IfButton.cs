using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfButton : MonoBehaviour
{
    public GameObject LeftButton;
    public GameObject RightButton;
    public GameObject Map;
    public GameObject Years;
    private Year years;
    private string year;
    private float temp;
    private float StartPos;
    // Start is called before the first frame update
    void Start()
    {
        StartPos = Map.gameObject.transform.position.x;
        years = Years.GetComponent<Year>();
    }

    // Update is called once per frame
    void Update()
    {
        year = years.year[years.show];
        temp = Map.gameObject.transform.position.x;
        if (temp > StartPos)
        {
            LeftButton.SetActive(false);
            RightButton.SetActive(true);
        }
        else if (temp < StartPos)
        {
            LeftButton.SetActive(true);
            RightButton.SetActive(false);
        }

        if (temp <= StartPos && (year == "1935년" || year == "1940년"))
        {
            LeftButton.SetActive(true);
        }
        else if (temp == StartPos && year == "1919년")
        {
            LeftButton.SetActive(true);
            RightButton.SetActive(true);
        }
        else if (temp >= StartPos && (year == "1920년" || year == "1926년" || year == "1929년"))
        {
            LeftButton.SetActive(false);
            RightButton.SetActive(false);
        }
    }
}
