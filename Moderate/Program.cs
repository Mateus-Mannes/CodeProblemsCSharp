// See https://aka.ms/new-console-template for more information

using Moderate;

var result = Interception.Run(new Coordenada() { X = 3, Y =5 }, 
                               new Coordenada() { X = 5, Y =7 }, 

                                new Coordenada() { X = 3, Y = 4 }, 
                                new Coordenada() { X = 5, Y = 8 } );

Console.WriteLine($"{result.X}, {result.Y}");