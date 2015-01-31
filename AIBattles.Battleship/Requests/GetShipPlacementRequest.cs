﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIBattles.Battleship.Requests
{
    public class GetShipPlacementRequest : BattleshipRequest
    {
        public GetShipPlacementRequest(string name)
            : base(name, "Ship Placement")
        {

        }
    }
}
