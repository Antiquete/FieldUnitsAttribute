using UnityEngine;

namespace FieldUnits
{
    public class FieldUnitsSample : MonoBehaviour
    {
        [Header("Movement")]
        [FieldUnit("m")]
        public float distance = 12.5f;

        [FieldUnit("m/s")]
        public float speed = 5f;

        [Header("Timing")]
        [FieldUnit("s")]
        public float duration = 2.5f;

        [FieldUnit("ms")]
        public int delay = 250;

        [Header("Other Units")]
        [FieldUnit("°")]
        public float angle = 45f;

        [FieldUnit("kg")]
        public float mass = 10f;

        [FieldUnit("%")]
        public float efficiency = 95f;
    }
}
