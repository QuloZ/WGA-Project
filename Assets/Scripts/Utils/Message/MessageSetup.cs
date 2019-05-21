﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageSetup : MonoBehaviour
{
    private Text txtPanel;
    private MessageText txtObj;
    int i;

    //  private Text txt;
    void Start()
    {
        txtPanel = gameObject.GetComponent<Text>();
        txtObj = gameObject.GetComponent<MessageText>();
        txtObj.Init();
        txtPanel.text = txtObj.GetText(0);
        i = 0;
    }

    public void onClick()
    {
        i++;
        try
        {
            txtPanel.text = txtObj.GetText(i);
        }
        catch (System.Exception)
        {

            gameObject.transform.parent.gameObject.SetActive(false);
        }

    }



}