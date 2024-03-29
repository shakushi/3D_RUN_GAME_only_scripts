﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/* Dependencies */
[RequireComponent(typeof(UIManager))]

public class GameLoopManager : MonoBehaviour
{
    [SerializeField]
    public PlayerCtlr playerCtlr;
    [SerializeField]
    public ObstacleFactory factory;

    private UIManager uiManager;
    private bool inGame = false;
    private float startTime;

    private void Awake()
    {
        uiManager = GetComponent<UIManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        factory.Activate = false;
    }

    private void Update()
    {
        if (inGame)
        {
            uiManager.SetTimeText(Time.time - startTime);
        }
    }

    public void GameStart()
    {
        inGame = true;
        startTime = Time.time;
        playerCtlr.IPlayerGameStart();
        uiManager.DeleteInitialUI();
        factory.Activate = true;
    }

    public void GameClear()
    {
        inGame = false;
        playerCtlr.IPlayerGameClear();
        uiManager.EnableClearUI();
        factory.Activate = false;
    }

    public void GameRestart()
    {
        SceneManager.LoadScene("Main");
    }
}
