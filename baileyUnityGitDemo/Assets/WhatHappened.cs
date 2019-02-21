using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhatHappened : MonoBehaviour, IFocusable
{

        public void OnFocusEnter()
        {
            Debug.Log("I'm looking at a " + gameObject.name);
        }
        public void OnFocusExit()
        {
            Debug.Log("I'm no longer looking at a " + gameObject.name);
        }
 }

 

