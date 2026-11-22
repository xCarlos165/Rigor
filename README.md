# Rigor

Videojuego *hardcore* de supervivencia isométrica *offline* enfocado en dispositivos móviles, con sistema de daño localizado por extremidades (*Paper Doll*), sigilo acústico y muerte definitiva (*Permadeath*).

## Objetivo del proyecto
Diseñar y desarrollar una arquitectura modular y escalable en Unity 6 que mantenga un rendimiento estable de 60 FPS en hardware móvil de gama media, eliminando el acoplamiento directo entre la lógica de juego y la interfaz mediante eventos (*Observer Pattern*), serialización asíncrona a JSON, carga multi-escena aditiva y *Object Pooling*.

## Integrante
* **Carlos Pérez** – Desarrollo, arquitectura de software y gestión de repositorio.

## Herramientas utilizadas
* **Motor:** Unity 6 (6000.3.26f1 LTS) con Universal Render Pipeline (URP)
* **Lenguaje:** C# (.NET)
* **Control de versiones:** Git, Git LFS y GitHub
* **Modelado y arte 3D:** Blender
* **Audio:** Reaper / Audacity

## Estructura del repositorio

    Rigor/
    ├── Assets/
    │   ├── _Rigor/
    │   │   ├── Animations/
    │   │   ├── Audio/
    │   │   ├── Characters/
    │   │   ├── Data/
    │   │   ├── Environments/
    │   │   ├── Models/
    │   │   ├── Prefabs/
    │   │   ├── Scenes/
    │   │   ├── Scripts/
    │   │   │   ├── AI/
    │   │   │   ├── Combat/
    │   │   │   ├── Core/
    │   │   │   ├── Persistence/
    │   │   │   └── UI/
    │   │   ├── Tests/
    │   │   └── UI/
    │   └── ThirdParty/
    ├── Docs/
    │   └── Diagramas/
    ├── Packages/
    ├── ProjectSettings/
    ├── .gitattributes
    ├── .gitignore
    └── README.md

## Flujo de trabajo en Git
* `main`: rama estable con versiones funcionales verificadas.
* `develop`: rama de integración de sistemas y avances.
* `feature/*`: ramas aisladas para el desarrollo de mecánicas o módulos específicos.
