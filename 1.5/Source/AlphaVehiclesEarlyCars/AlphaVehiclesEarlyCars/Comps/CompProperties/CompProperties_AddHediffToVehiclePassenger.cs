using System;
using System.Collections.Generic;
using System.Linq;
using Verse;
using RimWorld;
using UnityEngine;
using Vehicles;


namespace AlphaVehiclesEarlyCars
{
   
    public class CompProperties_AddHediffToVehiclePassenger : VehicleCompProperties
    {
        public List<HediffToRoles> hediffsToAdd;

        public CompProperties_AddHediffToVehiclePassenger()
        {
            compClass = typeof(CompAddHediffToVehiclePassenger);
        }

     
    }
}
