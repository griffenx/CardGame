﻿using CardGame.Characters;
using CardGame.Data;
using CardGame.Scenes;
using ConsoleUI;
using System;

namespace CardGame {
    public class Program : GameProgram {

        public static Player ActivePlayer;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            DB.CreateDatabase();
            DB.PopulateTables();
            WindowSize = new[] { 50, 63 };
            Initialize();
            StartingScene = new TitleScene();
            Console.Title = "Card Game";

            Run();
        }
    }
}
