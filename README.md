# Estructuras de datos – Unidad 1 (Tarea 1.2 y 1.3)

Aplicación de **Windows Forms** (C#, .NET 10, Visual Studio) que demuestra:

1. **Memoria estática vs. redimensionamiento en tiempo de ejecución** (`int[]`, `Array.Resize`, `List<int>`).
2. **Memoria dinámica (Heap)**: instancias de clases, referencias/alias, tipos por valor vs. por referencia,
   lista enlazada propia y recolector de basura (GC).
3. **Complejidad algorítmica**: Bubble Sort `O(n²)` vs. Merge Sort `O(n log n)` con medición real.

## Cómo ejecutarlo
1. Abre `DataStructuresUnit1.sln` en Visual Studio (con la carga de trabajo *Desarrollo de escritorio de .NET* y el SDK de .NET 10).
2. Presiona **F5**.
3. Para ver el diseño visual: doble clic en `MainForm.cs` (abre el Diseñador de Windows Forms).

## Estructura
- `MainForm.cs` / `MainForm.Designer.cs`: interfaz (textos en español) y comportamiento.
- `Models/`: `Student` (clase) / `StudentValue` (struct) y `SinglyLinkedList`.
- `Algorithms/`: `SortingAlgorithms` (con contadores) y `DataGenerator`.

El código fuente y los comentarios están en inglés; la interfaz está en español.
