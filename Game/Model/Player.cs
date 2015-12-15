﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Model.DataStructures;
using System.Collections.ObjectModel;

namespace Game.Model
{
    abstract class Player
    {

        private int _money = 0;
        public int Money
        {
            get
            {
                return _money;
            }
            set
            {
                if (value < 0) throw new ArgumentException("Cannot set negative money");
                _money = value;
            }
        }

        /// <summary>
        /// Used to make sure the piece a player is attempting to move is actually
        /// a piece they are allowed to move. For a police player, ensures the piece
        /// is a police piece. For a thief, makes sure it is the piece belonging to that player
        /// </summary>
        /// <param name="p">The piece to be moved</param>
        /// <returns>True if player is allowed to move p</returns>
        public abstract bool allowedToMovePiece(Piece p);

        public abstract List<Piece> getControlledPieces();

        public abstract bool anyInPlay();
    }


}
