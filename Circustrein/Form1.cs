using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circustrein
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Train circus = new Train();
        private void addAnimalButton_Click(object sender, EventArgs e)
        {
            AnimalSize size;
            if (smallRadioButton.Checked)
            {
                size = AnimalSize.small;
            }
            else if (mediumRadioButton.Checked)
            {
                size = AnimalSize.medium;
            }
            else
            {
                size = AnimalSize.big;
            }
            if (meatEaterRadioButton.Checked)
            {
                Carnivore carnivore = new Carnivore(size);
                circus.coolAddAnimalToWagon(carnivore);
            }
            else
            {
                Herbivore herbivore = new Herbivore(size);
                circus.coolAddAnimalToWagon(herbivore);
            }
            updateTreeView();
        }
        public void updateTreeView ()
        {
            wagonTreeView.Nodes.Clear();
            foreach (Wagon wagon in circus.Wagons)
            {
                wagonTreeView.Nodes.Add(wagon.ToString());
                foreach (Animal animal in wagon.Animals)
                {
                    wagonTreeView.Nodes[wagonTreeView.GetNodeCount(false) - 1].Nodes.Add(animal.ToString());
                }
            }
        }

        private void toGroupBoxButton_Click(object sender, EventArgs e)
        {
            AnimalSize size;
            if (smallRadioButton.Checked)
            {
                size = AnimalSize.small;
            }
            else if (mediumRadioButton.Checked)
            {
                size = AnimalSize.medium;
            }
            else
            {
                size = AnimalSize.big;
            }
            if (meatEaterRadioButton.Checked)
            {
                Carnivore carnivore = new Carnivore(size);
                animalGroupBox.Items.Add(carnivore);
            }
            else
            {
                Herbivore herbivore = new Herbivore(size);
                animalGroupBox.Items.Add(herbivore);
            }

        }

        private void addGroupButton_Click(object sender, EventArgs e)
        {
            List<Animal> animals = new List<Animal>();
            foreach (Animal animal in animalGroupBox.Items)
            {
                animals.Add(animal);
            }
            circus.addGroupOfAnimals(animals);
            updateTreeView();
            animalGroupBox.Items.Clear();
        }
    }
}
