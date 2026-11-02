using System.Runtime.CompilerServices;
using DataStructuresUnit1.Algorithms;
using DataStructuresUnit1.Models;

namespace DataStructuresUnit1;

/// <summary>
/// Main window. The visual layout lives in MainForm.Designer.cs (created with the Visual Studio designer);
/// this file only contains the behavior (event handlers) of the controls.
/// </summary>
public partial class MainForm : Form
{
    // ---- Tab 1: static memory and arrays ----
    private int[] _fixedArray = new int[5];
    private readonly List<int> _dynamicList = new();

    // ---- Tab 2: dynamic memory (Heap) ----
    private readonly List<Student> _students = new();
    private Student? _aliasStudent;
    private readonly SinglyLinkedList _linkedList = new();
    private List<Student>? _allocatedObjects;
    private WeakReference? _allocatedWeakReference;

    // Maximum number of items shown in the list box (keeps the UI fast for big arrays).
    private const int MaxDisplayedItems = 200;

    public MainForm()
    {
        InitializeComponent();

        RefreshStaticMemoryView();
        RefreshMemoryLabels();
        RefreshObjectsStateLabel();
        AppendLog(textBoxStaticLog, "Aplicación iniciada. Se creó un arreglo fijo de 5 elementos.");
    }

    // =====================================================================
    // Shared helpers
    // =====================================================================

    /// <summary>Returns a number that identifies the object instance (not its content).</summary>
    private static int IdentityOf(object instance) => RuntimeHelpers.GetHashCode(instance);

    private static void AppendLog(TextBox target, string message)
    {
        target.AppendText($"[{DateTime.Now:HH:mm:ss}] {message}{Environment.NewLine}");
    }

    private void SetStatus(string message)
    {
        toolStripStatusLabelInfo.Text = message;
    }

    private static void ShowWarning(string message)
    {
        MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    // =====================================================================
    // TAB 1 - Static memory vs. resizing at run time
    // =====================================================================

    private void RefreshStaticMemoryView()
    {
        labelArrayInfo.Text = $"int[]: longitud = {_fixedArray.Length}, identidad del bloque = #{IdentityOf(_fixedArray)}";
        labelListInfo.Text = $"List<int>: Count = {_dynamicList.Count}, Capacity = {_dynamicList.Capacity}";

        listBoxContent.BeginUpdate();
        try
        {
            listBoxContent.Items.Clear();

            listBoxContent.Items.Add("--- Arreglo int[] ---");
            int shownFromArray = Math.Min(_fixedArray.Length, MaxDisplayedItems);
            for (int i = 0; i < shownFromArray; i++)
            {
                listBoxContent.Items.Add($"[{i}] = {_fixedArray[i]}");
            }

            if (_fixedArray.Length > shownFromArray)
            {
                listBoxContent.Items.Add($"... ({_fixedArray.Length - shownFromArray} elementos más)");
            }

            listBoxContent.Items.Add("--- Lista List<int> ---");
            int shownFromList = Math.Min(_dynamicList.Count, MaxDisplayedItems);
            for (int i = 0; i < shownFromList; i++)
            {
                listBoxContent.Items.Add($"[{i}] = {_dynamicList[i]}");
            }

            if (_dynamicList.Count > shownFromList)
            {
                listBoxContent.Items.Add($"... ({_dynamicList.Count - shownFromList} elementos más)");
            }
        }
        finally
        {
            listBoxContent.EndUpdate();
        }
    }

    private void ButtonCreateFixed_Click(object? sender, EventArgs e)
    {
        int size = (int)numericFixedSize.Value;

        // Static-size allocation: the length is decided once and can never change for this block.
        _fixedArray = new int[size];

        AppendLog(textBoxStaticLog,
            $"Se creó un arreglo de tamaño fijo con {size} elementos (identidad #{IdentityOf(_fixedArray)}). Todos valen 0.");
        SetStatus($"Arreglo fijo creado con {size} elementos.");
        RefreshStaticMemoryView();
    }

    private void ButtonAssign_Click(object? sender, EventArgs e)
    {
        int index = (int)numericIndex.Value;
        int value = (int)numericValue.Value;

        try
        {
            _fixedArray[index] = value;
            AppendLog(textBoxStaticLog, $"arreglo[{index}] = {value}  (acceso directo por índice, tiempo O(1)).");
            SetStatus($"Valor asignado en la posición {index}.");
            RefreshStaticMemoryView();
        }
        catch (IndexOutOfRangeException)
        {
            AppendLog(textBoxStaticLog,
                $"ERROR: el índice {index} está fuera del rango válido [0, {_fixedArray.Length - 1}]. " +
                "Un arreglo de tamaño fijo no crece por sí solo; hay que redimensionarlo.");
            SetStatus("Índice fuera de rango (IndexOutOfRangeException controlada).");
        }
    }

    private void ButtonResize_Click(object? sender, EventArgs e)
    {
        int newSize = (int)numericNewSize.Value;
        int oldLength = _fixedArray.Length;
        int oldIdentity = IdentityOf(_fixedArray);

        // Array.Resize does NOT grow the block in place: it allocates a new array and copies the old data.
        Array.Resize(ref _fixedArray, newSize);

        int newIdentity = IdentityOf(_fixedArray);

        if (newIdentity == oldIdentity)
        {
            AppendLog(textBoxStaticLog, $"El tamaño solicitado ({newSize}) es igual al actual; no se reservó memoria nueva.");
        }
        else
        {
            AppendLog(textBoxStaticLog,
                $"Array.Resize: de {oldLength} a {newSize} elementos. Se reservó un bloque NUEVO (#{newIdentity}), " +
                $"se copiaron {Math.Min(oldLength, newSize)} valores del bloque anterior (#{oldIdentity}) " +
                "y éste quedó como basura para el GC. Costo: O(n).");
        }

        SetStatus($"Arreglo redimensionado a {newSize} elementos.");
        RefreshStaticMemoryView();
    }

    private void ButtonListAdd_Click(object? sender, EventArgs e)
    {
        int value = (int)numericListValue.Value;
        int capacityBefore = _dynamicList.Capacity;

        _dynamicList.Add(value);

        if (_dynamicList.Capacity != capacityBefore)
        {
            AppendLog(textBoxStaticLog,
                $"List<int>.Add({value}): la capacidad se agotó, se creó un arreglo interno más grande " +
                $"({capacityBefore} → {_dynamicList.Capacity}) y se copiaron los datos. Count = {_dynamicList.Count}.");
        }
        else
        {
            AppendLog(textBoxStaticLog,
                $"List<int>.Add({value}): cabía en la capacidad actual ({_dynamicList.Capacity}). Count = {_dynamicList.Count}.");
        }

        SetStatus($"Elemento agregado a la lista. Count = {_dynamicList.Count}.");
        RefreshStaticMemoryView();
    }

    // =====================================================================
    // TAB 2 - Dynamic memory: instances and references on the Heap
    // =====================================================================

    private void RefreshStudentList()
    {
        int selected = listBoxStudents.SelectedIndex;

        listBoxStudents.BeginUpdate();
        try
        {
            listBoxStudents.Items.Clear();
            foreach (Student student in _students)
            {
                listBoxStudents.Items.Add($"#{IdentityOf(student)}  {student.Name}  —  {student.Grade:0.0}");
            }

            if (selected >= 0 && selected < listBoxStudents.Items.Count)
            {
                listBoxStudents.SelectedIndex = selected;
            }
        }
        finally
        {
            listBoxStudents.EndUpdate();
        }
    }

    private void ButtonCreateStudent_Click(object? sender, EventArgs e)
    {
        string name = textBoxStudentName.Text.Trim();
        if (name.Length == 0)
        {
            ShowWarning("Escribe un nombre para crear la instancia.");
            return;
        }

        // 'new' requests memory on the Heap; 'student' only holds the reference to it.
        var student = new Student(name, (double)numericGrade.Value);
        _students.Add(student);

        AppendLog(textBoxDynamicLog,
            $"new Student(\"{name}\", {student.Grade:0.0}) → objeto creado en el Heap con identidad #{IdentityOf(student)}. " +
            $"Instancias totales: {_students.Count}.");
        SetStatus("Instancia creada en el Heap.");
        RefreshStudentList();
    }

    private void ButtonCreateAlias_Click(object? sender, EventArgs e)
    {
        int index = listBoxStudents.SelectedIndex;
        if (index < 0)
        {
            ShowWarning("Selecciona primero una instancia de la lista.");
            return;
        }

        Student original = _students[index];
        _aliasStudent = original; // copies only the reference, NOT the object

        AppendLog(textBoxDynamicLog,
            $"alias = original → ReferenceEquals(alias, original) = {ReferenceEquals(_aliasStudent, original)}. " +
            $"Ambas variables apuntan al mismo objeto #{IdentityOf(original)}; no se copió el contenido.");
        SetStatus("Alias creado (misma referencia).");
    }

    private void ButtonModifyAlias_Click(object? sender, EventArgs e)
    {
        if (_aliasStudent is null)
        {
            ShowWarning("Primero crea un alias de la selección.");
            return;
        }

        double previousGrade = _aliasStudent.Grade;
        _aliasStudent.Grade = Math.Min(100, _aliasStudent.Grade + 5);

        AppendLog(textBoxDynamicLog,
            $"Se modificó la calificación a través del alias: {previousGrade:0.0} → {_aliasStudent.Grade:0.0}. " +
            "El objeto original (misma referencia) también muestra el cambio en la lista.");
        SetStatus("Objeto modificado mediante su alias.");
        RefreshStudentList();
    }

    private void ButtonCopyStruct_Click(object? sender, EventArgs e)
    {
        int index = listBoxStudents.SelectedIndex;
        if (index < 0)
        {
            ShowWarning("Selecciona primero una instancia de la lista.");
            return;
        }

        Student source = _students[index];

        // Value type: the assignment copies ALL the data, so both variables are independent.
        var original = new StudentValue(source.Name, source.Grade);
        StudentValue copy = original;
        copy.Grade += 10;

        AppendLog(textBoxDynamicLog,
            $"struct: original.Grade = {original.Grade:0.0}, copy.Grade = {copy.Grade:0.0}. " +
            "Al ser un tipo por valor, la copia es independiente (no hay aliasing). " +
            "Con una clase (tipo por referencia) ambos cambiarían.");
        SetStatus("Comparación valor vs. referencia realizada.");
    }

    private void RefreshLinkedListLabel()
    {
        labelListContent.Text = $"Lista ({_linkedList.Count} nodos): {_linkedList}";
    }

    private void ButtonAddNode_Click(object? sender, EventArgs e)
    {
        int value = (int)numericNodeValue.Value;
        _linkedList.AddLast(value);

        AppendLog(textBoxDynamicLog,
            $"AddLast({value}): se reservó un nodo nuevo en el Heap y se enlazó al final. Nodos: {_linkedList.Count}.");
        SetStatus("Nodo insertado.");
        RefreshLinkedListLabel();
    }

    private void ButtonRemoveFirst_Click(object? sender, EventArgs e)
    {
        if (_linkedList.RemoveFirst(out int removed))
        {
            AppendLog(textBoxDynamicLog,
                $"RemoveFirst(): se desenlazó el nodo con valor {removed}; queda sin referencias y el GC podrá liberarlo. " +
                $"Nodos: {_linkedList.Count}.");
            SetStatus("Nodo eliminado.");
        }
        else
        {
            AppendLog(textBoxDynamicLog, "La lista está vacía; no hay nada que eliminar.");
            SetStatus("La lista está vacía.");
        }

        RefreshLinkedListLabel();
    }

    // ---- Garbage collector demo ----

    private void RefreshMemoryLabels()
    {
        labelMemory.Text = $"Memoria administrada: {GC.GetTotalMemory(false) / 1024:N0} KB";
    }

    private void RefreshObjectsStateLabel()
    {
        if (_allocatedObjects is not null)
        {
            labelObjectsState.Text = $"Estado de los objetos: referenciados ({_allocatedObjects.Count:N0} instancias vivas).";
        }
        else if (_allocatedWeakReference is null)
        {
            labelObjectsState.Text = "Estado de los objetos: aún no se han creado.";
        }
        else if (_allocatedWeakReference.IsAlive)
        {
            labelObjectsState.Text = "Estado de los objetos: sin referencias, pendientes de recolección.";
        }
        else
        {
            labelObjectsState.Text = "Estado de los objetos: recolectados por el GC (memoria liberada).";
        }
    }

    private void ButtonAllocate_Click(object? sender, EventArgs e)
    {
        int count = (int)numericAllocate.Value;
        long before = GC.GetTotalMemory(false);

        var objects = new List<Student>(count);
        for (int i = 0; i < count; i++)
        {
            objects.Add(new Student("Alumno " + i, i % 101));
        }

        _allocatedObjects = objects;
        _allocatedWeakReference = new WeakReference(objects);

        long after = GC.GetTotalMemory(false);
        AppendLog(textBoxDynamicLog,
            $"Se asignaron {count:N0} objetos en el Heap. Memoria: {before / 1024:N0} KB → {after / 1024:N0} KB " +
            $"(+{(after - before) / 1024:N0} KB).");
        SetStatus("Objetos asignados en el Heap.");
        RefreshMemoryLabels();
        RefreshObjectsStateLabel();
    }

    private void ButtonRelease_Click(object? sender, EventArgs e)
    {
        if (_allocatedObjects is null)
        {
            ShowWarning("No hay objetos referenciados. Usa primero «Asignar objetos».");
            return;
        }

        // Removing the only reference makes the objects unreachable, but the memory is not freed instantly.
        _allocatedObjects = null;

        AppendLog(textBoxDynamicLog,
            $"Se eliminó la única referencia. La memoria sigue ocupada ({GC.GetTotalMemory(false) / 1024:N0} KB) " +
            "hasta que el recolector de basura se ejecute.");
        SetStatus("Referencias liberadas; falta que el GC recolecte.");
        RefreshMemoryLabels();
        RefreshObjectsStateLabel();
    }

    private void ButtonCollect_Click(object? sender, EventArgs e)
    {
        long before = GC.GetTotalMemory(false);

        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();

        long after = GC.GetTotalMemory(true);
        AppendLog(textBoxDynamicLog,
            $"GC.Collect(): memoria {before / 1024:N0} KB → {after / 1024:N0} KB " +
            $"(liberados ≈ {Math.Max(0, before - after) / 1024:N0} KB).");
        SetStatus("Recolección de basura ejecutada.");
        RefreshMemoryLabels();
        RefreshObjectsStateLabel();
    }

    // =====================================================================
    // TAB 3 - Algorithm complexity: Bubble Sort vs. Merge Sort
    // =====================================================================

    private async void ButtonRunComparison_Click(object? sender, EventArgs e)
    {
        buttonRunComparison.Enabled = false;
        SetStatus("Ejecutando algoritmos de ordenamiento...");

        try
        {
            int n = (int)numericArraySize.Value;
            int scenario = comboBoxScenario.SelectedIndex;

            int[] original = DataGenerator.Create(n, scenario);
            int[] forBubble = (int[])original.Clone();
            int[] forMerge = (int[])original.Clone();

            // Run one after the other (not in parallel) so the timings do not disturb each other.
            SortMetrics bubble = await Task.Run(() => SortingAlgorithms.BubbleSort(forBubble));
            SortMetrics merge = await Task.Run(() => SortingAlgorithms.MergeSort(forMerge));

            bool bothSorted = SortingAlgorithms.IsSorted(forBubble) && SortingAlgorithms.IsSorted(forMerge);

            FillResults(bubble, merge);
            WriteAnalysis(n, scenario, bubble, merge, bothSorted);
            SetStatus("Comparación terminada.");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error durante la comparación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            SetStatus("Error durante la comparación.");
        }
        finally
        {
            buttonRunComparison.Enabled = true;
        }
    }

    private void FillResults(SortMetrics bubble, SortMetrics merge)
    {
        listViewResults.Items.Clear();

        listViewResults.Items.Add(new ListViewItem(new[]
        {
            "Bubble Sort (optimizado)", "O(n²)", "O(1)",
            bubble.Comparisons.ToString("N0"), bubble.Assignments.ToString("N0"),
            bubble.ElapsedMilliseconds.ToString("N3")
        }));

        listViewResults.Items.Add(new ListViewItem(new[]
        {
            "Merge Sort", "O(n log n)", "O(n)",
            merge.Comparisons.ToString("N0"), merge.Assignments.ToString("N0"),
            merge.ElapsedMilliseconds.ToString("N3")
        }));
    }

    private void WriteAnalysis(int n, int scenario, SortMetrics bubble, SortMetrics merge, bool bothSorted)
    {
        string scenarioName = scenario switch
        {
            DataGenerator.SortedScenario => "datos ya ordenados (mejor caso del Bubble Sort)",
            DataGenerator.ReversedScenario => "datos en orden inverso (peor caso del Bubble Sort)",
            _ => "datos aleatorios (caso promedio)"
        };

        double quadraticEstimate = n * (n - 1.0) / 2.0;
        double linearithmicEstimate = n * Math.Log2(n);
        long mergeExtraBytes = (long)n * sizeof(int);

        double bubbleMs = Math.Max(bubble.ElapsedMilliseconds, 0.001);
        double mergeMs = Math.Max(merge.ElapsedMilliseconds, 0.001);

        textBoxAnalysis.Clear();
        AppendLine($"Tamaño n = {n:N0} | Escenario: {scenarioName}");
        AppendLine($"Verificación: ambos arreglos quedaron ordenados = {(bothSorted ? "SÍ" : "NO")}");
        AppendLine(string.Empty);
        AppendLine("--- Operaciones teóricas aproximadas ---");
        AppendLine($"n(n-1)/2  = {quadraticEstimate:N0}   (cota del Bubble Sort)");
        AppendLine($"n·log2(n) = {linearithmicEstimate:N0}   (cota del Merge Sort)");
        AppendLine(string.Empty);
        AppendLine("--- Memoria adicional ---");
        AppendLine("Bubble Sort: 0 bytes extra (ordena en el mismo arreglo) → O(1).");
        AppendLine($"Merge Sort : {mergeExtraBytes / 1024:N0} KB extra (buffer auxiliar de n enteros) → O(n).");
        AppendLine(string.Empty);
        AppendLine("--- Conclusión ---");

        if (bubbleMs <= mergeMs)
        {
            AppendLine($"Con estos datos el Bubble Sort fue igual o más rápido ({bubble.ElapsedMilliseconds:N3} ms vs {merge.ElapsedMilliseconds:N3} ms).");
            if (scenario == DataGenerator.SortedScenario)
            {
                AppendLine("Razón: con datos ya ordenados la bandera 'swapped' detiene el algoritmo tras UNA pasada: O(n).");
            }
            else
            {
                AppendLine("Razón: con n pequeño las constantes ocultas pesan más que el orden de crecimiento.");
            }
        }
        else
        {
            AppendLine($"El Merge Sort fue {bubbleMs / mergeMs:N1} veces más rápido ({merge.ElapsedMilliseconds:N3} ms vs {bubble.ElapsedMilliseconds:N3} ms).");
            AppendLine("Razón: O(n log n) crece mucho más lento que O(n²) cuando n aumenta.");
        }

        AppendLine("Costo: el Merge Sort paga esa velocidad con memoria adicional O(n); el Bubble Sort no.");
    }

    private void AppendLine(string text)
    {
        textBoxAnalysis.AppendText(text + Environment.NewLine);
    }
}
