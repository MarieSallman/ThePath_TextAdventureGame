﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SallmanFinal
{
    class Monster: Game
    {


        /*public void Attack()
        {

        }
        

        public void Attack(weapon)
        {

        }

        public void Attack(weapon, advantage)
        {

        }*/

        public void Flash()
        {
            string creature = @"
            ███████████████████████████████████
            ███████████████████████████████████
            ███████████████████████████████████
            █████████████▒▒▒▒▒▒▒▒▒█████████████
            █████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█████████
            ███████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒███████
            ██████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██████
            █████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█████
            █████▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒█████
            ████▒▒▒▒███▒▒▒▒▒▒▒▒▒▒▒▒▒███▒▒▒▒████
            ███▒▒▒▒██████▒▒▒▒▒▒▒▒▒██████▒▒▒▒███
            ███▒▒▒███▐▀███▒▒▒▒▒▒▒███▀▌███▒▒▒███
            ███▒▒▒██▄▐▌▄███▒▒▒▒▒███▄▐▌▄██▒▒▒███
            ███▒▒▒▒██▌███▒▒▒█▒█▒▒▒███▐██▒▒▒▒███
            ██▒▒▒▒▒▒███▒▒▒▒██▒██▒▒▒▒███▒▒▒▒▒▒██
            █▒▒▒▒▒▒▒▒█▒▒▒▒██▒▒▒██▒▒▒▒█▒▒▒▒▒▒▒▒█
            █▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒█
            █▒▒▒▒█▒▒█▒▒▒▒██▒▒▒▒▒██▒▒▒▒█▒▒█▒▒▒▒█
            ██▒▒▒█▒▒█▒▒▒▒█▒██▒██▒█▒▒▒▒█▒▒█▒▒▒██
            ███▒█▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒█▒███
            █████▒▒█▒▒▒▐███████████▌▒▒▒█▒▒█████
            ███████▒▒▒▐█▀██▀███▀██▀█▌▒▒▒███████
            ███████▒▒▒▒█▐██▐███▌██▌█▒▒▒▒███████
            ███████▒▒▒▒▒▐▒▒▐▒▒▒▌▒▒▌▒▒▒▒▒███████
            ████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████████
            ████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████████
            █████████▒▒█▒█▒▒▒█▒▒▒█▒█▒▒█████████
            █████████▒██▒█▒▒▒█▒▒▒█▒██▒█████████
            ██████████████▒▒███▒▒██████████████
            ██████████████▒█████▒██████████████
            ███████████████████████████████████
            ███████████████████████████████████
                    ";
            for (int i = 0; i < 50; i++){
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(creature);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(creature);
                Console.Clear();
            }

            Console.Clear();
            return;
            
            
        }



    }
}
