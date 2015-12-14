﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Model.DataStructures;

namespace Game.Controller
{
    class GameController
    {
        public BoardController Game { get; set; }
        public bool AIPolice { get; private set; }
        public int HumanPlayers { get; set; }

        private bool isAITurn() {
            if (Game.CurrentPlayerIndex == Game.Players.Count - 1 && AIPolice) return true;
            if (Game.CurrentPlayerIndex > HumanPlayers - 1) return true;
            return false;
        }

        public GameController(int nrOfHumans, int nrOfAI, bool AIPolice)
        {
            HumanPlayers = nrOfHumans;
            this.AIPolice = AIPolice;
            Game = new BoardController(nrOfHumans + nrOfAI);
        }
    }
}