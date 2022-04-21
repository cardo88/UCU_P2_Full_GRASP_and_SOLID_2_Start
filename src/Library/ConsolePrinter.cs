//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        /// <summary>
        /// Se utiliza el patrón Expert, de forma que un clase se dedique especialmente a 
        /// imprimir en pantalla, en este caso se prepara para imprimir con el mismo codigo
        /// utilizado anteriormente en la clase Recipe.
        /// </summary>
        /// <param name="theRecipe"></param>
        public ConsolePrinter(Recipe theRecipe)
        {
            Console.WriteLine($"Receta de {theRecipe.FinalProduct.Description}:");
            foreach (Step step in theRecipe.GetSteps())
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
            Console.WriteLine($"El costo total es de ${this.GetProductionCost(theRecipe)}");
        }

        public double GetProductionCost(Recipe theRecipe)
        {
            double productsCost = 0 ;
            double equipmentCost = 0;
            foreach (Step step in theRecipe.GetSteps())
            {
                productsCost += step.Input.UnitCost * step.Quantity / 1000;
                equipmentCost += step.Equipment.HourlyCost * step.Time / 60;
            }
            
            return productsCost + equipmentCost;

        }
    }
}