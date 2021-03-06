﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Supplied_06._0_Vend_Lib;

//Assignment 09
//Author: Passic, Lars, 2011958

namespace Food
{
    public class FoodLocker
    {
        public ObservableCollection<Snack> FoodLockerDisplayData = new ObservableCollection<Snack>();

        public const int MinimumSize = 1;
        public const int MaximumSize = 10;

        public FoodLocker()
        {

        }

        private int size;
        public int Size
        {
            get => size;
        }

        //Empty variable for a list of snack objects
        public List<Snack> Store;

        //The stock method loads a list of Snack objects in to the Store field.
        public void Stock()
        {
            Store = new List<Snack>();
            size = randomFoodChooser.Next(MinimumSize,MaximumSize+1);
            for (int i = 0; i < size; i++)
            {
                Store.Add(chooseRandomSnack());
            }
            updateFoodLockerDisplayData();
        }

        

        //Clear and update the winforms list object
        private void updateFoodLockerDisplayData()
        {
            //Clear the display data of objects
            FoodLockerDisplayData.Clear();

            foreach (Snack s in Store)
            {
                FoodLockerDisplayData.Add(s);
            }
        }

        //Create a random to choose different food
        private Random randomFoodChooser = new Random();

        //Method to choose a random snack object
        private Snack chooseRandomSnack()
        {
            //Dot next returns between minValue and one below maxValue
            //So no need to do snackCatalog.count-1
            int snackIndex = randomFoodChooser.Next(0, snackCatalog.Count);
            return snackCatalog[snackIndex].Clone() as Snack;
        }

        //Empty list of snacks
        private static List<Snack> snackCatalog = new List<Snack>();

        //Constructor for FoodLocker? Edit: Nope.
        //The snack catalog willbe astaticcollection of Snack hierarchy objects
        //where each concretetype intheSnackhierarchyis represented exactly once 
        //(i.e.,one Apple, one Banana, one PotatoChip, and one CandyBar).
        static FoodLocker()
        {
            snackCatalog.Add(new Apple("Granny Smith", new PurchasePrice(1.00M)));
            snackCatalog.Add(new Banana("Chaquita", new PurchasePrice(0.50M)));
            snackCatalog.Add(new PotatoChips("Lays", new PurchasePrice(2.00M)));
            snackCatalog.Add(new CandyBar("Snickers", new PurchasePrice(1.75M)));
        }

    }
}
