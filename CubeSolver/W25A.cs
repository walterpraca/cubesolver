﻿using RubiksApp.RubiksAlgorithmToolset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMove
{
    public class W25A //: ICubeSolvingAlgorithm
    {
        public string AlgorithmName
        {
            get { return "W25A"; }
        }

        public string Author
        {
            get { return "Walter Praça"; }
        }

        public string Description
        {
            get { return "Six Rotations"; }
        }

        public void Solve(RubiksCore.RubiksCube cube)
        {
            cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
            cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
            cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
            cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
            cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
            cube.TurnRight(RubiksCore.TurningDirection.NineoClock);

        }
    }
}
