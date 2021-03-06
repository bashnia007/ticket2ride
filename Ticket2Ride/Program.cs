﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Ticket2Ride.Enums;

namespace Ticket2Ride
{
    class Program
    {
        static void Main(string[] args)
        {
             TestGame();
            // CreateTestDb();
        }

        static void TestGame()
        {
            var players = CreateTestUsers();
            var gameManager = new GameManager();
            gameManager.Players = players;

            gameManager.Init();

            gameManager.GameProcess();
        }

        static List<Player> CreateTestUsers()
        {
            var players = new List<Player>();
            for (int i = 0; i < 2; i++)
            {
                var player = new ConsolePlayer();
                player.Color = (PlayerColor) i;
                players.Add(player);
            }
            return players;
        }

        static void CreateTestDb()
        {
            var connections = DbManager.GetConnections();
            var cities = DbManager.GetCities();
            var routes = DbManager.GetRoutes();
        }
    }
}
