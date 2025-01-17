﻿using GameHub.Games.BatalhaNaval.tabuleiro;
using GameHub.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Games.BatalhaNaval.pecas
{
    class DefinicaoDePosicoesX
    {
        public static void PosicionandoNaviosX()
        {
            Console.WriteLine("Para iniciarmos a partida, antes é preciso definir onde seus navios serão posicionados");
            Console.WriteLine("Seus navios são: 1 Rebocador, 1 Contratorpedeiro, 1 Cruzador, 1 PortaAvioes\n");

            Console.WriteLine("Começaremos por " + Jogadores.Jogador1.Name);
            Console.WriteLine();
            Console.WriteLine("Posicione o REBOCADOR\n");

            Console.WriteLine("Utilizando números de 0 a 7, e os separando por virgula (ex.: 1,2), informe:\n");


            //Rebocador
            Rebocador.PosicionandoRebocadorX();

            //Contratorpedeiro
            Contratorpedeiro.PosicionandoContratorpedeiro();

            //Cruzador
            Cruzador.PosicionandoCruzador();

            //PortaAvioes
            PortaAvioes.PosicionandoPortaAvioes();
        }

        public static void ExibirBaseX()
        {
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine($"Esta é a base de {Jogadores.Jogador1.Name}");
            for (int i = 0; i < 8; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < 8; j++)
                {
                    if (i == Rebocador.LinhaInicialRebocador && j == Rebocador.ColunaInicialRebocador || i == Rebocador.LinhaFinalRebocador && j == Rebocador.ColunaFinalRebocador)
                    {
                        Console.Write("R  ");
                    }
                    else if (i == Contratorpedeiro.LinhaInicialContratorpedeiro && j == Contratorpedeiro.ColunaInicialContratorpedeiro || i == Contratorpedeiro.LinhaMeioContratorpedeiro && j == Contratorpedeiro.ColunaMeioContratorpedeiro || i == Contratorpedeiro.LinhaFinalContratorpedeiro && j == Contratorpedeiro.ColunaFinalContratorpedeiro)
                    {
                        Console.Write("Ct ");
                    }
                    else if (i == Cruzador.LinhaInicialCruzador && j == Cruzador.ColunaInicialCruzador || i == Cruzador.LinhaMeio1Cruzador && j == Cruzador.ColunaMeio1Cruzador || i == Cruzador.LinhaMeio2Cruzador && j == Cruzador.ColunaMeio2Cruzador || i == Cruzador.LinhaFinalCruzador && j == Cruzador.ColunaFinalCruzador)
                    {
                        Console.Write("Cr ");
                    }
                    else if (i == PortaAvioes.LinhaInicialPortaAvioes && j == PortaAvioes.ColunaInicialPortaAvioes || i == PortaAvioes.LinhaMeio1PortaAvioes && j == PortaAvioes.ColunaMeio1PortaAvioes || i == PortaAvioes.LinhaMeio2PortaAvioes && j == PortaAvioes.ColunaMeio2PortaAvioes || i == PortaAvioes.LinhaMeio3PortaAvioes && j == PortaAvioes.ColunaMeio3PortaAvioes || i == PortaAvioes.LinhaFinalPortaAvioes && j == PortaAvioes.ColunaFinalPortaAvioes)
                    {
                        Console.Write("Pa ");
                    }
                    else
                    {
                        Console.Write("-  ");
                    }
                }
                Console.WriteLine();
            }


        }
    }
}

