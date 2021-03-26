using System;
using System.Collections.Generic;
using Assets.Items;
using Randomizer;

namespace Randomizer
{
    struct Room
    {
        string name { get; set;} //Name we give the room to identify it (it can be a series of rooms that don't have requirements between each other to make the algorithm go faster)
        List<Room> neighbours { get; set;} //Refers to the rooms of the same stage that can be accesed from this room
        List<List<bool>> neighbourRequirments { get; set;} //List of list of requirements to enter each neighbouring room
        bool isStartingRoom { get; set;} //Defines if it is the stage you start the game in
        List<Check> checks { get; set;} //Checks contained inside the room
        bool visited { get; set;}
        string region { get; set;}
    }
}