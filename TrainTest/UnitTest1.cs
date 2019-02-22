using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circustrein;
using System.Collections.Generic;

namespace TrainTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanCreateNewWagons()
        {
            Train train = new Train();
            train.addWagon(new Wagon());
            Assert.AreEqual(train.Wagons.Count, 1);
        }
        [TestMethod]
        public void CanCreateWagonsForAnimal ()
        {
            Train train = new Train();
            train.coolAddAnimalToWagon(new Herbivore(AnimalSize.big));
            Assert.AreEqual(train.Wagons.Count, 1);
        }
        [TestMethod]
        public void CanAddGroupOfAnimals ()
        {
            Train train = new Train();
            List<Animal> animals = new List<Animal> { new Herbivore(AnimalSize.small), new Herbivore(AnimalSize.small), new Herbivore(AnimalSize.small) };
            train.addGroupOfAnimals(animals);
            Assert.AreEqual(train.Wagons[0].Animals.Count, 3);
        }
        [TestMethod]
        public void SeperatesBiggerMeatEaters ()
        {
            Train train = new Train();
            List<Animal> animals = new List<Animal> { new Carnivore(AnimalSize.big), new Herbivore(AnimalSize.small) };
            train.addGroupOfAnimals(animals);
            Assert.AreEqual(train.Wagons.Count, 2);

        }
        [TestMethod]
        public void AddsCorrectAmountOfAnimals ()
        {
            Train train = new Train();
            List<Animal> animals = new List<Animal> { new Herbivore(AnimalSize.big), new Herbivore(AnimalSize.big),new Herbivore(AnimalSize.big) };
            train.addGroupOfAnimals(animals);
            Assert.AreEqual(train.Wagons.Count, 2);
        }
        [TestMethod]
        public void OnlyCreatesUsedWagons ()
        {
            Train train = new Train();
            List<Animal> animals = new List<Animal>();
            train.addGroupOfAnimals(animals);
            Assert.AreEqual(train.Wagons.Count, 0);
        }
        [TestMethod]
        public void CanAddAnimalSeperately ()
        {
            Train train = new Train();
            train.addGroupOfAnimals(new List<Animal> {new Herbivore(AnimalSize.small), new Herbivore(AnimalSize.small), new Herbivore(AnimalSize.small) });
            train.coolAddAnimalToWagon(new Herbivore(AnimalSize.small));
            Assert.AreEqual(train.Wagons[0].Animals.Count, 4);
        }
    }
}
