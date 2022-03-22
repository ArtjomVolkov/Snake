﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Snakee
{
    class Menu2 : Paper
    {

        public void Start()
        {
            Title = "Snake Game!";
            RunMainMenu();
        }
        private void RunMainMenu()
        {
            string prompt = @"
███████╗███╗   ██╗ █████╗ ██╗  ██╗███████╗     ██████╗  █████╗ ███╗   ███╗███████╗
██╔════╝████╗  ██║██╔══██╗██║ ██╔╝██╔════╝    ██╔════╝ ██╔══██╗████╗ ████║██╔════╝
███████╗██╔██╗ ██║███████║█████╔╝ █████╗      ██║  ███╗███████║██╔████╔██║█████╗  
╚════██║██║╚██╗██║██╔══██║██╔═██╗ ██╔══╝      ██║   ██║██╔══██║██║╚██╔╝██║██╔══╝  
███████║██║ ╚████║██║  ██║██║  ██╗███████╗    ╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗
╚══════╝╚═╝  ╚═══╝╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝     ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝
Welcome to the Snake Game!";
            string[] options = { "Play", "About", "Exit" ,"Mono Lisa","Very Good Boy", "Rocks/Paper/Scissors" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    ;
                    RunFirstChoice();
                    break;
                case 1:
                    DisplayAboutInfo();
                    break;
                case 2:
                    ExitGame();
                    break;
                case 3:
                    MonoLisa();
                    break;
                case 4:
                    VeryGoodBoy();
                    break;
                case 5:
                    Rock();
                    break;
                default:
                    break;
            }
        }

        private void ExitGame()
        {
            WriteLine("\nPress any key to exit....");
            ReadKey(true);
            Environment.Exit(0);
        }

        private void DisplayAboutInfo()
        {
            Clear();
            WriteLine("Snake Game for Artjom Volkov TARpv21!");
            WriteLine("Press any key to return to the menu.");
            ReadKey(true);
            RunMainMenu();
        }
        private void MonoLisa()
        {
            Clear();
            string proms = (@"
          ____  
        o8%8888,    
      o88%8888888.  
     8'-    -:8888b   
    8'         8888  
   d8.-=. ,==-.:888b  
   >8 `~` :`~' d8888   
   88         ,88888   
   88b. `-~  ':88888  
   888b ~==~ .:88888 
   88888o--:':::8888      
   `88888| :::' 8888b  
   8888^^'       8888b  
  d888           ,%888b.   
 d88%            %%%8--'-.  
/88:.__ ,       _%-' ---  -  
    '''::===..-'   =  --.");
            WriteLine(proms);
            WriteLine("Press any key to return to the menu.");
            ReadKey(true);
            RunMainMenu();
        }
        private void VeryGoodBoy()
        {
            Clear();
            string prom = (@"
                     $$$$$$$$$$$$$$$$$$$$$$
                  $$$$$$$$$$$$$$$$$$$$$$$$$$$$
                $$$$$$$$$$$$$$$$$$$$$$$$$$$ $$$$$
               $$$$$$$$$$$$$$  $$$$$$$  $$   $ $$$$
             $$$$$$$$$$$   $$   $$$  $$  $   $  $$$$
            $$$$%$$$  $ $   $$   $$$  $  $   $$ $ $$
           $$$$%%$$$   $ $   $$   $$$  $  $$  $ $ $$$
          $$$$$%%$$$$  $ $    $    $$  $  $$$ $ $$ $$$$
         $$$$$%%%$$$$$ $$$$   $  $ $$   $ $$$$$ $$ $$$$$
        $$$$$$%%%$$$$$$$$$$$  $$ $ $$$$ $ $$$$$$$$$$$$$$$$
       $$$$$$%%%$$$$$$$$$$$$$$$ $$$$$$ $$$$$$$$$$$$$$$$$$$
      $$$$$$%%%$$%%%%%%$$$$$$$$$$$$$$$ $$$$$$$$$   $$$$$$$$
      $$$$$$%%$$%%%%%%%%%$$$$$$$$$$$$$ $$$$$$$     $$$$%$$$
      $$$$$$%$$%%%%%%%%%%%$$$$$$$$$$$$$$$$$        $$$$%%$$$
      $$$$$$$$%%%%%%%%%%%%%$$$$$$$$$$$             $$$$%%$$$
     $$$$$$$%%%            $$$$$$$$                 $$$%%$$$
     $$$$$$%%%                                      $$$%%$$
     $$$$$$%%%                                      $$$%%$$
     $$$$$%%%%                                    % $$$%%$$
     $$$$$%%%%                                    %  $$%%$$
     $$$$$%%%%                                    %  $$%%$$
     $$$$$%%%%                                   %%  $$$%$$
     $$$$$%%%%                                  %%%  $$$%$$
     $$$$$%%%%                                   %%  $$$%$$
     $$$$$%%%%                                   %%  $$$%$$
     $$$$$%%%%                                   %%  $$$%$$
      $$$$%%%%                             $$$$  %% $$$$%$$
     $ $$$%%%% $$$$$$$$$                $$$$$$$$$%% $$$$$$$
    $$$ $$%%%  $$$$$$$$$$              $$$$$$$$$$$%% $$$$$$
    $$$$  %%%          $$$           $$$$       $$%% $$$$$$
    $$$$$$%%%    $$$$$ $$$$         $$$$$$$$$$   $%% $$$$$$
     $$$$ %%%  $$$     $$$$$       $$$$$$    $$$  %%% $$$$$
     $$$$     $$$$$$$$$ $$$$      $$$$$$$$$$$$$$   %  $$$$$
     $$$$     $$$  $ $$  $$$$    $$$$$$  $ $  $$      $$$$
     $$$$      $   $$$ %%%$$$         %% $$$          $$$$
     $$$$             %%%% $$         %%%%%%  %%%     $$$$
      $$$$      %%% %%%%%   $           %%%%%%%       $$$$
      $$$$        %%%%%    $$             %%%         $$ $
      $$ $          %%     $                          $ $$
      $ $$                 $                          $  $
      $ $$  $             %$                         $$  $
      $  $  $            %%$                          $$$$
       $$$  $$         $ %%%                       $ $ $$
        $$  $$        $ %%%%          $ $$$       $$ $
         $ $$$     $$  %%%%        $$$  $$$     $$$ $
         $ $$$    $$  %%%$$$     $$$$    $$$$  $$$$ $
         $$$$$$$$$$   $$$$$$$$$$$$$$      $$$$$$$$$ $
          $$$$$$$   $$$$$$$$$$$$$$         $$$$$$$$ $
          $$$$$$ %%$$$$$$$$$$$$$$      $$$$$$$$$$$$$$
          $$$ $$  %$$$$$$$$$$      $$$$$$$$$    $$$$
           $$  $   $$$$     $$$$$$$$    $$      $$$
           $$  $   %$$$$               $$      $$$$
            $  $   %%%%$$$ $$$$$$$$$$$$$       $$$
            $$ $$   %%%%             $$       $$$$
            $$ $$    %%$$$$ $$$$$$$$$$        $$$
             $  $    $$$$$%%%%%%%%%%         $$$$
             $$ $$  $$$$$%%%                 $$$
              $  $ $$$$ %%%%%%%%%%%%%%      $$$
              $$  $$$$  %%%%%%%%%%%%%       $$$
     $$$       $ $$$$   $%%%%              $$$
   $$   $$      $$$$$  $$$$               $$$
  $  $$  $$   $$$$$$   $$$                $$$
 $ $$$$  $$  $$$$$$   $$$$               $$$
$  $$$  $$$ $$$$$$ $$$$$$$              $$$
$      $$$$$$$$$$   $$$$$$             $$$
$  $$   $$$$$$$$     $$$$$$$$$$$$$$$  $$$
$$$$$   $$$$$$$       $$$$$$$$$$$$$$$$$$
$$$$$$   $$$$$                  $$$$$$
 $$$$$   $$$$
 $$$$$$  $$$
  $$$$$  $$$
   $$$$$$$$
    $$$$$$
");
            WriteLine(prom);
            WriteLine("Press any key to return to the menu.");
            ReadKey(true);
            RunMainMenu();
        }
        private void Rock()
        {
            Clear();
            Paper rocks = new Paper();
            rocks.RockPaper();
        }
        private void RunFirstChoice()
        {
            Clear();
        }
    }
}