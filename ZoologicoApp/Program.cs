using System;
using System.Collections.Generic;

//clase que representa un animal
public class Animal
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Especie { get; set; }

    public Animal(string nombre, int edad, string especie)
    {
        Nombre = nombre;
        Edad = edad;
        Especie = especie;
    }
   //metodo virtual
    public virtual void EmitirSonido()
    {
        Console.WriteLine($"{Nombre} hace un sonido genérico.");
    }
}

//mamifero que hereda la clase animal
public class Mamifero : Animal
{
    public Mamifero(string nombre, int edad, string especie)
        : base(nombre, edad, especie) { }

    public override void EmitirSonido()
    {
        Console.WriteLine($"{Nombre} (mamífero) dice: ¡Grrrr!");
    }

    public void Amamantar()
    {
        Console.WriteLine($"{Nombre} está amamantando a sus crías.");
    }
}

//ave que hereda de la clase animal
public class Ave : Animal
{
    public Ave(string nombre, int edad, string especie)
        : base(nombre, edad, especie) { }

    public override void EmitirSonido()
    {
        Console.WriteLine($"{Nombre} (ave) dice: ¡Pío pío!");
    }

    public void Volar()
    {
        Console.WriteLine($"{Nombre} está volando .");
    }
}

// reptil que hereda de la clase animal
public class Reptil : Animal
{
    public Reptil(string nombre, int edad, string especie)
        : base(nombre, edad, especie) { }

    public override void EmitirSonido()
    {
        Console.WriteLine($"{Nombre} (reptil) dice: ¡Ssshhh!");
    }

    public void TomarSol()
    {
        Console.WriteLine($"{Nombre} está en el sol.");
    }
}

//clase que contiene la lista de animales
public class Zoologico
{
    private List<Animal> animales = new List<Animal>();

    public void AgregarAnimal(Animal animal)
    {
        animales.Add(animal);
        Console.WriteLine($" Se agregó {animal.Nombre} al zoológico.");
    }
//muestra comportamiento de los animales
    public void MostrarAnimales()
    {
        Console.WriteLine("\n Animales en el zoológico:\n");

        foreach (var animal in animales)
        {
            Console.WriteLine($"Nombre: {animal.Nombre}, Especie: {animal.Especie}, Edad: {animal.Edad} años");
            animal.EmitirSonido();

            if (animal is Mamifero m)
                m.Amamantar();
            else if (animal is Ave a)
                a.Volar();
            else if (animal is Reptil r)
                r.TomarSol();

            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Zoologico zoo = new Zoologico();

        
        var leon = new Mamifero("León", 5, "Panthera leo");
        var aguila = new Ave("Águila", 3, "Haliaeetus leucocephalus");
        var iguana = new Reptil("Iguana", 2, "Iguana iguana");

       
        zoo.AgregarAnimal(leon);
        zoo.AgregarAnimal(aguila);
        zoo.AgregarAnimal(iguana);

      
        zoo.MostrarAnimales();
    }
}

