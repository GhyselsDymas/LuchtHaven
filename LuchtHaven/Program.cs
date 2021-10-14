// See https://aka.ms/new-console-template for more information

using LuchtHaven.Entities;

Baan baan = new Baan();

string omschrijving = baan.GeefOmschrijving();

Console.WriteLine(omschrijving);