using UnityEngine;

namespace Antiquete.FieldUnits
{
    public class FieldUnitAttribute : PropertyAttribute
    {
        public readonly string Symbol;
        public FieldUnitAttribute(string symbol) => Symbol = symbol;
    }
}