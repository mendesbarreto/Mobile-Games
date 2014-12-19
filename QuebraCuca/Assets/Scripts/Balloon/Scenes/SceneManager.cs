﻿using UnityEngine;
using System.Collections;
namespace Com.Globo.Sitio.MobileGames.Balloon
{
    public class SceneManager : MonoBehaviour
    {
        public static string START_SCENE = "Balloon";
        public static string CHOOSE_MODE_SCENE = "BalloonChooseModeScene";
        public static string GAME_SCENE = "BalloonGameScene";
        public static string CREDITS_SCENE = "BalloonCreditsScene";
        public static string RESULT_SCENE = "BalloonResultScene";

        // Use this for initialization
        void Start()
        {

        }

        public void GotoGameScene()
        {
            Application.LoadLevel(GAME_SCENE);
        }

        public void GotoStartScene()
        {
            Application.LoadLevel(START_SCENE);
        }

        public void GotoCreditsScene()
        {
            Application.LoadLevel(CREDITS_SCENE);
        }

        public void GotoChooseModeScene()
        {
            Application.LoadLevel(CHOOSE_MODE_SCENE);
        }

        public void GotoResultScene()
        {
            Application.LoadLevel(RESULT_SCENE);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
