// See https://aka.ms/new-console-template for more information

using Moderate;

Interception.Run(new Reta() 
    { Inicial = new Coordenada() { X = 1, Y =1 }, 
    Final = new Coordenada() { X = 4, Y =4 } }, 

new Reta() { 
    Inicial = new Coordenada() { X = 1, Y = 4 }, 
    Final = new Coordenada() { X = 4, Y = 1 } });
