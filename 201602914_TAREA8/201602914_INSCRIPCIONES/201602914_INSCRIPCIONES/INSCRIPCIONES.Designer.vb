<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INSCRIPCIONES
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(INSCRIPCIONES))
        Me.TXT_NOMBRE = New System.Windows.Forms.TextBox()
        Me.TXT_CARNET = New System.Windows.Forms.TextBox()
        Me.CMB_CARRERA = New System.Windows.Forms.ComboBox()
        Me.RBN_BASICO = New System.Windows.Forms.RadioButton()
        Me.RBN_DIVERSIFICADO = New System.Windows.Forms.RadioButton()
        Me.CMB_PAGO = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BTN_LIMPIAR = New System.Windows.Forms.Button()
        Me.BTN_LIMPIARM = New System.Windows.Forms.Button()
        Me.BTN_RMOSTRAR = New System.Windows.Forms.Button()
        Me.BTN_GUARDAR = New System.Windows.Forms.Button()
        Me.BTN_SALIR = New System.Windows.Forms.Button()
        Me.BTN_TOTALES = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXT_NOMBRE
        '
        resources.ApplyResources(Me.TXT_NOMBRE, "TXT_NOMBRE")
        Me.TXT_NOMBRE.Name = "TXT_NOMBRE"
        '
        'TXT_CARNET
        '
        resources.ApplyResources(Me.TXT_CARNET, "TXT_CARNET")
        Me.TXT_CARNET.Name = "TXT_CARNET"
        '
        'CMB_CARRERA
        '
        resources.ApplyResources(Me.CMB_CARRERA, "CMB_CARRERA")
        Me.CMB_CARRERA.FormattingEnabled = True
        Me.CMB_CARRERA.Items.AddRange(New Object() {resources.GetString("CMB_CARRERA.Items"), resources.GetString("CMB_CARRERA.Items1"), resources.GetString("CMB_CARRERA.Items2"), resources.GetString("CMB_CARRERA.Items3")})
        Me.CMB_CARRERA.Name = "CMB_CARRERA"
        '
        'RBN_BASICO
        '
        resources.ApplyResources(Me.RBN_BASICO, "RBN_BASICO")
        Me.RBN_BASICO.Name = "RBN_BASICO"
        Me.RBN_BASICO.TabStop = True
        Me.RBN_BASICO.UseVisualStyleBackColor = True
        '
        'RBN_DIVERSIFICADO
        '
        resources.ApplyResources(Me.RBN_DIVERSIFICADO, "RBN_DIVERSIFICADO")
        Me.RBN_DIVERSIFICADO.Name = "RBN_DIVERSIFICADO"
        Me.RBN_DIVERSIFICADO.TabStop = True
        Me.RBN_DIVERSIFICADO.UseVisualStyleBackColor = True
        '
        'CMB_PAGO
        '
        resources.ApplyResources(Me.CMB_PAGO, "CMB_PAGO")
        Me.CMB_PAGO.FormattingEnabled = True
        Me.CMB_PAGO.Items.AddRange(New Object() {resources.GetString("CMB_PAGO.Items"), resources.GetString("CMB_PAGO.Items1"), resources.GetString("CMB_PAGO.Items2"), resources.GetString("CMB_PAGO.Items3")})
        Me.CMB_PAGO.Name = "CMB_PAGO"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TXT_NOMBRE)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TXT_CARNET)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.RBN_BASICO)
        Me.GroupBox2.Controls.Add(Me.RBN_DIVERSIFICADO)
        Me.GroupBox2.Controls.Add(Me.CMB_CARRERA)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox3.Controls.Add(Me.CMB_PAGO)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'BTN_LIMPIAR
        '
        Me.BTN_LIMPIAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.BTN_LIMPIAR, "BTN_LIMPIAR")
        Me.BTN_LIMPIAR.Name = "BTN_LIMPIAR"
        Me.BTN_LIMPIAR.UseVisualStyleBackColor = False
        '
        'BTN_LIMPIARM
        '
        Me.BTN_LIMPIARM.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.BTN_LIMPIARM, "BTN_LIMPIARM")
        Me.BTN_LIMPIARM.Name = "BTN_LIMPIARM"
        Me.BTN_LIMPIARM.UseVisualStyleBackColor = False
        '
        'BTN_RMOSTRAR
        '
        Me.BTN_RMOSTRAR.BackColor = System.Drawing.Color.Gray
        resources.ApplyResources(Me.BTN_RMOSTRAR, "BTN_RMOSTRAR")
        Me.BTN_RMOSTRAR.Name = "BTN_RMOSTRAR"
        Me.BTN_RMOSTRAR.UseVisualStyleBackColor = False
        '
        'BTN_GUARDAR
        '
        Me.BTN_GUARDAR.BackColor = System.Drawing.Color.SpringGreen
        resources.ApplyResources(Me.BTN_GUARDAR, "BTN_GUARDAR")
        Me.BTN_GUARDAR.Name = "BTN_GUARDAR"
        Me.BTN_GUARDAR.UseVisualStyleBackColor = False
        '
        'BTN_SALIR
        '
        Me.BTN_SALIR.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.BTN_SALIR, "BTN_SALIR")
        Me.BTN_SALIR.Name = "BTN_SALIR"
        Me.BTN_SALIR.UseVisualStyleBackColor = False
        '
        'BTN_TOTALES
        '
        Me.BTN_TOTALES.BackColor = System.Drawing.Color.Yellow
        resources.ApplyResources(Me.BTN_TOTALES, "BTN_TOTALES")
        Me.BTN_TOTALES.Name = "BTN_TOTALES"
        Me.BTN_TOTALES.UseVisualStyleBackColor = False
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        resources.ApplyResources(Me.DataGridView1, "DataGridView1")
        Me.DataGridView1.Name = "DataGridView1"
        '
        'Column1
        '
        resources.ApplyResources(Me.Column1, "Column1")
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        resources.ApplyResources(Me.Column2, "Column2")
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        resources.ApplyResources(Me.Column3, "Column3")
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        resources.ApplyResources(Me.Column4, "Column4")
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        resources.ApplyResources(Me.Column5, "Column5")
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        resources.ApplyResources(Me.Column6, "Column6")
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        resources.ApplyResources(Me.Column7, "Column7")
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        resources.ApplyResources(Me.Column8, "Column8")
        Me.Column8.Name = "Column8"
        '
        'INSCRIPCIONES
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BTN_TOTALES)
        Me.Controls.Add(Me.BTN_RMOSTRAR)
        Me.Controls.Add(Me.BTN_SALIR)
        Me.Controls.Add(Me.BTN_LIMPIAR)
        Me.Controls.Add(Me.BTN_LIMPIARM)
        Me.Controls.Add(Me.BTN_GUARDAR)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "INSCRIPCIONES"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXT_NOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents TXT_CARNET As System.Windows.Forms.TextBox
    Friend WithEvents CMB_CARRERA As System.Windows.Forms.ComboBox
    Friend WithEvents RBN_BASICO As System.Windows.Forms.RadioButton
    Friend WithEvents RBN_DIVERSIFICADO As System.Windows.Forms.RadioButton
    Friend WithEvents CMB_PAGO As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BTN_LIMPIAR As System.Windows.Forms.Button
    Friend WithEvents BTN_LIMPIARM As System.Windows.Forms.Button
    Friend WithEvents BTN_RMOSTRAR As System.Windows.Forms.Button
    Friend WithEvents BTN_GUARDAR As System.Windows.Forms.Button
    Friend WithEvents BTN_SALIR As System.Windows.Forms.Button
    Friend WithEvents BTN_TOTALES As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
