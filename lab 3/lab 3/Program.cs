using System;
using System.Collections.Generic;

// Базовий клас Живий організм
public class LivingOrganism
{
    public int Energy { get; set; }
    public int Age { get; set; }
    public int Size { get; set; }

    public LivingOrganism(int energy, int age, int size)
    {
        Energy = energy;
        Age = age;
        Size = size;
    }
}

// Клас Тварина
public class Animal : LivingOrganism
{
    public string Species { get; set; }

    public Animal(int energy, int age, int size, string species) : base(energy, age, size)
    {
        Species = species;
    }
}

// Клас Рослина
public class Plant : LivingOrganism
{
    public string Type { get; set; }

    public Plant(int energy, int age, int size, string type) : base(energy, age, size)
    {
        Type = type;
    }
}

// Клас Мікроорганізм
public class Microorganism : LivingOrganism
{
    public string MicrobeType { get; set; }

    public Microorganism(int energy, int age, int size, string microbeType) : base(energy, age, size)
    {
        MicrobeType = microbeType;
    }
}

// Клас Екосистема
public class Ecosystem
{
    public List<LivingOrganism> Organisms { get; set; }

    public Ecosystem()
    {
        Organisms = new List<LivingOrganism>();
    }

    public void AddOrganism(LivingOrganism organism)
    {
        Organisms.Add(organism);
    }

    public void SimulateEcosystem()
    {
        // Моделювання взаємодії організмів
        foreach (var organism in Organisms)
        {
            Console.WriteLine($"Organism of type {organism.GetType().Name} is part of the ecosystem.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Ecosystem ecosystem = new Ecosystem();
        Animal lion = new Animal(100, 5, 50, "Lion");
        Plant oak = new Plant(50, 10, 200, "Oak");
        Microorganism bacteria = new Microorganism(10, 1, 1, "Bacteria");
        ecosystem.AddOrganism(lion);
        ecosystem.AddOrganism(oak);
        ecosystem.AddOrganism(bacteria);
        ecosystem.SimulateEcosystem();
    }
}
