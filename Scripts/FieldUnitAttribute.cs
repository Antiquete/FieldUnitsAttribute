using UnityEngine;

namespace FieldUnits
{
    public class FieldUnitAttribute : PropertyAttribute
    {
        public readonly string Symbol;
        public FieldUnitAttribute(string symbol) => Symbol = symbol;
    }
}