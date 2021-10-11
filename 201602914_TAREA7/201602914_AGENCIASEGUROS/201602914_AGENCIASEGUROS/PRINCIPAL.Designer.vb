<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRINCIPAL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PRINCIPAL))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CMB_TALLER = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_MONTO = New System.Windows.Forms.TextBox()
        Me.CMB_COD = New System.Windows.Forms.GroupBox()
        Me.CMB_CODIGO = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CMB_GENERO = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_EDAD = New System.Windows.Forms.TextBox()
        Me.BTN_GUARDAR = New System.Windows.Forms.Button()
        Me.BTN_RMOSTRAR = New System.Windows.Forms.Button()
        Me.BTN_LIMPIARV = New System.Windows.Forms.Button()
        Me.BTN_ESTADÍSTICAS = New System.Windows.Forms.Button()
        Me.BTN_SALIR = New System.Windows.Forms.Button()
        Me.BTN_LIMPIAR = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.CMB_COD.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.CMB_COD)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CMB_GENERO)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TXT_EDAD)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(32, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(700, 174)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INFORMACIÓN DEL CONDUCTOR"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CMB_TALLER)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TXT_MONTO)
        Me.GroupBox3.Location = New System.Drawing.Point(356, 10)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(338, 158)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ACCIDENTE"
        '
        'CMB_TALLER
        '
        Me.CMB_TALLER.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMB_TALLER.FormattingEnabled = True
        Me.CMB_TALLER.Items.AddRange(New Object() {"TALLER DE CONFIANZA", "PROPORCIONADO POR ASEGURADORA"})
        Me.CMB_TALLER.Location = New System.Drawing.Point(93, 83)
        Me.CMB_TALLER.Name = "CMB_TALLER"
        Me.CMB_TALLER.Size = New System.Drawing.Size(231, 21)
        Me.CMB_TALLER.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "TALLER:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(214, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "MONTO DE LOS DAÑOS OCASIONADOS:"
        '
        'TXT_MONTO
        '
        Me.TXT_MONTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_MONTO.Location = New System.Drawing.Point(224, 32)
        Me.TXT_MONTO.Name = "TXT_MONTO"
        Me.TXT_MONTO.Size = New System.Drawing.Size(100, 20)
        Me.TXT_MONTO.TabIndex = 6
        '
        'CMB_COD
        '
        Me.CMB_COD.Controls.Add(Me.CMB_CODIGO)
        Me.CMB_COD.Controls.Add(Me.Label4)
        Me.CMB_COD.Controls.Add(Me.Label3)
        Me.CMB_COD.Location = New System.Drawing.Point(196, 28)
        Me.CMB_COD.Name = "CMB_COD"
        Me.CMB_COD.Size = New System.Drawing.Size(154, 106)
        Me.CMB_COD.TabIndex = 4
        Me.CMB_COD.TabStop = False
        Me.CMB_COD.Text = "CÓDIGO DE REGISTRO"
        '
        'CMB_CODIGO
        '
        Me.CMB_CODIGO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMB_CODIGO.FormattingEnabled = True
        Me.CMB_CODIGO.Items.AddRange(New Object() {"1", "0"})
        Me.CMB_CODIGO.Location = New System.Drawing.Point(27, 28)
        Me.CMB_CODIGO.Name = "CMB_CODIGO"
        Me.CMB_CODIGO.Size = New System.Drawing.Size(78, 21)
        Me.CMB_CODIGO.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "0 (extranjeros)**"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "**1 (Licencia guatemalteca)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "GÉNERO"
        '
        'CMB_GENERO
        '
        Me.CMB_GENERO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMB_GENERO.FormattingEnabled = True
        Me.CMB_GENERO.Items.AddRange(New Object() {"MASCULINO", "FEMENINO"})
        Me.CMB_GENERO.Location = New System.Drawing.Point(74, 83)
        Me.CMB_GENERO.Name = "CMB_GENERO"
        Me.CMB_GENERO.Size = New System.Drawing.Size(100, 21)
        Me.CMB_GENERO.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "EDAD:"
        '
        'TXT_EDAD
        '
        Me.TXT_EDAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_EDAD.Location = New System.Drawing.Point(74, 42)
        Me.TXT_EDAD.Name = "TXT_EDAD"
        Me.TXT_EDAD.Size = New System.Drawing.Size(100, 20)
        Me.TXT_EDAD.TabIndex = 0
        '
        'BTN_GUARDAR
        '
        Me.BTN_GUARDAR.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.BTN_GUARDAR.Location = New System.Drawing.Point(309, 221)
        Me.BTN_GUARDAR.Name = "BTN_GUARDAR"
        Me.BTN_GUARDAR.Size = New System.Drawing.Size(167, 44)
        Me.BTN_GUARDAR.TabIndex = 1
        Me.BTN_GUARDAR.Text = "GUARDAR REGISTRO"
        Me.BTN_GUARDAR.UseVisualStyleBackColor = False
        '
        'BTN_RMOSTRAR
        '
        Me.BTN_RMOSTRAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTN_RMOSTRAR.Location = New System.Drawing.Point(309, 281)
        Me.BTN_RMOSTRAR.Name = "BTN_RMOSTRAR"
        Me.BTN_RMOSTRAR.Size = New System.Drawing.Size(167, 41)
        Me.BTN_RMOSTRAR.TabIndex = 2
        Me.BTN_RMOSTRAR.Text = "MOSTRAR REGISTROS"
        Me.BTN_RMOSTRAR.UseVisualStyleBackColor = False
        '
        'BTN_LIMPIARV
        '
        Me.BTN_LIMPIARV.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTN_LIMPIARV.Location = New System.Drawing.Point(32, 281)
        Me.BTN_LIMPIARV.Name = "BTN_LIMPIARV"
        Me.BTN_LIMPIARV.Size = New System.Drawing.Size(155, 41)
        Me.BTN_LIMPIARV.TabIndex = 3
        Me.BTN_LIMPIARV.Text = "LIMPIAR VECTORES"
        Me.BTN_LIMPIARV.UseVisualStyleBackColor = False
        '
        'BTN_ESTADÍSTICAS
        '
        Me.BTN_ESTADÍSTICAS.BackColor = System.Drawing.Color.HotPink
        Me.BTN_ESTADÍSTICAS.Location = New System.Drawing.Point(595, 291)
        Me.BTN_ESTADÍSTICAS.Name = "BTN_ESTADÍSTICAS"
        Me.BTN_ESTADÍSTICAS.Size = New System.Drawing.Size(155, 33)
        Me.BTN_ESTADÍSTICAS.TabIndex = 4
        Me.BTN_ESTADÍSTICAS.Text = "ESTADÍSTICAS"
        Me.BTN_ESTADÍSTICAS.UseVisualStyleBackColor = False
        '
        'BTN_SALIR
        '
        Me.BTN_SALIR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_SALIR.Location = New System.Drawing.Point(648, 437)
        Me.BTN_SALIR.Name = "BTN_SALIR"
        Me.BTN_SALIR.Size = New System.Drawing.Size(114, 34)
        Me.BTN_SALIR.TabIndex = 5
        Me.BTN_SALIR.Text = "SALIR"
        Me.BTN_SALIR.UseVisualStyleBackColor = False
        '
        'BTN_LIMPIAR
        '
        Me.BTN_LIMPIAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTN_LIMPIAR.Location = New System.Drawing.Point(32, 221)
        Me.BTN_LIMPIAR.Name = "BTN_LIMPIAR"
        Me.BTN_LIMPIAR.Size = New System.Drawing.Size(155, 37)
        Me.BTN_LIMPIAR.TabIndex = 6
        Me.BTN_LIMPIAR.Text = "LIMPIAR ENTRADAS"
        Me.BTN_LIMPIAR.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(32, 330)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(593, 150)
        Me.DataGridView1.TabIndex = 7
        '
        'Column1
        '
        Me.Column1.HeaderText = "EDAD"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "GÉNERO"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "CÓDIGO REGISTRO"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 75
        '
        'Column4
        '
        Me.Column4.HeaderText = "MONTO DE DAÑOS OCASIONADOS"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "TALLER"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "DEDUCIBLE A PAGAR"
        Me.Column6.Name = "Column6"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(595, 211)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(155, 80)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PRINCIPAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(774, 492)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BTN_LIMPIAR)
        Me.Controls.Add(Me.BTN_SALIR)
        Me.Controls.Add(Me.BTN_ESTADÍSTICAS)
        Me.Controls.Add(Me.BTN_LIMPIARV)
        Me.Controls.Add(Me.BTN_RMOSTRAR)
        Me.Controls.Add(Me.BTN_GUARDAR)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PRINCIPAL"
        Me.Text = "PRINCIPAL"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.CMB_COD.ResumeLayout(False)
        Me.CMB_COD.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CMB_TALLER As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXT_MONTO As System.Windows.Forms.TextBox
    Friend WithEvents CMB_COD As System.Windows.Forms.GroupBox
    Friend WithEvents CMB_CODIGO As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CMB_GENERO As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXT_EDAD As System.Windows.Forms.TextBox
    Friend WithEvents BTN_GUARDAR As System.Windows.Forms.Button
    Friend WithEvents BTN_RMOSTRAR As System.Windows.Forms.Button
    Friend WithEvents BTN_LIMPIARV As System.Windows.Forms.Button
    Friend WithEvents BTN_ESTADÍSTICAS As System.Windows.Forms.Button
    Friend WithEvents BTN_SALIR As System.Windows.Forms.Button
    Friend WithEvents BTN_LIMPIAR As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
