﻿using RubiksApp.RubiksAlgorithmToolset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMove
{
    public class YE //: ICubeSolvingAlgorithm
    {
        public string AlgorithmName
        {
            get { return "YE"; }
        }

        public string Author
        {
            get { return "Walter Praça"; }
        }

        public string Description
        {
            get { return "Fourteen Rotations"; }
        }

        public void Solve(RubiksCore.RubiksCube cube)
        {
            cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
            cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
            cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
            cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
            cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
            cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
            cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
            cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
            cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
            cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
            cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
            cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
            cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
            cube.TurnDown(RubiksCore.TurningDirection.NineoClock);

        }
    }
}
