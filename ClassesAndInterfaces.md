# Classes

## Class Diagram
```mermaid
classDiagram
Entity <|-- Character
Character <|-- Wolf
Character <|-- Sheep

Entity <|-- Building
Building <|-- Castle
Building <|-- Houses
Building <|-- ProcessorBuilding
ProcessorBuilding <|-- StoneMasonry
ProcessorBuilding <|-- SawMill

Entity <|-- Resource

TERRAIN
Terrain <|-- Soil
Soil <|-- RawSoil
Soil <|-- Tilled
Terrain <|-- Sand
Terrain <|-- Rock
Rock <|-- RawRock
Rock <|-- Cobblestone
Rock <|-- StoneBrick

Terrain <|-- Snow
Terrain <|-- Grass
```

## Terrain
Soil, Sand, and Rock make up the base ground elements.

Grass and Snow solely exist on top of another base terrain. This property can be extrapolated to all of the terrains, where stone must be the base element that others are built on.

---

## Architecture Diagram

```mermaid
classDiagram
View <|-- Model
Controller <|-- View
Model <|-- View
```

```mermaid
classDiagram
A

A<--B
```