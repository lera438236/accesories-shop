using System.ComponentModel;

namespace Practic.Models;
public enum DeliveryMode
    {
        [Description("Курьерская доставка по Тирасполю (бесплатно)")]
        DilTir = 0,
        [Description("Курьерская доставка в Бендеры (35 руб)")]
        DilBend = 1,
        [Description("Курьерская доставка в дргуие города")]
        DilAnoth = 2,
        [Description("Самовывоз")]
        DilYour = 3,
    }
