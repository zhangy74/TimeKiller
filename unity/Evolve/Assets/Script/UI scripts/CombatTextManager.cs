﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombatTextManager : MonoBehaviour {

    public RectTransform canvas;
    public GameObject textPrefab;
    public float speed;
    public Vector3 direction;
    public float fadeTime;
    private static CombatTextManager instance;
    
    public static CombatTextManager Instance {
        get {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<CombatTextManager>();
            }

            return instance;
        }
    }

    public void CreateText(Vector3 position, string text, Color color, bool crit)
    {
        GameObject combatText = Instantiate(textPrefab, position, Quaternion.identity);
        combatText.transform.SetParent(canvas);
        combatText.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        combatText.GetComponent<CombatText>().InitialialCombatText(speed, direction, fadeTime, crit);
        combatText.GetComponent<Text>().text = text;
        combatText.GetComponent<Text>().color = color;

    }
}
