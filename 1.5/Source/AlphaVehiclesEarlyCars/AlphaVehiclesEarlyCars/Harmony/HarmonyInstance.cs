using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Verse;
using RimWorld;
using HarmonyLib;
using System.Reflection;

namespace AlphaVehiclesEarlyCars
{

    //Setting the Harmony instance
    [StaticConstructorOnStartup]
    public class MainEarlyCars
    {
        static MainEarlyCars()
        {
            var harmony = new Harmony("com.alphavehiclesearlycars");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }


    }

}
