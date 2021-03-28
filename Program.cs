using System;
using System.Reflection;
using Newtonsoft.Json;
using Assets.Items;
using System.IO;
using Logic;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System.Text.RegularExpressions;

namespace tprandomizer_poc_main
{ 
    class Program
    {
        static void Main(string[] args)
        {
            CheckFunctions Checks = new CheckFunctions();
            RoomFunctions Rooms = new RoomFunctions();
            Type myCheckType=typeof(Check);
            Checks.InitializeChecks();
            Rooms.InitializeRooms();
            foreach (string file in System.IO.Directory.GetFiles("./Checks/", "*",SearchOption.AllDirectories))
            {
                string contents = File.ReadAllText(file);
                PropertyInfo myPropInfo = myCheckType.GetProperty(file);
                Checks.CheckDict.Add(file,JsonConvert.DeserializeObject<Check>(contents));
                Console.WriteLine("Check File Loaded " + file);
            }

            Type myRoomType=typeof(Room);
            foreach (string file in System.IO.Directory.GetFiles("./Assets/Rooms/", "*",SearchOption.AllDirectories))
            {
                string contents = File.ReadAllText(file);
                PropertyInfo myPropInfo = myRoomType.GetProperty(file);
                Rooms.RoomDict.Add(file,JsonConvert.DeserializeObject<Room>(contents));
                Console.WriteLine("Room File Loaded " + file);
            }
            // To get the values alone, use the Values property.
         /*   Dictionary<string, Room>.ValueCollection valueColl = Rooms.RoomDict.Values;

            // The elements of the ValueCollection are strongly typed
            // with the type that was specified for dictionary values.
            Console.WriteLine();
            foreach( Room s in valueColl )
            {
                Console.WriteLine("Value = {0}", s);
            }*/
                
                //myJsonObject.requirements = Regex.Replace(myJsonObject.requirements, @"\bLogic\b", "Logic.LogicFunctions");
                //var options = ScriptOptions.Default.AddReferences(typeof(LogicFunctions).Assembly).AddImports("Assets.Items");
                //var now = CSharpScript.EvaluateAsync(myJsonObject.requirements, options).Result;
        }
    }
}
