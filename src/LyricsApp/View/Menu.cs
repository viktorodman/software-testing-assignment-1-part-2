using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using View.utils;
namespace View
{
    public class Menu
    {
        private IConsoleWrapper _consoleWrapper;
        private List<string> _menuItems = new List<string> { "Find Lyric", "Quit" };
        private string _promptArtistMessage = "Enter Artist Name";
        public Menu(IConsoleWrapper consoleWrapper)
        {
            _consoleWrapper = consoleWrapper;
        }

        public void ShowMainMenu()
        {
            string test = String.Join("\n", (_menuItems.Select((item, index) => $"{index + 1}: {item}")));

            _consoleWrapper.WriteLine(test);
        }

        public string GetUserInput()
        {
            return _consoleWrapper.ReadLine();
        }

        public IArtist PromptArtistName()
        {
            _consoleWrapper.WriteLine(_promptArtistMessage);
            _consoleWrapper.Write(">");
            string artistName = _consoleWrapper.ReadLine();
            return new Artist(artistName);
        }
    }
}