package entities

import enums.BuildingType

open class Building
(
    val type: BuildingType,
    var number: String? = null
)
