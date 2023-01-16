using System.ComponentModel;

namespace dws_ex_1.src.Domain.Helpers
{
  public enum EUnitOfMeasurement : byte {
    [Description("UN")]
    Unity = 1,

    [Description("MG")]
    Milligram = 2,

    [Description("G")]
    Gram = 2,

    [Description("KG")]
    Kilogram = 4,

    [Description("L")]
    Liter = 5,
  }
}