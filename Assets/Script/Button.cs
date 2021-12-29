using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Button : MonoBehaviour
{
    public GameObject LeftButton;
    public GameObject RightButton;
    public GameObject Map;
    public GameObject HanSungAnd31;
    public GameObject ImageCloseButton;
    public GameObject[] Image;
    private Number number;
    private Year year;
    private Vector3 StartPos;
    private bool hansubg_31;
    private void Start()
    {
        StartPos = Map.gameObject.transform.position;
        hansubg_31 = false;
        year = GameObject.Find("Year").GetComponent<Year>();
        HanSungAnd31.SetActive(hansubg_31);
        ImageClose();
    }
    public void ClickYearUp()
    {
        Debug.Log("Click Year Up Button");
        LeftButton.SetActive(false);
        RightButton.SetActive(false);
        Map.transform.position = StartPos;
        year.show = (year.show + 1) % year.number.Length;
    }
    public void ClickYearDown()
    {
        Debug.Log("Click Year Down Button");
        LeftButton.SetActive(false);
        RightButton.SetActive(false);
        Map.transform.position = StartPos;
        if (year.show <= 0)
            year.show = year.number.Length - 1;
        else
            year.show--;
    }
    public void Click31AndHanSung()
    {
        hansubg_31 = !hansubg_31;
        HanSungAnd31.SetActive(hansubg_31);
    }
    public void ClickLeftMove()
    {
        Map.transform.position += new Vector3(1000, 0, 0);
        LeftButton.SetActive(false);
        RightButton.SetActive(false);
    }
    public void ClickRightMove()
    {
        Map.transform.position -= new Vector3(1000, 0, 0);
        LeftButton.SetActive(false);
        RightButton.SetActive(false);
    }
    public void ClickShow()
    {
        string ButtonName = EventSystem.current.currentSelectedGameObject.name;
        GameObject button = GameObject.Find(ButtonName);
        number = button.GetComponent<Number>();
        Image[number.index].SetActive(true);
        ImageCloseButton.SetActive(true);
    }
    public void ImageClose()
    {
        ImageCloseButton.SetActive(false);
        for (int i = 0; i < Image.Length; i++)
        {
            Image[i].SetActive(false);
        }
    }
}
