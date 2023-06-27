using Services.Input;
using UnityEngine;

namespace Infrastructure
{
    public class Game
    {
        public static IInputServices InputServices;

        public Game()
        {
            RegisterInputService();
        } 

        private static void RegisterInputService()
        {
            if (Application.isEditor)
                InputServices = new StandaloneInputService();
            else
                InputServices = new MobileInputService();
        }
    }
}