﻿using RubiksApp.RubiksAlgorithmToolset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMove
{
    public class TotalMoveUpRight //: ICubeSolvingAlgorithm
    {
        public string AlgorithmName
        {
            get { return "Total Move Up Right"; }
        }

        public string Author 
        {
            get { return "Walter Praça"; }
        }

        public string Description
        {
            get { return "A total move"; }
        }

        public void Solve(RubiksCore.RubiksCube cube)
        {
            cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock, 2);

        }
    }
}
