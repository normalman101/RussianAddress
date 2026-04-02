using Address.Core.Type;

namespace Address.Core;

/// <summary>
/// Класс, описывающий адресс РФ
/// </summary>
public record Address
{
    /// <summary>
    /// Имя страны
    /// </summary>
    public string CountryName { get; set; } // Имя страны
    /// <summary>
    /// Субъект
    /// </summary>
    public Subject Subject { get; set; }
    /// <summary>
    /// Район
    /// </summary>
    public string District { get; set; } // Район
    /// <summary>
    /// Поселение
    /// </summary>
    public Settlement Settlement { get; set; }
    /// <summary>
    /// Населённый пункт
    /// </summary>
    public Locality Locality { get; set; }
    /// <summary>
    /// Городской район
    /// </summary>
    public CityDistrict CityDistrict { get; set; }
    /// <summary>
    /// Тип планировочной структуры
    /// </summary>
    public PlanningStructureType PlanningStructure { get; set; } // Тип планировочной структуры
    /// <summary>
    /// Улично-дорожная сеть
    /// </summary>
    public Street Street { get; set; }
    /// <summary>
    /// Тип земельного участка
    /// </summary>
    public LandPlotType LandPlot { get; set; } // Тип земельного участка
    /// <summary>
    /// Здание
    /// </summary>
    public Building Building { get; set; }
    /// <summary>
    /// Тип помещения
    /// </summary>
    public RoomType Room { get; set; } // Тип помещения
    /// <summary>
    /// Номер машино-места
    /// </summary>
    public string ParkingSpace { get; set; } // Парковочное место
}

/// <summary>
/// Субъект
/// </summary>
public record Subject
{
    /// <summary>
    /// Тип
    /// </summary>
    public FederalSubjectType Type { get; set; }
    /// <summary>
    /// Имя
    /// </summary>
    public string Name { get; set; }
}

/// <summary>
/// Поселение
/// </summary>
public record Settlement
{
    /// <summary>
    /// Тип
    /// </summary>
    public SettlementType Type { get; set; } // Тип поселения
    /// <summary>
    /// Имя
    /// </summary>
    public string Name { get; set; } // Имя поселения
}

/// <summary>
/// Населённый пункт
/// </summary>
public record Locality
{
    /// <summary>
    /// Тип
    /// </summary>
    public SettlementType Type { get; set; } // Тип населённого пункта
    /// <summary>
    /// Имя
    /// </summary>
    public string Name { get; set; } // Имя населённого пункта
}

/// <summary>
/// Городской район
/// </summary>
public record CityDistrict
{
    /// <summary>
    /// Тип
    /// </summary>
    public CityDistrictType Type { get; set; } // Тип внутригородского района
    /// <summary>
    /// Имя
    /// </summary>
    public string Name { get; set; } // Имя внутригородского района
}

/// <summary>
/// Улично-дорожная сеть
/// </summary>
public record Street
{
    /// <summary>
    /// Тип
    /// </summary>
    public StreetType Type { get; set; } // Тип улично-дорожной сети
    /// <summary>
    /// Имя
    /// </summary>
    public string Name { get; set; } // Имя улицы
}

/// <summary>
/// Здание
/// </summary>
public record Building
{
    /// <summary>
    /// Тип
    /// </summary>
    public BuildingType Type { get; set; } // Тип здания
    /// <summary>
    /// Номер
    /// </summary>
    public string Number { get; set; } // Номер здания
}