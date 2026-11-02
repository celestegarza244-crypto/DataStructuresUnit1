namespace DataStructuresUnit1;

partial class MainForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.tabControlMain = new System.Windows.Forms.TabControl();
        this.statusStrip = new System.Windows.Forms.StatusStrip();
        this.toolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
        this.tabStaticMemory = new System.Windows.Forms.TabPage();
        this.tabDynamicMemory = new System.Windows.Forms.TabPage();
        this.tabAlgorithms = new System.Windows.Forms.TabPage();
        this.groupFixedArray = new System.Windows.Forms.GroupBox();
        this.labelFixedSize = new System.Windows.Forms.Label();
        this.numericFixedSize = new System.Windows.Forms.NumericUpDown();
        this.buttonCreateFixed = new System.Windows.Forms.Button();
        this.labelIndex = new System.Windows.Forms.Label();
        this.numericIndex = new System.Windows.Forms.NumericUpDown();
        this.labelValue = new System.Windows.Forms.Label();
        this.numericValue = new System.Windows.Forms.NumericUpDown();
        this.buttonAssign = new System.Windows.Forms.Button();
        this.groupResize = new System.Windows.Forms.GroupBox();
        this.labelNewSize = new System.Windows.Forms.Label();
        this.numericNewSize = new System.Windows.Forms.NumericUpDown();
        this.buttonResize = new System.Windows.Forms.Button();
        this.labelListValue = new System.Windows.Forms.Label();
        this.numericListValue = new System.Windows.Forms.NumericUpDown();
        this.buttonListAdd = new System.Windows.Forms.Button();
        this.groupContent = new System.Windows.Forms.GroupBox();
        this.labelArrayInfo = new System.Windows.Forms.Label();
        this.labelListInfo = new System.Windows.Forms.Label();
        this.listBoxContent = new System.Windows.Forms.ListBox();
        this.groupStaticLog = new System.Windows.Forms.GroupBox();
        this.textBoxStaticLog = new System.Windows.Forms.TextBox();
        this.groupObjects = new System.Windows.Forms.GroupBox();
        this.labelStudentName = new System.Windows.Forms.Label();
        this.textBoxStudentName = new System.Windows.Forms.TextBox();
        this.labelStudentGrade = new System.Windows.Forms.Label();
        this.numericGrade = new System.Windows.Forms.NumericUpDown();
        this.buttonCreateStudent = new System.Windows.Forms.Button();
        this.buttonCreateAlias = new System.Windows.Forms.Button();
        this.buttonModifyAlias = new System.Windows.Forms.Button();
        this.buttonCopyStruct = new System.Windows.Forms.Button();
        this.listBoxStudents = new System.Windows.Forms.ListBox();
        this.groupLinkedList = new System.Windows.Forms.GroupBox();
        this.labelNodeValue = new System.Windows.Forms.Label();
        this.numericNodeValue = new System.Windows.Forms.NumericUpDown();
        this.buttonAddNode = new System.Windows.Forms.Button();
        this.buttonRemoveFirst = new System.Windows.Forms.Button();
        this.labelListContent = new System.Windows.Forms.Label();
        this.groupGc = new System.Windows.Forms.GroupBox();
        this.labelAllocateCount = new System.Windows.Forms.Label();
        this.numericAllocate = new System.Windows.Forms.NumericUpDown();
        this.buttonAllocate = new System.Windows.Forms.Button();
        this.buttonRelease = new System.Windows.Forms.Button();
        this.buttonCollect = new System.Windows.Forms.Button();
        this.labelMemory = new System.Windows.Forms.Label();
        this.labelObjectsState = new System.Windows.Forms.Label();
        this.groupDynamicLog = new System.Windows.Forms.GroupBox();
        this.textBoxDynamicLog = new System.Windows.Forms.TextBox();
        this.groupParameters = new System.Windows.Forms.GroupBox();
        this.labelArraySize = new System.Windows.Forms.Label();
        this.numericArraySize = new System.Windows.Forms.NumericUpDown();
        this.labelScenario = new System.Windows.Forms.Label();
        this.comboBoxScenario = new System.Windows.Forms.ComboBox();
        this.buttonRunComparison = new System.Windows.Forms.Button();
        this.groupResults = new System.Windows.Forms.GroupBox();
        this.listViewResults = new System.Windows.Forms.ListView();
        this.columnAlgorithm = new System.Windows.Forms.ColumnHeader();
        this.columnTime = new System.Windows.Forms.ColumnHeader();
        this.columnSpace = new System.Windows.Forms.ColumnHeader();
        this.columnComparisons = new System.Windows.Forms.ColumnHeader();
        this.columnAssignments = new System.Windows.Forms.ColumnHeader();
        this.columnElapsed = new System.Windows.Forms.ColumnHeader();
        this.groupAnalysis = new System.Windows.Forms.GroupBox();
        this.textBoxAnalysis = new System.Windows.Forms.TextBox();
        ((System.ComponentModel.ISupportInitialize)(this.numericFixedSize)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.numericIndex)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.numericValue)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.numericNewSize)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.numericListValue)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.numericGrade)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.numericNodeValue)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.numericAllocate)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.numericArraySize)).BeginInit();
        this.tabControlMain.SuspendLayout();
        this.statusStrip.SuspendLayout();
        this.tabStaticMemory.SuspendLayout();
        this.tabDynamicMemory.SuspendLayout();
        this.tabAlgorithms.SuspendLayout();
        this.groupFixedArray.SuspendLayout();
        this.groupResize.SuspendLayout();
        this.groupContent.SuspendLayout();
        this.groupStaticLog.SuspendLayout();
        this.groupObjects.SuspendLayout();
        this.groupLinkedList.SuspendLayout();
        this.groupGc.SuspendLayout();
        this.groupDynamicLog.SuspendLayout();
        this.groupParameters.SuspendLayout();
        this.groupResults.SuspendLayout();
        this.groupAnalysis.SuspendLayout();
        this.SuspendLayout();
        // 
        // tabControlMain
        // 
        this.tabControlMain.Controls.Add(this.tabStaticMemory);
        this.tabControlMain.Controls.Add(this.tabDynamicMemory);
        this.tabControlMain.Controls.Add(this.tabAlgorithms);
        this.tabControlMain.Name = "tabControlMain";
        this.tabControlMain.Location = new System.Drawing.Point(0, 0);
        this.tabControlMain.Size = new System.Drawing.Size(980, 658);
        this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tabControlMain.SelectedIndex = 0;
        // 
        // statusStrip
        // 
        this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelInfo});
        this.statusStrip.Name = "statusStrip";
        this.statusStrip.Location = new System.Drawing.Point(0, 658);
        this.statusStrip.Size = new System.Drawing.Size(980, 22);
        // 
        // toolStripStatusLabelInfo
        // 
        this.toolStripStatusLabelInfo.Name = "toolStripStatusLabelInfo";
        this.toolStripStatusLabelInfo.Text = "Listo.";
        this.toolStripStatusLabelInfo.AutoSize = true;
        // 
        // tabStaticMemory
        // 
        this.tabStaticMemory.Controls.Add(this.groupFixedArray);
        this.tabStaticMemory.Controls.Add(this.groupResize);
        this.tabStaticMemory.Controls.Add(this.groupContent);
        this.tabStaticMemory.Controls.Add(this.groupStaticLog);
        this.tabStaticMemory.Name = "tabStaticMemory";
        this.tabStaticMemory.Location = new System.Drawing.Point(4, 24);
        this.tabStaticMemory.Size = new System.Drawing.Size(972, 630);
        this.tabStaticMemory.Text = "1. Memoria estática y arreglos";
        this.tabStaticMemory.Padding = new System.Windows.Forms.Padding(3);
        this.tabStaticMemory.UseVisualStyleBackColor = true;
        // 
        // tabDynamicMemory
        // 
        this.tabDynamicMemory.Controls.Add(this.groupObjects);
        this.tabDynamicMemory.Controls.Add(this.groupLinkedList);
        this.tabDynamicMemory.Controls.Add(this.groupGc);
        this.tabDynamicMemory.Controls.Add(this.groupDynamicLog);
        this.tabDynamicMemory.Name = "tabDynamicMemory";
        this.tabDynamicMemory.Location = new System.Drawing.Point(4, 24);
        this.tabDynamicMemory.Size = new System.Drawing.Size(972, 630);
        this.tabDynamicMemory.Text = "2. Memoria dinámica (Heap)";
        this.tabDynamicMemory.Padding = new System.Windows.Forms.Padding(3);
        this.tabDynamicMemory.UseVisualStyleBackColor = true;
        // 
        // tabAlgorithms
        // 
        this.tabAlgorithms.Controls.Add(this.groupParameters);
        this.tabAlgorithms.Controls.Add(this.groupResults);
        this.tabAlgorithms.Controls.Add(this.groupAnalysis);
        this.tabAlgorithms.Name = "tabAlgorithms";
        this.tabAlgorithms.Location = new System.Drawing.Point(4, 24);
        this.tabAlgorithms.Size = new System.Drawing.Size(972, 630);
        this.tabAlgorithms.Text = "3. Complejidad algorítmica";
        this.tabAlgorithms.Padding = new System.Windows.Forms.Padding(3);
        this.tabAlgorithms.UseVisualStyleBackColor = true;
        // 
        // groupFixedArray
        // 
        this.groupFixedArray.Controls.Add(this.labelFixedSize);
        this.groupFixedArray.Controls.Add(this.numericFixedSize);
        this.groupFixedArray.Controls.Add(this.buttonCreateFixed);
        this.groupFixedArray.Controls.Add(this.labelIndex);
        this.groupFixedArray.Controls.Add(this.numericIndex);
        this.groupFixedArray.Controls.Add(this.labelValue);
        this.groupFixedArray.Controls.Add(this.numericValue);
        this.groupFixedArray.Controls.Add(this.buttonAssign);
        this.groupFixedArray.Name = "groupFixedArray";
        this.groupFixedArray.Location = new System.Drawing.Point(12, 12);
        this.groupFixedArray.Size = new System.Drawing.Size(440, 150);
        this.groupFixedArray.Text = "Arreglo de tamaño fijo (estático)";
        // 
        // labelFixedSize
        // 
        this.labelFixedSize.Name = "labelFixedSize";
        this.labelFixedSize.Location = new System.Drawing.Point(15, 31);
        this.labelFixedSize.AutoSize = true;
        this.labelFixedSize.Text = "Tamaño del arreglo:";
        // 
        // numericFixedSize
        // 
        this.numericFixedSize.Name = "numericFixedSize";
        this.numericFixedSize.Location = new System.Drawing.Point(160, 28);
        this.numericFixedSize.Size = new System.Drawing.Size(80, 23);
        this.numericFixedSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        this.numericFixedSize.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        this.numericFixedSize.Value = new decimal(new int[] { 5, 0, 0, 0 });
        // 
        // buttonCreateFixed
        // 
        this.buttonCreateFixed.Name = "buttonCreateFixed";
        this.buttonCreateFixed.Location = new System.Drawing.Point(260, 24);
        this.buttonCreateFixed.Size = new System.Drawing.Size(165, 30);
        this.buttonCreateFixed.Text = "Crear arreglo fijo";
        this.buttonCreateFixed.UseVisualStyleBackColor = true;
        this.buttonCreateFixed.Click += new System.EventHandler(this.ButtonCreateFixed_Click);
        // 
        // labelIndex
        // 
        this.labelIndex.Name = "labelIndex";
        this.labelIndex.Location = new System.Drawing.Point(15, 76);
        this.labelIndex.AutoSize = true;
        this.labelIndex.Text = "Índice:";
        // 
        // numericIndex
        // 
        this.numericIndex.Name = "numericIndex";
        this.numericIndex.Location = new System.Drawing.Point(160, 73);
        this.numericIndex.Size = new System.Drawing.Size(80, 23);
        this.numericIndex.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
        this.numericIndex.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        this.numericIndex.Value = new decimal(new int[] { 0, 0, 0, 0 });
        // 
        // labelValue
        // 
        this.labelValue.Name = "labelValue";
        this.labelValue.Location = new System.Drawing.Point(15, 108);
        this.labelValue.AutoSize = true;
        this.labelValue.Text = "Valor:";
        // 
        // numericValue
        // 
        this.numericValue.Name = "numericValue";
        this.numericValue.Location = new System.Drawing.Point(160, 105);
        this.numericValue.Size = new System.Drawing.Size(80, 23);
        this.numericValue.Minimum = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
        this.numericValue.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        this.numericValue.Value = new decimal(new int[] { 10, 0, 0, 0 });
        // 
        // buttonAssign
        // 
        this.buttonAssign.Name = "buttonAssign";
        this.buttonAssign.Location = new System.Drawing.Point(260, 88);
        this.buttonAssign.Size = new System.Drawing.Size(165, 30);
        this.buttonAssign.Text = "Asignar valor";
        this.buttonAssign.UseVisualStyleBackColor = true;
        this.buttonAssign.Click += new System.EventHandler(this.ButtonAssign_Click);
        // 
        // groupResize
        // 
        this.groupResize.Controls.Add(this.labelNewSize);
        this.groupResize.Controls.Add(this.numericNewSize);
        this.groupResize.Controls.Add(this.buttonResize);
        this.groupResize.Controls.Add(this.labelListValue);
        this.groupResize.Controls.Add(this.numericListValue);
        this.groupResize.Controls.Add(this.buttonListAdd);
        this.groupResize.Name = "groupResize";
        this.groupResize.Location = new System.Drawing.Point(12, 172);
        this.groupResize.Size = new System.Drawing.Size(440, 150);
        this.groupResize.Text = "Redimensionar en tiempo de ejecución";
        // 
        // labelNewSize
        // 
        this.labelNewSize.Name = "labelNewSize";
        this.labelNewSize.Location = new System.Drawing.Point(15, 31);
        this.labelNewSize.AutoSize = true;
        this.labelNewSize.Text = "Nuevo tamaño:";
        // 
        // numericNewSize
        // 
        this.numericNewSize.Name = "numericNewSize";
        this.numericNewSize.Location = new System.Drawing.Point(160, 28);
        this.numericNewSize.Size = new System.Drawing.Size(80, 23);
        this.numericNewSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        this.numericNewSize.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        this.numericNewSize.Value = new decimal(new int[] { 10, 0, 0, 0 });
        // 
        // buttonResize
        // 
        this.buttonResize.Name = "buttonResize";
        this.buttonResize.Location = new System.Drawing.Point(260, 24);
        this.buttonResize.Size = new System.Drawing.Size(165, 30);
        this.buttonResize.Text = "Redimensionar arreglo";
        this.buttonResize.UseVisualStyleBackColor = true;
        this.buttonResize.Click += new System.EventHandler(this.ButtonResize_Click);
        // 
        // labelListValue
        // 
        this.labelListValue.Name = "labelListValue";
        this.labelListValue.Location = new System.Drawing.Point(15, 83);
        this.labelListValue.AutoSize = true;
        this.labelListValue.Text = "Valor a agregar:";
        // 
        // numericListValue
        // 
        this.numericListValue.Name = "numericListValue";
        this.numericListValue.Location = new System.Drawing.Point(160, 80);
        this.numericListValue.Size = new System.Drawing.Size(80, 23);
        this.numericListValue.Minimum = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
        this.numericListValue.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        this.numericListValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // buttonListAdd
        // 
        this.buttonListAdd.Name = "buttonListAdd";
        this.buttonListAdd.Location = new System.Drawing.Point(260, 76);
        this.buttonListAdd.Size = new System.Drawing.Size(165, 30);
        this.buttonListAdd.Text = "Agregar a List<int>";
        this.buttonListAdd.UseVisualStyleBackColor = true;
        this.buttonListAdd.Click += new System.EventHandler(this.ButtonListAdd_Click);
        // 
        // groupContent
        // 
        this.groupContent.Controls.Add(this.labelArrayInfo);
        this.groupContent.Controls.Add(this.labelListInfo);
        this.groupContent.Controls.Add(this.listBoxContent);
        this.groupContent.Name = "groupContent";
        this.groupContent.Location = new System.Drawing.Point(470, 12);
        this.groupContent.Size = new System.Drawing.Size(490, 310);
        this.groupContent.Text = "Estado actual en memoria";
        this.groupContent.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        // 
        // labelArrayInfo
        // 
        this.labelArrayInfo.Name = "labelArrayInfo";
        this.labelArrayInfo.Location = new System.Drawing.Point(15, 25);
        this.labelArrayInfo.AutoSize = true;
        this.labelArrayInfo.Text = "Arreglo: —";
        // 
        // labelListInfo
        // 
        this.labelListInfo.Name = "labelListInfo";
        this.labelListInfo.Location = new System.Drawing.Point(15, 48);
        this.labelListInfo.AutoSize = true;
        this.labelListInfo.Text = "List<int>: —";
        // 
        // listBoxContent
        // 
        this.listBoxContent.Name = "listBoxContent";
        this.listBoxContent.Location = new System.Drawing.Point(15, 75);
        this.listBoxContent.Size = new System.Drawing.Size(460, 225);
        this.listBoxContent.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.listBoxContent.FormattingEnabled = true;
        this.listBoxContent.ItemHeight = 15;
        this.listBoxContent.Font = new System.Drawing.Font("Consolas", 9.75F);
        // 
        // groupStaticLog
        // 
        this.groupStaticLog.Controls.Add(this.textBoxStaticLog);
        this.groupStaticLog.Name = "groupStaticLog";
        this.groupStaticLog.Location = new System.Drawing.Point(12, 332);
        this.groupStaticLog.Size = new System.Drawing.Size(948, 258);
        this.groupStaticLog.Text = "Bitácora de operaciones";
        this.groupStaticLog.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        // 
        // textBoxStaticLog
        // 
        this.textBoxStaticLog.Name = "textBoxStaticLog";
        this.textBoxStaticLog.Location = new System.Drawing.Point(3, 19);
        this.textBoxStaticLog.Size = new System.Drawing.Size(942, 236);
        this.textBoxStaticLog.Dock = System.Windows.Forms.DockStyle.Fill;
        this.textBoxStaticLog.Multiline = true;
        this.textBoxStaticLog.ReadOnly = true;
        this.textBoxStaticLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.textBoxStaticLog.Font = new System.Drawing.Font("Consolas", 9.75F);
        this.textBoxStaticLog.WordWrap = true;
        // 
        // groupObjects
        // 
        this.groupObjects.Controls.Add(this.labelStudentName);
        this.groupObjects.Controls.Add(this.textBoxStudentName);
        this.groupObjects.Controls.Add(this.labelStudentGrade);
        this.groupObjects.Controls.Add(this.numericGrade);
        this.groupObjects.Controls.Add(this.buttonCreateStudent);
        this.groupObjects.Controls.Add(this.buttonCreateAlias);
        this.groupObjects.Controls.Add(this.buttonModifyAlias);
        this.groupObjects.Controls.Add(this.buttonCopyStruct);
        this.groupObjects.Controls.Add(this.listBoxStudents);
        this.groupObjects.Name = "groupObjects";
        this.groupObjects.Location = new System.Drawing.Point(12, 12);
        this.groupObjects.Size = new System.Drawing.Size(440, 330);
        this.groupObjects.Text = "Instancias en el Heap (tipos por referencia)";
        // 
        // labelStudentName
        // 
        this.labelStudentName.Name = "labelStudentName";
        this.labelStudentName.Location = new System.Drawing.Point(15, 31);
        this.labelStudentName.AutoSize = true;
        this.labelStudentName.Text = "Nombre:";
        // 
        // textBoxStudentName
        // 
        this.textBoxStudentName.Name = "textBoxStudentName";
        this.textBoxStudentName.Location = new System.Drawing.Point(130, 28);
        this.textBoxStudentName.Size = new System.Drawing.Size(295, 23);
        this.textBoxStudentName.Text = "Ana";
        // 
        // labelStudentGrade
        // 
        this.labelStudentGrade.Name = "labelStudentGrade";
        this.labelStudentGrade.Location = new System.Drawing.Point(15, 63);
        this.labelStudentGrade.AutoSize = true;
        this.labelStudentGrade.Text = "Calificación:";
        // 
        // numericGrade
        // 
        this.numericGrade.Name = "numericGrade";
        this.numericGrade.Location = new System.Drawing.Point(130, 60);
        this.numericGrade.Size = new System.Drawing.Size(80, 23);
        this.numericGrade.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
        this.numericGrade.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
        this.numericGrade.Value = new decimal(new int[] { 90, 0, 0, 0 });
        this.numericGrade.DecimalPlaces = 1;
        // 
        // buttonCreateStudent
        // 
        this.buttonCreateStudent.Name = "buttonCreateStudent";
        this.buttonCreateStudent.Location = new System.Drawing.Point(15, 95);
        this.buttonCreateStudent.Size = new System.Drawing.Size(200, 30);
        this.buttonCreateStudent.Text = "Crear instancia (new)";
        this.buttonCreateStudent.UseVisualStyleBackColor = true;
        this.buttonCreateStudent.Click += new System.EventHandler(this.ButtonCreateStudent_Click);
        // 
        // buttonCreateAlias
        // 
        this.buttonCreateAlias.Name = "buttonCreateAlias";
        this.buttonCreateAlias.Location = new System.Drawing.Point(225, 95);
        this.buttonCreateAlias.Size = new System.Drawing.Size(200, 30);
        this.buttonCreateAlias.Text = "Crear alias de la selección";
        this.buttonCreateAlias.UseVisualStyleBackColor = true;
        this.buttonCreateAlias.Click += new System.EventHandler(this.ButtonCreateAlias_Click);
        // 
        // buttonModifyAlias
        // 
        this.buttonModifyAlias.Name = "buttonModifyAlias";
        this.buttonModifyAlias.Location = new System.Drawing.Point(15, 131);
        this.buttonModifyAlias.Size = new System.Drawing.Size(200, 30);
        this.buttonModifyAlias.Text = "Modificar mediante alias (+5)";
        this.buttonModifyAlias.UseVisualStyleBackColor = true;
        this.buttonModifyAlias.Click += new System.EventHandler(this.ButtonModifyAlias_Click);
        // 
        // buttonCopyStruct
        // 
        this.buttonCopyStruct.Name = "buttonCopyStruct";
        this.buttonCopyStruct.Location = new System.Drawing.Point(225, 131);
        this.buttonCopyStruct.Size = new System.Drawing.Size(200, 30);
        this.buttonCopyStruct.Text = "Comparar copia por valor";
        this.buttonCopyStruct.UseVisualStyleBackColor = true;
        this.buttonCopyStruct.Click += new System.EventHandler(this.ButtonCopyStruct_Click);
        // 
        // listBoxStudents
        // 
        this.listBoxStudents.Name = "listBoxStudents";
        this.listBoxStudents.Location = new System.Drawing.Point(15, 172);
        this.listBoxStudents.Size = new System.Drawing.Size(410, 148);
        this.listBoxStudents.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.listBoxStudents.FormattingEnabled = true;
        this.listBoxStudents.ItemHeight = 15;
        // 
        // groupLinkedList
        // 
        this.groupLinkedList.Controls.Add(this.labelNodeValue);
        this.groupLinkedList.Controls.Add(this.numericNodeValue);
        this.groupLinkedList.Controls.Add(this.buttonAddNode);
        this.groupLinkedList.Controls.Add(this.buttonRemoveFirst);
        this.groupLinkedList.Controls.Add(this.labelListContent);
        this.groupLinkedList.Name = "groupLinkedList";
        this.groupLinkedList.Location = new System.Drawing.Point(470, 12);
        this.groupLinkedList.Size = new System.Drawing.Size(490, 150);
        this.groupLinkedList.Text = "Lista enlazada (estructura dinámica)";
        this.groupLinkedList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        // 
        // labelNodeValue
        // 
        this.labelNodeValue.Name = "labelNodeValue";
        this.labelNodeValue.Location = new System.Drawing.Point(15, 31);
        this.labelNodeValue.AutoSize = true;
        this.labelNodeValue.Text = "Valor del nodo:";
        // 
        // numericNodeValue
        // 
        this.numericNodeValue.Name = "numericNodeValue";
        this.numericNodeValue.Location = new System.Drawing.Point(150, 28);
        this.numericNodeValue.Size = new System.Drawing.Size(100, 23);
        this.numericNodeValue.Minimum = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
        this.numericNodeValue.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        this.numericNodeValue.Value = new decimal(new int[] { 10, 0, 0, 0 });
        // 
        // buttonAddNode
        // 
        this.buttonAddNode.Name = "buttonAddNode";
        this.buttonAddNode.Location = new System.Drawing.Point(15, 65);
        this.buttonAddNode.Size = new System.Drawing.Size(200, 30);
        this.buttonAddNode.Text = "Insertar al final";
        this.buttonAddNode.UseVisualStyleBackColor = true;
        this.buttonAddNode.Click += new System.EventHandler(this.ButtonAddNode_Click);
        // 
        // buttonRemoveFirst
        // 
        this.buttonRemoveFirst.Name = "buttonRemoveFirst";
        this.buttonRemoveFirst.Location = new System.Drawing.Point(225, 65);
        this.buttonRemoveFirst.Size = new System.Drawing.Size(200, 30);
        this.buttonRemoveFirst.Text = "Eliminar el primero";
        this.buttonRemoveFirst.UseVisualStyleBackColor = true;
        this.buttonRemoveFirst.Click += new System.EventHandler(this.ButtonRemoveFirst_Click);
        // 
        // labelListContent
        // 
        this.labelListContent.Name = "labelListContent";
        this.labelListContent.Location = new System.Drawing.Point(15, 107);
        this.labelListContent.Size = new System.Drawing.Size(460, 35);
        this.labelListContent.Text = "Lista: (lista vacía)";
        this.labelListContent.AutoSize = false;
        // 
        // groupGc
        // 
        this.groupGc.Controls.Add(this.labelAllocateCount);
        this.groupGc.Controls.Add(this.numericAllocate);
        this.groupGc.Controls.Add(this.buttonAllocate);
        this.groupGc.Controls.Add(this.buttonRelease);
        this.groupGc.Controls.Add(this.buttonCollect);
        this.groupGc.Controls.Add(this.labelMemory);
        this.groupGc.Controls.Add(this.labelObjectsState);
        this.groupGc.Name = "groupGc";
        this.groupGc.Location = new System.Drawing.Point(470, 172);
        this.groupGc.Size = new System.Drawing.Size(490, 170);
        this.groupGc.Text = "Recolector de basura (GC)";
        this.groupGc.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        // 
        // labelAllocateCount
        // 
        this.labelAllocateCount.Name = "labelAllocateCount";
        this.labelAllocateCount.Location = new System.Drawing.Point(15, 31);
        this.labelAllocateCount.AutoSize = true;
        this.labelAllocateCount.Text = "Objetos a crear:";
        // 
        // numericAllocate
        // 
        this.numericAllocate.Name = "numericAllocate";
        this.numericAllocate.Location = new System.Drawing.Point(150, 28);
        this.numericAllocate.Size = new System.Drawing.Size(120, 23);
        this.numericAllocate.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
        this.numericAllocate.Maximum = new decimal(new int[] { 2000000, 0, 0, 0 });
        this.numericAllocate.Value = new decimal(new int[] { 200000, 0, 0, 0 });
        this.numericAllocate.Increment = new decimal(new int[] { 10000, 0, 0, 0 });
        // 
        // buttonAllocate
        // 
        this.buttonAllocate.Name = "buttonAllocate";
        this.buttonAllocate.Location = new System.Drawing.Point(15, 65);
        this.buttonAllocate.Size = new System.Drawing.Size(140, 30);
        this.buttonAllocate.Text = "Asignar objetos";
        this.buttonAllocate.UseVisualStyleBackColor = true;
        this.buttonAllocate.Click += new System.EventHandler(this.ButtonAllocate_Click);
        // 
        // buttonRelease
        // 
        this.buttonRelease.Name = "buttonRelease";
        this.buttonRelease.Location = new System.Drawing.Point(160, 65);
        this.buttonRelease.Size = new System.Drawing.Size(140, 30);
        this.buttonRelease.Text = "Liberar referencias";
        this.buttonRelease.UseVisualStyleBackColor = true;
        this.buttonRelease.Click += new System.EventHandler(this.ButtonRelease_Click);
        // 
        // buttonCollect
        // 
        this.buttonCollect.Name = "buttonCollect";
        this.buttonCollect.Location = new System.Drawing.Point(305, 65);
        this.buttonCollect.Size = new System.Drawing.Size(170, 30);
        this.buttonCollect.Text = "Ejecutar GC.Collect()";
        this.buttonCollect.UseVisualStyleBackColor = true;
        this.buttonCollect.Click += new System.EventHandler(this.ButtonCollect_Click);
        // 
        // labelMemory
        // 
        this.labelMemory.Name = "labelMemory";
        this.labelMemory.Location = new System.Drawing.Point(15, 112);
        this.labelMemory.Size = new System.Drawing.Size(460, 20);
        this.labelMemory.Text = "Memoria administrada: —";
        this.labelMemory.AutoSize = false;
        // 
        // labelObjectsState
        // 
        this.labelObjectsState.Name = "labelObjectsState";
        this.labelObjectsState.Location = new System.Drawing.Point(15, 138);
        this.labelObjectsState.Size = new System.Drawing.Size(460, 20);
        this.labelObjectsState.Text = "Estado de los objetos: —";
        this.labelObjectsState.AutoSize = false;
        // 
        // groupDynamicLog
        // 
        this.groupDynamicLog.Controls.Add(this.textBoxDynamicLog);
        this.groupDynamicLog.Name = "groupDynamicLog";
        this.groupDynamicLog.Location = new System.Drawing.Point(12, 352);
        this.groupDynamicLog.Size = new System.Drawing.Size(948, 238);
        this.groupDynamicLog.Text = "Bitácora de operaciones";
        this.groupDynamicLog.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        // 
        // textBoxDynamicLog
        // 
        this.textBoxDynamicLog.Name = "textBoxDynamicLog";
        this.textBoxDynamicLog.Location = new System.Drawing.Point(3, 19);
        this.textBoxDynamicLog.Size = new System.Drawing.Size(942, 236);
        this.textBoxDynamicLog.Dock = System.Windows.Forms.DockStyle.Fill;
        this.textBoxDynamicLog.Multiline = true;
        this.textBoxDynamicLog.ReadOnly = true;
        this.textBoxDynamicLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.textBoxDynamicLog.Font = new System.Drawing.Font("Consolas", 9.75F);
        this.textBoxDynamicLog.WordWrap = true;
        // 
        // groupParameters
        // 
        this.groupParameters.Controls.Add(this.labelArraySize);
        this.groupParameters.Controls.Add(this.numericArraySize);
        this.groupParameters.Controls.Add(this.labelScenario);
        this.groupParameters.Controls.Add(this.comboBoxScenario);
        this.groupParameters.Controls.Add(this.buttonRunComparison);
        this.groupParameters.Name = "groupParameters";
        this.groupParameters.Location = new System.Drawing.Point(12, 12);
        this.groupParameters.Size = new System.Drawing.Size(948, 80);
        this.groupParameters.Text = "Parámetros de la comparación (ordenamiento)";
        this.groupParameters.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        // 
        // labelArraySize
        // 
        this.labelArraySize.Name = "labelArraySize";
        this.labelArraySize.Location = new System.Drawing.Point(15, 35);
        this.labelArraySize.AutoSize = true;
        this.labelArraySize.Text = "Tamaño n:";
        // 
        // numericArraySize
        // 
        this.numericArraySize.Name = "numericArraySize";
        this.numericArraySize.Location = new System.Drawing.Point(90, 32);
        this.numericArraySize.Size = new System.Drawing.Size(100, 23);
        this.numericArraySize.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
        this.numericArraySize.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
        this.numericArraySize.Value = new decimal(new int[] { 5000, 0, 0, 0 });
        this.numericArraySize.Increment = new decimal(new int[] { 500, 0, 0, 0 });
        // 
        // labelScenario
        // 
        this.labelScenario.Name = "labelScenario";
        this.labelScenario.Location = new System.Drawing.Point(230, 35);
        this.labelScenario.AutoSize = true;
        this.labelScenario.Text = "Escenario:";
        // 
        // comboBoxScenario
        // 
        this.comboBoxScenario.Items.AddRange(new object[] {
            "Datos aleatorios",
            "Datos ya ordenados (mejor caso)",
            "Datos en orden inverso (peor caso)"});
        this.comboBoxScenario.Name = "comboBoxScenario";
        this.comboBoxScenario.Location = new System.Drawing.Point(305, 32);
        this.comboBoxScenario.Size = new System.Drawing.Size(220, 23);
        this.comboBoxScenario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.comboBoxScenario.FormattingEnabled = true;
        this.comboBoxScenario.SelectedIndex = 0;
        // 
        // buttonRunComparison
        // 
        this.buttonRunComparison.Name = "buttonRunComparison";
        this.buttonRunComparison.Location = new System.Drawing.Point(555, 28);
        this.buttonRunComparison.Size = new System.Drawing.Size(200, 32);
        this.buttonRunComparison.Text = "Ejecutar comparación";
        this.buttonRunComparison.UseVisualStyleBackColor = true;
        this.buttonRunComparison.Click += new System.EventHandler(this.ButtonRunComparison_Click);
        // 
        // groupResults
        // 
        this.groupResults.Controls.Add(this.listViewResults);
        this.groupResults.Name = "groupResults";
        this.groupResults.Location = new System.Drawing.Point(12, 102);
        this.groupResults.Size = new System.Drawing.Size(948, 140);
        this.groupResults.Text = "Resultados medidos";
        this.groupResults.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        // 
        // listViewResults
        // 
        this.listViewResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnAlgorithm,
            this.columnTime,
            this.columnSpace,
            this.columnComparisons,
            this.columnAssignments,
            this.columnElapsed});
        this.listViewResults.Name = "listViewResults";
        this.listViewResults.Location = new System.Drawing.Point(3, 19);
        this.listViewResults.Size = new System.Drawing.Size(942, 118);
        this.listViewResults.Dock = System.Windows.Forms.DockStyle.Fill;
        this.listViewResults.FullRowSelect = true;
        this.listViewResults.GridLines = true;
        this.listViewResults.HideSelection = false;
        this.listViewResults.UseCompatibleStateImageBehavior = false;
        this.listViewResults.View = System.Windows.Forms.View.Details;
        // 
        // columnAlgorithm
        // 
        this.columnAlgorithm.Name = "columnAlgorithm";
        this.columnAlgorithm.Text = "Algoritmo";
        this.columnAlgorithm.Width = 190;
        // 
        // columnTime
        // 
        this.columnTime.Name = "columnTime";
        this.columnTime.Text = "Tiempo teórico";
        this.columnTime.Width = 130;
        // 
        // columnSpace
        // 
        this.columnSpace.Name = "columnSpace";
        this.columnSpace.Text = "Espacio teórico";
        this.columnSpace.Width = 130;
        // 
        // columnComparisons
        // 
        this.columnComparisons.Name = "columnComparisons";
        this.columnComparisons.Text = "Comparaciones";
        this.columnComparisons.Width = 130;
        // 
        // columnAssignments
        // 
        this.columnAssignments.Name = "columnAssignments";
        this.columnAssignments.Text = "Asignaciones";
        this.columnAssignments.Width = 130;
        // 
        // columnElapsed
        // 
        this.columnElapsed.Name = "columnElapsed";
        this.columnElapsed.Text = "Tiempo real (ms)";
        this.columnElapsed.Width = 130;
        // 
        // groupAnalysis
        // 
        this.groupAnalysis.Controls.Add(this.textBoxAnalysis);
        this.groupAnalysis.Name = "groupAnalysis";
        this.groupAnalysis.Location = new System.Drawing.Point(12, 252);
        this.groupAnalysis.Size = new System.Drawing.Size(948, 338);
        this.groupAnalysis.Text = "Análisis de resultados";
        this.groupAnalysis.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        // 
        // textBoxAnalysis
        // 
        this.textBoxAnalysis.Name = "textBoxAnalysis";
        this.textBoxAnalysis.Location = new System.Drawing.Point(3, 19);
        this.textBoxAnalysis.Size = new System.Drawing.Size(942, 236);
        this.textBoxAnalysis.Dock = System.Windows.Forms.DockStyle.Fill;
        this.textBoxAnalysis.Multiline = true;
        this.textBoxAnalysis.ReadOnly = true;
        this.textBoxAnalysis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.textBoxAnalysis.Font = new System.Drawing.Font("Consolas", 9.75F);
        this.textBoxAnalysis.WordWrap = true;
        // 
        // MainForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(980, 680);
        this.Controls.Add(this.tabControlMain);
        this.Controls.Add(this.statusStrip);
        this.MinimumSize = new System.Drawing.Size(996, 719);
        this.Name = "MainForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Estructuras de datos – Unidad 1: Memoria y complejidad";
        ((System.ComponentModel.ISupportInitialize)(this.numericFixedSize)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numericIndex)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numericValue)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numericNewSize)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numericListValue)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numericGrade)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numericNodeValue)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numericAllocate)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numericArraySize)).EndInit();
        this.groupAnalysis.ResumeLayout(false);
        this.groupResults.ResumeLayout(false);
        this.groupParameters.ResumeLayout(false);
        this.groupDynamicLog.ResumeLayout(false);
        this.groupGc.ResumeLayout(false);
        this.groupLinkedList.ResumeLayout(false);
        this.groupObjects.ResumeLayout(false);
        this.groupStaticLog.ResumeLayout(false);
        this.groupContent.ResumeLayout(false);
        this.groupResize.ResumeLayout(false);
        this.groupFixedArray.ResumeLayout(false);
        this.tabAlgorithms.ResumeLayout(false);
        this.tabDynamicMemory.ResumeLayout(false);
        this.tabStaticMemory.ResumeLayout(false);
        this.statusStrip.ResumeLayout(false);
        this.statusStrip.PerformLayout();
        this.tabControlMain.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.TabControl tabControlMain;
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInfo;
    private System.Windows.Forms.TabPage tabStaticMemory;
    private System.Windows.Forms.TabPage tabDynamicMemory;
    private System.Windows.Forms.TabPage tabAlgorithms;
    private System.Windows.Forms.GroupBox groupFixedArray;
    private System.Windows.Forms.Label labelFixedSize;
    private System.Windows.Forms.NumericUpDown numericFixedSize;
    private System.Windows.Forms.Button buttonCreateFixed;
    private System.Windows.Forms.Label labelIndex;
    private System.Windows.Forms.NumericUpDown numericIndex;
    private System.Windows.Forms.Label labelValue;
    private System.Windows.Forms.NumericUpDown numericValue;
    private System.Windows.Forms.Button buttonAssign;
    private System.Windows.Forms.GroupBox groupResize;
    private System.Windows.Forms.Label labelNewSize;
    private System.Windows.Forms.NumericUpDown numericNewSize;
    private System.Windows.Forms.Button buttonResize;
    private System.Windows.Forms.Label labelListValue;
    private System.Windows.Forms.NumericUpDown numericListValue;
    private System.Windows.Forms.Button buttonListAdd;
    private System.Windows.Forms.GroupBox groupContent;
    private System.Windows.Forms.Label labelArrayInfo;
    private System.Windows.Forms.Label labelListInfo;
    private System.Windows.Forms.ListBox listBoxContent;
    private System.Windows.Forms.GroupBox groupStaticLog;
    private System.Windows.Forms.TextBox textBoxStaticLog;
    private System.Windows.Forms.GroupBox groupObjects;
    private System.Windows.Forms.Label labelStudentName;
    private System.Windows.Forms.TextBox textBoxStudentName;
    private System.Windows.Forms.Label labelStudentGrade;
    private System.Windows.Forms.NumericUpDown numericGrade;
    private System.Windows.Forms.Button buttonCreateStudent;
    private System.Windows.Forms.Button buttonCreateAlias;
    private System.Windows.Forms.Button buttonModifyAlias;
    private System.Windows.Forms.Button buttonCopyStruct;
    private System.Windows.Forms.ListBox listBoxStudents;
    private System.Windows.Forms.GroupBox groupLinkedList;
    private System.Windows.Forms.Label labelNodeValue;
    private System.Windows.Forms.NumericUpDown numericNodeValue;
    private System.Windows.Forms.Button buttonAddNode;
    private System.Windows.Forms.Button buttonRemoveFirst;
    private System.Windows.Forms.Label labelListContent;
    private System.Windows.Forms.GroupBox groupGc;
    private System.Windows.Forms.Label labelAllocateCount;
    private System.Windows.Forms.NumericUpDown numericAllocate;
    private System.Windows.Forms.Button buttonAllocate;
    private System.Windows.Forms.Button buttonRelease;
    private System.Windows.Forms.Button buttonCollect;
    private System.Windows.Forms.Label labelMemory;
    private System.Windows.Forms.Label labelObjectsState;
    private System.Windows.Forms.GroupBox groupDynamicLog;
    private System.Windows.Forms.TextBox textBoxDynamicLog;
    private System.Windows.Forms.GroupBox groupParameters;
    private System.Windows.Forms.Label labelArraySize;
    private System.Windows.Forms.NumericUpDown numericArraySize;
    private System.Windows.Forms.Label labelScenario;
    private System.Windows.Forms.ComboBox comboBoxScenario;
    private System.Windows.Forms.Button buttonRunComparison;
    private System.Windows.Forms.GroupBox groupResults;
    private System.Windows.Forms.ListView listViewResults;
    private System.Windows.Forms.ColumnHeader columnAlgorithm;
    private System.Windows.Forms.ColumnHeader columnTime;
    private System.Windows.Forms.ColumnHeader columnSpace;
    private System.Windows.Forms.ColumnHeader columnComparisons;
    private System.Windows.Forms.ColumnHeader columnAssignments;
    private System.Windows.Forms.ColumnHeader columnElapsed;
    private System.Windows.Forms.GroupBox groupAnalysis;
    private System.Windows.Forms.TextBox textBoxAnalysis;
}
