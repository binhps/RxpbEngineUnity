﻿using System;
using UnityEngine;
using System.Collections;



/// <summary>
/// 
/// </summary>
public class CapcomLogoSceneManager : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    public ScreenFader _fader;
    /// <summary>
    /// 
    /// </summary>
    private bool _endRequested = false;


    /// <summary>
    /// 
    /// </summary>
    void Start()
    {
        _fader.FadeIn();

        StartCoroutine(SceneCoroutine());
    }
    /// <summary>
    /// 
    /// </summary>
    void Update()
    {
        if (_endRequested)
        {
            if (_fader.FadeOutEnded)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene("SnakeHead");
            }
            return;
        }


        if (Input.anyKeyDown)
        {
            RequestEnd();
        }
    }


    /// <summary>
    /// 
    /// </summary>
    private void RequestEnd()
    {
        _endRequested = true;
        _fader.FadeOut();
    }
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    IEnumerator SceneCoroutine()
    {
        yield return new WaitForSeconds(7);

        RequestEnd();
        yield break;
    }
}
