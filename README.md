# Field Units

Add readable units to Inspector Fields with `[FieldUnit("m")]`:

```csharp
using UnityEngine;
using Antiquete.FieldUnits;

public class Movement : MonoBehaviour
{
    [FieldUnit("m/s")]
    public float speed = 5f;

    [SerializeField, FieldUnit("s")]
    private float duration = 2.5f;
}
```

```text
Distance (m)    [12.5]
Speed (m/s)     [5]
Duration (s)    [2.5]
```

## Support and license

- Issues: [https://github.com/Antiquete/FieldUnitsAttribute/issues](https://github.com/Antiquete/FieldUnitsAttribute/issues)
- Email: antiquete@proton.me
- Website: [antiquete.cc](https://antiquete.cc/)
