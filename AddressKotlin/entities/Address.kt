package entities

import enums.PlanningStructureType
import enums.LandPlotType
import enums.StreetType
import enums.CityDistrictType
import enums.SettlementType
import enums.FederalSubjectType
import entities.Subject
import entities.Settlement
import entities.Locality
import entities.CityDistrict
import entities.Street
import entities.Building
import entities.LandPlot
import entities.Room

class Address(
    var countryName: String,
    var subject: Subject,
    var district: String,
    var settlement: Settlement,
    var locality: Locality,
    var cityDistrict: CityDistrict,
    var planningStructure: PlanningStructureType,
    var street: Street,
    var building: Building,
    var room: Room,
    var parkingSpaceNumber: String
)
