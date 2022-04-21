//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        /// <summary>
        /// se crea un método que permita acceder a los steps de la instancia, ya que este 
        /// atributo es originalmenten privado.
        /// </summary>
        /// <returns>steps de la instancia</returns>
        public ArrayList GetSteps()
        {
            return this.steps;
        }

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public void PrintRecipe()
        {
            ConsolePrinter sendPrint = new ConsolePrinter(this);
        }



        ///
        /// se traslada código desde la clase Recipe a la clase experta ConsolePrinter
        /// 
        // public void PrintRecipe()
        // {
        //     Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
        //     foreach (Step step in this.steps)
        //     {
        //         Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
        //             $"usando '{step.Equipment.Description}' durante {step.Time}");
        //     }
        //     Console.WriteLine($"El costo total es de ${this.GetProductionCost()}");
        // }

        // /// <summary>
        // /// se aplica el principio de SRP, de tal forma que la clase "Recipe" siga 
        // /// siendo la responsable de la receta, por consiguiente de su impresión en pantalla,
        // /// y entonces de realizar el cálculo del total de su costo.
        // /// </summary>
        // /// <returns>CostoTotal</returns>
        // public double GetProductionCost()
        // {
        //     double productsCost = 0 ;
        //     double equipmentCost = 0;
        //     foreach (Step step in this.steps)
        //     {
        //         productsCost += step.Input.UnitCost * step.Quantity / 1000;
        //         equipmentCost += step.Equipment.HourlyCost * step.Time / 60;
        //     }
            
        //     return productsCost + equipmentCost;

        // }
    }
}