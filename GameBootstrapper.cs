using System;
using UnityEngine;

namespace Infrastructure
{
    public class GameBootstrapper : MonoBehaviour
    {
        private Game _game;

        public void Awake()
        {
            _game = new Game();

            DontDestroyOnLoad(this);
        }
    }
}