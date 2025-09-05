using HarmonyLib;
using MGSC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace DontShootBoxes
{
    /// <summary>
    /// Changes the default action for all storage items to "Open" instead of "Attack".
    /// </summary>
    [HarmonyPatch(MethodType.Getter)]
    [HarmonyPatch(typeof(Store), nameof(Store.AttackAsPrimaryAction))]
    public static class Store_AttackAsPrimaryAction_Patch
    {
        public static bool Prefix()
        {
            return false;
        }
    }
}
