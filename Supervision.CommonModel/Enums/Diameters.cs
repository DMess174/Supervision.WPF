using SupervisionApp.ModelAPI.Converters;
using System.ComponentModel;

namespace Supervision.CommonModel.Enums
{
    /// <summary>
    /// Диаметр основного прохода
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum Diameters : int
    {
        [Description("100")]
        Hundred = 100,

        [Description("125")]
        Hundred25 = 125,

        [Description("150")]
        Hundred50 = 150,

        [Description("160")]
        Hundred60 = 160,

        [Description("175")]
        Hundred75 = 175,

        [Description("200")]
        TwoHundred = 200,

        [Description("250")]
        TwoHundred50 = 250,

        [Description("300")]
        ThreeHundred = 300,

        [Description("350")]
        ThreeHundred50 = 350,

        [Description("400")]
        FourHundred = 400,

        [Description("450")]
        FourHundred50 = 450,

        [Description("500")]
        FiveHundred = 500,

        [Description("600")]
        SixHundred = 600,

        [Description("700")]
        SevenHundred = 700,

        [Description("800")]
        EightHundred = 800,

        [Description("900")]
        NineHundred = 900,

        [Description("1000")]
        Thousand = 1000,

        [Description("1200")]
        Thousand200 = 1200,
    }
}
