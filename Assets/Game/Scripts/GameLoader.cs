using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class GameLoader : MonoBehaviour
    {
        public Game game;

        void Awake()
        {
            game = new Game();
            game.Initialize();
        }
    }
}
